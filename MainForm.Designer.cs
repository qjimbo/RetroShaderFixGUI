namespace RetroShaderFixGUI
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtHelp = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSystemInformation = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbNVIDIA = new System.Windows.Forms.RadioButton();
            this.rbAMD = new System.Windows.Forms.RadioButton();
            this.rbNone = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.txtLog = new System.Windows.Forms.TextBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnPath = new System.Windows.Forms.Button();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblScan = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(3, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "RetroShaderFix by EthanRDoesMC";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(391, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(195, 30);
            this.panel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(391, 48);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(195, 30);
            this.panel2.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(3, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(185, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "RetroShaderFixGUI v1.02 by Qjimbo";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtHelp);
            this.groupBox1.Location = new System.Drawing.Point(15, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(370, 102);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "RetroShaderFix Information";
            // 
            // txtHelp
            // 
            this.txtHelp.Location = new System.Drawing.Point(6, 19);
            this.txtHelp.Multiline = true;
            this.txtHelp.Name = "txtHelp";
            this.txtHelp.ReadOnly = true;
            this.txtHelp.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtHelp.Size = new System.Drawing.Size(358, 74);
            this.txtHelp.TabIndex = 0;
            this.txtHelp.Text = "Information";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.label4);
            this.panel3.Location = new System.Drawing.Point(391, 84);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(195, 30);
            this.panel3.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.ForeColor = System.Drawing.Color.Green;
            this.label4.Location = new System.Drawing.Point(6, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(182, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "v1.00 PAKs [Feb 14 2023]";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtSystemInformation
            // 
            this.txtSystemInformation.Location = new System.Drawing.Point(6, 19);
            this.txtSystemInformation.Multiline = true;
            this.txtSystemInformation.Name = "txtSystemInformation";
            this.txtSystemInformation.ReadOnly = true;
            this.txtSystemInformation.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtSystemInformation.Size = new System.Drawing.Size(559, 98);
            this.txtSystemInformation.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbNVIDIA);
            this.groupBox2.Controls.Add(this.rbAMD);
            this.groupBox2.Controls.Add(this.rbNone);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtLog);
            this.groupBox2.Controls.Add(this.btnStart);
            this.groupBox2.Controls.Add(this.btnPath);
            this.groupBox2.Controls.Add(this.txtPath);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.panel4);
            this.groupBox2.Location = new System.Drawing.Point(15, 260);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(571, 284);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Scan and Apply RetroShaderFix";
            // 
            // rbNVIDIA
            // 
            this.rbNVIDIA.Image = global::RetroShaderFixGUI.Properties.Resources.nvidia_16;
            this.rbNVIDIA.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.rbNVIDIA.Location = new System.Drawing.Point(133, 76);
            this.rbNVIDIA.Name = "rbNVIDIA";
            this.rbNVIDIA.Size = new System.Drawing.Size(71, 22);
            this.rbNVIDIA.TabIndex = 11;
            this.rbNVIDIA.TabStop = true;
            this.rbNVIDIA.Text = "nVidia";
            this.rbNVIDIA.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rbNVIDIA.UseVisualStyleBackColor = true;
            this.rbNVIDIA.CheckedChanged += new System.EventHandler(this.rbNVIDIA_CheckedChanged);
            // 
            // rbAMD
            // 
            this.rbAMD.Image = global::RetroShaderFixGUI.Properties.Resources.amd_16;
            this.rbAMD.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.rbAMD.Location = new System.Drawing.Point(63, 76);
            this.rbAMD.Name = "rbAMD";
            this.rbAMD.Size = new System.Drawing.Size(65, 21);
            this.rbAMD.TabIndex = 10;
            this.rbAMD.TabStop = true;
            this.rbAMD.Text = "AMD";
            this.rbAMD.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rbAMD.UseVisualStyleBackColor = true;
            this.rbAMD.CheckedChanged += new System.EventHandler(this.rbAMD_CheckedChanged);
            // 
            // rbNone
            // 
            this.rbNone.Location = new System.Drawing.Point(7, 76);
            this.rbNone.Name = "rbNone";
            this.rbNone.Size = new System.Drawing.Size(51, 22);
            this.rbNone.TabIndex = 9;
            this.rbNone.TabStop = true;
            this.rbNone.Text = "None";
            this.rbNone.UseVisualStyleBackColor = true;
            this.rbNone.Click += new System.EventHandler(this.rbNone_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(180, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "RetroShaderFix Graphics Card Mode";
            // 
            // txtLog
            // 
            this.txtLog.Location = new System.Drawing.Point(6, 176);
            this.txtLog.Multiline = true;
            this.txtLog.Name = "txtLog";
            this.txtLog.ReadOnly = true;
            this.txtLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtLog.Size = new System.Drawing.Size(559, 102);
            this.txtLog.TabIndex = 2;
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnStart.Enabled = false;
            this.btnStart.Location = new System.Drawing.Point(173, 102);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(224, 31);
            this.btnStart.TabIndex = 7;
            this.btnStart.Text = "Begin Scan and Apply";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnPath
            // 
            this.btnPath.Location = new System.Drawing.Point(524, 37);
            this.btnPath.Name = "btnPath";
            this.btnPath.Size = new System.Drawing.Size(41, 20);
            this.btnPath.TabIndex = 6;
            this.btnPath.Text = "...";
            this.btnPath.UseVisualStyleBackColor = true;
            this.btnPath.Click += new System.EventHandler(this.btnPath_Click);
            // 
            // txtPath
            // 
            this.txtPath.Location = new System.Drawing.Point(6, 38);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(512, 20);
            this.txtPath.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(350, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Folder to Scan for No Man\'s Sky Installations (Multiple Installs Supported)";
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.lblScan);
            this.panel4.Location = new System.Drawing.Point(6, 140);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(559, 30);
            this.panel4.TabIndex = 3;
            // 
            // lblScan
            // 
            this.lblScan.ForeColor = System.Drawing.Color.Blue;
            this.lblScan.Location = new System.Drawing.Point(3, 3);
            this.lblScan.Name = "lblScan";
            this.lblScan.Size = new System.Drawing.Size(549, 21);
            this.lblScan.TabIndex = 0;
            this.lblScan.Text = "...";
            this.lblScan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtSystemInformation);
            this.groupBox3.Location = new System.Drawing.Point(15, 120);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(571, 134);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "System Information";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 556);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RetroShaderFix for No Man\'s Sky";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSystemInformation;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtHelp;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblScan;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnPath;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.TextBox txtLog;
        private System.Windows.Forms.RadioButton rbNVIDIA;
        private System.Windows.Forms.RadioButton rbAMD;
        private System.Windows.Forms.RadioButton rbNone;
        private System.Windows.Forms.Label label3;
    }
}

