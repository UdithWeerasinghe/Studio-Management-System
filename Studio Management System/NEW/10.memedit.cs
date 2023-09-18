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
    public partial class memedit : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=K:\NEW\NEW\Main.mdf;Integrated Security=True;User Instance=TrueData Source=.\SQLEXPRESS;AttachDbFilename=K:\Studio Management System\NEW\Main.mdf;Integrated Security=True;User Instance=True");
        SqlCommand com;
        public memedit()
        {
            InitializeComponent();
        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            txtnm.ReadOnly = false;
            txtmn.ReadOnly = false;
            txtage.ReadOnly = false;
            txtadr.ReadOnly = false;
            txtnic.ReadOnly = false;
            txttp1.ReadOnly = false;
            txttp2.ReadOnly = false;
            txte.ReadOnly = false;
            txtsal.ReadOnly = false;


            btnsv.Enabled = true;
        }

        private void btnsv_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string sql = "Update Member set num='" + txtmn.Text + "',name='" + txtnm.Text + "',gender='" + cmb.Text + "',dob='" + dtp.Text + "',age='" + txtage.Text + "',address='" + txtadr.Text + "',nic='" + txtnic.Text + "',tp1='" + txttp1.Text + "',tp2='" + txttp2.Text + "',email='" + txte.Text + "',sal='" + txtsal.Text + "' where num='" + mskno.Text + "'";
                com = new SqlCommand(sql, con);
                com.ExecuteNonQuery();
                MessageBox.Show("Details Updated");



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
                txtnm.ReadOnly = true;
                txtmn.ReadOnly = true;
                txtage.ReadOnly = true;
                txtadr.ReadOnly = true;
                txtnic.ReadOnly = true;
                txttp1.ReadOnly = true;
                txttp2.ReadOnly = true;
                txte.ReadOnly = true;
                txtsal.ReadOnly = true;
                mskno.Enabled = true;
                btnedit.Enabled = false;
                btnsv.Enabled = false;


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

                        btnsv.Enabled = true;
                        btnedit.Enabled = true;


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

                        btnsv.Enabled = true;
                        btnedit.Enabled = true;


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
