namespace ShabsImpl
{
    partial class ImageCompareTable
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
            this.label2 = new System.Windows.Forms.Label();
            this.cbCompareAlgorithm = new System.Windows.Forms.ComboBox();
            this.btnImageCompare = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Compare Algorithm";
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
            this.cbCompareAlgorithm.Location = new System.Drawing.Point(135, 21);
            this.cbCompareAlgorithm.Name = "cbCompareAlgorithm";
            this.cbCompareAlgorithm.Size = new System.Drawing.Size(165, 21);
            this.cbCompareAlgorithm.TabIndex = 12;
            // 
            // btnImageCompare
            // 
            this.btnImageCompare.Location = new System.Drawing.Point(325, 13);
            this.btnImageCompare.Name = "btnImageCompare";
            this.btnImageCompare.Size = new System.Drawing.Size(142, 35);
            this.btnImageCompare.TabIndex = 11;
            this.btnImageCompare.Text = "Image Compare";
            this.btnImageCompare.UseVisualStyleBackColor = true;
            this.btnImageCompare.Click += new System.EventHandler(this.btnImageCompare_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(31, 76);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(475, 244);
            this.dataGridView1.TabIndex = 14;
            // 
            // ImageCompareTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 359);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbCompareAlgorithm);
            this.Controls.Add(this.btnImageCompare);
            this.Name = "ImageCompareTable";
            this.Text = "Image Compare Table";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbCompareAlgorithm;
        private System.Windows.Forms.Button btnImageCompare;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}