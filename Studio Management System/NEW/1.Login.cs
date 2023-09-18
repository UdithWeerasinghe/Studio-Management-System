using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace NEW
{
    public partial class login : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=K:\Studio Management System\NEW\Main.mdf;Integrated Security=True;User Instance=True");
        SqlCommand com;
        public login()
        {
            InitializeComponent();
        }
        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            
            try
            {
                
                con.Open();
                string sql = "select * from Tablelog where password='" + txtpwd.Text + "'";
                com = new SqlCommand(sql, con);
                SqlDataReader dr;
                dr = com.ExecuteReader();
                if (dr.Read())
                {
                    MessageBox.Show("Login success", "Loging", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    this.Hide();
                    mainmenu obj = new mainmenu();
                    obj.Show();

                }
                else
                {
                    MessageBox.Show("Login failed!", "Loging", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    txtpwd.Clear();
                    
                    txtun.Focus();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void txtpwd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar==13)
            try
            {

                con.Open();
                string sql = "select * from Tablelog where password='" + txtpwd.Text + "'";
                com = new SqlCommand(sql, con);
                SqlDataReader dr;
                dr = com.ExecuteReader();
                if (dr.Read())
                {
                    MessageBox.Show("Login success", "Loging", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    this.Hide();
                    mainmenu obj = new mainmenu();
                    obj.Show();

                }
                else
                {
                    MessageBox.Show("Login failed!", "Loging", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    txtpwd.Clear();

                    txtun.Focus();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void btnex_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            type obj= new type();
            obj.Show();
            this.Hide();
        }

       

       

       
    }
}
