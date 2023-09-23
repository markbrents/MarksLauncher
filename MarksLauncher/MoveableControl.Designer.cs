namespace MarksLaunchMenu
{
    partial class MoveableControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            lblLinkDisplayName = new System.Windows.Forms.Label();
            pbIcon = new System.Windows.Forms.PictureBox();
            panel1 = new System.Windows.Forms.Panel();
            contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(components);
            editLinkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)pbIcon).BeginInit();
            panel1.SuspendLayout();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // lblLinkDisplayName
            // 
            lblLinkDisplayName.AutoSize = true;
            lblLinkDisplayName.Enabled = false;
            lblLinkDisplayName.Location = new System.Drawing.Point(41, 16);
            lblLinkDisplayName.Name = "lblLinkDisplayName";
            lblLinkDisplayName.Size = new System.Drawing.Size(38, 15);
            lblLinkDisplayName.TabIndex = 1;
            lblLinkDisplayName.Text = "label1";
            // 
            // pbIcon
            // 
            pbIcon.Enabled = false;
            pbIcon.Location = new System.Drawing.Point(3, 8);
            pbIcon.Name = "pbIcon";
            pbIcon.Size = new System.Drawing.Size(32, 32);
            pbIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pbIcon.TabIndex = 2;
            pbIcon.TabStop = false;
            // 
            // panel1
            // 
            panel1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            panel1.BackColor = System.Drawing.SystemColors.Control;
            panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            panel1.Controls.Add(pbIcon);
            panel1.Controls.Add(lblLinkDisplayName);
            panel1.Enabled = false;
            panel1.Location = new System.Drawing.Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(175, 49);
            panel1.TabIndex = 3;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { editLinkToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new System.Drawing.Size(181, 48);
            // 
            // editLinkToolStripMenuItem
            // 
            editLinkToolStripMenuItem.Name = "editLinkToolStripMenuItem";
            editLinkToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            editLinkToolStripMenuItem.Text = "Delete Link...";
            editLinkToolStripMenuItem.Click += editLinkToolStripMenuItem_Click;
            // 
            // MoveableControl
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.SystemColors.ControlDarkDark;
            ContextMenuStrip = contextMenuStrip1;
            Controls.Add(panel1);
            Name = "MoveableControl";
            Size = new System.Drawing.Size(184, 57);
            MouseDown += MoveableControl_MouseDown;
            ((System.ComponentModel.ISupportInitialize)pbIcon).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Label lblLinkDisplayName;
        private System.Windows.Forms.PictureBox pbIcon;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem editLinkToolStripMenuItem;
    }
}
