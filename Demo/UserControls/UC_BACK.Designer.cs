namespace OutlookDemo.UserControls
{
    partial class UC_BACK
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
            this.Elips_back = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.progressPanel1 = new DevExpress.XtraWaitForm.ProgressPanel();
            this.guna2Button4 = new Guna.UI2.WinForms.Guna2Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.guna2GroupBox2 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.progressPanel2 = new DevExpress.XtraWaitForm.ProgressPanel();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.guna2GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.guna2GroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // Elips_back
            // 
            this.Elips_back.TargetControl = this;
            // 
            // guna2GroupBox1
            // 
            this.guna2GroupBox1.BorderColor = System.Drawing.Color.DarkGreen;
            this.guna2GroupBox1.BorderRadius = 30;
            this.guna2GroupBox1.BorderThickness = 10;
            this.guna2GroupBox1.Controls.Add(this.progressPanel1);
            this.guna2GroupBox1.Controls.Add(this.guna2Button4);
            this.guna2GroupBox1.Controls.Add(this.pictureBox1);
            this.guna2GroupBox1.CustomBorderColor = System.Drawing.Color.DarkGreen;
            this.guna2GroupBox1.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold);
            this.guna2GroupBox1.ForeColor = System.Drawing.Color.White;
            this.guna2GroupBox1.Location = new System.Drawing.Point(551, 163);
            this.guna2GroupBox1.Name = "guna2GroupBox1";
            this.guna2GroupBox1.ShadowDecoration.Parent = this.guna2GroupBox1;
            this.guna2GroupBox1.Size = new System.Drawing.Size(300, 367);
            this.guna2GroupBox1.TabIndex = 0;
            this.guna2GroupBox1.Text = "إنشاء نسخة إحتياطية";
            this.guna2GroupBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // progressPanel1
            // 
            this.progressPanel1.Appearance.BackColor = System.Drawing.Color.DarkGreen;
            this.progressPanel1.Appearance.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.progressPanel1.Appearance.Options.UseBackColor = true;
            this.progressPanel1.Appearance.Options.UseFont = true;
            this.progressPanel1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.progressPanel1.Caption = "الرجاء الانتظار";
            this.progressPanel1.Description = "الرجاء الانتظار حتى يتم حفظ النسخة....";
            this.progressPanel1.Location = new System.Drawing.Point(28, 213);
            this.progressPanel1.Name = "progressPanel1";
            this.progressPanel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.progressPanel1.Size = new System.Drawing.Size(246, 63);
            this.progressPanel1.TabIndex = 44;
            this.progressPanel1.Text = "progressPanel1";
            this.progressPanel1.Visible = false;
            // 
            // guna2Button4
            // 
            this.guna2Button4.BorderColor = System.Drawing.Color.Lavender;
            this.guna2Button4.BorderRadius = 15;
            this.guna2Button4.BorderThickness = 3;
            this.guna2Button4.CheckedState.Parent = this.guna2Button4;
            this.guna2Button4.CustomImages.Parent = this.guna2Button4;
            this.guna2Button4.FillColor = System.Drawing.Color.DarkGreen;
            this.guna2Button4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button4.ForeColor = System.Drawing.Color.White;
            this.guna2Button4.HoverState.Parent = this.guna2Button4;
            this.guna2Button4.Location = new System.Drawing.Point(79, 298);
            this.guna2Button4.Name = "guna2Button4";
            this.guna2Button4.ShadowDecoration.Parent = this.guna2Button4;
            this.guna2Button4.Size = new System.Drawing.Size(140, 41);
            this.guna2Button4.TabIndex = 43;
            this.guna2Button4.Text = "إنشاء";
            this.guna2Button4.TextOffset = new System.Drawing.Point(0, 3);
            this.guna2Button4.Click += new System.EventHandler(this.guna2Button4_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::OutlookDemo.Properties.Resources.icons8_share_3_256;
            this.pictureBox1.Location = new System.Drawing.Point(28, 44);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(246, 248);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 45;
            this.pictureBox1.TabStop = false;
            // 
            // guna2GroupBox2
            // 
            this.guna2GroupBox2.BorderColor = System.Drawing.Color.Maroon;
            this.guna2GroupBox2.BorderRadius = 30;
            this.guna2GroupBox2.BorderThickness = 10;
            this.guna2GroupBox2.Controls.Add(this.progressPanel2);
            this.guna2GroupBox2.Controls.Add(this.guna2Button1);
            this.guna2GroupBox2.Controls.Add(this.pictureBox2);
            this.guna2GroupBox2.Cursor = System.Windows.Forms.Cursors.Default;
            this.guna2GroupBox2.CustomBorderColor = System.Drawing.Color.Maroon;
            this.guna2GroupBox2.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2GroupBox2.ForeColor = System.Drawing.Color.White;
            this.guna2GroupBox2.Location = new System.Drawing.Point(142, 163);
            this.guna2GroupBox2.Name = "guna2GroupBox2";
            this.guna2GroupBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.guna2GroupBox2.ShadowDecoration.Parent = this.guna2GroupBox2;
            this.guna2GroupBox2.Size = new System.Drawing.Size(300, 367);
            this.guna2GroupBox2.TabIndex = 1;
            this.guna2GroupBox2.Text = "إستعادة نسخة إحتياطية";
            this.guna2GroupBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // progressPanel2
            // 
            this.progressPanel2.Appearance.BackColor = System.Drawing.Color.Maroon;
            this.progressPanel2.Appearance.Options.UseBackColor = true;
            this.progressPanel2.Caption = "الرجاء الانتظار";
            this.progressPanel2.Description = "الرجاء الانتظار حتى يتم استعادة النسخة....";
            this.progressPanel2.Location = new System.Drawing.Point(28, 213);
            this.progressPanel2.Name = "progressPanel2";
            this.progressPanel2.Size = new System.Drawing.Size(246, 63);
            this.progressPanel2.TabIndex = 44;
            this.progressPanel2.Text = "progressPanel2";
            this.progressPanel2.Visible = false;
            // 
            // guna2Button1
            // 
            this.guna2Button1.BorderColor = System.Drawing.Color.Lavender;
            this.guna2Button1.BorderRadius = 15;
            this.guna2Button1.BorderThickness = 3;
            this.guna2Button1.CheckedState.Parent = this.guna2Button1;
            this.guna2Button1.CustomImages.Parent = this.guna2Button1;
            this.guna2Button1.FillColor = System.Drawing.Color.Maroon;
            this.guna2Button1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.HoverState.Parent = this.guna2Button1;
            this.guna2Button1.Location = new System.Drawing.Point(78, 298);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.ShadowDecoration.Parent = this.guna2Button1;
            this.guna2Button1.Size = new System.Drawing.Size(140, 41);
            this.guna2Button1.TabIndex = 43;
            this.guna2Button1.Text = "إستعادة";
            this.guna2Button1.TextOffset = new System.Drawing.Point(0, 3);
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::OutlookDemo.Properties.Resources.icons8_restart_256;
            this.pictureBox2.Location = new System.Drawing.Point(28, 44);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(246, 248);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 46;
            this.pictureBox2.TabStop = false;
            // 
            // UC_BACK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.guna2GroupBox2);
            this.Controls.Add(this.guna2GroupBox1);
            this.Name = "UC_BACK";
            this.Size = new System.Drawing.Size(1006, 681);
            this.guna2GroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.guna2GroupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse Elips_back;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox2;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
        private DevExpress.XtraWaitForm.ProgressPanel progressPanel2;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private DevExpress.XtraWaitForm.ProgressPanel progressPanel1;
        private Guna.UI2.WinForms.Guna2Button guna2Button4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}
