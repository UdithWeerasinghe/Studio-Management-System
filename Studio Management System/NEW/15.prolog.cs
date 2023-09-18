using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace NEW
{
    public partial class prolog : Form
    {
        public prolog()
        {
            InitializeComponent();
        }



        private void prolog_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mainDataSet4.tablepro' table. You can move, or remove it, as needed.
            this.tableproTableAdapter3.Fill(this.mainDataSet4.tablepro);

        }

        

        

        private void btnback_Click(object sender, EventArgs e)
        {
            log obj = new log();
            obj.Show();
            this.Hide();
        }

        private void btnhome_Click(object sender, EventArgs e)
        {
            mainmenu obj = new mainmenu();
            obj.Show();
            this.Hide();
        }

        private void btnstng_Click(object sender, EventArgs e)
        {
            settings obj = new settings();
            obj.Show();
            this.Hide();
        }

        

        
    }
}
