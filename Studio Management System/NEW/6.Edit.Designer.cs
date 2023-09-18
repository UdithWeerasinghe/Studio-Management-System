namespace NEW
{
    partial class proedit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(proedit));
            this.mskno = new System.Windows.Forms.MaskedTextBox();
            this.btnsrc2 = new System.Windows.Forms.Button();
            this.allbata = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.othrc = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dtp1 = new System.Windows.Forms.DateTimePicker();
            this.txtadv = new System.Windows.Forms.TextBox();
            this.txtpac = new System.Windows.Forms.TextBox();
            this.txtcn = new System.Windows.Forms.TextBox();
            this.txthtl = new System.Windows.Forms.TextBox();
            this.txtev = new System.Windows.Forms.TextBox();
            this.txtpn = new System.Windows.Forms.TextBox();
            this.lbladv = new System.Windows.Forms.Label();
            this.lblpac = new System.Windows.Forms.Label();
            this.lblcn = new System.Windows.Forms.Label();
            this.lblhtl = new System.Windows.Forms.Label();
            this.lblev = new System.Windows.Forms.Label();
            this.lbldt = new System.Windows.Forms.Label();
            this.lblpn = new System.Windows.Forms.Label();
            this.btnedit = new System.Windows.Forms.Button();
            this.btnsv = new System.Windows.Forms.Button();
            this.btnstng = new System.Windows.Forms.Button();
            this.btnhome = new System.Windows.Forms.Button();
            this.btnback = new System.Windows.Forms.Button();
            this.txtcntct = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // mskno
            // 
            this.mskno.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskno.Location = new System.Drawing.Point(49, 38);
            this.mskno.Margin = new System.Windows.Forms.Padding(4);
            this.mskno.Mask = "0000";
            this.mskno.Name = "mskno";
            this.mskno.Size = new System.Drawing.Size(167, 25);
            this.mskno.TabIndex = 42;
            this.mskno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mskno_KeyPress);
            // 
            // btnsrc2
            // 
            this.btnsrc2.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.btnsrc2.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsrc2.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnsrc2.Location = new System.Drawing.Point(225, 31);
            this.btnsrc2.Margin = new System.Windows.Forms.Padding(4);
            this.btnsrc2.Name = "btnsrc2";
            this.btnsrc2.Size = new System.Drawing.Size(90, 35);
            this.btnsrc2.TabIndex = 41;
            this.btnsrc2.Text = "Search";
            this.btnsrc2.UseVisualStyleBackColor = false;
            this.btnsrc2.Click += new System.EventHandler(this.btnsrc2_Click);
            // 
            // allbata
            // 
            this.allbata.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.allbata.Location = new System.Drawing.Point(176, 370);
            this.allbata.Margin = new System.Windows.Forms.Padding(4);
            this.allbata.Name = "allbata";
            this.allbata.ReadOnly = true;
            this.allbata.Size = new System.Drawing.Size(213, 25);
            this.allbata.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(48, 374);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 23);
            this.label5.TabIndex = 16;
            this.label5.Text = "All BATA";
            // 
            // othrc
            // 
            this.othrc.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.othrc.Location = new System.Drawing.Point(176, 416);
            this.othrc.Margin = new System.Windows.Forms.Padding(4);
            this.othrc.Name = "othrc";
            this.othrc.ReadOnly = true;
            this.othrc.Size = new System.Drawing.Size(213, 25);
            this.othrc.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(48, 416);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 23);
            this.label4.TabIndex = 14;
            this.label4.Text = "Other costs";
            // 
            // dtp1
            // 
            this.dtp1.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp1.Location = new System.Drawing.Point(176, 129);
            this.dtp1.Margin = new System.Windows.Forms.Padding(4);
            this.dtp1.Name = "dtp1";
            this.dtp1.Size = new System.Drawing.Size(213, 25);
            this.dtp1.TabIndex = 13;
            // 
            // txtadv
            // 
            this.txtadv.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtadv.Location = new System.Drawing.Point(176, 330);
            this.txtadv.Margin = new System.Windows.Forms.Padding(4);
            this.txtadv.Name = "txtadv";
            this.txtadv.ReadOnly = true;
            this.txtadv.Size = new System.Drawing.Size(213, 25);
            this.txtadv.TabIndex = 12;
            // 
            // txtpac
            // 
            this.txtpac.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpac.Location = new System.Drawing.Point(176, 290);
            this.txtpac.Margin = new System.Windows.Forms.Padding(4);
            this.txtpac.Name = "txtpac";
            this.txtpac.ReadOnly = true;
            this.txtpac.Size = new System.Drawing.Size(213, 25);
            this.txtpac.TabIndex = 11;
            // 
            // txtcn
            // 
            this.txtcn.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcn.Location = new System.Drawing.Point(176, 250);
            this.txtcn.Margin = new System.Windows.Forms.Padding(4);
            this.txtcn.Name = "txtcn";
            this.txtcn.ReadOnly = true;
            this.txtcn.Size = new System.Drawing.Size(213, 25);
            this.txtcn.TabIndex = 10;
            // 
            // txthtl
            // 
            this.txthtl.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txthtl.Location = new System.Drawing.Point(176, 209);
            this.txthtl.Margin = new System.Windows.Forms.Padding(4);
            this.txthtl.Name = "txthtl";
            this.txthtl.ReadOnly = true;
            this.txthtl.Size = new System.Drawing.Size(213, 25);
            this.txthtl.TabIndex = 9;
            // 
            // txtev
            // 
            this.txtev.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtev.Location = new System.Drawing.Point(176, 169);
            this.txtev.Margin = new System.Windows.Forms.Padding(4);
            this.txtev.Name = "txtev";
            this.txtev.ReadOnly = true;
            this.txtev.Size = new System.Drawing.Size(213, 25);
            this.txtev.TabIndex = 8;
            // 
            // txtpn
            // 
            this.txtpn.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpn.Location = new System.Drawing.Point(176, 90);
            this.txtpn.Margin = new System.Windows.Forms.Padding(4);
            this.txtpn.Name = "txtpn";
            this.txtpn.ReadOnly = true;
            this.txtpn.Size = new System.Drawing.Size(111, 25);
            this.txtpn.TabIndex = 7;
            // 
            // lbladv
            // 
            this.lbladv.AutoSize = true;
            this.lbladv.BackColor = System.Drawing.Color.Transparent;
            this.lbladv.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbladv.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbladv.Location = new System.Drawing.Point(48, 330);
            this.lbladv.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbladv.Name = "lbladv";
            this.lbladv.Size = new System.Drawing.Size(100, 23);
            this.lbladv.TabIndex = 6;
            this.lbladv.Text = "Advance fee";
            // 
            // lblpac
            // 
            this.lblpac.AutoSize = true;
            this.lblpac.BackColor = System.Drawing.Color.Transparent;
            this.lblpac.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpac.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblpac.Location = new System.Drawing.Point(48, 291);
            this.lblpac.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblpac.Name = "lblpac";
            this.lblpac.Size = new System.Drawing.Size(67, 23);
            this.lblpac.TabIndex = 5;
            this.lblpac.Text = "Package";
            // 
            // lblcn
            // 
            this.lblcn.AutoSize = true;
            this.lblcn.BackColor = System.Drawing.Color.Transparent;
            this.lblcn.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblcn.Location = new System.Drawing.Point(48, 254);
            this.lblcn.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblcn.Name = "lblcn";
            this.lblcn.Size = new System.Drawing.Size(110, 23);
            this.lblcn.TabIndex = 4;
            this.lblcn.Text = "Couple Names";
            // 
            // lblhtl
            // 
            this.lblhtl.AutoSize = true;
            this.lblhtl.BackColor = System.Drawing.Color.Transparent;
            this.lblhtl.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblhtl.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblhtl.Location = new System.Drawing.Point(48, 212);
            this.lblhtl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblhtl.Name = "lblhtl";
            this.lblhtl.Size = new System.Drawing.Size(50, 23);
            this.lblhtl.TabIndex = 3;
            this.lblhtl.Text = "Hotel";
            // 
            // lblev
            // 
            this.lblev.AutoSize = true;
            this.lblev.BackColor = System.Drawing.Color.Transparent;
            this.lblev.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblev.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblev.Location = new System.Drawing.Point(48, 172);
            this.lblev.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblev.Name = "lblev";
            this.lblev.Size = new System.Drawing.Size(51, 23);
            this.lblev.TabIndex = 2;
            this.lblev.Text = "Event";
            // 
            // lbldt
            // 
            this.lbldt.AutoSize = true;
            this.lbldt.BackColor = System.Drawing.Color.Transparent;
            this.lbldt.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldt.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbldt.Location = new System.Drawing.Point(48, 133);
            this.lbldt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbldt.Name = "lbldt";
            this.lbldt.Size = new System.Drawing.Size(45, 23);
            this.lbldt.TabIndex = 1;
            this.lbldt.Text = "Date";
            // 
            // lblpn
            // 
            this.lblpn.AutoSize = true;
            this.lblpn.BackColor = System.Drawing.Color.Transparent;
            this.lblpn.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblpn.Location = new System.Drawing.Point(48, 99);
            this.lblpn.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblpn.Name = "lblpn";
            this.lblpn.Size = new System.Drawing.Size(94, 23);
            this.lblpn.TabIndex = 0;
            this.lblpn.Text = "Project No:";
            // 
            // btnedit
            // 
            this.btnedit.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.btnedit.Enabled = false;
            this.btnedit.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnedit.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnedit.Location = new System.Drawing.Point(115, 500);
            this.btnedit.Margin = new System.Windows.Forms.Padding(4);
            this.btnedit.Name = "btnedit";
            this.btnedit.Size = new System.Drawing.Size(126, 56);
            this.btnedit.TabIndex = 44;
            this.btnedit.Text = "Edit";
            this.btnedit.UseVisualStyleBackColor = false;
            this.btnedit.Click += new System.EventHandler(this.btnedit_Click);
            // 
            // btnsv
            // 
            this.btnsv.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.btnsv.Enabled = false;
            this.btnsv.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsv.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnsv.Location = new System.Drawing.Point(249, 500);
            this.btnsv.Margin = new System.Windows.Forms.Padding(4);
            this.btnsv.Name = "btnsv";
            this.btnsv.Size = new System.Drawing.Size(126, 56);
            this.btnsv.TabIndex = 43;
            this.btnsv.Text = "Save";
            this.btnsv.UseVisualStyleBackColor = false;
            this.btnsv.Click += new System.EventHandler(this.btnsv_Click);
            // 
            // btnstng
            // 
            this.btnstng.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnstng.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnstng.BackgroundImage")));
            this.btnstng.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnstng.Location = new System.Drawing.Point(963, 15);
            this.btnstng.Margin = new System.Windows.Forms.Padding(4);
            this.btnstng.Name = "btnstng";
            this.btnstng.Size = new System.Drawing.Size(47, 48);
            this.btnstng.TabIndex = 47;
            this.btnstng.UseVisualStyleBackColor = false;
            this.btnstng.Click += new System.EventHandler(this.btnstng_Click);
            // 
            // btnhome
            // 
            this.btnhome.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnhome.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnhome.BackgroundImage")));
            this.btnhome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnhome.Location = new System.Drawing.Point(907, 15);
            this.btnhome.Margin = new System.Windows.Forms.Padding(4);
            this.btnhome.Name = "btnhome";
            this.btnhome.Size = new System.Drawing.Size(47, 48);
            this.btnhome.TabIndex = 46;
            this.btnhome.UseVisualStyleBackColor = false;
            this.btnhome.Click += new System.EventHandler(this.btnhome_Click);
            // 
            // btnback
            // 
            this.btnback.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnback.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnback.BackgroundImage")));
            this.btnback.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnback.Location = new System.Drawing.Point(851, 15);
            this.btnback.Margin = new System.Windows.Forms.Padding(4);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(47, 48);
            this.btnback.TabIndex = 45;
            this.btnback.UseVisualStyleBackColor = false;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // txtcntct
            // 
            this.txtcntct.Enabled = false;
            this.txtcntct.Location = new System.Drawing.Point(176, 448);
            this.txtcntct.Mask = "(999) 000-0000";
            this.txtcntct.Name = "txtcntct";
            this.txtcntct.ReadOnly = true;
            this.txtcntct.Size = new System.Drawing.Size(213, 26);
            this.txtcntct.TabIndex = 51;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(50, 451);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 23);
            this.label1.TabIndex = 50;
            this.label1.Text = "Contact";
            // 
            // proedit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1023, 741);
            this.ControlBox = false;
            this.Controls.Add(this.txtcntct);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnstng);
            this.Controls.Add(this.btnhome);
            this.Controls.Add(this.btnback);
            this.Controls.Add(this.allbata);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.othrc);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnedit);
            this.Controls.Add(this.dtp1);
            this.Controls.Add(this.btnsv);
            this.Controls.Add(this.txtadv);
            this.Controls.Add(this.mskno);
            this.Controls.Add(this.txtpac);
            this.Controls.Add(this.btnsrc2);
            this.Controls.Add(this.txtcn);
            this.Controls.Add(this.txthtl);
            this.Controls.Add(this.txtev);
            this.Controls.Add(this.lblpn);
            this.Controls.Add(this.txtpn);
            this.Controls.Add(this.lbldt);
            this.Controls.Add(this.lbladv);
            this.Controls.Add(this.lblev);
            this.Controls.Add(this.lblpac);
            this.Controls.Add(this.lblhtl);
            this.Controls.Add(this.lblcn);
            this.Font = new System.Drawing.Font("Comic Sans MS", 9.75F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "proedit";
            this.Text = "Edit Projrct";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox mskno;
        private System.Windows.Forms.Button btnsrc2;
        private System.Windows.Forms.TextBox allbata;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox othrc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtp1;
        private System.Windows.Forms.TextBox txtadv;
        private System.Windows.Forms.TextBox txtpac;
        private System.Windows.Forms.TextBox txtcn;
        private System.Windows.Forms.TextBox txthtl;
        private System.Windows.Forms.TextBox txtev;
        private System.Windows.Forms.TextBox txtpn;
        private System.Windows.Forms.Label lbladv;
        private System.Windows.Forms.Label lblpac;
        private System.Windows.Forms.Label lblcn;
        private System.Windows.Forms.Label lblhtl;
        private System.Windows.Forms.Label lblev;
        private System.Windows.Forms.Label lbldt;
        private System.Windows.Forms.Label lblpn;
        private System.Windows.Forms.Button btnedit;
        private System.Windows.Forms.Button btnsv;
        private System.Windows.Forms.Button btnstng;
        private System.Windows.Forms.Button btnhome;
        private System.Windows.Forms.Button btnback;
        private System.Windows.Forms.MaskedTextBox txtcntct;
        private System.Windows.Forms.Label label1;
    }
}