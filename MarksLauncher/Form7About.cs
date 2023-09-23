using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarksLaunchMenu
{
    public partial class Form7About : Form
    {
        public Form7About()
        {
            InitializeComponent();

            this.Text = GlobalSettings.AppName;
            this.lblAppName.Text = GlobalSettings.AppName;
            this.lblVersion.Text = GlobalSettings.VersionString;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //try
            //{
            //    linkLabel1.LinkVisited = true;
            //    System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
            //    {
            //        FileName = "https://www.iconfinder.com/iconsets/arrows-and-universal-actions-icon-set",
            //        UseShellExecute = true
            //    });
            //}
            //catch (Exception)
            //{
            //}
            VisitLink("https://www.iconfinder.com/iconsets/arrows-and-universal-actions-icon-set");
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            VisitLink("https://www.iconfinder.com/iconsets/ionicons-outline-vol-2");
        }

        private void VisitLink(string link)
        {
            try
            {
                linkLabel1.LinkVisited = true;
                System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
                {
                    FileName = link,
                    UseShellExecute = true
                });
            }
            catch (Exception)
            {
            }
        }
    }
}
