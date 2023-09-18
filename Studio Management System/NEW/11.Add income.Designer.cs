namespace NEW
{
    partial class income
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(income));
            this.btnsrc = new System.Windows.Forms.Button();
            this.btncnt = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtev = new System.Windows.Forms.TextBox();
            this.mskno = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtpac = new System.Windows.Forms.TextBox();
            this.Ocost = new System.Windows.Forms.Label();
            this.othrc = new System.Windows.Forms.TextBox();
            this.bata = new System.Windows.Forms.Label();
            this.allbata = new System.Windows.Forms.TextBox();
            this.btncntp = new System.Windows.Forms.Button();
            this.txtpr = new System.Windows.Forms.TextBox();
            this.btnclr = new System.Windows.Forms.Button();
            this.cost = new System.Windows.Forms.Label();
            this.profit = new System.Windows.Forms.Label();
            this.c1 = new System.Windows.Forms.TextBox();
            this.btnstng = new System.Windows.Forms.Button();
            this.btnhome = new System.Windows.Forms.Button();
            this.btnback = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnsrc
            // 
            this.btnsrc.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.btnsrc.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsrc.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnsrc.Location = new System.Drawing.Point(340, 107);
            this.btnsrc.Name = "btnsrc";
            this.btnsrc.Size = new System.Drawing.Size(90, 35);
            this.btnsrc.TabIndex = 0;
            this.btnsrc.Text = "search";
            this.btnsrc.UseVisualStyleBackColor = false;
            this.btnsrc.Click += new System.EventHandler(this.btnsrc_Click);
            // 
            // btncnt
            // 
            this.btncnt.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.btncnt.Enabled = false;
            this.btncnt.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncnt.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btncnt.Location = new System.Drawing.Point(66, 308);
            this.btncnt.Name = "btncnt";
            this.btncnt.Size = new System.Drawing.Size(98, 32);
            this.btncnt.TabIndex = 1;
            this.btncnt.Text = "Count cost";
            this.btncnt.UseVisualStyleBackColor = false;
            this.btncnt.Click += new System.EventHandler(this.btncnt_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(109, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Project no";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(156, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Event";
            // 
            // txtev
            // 
            this.txtev.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtev.Location = new System.Drawing.Point(253, 152);
            this.txtev.Name = "txtev";
            this.txtev.ReadOnly = true;
            this.txtev.Size = new System.Drawing.Size(134, 25);
            this.txtev.TabIndex = 5;
            // 
            // mskno
            // 
            this.mskno.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskno.Location = new System.Drawing.Point(191, 112);
            this.mskno.Mask = "####";
            this.mskno.Name = "mskno";
            this.mskno.Size = new System.Drawing.Size(134, 25);
            this.mskno.TabIndex = 6;
            this.mskno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mskno_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(156, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 23);
            this.label3.TabIndex = 7;
            this.label3.Text = "Package";
            // 
            // txtpac
            // 
            this.txtpac.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpac.Location = new System.Drawing.Point(253, 184);
            this.txtpac.Name = "txtpac";
            this.txtpac.ReadOnly = true;
            this.txtpac.Size = new System.Drawing.Size(134, 25);
            this.txtpac.TabIndex = 8;
            // 
            // Ocost
            // 
            this.Ocost.AutoSize = true;
            this.Ocost.BackColor = System.Drawing.Color.Transparent;
            this.Ocost.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ocost.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Ocost.Location = new System.Drawing.Point(156, 251);
            this.Ocost.Name = "Ocost";
            this.Ocost.Size = new System.Drawing.Size(96, 23);
            this.Ocost.TabIndex = 9;
            this.Ocost.Text = "Other costs";
            // 
            // othrc
            // 
            this.othrc.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.othrc.Location = new System.Drawing.Point(253, 251);
            this.othrc.Name = "othrc";
            this.othrc.ReadOnly = true;
            this.othrc.Size = new System.Drawing.Size(134, 25);
            this.othrc.TabIndex = 10;
            // 
            // bata
            // 
            this.bata.AutoSize = true;
            this.bata.BackColor = System.Drawing.Color.Transparent;
            this.bata.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bata.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bata.Location = new System.Drawing.Point(156, 221);
            this.bata.Name = "bata";
            this.bata.Size = new System.Drawing.Size(82, 23);
            this.bata.TabIndex = 11;
            this.bata.Text = "All BATA";
            // 
            // allbata
            // 
            this.allbata.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.allbata.Location = new System.Drawing.Point(253, 217);
            this.allbata.Name = "allbata";
            this.allbata.ReadOnly = true;
            this.allbata.Size = new System.Drawing.Size(134, 25);
            this.allbata.TabIndex = 12;
            // 
            // btncntp
            // 
            this.btncntp.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.btncntp.Enabled = false;
            this.btncntp.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncntp.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btncntp.Location = new System.Drawing.Point(66, 347);
            this.btncntp.Name = "btncntp";
            this.btncntp.Size = new System.Drawing.Size(98, 32);
            this.btncntp.TabIndex = 13;
            this.btncntp.Text = "Count Profit";
            this.btncntp.UseVisualStyleBackColor = false;
            this.btncntp.Click += new System.EventHandler(this.btncntp_Click);
            // 
            // txtpr
            // 
            this.txtpr.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpr.Location = new System.Drawing.Point(245, 349);
            this.txtpr.Name = "txtpr";
            this.txtpr.Size = new System.Drawing.Size(140, 25);
            this.txtpr.TabIndex = 15;
            // 
            // btnclr
            // 
            this.btnclr.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.btnclr.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclr.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnclr.Location = new System.Drawing.Point(291, 391);
            this.btnclr.Name = "btnclr";
            this.btnclr.Size = new System.Drawing.Size(126, 56);
            this.btnclr.TabIndex = 16;
            this.btnclr.Text = "Clear all";
            this.btnclr.UseVisualStyleBackColor = false;
            this.btnclr.Click += new System.EventHandler(this.btnclr_Click);
            // 
            // cost
            // 
            this.cost.AutoSize = true;
            this.cost.BackColor = System.Drawing.Color.Transparent;
            this.cost.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cost.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cost.Location = new System.Drawing.Point(173, 314);
            this.cost.Name = "cost";
            this.cost.Size = new System.Drawing.Size(42, 23);
            this.cost.TabIndex = 17;
            this.cost.Text = "Cost";
            // 
            // profit
            // 
            this.profit.AutoSize = true;
            this.profit.BackColor = System.Drawing.Color.Transparent;
            this.profit.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.profit.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.profit.Location = new System.Drawing.Point(173, 352);
            this.profit.Name = "profit";
            this.profit.Size = new System.Drawing.Size(55, 23);
            this.profit.TabIndex = 18;
            this.profit.Text = "profit";
            // 
            // c1
            // 
            this.c1.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c1.Location = new System.Drawing.Point(245, 314);
            this.c1.Name = "c1";
            this.c1.Size = new System.Drawing.Size(140, 25);
            this.c1.TabIndex = 19;
            // 
            // btnstng
            // 
            this.btnstng.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnstng.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnstng.BackgroundImage")));
            this.btnstng.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnstng.Location = new System.Drawing.Point(964, 12);
            this.btnstng.Name = "btnstng";
            this.btnstng.Size = new System.Drawing.Size(47, 48);
            this.btnstng.TabIndex = 22;
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
            this.btnhome.TabIndex = 21;
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
            this.btnback.TabIndex = 20;
            this.btnback.UseVisualStyleBackColor = false;
            this.btnback.Click += new System.EventHandler(this.btnback_Click_1);
            // 
            // income
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
            this.Controls.Add(this.c1);
            this.Controls.Add(this.profit);
            this.Controls.Add(this.cost);
            this.Controls.Add(this.btnclr);
            this.Controls.Add(this.txtpr);
            this.Controls.Add(this.btncntp);
            this.Controls.Add(this.allbata);
            this.Controls.Add(this.bata);
            this.Controls.Add(this.othrc);
            this.Controls.Add(this.Ocost);
            this.Controls.Add(this.txtpac);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.mskno);
            this.Controls.Add(this.txtev);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btncnt);
            this.Controls.Add(this.btnsrc);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "income";
            this.Text = "Count Profit";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.income_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnsrc;
        private System.Windows.Forms.Button btncnt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtev;
        private System.Windows.Forms.MaskedTextBox mskno;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtpac;
        private System.Windows.Forms.Label Ocost;
        private System.Windows.Forms.TextBox othrc;
        private System.Windows.Forms.Label bata;
        private System.Windows.Forms.TextBox allbata;
        private System.Windows.Forms.Button btncntp;
        
        private System.Windows.Forms.TextBox txtpr;
        private System.Windows.Forms.Button btnclr;
        private System.Windows.Forms.Label cost;
        private System.Windows.Forms.Label profit;
        private System.Windows.Forms.TextBox c1;
        private System.Windows.Forms.Button btnstng;
        private System.Windows.Forms.Button btnhome;
        private System.Windows.Forms.Button btnback;


    }
}