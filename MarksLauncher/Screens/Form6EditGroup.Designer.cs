namespace MarksLaunchMenu
{
    partial class Form6EditGroup
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
            label3 = new System.Windows.Forms.Label();
            flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            panel1 = new System.Windows.Forms.Panel();
            label1 = new System.Windows.Forms.Label();
            btnOK = new System.Windows.Forms.Button();
            btnCancel = new System.Windows.Forms.Button();
            label2 = new System.Windows.Forms.Label();
            lblGroupName = new System.Windows.Forms.Label();
            btnBrowse = new System.Windows.Forms.Button();
            txtName = new System.Windows.Forms.TextBox();
            label4 = new System.Windows.Forms.Label();
            txtPath = new System.Windows.Forms.TextBox();
            label5 = new System.Windows.Forms.Label();
            btnEditLink = new System.Windows.Forms.Button();
            txtLinkId = new System.Windows.Forms.TextBox();
            txtArguments = new System.Windows.Forms.TextBox();
            label6 = new System.Windows.Forms.Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label3
            // 
            label3.BackColor = System.Drawing.SystemColors.ControlDark;
            label3.Dock = System.Windows.Forms.DockStyle.Top;
            label3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label3.Location = new System.Drawing.Point(0, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(839, 36);
            label3.TabIndex = 13;
            label3.Text = "     Edit Group";
            label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AllowDrop = true;
            flowLayoutPanel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new System.Drawing.Size(193, 416);
            flowLayoutPanel1.TabIndex = 14;
            flowLayoutPanel1.DragDrop += flowLayoutPanel1_DragDrop;
            flowLayoutPanel1.DragEnter += flowLayoutPanel1_DragEnter;
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.AutoSize = true;
            panel1.Controls.Add(flowLayoutPanel1);
            panel1.Location = new System.Drawing.Point(51, 71);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(193, 416);
            panel1.TabIndex = 15;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(74, 501);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(134, 15);
            label1.TabIndex = 16;
            label1.Text = "Drap Items to Rearrange";
            // 
            // btnOK
            // 
            btnOK.Location = new System.Drawing.Point(291, 87);
            btnOK.Name = "btnOK";
            btnOK.Size = new System.Drawing.Size(75, 23);
            btnOK.TabIndex = 17;
            btnOK.Text = "OK";
            btnOK.UseVisualStyleBackColor = true;
            btnOK.Click += btnOK_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new System.Drawing.Point(291, 116);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new System.Drawing.Size(75, 23);
            btnCancel.TabIndex = 18;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label2.Location = new System.Drawing.Point(51, 48);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(57, 20);
            label2.TabIndex = 19;
            label2.Text = "Group:";
            // 
            // lblGroupName
            // 
            lblGroupName.AutoSize = true;
            lblGroupName.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblGroupName.Location = new System.Drawing.Point(106, 48);
            lblGroupName.Name = "lblGroupName";
            lblGroupName.Size = new System.Drawing.Size(15, 20);
            lblGroupName.TabIndex = 20;
            lblGroupName.Text = "_";
            // 
            // btnBrowse
            // 
            btnBrowse.Location = new System.Drawing.Point(789, 173);
            btnBrowse.Name = "btnBrowse";
            btnBrowse.Size = new System.Drawing.Size(27, 23);
            btnBrowse.TabIndex = 22;
            btnBrowse.Text = "...";
            btnBrowse.UseVisualStyleBackColor = true;
            btnBrowse.Visible = false;
            // 
            // txtName
            // 
            txtName.Enabled = false;
            txtName.Location = new System.Drawing.Point(347, 267);
            txtName.MaxLength = 50;
            txtName.Name = "txtName";
            txtName.Size = new System.Drawing.Size(128, 23);
            txtName.TabIndex = 23;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label4.Location = new System.Drawing.Point(256, 270);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(85, 15);
            label4.TabIndex = 27;
            label4.Text = "Display Name:";
            // 
            // txtPath
            // 
            txtPath.Enabled = false;
            txtPath.Location = new System.Drawing.Point(347, 173);
            txtPath.MaxLength = 255;
            txtPath.Name = "txtPath";
            txtPath.Size = new System.Drawing.Size(426, 23);
            txtPath.TabIndex = 21;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label5.Location = new System.Drawing.Point(306, 176);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(35, 15);
            label5.TabIndex = 26;
            label5.Text = "Path:";
            // 
            // btnEditLink
            // 
            btnEditLink.Location = new System.Drawing.Point(698, 266);
            btnEditLink.Name = "btnEditLink";
            btnEditLink.Size = new System.Drawing.Size(75, 23);
            btnEditLink.TabIndex = 28;
            btnEditLink.Text = "Edit Link...";
            btnEditLink.UseVisualStyleBackColor = true;
            btnEditLink.Click += btnEditLink_Click;
            // 
            // txtLinkId
            // 
            txtLinkId.Enabled = false;
            txtLinkId.Location = new System.Drawing.Point(347, 309);
            txtLinkId.MaxLength = 50;
            txtLinkId.Name = "txtLinkId";
            txtLinkId.Size = new System.Drawing.Size(128, 23);
            txtLinkId.TabIndex = 29;
            txtLinkId.Visible = false;
            // 
            // txtArguments
            // 
            txtArguments.Enabled = false;
            txtArguments.Location = new System.Drawing.Point(347, 218);
            txtArguments.MaxLength = 255;
            txtArguments.Name = "txtArguments";
            txtArguments.Size = new System.Drawing.Size(426, 23);
            txtArguments.TabIndex = 30;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label6.Location = new System.Drawing.Point(269, 221);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(72, 15);
            label6.TabIndex = 31;
            label6.Text = "Arguments:";
            // 
            // Form6EditGroup
            // 
            AcceptButton = btnOK;
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.SystemColors.ControlLight;
            CancelButton = btnCancel;
            ClientSize = new System.Drawing.Size(839, 583);
            Controls.Add(txtArguments);
            Controls.Add(label6);
            Controls.Add(txtLinkId);
            Controls.Add(btnEditLink);
            Controls.Add(btnBrowse);
            Controls.Add(txtName);
            Controls.Add(label4);
            Controls.Add(txtPath);
            Controls.Add(label5);
            Controls.Add(lblGroupName);
            Controls.Add(label2);
            Controls.Add(btnCancel);
            Controls.Add(btnOK);
            Controls.Add(label1);
            Controls.Add(panel1);
            Controls.Add(label3);
            Name = "Form6EditGroup";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "Edit Group";
            Load += Form6_Load;
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblGroupName;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnEditLink;
        private System.Windows.Forms.TextBox txtLinkId;
        private System.Windows.Forms.TextBox txtArguments;
        private System.Windows.Forms.Label label6;
    }
}