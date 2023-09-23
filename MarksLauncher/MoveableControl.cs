using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarksLaunchMenu
{


    public partial class MoveableControl : UserControl
    {
        public event EventHandler<MoveableControl> MoveableSelected;

        protected virtual void OnMoveableSelected(MoveableControl e)
        {
            MoveableSelected?.Invoke(this, e);
        }

        public event EventHandler<MoveableControl> DeleteMoveable; 
        protected virtual void OnDeleteMoveable(MoveableControl e)
        {
            DeleteMoveable?.Invoke(this, e);
        }

        public string DisplayName
        {
            get { return lblLinkDisplayName.Text; }

            set { lblLinkDisplayName.Text = value; }
        }

        public Image Image
        {
            get { return pbIcon.Image; }
            set { pbIcon.Image = value; }
        }

        public Boolean IsCurrent;

        public string LinkPath { get; set; }
        public string GroupId { get; set; }
        public string LinkId { get; set; }
        public int Order { get; set; }


        public MoveableControl()
        {
            InitializeComponent();
        }
        private void MoveableControl_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
                return;
            DoDragDrop(sender, DragDropEffects.All);

            var currentBackColor = BackColor;

            var siblings = this.Parent.Controls.OfType<MoveableControl>().ToList();

            foreach (var moveableControl in siblings)
            {
                moveableControl.BackColor = GlobalSettings.NormalColor;
                IsCurrent = false;
            }

            this.IsCurrent = true;

            if (currentBackColor == GlobalSettings.NormalColor)
            {
                BackColor = GlobalSettings.SelectedColor;
            }
            else
            {
                BackColor = GlobalSettings.NormalColor;
            }

            OnMoveableSelected(this);
        }

        private void editLinkToolStripMenuItem_Click(object sender, EventArgs e)
        {
                OnDeleteMoveable(this); 
        }
    }
}
