namespace MarksLauncher.Screens
{
    partial class Form4Settings2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4Settings2));
            label3 = new System.Windows.Forms.Label();
            splitContainer1 = new System.Windows.Forms.SplitContainer();
            lbSettings = new System.Windows.Forms.ListBox();
            tabControl1 = new System.Windows.Forms.TabControl();
            tabPageColors = new System.Windows.Forms.TabPage();
            label4 = new System.Windows.Forms.Label();
            panel1 = new System.Windows.Forms.Panel();
            toolStrip1 = new System.Windows.Forms.ToolStrip();
            btnGroup1 = new System.Windows.Forms.ToolStripDropDownButton();
            toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            btnGroup2 = new System.Windows.Forms.ToolStripDropDownButton();
            pbTextColor = new System.Windows.Forms.PictureBox();
            pbBackcolor = new System.Windows.Forms.PictureBox();
            label2 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            btnUpdate = new System.Windows.Forms.Button();
            tabPageGroupArrange = new System.Windows.Forms.TabPage();
            splitContainer2 = new System.Windows.Forms.SplitContainer();
            lbGroups = new System.Windows.Forms.ListBox();
            splitContainer3 = new System.Windows.Forms.SplitContainer();
            flowLayoutPanelRearrange = new System.Windows.Forms.FlowLayoutPanel();
            button1 = new System.Windows.Forms.Button();
            tabPageGroupEditMembers = new System.Windows.Forms.TabPage();
            splitContainer4 = new System.Windows.Forms.SplitContainer();
            lbEditGroups = new System.Windows.Forms.ListBox();
            splitContainer5 = new System.Windows.Forms.SplitContainer();
            flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPageColors.SuspendLayout();
            panel1.SuspendLayout();
            toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbTextColor).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbBackcolor).BeginInit();
            tabPageGroupArrange.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer2).BeginInit();
            splitContainer2.Panel1.SuspendLayout();
            splitContainer2.Panel2.SuspendLayout();
            splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer3).BeginInit();
            splitContainer3.Panel1.SuspendLayout();
            splitContainer3.Panel2.SuspendLayout();
            splitContainer3.SuspendLayout();
            tabPageGroupEditMembers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer4).BeginInit();
            splitContainer4.Panel1.SuspendLayout();
            splitContainer4.Panel2.SuspendLayout();
            splitContainer4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer5).BeginInit();
            splitContainer5.Panel1.SuspendLayout();
            splitContainer5.Panel2.SuspendLayout();
            splitContainer5.SuspendLayout();
            SuspendLayout();
            // 
            // label3
            // 
            label3.BackColor = System.Drawing.SystemColors.ControlDark;
            label3.Dock = System.Windows.Forms.DockStyle.Top;
            label3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label3.Location = new System.Drawing.Point(0, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(1047, 36);
            label3.TabIndex = 12;
            label3.Text = "     Settings";
            label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            splitContainer1.Location = new System.Drawing.Point(0, 36);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(lbSettings);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(tabControl1);
            splitContainer1.Size = new System.Drawing.Size(1047, 575);
            splitContainer1.SplitterDistance = 236;
            splitContainer1.TabIndex = 13;
            splitContainer1.SplitterMoved += splitContainer1_SplitterMoved;
            // 
            // lbSettings
            // 
            lbSettings.Dock = System.Windows.Forms.DockStyle.Fill;
            lbSettings.FormattingEnabled = true;
            lbSettings.ItemHeight = 15;
            lbSettings.Location = new System.Drawing.Point(0, 0);
            lbSettings.Name = "lbSettings";
            lbSettings.Size = new System.Drawing.Size(236, 575);
            lbSettings.TabIndex = 0;
            lbSettings.SelectedIndexChanged += lbSettings_SelectedIndexChanged;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPageColors);
            tabControl1.Controls.Add(tabPageGroupArrange);
            tabControl1.Controls.Add(tabPageGroupEditMembers);
            tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            tabControl1.Location = new System.Drawing.Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new System.Drawing.Size(807, 575);
            tabControl1.TabIndex = 0;
            // 
            // tabPageColors
            // 
            tabPageColors.BackColor = System.Drawing.SystemColors.Control;
            tabPageColors.Controls.Add(label4);
            tabPageColors.Controls.Add(panel1);
            tabPageColors.Controls.Add(pbTextColor);
            tabPageColors.Controls.Add(pbBackcolor);
            tabPageColors.Controls.Add(label2);
            tabPageColors.Controls.Add(label1);
            tabPageColors.Controls.Add(btnUpdate);
            tabPageColors.Location = new System.Drawing.Point(4, 24);
            tabPageColors.Name = "tabPageColors";
            tabPageColors.Padding = new System.Windows.Forms.Padding(3);
            tabPageColors.Size = new System.Drawing.Size(799, 547);
            tabPageColors.TabIndex = 0;
            tabPageColors.Text = "Colors";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(239, 29);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(51, 15);
            label4.TabIndex = 27;
            label4.Text = "Preview:";
            // 
            // panel1
            // 
            panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            panel1.Controls.Add(toolStrip1);
            panel1.Location = new System.Drawing.Point(239, 47);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(119, 38);
            panel1.TabIndex = 26;
            // 
            // toolStrip1
            // 
            toolStrip1.Dock = System.Windows.Forms.DockStyle.Fill;
            toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { btnGroup1, toolStripSeparator1, btnGroup2 });
            toolStrip1.Location = new System.Drawing.Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new System.Drawing.Size(117, 36);
            toolStrip1.TabIndex = 17;
            toolStrip1.Text = "toolStrip1";
            // 
            // btnGroup1
            // 
            btnGroup1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            btnGroup1.Image = (System.Drawing.Image)resources.GetObject("btnGroup1.Image");
            btnGroup1.ImageTransparentColor = System.Drawing.Color.Magenta;
            btnGroup1.Name = "btnGroup1";
            btnGroup1.ShowDropDownArrow = false;
            btnGroup1.Size = new System.Drawing.Size(53, 33);
            btnGroup1.Text = "Group 1";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new System.Drawing.Size(6, 36);
            // 
            // btnGroup2
            // 
            btnGroup2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            btnGroup2.Image = (System.Drawing.Image)resources.GetObject("btnGroup2.Image");
            btnGroup2.ImageTransparentColor = System.Drawing.Color.Magenta;
            btnGroup2.Name = "btnGroup2";
            btnGroup2.ShowDropDownArrow = false;
            btnGroup2.Size = new System.Drawing.Size(53, 33);
            btnGroup2.Text = "Group 2";
            // 
            // pbTextColor
            // 
            pbTextColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            pbTextColor.Location = new System.Drawing.Point(136, 64);
            pbTextColor.Name = "pbTextColor";
            pbTextColor.Size = new System.Drawing.Size(29, 18);
            pbTextColor.TabIndex = 25;
            pbTextColor.TabStop = false;
            // 
            // pbBackcolor
            // 
            pbBackcolor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            pbBackcolor.Location = new System.Drawing.Point(136, 32);
            pbBackcolor.Name = "pbBackcolor";
            pbBackcolor.Size = new System.Drawing.Size(29, 18);
            pbBackcolor.TabIndex = 24;
            pbBackcolor.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label2.Location = new System.Drawing.Point(62, 64);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(67, 15);
            label2.TabIndex = 23;
            label2.Text = "Text Color:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(21, 32);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(109, 15);
            label1.TabIndex = 22;
            label1.Text = "Background Color:";
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new System.Drawing.Point(240, 139);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new System.Drawing.Size(75, 23);
            btnUpdate.TabIndex = 20;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // tabPageGroupArrange
            // 
            tabPageGroupArrange.BackColor = System.Drawing.SystemColors.Control;
            tabPageGroupArrange.Controls.Add(splitContainer2);
            tabPageGroupArrange.Location = new System.Drawing.Point(4, 24);
            tabPageGroupArrange.Name = "tabPageGroupArrange";
            tabPageGroupArrange.Padding = new System.Windows.Forms.Padding(3);
            tabPageGroupArrange.Size = new System.Drawing.Size(799, 547);
            tabPageGroupArrange.TabIndex = 1;
            tabPageGroupArrange.Text = "AG";
            // 
            // splitContainer2
            // 
            splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            splitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            splitContainer2.Location = new System.Drawing.Point(3, 3);
            splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            splitContainer2.Panel1.Controls.Add(lbGroups);
            // 
            // splitContainer2.Panel2
            // 
            splitContainer2.Panel2.Controls.Add(splitContainer3);
            splitContainer2.Size = new System.Drawing.Size(793, 541);
            splitContainer2.SplitterDistance = 264;
            splitContainer2.TabIndex = 0;
            // 
            // lbGroups
            // 
            lbGroups.Dock = System.Windows.Forms.DockStyle.Fill;
            lbGroups.FormattingEnabled = true;
            lbGroups.ItemHeight = 15;
            lbGroups.Location = new System.Drawing.Point(0, 0);
            lbGroups.Name = "lbGroups";
            lbGroups.Size = new System.Drawing.Size(264, 541);
            lbGroups.TabIndex = 1;
            lbGroups.SelectedIndexChanged += lbGroups_SelectedIndexChanged;
            // 
            // splitContainer3
            // 
            splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            splitContainer3.Location = new System.Drawing.Point(0, 0);
            splitContainer3.Name = "splitContainer3";
            // 
            // splitContainer3.Panel1
            // 
            splitContainer3.Panel1.Controls.Add(flowLayoutPanelRearrange);
            // 
            // splitContainer3.Panel2
            // 
            splitContainer3.Panel2.Controls.Add(button1);
            splitContainer3.Size = new System.Drawing.Size(525, 541);
            splitContainer3.SplitterDistance = 333;
            splitContainer3.TabIndex = 16;
            // 
            // flowLayoutPanelRearrange
            // 
            flowLayoutPanelRearrange.AllowDrop = true;
            flowLayoutPanelRearrange.AutoScroll = true;
            flowLayoutPanelRearrange.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            flowLayoutPanelRearrange.Dock = System.Windows.Forms.DockStyle.Fill;
            flowLayoutPanelRearrange.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            flowLayoutPanelRearrange.Location = new System.Drawing.Point(0, 0);
            flowLayoutPanelRearrange.Name = "flowLayoutPanelRearrange";
            flowLayoutPanelRearrange.Size = new System.Drawing.Size(333, 541);
            flowLayoutPanelRearrange.TabIndex = 15;
            flowLayoutPanelRearrange.WrapContents = false;
            // 
            // button1
            // 
            button1.Location = new System.Drawing.Point(29, 40);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(75, 23);
            button1.TabIndex = 21;
            button1.Text = "Update";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // tabPageGroupEditMembers
            // 
            tabPageGroupEditMembers.BackColor = System.Drawing.SystemColors.Control;
            tabPageGroupEditMembers.Controls.Add(splitContainer4);
            tabPageGroupEditMembers.Location = new System.Drawing.Point(4, 24);
            tabPageGroupEditMembers.Name = "tabPageGroupEditMembers";
            tabPageGroupEditMembers.Padding = new System.Windows.Forms.Padding(3);
            tabPageGroupEditMembers.Size = new System.Drawing.Size(799, 547);
            tabPageGroupEditMembers.TabIndex = 2;
            tabPageGroupEditMembers.Text = "Edit Group Members";
            // 
            // splitContainer4
            // 
            splitContainer4.Dock = System.Windows.Forms.DockStyle.Fill;
            splitContainer4.Location = new System.Drawing.Point(3, 3);
            splitContainer4.Name = "splitContainer4";
            // 
            // splitContainer4.Panel1
            // 
            splitContainer4.Panel1.Controls.Add(lbEditGroups);
            // 
            // splitContainer4.Panel2
            // 
            splitContainer4.Panel2.Controls.Add(splitContainer5);
            splitContainer4.Size = new System.Drawing.Size(793, 541);
            splitContainer4.SplitterDistance = 264;
            splitContainer4.TabIndex = 1;
            // 
            // lbEditGroups
            // 
            lbEditGroups.Dock = System.Windows.Forms.DockStyle.Fill;
            lbEditGroups.FormattingEnabled = true;
            lbEditGroups.ItemHeight = 15;
            lbEditGroups.Location = new System.Drawing.Point(0, 0);
            lbEditGroups.Name = "lbEditGroups";
            lbEditGroups.Size = new System.Drawing.Size(264, 541);
            lbEditGroups.TabIndex = 1;
            // 
            // splitContainer5
            // 
            splitContainer5.Dock = System.Windows.Forms.DockStyle.Fill;
            splitContainer5.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            splitContainer5.Location = new System.Drawing.Point(0, 0);
            splitContainer5.Name = "splitContainer5";
            // 
            // splitContainer5.Panel1
            // 
            splitContainer5.Panel1.Controls.Add(flowLayoutPanel1);
            // 
            // splitContainer5.Panel2
            // 
            splitContainer5.Panel2.Controls.Add(button2);
            splitContainer5.Size = new System.Drawing.Size(525, 541);
            splitContainer5.SplitterDistance = 333;
            splitContainer5.TabIndex = 16;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AllowDrop = true;
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new System.Drawing.Size(333, 541);
            flowLayoutPanel1.TabIndex = 15;
            flowLayoutPanel1.WrapContents = false;
            // 
            // button2
            // 
            button2.Location = new System.Drawing.Point(29, 40);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(75, 23);
            button2.TabIndex = 21;
            button2.Text = "Update";
            button2.UseVisualStyleBackColor = true;
            // 
            // Form4Settings2
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1047, 611);
            Controls.Add(splitContainer1);
            Controls.Add(label3);
            Name = "Form4Settings2";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "Settings";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            tabControl1.ResumeLayout(false);
            tabPageColors.ResumeLayout(false);
            tabPageColors.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbTextColor).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbBackcolor).EndInit();
            tabPageGroupArrange.ResumeLayout(false);
            splitContainer2.Panel1.ResumeLayout(false);
            splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer2).EndInit();
            splitContainer2.ResumeLayout(false);
            splitContainer3.Panel1.ResumeLayout(false);
            splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer3).EndInit();
            splitContainer3.ResumeLayout(false);
            tabPageGroupEditMembers.ResumeLayout(false);
            splitContainer4.Panel1.ResumeLayout(false);
            splitContainer4.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer4).EndInit();
            splitContainer4.ResumeLayout(false);
            splitContainer5.Panel1.ResumeLayout(false);
            splitContainer5.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer5).EndInit();
            splitContainer5.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ListBox lbSettings;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageColors;
        private System.Windows.Forms.TabPage tabPageGroupArrange;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton btnGroup1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripDropDownButton btnGroup2;
        private System.Windows.Forms.PictureBox pbTextColor;
        private System.Windows.Forms.PictureBox pbBackcolor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.ListBox lbGroups;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelRearrange;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabPage tabPageGroupEditMembers;
        private System.Windows.Forms.SplitContainer splitContainer4;
        private System.Windows.Forms.ListBox lbEditGroups;
        private System.Windows.Forms.SplitContainer splitContainer5;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button button2;
    }
}