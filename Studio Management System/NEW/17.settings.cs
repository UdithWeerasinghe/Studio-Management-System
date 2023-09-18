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
    public partial class settings : Form
    {
        
        public settings()
        {
            InitializeComponent();
        }

        private void btncp_Click(object sender, EventArgs e)
        {
            chngepwd obj = new chngepwd();
            obj.Show();
            this.Hide();
        }

        private void btnbkup_Click(object sender, EventArgs e)
        {
            set obj = new set();
            obj.Show();
            this.Hide();
        }

        private void btnlgout_Click(object sender, EventArgs e)
        {
             DialogResult ans = MessageBox.Show("Do you Really Want to Log out?", "Log out", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (ans == DialogResult.Yes)
                try
                {
                    
                    
                    login obj = new login();
                    obj.Show();
                    this.Hide();
                    

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            mainmenu obj = new mainmenu();
            obj.Show();
            this.Hide();
        }

        private void btnhome_Click(object sender, EventArgs e)
        {
            mainmenu obj = new mainmenu();
            obj.Show();
            this.Hide();
        }

       



      
    }
}
