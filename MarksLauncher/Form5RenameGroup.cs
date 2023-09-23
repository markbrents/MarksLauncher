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
    public partial class Form5RenameGroup : Form
    {
        public string NewName => txtNewName.Text;

        public Form5RenameGroup(string oldName)
        {
            InitializeComponent();
            Setup(oldName);
        }

        private void Setup(string oldName)
        {
            txtOldName.Text = oldName;
            txtNewName.MaxLength = GlobalSettings.GroupButtonWidth;
        }

        private void Form5_Shown(object sender, EventArgs e)
        {
            txtNewName.Select();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNewName.Text))
            {
                MessageBox.Show("Please provide a new name", GlobalSettings.AppName);
                return;
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
