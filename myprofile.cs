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
    public partial class myprofile : Form
    {
        public myprofile()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void myprofile_Load(object sender, EventArgs e)
        {
            button2.Text = Admin.name;
            textBox1.Text = Admin.name;
            textBox2.Text = Admin.email;
            textBox3.Text = Admin.password;
            textBox4.Text = Admin.phone;
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            homeA obj = new homeA();
            this.Hide();
            obj.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=admin;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            string query = " UPDATE [admin].[dbo].[admin] SET name=@name,email=@email,password=@password,phone=@phone";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@name", textBox1.Text);
            cmd.Parameters.AddWithValue("@email", textBox2.Text);
            cmd.Parameters.AddWithValue("@password", textBox3.Text);
            cmd.Parameters.AddWithValue("@phone", textBox4.Text);
           
            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("successfully updated ");

            }
            catch (SqlException error)
            {
                MessageBox.Show("error" + error.ToString());
            }

        }
    }
}
