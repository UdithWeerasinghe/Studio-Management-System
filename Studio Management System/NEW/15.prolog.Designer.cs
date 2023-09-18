namespace NEW
{
    partial class prolog
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(prolog));
            this.tableproBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mainDataSet = new NEW.MainDataSet();
            this.tableproTableAdapter = new NEW.MainDataSetTableAdapters.tableproTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.projectnoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eventDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hotelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cnDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pacDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.advanceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.allbataDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.othercostDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableproBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.mainDataSet4 = new NEW.MainDataSet4();
            this.memberBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mainDataSet3 = new NEW.MainDataSet3();
            this.tableproBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.mainDataSet1 = new NEW.MainDataSet1();
            this.tableproTableAdapter1 = new NEW.MainDataSet1TableAdapters.tableproTableAdapter();
            this.btnstng = new System.Windows.Forms.Button();
            this.btnhome = new System.Windows.Forms.Button();
            this.btnback = new System.Windows.Forms.Button();
            this.mainDataSet2 = new NEW.MainDataSet2();
            this.tableproBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.tableproTableAdapter2 = new NEW.MainDataSet2TableAdapters.tableproTableAdapter();
            this.memberTableAdapter = new NEW.MainDataSet3TableAdapters.memberTableAdapter();
            this.tableproTableAdapter3 = new NEW.MainDataSet4TableAdapters.tableproTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.tableproBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableproBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memberBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableproBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableproBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // tableproBindingSource
            // 
            this.tableproBindingSource.DataMember = "tablepro";
            this.tableproBindingSource.DataSource = this.mainDataSet;
            // 
            // mainDataSet
            // 
            this.mainDataSet.DataSetName = "MainDataSet";
            this.mainDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tableproTableAdapter
            // 
            this.tableproTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Linen;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.projectnoDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.eventDataGridViewTextBoxColumn,
            this.hotelDataGridViewTextBoxColumn,
            this.cnDataGridViewTextBoxColumn,
            this.pacDataGridViewTextBoxColumn,
            this.advanceDataGridViewTextBoxColumn,
            this.allbataDataGridViewTextBoxColumn,
            this.othercostDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tableproBindingSource3;
            this.dataGridView1.GridColor = System.Drawing.Color.Linen;
            this.dataGridView1.Location = new System.Drawing.Point(-20, 69);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(1035, 635);
            this.dataGridView1.TabIndex = 0;
            
            // 
            // projectnoDataGridViewTextBoxColumn
            // 
            this.projectnoDataGridViewTextBoxColumn.DataPropertyName = "projectno";
            this.projectnoDataGridViewTextBoxColumn.HeaderText = "Project No";
            this.projectnoDataGridViewTextBoxColumn.Name = "projectnoDataGridViewTextBoxColumn";
            this.projectnoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // eventDataGridViewTextBoxColumn
            // 
            this.eventDataGridViewTextBoxColumn.DataPropertyName = "event";
            this.eventDataGridViewTextBoxColumn.HeaderText = "Event";
            this.eventDataGridViewTextBoxColumn.Name = "eventDataGridViewTextBoxColumn";
            this.eventDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // hotelDataGridViewTextBoxColumn
            // 
            this.hotelDataGridViewTextBoxColumn.DataPropertyName = "hotel";
            this.hotelDataGridViewTextBoxColumn.HeaderText = "Hotel";
            this.hotelDataGridViewTextBoxColumn.Name = "hotelDataGridViewTextBoxColumn";
            this.hotelDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cnDataGridViewTextBoxColumn
            // 
            this.cnDataGridViewTextBoxColumn.DataPropertyName = "cn";
            this.cnDataGridViewTextBoxColumn.HeaderText = "Couple Names";
            this.cnDataGridViewTextBoxColumn.Name = "cnDataGridViewTextBoxColumn";
            this.cnDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pacDataGridViewTextBoxColumn
            // 
            this.pacDataGridViewTextBoxColumn.DataPropertyName = "pac";
            this.pacDataGridViewTextBoxColumn.HeaderText = "Package";
            this.pacDataGridViewTextBoxColumn.Name = "pacDataGridViewTextBoxColumn";
            this.pacDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // advanceDataGridViewTextBoxColumn
            // 
            this.advanceDataGridViewTextBoxColumn.DataPropertyName = "advance";
            this.advanceDataGridViewTextBoxColumn.HeaderText = "Advance";
            this.advanceDataGridViewTextBoxColumn.Name = "advanceDataGridViewTextBoxColumn";
            this.advanceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // allbataDataGridViewTextBoxColumn
            // 
            this.allbataDataGridViewTextBoxColumn.DataPropertyName = "allbata";
            this.allbataDataGridViewTextBoxColumn.HeaderText = "BATA";
            this.allbataDataGridViewTextBoxColumn.Name = "allbataDataGridViewTextBoxColumn";
            this.allbataDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // othercostDataGridViewTextBoxColumn
            // 
            this.othercostDataGridViewTextBoxColumn.DataPropertyName = "othercost";
            this.othercostDataGridViewTextBoxColumn.HeaderText = "Other Cost";
            this.othercostDataGridViewTextBoxColumn.Name = "othercostDataGridViewTextBoxColumn";
            this.othercostDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tableproBindingSource3
            // 
            this.tableproBindingSource3.DataMember = "tablepro";
            this.tableproBindingSource3.DataSource = this.mainDataSet4;
            // 
            // mainDataSet4
            // 
            this.mainDataSet4.DataSetName = "MainDataSet4";
            this.mainDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // memberBindingSource
            // 
            this.memberBindingSource.DataMember = "member";
            this.memberBindingSource.DataSource = this.mainDataSet3;
            // 
            // mainDataSet3
            // 
            this.mainDataSet3.DataSetName = "MainDataSet3";
            this.mainDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tableproBindingSource1
            // 
            this.tableproBindingSource1.DataMember = "tablepro";
            this.tableproBindingSource1.DataSource = this.mainDataSet1;
            // 
            // mainDataSet1
            // 
            this.mainDataSet1.DataSetName = "MainDataSet1";
            this.mainDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tableproTableAdapter1
            // 
            this.tableproTableAdapter1.ClearBeforeFill = true;
            // 
            // btnstng
            // 
            this.btnstng.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnstng.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnstng.BackgroundImage")));
            this.btnstng.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnstng.Location = new System.Drawing.Point(964, 14);
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
            this.btnhome.Location = new System.Drawing.Point(911, 14);
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
            this.btnback.Location = new System.Drawing.Point(858, 14);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(47, 48);
            this.btnback.TabIndex = 10;
            this.btnback.UseVisualStyleBackColor = false;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // mainDataSet2
            // 
            this.mainDataSet2.DataSetName = "MainDataSet2";
            this.mainDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tableproBindingSource2
            // 
            this.tableproBindingSource2.DataMember = "tablepro";
            this.tableproBindingSource2.DataSource = this.mainDataSet2;
            // 
            // tableproTableAdapter2
            // 
            this.tableproTableAdapter2.ClearBeforeFill = true;
            // 
            // memberTableAdapter
            // 
            this.memberTableAdapter.ClearBeforeFill = true;
            // 
            // tableproTableAdapter3
            // 
            this.tableproTableAdapter3.ClearBeforeFill = true;
            // 
            // prolog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1028, 741);
            this.ControlBox = false;
            this.Controls.Add(this.btnstng);
            this.Controls.Add(this.btnhome);
            this.Controls.Add(this.btnback);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Comic Sans MS", 9.75F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "prolog";
            this.Text = "Project Log";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.prolog_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tableproBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableproBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memberBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableproBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableproBindingSource2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MainDataSet mainDataSet;
        private System.Windows.Forms.BindingSource tableproBindingSource;
        private MainDataSetTableAdapters.tableproTableAdapter tableproTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private MainDataSet1 mainDataSet1;
        private System.Windows.Forms.BindingSource tableproBindingSource1;
        private MainDataSet1TableAdapters.tableproTableAdapter tableproTableAdapter1;
        private System.Windows.Forms.Button btnstng;
        private System.Windows.Forms.Button btnhome;
        private System.Windows.Forms.Button btnback;
        private MainDataSet2 mainDataSet2;
        private System.Windows.Forms.BindingSource tableproBindingSource2;
        private MainDataSet2TableAdapters.tableproTableAdapter tableproTableAdapter2;
        private MainDataSet3 mainDataSet3;
        private System.Windows.Forms.BindingSource memberBindingSource;
        private MainDataSet3TableAdapters.memberTableAdapter memberTableAdapter;
        private MainDataSet4 mainDataSet4;
        private System.Windows.Forms.BindingSource tableproBindingSource3;
        private MainDataSet4TableAdapters.tableproTableAdapter tableproTableAdapter3;
        private System.Windows.Forms.DataGridViewTextBoxColumn projectnoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eventDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hotelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cnDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pacDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn advanceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn allbataDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn othercostDataGridViewTextBoxColumn;
    }
}