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
    public partial class prodel : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=K:\Studio Management System\NEW\Main.mdf;Integrated Security=True;User Instance=True");
        SqlCommand com;
        public prodel()
        {
            InitializeComponent();
        }

        private void btnsrc2_Click(object sender, EventArgs e)
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
                        btndel.Enabled = true;

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
                            btncan.Enabled = true;
                            btndel.Enabled = true;



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
        }

        private void btndel_Click(object sender, EventArgs e)
        {
            DialogResult ans = MessageBox.Show("Do you Really Want to Delete this Record?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (ans == DialogResult.Yes)
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
                        string sql = "Delete from tablepro where projectno='" + mskno.Text + "'";
                        com = new SqlCommand(sql, con);
                        com.ExecuteNonQuery();
                        MessageBox.Show("Project Deleted");

                        mskno.Focus();
                        mskno.Clear();
                        txtpn.Clear();
                        txtev.Clear();
                        txthtl.Clear();
                        txtcn.Clear();
                        txtpac.Clear();
                        txtadv.Clear();
                        allbata.Clear();
                        txtcntct.Clear();
                        othrc.Clear();


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


        private void btncan_Click(object sender, EventArgs e)
        {
            Clear_Text();
            mskno.Clear();
            txtev.Clear();
            txthtl.Clear();
            txtcn.Clear();
            txtpac.Clear();
            txtadv.Clear();
            txtcntct.Clear();
            mskno.Focus();


        }
        private void Clear_Text()
        {
            mskno.Text = " ";


        }

        private void btncan_Click_1(object sender, EventArgs e)
        {
            mskno.Text = " ";
            mskno.Clear();
            txtev.Clear();
            txthtl.Clear();
            txtcn.Clear();
            txtpac.Clear();
            txtadv.Clear();
            allbata.Clear();
            othrc.Clear();
            txtcntct.Clear();

            mskno.Focus();
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
                        btndel.Enabled = true;

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
                            btncan.Enabled = true;
                            btndel.Enabled = true;



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
        
    

