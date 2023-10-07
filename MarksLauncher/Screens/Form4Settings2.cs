using MarksLauncher.Dtos;
using MarksLaunchMenu;
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

namespace MarksLauncher.Screens
{
    public partial class Form4Settings2 : Form
    {

        public event EventHandler ColorsUpdated;

        protected virtual void OnColorsUpdated(EventArgs e)
        {
            ColorsUpdated?.Invoke(this, e);
        }

        public event EventHandler GroupsUpdated;

        protected virtual void OnGroupsUpdated(EventArgs e)
        {
            GroupsUpdated?.Invoke(this, e);
        }

        public Form4Settings2()
        {
            InitializeComponent();

            LoadCategories();
            SetupColorPage();
            //SetupGroupArrangePage();
            //SetupGroupEditPage();

        }

        private void SetupGroupEditPage()
        {
            var groups = Repository.GetAllGroups();

            lbEditGroups.DisplayMember = "GroupName";
            lbEditGroups.ValueMember = "GroupID";

            lbEditGroups.DataSource = groups;

            lbEditGroups.SelectedIndexChanged += EditGroups_SelectedIndexChanged; ;
        }

        private void EditGroups_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void SetupGroupArrangePage()
        {
            var groups = Repository.GetAllGroups();

            lbGroups.DisplayMember = "GroupName";
            lbGroups.ValueMember = "GroupID";

            lbGroups.DataSource = groups;

            lbGroups.SelectedIndexChanged += lbGroups_SelectedIndexChanged;

            flowLayoutPanelRearrange.DragEnter += FlowLayoutPanelRearrange_DragEnter;
            flowLayoutPanelRearrange.DragDrop += FlowLayoutPanelRearrange_DragDrop;
        }

        private void FlowLayoutPanelRearrange_DragDrop(object sender, DragEventArgs e)
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

        private void FlowLayoutPanelRearrange_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;
        }

        private void lbGroups_SelectedIndexChanged(object sender, EventArgs e)
        {
            var group = lbGroups.SelectedItem as GroupDto;

            if (group != null)
            {
                LoadList(group);
            }
        }
        private void LoadList(GroupDto group)
        {
            flowLayoutPanelRearrange.Controls.Clear();

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
                //pnl.DeleteMoveable += HandleDeleteMoveable;

                flowLayoutPanelRearrange.Controls.Add(pnl);
            }
            flowLayoutPanelRearrange.Invalidate();

        }

        private void HandleMoveableSelected(object sender, MoveableControl e)
        {
            //throw new NotImplementedException();
        }

        private void SetupColorPage()
        {
            pbBackcolor.BackColor = GlobalSettings.BackColor;
            pbTextColor.BackColor = GlobalSettings.ForeColor;

            pbBackcolor.Click += PbBackcolor_Click;
            pbTextColor.Click += PbTextColor_Click;
        }

        private void PbTextColor_Click(object sender, EventArgs e)
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

        private void PbBackcolor_Click(object sender, EventArgs e)
        {
            using var f = new ColorDialog();
            var result = f.ShowDialog(this);

            if (result == DialogResult.OK)
            {
                pbBackcolor.BackColor = f.Color;
                UpdatePreview();
            }
        }

        private void LoadCategories()
        {
            var categories = GetCategories();

            lbSettings.DisplayMember = "DisplayName";
            lbSettings.DataSource = categories;
        }

        private List<SettingsCategoryDto> GetCategories()
        {
            var result = new List<SettingsCategoryDto>();

            result.Add(new SettingsCategoryDto() { DisplayName = "Colors", Name = "Colors" });
            result.Add(new SettingsCategoryDto() { DisplayName = "Arrange Group Links", Name = "GroupArrange" });
            result.Add(new SettingsCategoryDto() { DisplayName = "Edit Group Members", Name = "GroupEditMembers" });
            result.Add(new SettingsCategoryDto() { DisplayName = "Edit Link", Name = "LinkEdit" });

            return result;
        }

        private void lbSettings_SelectedIndexChanged(object sender, EventArgs e)
        {
            var setting = lbSettings.SelectedItem as SettingsCategoryDto;

            if (lbSettings.SelectedIndex != -1)
            {

                var tp = tabControl1.TabPages["tabPage" + setting.Name];
                if (tp != null)
                {
                    tabControl1.SelectedTab = tp;
                }
            }

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            GlobalSettings.BackColor = pbBackcolor.BackColor;
            GlobalSettings.ForeColor = pbTextColor.BackColor;

            OnColorsUpdated(EventArgs.Empty);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var controls = flowLayoutPanelRearrange.Controls.OfType<MoveableControl>().ToList();

            for (int i = 0; i < controls.Count; i++)
            {
                controls[i].Order = i;
            }

            //var lb = flowLayoutPanelRearrange.Controls.OfType<MoveableControl>().ToList();

            foreach (MoveableControl item in controls)
            {
                Repository.UpdateSort(item.GroupId, item.LinkId, item.Order);
            }

            OnGroupsUpdated(EventArgs.Empty);
            //LoadGroups();
        }

        private void splitContainer1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }
    }
}
