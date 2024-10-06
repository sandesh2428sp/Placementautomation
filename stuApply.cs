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
    public partial class stuApply : Form
    {
        public stuApply()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void stuApply_Load(object sender, EventArgs e)
        {
            textBox1.Text = studlogin.name;
            textBox2.Text = studlogin.email;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=admin;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            string query = "INSERT INTO [admin].[dbo].[jobs](name,email,phone,address,sslc,puc,ug,institution,company,jd,role)VALUES('" + textBox1.Text.Trim() + "','" + textBox2.Text.Trim() + "','" + textBox3.Text.Trim() + "','" + textBox4.Text.Trim() + "','"+textBox5.Text.Trim()+"','"+textBox6.Text.Trim()+"','"+textBox7.Text.Trim()+"','"+textBox8.Text.Trim()+"','"+textBox9.Text.Trim()+"','"+textBox10.Text.Trim()+"','"+textBox11.Text.Trim()+"')";
            SqlCommand cmd = new SqlCommand(query, conn);
            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("row successfully inserted");

            }
            catch (SqlException error)
            {
                MessageBox.Show("error" + error.ToString());
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            company obj = new company();
            this.Hide();
            obj.Show();
        }
    }
}
