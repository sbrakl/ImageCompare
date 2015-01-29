using ImageMagick;
using ShabsImpl.Helper;
using ShabsImpl.Jakob;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ShabsImpl
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnImageCompare_Click(object sender, EventArgs e)
        {
            string orgImagePath = lblImage1Path.Text;
            string dupImagePath = lblImage2Path.Text;

            bool isFirstImageEmpty = string.IsNullOrWhiteSpace(orgImagePath);
            bool isSecondImageEmpty = string.IsNullOrWhiteSpace(dupImagePath);

            if (isFirstImageEmpty || isSecondImageEmpty)
            {
                MessageBox.Show("Please select images before compare");
            }

            bool ispHashSelected = cbCompareAlgorithm.Text == "pHash";
            bool isBhattacharyyaSelected = cbCompareAlgorithm.Text == "Bhattacharyya";

            if (ispHashSelected)
            {
                var percentage = ImageHashing.Similarity(orgImagePath, dupImagePath);
                percentage = Math.Round(percentage, 3);
                txtPerDiff.Text = percentage.ToString();
            }
            else if (isBhattacharyyaSelected)
            {
                Image img1 = Image.FromFile(orgImagePath);
                Image img2 = Image.FromFile(dupImagePath);
                var percentage = Bhattacharyya.BhattacharyyaDifference(img1, img2);
                percentage = percentage * 100;
                percentage = Math.Round(percentage, 3);
                txtPerDiff.Text = percentage.ToString();
            }
            else
            {
                int imageAlgoIndex = cbCompareAlgorithm.SelectedIndex;
                ErrorMetric imageAlgo = (ErrorMetric)imageAlgoIndex;

                MagickImage orgImage = new MagickImage(orgImagePath);
                MagickImage dupImage = new MagickImage(dupImagePath);
                var percentage = orgImage.Compare(dupImage, imageAlgo);
                txtPerDiff.Text = percentage.ToString();
                orgImage.Dispose();
                dupImage.Dispose();
            }

            
                
            
        }

        private void openFirstImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog.Filter = "Image Files|*.jpg;*.png";
            openFileDialog.InitialDirectory = DirectoryHelper.PictureDirectory;
            openFileDialog.Title = "Please select Image 1";
            openFileDialog.FileName = "";
            DialogResult diagResult = openFileDialog.ShowDialog();
            if (diagResult == System.Windows.Forms.DialogResult.OK)
            {
                lblImage1Path.Text = openFileDialog.FileName;
                pictureBox1.ImageLocation = openFileDialog.FileName;
            }
        }

        private void openSecondImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog.Filter = "Image Files|*.jpg;*.png";
            openFileDialog.InitialDirectory = DirectoryHelper.PictureDirectory;
            openFileDialog.Title = "Please select Image 2";
            openFileDialog.FileName = "";
            DialogResult diagResult = openFileDialog.ShowDialog();
            if (diagResult == System.Windows.Forms.DialogResult.OK)
            {
                lblImage2Path.Text = openFileDialog.FileName;
                pictureBox2.ImageLocation = openFileDialog.FileName;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cbCompareAlgorithm.SelectedIndex = 0;
        }

        private void dataCompareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ImageCompareTable frmImageCompare = new ImageCompareTable();
            frmImageCompare.Show();            
        }

        
    }
}
