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
    public partial class FrmOgrenciAnaModul : Form
    {
        public FrmOgrenciAnaModul()
        {
            InitializeComponent();
        }

        sqlBaglanti bgl = new sqlBaglanti();

        private void LoadGelmedigiGunler()
        {
            int OgrenciID = GirisFormu.OgrenciID; // Global değişkeni kullanarak OgrenciID'yi alıyoruz
                                                // Öğrencinin ID'sini alıyoruz (login ekranından)
            DateTime today = DateTime.Now.Date;            
            {                
                SqlCommand cmd = new SqlCommand("SELECT Tarih FROM Yoklama WHERE OgrenciID = @OgrenciID AND Durum = 'Yok'",bgl.baglanti());
                cmd.Parameters.AddWithValue("@OgrenciID", OgrenciID);

                SqlDataReader reader = cmd.ExecuteReader();
                List<DateTime> gelmedigiGunler = new List<DateTime>();
                while (reader.Read())
                {
                    gelmedigiGunler.Add(reader.GetDateTime(0));
                }

                // GridControl veya ListBox kullanarak öğrenciye gelmediği günleri göster
                gridControl1.DataSource = gelmedigiGunler;
                bgl.baglanti().Close();
            }
        }

        private void LoadOgrenciBilgileri()
        {
            sqlBaglanti bgl = new sqlBaglanti();
            try
            {
                SqlCommand komut = new SqlCommand("SELECT OgrenciAd, OgrenciSoyad, OgrenciNo, OgrenciSinif, OgrenciTC FROM Ogrenci WHERE OgrenciID = @OgrenciID", bgl.baglanti());
                komut.Parameters.AddWithValue("@OgrenciID", GirisFormu.OgrenciID); // Global OgrenciID
                SqlDataReader dr = komut.ExecuteReader();

                if (dr.Read())
                {
                    txtAd.Text = dr["OgrenciAd"].ToString();
                    txtSoyad.Text = dr["OgrenciSoyad"].ToString();
                    txtNo.Text = dr["OgrenciNo"].ToString();
                    txtSinif.Text = dr["OgrenciSinif"].ToString();
                    txtTC.Text = dr["OgrenciTC"].ToString();
                }
                else
                {
                    MessageBox.Show("Öğrenci bilgileri bulunamadı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                bgl.baglanti().Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void FrmOgrenciAnaModul_Load(object sender, EventArgs e)
        {            
                LoadOgrenciBilgileri();  // Öğrencinin bilgilerini yükleyin
                LoadGelmedigiGunler();  // Öğrencinin gelmediği günleri yükleyin            
        }

        private void btnCıkıs_Click(object sender, EventArgs e)
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
