using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Design;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

namespace MarksLaunchMenu
{
    class GlobalSettings
    {
        public static string AppName = "Mark's Launcher";
        public static string AppFolder = "MarksLauncher";
        public static Color ForeColor = Color.Black;
        public static Color BackColor = Color.White;
        public static Color SelectedColor = Color.Blue;
        public static Color NormalColor = SystemColors.ControlDarkDark; 
        public static Size MainLaunchImageScalingSize = new Size(32, 32);
        public static string DatabaseDBFile = "";
        public static int GroupButtonWidth = 100;
        public static int GroupButtonHeight = 40;
        public static string VersionString = "Version 1.0";

        public static string UserDataFolder
        {
            get
            {
                string folderBase = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
                string dir = Path.Combine(folderBase, AppFolder);
                return dir;
            }
        }

        public static string DatabaseFileName
        {
            get
            {
                var name = Path.Combine(GlobalSettings.UserDataFolder, $"{AppFolder}.db");
                return name;
            }
        }

    }
}
