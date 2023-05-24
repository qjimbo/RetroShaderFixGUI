using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NMSVersionDll;

namespace RetroShaderFixGUI
{
    public partial class SelectVersionForm : Form
    {
        public NMSUpdate? SelectedVersion { get; set; }

        public SelectVersionForm(string path)
        {
            InitializeComponent();
            lblPath.Text = path;
            pbIcon.Image = SystemIcons.Question.ToBitmap();
        }

        private void btnSkip_Click(object sender, EventArgs e)
        {
            // Skip
            SelectedVersion = null;
            this.Close();
        }

        private void btnRelease_Click(object sender, EventArgs e)
        {
            // Release
            SelectedVersion = NMSUpdate.Release;
            this.Close();
        }

        private void btnFoundation_Click(object sender, EventArgs e)
        {
            // Foundation
            SelectedVersion = NMSUpdate.Foundation;
            this.Close();
        }

        private void btnPathFinder_Click(object sender, EventArgs e)
        {
            // Path Finder
            SelectedVersion = NMSUpdate.PathFinder;
            this.Close();
        }

        private void btnAtlasRises_Click(object sender, EventArgs e)
        {
            // Atlas Rises
            SelectedVersion = NMSUpdate.AtlasRises;
            this.Close();
        }
    }
}
