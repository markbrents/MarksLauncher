namespace MarksLaunchMenu
{
    partial class Form6EditGroup2
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
            lbGroups = new System.Windows.Forms.ListBox();
            flpLinks = new System.Windows.Forms.FlowLayoutPanel();
            txtLinkId = new System.Windows.Forms.TextBox();
            btnEditLink = new System.Windows.Forms.Button();
            btnBrowse = new System.Windows.Forms.Button();
            txtName = new System.Windows.Forms.TextBox();
            label4 = new System.Windows.Forms.Label();
            txtPath = new System.Windows.Forms.TextBox();
            label5 = new System.Windows.Forms.Label();
            splitContainer1 = new System.Windows.Forms.SplitContainer();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            SuspendLayout();
            // 
            // lbGroups
            // 
            lbGroups.Dock = System.Windows.Forms.DockStyle.Fill;
            lbGroups.FormattingEnabled = true;
            lbGroups.ItemHeight = 15;
            lbGroups.Location = new System.Drawing.Point(0, 0);
            lbGroups.Name = "lbGroups";
            lbGroups.Size = new System.Drawing.Size(182, 595);
            lbGroups.TabIndex = 0;
            lbGroups.SelectedIndexChanged += lbGroups_SelectedIndexChanged;
            // 
            // flpLinks
            // 
            flpLinks.AllowDrop = true;
            flpLinks.BackColor = System.Drawing.SystemColors.ControlLight;
            flpLinks.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            flpLinks.Location = new System.Drawing.Point(32, 20);
            flpLinks.Name = "flpLinks";
            flpLinks.Size = new System.Drawing.Size(185, 364);
            flpLinks.TabIndex = 15;
            // 
            // txtLinkId
            // 
            txtLinkId.Enabled = false;
            txtLinkId.Location = new System.Drawing.Point(275, 134);
            txtLinkId.MaxLength = 50;
            txtLinkId.Name = "txtLinkId";
            txtLinkId.Size = new System.Drawing.Size(128, 23);
            txtLinkId.TabIndex = 36;
            // 
            // btnEditLink
            // 
            btnEditLink.Location = new System.Drawing.Point(421, 67);
            btnEditLink.Name = "btnEditLink";
            btnEditLink.Size = new System.Drawing.Size(75, 23);
            btnEditLink.TabIndex = 35;
            btnEditLink.Text = "Edit Link...";
            btnEditLink.UseVisualStyleBackColor = true;
            btnEditLink.Click += btnEditLink_Click;
            // 
            // btnBrowse
            // 
            btnBrowse.Location = new System.Drawing.Point(514, 67);
            btnBrowse.Name = "btnBrowse";
            btnBrowse.Size = new System.Drawing.Size(27, 23);
            btnBrowse.TabIndex = 31;
            btnBrowse.Text = "...";
            btnBrowse.UseVisualStyleBackColor = true;
            btnBrowse.Visible = false;
            // 
            // txtName
            // 
            txtName.Enabled = false;
            txtName.Location = new System.Drawing.Point(275, 105);
            txtName.MaxLength = 50;
            txtName.Name = "txtName";
            txtName.Size = new System.Drawing.Size(128, 23);
            txtName.TabIndex = 32;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label4.Location = new System.Drawing.Point(275, 87);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(85, 15);
            label4.TabIndex = 34;
            label4.Text = "Display Name:";
            // 
            // txtPath
            // 
            txtPath.Enabled = false;
            txtPath.Location = new System.Drawing.Point(275, 38);
            txtPath.MaxLength = 255;
            txtPath.Name = "txtPath";
            txtPath.Size = new System.Drawing.Size(426, 23);
            txtPath.TabIndex = 30;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label5.Location = new System.Drawing.Point(275, 20);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(35, 15);
            label5.TabIndex = 33;
            label5.Text = "Path:";
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            splitContainer1.Location = new System.Drawing.Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(lbGroups);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(flpLinks);
            splitContainer1.Panel2.Controls.Add(btnEditLink);
            splitContainer1.Panel2.Controls.Add(btnBrowse);
            splitContainer1.Panel2.Controls.Add(txtLinkId);
            splitContainer1.Panel2.Controls.Add(label5);
            splitContainer1.Panel2.Controls.Add(txtPath);
            splitContainer1.Panel2.Controls.Add(label4);
            splitContainer1.Panel2.Controls.Add(txtName);
            splitContainer1.Size = new System.Drawing.Size(1094, 595);
            splitContainer1.SplitterDistance = 182;
            splitContainer1.TabIndex = 37;
            // 
            // Form6EditGroup2
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1094, 595);
            Controls.Add(splitContainer1);
            Name = "Form6EditGroup2";
            Text = "Edit Groups";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.ListBox lbGroups;
        private System.Windows.Forms.FlowLayoutPanel flpLinks;
        private System.Windows.Forms.TextBox txtLinkId;
        private System.Windows.Forms.Button btnEditLink;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.SplitContainer splitContainer1;
    }
}