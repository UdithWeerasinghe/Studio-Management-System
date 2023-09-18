namespace NEW
{
    partial class mainmenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainmenu));
            this.btnpro = new System.Windows.Forms.Button();
            this.btnmem = new System.Windows.Forms.Button();
            this.btnlogs = new System.Windows.Forms.Button();
            this.btnset = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnpro
            // 
            this.btnpro.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.btnpro.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnpro.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnpro.Location = new System.Drawing.Point(82, 69);
            this.btnpro.Name = "btnpro";
            this.btnpro.Size = new System.Drawing.Size(156, 74);
            this.btnpro.TabIndex = 0;
            this.btnpro.Text = "Projects";
            this.btnpro.UseVisualStyleBackColor = false;
            this.btnpro.Click += new System.EventHandler(this.btnpro_Click);
            // 
            // btnmem
            // 
            this.btnmem.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.btnmem.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmem.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnmem.Location = new System.Drawing.Point(82, 149);
            this.btnmem.Name = "btnmem";
            this.btnmem.Size = new System.Drawing.Size(156, 74);
            this.btnmem.TabIndex = 1;
            this.btnmem.Text = "Members";
            this.btnmem.UseVisualStyleBackColor = false;
            this.btnmem.Click += new System.EventHandler(this.btnmem_Click);
            // 
            // btnlogs
            // 
            this.btnlogs.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.btnlogs.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlogs.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnlogs.Location = new System.Drawing.Point(82, 309);
            this.btnlogs.Name = "btnlogs";
            this.btnlogs.Size = new System.Drawing.Size(156, 74);
            this.btnlogs.TabIndex = 2;
            this.btnlogs.Text = "Logs";
            this.btnlogs.UseVisualStyleBackColor = false;
            this.btnlogs.Click += new System.EventHandler(this.btnlogs_Click);
            // 
            // btnset
            // 
            this.btnset.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.btnset.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnset.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnset.Location = new System.Drawing.Point(82, 389);
            this.btnset.Name = "btnset";
            this.btnset.Size = new System.Drawing.Size(156, 74);
            this.btnset.TabIndex = 3;
            this.btnset.Text = "Settings";
            this.btnset.UseVisualStyleBackColor = false;
            this.btnset.Click += new System.EventHandler(this.btnset_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.button1.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.button1.Location = new System.Drawing.Point(82, 229);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(156, 74);
            this.button1.TabIndex = 4;
            this.button1.Text = "Count Profit ";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // mainmenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(705, 520);
            this.ControlBox = false;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnset);
            this.Controls.Add(this.btnpro);
            this.Controls.Add(this.btnmem);
            this.Controls.Add(this.btnlogs);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "mainmenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Home Page";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnpro;
        private System.Windows.Forms.Button btnmem;
        private System.Windows.Forms.Button btnlogs;
        private System.Windows.Forms.Button btnset;
        private System.Windows.Forms.Button button1;





        public System.EventHandler projectsToolStripMenuItem_Click { get; set; }
    }
}