using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShabsImpl.Helper
{
    public class DirectoryHelper
    {
        public static string MyApplicationDirectory
        {
            get
            {
                return Path.GetDirectoryName(Application.ExecutablePath); ;
            }
        }

        public static string PictureDirectory
        {
            get
            {
                string appDirectory = MyApplicationDirectory;
                string picDirectory = string.Empty;
                DirectoryInfo di = new DirectoryInfo(appDirectory);
                DirectoryInfo picDirInfo = null;
                DirectoryInfo currDir = di;
                while (true)
                {
                    picDirInfo = currDir.Parent.EnumerateDirectories().Where(d => d.Name.ToLower() == "pic").SingleOrDefault();
                    if (picDirInfo != null)
                        break;
                    else
                        currDir = currDir.Parent;

                    //If root directory, exist
                    if (currDir.Parent == null)
                        break;
                }
                if (picDirInfo != null)
                    picDirectory = picDirInfo.FullName;
                return picDirectory;
            }
        }
    }
}
