using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Foundation;
using UIKit;
using Practica8.iOS;
using System.IO;
using Xamarin.Forms;

[assembly: Dependency(typeof(ISQLite_IOS))]
namespace Practica8.iOS
{
  public class ISQLite_IOS : ISQLite
    {
        public string GetLocalFilePath(string filename)
        {
            string docFolder = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            string libfolder = Path.Combine(docFolder, "..", "Library", "DataBase");
            if (!Directory.Exists(libfolder))
            {
                Directory.CreateDirectory(libfolder);
            }
            return Path.Combine(libfolder, filename);
        }
    }
}