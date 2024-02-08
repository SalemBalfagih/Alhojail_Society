using Guna.UI2.WinForms;
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

namespace OutlookDemo
{
    public partial class Form1 : Form
    {
        
        
        public Form1()
        {
            InitializeComponent();

            uC_EMP1.Visible = false;
            uC_home1.Visible = true;
            uC_BACK1.Visible = false;
            uC_SETTING1.Visible = false;
            uC_INFO1.Visible = false;


            try {
                    Class_conn.cn.Open();
               

            } catch (SqlException ex)
                {
                uC_EMP1.Visible = false;
                uC_home1.Visible = false;
                uC_BACK1.Visible = false;
                uC_SETTING1.Visible = true;
                uC_INFO1.Visible = false;

              
                uC_SETTING1.BringToFront();

                btn_emp.Enabled = false;
                btn_back.Enabled = false;
                btn_home.Enabled = false;
                btn_info.Enabled = false;
               
            }
            Class_conn.cn.Close();

            // uC_EMP1.dataGridView1.Columns[].HeaderCell.Style.ForeColor = Color.DarkSlateBlue;
            //uC_EMP1.dataGridView1.EnableHeadersVisualStyles = false;




        }
       

        private void moveImageBox(object sender)
        {
           
        }
        private void guna2Button1_CheckedChanged(object sender, EventArgs e)
        {
            moveImageBox(sender);
        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void imgSlide_Click(object sender, EventArgs e)
        {
 
        }
        private void btn_emp_Click(object sender, EventArgs e)
        {
           
               
          
           
            uC_EMP1.Visible = true;
            uC_EMP1.BringToFront();
        }

        private void btn_home_Click(object sender, EventArgs e)
        {
            uC_home1.Visible = true;
            uC_home1.BringToFront();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            uC_BACK1.Visible = true;
            uC_BACK1.BringToFront();
        }

        private void btn_set_Click(object sender, EventArgs e)
        {
            uC_SETTING1.Visible = true;
            uC_SETTING1.BringToFront();
        }

        private void btn_info_Click(object sender, EventArgs e)
        {
            uC_INFO1.Visible = true;
            uC_INFO1.BringToFront();
        }

        private void uC_SETTING1_Load(object sender, EventArgs e)
        {

        }

        private void uC_BACK1_Load(object sender, EventArgs e)
        {
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void uC_EMP1_Load(object sender, EventArgs e)
        {
            
        }

        private void uC_SETTING1_Load_1(object sender, EventArgs e)
        {

        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
           
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2Button1_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
