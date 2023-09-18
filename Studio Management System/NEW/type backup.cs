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
    public partial class type : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=K:\Studio Management System\NEW\Main.mdf;Integrated Security=True;User Instance=True");
        SqlCommand com;
        public type()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
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
                    string sql = "select * from Tablelog where backupkey='" + txtbkup.Text + "'";
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
                        txtbkup.Clear();

                        txtbkup.Focus();

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
                        string sql = "select * from Tablelog where backupkey='" + txtbkup.Text + "'";
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
                            txtbkup.Clear();

                            txtbkup.Focus();

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

        private void btnback_Click(object sender, EventArgs e)
        {
            login obj = new login();
            obj.Show();

            this.Hide();
        }
    }

        
}
