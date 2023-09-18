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
    public partial class memadd : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=K:\Studio Management System\NEW\Main.mdf;Integrated Security=True;User Instance=True");
        SqlCommand com;

        public memadd()
        {
            InitializeComponent();
        }


        private void btnadd3_Click(object sender, EventArgs e)
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
                    string sql = "select * from Member where num ='" + mskno.Text + "'";
                    com = new SqlCommand(sql, con);
                    SqlDataReader dr;
                    dr = com.ExecuteReader();
                    if (dr.Read())
                    {
                        MessageBox.Show("Member Found,Try Again", "Add Member", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                        mskno.Clear();
                        mskno.Focus();
                    }
                    else
                    {
                        dtp.Enabled = true;
                        txtnm.Enabled = true;
                        txtage.Enabled = true;
                        txtadr.Enabled = true;
                        txtnic.Enabled = true;
                        txttp1.Enabled = true;
                        txttp2.Enabled = true;
                        txte.Enabled = true;
                        txtsal.Enabled = true;
                        cmb.Enabled = true;
                        btnsv.Enabled = true;
                        txtnm.Focus();

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

        private void btnsv_Click(object sender, EventArgs e)
        {
            {
                 
                    

               
                


                }
                if (mskno.Text.Length < 4)
                {
                    MessageBox.Show("Wrong Length", "Length Check", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    mskno.Clear();
                    mskno.Focus();
                }
                try
                {
                    con.Open();
                    string sql = "Insert into member(num,name,gender,dob,age,address,nic,tp1,tp2,email,sal) values('" + mskno.Text + "','" + txtnm.Text + "','" + cmb.Text + "','" + dtp.Text + "','" + txtage.Text + "','" + txtadr.Text + "','" + txtnic.Text + "','" + txttp1.Text + "','" + txttp2.Text + "','" + txte.Text + "','" + txtsal.Text + "')";
                    com = new SqlCommand(sql, con);
                    com.ExecuteNonQuery();
                    MessageBox.Show("Member Added", "Add", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    mskno.Clear();
                    txtnm.Clear();
                    txtage.Clear();
                    txtadr.Clear();
                    txtnic.Clear();
                    txttp1.Clear();
                    txttp2.Clear();
                    txte.Clear();
                    txtsal.Clear();
                    mskno.Focus();
                    mskno.Enabled = true;
                    txtnm.Enabled = false;
                    txtage.Enabled = false;
                    txtadr.Enabled = false;
                    txtnic.Enabled = false;
                    txttp1.Enabled = false;
                    txttp2.Enabled = false;
                    txte.Enabled = false;
                    txtsal.Enabled = false;

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
        

        private void btncan_Click(object sender, EventArgs e)
        {
            Clear_Text();
            mskno.Clear();
            txtnm.Clear();
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
                        btnsv.Enabled = true;
                        btncan.Enabled = true;
                        con.Open();
                        string sql = "select * from Member where num ='" + mskno.Text + "'";
                        com = new SqlCommand(sql, con);
                        SqlDataReader dr;
                        dr = com.ExecuteReader();
                        if (dr.Read())
                        {
                            MessageBox.Show("Member Found,Try Again", "Add Member", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                            mskno.Clear();
                            mskno.Focus();
                        }
                        else
                        {
                            dtp.Enabled = true;
                            txtnm.Enabled = true;
                            txtage.Enabled = true;
                            txtadr.Enabled = true;
                            txtnic.Enabled = true;
                            txttp1.Enabled = true;
                            txttp2.Enabled = true;
                            txte.Enabled = true;
                            txtsal.Enabled = true;
                            cmb.Enabled = true;

                            txtnm.Focus();

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

        private void txtnm_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                cmb.Focus();
        }

        private void cmb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            dtp.Focus();
        }

        private void dtp_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                txtage.Focus();
        }

        private void txtage_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                txtadr.Focus();
        }

        private void txtadr_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                txtnic.Focus();
        }

        private void txtnic_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                txttp1.Focus();
        }

        private void txttp1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                txttp2.Focus();
        }

        private void txttp2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                txte.Focus();
        }

        private void txte_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                txtsal.Focus();
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

            
        

       

    

       

    

       

