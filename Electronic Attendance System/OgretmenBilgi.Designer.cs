namespace Electronic_Attendance_System
{
    partial class OgretmenBilgi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OgretmenBilgi));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtOgrtAd = new DevExpress.XtraEditors.TextEdit();
            this.txtOgrtSoyad = new DevExpress.XtraEditors.TextEdit();
            this.txtTC = new DevExpress.XtraEditors.TextEdit();
            this.txtBrans = new DevExpress.XtraEditors.TextEdit();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOgrtAd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOgrtSoyad.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTC.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBrans.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox1.Location = new System.Drawing.Point(-1, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(803, 457);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // txtOgrtAd
            // 
            this.txtOgrtAd.Enabled = false;
            this.txtOgrtAd.Location = new System.Drawing.Point(41, 78);
            this.txtOgrtAd.Name = "txtOgrtAd";
            this.txtOgrtAd.Size = new System.Drawing.Size(125, 22);
            this.txtOgrtAd.TabIndex = 1;
            // 
            // txtOgrtSoyad
            // 
            this.txtOgrtSoyad.Enabled = false;
            this.txtOgrtSoyad.Location = new System.Drawing.Point(41, 140);
            this.txtOgrtSoyad.Name = "txtOgrtSoyad";
            this.txtOgrtSoyad.Size = new System.Drawing.Size(125, 22);
            this.txtOgrtSoyad.TabIndex = 2;
            // 
            // txtTC
            // 
            this.txtTC.Enabled = false;
            this.txtTC.Location = new System.Drawing.Point(41, 209);
            this.txtTC.Name = "txtTC";
            this.txtTC.Size = new System.Drawing.Size(125, 22);
            this.txtTC.TabIndex = 3;
            // 
            // txtBrans
            // 
            this.txtBrans.Enabled = false;
            this.txtBrans.Location = new System.Drawing.Point(41, 283);
            this.txtBrans.Name = "txtBrans";
            this.txtBrans.Size = new System.Drawing.Size(125, 22);
            this.txtBrans.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(287, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(445, 264);
            this.label1.TabIndex = 5;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // OgretmenBilgi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBrans);
            this.Controls.Add(this.txtTC);
            this.Controls.Add(this.txtOgrtSoyad);
            this.Controls.Add(this.txtOgrtAd);
            this.Controls.Add(this.pictureBox1);
            this.Name = "OgretmenBilgi";
            this.Text = "OgretmenBilgi";
            this.Load += new System.EventHandler(this.OgretmenBilgi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOgrtAd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOgrtSoyad.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTC.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBrans.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private DevExpress.XtraEditors.TextEdit txtOgrtAd;
        private DevExpress.XtraEditors.TextEdit txtOgrtSoyad;
        private DevExpress.XtraEditors.TextEdit txtTC;
        private DevExpress.XtraEditors.TextEdit txtBrans;
        private System.Windows.Forms.Label label1;
    }
}