
namespace MarksLaunchMenu
{
    partial class Form3AddLink
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
            btnCancel = new System.Windows.Forms.Button();
            btnAdd = new System.Windows.Forms.Button();
            txtPath = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            txtName = new System.Windows.Forms.TextBox();
            btnBrowse = new System.Windows.Forms.Button();
            label3 = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // btnCancel
            // 
            btnCancel.Location = new System.Drawing.Point(518, 99);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new System.Drawing.Size(75, 28);
            btnCancel.TabIndex = 4;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += BtnCancel_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new System.Drawing.Point(428, 99);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new System.Drawing.Size(75, 28);
            btnAdd.TabIndex = 3;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += BtnAdd_Click;
            // 
            // txtPath
            // 
            txtPath.Location = new System.Drawing.Point(124, 53);
            txtPath.MaxLength = 255;
            txtPath.Name = "txtPath";
            txtPath.Size = new System.Drawing.Size(426, 23);
            txtPath.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(83, 56);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(35, 15);
            label1.TabIndex = 4;
            label1.Text = "Path:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label2.Location = new System.Drawing.Point(33, 97);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(85, 15);
            label2.TabIndex = 8;
            label2.Text = "Display Name:";
            // 
            // txtName
            // 
            txtName.Location = new System.Drawing.Point(124, 94);
            txtName.MaxLength = 50;
            txtName.Name = "txtName";
            txtName.Size = new System.Drawing.Size(128, 23);
            txtName.TabIndex = 2;
            // 
            // btnBrowse
            // 
            btnBrowse.Location = new System.Drawing.Point(566, 53);
            btnBrowse.Name = "btnBrowse";
            btnBrowse.Size = new System.Drawing.Size(27, 23);
            btnBrowse.TabIndex = 1;
            btnBrowse.Text = "...";
            btnBrowse.UseVisualStyleBackColor = true;
            btnBrowse.Click += BtnBrowse_Click;
            // 
            // label3
            // 
            label3.BackColor = System.Drawing.SystemColors.ControlDark;
            label3.Dock = System.Windows.Forms.DockStyle.Top;
            label3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label3.Location = new System.Drawing.Point(0, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(645, 36);
            label3.TabIndex = 11;
            label3.Text = "     Add Links";
            label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Form3AddLink
            // 
            AcceptButton = btnAdd;
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            CancelButton = btnCancel;
            ClientSize = new System.Drawing.Size(645, 172);
            Controls.Add(label3);
            Controls.Add(btnBrowse);
            Controls.Add(txtName);
            Controls.Add(label2);
            Controls.Add(btnCancel);
            Controls.Add(btnAdd);
            Controls.Add(txtPath);
            Controls.Add(label1);
            Name = "Form3AddLink";
            ShowInTaskbar = false;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "Add Link to Group";
            Load += Form3_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Label label3;
    }
}