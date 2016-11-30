using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Smista_File
{
    class Functions
    {
        /// <summary>
        /// Check if a folder exists, and in case it create it
        /// </summary>
        /// <param name="path">Folder to check</param>
        /// <returns>Bool, if something happens return false</returns>
        public static bool ControllaCartella(string path)
        {
            bool ris = false;
            if (Directory.Exists(path))
            {
                ris = true;
            }
            else
            {
                Directory.CreateDirectory(path);
                ris = true;
            }
            return ris;
        }

    }
}
