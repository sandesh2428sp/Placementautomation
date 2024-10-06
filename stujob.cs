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
    public partial class stujob : Form
    {
        string connection = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=admin;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        public stujob()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            student obj = new student();
            this.Hide();
            obj.Show();
        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void stujob_Load(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connection))
            {
                conn.Open();
                SqlDataAdapter sqlda = new SqlDataAdapter("select *from [admin].[dbo].[jobs] Where email='"+studlogin.email+"'", conn);
                DataTable dtb1 = new DataTable();
                sqlda.Fill(dtb1);
                if(dtb1.Rows.Count==0)
                {
                    label1.Text = "your not applied to any company";
                }
                else
                {
                    label1.Text = "companies you have applied";
                    dataGridView1.DataSource = dtb1;
                }
               
            }
        }
    }
}
