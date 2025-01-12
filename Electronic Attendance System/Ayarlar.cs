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
    public partial class Ayarlar : Form
    {
        public Ayarlar()
        {
            InitializeComponent();
        }

        sqlBaglanti bgl = new sqlBaglanti();

        //ADO.NET Öğretmen Şifre Bilgileri
        void listele()
        {
            DataTable dt1 = new DataTable();
            SqlDataAdapter da1 = new SqlDataAdapter("Execute AyarlarOgretmen",bgl.baglanti());
            da1.Fill(dt1);
            gridControl1.DataSource = dt1;

        }

        void temizle()
        {
            TxtOgretmenID.Text = "";
            TxtBrans.Text = "";
            lookUpOgretmenAd.Text = "";
            TxtOgretmenTC.Text = "";
            TxtOgretmenSifre.Text = "";
            lookUpOgretmenAd.Text = "";
            lookUpOgretmenAd.Properties.NullText = "Öğretmen Seçiniz";
        }

        //ADO.NET LookUpEdit Aracı veri getirme
        void ogretmenlistesi()
        {
            DataTable dt2 = new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter("Select OgretmenID,(OgretmenAdi+' '+ OgretmenSoyadi) as 'OgretmenAdSoyad',OgretmenBrans from Ogretmen",bgl.baglanti());
            da2.Fill(dt2);
            lookUpOgretmenAd.Properties.ValueMember = "OgretmenID";
            lookUpOgretmenAd.Properties.DisplayMember = "OgretmenAdSoyad";
            lookUpOgretmenAd.Properties.NullText = "Öğretmen Seçiniz.";
            lookUpOgretmenAd.Properties.DataSource = dt2;
        }
                
        private void Ayarlar_Load(object sender, EventArgs e)
        {
            listele();
            ogretmenlistesi();
            temizle();
            Ogrencilistele();
            ogrencilistesimetot();
        }

        //ADO.NET ile gridcontrol verilerini araçlara taşımak
               
        private void gridView1_FocusedRowObjectChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowObjectChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dr != null)
            {
                TxtOgretmenID.Text = dr["AyarlarID"].ToString();
                lookUpOgretmenAd.Text = dr["OgretmenAdSoyad"].ToString();
                TxtBrans.Text = dr["OgretmenBrans"].ToString();
                TxtOgretmenTC.Text = dr["OgretmenTC"].ToString();
                TxtOgretmenSifre.Text = dr["OgretmenSifre"].ToString();

            }
        }
        // ADO.NET ile lookupedit seçimi sonrası verilerin düzeltilmesi
        private void lookUpOgretmenAd_Properties_EditValueChanged(object sender, EventArgs e)
        {
            TxtOgretmenSifre.Text = "";
            SqlCommand komut = new SqlCommand("Select * from Ogretmen where OgretmenID=@p1",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", lookUpOgretmenAd.ItemIndex + 1);
            SqlDataReader dr3 = komut.ExecuteReader();
            while (dr3.Read())
            {
                TxtOgretmenID.Text = dr3["OgretmenID"].ToString();
                TxtBrans.Text = dr3["OgretmenBrans"].ToString();
                TxtOgretmenTC.Text = dr3["OgretmenTC"].ToString();
            }
            bgl.baglanti().Close();
        }


        //Öğretmen Şifre Kaydet
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            SqlCommand komut2 = new SqlCommand("insert into Ayarlar (AyarlarID,OgretmenSifre) values (@p1,@p2) ", bgl.baglanti());
            komut2.Parameters.AddWithValue("@p1", TxtOgretmenID.Text);
            komut2.Parameters.AddWithValue("@p2", TxtOgretmenSifre.Text);
            komut2.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Şifre Oluşturuldu", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();
            temizle();
        }

        //Öğretmen Şİfre Güncelle
        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut3 = new SqlCommand("Update Ayarlar set OgretmenSifre=@p1 where AyarlarID=@p2",bgl.baglanti());
            komut3.Parameters.AddWithValue("@p1", TxtOgretmenSifre.Text);
            komut3.Parameters.AddWithValue("@p2", TxtOgretmenID.Text);
            komut3.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Şifre Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();
            temizle();
        }

        private void Temizle_Click(object sender, EventArgs e)
        {
            temizle();
        }

        void Ogrencilistele()
        {
            DataTable dt1 = new DataTable();
            SqlDataAdapter da1 = new SqlDataAdapter("Execute AyarlarOgrenci", bgl.baglanti());
            da1.Fill(dt1);
            gridControl2.DataSource = dt1;
        }

        //ADO.NET ile lookupedit veri getirme
        void ogrencilistesimetot()
        {
            DataTable dt2 = new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter("Select OgrenciID, (OgrenciAd+' '+OgrenciSoyad) as 'OgrenciAdSoyad', OgrenciSinif from Ogrenci", bgl.baglanti());
            da2.Fill(dt2);
            lookUpOgrenciAd.Properties.ValueMember = "OgrenciID";
            lookUpOgrenciAd.Properties.DisplayMember = "OgrenciAdSoyad";
            lookUpOgrenciAd.Properties.NullText = "Öğrenci Seçiniz";
            lookUpOgrenciAd.Properties.DataSource = dt2;
        }

        //ADO.NET ile GridControl verilerini araçlara aktarma
        
        private void gridView2_FocusedRowObjectChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowObjectChangedEventArgs e)
        {

            DataRow dr = gridView2.GetDataRow(gridView2.FocusedRowHandle);
            if (dr != null)
            {
                TxtOgrenciID.Text = dr["AyarlarOgrenciID"].ToString();
                lookUpOgrenciAd.Text = dr["OgrenciAdSoyad"].ToString();
                TxtSinif.Text = dr["OgrenciSinif"].ToString();
                TxtOgrenciTC.Text = dr["OgrenciTC"].ToString();
                TxtOgrenciSifre.Text = dr["OgrenciSifre"].ToString();
            }
        }
        //ADO.Net ile lookupedit seçimi sonrası verilerin düzeltilmesi
        private void TxtOgrenciID_Properties_EditValueChanged(object sender, EventArgs e)
        {
            TxtOgrenciSifre.Text = "";
            SqlCommand komut = new SqlCommand("Select * from Ogrenci where OgrenciID=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", lookUpOgrenciAd.ItemIndex + 1);
            SqlDataReader dr4 = komut.ExecuteReader();
            while (dr4.Read())
            {
                TxtOgretmenID.Text = dr4["OgrenciID"].ToString();
                TxtSinif.Text = dr4["OgrenciSinif"].ToString();
                TxtOgrenciTC.Text = dr4["OgrenciTC"].ToString();
            }
            bgl.baglanti().Close();
        }

        void Ogrencitemizle()
        {

            TxtOgrenciID.Text = "";
            TxtSinif.Text = "";
            lookUpOgrenciAd.Text = "";
            TxtOgrenciTC.Text = "";
            TxtOgrenciSifre.Text = "";
            lookUpOgrenciAd.Text = "";
            lookUpOgrenciAd.Properties.NullText = "Öğrenci Seçiniz";
        }

        private void btnOgrenciKaydet_Click(object sender, EventArgs e)
        {
            SqlCommand komut3 = new SqlCommand("insert into OgrenciAyarlar (AyarlarOgrenciID,OgrenciSifre) values (@p1,@p2) ", bgl.baglanti());
            komut3.Parameters.AddWithValue("@p1", TxtOgrenciID.Text);
            komut3.Parameters.AddWithValue("@p2", TxtOgrenciSifre.Text);
            komut3.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Şifre Oluşturuldu", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Ogrencilistele();
            Ogrencitemizle();
        }
            //Öğrenci Şifre Güncelleme
        private void btnOgrenciGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut4 = new SqlCommand("Update OgrenciAyarlar set OgrenciSifre=@p1 where AyarlarOgrenciID=@p2", bgl.baglanti());
            komut4.Parameters.AddWithValue("@p1", TxtOgrenciSifre.Text);
            komut4.Parameters.AddWithValue("@p2", TxtOgrenciID.Text);
            komut4.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Şifre Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Ogrencilistele();
            Ogrencitemizle();
        }

        private void btnOgrenciTemizle_Click(object sender, EventArgs e)
        {
            Ogrencitemizle();
        }
    }
}
