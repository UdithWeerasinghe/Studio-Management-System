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
    public partial class chngepwd : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=K:\Studio Management System\NEW\Main.mdf;Integrated Security=True;User Instance=True");
        SqlCommand com;
        public chngepwd()
        {
            InitializeComponent();
        }
        private void btncnge_Click(object sender, EventArgs e)
        {
            if (newpwd.Text.Length < 4)
            {
                MessageBox.Show("Add More items", "Less security", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                newpwd.Clear();
                newpwd.Focus();
            }
            else
            {

                {
                    DialogResult ans = MessageBox.Show("Do you Really Want to Change the password?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (ans == DialogResult.Yes)
                        try
                        {
                            con.Open();
                            string sql = "Update Tablelog set password='" + newpwd.Text + "'";
                            com = new SqlCommand(sql, con);
                            com.ExecuteNonQuery();
                            MessageBox.Show("Password changed!");




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
                        newpwd.Enabled = true;
                        btncnge.Enabled = true;
                        newpwd.Focus();


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





        private void btnback_Click(object sender, EventArgs e)
        {
            settings obj = new settings();
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
                        MessageBox.Show("Confirmed", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                        newpwd.Enabled = true;
                        btncnge.Enabled = true;
                        newpwd.Focus();


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

        
    }
}

        
        

        

        

        

        

        
    

             
               
            
        
    

        
    

