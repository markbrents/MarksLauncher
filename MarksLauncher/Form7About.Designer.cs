namespace MarksLaunchMenu
{
    partial class Form7About
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form7About));
            label3 = new System.Windows.Forms.Label();
            lblAppName = new System.Windows.Forms.Label();
            lblThirdParty = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            llAppBar = new System.Windows.Forms.LinkLabel();
            label2 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            textBox1 = new System.Windows.Forms.TextBox();
            label6 = new System.Windows.Forms.Label();
            btnOK = new System.Windows.Forms.Button();
            lblVersion = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // label3
            // 
            label3.BackColor = System.Drawing.SystemColors.ControlDark;
            label3.Dock = System.Windows.Forms.DockStyle.Top;
            label3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label3.Location = new System.Drawing.Point(0, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(753, 36);
            label3.TabIndex = 14;
            label3.Text = "     About ";
            label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblAppName
            // 
            lblAppName.AutoSize = true;
            lblAppName.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblAppName.Location = new System.Drawing.Point(27, 49);
            lblAppName.Name = "lblAppName";
            lblAppName.Size = new System.Drawing.Size(15, 20);
            lblAppName.TabIndex = 15;
            lblAppName.Text = "_";
            // 
            // lblThirdParty
            // 
            lblThirdParty.AutoSize = true;
            lblThirdParty.Location = new System.Drawing.Point(27, 184);
            lblThirdParty.Name = "lblThirdParty";
            lblThirdParty.Size = new System.Drawing.Size(85, 15);
            lblThirdParty.TabIndex = 16;
            lblThirdParty.Text = "3rd Party Code";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(52, 210);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(81, 15);
            label1.TabIndex = 17;
            label1.Text = "AppBarHelper";
            // 
            // llAppBar
            // 
            llAppBar.AutoSize = true;
            llAppBar.Location = new System.Drawing.Point(52, 236);
            llAppBar.Name = "llAppBar";
            llAppBar.Size = new System.Drawing.Size(273, 15);
            llAppBar.TabIndex = 19;
            llAppBar.TabStop = true;
            llAppBar.Text = "https://github.com/tip2tail/t2tWinFormAppBarLib";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(52, 261);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(172, 15);
            label2.TabIndex = 20;
            label2.Text = "Licensed under the MIT License";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(27, 100);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(153, 15);
            label4.TabIndex = 21;
            label4.Text = "Copyright 2023 Mark Brents";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(27, 125);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(172, 15);
            label5.TabIndex = 22;
            label5.Text = "Licensed under the MIT License";
            // 
            // textBox1
            // 
            textBox1.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            textBox1.Location = new System.Drawing.Point(370, 49);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            textBox1.Size = new System.Drawing.Size(334, 323);
            textBox1.TabIndex = 23;
            textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // label6
            // 
            label6.BackColor = System.Drawing.Color.Black;
            label6.Location = new System.Drawing.Point(25, 169);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(300, 5);
            label6.TabIndex = 24;
            label6.Text = "_";
            // 
            // btnOK
            // 
            btnOK.Location = new System.Drawing.Point(629, 397);
            btnOK.Name = "btnOK";
            btnOK.Size = new System.Drawing.Size(75, 23);
            btnOK.TabIndex = 25;
            btnOK.Text = "OK";
            btnOK.UseVisualStyleBackColor = true;
            btnOK.Click += button1_Click;
            // 
            // lblVersion
            // 
            lblVersion.AutoSize = true;
            lblVersion.Location = new System.Drawing.Point(27, 79);
            lblVersion.Name = "lblVersion";
            lblVersion.Size = new System.Drawing.Size(12, 15);
            lblVersion.TabIndex = 26;
            lblVersion.Text = "_";
            // 
            // Form7About
            // 
            AcceptButton = btnOK;
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(753, 450);
            Controls.Add(lblVersion);
            Controls.Add(btnOK);
            Controls.Add(label6);
            Controls.Add(textBox1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(llAppBar);
            Controls.Add(label1);
            Controls.Add(lblThirdParty);
            Controls.Add(lblAppName);
            Controls.Add(label3);
            Name = "Form7About";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "Form7About";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblAppName;
        private System.Windows.Forms.Label lblThirdParty;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel llAppBar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Label lblVersion;
    }
}