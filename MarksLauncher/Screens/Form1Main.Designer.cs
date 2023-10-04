
namespace MarksLaunchMenu
{
    partial class Form1Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1Main));
            tsLaunch = new System.Windows.Forms.ToolStrip();
            tsMenuButton = new System.Windows.Forms.ToolStripDropDownButton();
            tsSettingsButton = new System.Windows.Forms.ToolStripMenuItem();
            toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            tsExitButton = new System.Windows.Forms.ToolStripMenuItem();
            toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            tsMenu = new System.Windows.Forms.ToolStrip();
            btnMenu = new System.Windows.Forms.ToolStripDropDownButton();
            settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            contextMenuStripGroups = new System.Windows.Forms.ContextMenuStrip(components);
            tsLaunch.SuspendLayout();
            tsMenu.SuspendLayout();
            SuspendLayout();
            // 
            // tsLaunch
            // 
            tsLaunch.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            tsLaunch.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { tsMenuButton, toolStripDropDownButton1 });
            tsLaunch.Location = new System.Drawing.Point(0, 0);
            tsLaunch.Name = "tsLaunch";
            tsLaunch.Size = new System.Drawing.Size(800, 25);
            tsLaunch.TabIndex = 0;
            tsLaunch.Text = "toolStrip1";
            // 
            // tsMenuButton
            // 
            tsMenuButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            tsMenuButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { tsSettingsButton, toolStripSeparator1, tsExitButton });
            tsMenuButton.Image = (System.Drawing.Image)resources.GetObject("tsMenuButton.Image");
            tsMenuButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            tsMenuButton.Name = "tsMenuButton";
            tsMenuButton.Size = new System.Drawing.Size(51, 22);
            tsMenuButton.Text = "Menu";
            // 
            // tsSettingsButton
            // 
            tsSettingsButton.Name = "tsSettingsButton";
            tsSettingsButton.Size = new System.Drawing.Size(116, 22);
            tsSettingsButton.Text = "Settings";
            tsSettingsButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new System.Drawing.Size(113, 6);
            // 
            // tsExitButton
            // 
            tsExitButton.Name = "tsExitButton";
            tsExitButton.Size = new System.Drawing.Size(116, 22);
            tsExitButton.Text = "Exit";
            // 
            // toolStripDropDownButton1
            // 
            toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            toolStripDropDownButton1.Image = (System.Drawing.Image)resources.GetObject("toolStripDropDownButton1.Image");
            toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            toolStripDropDownButton1.Size = new System.Drawing.Size(29, 22);
            toolStripDropDownButton1.Text = "toolStripDropDownButton1";
            // 
            // tsMenu
            // 
            tsMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { btnMenu });
            tsMenu.Location = new System.Drawing.Point(0, 25);
            tsMenu.Name = "tsMenu";
            tsMenu.Size = new System.Drawing.Size(800, 25);
            tsMenu.TabIndex = 1;
            tsMenu.Text = "toolStrip1";
            tsMenu.Visible = false;
            // 
            // btnMenu
            // 
            btnMenu.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            btnMenu.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            btnMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { settingsToolStripMenuItem, exitToolStripMenuItem, aboutToolStripMenuItem });
            btnMenu.Image = (System.Drawing.Image)resources.GetObject("btnMenu.Image");
            btnMenu.ImageTransparentColor = System.Drawing.Color.Magenta;
            btnMenu.Name = "btnMenu";
            btnMenu.Size = new System.Drawing.Size(51, 22);
            btnMenu.Text = "Menu";
            // 
            // settingsToolStripMenuItem
            // 
            settingsToolStripMenuItem.Image = MarksLauncher.Properties.Resources._9035575_settings_outline_icon;
            settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            settingsToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            settingsToolStripMenuItem.Text = "Settings";
            settingsToolStripMenuItem.Click += SettingsToolStripMenuItem_Click;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Image = MarksLauncher.Properties.Resources._1303884_cancel_close_cross_delete_exit_icon;
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += ExitToolStripMenuItem_Click;
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.Image = MarksLauncher.Properties.Resources.i;
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            aboutToolStripMenuItem.Text = "About";
            aboutToolStripMenuItem.Click += AboutToolStripMenuItem_Click;
            // 
            // contextMenuStripGroups
            // 
            contextMenuStripGroups.Name = "contextMenuStripGroups";
            contextMenuStripGroups.Size = new System.Drawing.Size(61, 4);
            // 
            // Form1Main
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 129);
            Controls.Add(tsMenu);
            Controls.Add(tsLaunch);
            Name = "Form1Main";
            ShowInTaskbar = false;
            Text = "Mark's Launcher";
            Load += Form1_Load;
            tsLaunch.ResumeLayout(false);
            tsLaunch.PerformLayout();
            tsMenu.ResumeLayout(false);
            tsMenu.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.ToolStrip tsLaunch;
        private System.Windows.Forms.ToolStripDropDownButton tsMenuButton;
        private System.Windows.Forms.ToolStripMenuItem tsSettingsButton;
        private System.Windows.Forms.ToolStripMenuItem tsExitButton;
        private System.Windows.Forms.ToolStrip tsMenu;
        private System.Windows.Forms.ToolStripDropDownButton btnMenu;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripGroups;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
    }
}

