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
    public partial class mainmenu : Form
    {
        public mainmenu()
        {
            InitializeComponent();
        }

        private void btnpro_Click(object sender, EventArgs e)
        {
            
            project frm = new project();
            frm.Show();
            this.Hide();
            
        }

        private void btnmem_Click(object sender, EventArgs e)
        {
            member frm = new member();
            frm.Show();
            this.Hide();
        }

        private void btnlogs_Click(object sender, EventArgs e)
        {
            log frm = new log();
            frm.Show();
            this.Hide();
        }

        private void btnset_Click(object sender, EventArgs e)
        {
            settings frm = new settings();
            frm.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            income frm = new income();
            frm.Show();
            this.Hide();
        }

        

       

        
    }
}
