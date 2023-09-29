using MarksLaunchMenu.Database;
using MarksLaunchMenu.Dtos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using tip2tail.WinFormAppBarLib;

namespace MarksLaunchMenu
{
    public partial class Form1Main : Form
    {
        private ToolStripTextBox txtRenameGroup;
        private ToolStripDropDownButton btnRename;

        public Form1Main()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Setup();
            LoadGroups();
        }

        #region  "Load Items"

        // Groups
        private void LoadGroups()
        {
            tsLaunch.Items.Clear();

            var groups = Repository.GetAllGroups();

            foreach (var group in groups)
            {
                AddGroupToLauncher(group);
            }

            AddGroupAdder();

        }

        private void AddGroupToLauncher(Dtos.GroupDto group)
        {
            // Group (end up as drop "down" buttons)
            var groupBtn = new ToolStripDropDownButton
            {
                ShowDropDownArrow = false,
                Text = group.GroupName,
                AutoSize = false,
                Height = GlobalSettings.GroupButtonHeight,
                Width = GlobalSettings.GroupButtonWidth,
                ForeColor = GlobalSettings.ForeColor,
                Tag = group,
                BackColor = GlobalSettings.BackColor,
                AutoToolTip = false
            };
            groupBtn.MouseDown += HandleGroupMouseDown;


            // Links (shortcuts) (end up as items in the button dropdown)
            var links = Repository.GetLinksForGroup(group.GroupID);



            // Add link at top for adding more links
            var addLink = new ToolStripMenuItem();
            addLink.Font = new Font(addLink.Font, FontStyle.Italic);
            addLink.Text = "Add new link...";
            addLink.Tag = group.GroupID;
            addLink.ForeColor = GlobalSettings.ForeColor;
            addLink.BackColor = GlobalSettings.BackColor;
            groupBtn.DropDownItems.Add(addLink);

            var bar = new ToolStripSeparator();
            groupBtn.DropDownItems.Add(bar);

            foreach (var link in links)
            {
                var newLink = new ToolStripMenuItem
                {
                    Text = link.LinkName,
                    ImageScaling = ToolStripItemImageScaling.SizeToFit,
                    ForeColor = GlobalSettings.ForeColor,
                    BackColor = GlobalSettings.BackColor,
                    Tag = link.LinkPath
                };

                var linkPath = Environment.ExpandEnvironmentVariables(link.LinkPath);
                var img = IconHelper.GetIcon(linkPath, true);
                newLink.Image = img;

                newLink.Click += HandleLinkClicked;

                groupBtn.DropDownItems.Add(newLink);
            }



            var split = new ToolStripSeparator();
            split.Name = group.GroupName + "Separator";


            addLink.Click += HandleAddLinkClicked;
            tsLaunch.Items.Add(groupBtn);
            tsLaunch.Items.Add(split);
        }

        private void AddGroupAdder()
        {
            var groupAdder = new ToolStripButton();
            groupAdder.Text = "+";
            groupAdder.ToolTipText = "Add new group";
            groupAdder.Font = new Font(groupAdder.Font, FontStyle.Italic);
            groupAdder.ForeColor = GlobalSettings.ForeColor;
            groupAdder.BackColor = GlobalSettings.BackColor;

            groupAdder.Click += HandleGroupAdderClicked;

            tsLaunch.Items.Add(groupAdder);

            tsLaunch.Items.Add(btnMenu);
        }

        private void HandleGroupAdderClicked(object sender, EventArgs e)
        {
            using var f = new Form2AddGroup();
            var result = f.ShowDialog(this);

            if (result == DialogResult.OK)
            {
                Repository.AddGroup(f.GroupName);
                LoadGroups();
            }

        }

        #endregion



        #region " Right-click group menu" 


