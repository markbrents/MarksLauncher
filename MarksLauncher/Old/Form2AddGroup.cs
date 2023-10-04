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
    public partial class Form2AddGroup : Form
    {
        public string GroupName => txtGroupName.Text;

        public Form2AddGroup()
        {
            InitializeComponent();

        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;

            this.Close();

        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txtGroupName.Text))
            {
                MessageBox.Show("Please enter a group name", GlobalSettings.AppName, MessageBoxButtons.OK);
                return;
            }

            this.DialogResult = DialogResult.OK;

            this.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.Text = GlobalSettings.AppName;
        }
    }
}
