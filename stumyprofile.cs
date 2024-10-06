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
    public partial class stumyprofile : Form
    {
        public stumyprofile()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            student obj = new student();
            this.Hide();
            obj.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void stumyprofile_Load(object sender, EventArgs e)
        {
            textBox1.Text = studlogin.name;
            textBox2.Text = studlogin.email;
            textBox3.Text = studlogin.regno;
            textBox6.Text = studlogin.section;
        }

        private void button2_Click(object sender, EventArgs e)
        {
           

        }
    }
}
