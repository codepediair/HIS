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
    public partial class test : Form
    {
        public test()
        {
            InitializeComponent();
        }
        string q = string.Empty;
        SqlConnection sc = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Hospital;Data Source=.");
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
            comboBox1.DataSource = ds.Tables["Doctor"];
            comboBox1.DisplayMember = "Dr_name";
            comboBox1.ValueMember = "Dr#";

        }

        private void test_Load(object sender, EventArgs e)
        {
            LodeDataTocmbDoctor();
        }
    }
}
