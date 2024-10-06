using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Placementautomation
{
    public partial class company : Form
    {
        string connection = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=admin;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        public company()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            homeA obj = new homeA();
            this.Hide();
            obj.Show();
        }

        private void company_Load(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connection)) 
            {
                conn.Open();
                SqlDataAdapter sqlda = new SqlDataAdapter("select *from [admin].[dbo].[company]", conn);
                DataTable dtb1 = new DataTable();
                sqlda.Fill(dtb1);
                dataGridView1.DataSource = dtb1;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
