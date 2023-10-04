using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarksLaunchMenu
{
    public partial class Form3AddLink : Form
    {

        public string LinkPath
        {
            get { return txtPath.Text; }

            set { txtPath.Text = value; }
        }

        public string LinkName
        {
            get { return txtName.Text; }

            set { txtName.Text = value; }
        }

        public string Header
        {
            get { return label3.Text; }

            set { label3.Text = value; }
        }
        public string ButtonText
        {
            get { return btnAdd.Text; }
            set { btnAdd.Text = value; }
        }

        public string LinkArguments
        {
            get { return txtArguments.Text; }
            set { txtArguments.Text = value; } 
        }

        public Form3AddLink()
        {
            InitializeComponent();
        }

        private void BtnBrowse_Click(object sender, EventArgs e)
        {
            using var f = new OpenFileDialog();
            if (Directory.Exists(txtPath.Text))
            {
                f.InitialDirectory = txtPath.Text;
            }
            f.Multiselect = false;
            var result = f.ShowDialog(this);

            if (result == DialogResult.OK)
            {
                txtPath.Text = f.FileName;
                CheckDisplayName();
            }
        }

        private void CheckDisplayName()
        {
            if (txtName.Text == "")
            {
                txtName.Text = Path.GetFileNameWithoutExtension(txtPath.Text);
            }
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            // Remove any quotes 
            txtName.Text = txtName.Text.Replace("\"", "");
            this.DialogResult = DialogResult.OK;

            this.Close();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {

            DialogResult = DialogResult.Cancel;

            this.Close();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            this.Text = GlobalSettings.AppName;
        }
    }
}
