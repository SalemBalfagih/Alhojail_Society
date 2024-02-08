using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Zen.Barcode;
using System.Text.RegularExpressions;



namespace OutlookDemo.UserControls
{
    public partial class UC_EMP : UserControl
    {
        
        int add = 0;
        Boolean ADD =true;
        Class_emp cls = new Class_emp();
        public UC_EMP()
        {

          
            InitializeComponent();
            int num = cls.MaxID() + 1;
            textnum.Text = num.ToString();

            dataGridView1.EnableHeadersVisualStyles = false;

            Zen.Barcode.CodeQrBarcodeDraw bar = Zen.Barcode.BarcodeDrawFactory.CodeQr;
            guna2PictureBox1.Image = bar.Draw("0", 50);

          

           
        }



        public void cleartext()
        {
            textid.Text = "0";       
            textname.Clear();
            textBname.Clear();
            textteam.Clear();
            text_age.Clear();
            text_cust.Clear();
            guna2PictureBox3.Image = Properties.Resources.icons8_male_user_50px;


        }
        public void loadf()
        {

            
            cls.dtitem.Clear();
            cls.loaditem();
            dataGridView1.DataSource = cls.dtitem;
        }
        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }

        private void UC_EMP_Load(object sender, EventArgs e)
        {

            cls.loaditem();

            dataGridView1.DataSource = cls.dtitem;
            dataGridView1.Columns[0].HeaderText = "الرقم";
            dataGridView1.Columns[1].HeaderText = "اسم العامل";
            dataGridView1.Columns[2].HeaderText = "المستلم البديل";
            dataGridView1.Columns[3].HeaderText = "اسم الفرقة";
            dataGridView1.Columns[4].HeaderText = "رقم العامل";
            dataGridView1.Columns[5].HeaderText = "العمر";
            dataGridView1.Columns[6].HeaderText = "رقم الشخصي";
            dataGridView1.Columns[7].HeaderText = "الباركود";
            dataGridView1.Columns[8].HeaderText = "الصورة";


            dataGridView1.Columns[0].Width = 40;
            dataGridView1.Columns[1].Width = 180;
            dataGridView1.Columns[2].Width = 180;
            dataGridView1.Columns[3].Width = 80;
            dataGridView1.Columns[4].Width = 80;
            dataGridView1.Columns[5].Width = 50;
            dataGridView1.Columns[6].Width = 100;
            dataGridView1.Columns[7].Width = 60;
            dataGridView1.Columns[8].Width = 60;


            dataGridView1.Columns[0].HeaderCell.Style.Font = new Font("Times New Roman", 15, FontStyle.Bold);
            dataGridView1.Columns[1].HeaderCell.Style.Font = new Font("Times New Roman", 15, FontStyle.Bold);
            dataGridView1.Columns[2].HeaderCell.Style.Font = new Font("Times New Roman", 15, FontStyle.Bold);
            dataGridView1.Columns[3].HeaderCell.Style.Font = new Font("Times New Roman", 15, FontStyle.Bold);
            dataGridView1.Columns[4].HeaderCell.Style.Font = new Font("Times New Roman", 15, FontStyle.Bold);
            dataGridView1.Columns[5].HeaderCell.Style.Font = new Font("Times New Roman", 15, FontStyle.Bold);
            dataGridView1.Columns[6].HeaderCell.Style.Font = new Font("Times New Roman", 15, FontStyle.Bold);
            dataGridView1.Columns[7].HeaderCell.Style.Font = new Font("Times New Roman", 15, FontStyle.Bold);
            dataGridView1.Columns[8].HeaderCell.Style.Font = new Font("Times New Roman", 15, FontStyle.Bold);


        }
       
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }
        private void guna2Button2_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Image |*.jpeg;*.jpg;*.png";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                guna2PictureBox3.Image = Image.FromFile(openFileDialog1.FileName);
            }
        }
        private void guna2Button4_Click(object sender, EventArgs e)
        {
            string input_na = textname.Text;
            int minNa = 10;
            //string input_Bn = textBname.Text;
            //int minBn = 10;

            if (ADD == true)
            {
                try
                {
                    if (input_na.Length < minNa)
                    {
                        MessageBox.Show("!!الرجاء إدخال اسم العامل كاملاً");
                    }
                    //else if()
                    //{
                        
                    //} 
                  
                    //else if (input_Bn.Length < minBn)
                    //{
                    //    MessageBox.Show("!!الرجاء إدخال اسم المستلم البديل كاملاً");
                    //}
                    else
                    {
                        MemoryStream ms = new MemoryStream();
                        guna2PictureBox3.Image.Save(ms, guna2PictureBox3.Image.RawFormat);
                        byte[] img = ms.ToArray();

                        Zen.Barcode.CodeQrBarcodeDraw b = Zen.Barcode.BarcodeDrawFactory.CodeQr;
                        Image m = b.Draw(textid.Text, 50);

                        //BarcodeDraw b = BarcodeDrawFactory.Code128WithChecksum;
                        string t = textid.Text;
                        //Image m = b.Draw(t, 50);

                        byte[] Bby;
                        using (MemoryStream ms1 = new MemoryStream())
                        {
                            m.Save(ms1, System.Drawing.Imaging.ImageFormat.Png);
                            Bby = ms1.ToArray();
                        }
                        Class_emp cls = new Class_emp();
                        cls.insertpro_image(Convert.ToInt32(textnum.Text), (textname.Text),
                           (textBname.Text), (textteam.Text), (text_cust.Text), (text_age.Text),
                            Convert.ToInt32(textid.Text), Bby, img);
                        MessageBox.Show("         تمت الإضافة بنجاح           ", "اضافة عامل ");
                        loadf();
                        disable();
                        cleartext();
                        btnsave.Enabled = false;
                    }
                }
                catch (Exception ex)
                {
                    Class_conn.cn.Close();
                    MessageBox.Show(" الرجاء إدخال قيم صحيحه لا تترك الحقول فارغة او تاكد من عدم ادخال بيانات مكررة " + ex.Message, " ", MessageBoxButtons.OK, MessageBoxIcon.Asterisk); 
                }
            }
            else
            {
                try
                {
                    if (input_na.Length < minNa)
                    {
                        MessageBox.Show(" !!الرجاء إدخال اسم العامل كاملاً ");
                    }
                   //else if (input_Bn.Length < minBn)
                   // {
                   //     MessageBox.Show(" !!الرجاء إدخال اسم المستلم البديل كاملاً ");
                   // }
                    else
                    {
                        MemoryStream ms = new MemoryStream();
                        guna2PictureBox3.Image.Save(ms, guna2PictureBox3.Image.RawFormat);
                        byte[] img = ms.ToArray();

                        Class_emp cls = new Class_emp();
                        cls.updateprodactImage((textname.Text),
                             (textBname.Text), (textteam.Text), (text_cust.Text), (text_age.Text),
                             Convert.ToInt32(textid.Text), img);
                        MessageBox.Show("         تم التعديل بنجاح           ", "تعديل  عامل ");
                        disable();
                        loadf();

                        cleartext();
                        btnsave.Enabled = false;

                    }
                }
                catch
                {
                    MessageBox.Show(" !!الرجاء إدخال قيم صحيحه لا تترك الحقول فارغةاو تاكد من عدم إدخال بيانات مكررة ", " ", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                }

            }
        }

    private void guna2Button7_Click(object sender, EventArgs e)
        {
            


        }

        private void textid_TextChanged(object sender, EventArgs e)
        {

            Zen.Barcode.CodeQrBarcodeDraw bar = Zen.Barcode.BarcodeDrawFactory.CodeQr;
            guna2PictureBox1.Image = bar.Draw(textid.Text, 50);


        }
        public void enable()
        {
            textBname.ReadOnly = false;
            textname.ReadOnly = false;
            textteam.ReadOnly = false;
            textid.ReadOnly = false;
            text_age.ReadOnly = false;
            text_cust.ReadOnly = false;

        }
        public void disable()
        {
            textBname.ReadOnly = true;
            textname.ReadOnly = true;
            textteam.ReadOnly = true;
            textid.ReadOnly = true;
            text_age.ReadOnly = true;
            text_cust.ReadOnly = true;

        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            a = 0;
            enable();
            cleartext();
            Class_emp cls = new Class_emp();
            int max = cls.MaxID() + 1;
            textnum.Text = max.ToString();
            ADD = true;
            btnsave.Enabled = true;
            text_cust.Focus();

        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            Class_emp item = new Class_emp();
            int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[6].Value);
            if (MessageBox.Show("هل تريد حذف العنصر المحدد", "عملية الحذف", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                item.deleteitem(id);
                MessageBox.Show("تم حذف العنصر المحدد بنجاح", "عملية الحذف", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("تم الغاء عملية الحذف", "عملية الحذف", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            item.loaditem();
            dataGridView1.DataSource = item.dtitem;
        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            enable();
            a = 1;
            ADD = false;
            btnsave.Enabled = true;
          
                try
                {


                    textnum.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                    textname.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                    textBname.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                    textteam.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                    text_cust.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                    text_age.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                    textid.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
                    textid.ReadOnly = true;

                    byte[] img = (byte[])cls.getimgpro(dataGridView1.CurrentRow.Cells[6].Value
                        .ToString()).Rows[0][0];
                    MemoryStream ms = new MemoryStream(img);
                    guna2PictureBox3.Image = Image.FromStream(ms);

                }
                catch
                {
                return;
                }
            
        }  

        private void textid_Validating(object sender, CancelEventArgs e)
        {
            if(!Regex.IsMatch(textid.Text,@"^\d+$"))
            {
                MessageBox.Show("يرجى إدخال ارقام فقط في المعرف");
                                
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void text_age_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textname_TextChanged(object sender, EventArgs e)
        {
            if(a==0)
            {
                textBname.Text = textname.Text;
            }
        }
        
        private void textname_Validating(object sender, CancelEventArgs e)
        {
            //string input = textname.Text;
            //int minl = 10;

            //if( input.Length < minl )
            //{
            //    MessageBox.Show("!!الرجاء ادخال اسم العامل");
            //}
        }

        private void text_age_Validating(object sender, CancelEventArgs e)
        {
          
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Button4_Click_1(object sender, EventArgs e)
        {
            panel1.BringToFront();
            
            byte[] img = (byte[])cls.getimgpro(dataGridView1.CurrentRow.Cells[6].Value
                       .ToString()).Rows[0][0];
            MemoryStream ms = new MemoryStream(img);
            image.Image = Image.FromStream(ms);
            labid.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            labname.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            labbname.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            labage.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            labteam.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            labcust.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();

            Zen.Barcode.CodeQrBarcodeDraw bar = Zen.Barcode.BarcodeDrawFactory.CodeQr;
            imgcode.Image = bar.Draw(labid.Text, 50);
            btndel.Visible = false;
            btnsave.Visible = false;
        }

        private void textBname_Validating(object sender, CancelEventArgs e)
        {
            //string input = textBname.Text;
            //int minl = 10;

            //if (input.Length < minl)
            //{
            //    MessageBox.Show("!!الرجاء ادخال اسم المستلم البديل كاملا");
            //}
        }

        private void guna2Button7_Click_1(object sender, EventArgs e)
        {
            panel1.SendToBack();
            btndel.Visible = true;
            btnsave.Visible = true;
        }

        private void guna2Button5_MouseHover(object sender, EventArgs e)
        {
          //  btndel.FillColor = Color.Red;
        }

        private void btndel_MouseLeave(object sender, EventArgs e)
        {
           // btndel.FillColor = Color.FromArgb(0, 118, 212);
        }
        int a = 0;

        private void btnsave_MouseHover(object sender, EventArgs e)
        {

           for(int i =0; i< dataGridView1.Rows.Count; i++)
            {
                if(a==0 && text_cust.Text== dataGridView1.Rows[i].Cells[4].Value.ToString()
                    && textteam.Text == dataGridView1.Rows[i].Cells[3].Value.ToString())
                {
                    MessageBox.Show(" !!رقم العامل مكرر في هذه الفرقة ");
                    text_cust.Clear();
                    break;
                }
                    
           }
        }

        private void btnsave_MouseLeave(object sender, EventArgs e)
        {
           // btnsave.FillColor = Color.FromArgb(0, 118, 212);
        }

        private void text_age_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar)&& !char.IsDigit(e.KeyChar) )
            {
                e.Handled = true;
                MessageBox.Show(" !!الرجاء إدخال العمر بشكل صحيح ");
            }
        }

        private void textname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) 
                && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show(" !!الرجاء إدخال اسم العامل بشكل صحيح ");
            }
        }
        private void textBname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show(" !!الرجاء إدخال اسم المستلم البديل بشكل صحيح ");
            }
        }

        private void textBname_TextChanged(object sender, EventArgs e)
        {

        }

        private void text_cust_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textteam.Focus();
            }
        }

        private void textname_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textBname.Focus();
            }
        }

        private void textteam_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textname.Focus();
            }
        }

        private void textBname_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textid.Focus();
            }
        }

        private void textid_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnsave.Focus();
            }
        }

        private void text_cust_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                text_cust.Focus();
            }
        }

        
        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {
            Class_emp em = new Class_emp();
            em.searchpro(guna2TextBox1.Text);
            dataGridView1.DataSource = em.dtitem;
        }
        int id = 0;
        private void guna2Button1_Click_1(object sender, EventArgs e)
        {
            if (guna2ComboBox1.Text=="الكل")
            { CryRep cr = new CryRep();
            Class_emp cls = new Class_emp();
            print frm = new print();
            cls.oneprint();
            cr.SetDataSource(cls.dtitem);
            frm.crystalReportViewer1.ReportSource = cr;
            frm.Show();
            }  
            else
            {
                id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[6].Value);
                CryRep cr = new CryRep();
                Class_emp cls = new Class_emp();
                print frm = new print();
                cls.oneprint1(id);
                cr.SetDataSource(cls.dtitem);
                frm.crystalReportViewer1.ReportSource = cr;
                frm.Show();
            }
           
        }

        private void txtB_sear_TextChanged(object sender, EventArgs e)
        {
            Class_emp sl = new Class_emp();
            sl.searchpro(txtB_sear.Text);
            dataGridView1.DataSource = sl.dtitem;
            
        }

        private void guna2Button5_Click_1(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.WindowState = FormWindowState.Minimized;
        }

        private void guna2Button8_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Close();
        }
    }
}
