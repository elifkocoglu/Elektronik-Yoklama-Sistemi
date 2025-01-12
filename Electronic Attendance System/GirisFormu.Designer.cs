namespace Electronic_Attendance_System
{
    partial class GirisFormu
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GirisFormu));
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtGirisSifre = new DevExpress.XtraEditors.TextEdit();
            this.txtGirisKullanıcı = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.btngirisMudur = new System.Windows.Forms.Button();
            this.btnGirisOgretmen = new System.Windows.Forms.Button();
            this.btnGirisOgrenci = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtGirisSifre.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGirisKullanıcı.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.labelControl1);
            this.panel1.Location = new System.Drawing.Point(12, 21);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 70);
            this.panel1.TabIndex = 0;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Century", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(81, 17);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(599, 39);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Elazığ Anadolu Lisesi Yoklama Sistemi";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl2.Appearance.ForeColor = System.Drawing.Color.SaddleBrown;
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Appearance.Options.UseForeColor = true;
            this.labelControl2.Location = new System.Drawing.Point(65, 445);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(133, 24);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Kullanıcı Adı:";
            // 
            // txtGirisSifre
            // 
            this.txtGirisSifre.Location = new System.Drawing.Point(496, 447);
            this.txtGirisSifre.Name = "txtGirisSifre";
            this.txtGirisSifre.Properties.Appearance.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.txtGirisSifre.Properties.Appearance.Options.UseBackColor = true;
            this.txtGirisSifre.Properties.UseSystemPasswordChar = true;
            this.txtGirisSifre.Size = new System.Drawing.Size(125, 22);
            this.txtGirisSifre.TabIndex = 2;
            // 
            // txtGirisKullanıcı
            // 
            this.txtGirisKullanıcı.Location = new System.Drawing.Point(216, 447);
            this.txtGirisKullanıcı.Name = "txtGirisKullanıcı";
            this.txtGirisKullanıcı.Properties.Appearance.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.txtGirisKullanıcı.Properties.Appearance.Options.UseBackColor = true;
            this.txtGirisKullanıcı.Size = new System.Drawing.Size(125, 22);
            this.txtGirisKullanıcı.TabIndex = 3;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl3.Appearance.ForeColor = System.Drawing.Color.SaddleBrown;
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Appearance.Options.UseForeColor = true;
            this.labelControl3.Location = new System.Drawing.Point(426, 445);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(55, 24);
            this.labelControl3.TabIndex = 4;
            this.labelControl3.Text = "Şifre:";
            // 
            // btngirisMudur
            // 
            this.btngirisMudur.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btngirisMudur.Location = new System.Drawing.Point(141, 508);
            this.btngirisMudur.Name = "btngirisMudur";
            this.btngirisMudur.Size = new System.Drawing.Size(150, 50);
            this.btngirisMudur.TabIndex = 5;
            this.btngirisMudur.Text = "İdari Personel Girişi";
            this.btngirisMudur.UseVisualStyleBackColor = false;
            this.btngirisMudur.Click += new System.EventHandler(this.btngirisMudur_Click);
            // 
            // btnGirisOgretmen
            // 
            this.btnGirisOgretmen.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnGirisOgretmen.Location = new System.Drawing.Point(331, 508);
            this.btnGirisOgretmen.Name = "btnGirisOgretmen";
            this.btnGirisOgretmen.Size = new System.Drawing.Size(150, 50);
            this.btnGirisOgretmen.TabIndex = 6;
            this.btnGirisOgretmen.Text = "Öğretmen Girişi";
            this.btnGirisOgretmen.UseVisualStyleBackColor = false;
            this.btnGirisOgretmen.Click += new System.EventHandler(this.btnGirisOgretmen_Click);
            // 
            // btnGirisOgrenci
            // 
            this.btnGirisOgrenci.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnGirisOgrenci.Location = new System.Drawing.Point(521, 508);
            this.btnGirisOgrenci.Name = "btnGirisOgrenci";
            this.btnGirisOgrenci.Size = new System.Drawing.Size(150, 50);
            this.btnGirisOgrenci.TabIndex = 7;
            this.btnGirisOgrenci.Text = "Öğrenci Girişi";
            this.btnGirisOgrenci.UseVisualStyleBackColor = false;
            this.btnGirisOgrenci.Click += new System.EventHandler(this.btnGirisOgrenci_Click);
            // 
            // GirisFormu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 610);
            this.Controls.Add(this.btnGirisOgrenci);
            this.Controls.Add(this.btnGirisOgretmen);
            this.Controls.Add(this.btngirisMudur);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.txtGirisKullanıcı);
            this.Controls.Add(this.txtGirisSifre);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.MaximizeBox = false;
            this.Name = "GirisFormu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GirisFormu";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtGirisSifre.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGirisKullanıcı.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtGirisSifre;
        private DevExpress.XtraEditors.TextEdit txtGirisKullanıcı;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private System.Windows.Forms.Button btngirisMudur;
        private System.Windows.Forms.Button btnGirisOgretmen;
        private System.Windows.Forms.Button btnGirisOgrenci;
    }
}