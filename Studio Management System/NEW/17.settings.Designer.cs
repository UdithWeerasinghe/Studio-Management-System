namespace NEW
{
    partial class settings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(settings));
            this.btnlgout = new System.Windows.Forms.Button();
            this.btncp = new System.Windows.Forms.Button();
            this.btnbkup = new System.Windows.Forms.Button();
            this.btnstng = new System.Windows.Forms.Button();
            this.btnhome = new System.Windows.Forms.Button();
            this.btnback = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnlgout
            // 
            this.btnlgout.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.btnlgout.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlgout.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnlgout.Location = new System.Drawing.Point(146, 271);
            this.btnlgout.Margin = new System.Windows.Forms.Padding(4);
            this.btnlgout.Name = "btnlgout";
            this.btnlgout.Size = new System.Drawing.Size(126, 56);
            this.btnlgout.TabIndex = 0;
            this.btnlgout.Text = "Log Out";
            this.btnlgout.UseVisualStyleBackColor = false;
            this.btnlgout.Click += new System.EventHandler(this.btnlgout_Click);
            // 
            // btncp
            // 
            this.btncp.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.btncp.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncp.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btncp.Location = new System.Drawing.Point(146, 142);
            this.btncp.Margin = new System.Windows.Forms.Padding(4);
            this.btncp.Name = "btncp";
            this.btncp.Size = new System.Drawing.Size(126, 56);
            this.btncp.TabIndex = 1;
            this.btncp.Text = "Change Password";
            this.btncp.UseVisualStyleBackColor = false;
            this.btncp.Click += new System.EventHandler(this.btncp_Click);
            // 
            // btnbkup
            // 
            this.btnbkup.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.btnbkup.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbkup.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnbkup.Location = new System.Drawing.Point(146, 207);
            this.btnbkup.Name = "btnbkup";
            this.btnbkup.Size = new System.Drawing.Size(126, 56);
            this.btnbkup.TabIndex = 9;
            this.btnbkup.Text = "Set Backup Key";
            this.btnbkup.UseVisualStyleBackColor = false;
            this.btnbkup.Click += new System.EventHandler(this.btnbkup_Click);
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
            // settings
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
            this.Controls.Add(this.btnbkup);
            this.Controls.Add(this.btncp);
            this.Controls.Add(this.btnlgout);
            this.Font = new System.Drawing.Font("Comic Sans MS", 9.75F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "settings";
            this.Text = "Settings";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnlgout;
        private System.Windows.Forms.Button btncp;
        private System.Windows.Forms.Button btnbkup;
        private System.Windows.Forms.Button btnstng;
        private System.Windows.Forms.Button btnhome;
        private System.Windows.Forms.Button btnback;
    }
}