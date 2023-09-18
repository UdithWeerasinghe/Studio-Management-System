namespace NEW
{
    partial class memedit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(memedit));
            this.dtp = new System.Windows.Forms.DateTimePicker();
            this.cmb = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.mskno = new System.Windows.Forms.MaskedTextBox();
            this.btnsrc2 = new System.Windows.Forms.Button();
            this.txte = new System.Windows.Forms.TextBox();
            this.txtnic = new System.Windows.Forms.TextBox();
            this.txtadr = new System.Windows.Forms.TextBox();
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
            this.btnedit = new System.Windows.Forms.Button();
            this.btnsv = new System.Windows.Forms.Button();
            this.txtage = new System.Windows.Forms.MaskedTextBox();
            this.txtsal = new System.Windows.Forms.MaskedTextBox();
            this.txttp1 = new System.Windows.Forms.MaskedTextBox();
            this.txttp2 = new System.Windows.Forms.MaskedTextBox();
            this.btnstng = new System.Windows.Forms.Button();
            this.btnhome = new System.Windows.Forms.Button();
            this.btnback = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dtp
            // 
            this.dtp.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp.Location = new System.Drawing.Point(154, 174);
            this.dtp.Name = "dtp";
            this.dtp.Size = new System.Drawing.Size(210, 25);
            this.dtp.TabIndex = 107;
            // 
            // cmb
            // 
            this.cmb.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb.FormattingEnabled = true;
            this.cmb.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cmb.Location = new System.Drawing.Point(154, 144);
            this.cmb.Name = "cmb";
            this.cmb.Size = new System.Drawing.Size(131, 26);
            this.cmb.TabIndex = 106;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(73, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 23);
            this.label1.TabIndex = 105;
            this.label1.Text = "Gender";
            // 
            // mskno
            // 
            this.mskno.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskno.Location = new System.Drawing.Point(76, 50);
            this.mskno.Mask = "####";
            this.mskno.Name = "mskno";
            this.mskno.Size = new System.Drawing.Size(113, 25);
            this.mskno.TabIndex = 104;
            this.mskno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mskno_KeyPress);
            // 
            // btnsrc2
            // 
            this.btnsrc2.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.btnsrc2.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsrc2.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnsrc2.Location = new System.Drawing.Point(198, 45);
            this.btnsrc2.Name = "btnsrc2";
            this.btnsrc2.Size = new System.Drawing.Size(90, 35);
            this.btnsrc2.TabIndex = 103;
            this.btnsrc2.Text = "Search";
            this.btnsrc2.UseVisualStyleBackColor = false;
            this.btnsrc2.Click += new System.EventHandler(this.btnsrc2_Click);
            // 
            // txte
            // 
            this.txte.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txte.Location = new System.Drawing.Point(154, 360);
            this.txte.Name = "txte";
            this.txte.ReadOnly = true;
            this.txte.Size = new System.Drawing.Size(221, 25);
            this.txte.TabIndex = 101;
            // 
            // txtnic
            // 
            this.txtnic.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnic.Location = new System.Drawing.Point(154, 265);
            this.txtnic.Name = "txtnic";
            this.txtnic.ReadOnly = true;
            this.txtnic.Size = new System.Drawing.Size(221, 25);
            this.txtnic.TabIndex = 98;
            // 
            // txtadr
            // 
            this.txtadr.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtadr.Location = new System.Drawing.Point(154, 236);
            this.txtadr.Multiline = true;
            this.txtadr.Name = "txtadr";
            this.txtadr.ReadOnly = true;
            this.txtadr.Size = new System.Drawing.Size(221, 20);
            this.txtadr.TabIndex = 97;
            // 
            // txtmn
            // 
            this.txtmn.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmn.Location = new System.Drawing.Point(154, 90);
            this.txtmn.Name = "txtmn";
            this.txtmn.ReadOnly = true;
            this.txtmn.Size = new System.Drawing.Size(68, 25);
            this.txtmn.TabIndex = 95;
            // 
            // txtnm
            // 
            this.txtnm.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnm.Location = new System.Drawing.Point(154, 118);
            this.txtnm.Multiline = true;
            this.txtnm.Name = "txtnm";
            this.txtnm.ReadOnly = true;
            this.txtnm.Size = new System.Drawing.Size(225, 22);
            this.txtnm.TabIndex = 94;
            // 
            // lblsal
            // 
            this.lblsal.AutoSize = true;
            this.lblsal.BackColor = System.Drawing.Color.Transparent;
            this.lblsal.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsal.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblsal.Location = new System.Drawing.Point(73, 390);
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
            this.lble.Location = new System.Drawing.Point(73, 360);
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
            this.lbltp2.Location = new System.Drawing.Point(73, 331);
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
            this.lbltp1.Location = new System.Drawing.Point(73, 298);
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
            this.lblnic.Location = new System.Drawing.Point(73, 264);
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
            this.lbladr.Location = new System.Drawing.Point(73, 234);
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
            this.lblage.Location = new System.Drawing.Point(73, 204);
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
            this.lbldob.Location = new System.Drawing.Point(73, 171);
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
            this.lblmn.Location = new System.Drawing.Point(73, 89);
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
            this.lblnm.Location = new System.Drawing.Point(73, 114);
            this.lblnm.Name = "lblnm";
            this.lblnm.Size = new System.Drawing.Size(50, 23);
            this.lblnm.TabIndex = 84;
            this.lblnm.Text = "Name";
            // 
            // btnedit
            // 
            this.btnedit.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.btnedit.Enabled = false;
            this.btnedit.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnedit.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnedit.Location = new System.Drawing.Point(148, 445);
            this.btnedit.Name = "btnedit";
            this.btnedit.Size = new System.Drawing.Size(126, 56);
            this.btnedit.TabIndex = 109;
            this.btnedit.Text = "Edit";
            this.btnedit.UseVisualStyleBackColor = false;
            this.btnedit.Click += new System.EventHandler(this.btnedit_Click);
            // 
            // btnsv
            // 
            this.btnsv.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.btnsv.Enabled = false;
            this.btnsv.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsv.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnsv.Location = new System.Drawing.Point(280, 445);
            this.btnsv.Name = "btnsv";
            this.btnsv.Size = new System.Drawing.Size(126, 56);
            this.btnsv.TabIndex = 108;
            this.btnsv.Text = "Save";
            this.btnsv.UseVisualStyleBackColor = false;
            this.btnsv.Click += new System.EventHandler(this.btnsv_Click);
            // 
            // txtage
            // 
            this.txtage.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtage.Location = new System.Drawing.Point(154, 205);
            this.txtage.Mask = "0000000000";
            this.txtage.Name = "txtage";
            this.txtage.ReadOnly = true;
            this.txtage.Size = new System.Drawing.Size(221, 25);
            this.txtage.TabIndex = 110;
            // 
            // txtsal
            // 
            this.txtsal.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsal.Location = new System.Drawing.Point(154, 391);
            this.txtsal.Mask = "0000000000";
            this.txtsal.Name = "txtsal";
            this.txtsal.ReadOnly = true;
            this.txtsal.Size = new System.Drawing.Size(221, 25);
            this.txtsal.TabIndex = 113;
            // 
            // txttp1
            // 
            this.txttp1.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttp1.Location = new System.Drawing.Point(154, 298);
            this.txttp1.Mask = "0000000000";
            this.txttp1.Name = "txttp1";
            this.txttp1.ReadOnly = true;
            this.txttp1.Size = new System.Drawing.Size(221, 25);
            this.txttp1.TabIndex = 114;
            // 
            // txttp2
            // 
            this.txttp2.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttp2.Location = new System.Drawing.Point(154, 329);
            this.txttp2.Mask = "0000000000";
            this.txttp2.Name = "txttp2";
            this.txttp2.ReadOnly = true;
            this.txttp2.Size = new System.Drawing.Size(221, 25);
            this.txttp2.TabIndex = 115;
            // 
            // btnstng
            // 
            this.btnstng.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnstng.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnstng.BackgroundImage")));
            this.btnstng.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnstng.Location = new System.Drawing.Point(964, 12);
            this.btnstng.Name = "btnstng";
            this.btnstng.Size = new System.Drawing.Size(47, 48);
            this.btnstng.TabIndex = 118;
            this.btnstng.UseVisualStyleBackColor = false;
            this.btnstng.Click += new System.EventHandler(this.btnstng_Click);
            // 
            // btnhome
            // 
            this.btnhome.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnhome.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnhome.BackgroundImage")));
            this.btnhome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnhome.Location = new System.Drawing.Point(911, 12);
            this.btnhome.Name = "btnhome";
            this.btnhome.Size = new System.Drawing.Size(47, 48);
            this.btnhome.TabIndex = 117;
            this.btnhome.UseVisualStyleBackColor = false;
            this.btnhome.Click += new System.EventHandler(this.btnhome_Click);
            // 
            // btnback
            // 
            this.btnback.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnback.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnback.BackgroundImage")));
            this.btnback.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnback.Location = new System.Drawing.Point(858, 12);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(47, 48);
            this.btnback.TabIndex = 116;
            this.btnback.UseVisualStyleBackColor = false;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // memedit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1023, 741);
            this.ControlBox = false;
            this.Controls.Add(this.btnstng);
            this.Controls.Add(this.btnhome);
            this.Controls.Add(this.btnback);
            this.Controls.Add(this.txttp2);
            this.Controls.Add(this.txttp1);
            this.Controls.Add(this.txtsal);
            this.Controls.Add(this.txtage);
            this.Controls.Add(this.btnedit);
            this.Controls.Add(this.btnsv);
            this.Controls.Add(this.dtp);
            this.Controls.Add(this.cmb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mskno);
            this.Controls.Add(this.btnsrc2);
            this.Controls.Add(this.txte);
            this.Controls.Add(this.txtnic);
            this.Controls.Add(this.txtadr);
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
            this.Name = "memedit";
            this.Text = "Edit Member";
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
        private System.Windows.Forms.TextBox txte;
        private System.Windows.Forms.TextBox txtnic;
        private System.Windows.Forms.TextBox txtadr;
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
        private System.Windows.Forms.Button btnedit;
        private System.Windows.Forms.Button btnsv;
        private System.Windows.Forms.MaskedTextBox txtage;
        private System.Windows.Forms.MaskedTextBox txtsal;
        private System.Windows.Forms.MaskedTextBox txttp1;
        private System.Windows.Forms.MaskedTextBox txttp2;
        private System.Windows.Forms.Button btnstng;
        private System.Windows.Forms.Button btnhome;
        private System.Windows.Forms.Button btnback;
    }
}