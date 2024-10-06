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
    public partial class studlogin : Form
    {
        public static string id, name, email, regno, classes, section;

        private void textBox1_TextChanged(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                e.Cancel = true;
                textBox1.Focus();


                MessageBox.Show("please fill the above field", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                e.Cancel = false;

                errorProvider1.SetError(textBox1, null);
            }
        }
        private void textBox2_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(textBox2.Text))
            {
                e.Cancel = true;
                textBox2.Focus();
                MessageBox.Show("please fill the above field", "", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }
            else
            {
                e.Cancel = false;

                errorProvider1.SetError(textBox2, null);

            }
        }
        public studlogin()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=admin;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            string query = "select *from [admin].[dbo].[student] where email='" + textBox1.Text.Trim() + "'and regno='" + textBox2.Text.Trim() + "'";
            SqlDataAdapter dsa = new SqlDataAdapter(query, conn);
            DataTable dts = new DataTable();
            dsa.Fill(dts);
            if (dts.Rows.Count == 1)
            {
                MessageBox.Show("welcome student", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (ValidateChildren(ValidationConstraints.Enabled))
                {

                    id = dts.Rows[0]["ID"].ToString();
                    name = dts.Rows[0]["NAME"].ToString();
                    email = dts.Rows[0]["EMAIL"].ToString();
                    regno = dts.Rows[0]["REGNO"].ToString();
                    section = dts.Rows[0]["SECTION"].ToString();
                    student obj = new student();
                    this.Hide();
                    obj.Show();

                }
            }
            else
            {
                MessageBox.Show("invalid creditnals");
            }
            
            
        }
    }
}

