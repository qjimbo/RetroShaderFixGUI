
namespace RetroShaderFixGUI
{
    partial class SelectVersionForm
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
            this.lblText1 = new System.Windows.Forms.Label();
            this.pbIcon = new System.Windows.Forms.PictureBox();
            this.lblPath = new System.Windows.Forms.Label();
            this.btnSkip = new System.Windows.Forms.Button();
            this.btnRelease = new System.Windows.Forms.Button();
            this.btnFoundation = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPathFinder = new System.Windows.Forms.Button();
            this.btnAtlasRises = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // lblText1
            // 
            this.lblText1.Location = new System.Drawing.Point(66, 12);
            this.lblText1.Name = "lblText1";
            this.lblText1.Size = new System.Drawing.Size(402, 15);
            this.lblText1.TabIndex = 0;
            this.lblText1.Text = "Unable to determine the version of this No Man\'s Sky executable:";
            // 
            // pbIcon
            // 
            this.pbIcon.Location = new System.Drawing.Point(12, 12);
            this.pbIcon.Name = "pbIcon";
            this.pbIcon.Size = new System.Drawing.Size(48, 48);
            this.pbIcon.TabIndex = 1;
            this.pbIcon.TabStop = false;
            // 
            // lblPath
            // 
            this.lblPath.ForeColor = System.Drawing.Color.Green;
            this.lblPath.Location = new System.Drawing.Point(66, 31);
            this.lblPath.Name = "lblPath";
            this.lblPath.Size = new System.Drawing.Size(402, 23);
            this.lblPath.TabIndex = 2;
            this.lblPath.Text = "C:\\NMSLegacy\\NMS.exe";
            // 
            // btnSkip
            // 
            this.btnSkip.Location = new System.Drawing.Point(69, 73);
            this.btnSkip.Name = "btnSkip";
            this.btnSkip.Size = new System.Drawing.Size(75, 23);
            this.btnSkip.TabIndex = 3;
            this.btnSkip.Text = "Skip >";
            this.btnSkip.UseVisualStyleBackColor = true;
            this.btnSkip.Click += new System.EventHandler(this.btnSkip_Click);
            // 
            // btnRelease
            // 
            this.btnRelease.Location = new System.Drawing.Point(150, 73);
            this.btnRelease.Name = "btnRelease";
            this.btnRelease.Size = new System.Drawing.Size(75, 23);
            this.btnRelease.TabIndex = 4;
            this.btnRelease.Text = "Release";
            this.btnRelease.UseVisualStyleBackColor = true;
            this.btnRelease.Click += new System.EventHandler(this.btnRelease_Click);
            // 
            // btnFoundation
            // 
            this.btnFoundation.Location = new System.Drawing.Point(231, 73);
            this.btnFoundation.Name = "btnFoundation";
            this.btnFoundation.Size = new System.Drawing.Size(75, 23);
            this.btnFoundation.TabIndex = 5;
            this.btnFoundation.Text = "Foundation";
            this.btnFoundation.UseVisualStyleBackColor = true;
            this.btnFoundation.Click += new System.EventHandler(this.btnFoundation_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(66, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(402, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Please specify No Man\'s Sky version:";
            // 
            // btnPathFinder
            // 
            this.btnPathFinder.Location = new System.Drawing.Point(312, 72);
            this.btnPathFinder.Name = "btnPathFinder";
            this.btnPathFinder.Size = new System.Drawing.Size(75, 23);
            this.btnPathFinder.TabIndex = 7;
            this.btnPathFinder.Text = "Path Finder";
            this.btnPathFinder.UseVisualStyleBackColor = true;
            this.btnPathFinder.Click += new System.EventHandler(this.btnPathFinder_Click);
            // 
            // btnAtlasRises
            // 
            this.btnAtlasRises.Location = new System.Drawing.Point(393, 72);
            this.btnAtlasRises.Name = "btnAtlasRises";
            this.btnAtlasRises.Size = new System.Drawing.Size(75, 23);
            this.btnAtlasRises.TabIndex = 8;
            this.btnAtlasRises.Text = "Atlas Rises";
            this.btnAtlasRises.UseVisualStyleBackColor = true;
            this.btnAtlasRises.Click += new System.EventHandler(this.btnAtlasRises_Click);
            // 
            // SelectVersionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 105);
            this.Controls.Add(this.btnAtlasRises);
            this.Controls.Add(this.btnPathFinder);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnFoundation);
            this.Controls.Add(this.btnRelease);
            this.Controls.Add(this.btnSkip);
            this.Controls.Add(this.lblPath);
            this.Controls.Add(this.pbIcon);
            this.Controls.Add(this.lblText1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SelectVersionForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Unable to Detect Version";
            ((System.ComponentModel.ISupportInitialize)(this.pbIcon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblText1;
        private System.Windows.Forms.PictureBox pbIcon;
        private System.Windows.Forms.Label lblPath;
        private System.Windows.Forms.Button btnSkip;
        private System.Windows.Forms.Button btnRelease;
        private System.Windows.Forms.Button btnFoundation;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPathFinder;
        private System.Windows.Forms.Button btnAtlasRises;
    }
}