namespace OutlookDemo.UserControls
{
    partial class UC_SETTING
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Elips_set = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.btn_save = new Guna.UI2.WinForms.Guna2Button();
            this.btndel = new Guna.UI2.WinForms.Guna2Button();
            this.btn_show = new Guna.UI2.WinForms.Guna2Button();
            this.textname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_new = new Guna.UI2.WinForms.Guna2Button();
            this.guna2GroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Elips_set
            // 
            this.Elips_set.TargetControl = this;
            // 
            // guna2GroupBox1
            // 
            this.guna2GroupBox1.BorderColor = System.Drawing.Color.DodgerBlue;
            this.guna2GroupBox1.BorderRadius = 15;
            this.guna2GroupBox1.Controls.Add(this.btn_save);
            this.guna2GroupBox1.Controls.Add(this.btndel);
            this.guna2GroupBox1.Controls.Add(this.btn_show);
            this.guna2GroupBox1.Controls.Add(this.textname);
            this.guna2GroupBox1.Controls.Add(this.label1);
            this.guna2GroupBox1.Controls.Add(this.btn_new);
            this.guna2GroupBox1.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.guna2GroupBox1.FillColor = System.Drawing.SystemColors.Window;
            this.guna2GroupBox1.Font = new System.Drawing.Font("Times New Roman", 16F);
            this.guna2GroupBox1.ForeColor = System.Drawing.Color.White;
            this.guna2GroupBox1.Location = new System.Drawing.Point(184, 158);
            this.guna2GroupBox1.Name = "guna2GroupBox1";
            this.guna2GroupBox1.ShadowDecoration.Parent = this.guna2GroupBox1;
            this.guna2GroupBox1.Size = new System.Drawing.Size(598, 410);
            this.guna2GroupBox1.TabIndex = 47;
            this.guna2GroupBox1.Text = "تهيئة الإتصال بقاعدة البيانات";
            this.guna2GroupBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_save
            // 
            this.btn_save.BorderColor = System.Drawing.Color.Lavender;
            this.btn_save.BorderRadius = 15;
            this.btn_save.BorderThickness = 3;
            this.btn_save.CheckedState.Parent = this.btn_save;
            this.btn_save.CustomImages.Parent = this.btn_save;
            this.btn_save.Enabled = false;
            this.btn_save.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.btn_save.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.ForeColor = System.Drawing.Color.White;
            this.btn_save.HoverState.FillColor = System.Drawing.Color.Green;
            this.btn_save.HoverState.Parent = this.btn_save;
            this.btn_save.Location = new System.Drawing.Point(284, 349);
            this.btn_save.Name = "btn_save";
            this.btn_save.ShadowDecoration.Parent = this.btn_save;
            this.btn_save.Size = new System.Drawing.Size(103, 41);
            this.btn_save.TabIndex = 57;
            this.btn_save.Text = "حفظ";
            this.btn_save.TextOffset = new System.Drawing.Point(0, 3);
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btndel
            // 
            this.btndel.BorderColor = System.Drawing.Color.Lavender;
            this.btndel.BorderRadius = 15;
            this.btndel.BorderThickness = 3;
            this.btndel.CheckedState.Parent = this.btndel;
            this.btndel.CustomImages.Parent = this.btndel;
            this.btndel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.btndel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndel.ForeColor = System.Drawing.Color.White;
            this.btndel.HoverState.FillColor = System.Drawing.Color.Red;
            this.btndel.HoverState.Parent = this.btndel;
            this.btndel.Location = new System.Drawing.Point(66, 349);
            this.btndel.Name = "btndel";
            this.btndel.ShadowDecoration.Parent = this.btndel;
            this.btndel.Size = new System.Drawing.Size(103, 41);
            this.btndel.TabIndex = 56;
            this.btndel.Text = "حذف";
            this.btndel.TextOffset = new System.Drawing.Point(0, 3);
            this.btndel.Click += new System.EventHandler(this.btndel_Click);
            // 
            // btn_show
            // 
            this.btn_show.BorderColor = System.Drawing.Color.Lavender;
            this.btn_show.BorderRadius = 15;
            this.btn_show.BorderThickness = 3;
            this.btn_show.CheckedState.Parent = this.btn_show;
            this.btn_show.CustomImages.Parent = this.btn_show;
            this.btn_show.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.btn_show.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_show.ForeColor = System.Drawing.Color.White;
            this.btn_show.HoverState.Parent = this.btn_show;
            this.btn_show.Location = new System.Drawing.Point(175, 349);
            this.btn_show.Name = "btn_show";
            this.btn_show.ShadowDecoration.Parent = this.btn_show;
            this.btn_show.Size = new System.Drawing.Size(103, 41);
            this.btn_show.TabIndex = 54;
            this.btn_show.Text = "عرض";
            this.btn_show.TextOffset = new System.Drawing.Point(0, 3);
            this.btn_show.Click += new System.EventHandler(this.btn_show_Click);
            // 
            // textname
            // 
            this.textname.Enabled = false;
            this.textname.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textname.Location = new System.Drawing.Point(66, 169);
            this.textname.Name = "textname";
            this.textname.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textname.Size = new System.Drawing.Size(388, 39);
            this.textname.TabIndex = 53;
            this.textname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(460, 171);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(122, 38);
            this.label1.TabIndex = 52;
            this.label1.Text = "اسم السيرفر";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_new
            // 
            this.btn_new.BorderColor = System.Drawing.Color.Lavender;
            this.btn_new.BorderRadius = 15;
            this.btn_new.BorderThickness = 3;
            this.btn_new.CheckedState.Parent = this.btn_new;
            this.btn_new.CustomImages.Parent = this.btn_new;
            this.btn_new.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.btn_new.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_new.ForeColor = System.Drawing.Color.White;
            this.btn_new.HoverState.Parent = this.btn_new;
            this.btn_new.Location = new System.Drawing.Point(393, 349);
            this.btn_new.Name = "btn_new";
            this.btn_new.ShadowDecoration.Parent = this.btn_new;
            this.btn_new.Size = new System.Drawing.Size(103, 41);
            this.btn_new.TabIndex = 44;
            this.btn_new.Text = "جديد";
            this.btn_new.TextOffset = new System.Drawing.Point(0, 3);
            this.btn_new.Click += new System.EventHandler(this.btn_new_Click);
            // 
            // UC_SETTING
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.guna2GroupBox1);
            this.Name = "UC_SETTING";
            this.Size = new System.Drawing.Size(1006, 681);
            this.guna2GroupBox1.ResumeLayout(false);
            this.guna2GroupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse Elips_set;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
        private Guna.UI2.WinForms.Guna2Button btn_new;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox textname;
        private Guna.UI2.WinForms.Guna2Button btn_show;
        private Guna.UI2.WinForms.Guna2Button btndel;
        private Guna.UI2.WinForms.Guna2Button btn_save;
    }
}
