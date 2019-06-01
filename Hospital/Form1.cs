using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Hospital
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }
        #region Globalvariable
            string q =string.Empty;
            SqlConnection sc = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Hospital;Data Source=.");
            enum dbOpration { Insert, Update };
            dbOpration mydbOpration;
            int id;
        #endregion

        #region UserFunction
            private void LodeDataTocmbDoctor()
            {
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = new SqlCommand();
                da.SelectCommand.Connection = sc;
                da.SelectCommand.CommandText = "selec * From Doctor";


                DataSet ds = new DataSet();
                ds.Tables.Add("Doctor");
                ds.Tables["Doctor"].Columns.Add("Dr#");
                ds.Tables["Doctor"].Columns.Add("Dr_name");


                da.Fill(ds.Tables["Doctor"]);
                cmbDoctor.DataSource = ds.Tables["Doctor"];
                cmbDoctor.DisplayMember = "Dr_name";
                cmbDoctor.ValueMember = "Dr#";

            }
            private void LodeDataTocmbInsurance()
            {
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = new SqlCommand();
                da.SelectCommand.Connection = sc;
                da.SelectCommand.CommandText = "selec * From Insurance";
                DataSet ds = new DataSet();
                ds.Tables.Add("Insurance");
                ds.Tables["Insurance"].Columns.Add("Insurance");
                da.Fill(ds.Tables["Insurance"]);
                cmbInsurance.DataSource = ds.Tables["Insurance"];
                cmbInsurance.DisplayMember = "Insurance";
                cmbInsurance.ValueMember = "Insurance";

            }
            private char numberFormat(char ch)
            {
                if ((ch < '0' || ch > '9') && ch != (char)8)
                    return '\0';
                return ch;
            }
            public char ParsianNameFormate(char ch)
            {
                if ((ch < 'ا' || ch > 'ی') && ch != (char)8 && ch != (char)32 && ch != 'آ')
                    return '\0';
                return ch;
            }
            private void DataView(string query)
            {
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = new SqlCommand();
                da.SelectCommand.Connection = sc;
                if (query.Length == 0)
                    da.SelectCommand.CommandText = "select * From Sick";
                else
                    da.SelectCommand.CommandText = "select * From Sick" + query;
                DataSet ds = new DataSet();
                ds.Tables.Add("Sick");
                ds.Tables["Sick"].Columns.Add("S#");
                ds.Tables["Sick"].Columns.Add("S_Lname");
                ds.Tables["Sick"].Columns.Add("S_Fname");
                ds.Tables["Sick"].Columns.Add("Insurance");
                ds.Tables["Sick"].Columns.Add("Dr#");
                ds.Tables["Sick"].Columns.Add("Ca_name");
                ds.Tables["Sick"].Columns.Add("Bed#");
                ds.Tables["Sick"].Columns.Add("Address");
                ds.Tables["Sick"].Columns.Add("Phone");
                ds.Tables["Sick"].Columns.Add("Preamble");

                da.Fill(ds.Tables["Sick"]);
                dgvSick.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
                dgvSick.Columns.Add("S#", "کد ملی");
                dgvSick.Columns["S#"].DataPropertyName = "S#";

                dgvSick.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
                dgvSick.Columns.Add("S_Lname", "نام خانوادگی");
                dgvSick.Columns["S_Lname"].DataPropertyName = "S_Lname";

                dgvSick.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
                dgvSick.Columns.Add("S_Fname", "نام");
                dgvSick.Columns["S_Fname"].DataPropertyName = "S_Fname";


                dgvSick.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
                dgvSick.Columns.Add("Insurance", "بیمه");
                dgvSick.Columns["Insurance"].DataPropertyName = "Insurance";


                dgvSick.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
                dgvSick.Columns.Add("Dr#", "نام پزشک");
                dgvSick.Columns["Dr#"].DataPropertyName = "Dr#";

                dgvSick.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
                dgvSick.Columns.Add("Ca_name", "نام همراه");
                dgvSick.Columns["Ca_name"].DataPropertyName = "Ca_name";

                dgvSick.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
                dgvSick.Columns.Add("Bed#", "شماره ی تخت");
                dgvSick.Columns["Bed#"].DataPropertyName = "Bed#";

                dgvSick.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
                dgvSick.Columns.Add("Address", "آدرس");
                dgvSick.Columns["Address"].DataPropertyName = "Address";

                dgvSick.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
                dgvSick.Columns.Add("Phone", "شماره تلفن");
                dgvSick.Columns["Phone"].DataPropertyName = "Phone";

                dgvSick.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
                dgvSick.Columns.Add("Preamble", "توضیحات");
                dgvSick.Columns["Preamble"].DataPropertyName = "Preamble";

                dgvSick.DataSource = ds;
                dgvSick.DataMember = "Sick";
            }
            private bool CheckData()
            {
                if ((txtCod.TextLength <= 0) || (txtCod.TextLength>10))
                {
                    MessageBox.Show("فیلد کد ملی خالی یا اشتباه وارد شده است لطفا کد ملی بیمار را بررسی و وارد کنید");
                    txtCod.Focus();
                    return false;
                }
                if (txtLname.TextLength == 0)
                {
                    MessageBox.Show("فیلد نام خالی است لطفا کد ملی بیمار را وارد کنید");
                    txtLname.Focus();
                    return false;
                }
                if (txtFname.TextLength == 0)
                {
                    MessageBox.Show("فیلد نام خانوادگی خالی است لطفا کد ملی بیمار را وارد کنید");
                    txtFname.Focus();
                    return false;
                }
                if (cmbDoctor.SelectedIndex > -1)
                {
                    MessageBox.Show("فیلد کد نام پزشک است لطفا کد ملی بیمار را وارد کنید");
                    txtCod.Focus();
                    return false;
                }
                return true;
            }
            private void ClearControl()
            {
                txtCod.Text = txtFname.Text = txtLname.Text = string.Empty;
            }
        #endregion

        #region Events
            private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
            {

            }

            private void txtCod_TextChanged(object sender, EventArgs e)
            {

            }

            private void txtCod_Enter(object sender, EventArgs e)
            {
                ((TextBox)sender).BackColor = Color.LemonChiffon;
            }

            private void txtCod_Leave(object sender, EventArgs e)
            {
                ((TextBox)sender).BackColor = Color.White;
            }

            private void txtCod_KeyPress(object sender, KeyPressEventArgs e)
            {
                e.KeyChar = numberFormat(e.KeyChar);
            }

            private void txtFname_KeyPress(object sender, KeyPressEventArgs e)
            {
                e.KeyChar = ParsianNameFormate(e.KeyChar);
            }

            private void FrmMain_Load(object sender, EventArgs e)
            {
                DataView(q);
                mydbOpration = dbOpration.Insert;
                LodeDataTocmbDoctor();
                LodeDataTocmbInsurance();
            }
            private void button3_Click(object sender, EventArgs e)
                    {
                        try
                            {
                                if (CheckData())
                                {
                                    SqlCommand cmd = new SqlCommand("Proce_Insert_Sick", sc);
                                    cmd.CommandType = CommandType.StoredProcedure;
                                    cmd.Parameters.AddWithValue("@S#", txtCod.Text);
                                    cmd.Parameters.AddWithValue("@S_Fname", txtFname.Text);
                                    cmd.Parameters.AddWithValue("@S_Lname", txtLname.Text);
                                    cmd.Parameters.AddWithValue("@Dr#", cmbDoctor.Text);
                                    cmd.Parameters.AddWithValue("@Insurance", cmbInsurance.Text);

                                    sc.Open();
                                    cmd.ExecuteNonQuery();
                                    sc.Close();

                                    MessageBox.Show("پیغام", "عملیات با موفقیت انحام شد");
                                    ClearControl();
                                }
                       

                            }
                        catch
                        {
                            MessageBox.Show("اطلاعات وارد شده دارای خطا میباشد لطفا بعد از بررسی دوباره نسبت به درج اقدانم کنید");
                        }
                        
                       
                    }



        #endregion
                   
            
           

    }
}
