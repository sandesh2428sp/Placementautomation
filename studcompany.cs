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
    public partial class studcompany : Form
    {
        string connection = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=admin;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        public studcompany()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            student obj = new student();
            this.Hide();
            obj.Show();
        }

        private void studcompany_Load(object sender, EventArgs e)
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

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            stuApply obj = new stuApply();
            obj.textBox9.Text = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
            obj.textBox10.Text = this.dataGridView1.CurrentRow.Cells[2].Value.ToString();
            obj.textBox11.Text = this.dataGridView1.CurrentRow.Cells[3].Value.ToString();
            this.Hide();
            obj.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
