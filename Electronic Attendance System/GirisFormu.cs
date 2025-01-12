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

namespace Electronic_Attendance_System
{
    public partial class GirisFormu : Form
    {
        public GirisFormu()
        {
            InitializeComponent();
        }

        sqlBaglanti bgl = new sqlBaglanti();

        private void btngirisMudur_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Select OgretmenTC,OgretmenSifre from Ayarlar inner join Ogretmen on Ayarlar.AyarlarID=Ogretmen.OgretmenID where OgretmenTC=@p1 and OgretmenSifre=@p2",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1",txtGirisKullanıcı.Text);
            komut.Parameters.AddWithValue("@p2", txtGirisSifre.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                Form1 frm1 = new Form1();
                frm1.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı Kullanıcı Adı Veya Şİfre Girdiniz");
                txtGirisKullanıcı.Text = "";
                txtGirisSifre.Text = "";
            }
            bgl.baglanti().Close();
        }

        private void btnGirisOgretmen_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Select OgretmenTC,OgretmenSifre, OgretmenID from Ayarlar inner join Ogretmen on Ayarlar.AyarlarID=Ogretmen.OgretmenID where OgretmenTC=@p1 and OgretmenSifre=@p2", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txtGirisKullanıcı.Text);
            komut.Parameters.AddWithValue("@p2", txtGirisSifre.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                OgretmenID = dr.GetInt32(2);
                FrmOgretmenAnaModul frm2 = new FrmOgretmenAnaModul();
                frm2.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı Kullanıcı Adı Veya Şİfre Girdiniz");
                txtGirisKullanıcı.Text = "";
                txtGirisSifre.Text = "";
            }
            bgl.baglanti().Close();
        }
        public static int OgrenciID { get; set; } // Global OgrenciID
        public static int OgretmenID { get; set; }

        private void btnGirisOgrenci_Click(object sender, EventArgs e)
        {   //TC ve Şifreyi Alıyoruz
            SqlCommand komut2 = new SqlCommand("Select OgrenciID, OgrenciTC,OgrenciSifre from OgrenciAyarlar inner join Ogrenci on OgrenciAyarlar.AyarlarOgrenciID=Ogrenci.OgrenciID where OgrenciTC=@p1 and OgrenciSifre=@p2", bgl.baglanti());
            komut2.Parameters.AddWithValue("@p1", txtGirisKullanıcı.Text);
            komut2.Parameters.AddWithValue("@p2", txtGirisSifre.Text);
            
            // Veritabanından verileri çekiyoruz
            SqlDataReader dr2 = komut2.ExecuteReader();
            if (dr2.Read())
            {
                OgrenciID = dr2.GetInt32(0);
                FrmOgrenciAnaModul frm3 = new FrmOgrenciAnaModul();
                frm3.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı Kullanıcı Adı Veya Şİfre Girdiniz");
                txtGirisKullanıcı.Text = "";
                txtGirisSifre.Text = "";
            }
            bgl.baglanti().Close();
        }
    }
}
