using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormPrac1
{
    public partial class Form1 : Form
    {

        public SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=DBPrac1;Integrated Security=True");
        SqlCommand cmd;
        SqlDataReader dr;




        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            con.Open();
            MessageBox.Show("Conexion Creada Con Exito!");
            con.Close();





        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();

            string query = "Select * from APODERADO";
            cmd = new SqlCommand(query, con);

            SqlDataAdapter dAdapter = new SqlDataAdapter(cmd);

            DataSet ds = new DataSet();

            dAdapter.Fill(ds);

            dataGridView1.ReadOnly = true;

            dataGridView1.DataSource = ds.Tables[0];

            con.Close();
        }
    }
}
