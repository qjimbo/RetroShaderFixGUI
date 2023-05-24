using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Management;
using System.IO;
using Microsoft.WindowsAPICodePack.Dialogs;
using System.Threading;
using System.Reflection;
using NMSVersionDll;

namespace RetroShaderFixGUI
{
    public partial class MainForm : Form
    {
        // GLOBALS
        public enum GraphicsCard
        {
            None,
            AMD,
            nVidia
        }

        public List<string> GraphicsCards = new List<string>();
        public GraphicsCard GraphicsCardMode = GraphicsCard.None;
        public List<string> ScanResults = new List<string>();

        // UI
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void MainForm_Shown(object sender, EventArgs e)
        {            
            txtSystemInformation.Focus();
            
            // Help
            txtHelp.Text = Properties.Resources.Information;
            txtHelp.SelectionLength = 0;

            // Current Path
            txtPath.Text = Directory.GetCurrentDirectory();

            // Scan for Graphics Cards
            txtSystemInformation.Text += "Detected Graphics Cards:" + Environment.NewLine;
            ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT * FROM Win32_VideoController");
            foreach (ManagementObject obj in searcher.Get())
            {
                string graphicsCard = obj["Name"].ToString();
                GraphicsCards.Add(graphicsCard);
                txtSystemInformation.Text += "* " + graphicsCard + Environment.NewLine;
                if (graphicsCard.ToLower().Contains("amd ")) 
                {
                    rbAMD.Checked = true;
                    GraphicsCardMode = GraphicsCard.AMD;
                }

                if (graphicsCard.ToLower().Contains("nvidia "))
                {
                    rbNVIDIA.Checked = true;
                    GraphicsCardMode = GraphicsCard.nVidia;
                }
                
            }
            txtSystemInformation.Text += "RetroShaderFix Shader Update Mode: " + GraphicsCardMode.ToString() + Environment.NewLine;
        }

        private void btnPath_Click(object sender, EventArgs e)
        {
            // Pick Path
            CommonOpenFileDialog dialog = new CommonOpenFileDialog();
            dialog.InitialDirectory = txtPath.Text;
            dialog.IsFolderPicker = true;
            if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
                txtPath.Text = dialog.FileName;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            btnStart.Enabled = false;
            string path = txtPath.Text;
            WriteToLog("Starting Scan of " + path);
            Thread scanningThread = new Thread(() =>
            {
                // Start scanning the root folder recursively
                ScanFolder(path, true);
            });
            scanningThread.Start();
        }

        private void rbNone_Click(object sender, EventArgs e)
        {
            GraphicsCardMode = GraphicsCard.None;
            btnStart.Enabled = false;
        }

        private void rbAMD_CheckedChanged(object sender, EventArgs e)
        {
            GraphicsCardMode = GraphicsCard.AMD;
            btnStart.Enabled = true;
        }

        private void rbNVIDIA_CheckedChanged(object sender, EventArgs e)
        {
            GraphicsCardMode = GraphicsCard.nVidia;
            btnStart.Enabled = true;
        }

        // LOGIC
        public void WriteToLog(string text)
        {
            string date = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

            this.Invoke((MethodInvoker)delegate()
            {
                txtLog.AppendText("[" + date + "] " + text + Environment.NewLine);
                File.AppendAllText(Path.Combine(Path.GetDirectoryName(Assembly.GetEntryAssembly().Location), "log.txt"), "[" + date + "] " + text + Environment.NewLine);

            });
        }

        private void ScanFolder(string folderPath, bool initial = false)
        {
            // Update the label to show the current scanning path
            UpdateLabel(folderPath);

            try
            {
                // Scan all files in the current folder
                foreach (string filePath in Directory.GetFiles(folderPath))
                {
                    // Check if the current file is the one we're looking for
                    if (Path.GetFileName(filePath).Equals("NMS.exe", StringComparison.OrdinalIgnoreCase))
                    {
                        WriteToLog("Found NMS.exe at " + filePath);
                        ScanResults.Add(filePath);                        
                    }
                }

                // Recursively scan all subfolders in the current folder
                foreach (string subFolderPath in Directory.GetDirectories(folderPath))
                {
                    ScanFolder(subFolderPath);
                }
            }
            catch (Exception ex)
            {
                // Handle any exceptions that occur during scanning
                WriteToLog("Error in folder " + folderPath + ": " + ex.Message);
            }
            if (initial)
            {
                UpdateLabel("Scan Complete");
                WriteToLog("Scan Complete");                
                this.Invoke((MethodInvoker)delegate()
                { // Threadsafe
                    ApplyFixes();
                    btnStart.Enabled = true;
                });
            }
        }

        private void UpdateLabel(string labelText)
        {
            // Update the label on the UI thread (assuming this is a WinForms or WPF app)
            // This will need to be modified if you're using a different UI framework
            lblScan.Invoke((MethodInvoker)(() => lblScan.Text = labelText));
        }

