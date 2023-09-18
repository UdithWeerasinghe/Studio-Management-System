namespace NEW
{
    partial class chngepwd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(chngepwd));
            this.newpwd = new System.Windows.Forms.TextBox();
            this.btncnge = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnstng = new System.Windows.Forms.Button();
            this.btnhome = new System.Windows.Forms.Button();
            this.btnback = new System.Windows.Forms.Button();
            this.txtun = new System.Windows.Forms.ComboBox();
            this.btnex = new System.Windows.Forms.Button();
            this.btnlogin = new System.Windows.Forms.Button();
            this.txtpwd = new System.Windows.Forms.TextBox();
            this.lblpwd = new System.Windows.Forms.Label();
            this.lblun = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // newpwd
            // 
            this.newpwd.Enabled = false;
            this.newpwd.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newpwd.Location = new System.Drawing.Point(205, 231);
            this.newpwd.Margin = new System.Windows.Forms.Padding(4);
            this.newpwd.Name = "newpwd";
            this.newpwd.Size = new System.Drawing.Size(276, 25);
            this.newpwd.TabIndex = 0;
            // 
            // btncnge
            // 
            this.btncnge.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.btncnge.Enabled = false;
            this.btncnge.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncnge.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btncnge.Location = new System.Drawing.Point(210, 284);
            this.btncnge.Margin = new System.Windows.Forms.Padding(4);
            this.btncnge.Name = "btncnge";
            this.btncnge.Size = new System.Drawing.Size(126, 56);
            this.btncnge.TabIndex = 1;
            this.btncnge.Text = "Change";
            this.btncnge.UseVisualStyleBackColor = false;
            this.btncnge.Click += new System.EventHandler(this.btncnge_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(117, 233);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Type New";
            // 
            // btnstng
            // 
            this.btnstng.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnstng.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnstng.BackgroundImage")));
            this.btnstng.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnstng.Location = new System.Drawing.Point(963, 13);
            this.btnstng.Margin = new System.Windows.Forms.Padding(4);
            this.btnstng.Name = "btnstng";
            this.btnstng.Size = new System.Drawing.Size(47, 48);
            this.btnstng.TabIndex = 12;
            this.btnstng.UseVisualStyleBackColor = false;
            this.btnstng.Click += new System.EventHandler(this.btnstng_Click);
            // 
            // btnhome
            // 
            this.btnhome.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnhome.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnhome.BackgroundImage")));
            this.btnhome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnhome.Location = new System.Drawing.Point(907, 13);
            this.btnhome.Margin = new System.Windows.Forms.Padding(4);
            this.btnhome.Name = "btnhome";
            this.btnhome.Size = new System.Drawing.Size(47, 48);
            this.btnhome.TabIndex = 11;
            this.btnhome.UseVisualStyleBackColor = false;
            this.btnhome.Click += new System.EventHandler(this.btnhome_Click);
            // 
            // btnback
            // 
            this.btnback.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnback.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnback.BackgroundImage")));
            this.btnback.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnback.Location = new System.Drawing.Point(851, 13);
            this.btnback.Margin = new System.Windows.Forms.Padding(4);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(47, 48);
            this.btnback.TabIndex = 10;
            this.btnback.UseVisualStyleBackColor = false;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // txtun
            // 
            this.txtun.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtun.FormattingEnabled = true;
            this.txtun.Items.AddRange(new object[] {
            "Admin"});
            this.txtun.Location = new System.Drawing.Point(205, 97);
            this.txtun.Name = "txtun";
            this.txtun.Size = new System.Drawing.Size(276, 26);
            this.txtun.TabIndex = 26;
            // 
            // btnex
            // 
            this.btnex.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.btnex.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnex.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnex.Location = new System.Drawing.Point(343, 284);
            this.btnex.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnex.Name = "btnex";
            this.btnex.Size = new System.Drawing.Size(126, 56);
            this.btnex.TabIndex = 25;
            this.btnex.Text = "Cancel";
            this.btnex.UseVisualStyleBackColor = false;
            // 
            // btnlogin
            // 
            this.btnlogin.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.btnlogin.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlogin.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnlogin.Location = new System.Drawing.Point(267, 167);
            this.btnlogin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Size = new System.Drawing.Size(126, 56);
            this.btnlogin.TabIndex = 24;
            this.btnlogin.Text = "Confirm";
            this.btnlogin.UseVisualStyleBackColor = false;
            this.btnlogin.Click += new System.EventHandler(this.btnlogin_Click);
            // 
            // txtpwd
            // 
            this.txtpwd.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpwd.Location = new System.Drawing.Point(205, 129);
            this.txtpwd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtpwd.Name = "txtpwd";
            this.txtpwd.Size = new System.Drawing.Size(276, 25);
            this.txtpwd.TabIndex = 23;
            this.txtpwd.UseSystemPasswordChar = true;
            this.txtpwd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtpwd_KeyPress);
            // 
            // lblpwd
            // 
            this.lblpwd.AutoSize = true;
            this.lblpwd.BackColor = System.Drawing.Color.Transparent;
            this.lblpwd.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpwd.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblpwd.Location = new System.Drawing.Point(117, 134);
            this.lblpwd.Name = "lblpwd";
            this.lblpwd.Size = new System.Drawing.Size(76, 23);
            this.lblpwd.TabIndex = 22;
            this.lblpwd.Text = "Password";
            // 
            // lblun
            // 
            this.lblun.AutoSize = true;
            this.lblun.BackColor = System.Drawing.Color.Transparent;
            this.lblun.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblun.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblun.Location = new System.Drawing.Point(117, 97);
            this.lblun.Name = "lblun";
            this.lblun.Size = new System.Drawing.Size(90, 23);
            this.lblun.TabIndex = 21;
            this.lblun.Text = "User Name";
            // 
            // chngepwd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1023, 741);
            this.ControlBox = false;
            this.Controls.Add(this.txtun);
            this.Controls.Add(this.btnex);
            this.Controls.Add(this.btnlogin);
            this.Controls.Add(this.txtpwd);
            this.Controls.Add(this.lblpwd);
            this.Controls.Add(this.lblun);
            this.Controls.Add(this.btnstng);
            this.Controls.Add(this.btnhome);
            this.Controls.Add(this.btnback);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btncnge);
            this.Controls.Add(this.newpwd);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "chngepwd";
            this.Text = "New Password";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox newpwd;
        private System.Windows.Forms.Button btncnge;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnstng;
        private System.Windows.Forms.Button btnhome;
        private System.Windows.Forms.Button btnback;
        private System.Windows.Forms.ComboBox txtun;
        private System.Windows.Forms.Button btnex;
        private System.Windows.Forms.Button btnlogin;
        private System.Windows.Forms.TextBox txtpwd;
        private System.Windows.Forms.Label lblpwd;
        private System.Windows.Forms.Label lblun;
    }
}