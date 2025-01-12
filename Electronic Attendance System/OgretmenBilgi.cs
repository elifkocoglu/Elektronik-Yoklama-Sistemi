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
    public partial class OgretmenBilgi : Form
    {
        public OgretmenBilgi()
        {
            InitializeComponent();
        }
        private void LoadOgrenciBilgileri()
        {
            sqlBaglanti bgl = new sqlBaglanti();
            try
            {
                SqlCommand komut = new SqlCommand("SELECT OgretmenAdi, OgretmenSoyadi, OgretmenTC, OgretmenBrans FROM Ogretmen WHERE OgretmenID = @OgretmenID", bgl.baglanti());
                komut.Parameters.AddWithValue("@OgretmenID", GirisFormu.OgretmenID); // Global OgretmenID
                SqlDataReader dr = komut.ExecuteReader();

                if (dr.Read())
                {                    
                    txtOgrtAd.Text = dr["OgretmenAdi"].ToString();
                    txtOgrtSoyad.Text = dr["OgretmenSoyadi"].ToString();
                    txtTC.Text = dr["OgretmenTC"].ToString();
                    txtBrans.Text = dr["OgretmenBrans"].ToString();
                   
                }
                else
                {                    
                    MessageBox.Show("Öğretmen bilgileri bulunamadı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                bgl.baglanti().Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void OgretmenBilgi_Load(object sender, EventArgs e)
        {
            LoadOgrenciBilgileri();
        }
    }
}
