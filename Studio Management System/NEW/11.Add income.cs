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
    public partial class income : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=K:\Studio Management System\NEW\Main.mdf;Integrated Security=True;User Instance=True");
        SqlCommand com;
        public income()
        {
            InitializeComponent();
        }

        private void btnsrc_Click(object sender, EventArgs e)
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
                    btncnt.Enabled = true;
                    btncntp.Enabled = true;



                    con.Open();
                    string sql = "Select * from Tablepro where projectno='" + mskno.Text + "'";
                    com = new SqlCommand(sql, con);
                    SqlDataReader dr = com.ExecuteReader();
                    if (dr.Read())
                    {

                        txtev.Text = dr["event"].ToString();
                        txtpac.Text = dr["pac"].ToString();
                        allbata.Text = dr["allbata"].ToString();
                        othrc.Text = dr["othercost"].ToString();



                    }
                    else
                    {
                        MessageBox.Show("Project Not Found", "Search Project", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
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




        private void btncnt_Click(object sender, EventArgs e)
        {

            c1.Text = (Double.Parse(allbata.Text) + Double.Parse(othrc.Text)).ToString();


        }

        private void income_Load(object sender, EventArgs e)
        {
            mskno.Focus();

        }


        private void btnclr_Click(object sender, EventArgs e)
        {
            mskno.Clear();
            txtev.Clear();
            txtpac.Clear();
            allbata.Clear();
            othrc.Clear();
            c1.Clear();
            txtpr.Clear();
            mskno.Focus();
            btncnt.Enabled = false;
            btncntp.Enabled = false;

        }
        int pac;
        int cst;
        int prf;
        private void btncntp_Click(object sender, EventArgs e)
        {
            pac = int.Parse(txtpac.Text);
            cst = int.Parse(c1.Text);
            prf = pac - cst;
            txtpr.Text = prf.ToString();

        }

        private void mskno_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar==13)
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
                    btncnt.Enabled = true;
                    btncntp.Enabled = true;



                    con.Open();
                    string sql = "Select * from Tablepro where projectno='" + mskno.Text + "'";
                    com = new SqlCommand(sql, con);
                    SqlDataReader dr = com.ExecuteReader();
                    if (dr.Read())
                    {

                        txtev.Text = dr["event"].ToString();
                        txtpac.Text = dr["pac"].ToString();
                        allbata.Text = dr["allbata"].ToString();
                        othrc.Text = dr["othercost"].ToString();



                    }
                    else
                    {
                        MessageBox.Show("Project Not Found", "Search Project", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
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

        private void btnback_Click_1(object sender, EventArgs e)
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

        private void btnstng_Click(object sender, EventArgs e)
        {
            settings obj = new settings();
            obj.Show();
            this.Hide();
        }
    }
    }

