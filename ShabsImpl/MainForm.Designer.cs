namespace ShabsImpl
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
            this.btnImageCompare = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFirstImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openSecondImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataCompareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPerDiff = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblImage1Path = new System.Windows.Forms.Label();
            this.lblImage2Path = new System.Windows.Forms.Label();
            this.cbCompareAlgorithm = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnImageCompare
            // 
            this.btnImageCompare.Location = new System.Drawing.Point(307, 201);
            this.btnImageCompare.Name = "btnImageCompare";
            this.btnImageCompare.Size = new System.Drawing.Size(142, 35);
            this.btnImageCompare.TabIndex = 0;
            this.btnImageCompare.Text = "Image Compare";
            this.btnImageCompare.UseVisualStyleBackColor = true;
            this.btnImageCompare.Click += new System.EventHandler(this.btnImageCompare_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(549, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openFirstImageToolStripMenuItem,
            this.openSecondImageToolStripMenuItem,
            this.dataCompareToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openFirstImageToolStripMenuItem
            // 
            this.openFirstImageToolStripMenuItem.Name = "openFirstImageToolStripMenuItem";
            this.openFirstImageToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.openFirstImageToolStripMenuItem.Text = "Open first image";
            this.openFirstImageToolStripMenuItem.Click += new System.EventHandler(this.openFirstImageToolStripMenuItem_Click);
            // 
            // openSecondImageToolStripMenuItem
            // 
            this.openSecondImageToolStripMenuItem.Name = "openSecondImageToolStripMenuItem";
            this.openSecondImageToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.openSecondImageToolStripMenuItem.Text = "Open second image";
            this.openSecondImageToolStripMenuItem.Click += new System.EventHandler(this.openSecondImageToolStripMenuItem_Click);
            // 
            // dataCompareToolStripMenuItem
            // 
            this.dataCompareToolStripMenuItem.Name = "dataCompareToolStripMenuItem";
            this.dataCompareToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.dataCompareToolStripMenuItem.Text = "Data Compare";
            this.dataCompareToolStripMenuItem.Click += new System.EventHandler(this.dataCompareToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 251);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Image Compare Percentage: ";
            // 
            // txtPerDiff
            // 
            this.txtPerDiff.Location = new System.Drawing.Point(161, 248);
            this.txtPerDiff.Name = "txtPerDiff";
            this.txtPerDiff.Size = new System.Drawing.Size(259, 20);
            this.txtPerDiff.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 51);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(215, 129);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(322, 51);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(215, 129);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // lblImage1Path
            // 
            this.lblImage1Path.AutoSize = true;
            this.lblImage1Path.Location = new System.Drawing.Point(13, 187);
            this.lblImage1Path.Name = "lblImage1Path";
            this.lblImage1Path.Size = new System.Drawing.Size(67, 13);
            this.lblImage1Path.TabIndex = 7;
            this.lblImage1Path.Text = "Image1 Path";
            // 
            // lblImage2Path
            // 
            this.lblImage2Path.AutoSize = true;
            this.lblImage2Path.Location = new System.Drawing.Point(319, 187);
            this.lblImage2Path.Name = "lblImage2Path";
            this.lblImage2Path.Size = new System.Drawing.Size(67, 13);
            this.lblImage2Path.TabIndex = 8;
            this.lblImage2Path.Text = "Image2 Path";
            // 
            // cbCompareAlgorithm
            // 
            this.cbCompareAlgorithm.FormattingEnabled = true;
            this.cbCompareAlgorithm.Items.AddRange(new object[] {
            "Undefined",
            "Absolute",
            "Fuzz",
            "MeanAbsolute",
            "MeanErrorPerPixel",
            "MeanSquared",
            "NormalizedCrossCorrelation",
            "PeakAbsolute",
            "PeakSignalToNoiseRatio",
            "PerceptualHash",
            "RootMeanSquared",
            "pHash",
            "Bhattacharyya"});
            this.cbCompareAlgorithm.Location = new System.Drawing.Point(117, 209);
            this.cbCompareAlgorithm.Name = "cbCompareAlgorithm";
            this.cbCompareAlgorithm.Size = new System.Drawing.Size(165, 21);
            this.cbCompareAlgorithm.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 212);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Compare Algorithm";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 290);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbCompareAlgorithm);
            this.Controls.Add(this.lblImage2Path);
            this.Controls.Add(this.lblImage1Path);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtPerDiff);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnImageCompare);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnImageCompare;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openFirstImageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openSecondImageToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPerDiff;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblImage1Path;
        private System.Windows.Forms.Label lblImage2Path;
        private System.Windows.Forms.ComboBox cbCompareAlgorithm;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripMenuItem dataCompareToolStripMenuItem;
    }
}

