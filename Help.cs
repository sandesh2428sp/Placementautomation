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
    public partial class Help : Form
    {
        public Help()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            homeA obj = new homeA();
            this.Hide();
            obj.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            SqlConnection conn = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=admin;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            string query = "INSERT INTO [admin].[dbo].[query](name,email,query)VALUES ('"+Admin.name+"','"+Admin.email+"','" + richTextBox1.Text + "')";
            SqlCommand comm = new SqlCommand(query, conn);
            try
            {
                conn.Open();
                comm.ExecuteNonQuery();
                MessageBox.Show("query updated we will get back to you ", "", MessageBoxButtons.OK);
            }
            catch(SqlException error)
            {
                MessageBox.Show(error.ToString());
            }
           
        }
    }
}
