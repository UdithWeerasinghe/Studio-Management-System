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
    public partial class proedit : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=K:\Studio Management System\NEW\Main.mdf;Integrated Security=True;User Instance=True");
        SqlCommand com;
        public proedit()
        {
            InitializeComponent();
        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            txtev.ReadOnly = false;
            txthtl.ReadOnly = false;
            txtcn.ReadOnly = false;
            txtpac.ReadOnly = false;
            txtadv.ReadOnly = false;
            allbata.ReadOnly = false;
            othrc.ReadOnly = false;
            txtcntct.ReadOnly = false;

            txtpn.ReadOnly = false;

            btnsv.Enabled = true;
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
                    string sql = "Select * from Tablepro where projectno='" + mskno.Text + "'";
                    com = new SqlCommand(sql, con);
                    SqlDataReader dr = com.ExecuteReader();
                    if (dr.Read())
                    {
                        txtpn.Text = dr["projectno"].ToString();
                        dtp1.Text = dr["date"].ToString();
                        txtev.Text = dr["event"].ToString();
                        txthtl.Text = dr["hotel"].ToString();
                        txtcn.Text = dr["cn"].ToString();
                        txtpac.Text = dr["pac"].ToString();
                        txtadv.Text = dr["advance"].ToString();
                        allbata.Text = dr["allbata"].ToString();
                        othrc.Text = dr["othercost"].ToString();
                        txtcntct.Text = dr["contact"].ToString();

                        btnedit.Enabled = true;


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

        private void btnsv_Click(object sender, EventArgs e)
        {
            {
                try
                {
                    int a;
                    a = int.Parse(txtpac.Text + txtadv.Text + allbata.Text + othrc.Text);
                    MessageBox.Show(a.ToString());
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);


                }
                try
                {
                    con.Open();
                    string sql = "Update Tablepro set projectno='" + txtpn.Text + "',date='" + dtp1.Text + "',event='" + txtev.Text + "',hotel='" + txthtl.Text + "',cn='" + txtcn.Text + "',pac='" + txtpac.Text + "',advance='" + txtadv.Text + "',allbata='" + allbata.Text + "',othercost='" + othrc.Text + "',contact='"+txtcntct.Text+"' where Projectno='" + mskno.Text + "'";
                    com = new SqlCommand(sql, con);
                    com.ExecuteNonQuery();
                    MessageBox.Show("Details Updated");



                    mskno.Clear();
                    txtev.Clear();
                    txthtl.Clear();
                    txtcn.Clear();
                    txtpac.Clear();
                    txtadv.Clear();
                    allbata.Clear();
                    txtcntct.Clear();
                    othrc.Clear();

                    mskno.Focus();
                    txtev.ReadOnly = true;
                    txthtl.ReadOnly = true;
                    txtcn.ReadOnly = true;
                    txtpac.ReadOnly = true;
                    txtadv.ReadOnly = true;
                    allbata.ReadOnly = true;
                    othrc.ReadOnly = true;
                    txtcntct.ReadOnly=true;
                    txtpn.ReadOnly = true;
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
                        string sql = "Select * from Tablepro where projectno='" + mskno.Text + "'";
                        com = new SqlCommand(sql, con);
                        SqlDataReader dr = com.ExecuteReader();
                        if (dr.Read())
                        {
                            txtpn.Text = dr["projectno"].ToString();
                            dtp1.Text = dr["date"].ToString();
                            txtev.Text = dr["event"].ToString();
                            txthtl.Text = dr["hotel"].ToString();
                            txtcn.Text = dr["cn"].ToString();
                            txtpac.Text = dr["pac"].ToString();
                            txtadv.Text = dr["advance"].ToString();
                            allbata.Text = dr["allbata"].ToString();
                            othrc.Text = dr["othercost"].ToString();
                            txtcntct.Text = dr["contact"].ToString();
                            btnedit.Enabled = true;


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

        

        private void btnback_Click(object sender, EventArgs e)
        {
            project obj = new project();
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
        
    

