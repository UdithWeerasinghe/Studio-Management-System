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
    public partial class memlog : Form
    {
        
        public memlog()
        {
            InitializeComponent();
        }
        private void memlog_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mainDataSet5.member' table. You can move, or remove it, as needed.
            
            this.memberTableAdapter1.Fill(this.mainDataSet5.member);

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
