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
    public partial class Form4Settings : Form
    {
        public Form4Settings()
        {
            InitializeComponent();
            LoadConfig();
            UpdatePreview();
        }

        private void LoadConfig()
        {
            pbBackcolor.BackColor = GlobalSettings.BackColor;
            pbTextColor.BackColor = GlobalSettings.ForeColor;
        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            GlobalSettings.BackColor = pbBackcolor.BackColor;
            GlobalSettings.ForeColor = pbTextColor.BackColor;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            this.Text = GlobalSettings.AppName;

        }

        private void pbBackcolor_Click(object sender, EventArgs e)
        {
            using var f = new ColorDialog();
            var result = f.ShowDialog(this);

            if (result == DialogResult.OK)
            {
                pbBackcolor.BackColor = f.Color;
                UpdatePreview();
            }
        }

        private void pbTextColor_Click(object sender, EventArgs e)
        {
            using var f = new ColorDialog();
            var result = f.ShowDialog(this);

            if (result == DialogResult.OK)
            {
                pbTextColor.BackColor = f.Color;
                UpdatePreview();
            }
        }

        private void UpdatePreview()
        {
            btnGroup1.BackColor = pbBackcolor.BackColor;
            btnGroup1.ForeColor = pbTextColor.BackColor;
            btnGroup2.BackColor = pbBackcolor.BackColor;
            btnGroup2.ForeColor = pbTextColor.BackColor;
        }
    }
}
