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
    public partial class proadd : Form
    {

        SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=K:\Studio Management System\NEW\Main.mdf;Integrated Security=True;User Instance=True");
        SqlCommand com; 
      
        public proadd()
        {
            InitializeComponent();

        }
        
        
        private void btnadd2_Click(object sender, EventArgs e)
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
                    string sql = "select * from Tablepro where projectno='" + mskno.Text + "'";
                    com = new SqlCommand(sql, con);
                    SqlDataReader dr;
                    dr = com.ExecuteReader();
                    if (dr.Read())
                    {
                        MessageBox.Show("Project Found,Try Again", "Add Project", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                        mskno.Clear();
                        mskno.Focus();
                    }
                    else
                    {
                        dtp1.Enabled = true;
                        txtev.Enabled = true;
                        txthtl.Enabled = true;
                        txtcn.Enabled = true;
                        txtpac.Enabled = true;
                        txtadv.Enabled = true;
                        allbata.Enabled = true;
                        othrc.Enabled = true;
                        btnsv.Enabled = true;
                        txtcntct.Enabled = true;
                        txtev.Focus();

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
                        string sql = "Insert into Tablepro(projectno,date,event,hotel,cn,pac,advance,allbata,othercost,contact) values('" + mskno.Text + "','" + dtp1.Text + "','" + txtev.Text + "','" + txthtl.Text + "','" + txtcn.Text + "','" + txtpac.Text + "','" + txtadv.Text + "','" + allbata.Text + "','" + othrc.Text + "','"+txtcntct.Text+"')";
                        com = new SqlCommand(sql, con);
                        com.ExecuteNonQuery();
                        MessageBox.Show("Project Added", "Add", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
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
                        txtcn.Enabled = false;
                        dtp1.Enabled = false;
                        txtev.Enabled = false;
                        txthtl.Enabled = false;
                        txtpac.Enabled = false;
                        txtadv.Enabled = false;
                        allbata.Enabled = false;
                        othrc.Enabled = false;
                        txtcntct.Enabled = false;

                        mskno.Enabled = true;



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
            
            
        }
        private void Clear_Text()
        {
            mskno.Text = " ";
            mskno.Clear();
            txtev.Clear();
            txthtl.Clear();
            txtcn.Clear();
            txtpac.Clear();
            txtadv.Clear();
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
                        con.Open();
                        string sql = "select * from Tablepro where projectno='" + mskno.Text + "'";
                        com = new SqlCommand(sql, con);
                        SqlDataReader dr;
                        dr = com.ExecuteReader();
                        if (dr.Read())
                        {
                            MessageBox.Show("Project Found,Try Again", "Add Project", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                            mskno.Clear();
                            mskno.Focus();
                        }
                        else
                        {
                            dtp1.Enabled = true;
                            txtev.Enabled = true;
                            txthtl.Enabled = true;
                            txtcn.Enabled = true;
                            txtpac.Enabled = true;
                            txtadv.Enabled = true;
                            allbata.Enabled = true;
                            othrc.Enabled = true;
                            btnsv.Enabled = true;
                            txtcntct.Enabled = true;
                            txtev.Focus();

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

        private void txtev_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                txthtl.Focus();
        }

        private void txthtl_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                txtcn.Focus();
        }

        private void txtcn_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                txtpac.Focus();
        }

        private void txtpac_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                txtadv.Focus();
        }

        private void txtadv_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                allbata.Focus();
        }

        private void allbata_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                othrc.Focus();
        }

       

        private void btnback_Click_1(object sender, EventArgs e)
        {
            project obj = new project();
            obj.Show();
            this.Hide();
        }

        private void btnhome_Click_1(object sender, EventArgs e)
        {
            mainmenu obj = new mainmenu();
            obj.Show();
            this.Hide();
        }

        private void btnstng_Click_1(object sender, EventArgs e)
        {
            settings obj = new settings();
            obj.Show();
            this.Hide();
        }

        

        

    
        }
                

        

       
        }



    


    

            
       
        
                        

            
        
    
