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
    public partial class Applications : Form
    {
        
        public Applications()
        {
            InitializeComponent();
        }

        private void Applications_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=admin;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            string query = "select *from [admin].[dbo].[jobs]";
            SqlDataAdapter dts = new SqlDataAdapter(query,conn);
            DataTable tbs = new DataTable();
            dts.Fill(tbs);
            dataGridView1.DataSource = tbs;

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
             
        }

        private void button2_Click(object sender, EventArgs e)
        {
            homeA obj = new homeA();
            this.Hide();
            obj.Show();
        }
    }
}
