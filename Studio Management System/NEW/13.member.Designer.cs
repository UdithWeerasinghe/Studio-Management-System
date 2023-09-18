namespace NEW
{
    partial class member
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(member));
            this.btnadd = new System.Windows.Forms.Button();
            this.btndel = new System.Windows.Forms.Button();
            this.btnedit = new System.Windows.Forms.Button();
            this.btnsrc = new System.Windows.Forms.Button();
            this.btnstng = new System.Windows.Forms.Button();
            this.btnhome = new System.Windows.Forms.Button();
            this.btnback = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnadd
            // 
            this.btnadd.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.btnadd.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadd.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnadd.Location = new System.Drawing.Point(134, 122);
            this.btnadd.Margin = new System.Windows.Forms.Padding(4);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(126, 56);
            this.btnadd.TabIndex = 0;
            this.btnadd.Text = "Add new";
            this.btnadd.UseVisualStyleBackColor = false;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // btndel
            // 
            this.btndel.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.btndel.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndel.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btndel.Location = new System.Drawing.Point(133, 186);
            this.btndel.Margin = new System.Windows.Forms.Padding(4);
            this.btndel.Name = "btndel";
            this.btndel.Size = new System.Drawing.Size(126, 56);
            this.btndel.TabIndex = 1;
            this.btndel.Text = "Remove";
            this.btndel.UseVisualStyleBackColor = false;
            this.btndel.Click += new System.EventHandler(this.btndel_Click);
            // 
            // btnedit
            // 
            this.btnedit.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.btnedit.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnedit.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnedit.Location = new System.Drawing.Point(134, 250);
            this.btnedit.Margin = new System.Windows.Forms.Padding(4);
            this.btnedit.Name = "btnedit";
            this.btnedit.Size = new System.Drawing.Size(126, 56);
            this.btnedit.TabIndex = 2;
            this.btnedit.Text = "Update";
            this.btnedit.UseVisualStyleBackColor = false;
            this.btnedit.Click += new System.EventHandler(this.btnedit_Click);
            // 
            // btnsrc
            // 
            this.btnsrc.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.btnsrc.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsrc.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnsrc.Location = new System.Drawing.Point(134, 313);
            this.btnsrc.Margin = new System.Windows.Forms.Padding(4);
            this.btnsrc.Name = "btnsrc";
            this.btnsrc.Size = new System.Drawing.Size(126, 56);
            this.btnsrc.TabIndex = 3;
            this.btnsrc.Text = "Search";
            this.btnsrc.UseVisualStyleBackColor = false;
            this.btnsrc.Click += new System.EventHandler(this.btnsrc_Click);
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
            this.btnstng.TabIndex = 9;
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
            this.btnhome.TabIndex = 8;
            this.btnhome.UseVisualStyleBackColor = false;
            this.btnhome.Click += new System.EventHandler(this.btnhome_Click_1);
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
            this.btnback.TabIndex = 7;
            this.btnback.UseVisualStyleBackColor = false;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // member
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1023, 741);
            this.ControlBox = false;
            this.Controls.Add(this.btnstng);
            this.Controls.Add(this.btnhome);
            this.Controls.Add(this.btnback);
            this.Controls.Add(this.btnsrc);
            this.Controls.Add(this.btnedit);
            this.Controls.Add(this.btndel);
            this.Controls.Add(this.btnadd);
            this.Font = new System.Drawing.Font("Comic Sans MS", 9.75F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "member";
            this.Text = "Member";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Button btndel;
        private System.Windows.Forms.Button btnedit;
        private System.Windows.Forms.Button btnsrc;
        private System.Windows.Forms.Button btnstng;
        private System.Windows.Forms.Button btnhome;
        private System.Windows.Forms.Button btnback;
    }
}