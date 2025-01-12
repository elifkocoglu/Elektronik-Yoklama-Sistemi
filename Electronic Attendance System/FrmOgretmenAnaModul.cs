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
    public partial class FrmOgretmenAnaModul : Form
    {
        public FrmOgretmenAnaModul()
        {
            InitializeComponent();
        }
        Ogrenci frm2;
        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frm2 == null || frm2.IsDisposed)
            {
                frm2 = new Ogrenci();
                frm2.IsMdiContainer = true;  // Ana formu MDI konteyneri olarak ayarla
                frm2.Show();
            }
            else
            {
                // Eğer form zaten açıksa, yeniden göster
                frm2.BringToFront();
            }
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
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
        OgretmenBilgi frm3;
        private void btnOgretmen_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frm3 == null || frm3.IsDisposed)
            {
                frm3 = new OgretmenBilgi();
                frm3.IsMdiContainer = true;  // Ana formu MDI konteyneri olarak ayarla
                frm3.Show();
            }
            else
            {
                // Eğer form zaten açıksa, yeniden göster
                frm3.BringToFront();
            }
        }
    }
}
