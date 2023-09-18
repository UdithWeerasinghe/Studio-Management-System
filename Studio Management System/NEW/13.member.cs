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
    public partial class member : Form
    {
        public member()
        {
            InitializeComponent();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            memadd frm = new memadd();
            frm.Show();
            this.Hide();
        }

        private void btndel_Click(object sender, EventArgs e)
        {
            memdel frm = new memdel();
            frm.Show();
            this.Hide();
        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            memedit frm = new memedit();
            frm.Show();
            this.Hide();
        }

        private void btnsrc_Click(object sender, EventArgs e)
        {
            memsrc frm = new memsrc();
            frm.Show();
            this.Hide();
        }

        private void btnback_Click(object sender, EventArgs e)
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

        private void btnhome_Click_1(object sender, EventArgs e)
        {
            mainmenu obj = new mainmenu();
            obj.Show();
            this.Hide();
        }
    }
}
