using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Placementautomation
{
    public partial class Admin : Form
    {
        public static string id, name, email, password, phone, address;
        public Admin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            
            SqlConnection conn = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=admin;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            string query = "select *from [admin].[dbo].[admin] Where email='" + textBox1.Text.Trim() + "'and password='" + textBox2.Text.Trim() + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query,conn);
            DataTable dts = new DataTable();
            sda.Fill(dts);
            if(dts.Rows.Count==1)
                
            {
                
                if (ValidateChildren(ValidationConstraints.Enabled))
                {
                  
                    
                        id = dts.Rows[0]["ID"].ToString();
                        name = dts.Rows[0]["NAME"].ToString();
                        email = dts.Rows[0]["EMAIL"].ToString();
                        password = dts.Rows[0]["PASSWORD"].ToString();
                        phone = dts.Rows[0]["PHONE"].ToString();
                    MessageBox.Show("welcome Admin","", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    homeA obj = new homeA();
                        this.Hide();
                        obj.Show();
                    
                }
              
              

                
              
            }
            else
            {
                MessageBox.Show("Check with the creditanls","",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            main obj = new main();
            this.Hide();
            obj.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_Validating(object sender, CancelEventArgs e)
        {
            if(string.IsNullOrEmpty(textBox1.Text))
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
    }
}
