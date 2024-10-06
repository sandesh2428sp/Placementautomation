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
    public partial class statics : Form
    {
        public statics()
        {
            InitializeComponent();
        }

        private void statics_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=admin;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            DataSet ds = new DataSet();
            conn.Open();
            SqlDataAdapter adptr = new SqlDataAdapter("Select name,company from [admin].[dbo].[jobs]",conn);
            adptr.Fill(ds);
              


        }
    }
}
