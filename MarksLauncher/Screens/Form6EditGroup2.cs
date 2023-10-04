using MarksLaunchMenu.Database;
using MarksLaunchMenu.Dtos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarksLaunchMenu
{
    public partial class Form6EditGroup2 : Form
    {
        public Form6EditGroup2()
        {
            InitializeComponent();
            LoadGroups();
        }

        private void LoadGroups()
        {
            var groups = Repository.GetAllGroups();

            lbGroups.DisplayMember = "GroupName";
            lbGroups.ValueMember = "GroupID";

            lbGroups.DataSource = groups;

        }

        private void lbGroups_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChangeGroup();
        }

        private void ChangeGroup()
        {
            var currentGroup = (GroupDto)lbGroups.SelectedItem;

            var links = Repository.GetLinksForGroup(currentGroup.GroupID);

            LoadLinkList(currentGroup, links);

        }

        private void LoadLinkList(GroupDto group, List<LinkDto> links)
        {

            flpLinks.Controls.Clear();

            foreach (var link in links)
            {
                var pnl = new MoveableControl()
                {
                    DisplayName = link.LinkName,
                    LinkPath = link.LinkPath,
                    BackColor = SystemColors.ControlLight,
                    Tag = Environment.ExpandEnvironmentVariables(link.LinkPath),
                    GroupId = group.GroupID,
                    LinkId = link.LinkID,
                    Order = link.Order,
                    Image = IconHelper.GetIcon(Environment.ExpandEnvironmentVariables(link.LinkPath), true)

                };
                pnl.MoveableSelected += HandleLinkSelected;

                flpLinks.Controls.Add(pnl);
            }
            flpLinks.Invalidate();
        }

        private void HandleLinkSelected(object sender, MoveableControl e)
        {
            txtPath.Text = e.LinkPath;
            txtName.Text = e.DisplayName;
            txtLinkId.Text = e.LinkId;
        }

        private void btnEditLink_Click(object sender, EventArgs e)
        {
            using var f = new Form3AddLink();
            f.Header = "Edit Link";
            f.ButtonText = "OK";
            f.LinkPath = txtPath.Text;
            f.LinkName = txtName.Text;

            var result = f.ShowDialog();

            if (result == DialogResult.OK)
            {
                Repository.UpdateLink(txtLinkId.Text, f.LinkName, f.LinkPath, f.LinkArguments);
            }
        }
    }
}
