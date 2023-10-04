using MarksLaunchMenu.Database;
using MarksLaunchMenu.Dtos;
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
    public partial class Form6EditGroup : Form
    {
        public List<MoveableControl> LinkBoxes
        {
            get
            {
                var controls = flowLayoutPanel1.Controls.OfType<MoveableControl>().ToList();
                return controls;
            }
        }

        public Form6EditGroup(GroupDto group)
        {
            InitializeComponent();

            Setup(group);

            LoadList(group);


        }

        private void Setup(GroupDto group)
        {
            lblGroupName.Text = group.GroupName;
        }

        private void LoadList(GroupDto group)
        {

            var links = Repository.GetLinksForGroup(group.GroupID);

            foreach (var link in links)
            {
                var pnl = new MoveableControl()
                {
                    DisplayName = link.LinkName,
                    LinkPath = link.LinkPath,
                    BackColor = GlobalSettings.NormalColor,
                    Tag = Environment.ExpandEnvironmentVariables(link.LinkPath),
                    GroupId = group.GroupID,
                    LinkId = link.LinkID,
                    Order = link.Order,
                    Image = IconHelper.GetIcon(Environment.ExpandEnvironmentVariables(link.LinkPath), true)

                };
                pnl.MoveableSelected += HandleMoveableSelected;
                pnl.DeleteMoveable += HandleDeleteMoveable;

                flowLayoutPanel1.Controls.Add(pnl);
            }
            flowLayoutPanel1.Invalidate();

        }

        private void HandleDeleteMoveable(object sender, MoveableControl e)
        {
            var result = MessageBox.Show("Are you sure you wish to delete this link?", "Delete Item", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Repository.DeleteLink(e.LinkId);
            }
        }

        private void HandleMoveableSelected(object sender, MoveableControl e)
        {
            txtPath.Text = e.LinkPath;
            txtName.Text = e.DisplayName;
            txtLinkId.Text = e.LinkId;
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            this.Text = GlobalSettings.AppName;
        }

        private void flowLayoutPanel1_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;
        }

        private void flowLayoutPanel1_DragDrop(object sender, DragEventArgs e)
        {
            MoveableControl data = (MoveableControl)e.Data.GetData(typeof(MoveableControl));

            var destination = (FlowLayoutPanel)sender;

            Point p = destination.PointToClient(new Point(e.X, e.Y));
            var item = destination.GetChildAtPoint(p);
            int index = destination.Controls.GetChildIndex(item, false);
            destination.Controls.SetChildIndex(data, index);

            // Invalidate to paint!
            destination.Invalidate();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            var controls = flowLayoutPanel1.Controls.OfType<MoveableControl>().ToList();

            for (int i = 0; i < controls.Count; i++)
            {
                controls[i].Order = i;
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnEditLink_Click(object sender, EventArgs e)
        {

            using var f = new Form3AddLink();
            f.Header = "Edit Link";
            f.LinkPath = txtPath.Text;
            f.LinkName = txtName.Text;
            f.LinkArguments = txtArguments.Text; 
            var result = f.ShowDialog();

            if (result == DialogResult.OK)
            {
                Repository.UpdateLink(txtLinkId.Text, f.LinkName, f.LinkPath, f.LinkArguments);
            }

        }

    }
}
