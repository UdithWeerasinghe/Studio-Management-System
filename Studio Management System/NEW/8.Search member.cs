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
    public partial class memsrc : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=K:\Studio Management System\NEW\Main.mdf;Integrated Security=True;User Instance=True");
        SqlCommand com;
        public memsrc()
        {
            InitializeComponent();
        }

        private void btnsrc2_Click(object sender, EventArgs e)
        {
            if (mskno.Text.Length < 4)
            {
                MessageBox.Show("Wrong Length", "Length Check", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                mskno.Clear();
                mskno.Focus();
            }
            else
            {
                try
                {
                    btncan.Enabled = true;


                    con.Open();
                    string sql = "Select * from Member where num='" + mskno.Text + "'";
                    com = new SqlCommand(sql, con);
                    SqlDataReader dr = com.ExecuteReader();
                    if (dr.Read())
                    {
                        txtmn.Text = dr["num"].ToString();
                        txtnm.Text = dr["name"].ToString();
                        cmb.Text = dr["gender"].ToString();
                        dtp.Text = dr["dob"].ToString();
                        txtage.Text = dr["age"].ToString();
                        txtadr.Text = dr["address"].ToString();
                        txtnic.Text = dr["nic"].ToString();
                        txttp1.Text = dr["tp1"].ToString();
                        txttp2.Text = dr["tp2"].ToString();
                        txte.Text = dr["email"].ToString();
                        txtsal.Text = dr["sal"].ToString();
                        btncan.Enabled = true;




                    }
                    else
                    {
                        MessageBox.Show("Member Not Found", "Search Member", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                        mskno.Clear();
                        mskno.Focus();

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






        private void btncan_Click(object sender, EventArgs e)
        {
            Clear_Text();
            mskno.Clear();
            txtnm.Clear();
            txtmn.Clear();
            txtage.Clear();
            txtadr.Clear();
            txtnic.Clear();
            txttp1.Clear();
            txttp2.Clear();
            txte.Clear();
            txtsal.Clear();
            mskno.Focus();



        }
        private void Clear_Text()
        {
            mskno.Text = " ";


        }

        private void mskno_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                if (mskno.Text.Length < 4)
                {
                    MessageBox.Show("Wrong Length", "Length Check", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    mskno.Clear();
                    mskno.Focus();
                }
                else
                {
                    try
                    {
                        btncan.Enabled = true;


                        con.Open();
                        string sql = "Select * from Member where num='" + mskno.Text + "'";
                        com = new SqlCommand(sql, con);
                        SqlDataReader dr = com.ExecuteReader();
                        if (dr.Read())
                        {
                            txtmn.Text = dr["num"].ToString();
                            txtnm.Text = dr["name"].ToString();
                            cmb.Text = dr["gender"].ToString();
                            dtp.Text = dr["dob"].ToString();
                            txtage.Text = dr["age"].ToString();
                            txtadr.Text = dr["address"].ToString();
                            txtnic.Text = dr["nic"].ToString();
                            txttp1.Text = dr["tp1"].ToString();
                            txttp2.Text = dr["tp2"].ToString();
                            txte.Text = dr["email"].ToString();
                            txtsal.Text = dr["sal"].ToString();
                            btncan.Enabled = true;




                        }
                        else
                        {
                            MessageBox.Show("Member Not Found", "Search Member", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                            mskno.Clear();
                            mskno.Focus();

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
            member obj = new member();
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
          
    
        
    

