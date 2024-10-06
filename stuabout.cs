using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Placementautomation
{
    public partial class stuabout : Form
    {
        public stuabout()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            student obj = new student();
            this.Hide();
            obj.Show();
        }
    }
}
