using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OutlookDemo.UserControls
{
    public partial class UC_home : UserControl
    {
        public UC_home()
        {
            InitializeComponent();
        }

        private void UC_home_Load(object sender, EventArgs e)
        {

        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.WindowState = FormWindowState.Minimized;
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Close();
        }
    }
}
