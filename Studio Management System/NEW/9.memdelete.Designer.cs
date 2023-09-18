namespace NEW
{
    partial class memdel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(memdel));
            this.dtp = new System.Windows.Forms.DateTimePicker();
            this.cmb = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.mskno = new System.Windows.Forms.MaskedTextBox();
            this.btnsrc2 = new System.Windows.Forms.Button();
            this.txtsal = new System.Windows.Forms.TextBox();
            this.txte = new System.Windows.Forms.TextBox();
            this.txttp2 = new System.Windows.Forms.TextBox();
            this.txttp1 = new System.Windows.Forms.TextBox();
            this.txtnic = new System.Windows.Forms.TextBox();
            this.txtadr = new System.Windows.Forms.TextBox();
            this.txtage = new System.Windows.Forms.TextBox();
            this.txtmn = new System.Windows.Forms.TextBox();
            this.txtnm = new System.Windows.Forms.TextBox();
            this.lblsal = new System.Windows.Forms.Label();
            this.lble = new System.Windows.Forms.Label();
            this.lbltp2 = new System.Windows.Forms.Label();
            this.lbltp1 = new System.Windows.Forms.Label();
            this.lblnic = new System.Windows.Forms.Label();
            this.lbladr = new System.Windows.Forms.Label();
            this.lblage = new System.Windows.Forms.Label();
            this.lbldob = new System.Windows.Forms.Label();
            this.lblmn = new System.Windows.Forms.Label();
            this.lblnm = new System.Windows.Forms.Label();
            this.btndel = new System.Windows.Forms.Button();
            this.btncan = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dtp
            // 
            this.dtp.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp.Location = new System.Drawing.Point(143, 166);
            this.dtp.Name = "dtp";
            this.dtp.Size = new System.Drawing.Size(200, 25);
            this.dtp.TabIndex = 107;
            // 
            // cmb
            // 
            this.cmb.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb.FormattingEnabled = true;
            this.cmb.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cmb.Location = new System.Drawing.Point(143, 136);
            this.cmb.Name = "cmb";
            this.cmb.Size = new System.Drawing.Size(121, 26);
            this.cmb.TabIndex = 106;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(66, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 23);
            this.label1.TabIndex = 105;
            this.label1.Text = "Gender";
            // 
            // mskno
            // 
            this.mskno.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskno.Location = new System.Drawing.Point(72, 48);
            this.mskno.Mask = "####";
            this.mskno.Name = "mskno";
            this.mskno.Size = new System.Drawing.Size(100, 25);
            this.mskno.TabIndex = 104;
            this.mskno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mskno_KeyPress);
            // 
            // btnsrc2
            // 
            this.btnsrc2.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.btnsrc2.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsrc2.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnsrc2.Location = new System.Drawing.Point(180, 40);
            this.btnsrc2.Name = "btnsrc2";
            this.btnsrc2.Size = new System.Drawing.Size(90, 35);
            this.btnsrc2.TabIndex = 103;
            this.btnsrc2.Text = "Search";
            this.btnsrc2.UseVisualStyleBackColor = false;
            this.btnsrc2.Click += new System.EventHandler(this.btnsrc2_Click);
            // 
            // txtsal
            // 
            this.txtsal.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsal.Location = new System.Drawing.Point(143, 382);
            this.txtsal.Name = "txtsal";
            this.txtsal.ReadOnly = true;
            this.txtsal.Size = new System.Drawing.Size(211, 25);
            this.txtsal.TabIndex = 102;
            // 
            // txte
            // 
            this.txte.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txte.Location = new System.Drawing.Point(143, 352);
            this.txte.Name = "txte";
            this.txte.ReadOnly = true;
            this.txte.Size = new System.Drawing.Size(211, 25);
            this.txte.TabIndex = 101;
            // 
            // txttp2
            // 
            this.txttp2.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttp2.Location = new System.Drawing.Point(143, 322);
            this.txttp2.Name = "txttp2";
            this.txttp2.ReadOnly = true;
            this.txttp2.Size = new System.Drawing.Size(211, 25);
            this.txttp2.TabIndex = 100;
            // 
            // txttp1
            // 
            this.txttp1.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttp1.Location = new System.Drawing.Point(143, 290);
            this.txttp1.Name = "txttp1";
            this.txttp1.ReadOnly = true;
            this.txttp1.Size = new System.Drawing.Size(211, 25);
            this.txttp1.TabIndex = 99;
            // 
            // txtnic
            // 
            this.txtnic.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnic.Location = new System.Drawing.Point(143, 259);
            this.txtnic.Name = "txtnic";
            this.txtnic.ReadOnly = true;
            this.txtnic.Size = new System.Drawing.Size(211, 25);
            this.txtnic.TabIndex = 98;
            // 
            // txtadr
            // 
            this.txtadr.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtadr.Location = new System.Drawing.Point(143, 228);
            this.txtadr.Multiline = true;
            this.txtadr.Name = "txtadr";
            this.txtadr.ReadOnly = true;
            this.txtadr.Size = new System.Drawing.Size(211, 25);
            this.txtadr.TabIndex = 97;
            // 
            // txtage
            // 
            this.txtage.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtage.Location = new System.Drawing.Point(143, 196);
            this.txtage.Name = "txtage";
            this.txtage.ReadOnly = true;
            this.txtage.Size = new System.Drawing.Size(211, 25);
            this.txtage.TabIndex = 96;
            // 
            // txtmn
            // 
            this.txtmn.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmn.Location = new System.Drawing.Point(143, 79);
            this.txtmn.Name = "txtmn";
            this.txtmn.ReadOnly = true;
            this.txtmn.Size = new System.Drawing.Size(58, 25);
            this.txtmn.TabIndex = 95;
            // 
            // txtnm
            // 
            this.txtnm.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnm.Location = new System.Drawing.Point(143, 107);
            this.txtnm.Multiline = true;
            this.txtnm.Name = "txtnm";
            this.txtnm.ReadOnly = true;
            this.txtnm.Size = new System.Drawing.Size(215, 26);
            this.txtnm.TabIndex = 94;
            // 
            // lblsal
            // 
            this.lblsal.AutoSize = true;
            this.lblsal.BackColor = System.Drawing.Color.Transparent;
            this.lblsal.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsal.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblsal.Location = new System.Drawing.Point(66, 385);
            this.lblsal.Name = "lblsal";
            this.lblsal.Size = new System.Drawing.Size(59, 23);
            this.lblsal.TabIndex = 93;
            this.lblsal.Text = "Salary";
            // 
            // lble
            // 
            this.lble.AutoSize = true;
            this.lble.BackColor = System.Drawing.Color.Transparent;
            this.lble.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lble.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lble.Location = new System.Drawing.Point(66, 355);
            this.lble.Name = "lble";
            this.lble.Size = new System.Drawing.Size(60, 23);
            this.lble.TabIndex = 92;
            this.lble.Text = "E-Mail";
            // 
            // lbltp2
            // 
            this.lbltp2.AutoSize = true;
            this.lbltp2.BackColor = System.Drawing.Color.Transparent;
            this.lbltp2.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltp2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbltp2.Location = new System.Drawing.Point(66, 326);
            this.lbltp2.Name = "lbltp2";
            this.lbltp2.Size = new System.Drawing.Size(48, 23);
            this.lbltp2.TabIndex = 91;
            this.lbltp2.Text = "T.P 2";
            // 
            // lbltp1
            // 
            this.lbltp1.AutoSize = true;
            this.lbltp1.BackColor = System.Drawing.Color.Transparent;
            this.lbltp1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltp1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbltp1.Location = new System.Drawing.Point(66, 293);
            this.lbltp1.Name = "lbltp1";
            this.lbltp1.Size = new System.Drawing.Size(45, 23);
            this.lbltp1.TabIndex = 90;
            this.lbltp1.Text = "T.P 1";
            // 
            // lblnic
            // 
            this.lblnic.AutoSize = true;
            this.lblnic.BackColor = System.Drawing.Color.Transparent;
            this.lblnic.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnic.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblnic.Location = new System.Drawing.Point(66, 259);
            this.lblnic.Name = "lblnic";
            this.lblnic.Size = new System.Drawing.Size(76, 23);
            this.lblnic.TabIndex = 89;
            this.lblnic.Text = "N.I.C No";
            // 
            // lbladr
            // 
            this.lbladr.AutoSize = true;
            this.lbladr.BackColor = System.Drawing.Color.Transparent;
            this.lbladr.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbladr.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbladr.Location = new System.Drawing.Point(66, 229);
            this.lbladr.Name = "lbladr";
            this.lbladr.Size = new System.Drawing.Size(70, 23);
            this.lbladr.TabIndex = 88;
            this.lbladr.Text = "Address";
            // 
            // lblage
            // 
            this.lblage.AutoSize = true;
            this.lblage.BackColor = System.Drawing.Color.Transparent;
            this.lblage.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblage.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblage.Location = new System.Drawing.Point(66, 199);
            this.lblage.Name = "lblage";
            this.lblage.Size = new System.Drawing.Size(38, 23);
            this.lblage.TabIndex = 87;
            this.lblage.Text = "Age";
            // 
            // lbldob
            // 
            this.lbldob.AutoSize = true;
            this.lbldob.BackColor = System.Drawing.Color.Transparent;
            this.lbldob.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldob.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbldob.Location = new System.Drawing.Point(66, 166);
            this.lbldob.Name = "lbldob";
            this.lbldob.Size = new System.Drawing.Size(40, 23);
            this.lbldob.TabIndex = 86;
            this.lbldob.Text = "DoB";
            // 
            // lblmn
            // 
            this.lblmn.AutoSize = true;
            this.lblmn.BackColor = System.Drawing.Color.Transparent;
            this.lblmn.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblmn.Location = new System.Drawing.Point(66, 84);
            this.lblmn.Name = "lblmn";
            this.lblmn.Size = new System.Drawing.Size(68, 23);
            this.lblmn.TabIndex = 85;
            this.lblmn.Text = "Number";
            // 
            // lblnm
            // 
            this.lblnm.AutoSize = true;
            this.lblnm.BackColor = System.Drawing.Color.Transparent;
            this.lblnm.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnm.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblnm.Location = new System.Drawing.Point(66, 109);
            this.lblnm.Name = "lblnm";
            this.lblnm.Size = new System.Drawing.Size(50, 23);
            this.lblnm.TabIndex = 84;
            this.lblnm.Text = "Name";
            // 
            // btndel
            // 
            this.btndel.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.btndel.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndel.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btndel.Location = new System.Drawing.Point(138, 427);
            this.btndel.Name = "btndel";
            this.btndel.Size = new System.Drawing.Size(126, 56);
            this.btndel.TabIndex = 108;
            this.btndel.Text = "Delete";
            this.btndel.UseVisualStyleBackColor = false;
            this.btndel.Click += new System.EventHandler(this.btndel_Click);
            // 
            // btncan
            // 
            this.btncan.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.btncan.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncan.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btncan.Location = new System.Drawing.Point(272, 427);
            this.btncan.Name = "btncan";
            this.btncan.Size = new System.Drawing.Size(126, 56);
            this.btncan.TabIndex = 109;
            this.btncan.Text = "Clear";
            this.btncan.UseVisualStyleBackColor = false;
            this.btncan.Click += new System.EventHandler(this.btncan_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.Location = new System.Drawing.Point(964, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(47, 48);
            this.button3.TabIndex = 112;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Location = new System.Drawing.Point(911, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(47, 48);
            this.button2.TabIndex = 111;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(858, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(47, 48);
            this.button1.TabIndex = 110;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // memdel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1023, 750);
            this.ControlBox = false;
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btncan);
            this.Controls.Add(this.btndel);
            this.Controls.Add(this.dtp);
            this.Controls.Add(this.cmb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mskno);
            this.Controls.Add(this.btnsrc2);
            this.Controls.Add(this.txtsal);
            this.Controls.Add(this.txte);
            this.Controls.Add(this.txttp2);
            this.Controls.Add(this.txttp1);
            this.Controls.Add(this.txtnic);
            this.Controls.Add(this.txtadr);
            this.Controls.Add(this.txtage);
            this.Controls.Add(this.txtmn);
            this.Controls.Add(this.txtnm);
            this.Controls.Add(this.lblsal);
            this.Controls.Add(this.lble);
            this.Controls.Add(this.lbltp2);
            this.Controls.Add(this.lbltp1);
            this.Controls.Add(this.lblnic);
            this.Controls.Add(this.lbladr);
            this.Controls.Add(this.lblage);
            this.Controls.Add(this.lbldob);
            this.Controls.Add(this.lblmn);
            this.Controls.Add(this.lblnm);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "memdel";
            this.Text = "Delete Members";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtp;
        private System.Windows.Forms.ComboBox cmb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox mskno;
        private System.Windows.Forms.Button btnsrc2;
        private System.Windows.Forms.TextBox txtsal;
        private System.Windows.Forms.TextBox txte;
        private System.Windows.Forms.TextBox txttp2;
        private System.Windows.Forms.TextBox txttp1;
        private System.Windows.Forms.TextBox txtnic;
        private System.Windows.Forms.TextBox txtadr;
        private System.Windows.Forms.TextBox txtage;
        private System.Windows.Forms.TextBox txtmn;
        private System.Windows.Forms.TextBox txtnm;
        private System.Windows.Forms.Label lblsal;
        private System.Windows.Forms.Label lble;
        private System.Windows.Forms.Label lbltp2;
        private System.Windows.Forms.Label lbltp1;
        private System.Windows.Forms.Label lblnic;
        private System.Windows.Forms.Label lbladr;
        private System.Windows.Forms.Label lblage;
        private System.Windows.Forms.Label lbldob;
        private System.Windows.Forms.Label lblmn;
        private System.Windows.Forms.Label lblnm;
        private System.Windows.Forms.Button btndel;
        private System.Windows.Forms.Button btncan;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}