        private void ApplyFixes()
        {
            WriteToLog("Applying Fixes");
            foreach (var filePath in ScanResults)
            {                
                var version = NMSVersionDll.Version.GetVersionInfo(filePath);
                NMSUpdate? update = null;
                if (version == null)
                {
                    // Unable to identify
                    var selectVersion = new SelectVersionForm(filePath);
                    selectVersion.ShowDialog();
                    if (selectVersion.SelectedVersion != null)
                    {
                        update = selectVersion.SelectedVersion.Value;
                        WriteToLog(filePath + " specified by user is version " + update);
                    }                    
                }
                else
                {
                    update = version.UPDATE;
                    WriteToLog(filePath + " is " + version.PLATFORM.ToString() + " version " + version.VERSION + " " + version.UPDATE);
                }

                if(update == null)
                {
                    WriteToLog(filePath + " skipped");
                    continue;
                }

                string gameDataFolderPath = Path.Combine(Path.GetDirectoryName(Path.GetDirectoryName(filePath)), "GAMEDATA\\", "PCBANKS\\");
                string shaderCachePath = Path.Combine(Path.GetDirectoryName(Path.GetDirectoryName(filePath)), "GAMEDATA\\", "SHADERCACHE\\");
                string modsFolderPath = Path.Combine(gameDataFolderPath, "MODS\\");
                string disableModsFile = Path.Combine(gameDataFolderPath, "DISABLEMODS.TXT");

                bool madeChange = false;
                // RELEASE
                if (update == NMSUpdate.Release)
                {
                    if (GraphicsCardMode == GraphicsCard.AMD)
                    {
                        madeChange = true;
                        // Universal
                        ExtractSingleFileFromPAKs("Universal.AMDSpaceMapHorizon.pak", gameDataFolderPath);
                        // Release AMDFragData
                        ExtractSingleFileFromPAKs("Release.AMDFragData.pak", gameDataFolderPath);
                    }
                }

                // FOUNDATION
                if (update == NMSUpdate.Foundation)
                {
                    bool hasModsFolder = false;
                    if (File.Exists(disableModsFile) || Directory.Exists(modsFolderPath)) // Some foundation versions use mods folder, others don't               
                        hasModsFolder = true;

                    if(hasModsFolder && File.Exists(disableModsFile))
                    { 
                        WriteToLog("Deleting DISABLEMODS.TXT (" + disableModsFile + ")");
                        File.Delete(disableModsFile);
                    }

                    if (GraphicsCardMode == GraphicsCard.AMD)
                    {
                        madeChange = true;
                        // Universal
                        ExtractSingleFileFromPAKs("Universal.AMDSpaceMapHorizon.pak", hasModsFolder ? modsFolderPath : gameDataFolderPath);
                        // Texture Array
                        ExtractSingleFileFromPAKs("Foundations.AMDTextureArray.pak", hasModsFolder ? modsFolderPath : gameDataFolderPath);
                    }
                    if (GraphicsCardMode == GraphicsCard.nVidia)
                    {
                        madeChange = true;
                        // Frag Data
                        ExtractSingleFileFromPAKs("Foundations.NVIDIAFragData.pak", hasModsFolder ? modsFolderPath : gameDataFolderPath);
                    }
                }

                // PATH FINDER
                if (update == NMSUpdate.PathFinder)
                {
                    if (File.Exists(disableModsFile))
                    {
                        WriteToLog("Deleting DISABLEMODS.TXT (" + disableModsFile + ")");
                        File.Delete(disableModsFile);
                    }

                    if (GraphicsCardMode == GraphicsCard.AMD)
                    {
                        madeChange = true;
                        // Universal
                        ExtractSingleFileFromPAKs("Universal.AMDSpaceMapHorizon.pak", modsFolderPath);
                        // Texture Array
                        ExtractSingleFileFromPAKs("Pathfinder.AMDTextureArray.pak", modsFolderPath);
                    }
                    if (GraphicsCardMode == GraphicsCard.nVidia)
                    {
                        madeChange = true;
                        // Frag Data
                        ExtractSingleFileFromPAKs("Pathfinder.NVIDIAFragData.pak", modsFolderPath);
                    }
                }

                // PATH FINDER
                if (update == NMSUpdate.AtlasRises)
                {
                    if (File.Exists(disableModsFile))
                    {
                        WriteToLog("Deleting DISABLEMODS.TXT (" + disableModsFile + ")");
                        File.Delete(disableModsFile);
                    }

                    if (GraphicsCardMode == GraphicsCard.AMD)
                    {
                        madeChange = true;
                        // Universal
                        ExtractSingleFileFromPAKs("Universal.AMDSpaceMapHorizon.pak", modsFolderPath);
                        // Texture Array
                        ExtractSingleFileFromPAKs("AtlasRises.AMDTextureArray.pak", modsFolderPath);
                    }
                }

                if (madeChange)
                {
                    if (Directory.Exists(shaderCachePath))
                    {
                        WriteToLog("Deleting SHADERCACHE (" + shaderCachePath + ")");
                        Directory.Delete(shaderCachePath, true);
                    }
                }
                else
                {
                    WriteToLog("No Fixes Required");
                }
            }
            WriteToLog("Apply Fixes Complete");
        }

        public void ExtractSingleFileFromPAKs(string fileName, string outputPath)
        {
            WriteToLog("Extracting " + fileName + " to " + outputPath);

            var outputFileName = "zzzzzzzzzzzzz" + fileName;

            // Get the assembly that contains the embedded resources.
            Assembly assembly = Assembly.GetExecutingAssembly();

            // Construct the full resource name for the file.
            string resourceName = "RetroShaderFixGUI.PAKs." + fileName;

            // Get the resource stream.
            using (Stream resourceStream = assembly.GetManifestResourceStream(resourceName))
            {
                // Create any necessary subdirectories for the file.
                if (!Directory.Exists(outputPath))
                {
                    Directory.CreateDirectory(outputPath);
                }

                // Extract the resource to a file.
                using (FileStream fileStream = new FileStream(Path.Combine(outputPath, outputFileName), FileMode.Create))
                {
                    resourceStream.CopyTo(fileStream);
                }
            }
        }


    }
}
