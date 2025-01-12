using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Electronic_Attendance_System
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Ogretmen frm1;
        Ogrenci frm2;
        Ayarlar frm3;
        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(frm1 == null || frm1.IsDisposed) { 
            frm1 = new Ogretmen();
            frm1.MdiParent = this;
            frm1.Show();
            }
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frm2 == null || frm2.IsDisposed)
            {
                frm2 = new Ogrenci();
                frm2.MdiParent = this;
                frm2.Show();
            }
        }
        //Ayarlar
        private void barButtonItem7_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frm3 == null || frm3.IsDisposed)
            {
                frm3 = new Ayarlar();
                frm3.MdiParent = this;
                frm3.Show();
            }
        }

        private void barButtonItem2_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            // Çıkış yapmadan önce onay almak isterseniz:
            DialogResult result = MessageBox.Show("Uygulamadan çıkmak istediğinizden emin misiniz?", "Çıkış", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Hide();
                GirisFormu login = new GirisFormu();
                login.Show();
            }
        }
    }
}
