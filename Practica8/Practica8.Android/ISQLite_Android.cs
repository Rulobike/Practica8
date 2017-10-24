using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Practica8.Droid;
using System.IO;
using System.Runtime.CompilerServices;

[assembly: Dependency(typeof(ISQLite_Android))]
namespace Practica8.Droid
{
   public class ISQLite_Android : ISQLite
    {
        public string GetLocalFilePath(string filename)
        {
            string path = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
            return Path.Combine(path, filename);
        }
    }
}