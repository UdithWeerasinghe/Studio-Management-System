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
    public partial class project : Form
    {
        public project()
        {
            InitializeComponent();
        }

        private void btnnew_Click(object sender, EventArgs e)
        {
            proadd frm = new proadd();
            frm.Show();
            this.Hide();
        }

        private void btndel_Click(object sender, EventArgs e)
        {
            prodel frm = new prodel();
            frm.Show();
            this.Hide();
        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            proedit frm = new proedit();
            frm.Show();
            this.Hide();
        }

        private void btnsrc_Click(object sender, EventArgs e)
        {
            prosrc frm = new prosrc();
            frm.Show();
            this.Hide();
        }

        

        

        private void btnstng_Click(object sender, EventArgs e)
        {
            settings obj = new settings();
            obj.Show();
            this.Hide();
        }

        private void btnback_Click_1(object sender, EventArgs e)
        {
            mainmenu obj = new mainmenu();
            obj.Show();
            this.Hide();
        }

        private void btnhome_Click_1(object sender, EventArgs e)
        {
            mainmenu obj = new mainmenu();
            obj.Show();
            this.Hide();
        }

        
    }
}
