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
    public partial class adminreg : Form
    {
        public adminreg()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {


            SqlConnection conn = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=admin;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            string query = "INSERT INTO [admin].[dbo].[student](name,email,regno,section)VALUES('" + textBox1.Text.Trim() + "','" + textBox2.Text.Trim() + "','"+textBox3.Text.Trim()+"','"+textBox4.Text.Trim()+"')";
            string query2 = "SELECT *from [admin].[dbo].[student] where email='" + textBox2.Text + "'and name='"+textBox1.Text+"'";
            SqlDataAdapter dts = new SqlDataAdapter(query2, conn);
            DataTable tb = new DataTable();
            dts.Fill(tb);
            if (tb.Rows.Count > 1)
            {
                MessageBox.Show("student already exisits", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("student created successfully ", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                catch (SqlException error)
                {
                    MessageBox.Show("error" + error.ToString());
                }

            }
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            homeA obj = new homeA();
            this.Hide();
            obj.Show();
        }
    }
}
