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
    public partial class set : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=K:\Studio Management System\NEW\Main.mdf;Integrated Security=True;User Instance=True");
        SqlCommand com;
        public set()
        {
            InitializeComponent();
        }
        
        private void txtpwd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                try
                {

                    con.Open();
                    string sql = "select * from Tablelog where password='" + txtpwd.Text + "'";
                    com = new SqlCommand(sql, con);
                    SqlDataReader dr;
                    dr = com.ExecuteReader();
                    if (dr.Read())
                    {
                        MessageBox.Show("Confirmed", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                        txtbkup.Enabled = true;
                        btnset.Enabled = true;
                        txtbkup.Focus();


                    }
                    else
                    {
                        MessageBox.Show("Confirmation failed!", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
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

       
            
            
        

        private void txtbkup_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar==13)
                if (txtbkup.Text.Length < 4)
                {
                    MessageBox.Show("Wrong Length", "Length Check", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    txtbkup.Clear();
                    txtbkup.Focus();
                }
                else
                {
                    try
                    {
                        con.Open();
                        string sql = "Update Tablelog set backupkey='" + txtbkup.Text + "'";
                        com = new SqlCommand(sql, con);
                        com.ExecuteNonQuery();
                        MessageBox.Show("Backup key set!");




                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        con.Close();
                        this.Hide();
                        settings obj = new settings();
                        obj.Show();
                    }
                }

        }

        private void btnback_Click(object sender, EventArgs e)
        {
            settings obj = new settings();
            obj.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            mainmenu obj = new mainmenu();
            obj.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            settings obj = new settings();
            obj.Show();
            this.Hide();
        }

        private void btnex_Click(object sender, EventArgs e)
        {
            settings obj = new settings();
            obj.Show();
            this.Hide();

        }

        private void btnlogin_Click_1(object sender, EventArgs e)
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
                    MessageBox.Show("Confirmed", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    txtbkup.Enabled = true;
                    btnset.Enabled = true;
                    txtbkup.Focus();


                }
                else
                {
                    MessageBox.Show("Confirmation failed!", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
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

        private void btnset_Click(object sender, EventArgs e)
        {
            if (txtbkup.Text.Length < 4)
            {
                MessageBox.Show("Wrong Length", "Length Check", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                txtbkup.Clear();
                txtbkup.Focus();
            }
            else
            {
                try
                {
                    con.Open();
                    string sql = "Update Tablelog set backupkey='" + txtbkup.Text + "'";
                    com = new SqlCommand(sql, con);
                    com.ExecuteNonQuery();
                    MessageBox.Show("Backup key set!");




                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    con.Close();
                    this.Hide();
                    settings obj = new settings();
                    obj.Show();
                }
            }
        }

        

       

        
    }
}
