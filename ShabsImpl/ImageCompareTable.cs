using System;
using System.Windows.Forms;
using System.IO;
using ImageMagick;
using System.Collections.Generic;
using System.ComponentModel;
using ShabsImpl.Jakob;
using System.Drawing;
using ShabsImpl.Helper;

namespace ShabsImpl
{
    public partial class ImageCompareTable : Form
    {
        public ImageCompareTable()
        {
            InitializeComponent();
        }

        private void btnImageCompare_Click(object sender, EventArgs e)
        {

            string pictureDirectory = DirectoryHelper.PictureDirectory;
            if (string.IsNullOrWhiteSpace(pictureDirectory))
            {
                MessageBox.Show("Can't find picture directory, this form can't work!");
                return;
            }
            
            string OrginalFile = Path.Combine(pictureDirectory, "Original.jpg");
            
            MagickImage orgImage = null;
            MagickImage dupImage = null;

            DirectoryInfo di = new DirectoryInfo(pictureDirectory);
            Dictionary<string, double> imageCompareData = new Dictionary<string, double>();

            foreach (FileInfo fi in di.EnumerateFiles())
            {
                string filePath = fi.FullName;
                string fileName = fi.Name;
                if (filePath == OrginalFile)
                    continue;

                bool ispHashSelected = cbCompareAlgorithm.Text == "pHash";
                bool isBhattacharyyaSelected = cbCompareAlgorithm.Text == "Bhattacharyya";

                if (ispHashSelected)
                {
                    var percentage = ImageHashing.Similarity(OrginalFile, filePath);                    
                    percentage = Math.Round(percentage, 3);
                    imageCompareData.Add(fileName, percentage);                
                }
                else if (isBhattacharyyaSelected)
                {
                    Image img1 = Image.FromFile(OrginalFile);
                    Image img2 = Image.FromFile(filePath);
                    var percentage = Bhattacharyya.BhattacharyyaDifference(img1, img2);
                    percentage = (1 - percentage) * 100;
                    percentage = Math.Round(percentage, 3);
                    imageCompareData.Add(fileName, percentage);                
                }
                else
                {
                    orgImage = new MagickImage(OrginalFile);
                    int imageAlgoIndex = cbCompareAlgorithm.SelectedIndex;
                    ErrorMetric imageAlgo = (ErrorMetric)imageAlgoIndex;

                    dupImage = new MagickImage(filePath);
                    var percentage = orgImage.Compare(dupImage, imageAlgo);
                    percentage = Math.Round(percentage, 3);
                    imageCompareData.Add(fileName, percentage);                
                }

                
            }

            var bl = new DictionaryBindingList<string, double>(imageCompareData);
            dataGridView1.DataSource = bl;            

            if (orgImage != null)
                orgImage.Dispose();
            if (dupImage != null)
                dupImage.Dispose();
        }
    }
    public sealed class Pair<TKey, TValue>
    {
        private readonly TKey key;
        private readonly IDictionary<TKey, TValue> data;
        public Pair(TKey key, IDictionary<TKey, TValue> data)
        {
            this.key = key;
            this.data = data;
        }
        public TKey Key { get { return key; } }
        public TValue Value
        {
            get
            {
                TValue value;
                data.TryGetValue(key, out value);
                return value;
            }
            set { data[key] = value; }
        }
    }
    public class DictionaryBindingList<TKey, TValue>
        : BindingList<Pair<TKey, TValue>>
    {
        private readonly IDictionary<TKey, TValue> data;
        public DictionaryBindingList(IDictionary<TKey, TValue> data)
        {
            this.data = data;
            Reset();
        }
        public void Reset()
        {
            bool oldRaise = RaiseListChangedEvents;
            RaiseListChangedEvents = false;
            try
            {
                Clear();
                foreach (TKey key in data.Keys)
                {
                    Add(new Pair<TKey, TValue>(key, data));
                }
            }
            finally
            {
                RaiseListChangedEvents = oldRaise;
                ResetBindings();
            }
        }

    }
}
