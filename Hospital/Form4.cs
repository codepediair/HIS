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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        SqlConnection sc = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Hospital;Data Source=.");
        private void Form4_Load(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("select * From Insurance", sc);
            comboBox1.Items.Add(cmd.Parameters);
        }
    }
}
