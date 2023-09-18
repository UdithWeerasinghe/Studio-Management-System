namespace NEW
{
    partial class set
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(set));
            this.txtbkup = new System.Windows.Forms.MaskedTextBox();
            this.btnset = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnsett = new System.Windows.Forms.Button();
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
            // txtbkup
            // 
            this.txtbkup.Enabled = false;
            this.txtbkup.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbkup.Location = new System.Drawing.Point(252, 247);
            this.txtbkup.Mask = "####";
            this.txtbkup.Name = "txtbkup";
            this.txtbkup.Size = new System.Drawing.Size(274, 25);
            this.txtbkup.TabIndex = 9;
            this.txtbkup.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbkup_KeyPress);
            // 
            // btnset
            // 
            this.btnset.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.btnset.Enabled = false;
            this.btnset.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnset.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnset.Location = new System.Drawing.Point(258, 293);
            this.btnset.Name = "btnset";
            this.btnset.Size = new System.Drawing.Size(126, 56);
            this.btnset.TabIndex = 8;
            this.btnset.Text = "Set";
            this.btnset.UseVisualStyleBackColor = false;
            this.btnset.Click += new System.EventHandler(this.btnset_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(121, 243);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 23);
            this.label2.TabIndex = 7;
            this.label2.Text = "Set Backup Key";
            // 
            // btnsett
            // 
            this.btnsett.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnsett.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnsett.BackgroundImage")));
            this.btnsett.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnsett.Location = new System.Drawing.Point(963, 13);
            this.btnsett.Margin = new System.Windows.Forms.Padding(4);
            this.btnsett.Name = "btnsett";
            this.btnsett.Size = new System.Drawing.Size(47, 48);
            this.btnsett.TabIndex = 35;
            this.btnsett.UseVisualStyleBackColor = false;
            this.btnsett.Click += new System.EventHandler(this.button3_Click);
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
            this.btnhome.TabIndex = 34;
            this.btnhome.UseVisualStyleBackColor = false;
            this.btnhome.Click += new System.EventHandler(this.button1_Click);
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
            this.btnback.TabIndex = 33;
            this.btnback.UseVisualStyleBackColor = false;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // txtun
            // 
            this.txtun.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtun.FormattingEnabled = true;
            this.txtun.Items.AddRange(new object[] {
            "Admin"});
            this.txtun.Location = new System.Drawing.Point(250, 101);
            this.txtun.Name = "txtun";
            this.txtun.Size = new System.Drawing.Size(276, 26);
            this.txtun.TabIndex = 41;
            // 
            // btnex
            // 
            this.btnex.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.btnex.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnex.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnex.Location = new System.Drawing.Point(390, 293);
            this.btnex.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnex.Name = "btnex";
            this.btnex.Size = new System.Drawing.Size(126, 56);
            this.btnex.TabIndex = 40;
            this.btnex.Text = "Cancel";
            this.btnex.UseVisualStyleBackColor = false;
            this.btnex.Click += new System.EventHandler(this.btnex_Click);
            // 
            // btnlogin
            // 
            this.btnlogin.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.btnlogin.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlogin.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnlogin.Location = new System.Drawing.Point(306, 166);
            this.btnlogin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Size = new System.Drawing.Size(126, 56);
            this.btnlogin.TabIndex = 39;
            this.btnlogin.Text = "Confirm";
            this.btnlogin.UseVisualStyleBackColor = false;
            this.btnlogin.Click += new System.EventHandler(this.btnlogin_Click_1);
            // 
            // txtpwd
            // 
            this.txtpwd.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpwd.Location = new System.Drawing.Point(250, 133);
            this.txtpwd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtpwd.Name = "txtpwd";
            this.txtpwd.Size = new System.Drawing.Size(276, 25);
            this.txtpwd.TabIndex = 38;
            this.txtpwd.UseSystemPasswordChar = true;
            this.txtpwd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtpwd_KeyPress);
            // 
            // lblpwd
            // 
            this.lblpwd.AutoSize = true;
            this.lblpwd.BackColor = System.Drawing.Color.Transparent;
            this.lblpwd.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpwd.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblpwd.Location = new System.Drawing.Point(126, 138);
            this.lblpwd.Name = "lblpwd";
            this.lblpwd.Size = new System.Drawing.Size(76, 23);
            this.lblpwd.TabIndex = 37;
            this.lblpwd.Text = "Password";
            // 
            // lblun
            // 
            this.lblun.AutoSize = true;
            this.lblun.BackColor = System.Drawing.Color.Transparent;
            this.lblun.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblun.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblun.Location = new System.Drawing.Point(126, 101);
            this.lblun.Name = "lblun";
            this.lblun.Size = new System.Drawing.Size(90, 23);
            this.lblun.TabIndex = 36;
            this.lblun.Text = "User Name";
            // 
            // set
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1023, 750);
            this.ControlBox = false;
            this.Controls.Add(this.txtun);
            this.Controls.Add(this.btnex);
            this.Controls.Add(this.btnlogin);
            this.Controls.Add(this.txtpwd);
            this.Controls.Add(this.lblpwd);
            this.Controls.Add(this.lblun);
            this.Controls.Add(this.btnsett);
            this.Controls.Add(this.btnhome);
            this.Controls.Add(this.btnback);
            this.Controls.Add(this.txtbkup);
            this.Controls.Add(this.btnset);
            this.Controls.Add(this.label2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "set";
            this.Text = "Set BackUp Key";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox txtbkup;
        private System.Windows.Forms.Button btnset;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnsett;
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