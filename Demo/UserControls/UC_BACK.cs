using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace OutlookDemo.UserControls
{
    public partial class UC_BACK : UserControl
    {
        public UC_BACK()
        {
            InitializeComponent();
        }

        private async void guna2Button4_Click(object sender, EventArgs e)
        {
            try
            {

                progressPanel1.Visible = true;
                SaveFileDialog sf = new SaveFileDialog();
                sf.Filter = "Backup File (*.Bak) |*.bak";
                var rs = sf.ShowDialog();
                if (rs == DialogResult.OK)
                {


                    SqlCommand cmd;
                    cmd = new SqlCommand("Backup Database EMP To Disk='" + sf.FileName + "'", Class_conn.cn);
                    Class_conn.cn.Open();
                    cmd.ExecuteNonQuery();
                    Class_conn.cn.Close();

                    {
                        MessageBox.Show("تم الحفط بنجاح", "النسخة", MessageBoxButtons.OK);
                        progressPanel1.Visible = false;
                    }
                }
                else
                {
                    progressPanel1.Visible = false;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("حدد مكان اخر لحفط النسخة الاحتياطية لا تحدد القرص C ");
                progressPanel1.Visible = false;
            }
        }

        //public static SqlConnection cn1 = new SqlConnection(@"Data Source=DESKTOP-JVKE8T3\SQLEXPRESS;Initial Catalog=EMP;Integrated Security=True");


        private  void guna2Button1_Click(object sender, EventArgs e)
        {
            try
            {


                progressPanel2.Visible = true;
                SaveFileDialog sf = new SaveFileDialog();
                sf.Filter = "Backup File (*.Bak) |*.bak";
                var rs = sf.ShowDialog();
                if (rs == DialogResult.OK)

                {
                    SqlCommand cmd;
                    cmd = new SqlCommand("alter database EMP set offline with rollback immediate; Restore Database EMP From Disk='" + sf.FileName + "'", Class_conn.cn);
                Class_conn.cn.Open();
                    cmd.ExecuteNonQuery();
                Class_conn.cn.Close();
                    {
                        MessageBox.Show("تم الاستعادة بنجاح", "النسخة", MessageBoxButtons.OK);
                        progressPanel2.Visible = false;
                    }
                }
                else
                {
                    progressPanel2.Visible = false;
                }

            }
            catch
            {
                MessageBox.Show("خطاء في استعادة النسخة الاحتياطية   ");
                progressPanel2.Visible = false;
            }
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.WindowState = FormWindowState.Minimized;
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Close();
        }
    }
}
