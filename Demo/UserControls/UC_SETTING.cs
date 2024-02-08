using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace OutlookDemo.UserControls
{
    public partial class UC_SETTING : UserControl
    {
        public UC_SETTING()
        {
            InitializeComponent();
        }

        //private void btn_edit_Click(object sender, EventArgs e)
        //{
        //    text_user.ReadOnly = false;
        //    textpass.ReadOnly = false;
        //}

        //private void btn_save_Click(object sender, EventArgs e)
        //{
        //    text_user.ReadOnly = true;
        //    textpass.ReadOnly = true;

        //    //labn.Text = text_user.Text;
        //    //labp.Text = textpass.Text;
        //}

        private void text_user_TextChanged(object sender, EventArgs e)
        {
           

        }

        private void labn_Click(object sender, EventArgs e)
        {

        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            textname.Enabled = true;
            textname.Text = "";
            textname.Focus();
            btn_save.Enabled = true;
        }
        
        private void btn_show_Click(object sender, EventArgs e)
        {
            textname.Text = Properties.Settings.Default.server ;
        }
        
        private void btn_save_Click(object sender, EventArgs e)
        {

            string input_na = textname.Text;
            int minNa = 10;
            if (input_na.Length < minNa)
            {
                MessageBox.Show("!!الرجاء إدخال اسم سيرفر صحيح");
            }
            else
            {
                Properties.Settings.Default.server = textname.Text;
                Properties.Settings.Default.Save();
                MessageBox.Show(" تم تغيير السيرفر بنجاح ");
                textname.Clear();
                btn_save.Enabled = false;
              
                //Environment.Exit(0);
                //Process.Start(Environment.GetCommandLineArgs()[0]);
                Application.Restart();

            }
           
        }
       
        private void btndel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل تريد حذف العنصر المحدد", "عملية الحذف", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Properties.Settings.Default.server = "";
                textname.Text = Properties.Settings.Default.server;
                MessageBox.Show("تم حذف العنصر المحدد بنجاح", "عملية الحذف", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("تم الغاء عملية الحذف", "عملية الحذف", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
           
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Close();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.WindowState = FormWindowState.Minimized;
        }
    }
}