        // Popup menu for right click on group
        private void HandleGroupMouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Right)
                return;

            ToolStripDropDownButton btn = sender as ToolStripDropDownButton;

            var deleteButton = new ToolStripMenuItem("Delete group...", null, new EventHandler(DeleteGroupHandler));
            deleteButton.Tag = btn;

            var arrangeButton = new ToolStripMenuItem("Edit group...", null, new EventHandler(ArrangeGroupHandler));
            arrangeButton.Tag = btn;

            var renameButton = new ToolStripMenuItem("Rename group...", null, new EventHandler(RenameGroupHandler));
            renameButton.Tag = btn;

            var sep = new ToolStripSeparator();
            var sep2 = new ToolStripSeparator();
            var popup = new ContextMenuStrip();
            popup.Items.Add(deleteButton);
            popup.Items.Add(sep2);
            popup.Items.Add(arrangeButton);
            popup.Items.Add(sep);
            popup.Items.Add(renameButton);
            popup.Show(Cursor.Position.X, Cursor.Position.Y);

        }

        private void ArrangeGroupHandler(object sender, EventArgs e)
        {
            var arrange = (ToolStripMenuItem)sender;
            var btn = (ToolStripDropDownButton)arrange.Tag;
            var group = (GroupDto)btn.Tag;

            using var f = new Form6EditGroup(group);
            var result = f.ShowDialog(this);

            if (result == DialogResult.OK)
            {
                var lb = f.LinkBoxes;

                foreach (MoveableControl item in lb)
                {
                    Repository.UpdateSort(item.GroupId, item.LinkId, item.Order);
                }
                LoadGroups();
            }
        }

        private void DeleteGroupHandler(object sender, EventArgs e)
        {
            var delete = (ToolStripMenuItem)sender;
            var btn = (ToolStripDropDownButton)delete.Tag;
            var group = (GroupDto)btn.Tag;

            var result = MessageBox.Show($"Are you sure you wish to delete the group {group.GroupName}?",
                                         GlobalSettings.AppName,
                                         MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Repository.DeleteGroup(group.GroupID);
                LoadGroups();
            }

        }

        private void RenameGroupHandler(object sender, EventArgs e)
        {
            var rename = (ToolStripMenuItem)sender;
            btnRename = (ToolStripDropDownButton)rename.Tag;

            txtRenameGroup = new ToolStripTextBox();
            txtRenameGroup.Text = btnRename.Text;
            txtRenameGroup.MaxLength = GlobalSettings.MaxGroupNameLength;
            txtRenameGroup.KeyUp += HandleRenameTextboxKeyUp;
            txtRenameGroup.LostFocus += HandleRenameTextboxLostFocus;

            var i = tsLaunch.Items.IndexOf(btnRename);

            txtRenameGroup.SelectAll();

            tsLaunch.Items.Insert(i, txtRenameGroup);

            this.ActiveControl = txtRenameGroup.Control;
            btnRename.Width = 0;
            //tsLaunch.Items.Add(txtRename);

            //using var f = new Form5RenameGroup(btn.Text);
            //var result = f.ShowDialog(this);

            //if (result == DialogResult.OK)
            //{
            //    RenameGroup(btn, f.NewName);
            //}

        }

        private void HandleRenameTextboxLostFocus(object sender, EventArgs e)
        {
            RenameGroupFromTextBox();
        }

        private void HandleRenameTextboxKeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                RenameGroupFromTextBox(); 
                e.Handled = true;
            }
        }

        private void RenameGroupFromTextBox()
        {
            var newName = txtRenameGroup.Text;
                RenameGroup(btnRename, newName);
                //btnRename.Text = newName;
                //btnRename.Width = GlobalSettings.GroupButtonWidth;
        }

        private void RenameGroup(ToolStripDropDownButton btn, string newName)
        {
            var group = (GroupDto)btn.Tag;

            Repository.RenameGroup(group.GroupID, newName);
            LoadGroups();
        }
        #endregion


        #region " Links"

        private void HandleAddLinkClicked(object sender, EventArgs e)
        {
            using var f = new Form3AddLink();
            var result = f.ShowDialog(this);

            if (result == DialogResult.OK)
            {
                ToolStripMenuItem tsmi = (ToolStripMenuItem)sender;
                Repository.AddAndGroupLink(tsmi.Tag.ToString(), f.LinkName, f.LinkPath);
                LoadGroups();
            }
        }

        private void HandleLinkClicked(object sender, EventArgs e)
        {
            var lk = (ToolStripMenuItem)sender;

            if (string.IsNullOrEmpty(lk.Tag.ToString()) == false)
            {
                var expanded = Environment.ExpandEnvironmentVariables(lk.Tag.ToString());
                Process.Start(expanded);
            }
        }

        #endregion



        #region " Setup"
        private void Setup()
        {

            // Create new copy of database if it doesn't exist
            CheckDatabase();

            // todo
            Repository.DbFile = GlobalSettings.DatabaseFileName;

            // Load colors
            var fore = Repository.GetForeColor();
            var back = Repository.GetBackColor();

            GlobalSettings.ForeColor = Color.FromArgb(fore);
            GlobalSettings.BackColor = Color.FromName(back);
            tsLaunch.ForeColor = GlobalSettings.ForeColor;
            tsLaunch.BackColor = GlobalSettings.BackColor;

            tsLaunch.ImageScalingSize = GlobalSettings.MainLaunchImageScalingSize;

            this.Text = GlobalSettings.AppName;
            this.Height = tsLaunch.Height;
            tsLaunch.GripStyle = ToolStripGripStyle.Hidden;

            // App Bar
            AppBarHelper.AppBarMessage = "Usetheforce";
            AppBarHelper.SetAppBar(this, AppBarEdge.Bottom);

            //  Application.RemoveMessageFilter();

        }

        private void CheckDatabase()
        {
            var exists = Repository.DoesDatabaseExist();

            if (exists == false)
            {
                Repository.CreateDatabase();
            }
        }

        #endregion



        #region " Main Menu"

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AppBarHelper.SetAppBar(this, AppBarEdge.None);

            // If I don't call Application.DoEvents() here, the application won't fully shutdown
            // You will have to kill it with Task Manager 
            Application.DoEvents();

            Application.Exit();


        }

        private void SettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using var f = new Form4Settings();
            var result = f.ShowDialog();

            if (result == DialogResult.OK)
            {
                UpdateColors();
            }

        }

        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using var f = new Form7About();
            f.ShowDialog();
        }

        #endregion





        private void UpdateColors()
        {

            Repository.SetForeColor(GlobalSettings.ForeColor);
            Repository.SetBackColor(GlobalSettings.BackColor);

            foreach (var btn in tsLaunch.Items)
            {
                if (btn is ToolStripDropDownButton)
                {
                    var ddb = (ToolStripDropDownButton)btn;
                    ddb.BackColor = GlobalSettings.BackColor;
                    ddb.ForeColor = GlobalSettings.ForeColor;

                    foreach (var a in ddb.DropDownItems)
                    {
                        if (a is ToolStripMenuItem b)
                        {
                            b.ForeColor = GlobalSettings.ForeColor;
                            b.BackColor = GlobalSettings.BackColor;
                        }
                        //if (a is ToolStripSeparator)
                        //{
                        //    var c = (ToolStripSeparator)a;
                        //    c.ForeColor = GlobalConfig.ForeColor;
                        //    c.BackColor = GlobalConfig.BackColor;
                        //}
                    }
                }

                if (btn is ToolStripSeparator sb)
                {
                    sb.ForeColor = GlobalSettings.ForeColor;
                    sb.BackColor = GlobalSettings.BackColor;
                }
                if (btn is ToolStripButton)
                {
                    var ddb = (ToolStripButton)btn;
                    ddb.BackColor = GlobalSettings.BackColor;
                    ddb.ForeColor = GlobalSettings.ForeColor;
                }

                //foreach (var linkButton in ddb.DropDownItems)
                //{
                //    if (linkButton is ToolStripDropDownButton)
                //    {
                //        var ldb = (ToolStripDropDownButton)linkButton;
                //        ldb.ForeColor = GlobalConfig.ForeColor;
                //        ldb.BackColor = GlobalConfig.BackColor;
                //    }
                //}

            }
            tsLaunch.BackColor = GlobalSettings.BackColor;
        }



        // https://stackoverflow.com/a/47103019
        protected override void WndProc(ref Message m)
        {
            const int WM_PARENTNOTIFY = 0x0210;
            if (!this.Focused && m.Msg == WM_PARENTNOTIFY)
            {
                const int WM_CREATE = 0x0001;
                const int WM_DESTROY = 0x0002;
                const int WM_LBUTTONDOWN = 0x0201;
                const int WM_MBUTTONDOWN = 0x0207;
                const int WM_RBUTTONDOWN = 0x0204;
                const int WM_XBUTTONDOWN = 0x020B;
                const int WM_POINTERDOWN = 0x0246;

                int type = (int)(0xFFFF & (long)m.WParam);
                switch (type)
                {
                    case WM_LBUTTONDOWN:
                    case WM_MBUTTONDOWN:
                    case WM_RBUTTONDOWN:
                    case WM_XBUTTONDOWN:
                    case WM_POINTERDOWN:
                        // Make this form auto-grab the focus when menu/controls are clicked
                        this.Activate();
                        break;
                    case WM_DESTROY:
                    case WM_CREATE:
                        //do nothing
                        break;
                }
            }
            base.WndProc(ref m);
        }

        private void editGroupsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using var f = new Form6EditGroup2();
            f.ShowDialog(this);



        }
    }
}
