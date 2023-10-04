namespace MarksLaunchMenu
{
    partial class Form4Settings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4Settings));
            btnOk = new System.Windows.Forms.Button();
            btnCancel = new System.Windows.Forms.Button();
            label3 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            colorDialog1 = new System.Windows.Forms.ColorDialog();
            pbBackcolor = new System.Windows.Forms.PictureBox();
            pbTextColor = new System.Windows.Forms.PictureBox();
            toolStrip1 = new System.Windows.Forms.ToolStrip();
            btnGroup1 = new System.Windows.Forms.ToolStripDropDownButton();
            toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            btnGroup2 = new System.Windows.Forms.ToolStripDropDownButton();
            panel1 = new System.Windows.Forms.Panel();
            label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)pbBackcolor).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbTextColor).BeginInit();
            toolStrip1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnOk
            // 
            btnOk.Location = new System.Drawing.Point(142, 232);
            btnOk.Name = "btnOk";
            btnOk.Size = new System.Drawing.Size(75, 23);
            btnOk.TabIndex = 0;
            btnOk.Text = "OK";
            btnOk.UseVisualStyleBackColor = true;
            btnOk.Click += BtnOk_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new System.Drawing.Point(236, 232);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new System.Drawing.Size(75, 23);
            btnCancel.TabIndex = 1;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += BtnCancel_Click;
            // 
            // label3
            // 
            label3.BackColor = System.Drawing.SystemColors.ControlDark;
            label3.Dock = System.Windows.Forms.DockStyle.Top;
            label3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label3.Location = new System.Drawing.Point(0, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(454, 36);
            label3.TabIndex = 12;
            label3.Text = "     Settings";
            label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(30, 72);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(106, 15);
            label1.TabIndex = 13;
            label1.Text = "Background Color:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(71, 104);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(63, 15);
            label2.TabIndex = 14;
            label2.Text = "Text Color:";
            // 
            // pbBackcolor
            // 
            pbBackcolor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            pbBackcolor.Location = new System.Drawing.Point(142, 69);
            pbBackcolor.Name = "pbBackcolor";
            pbBackcolor.Size = new System.Drawing.Size(29, 18);
            pbBackcolor.TabIndex = 15;
            pbBackcolor.TabStop = false;
            pbBackcolor.Click += pbBackcolor_Click;
            // 
            // pbTextColor
            // 
            pbTextColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            pbTextColor.Location = new System.Drawing.Point(142, 101);
            pbTextColor.Name = "pbTextColor";
            pbTextColor.Size = new System.Drawing.Size(29, 18);
            pbTextColor.TabIndex = 16;
            pbTextColor.TabStop = false;
            pbTextColor.Click += pbTextColor_Click;
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
            // panel1
            // 
            panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            panel1.Controls.Add(toolStrip1);
            panel1.Location = new System.Drawing.Point(248, 87);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(119, 38);
            panel1.TabIndex = 18;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(248, 69);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(51, 15);
            label4.TabIndex = 19;
            label4.Text = "Preview:";
            // 
            // Form4
            // 
            AcceptButton = btnOk;
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            CancelButton = btnCancel;
            ClientSize = new System.Drawing.Size(454, 315);
            Controls.Add(label4);
            Controls.Add(panel1);
            Controls.Add(pbTextColor);
            Controls.Add(pbBackcolor);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(label3);
            Controls.Add(btnCancel);
            Controls.Add(btnOk);
            Name = "Form4";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "Settings";
            Load += Form4_Load;
            ((System.ComponentModel.ISupportInitialize)pbBackcolor).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbTextColor).EndInit();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.PictureBox pbBackcolor;
        private System.Windows.Forms.PictureBox pbTextColor;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton btnGroup1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripDropDownButton btnGroup2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
    }
}