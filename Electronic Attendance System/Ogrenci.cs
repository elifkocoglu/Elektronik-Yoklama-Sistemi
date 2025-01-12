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
    public partial class Ogrenci : Form
    {
        public Ogrenci()
        {
            InitializeComponent();
        }

        sqlBaglanti bgl = new sqlBaglanti();

        //listele metodu ile 9/A diğerlerinin verilerini veritabanından alıyoruz ve ekranda gösteriyoruz

        void listele()
        {
            DataTable dt1 = new DataTable();
            SqlDataAdapter da1 = new SqlDataAdapter("Select * from Ogrenci where OgrenciSinif = '9/A'", bgl.baglanti());
            da1.Fill(dt1);
            gridControl1.DataSource = dt1;

            // 9/B bilgilerini çekmek için
            DataTable dt2 = new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter("Select * from Ogrenci where OgrenciSinif = '9/B'", bgl.baglanti());
            da2.Fill(dt2);
            gridControl2.DataSource = dt2;

            // 10/B bilgilerini çekmek için
            DataTable dt3 = new DataTable();
            SqlDataAdapter da3 = new SqlDataAdapter("Select * from Ogrenci where OgrenciSinif = '10/B'", bgl.baglanti());
            da3.Fill(dt3);
            gridControl5.DataSource = dt3;

            // 9/C bilgilerini çekmek için
            DataTable dt4 = new DataTable();
            SqlDataAdapter da4 = new SqlDataAdapter("Select * from Ogrenci where OgrenciSinif = '9/C'", bgl.baglanti());
            da4.Fill(dt4);
            gridControl3.DataSource = dt4;

            // 10/B bilgilerini çekmek için
            DataTable dt5 = new DataTable();
            SqlDataAdapter da5 = new SqlDataAdapter("Select * from Ogrenci where OgrenciSinif = '10/A'", bgl.baglanti());
            da5.Fill(dt5);
            gridControl4.DataSource = dt5;

            // 10/B bilgilerini çekmek için
            DataTable dt6 = new DataTable();
            SqlDataAdapter da6 = new SqlDataAdapter("Select * from Ogrenci where OgrenciSinif = '11/B'", bgl.baglanti());
            da6.Fill(dt6);
            gridControl6.DataSource = dt6;

        }
        
              private void Ogrenci_Load(object sender, EventArgs e)
        {
            listele();
            temizle();
        }
                        
                void temizle()
        {
            TxtID.Text = "";
            TxtAd.Text = "";
            TxtSoyad.Text = "";
            MaskedTC.Text = "";
            maskedOgrenciNo.Text = "";
            comboSinif.Text = "";
            maskedTel.Text = "";
            rdnErkek.Checked =false;
            rdnKiz.Checked = false;
        }

        private void gridView1_FocusedRowObjectChanged_1(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowObjectChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dr != null)
            {
                YoklamaAd.Text = dr["OgrenciAd"].ToString();
                YoklamaSoyad.Text = dr["OgrenciSoyad"].ToString();
                YoklamaNo.Text = dr["OgrenciNo"].ToString();
                YoklamaSinif.Text = dr["OgrenciSinif"].ToString();
                TxtID.Text = dr["OgrenciID"].ToString();
                TxtAd.Text = dr["OgrenciAd"].ToString();
                TxtSoyad.Text = dr["OgrenciSoyad"].ToString();
                comboSinif.Text = dr["OgrenciSinif"].ToString();
                MaskedTC.Text = dr["OgrenciTC"].ToString();
                maskedTel.Text = dr["OgrenciTel"].ToString();
                maskedOgrenciNo.Text = dr["OgrenciNo"].ToString();
                if (dr["OgrenciCinsiyet"].ToString() == "Kız")
                {
                    rdnKiz.Checked = true;
                }
                else { rdnErkek.Checked = true; }
            }
        }

        private void gridView2_FocusedRowObjectChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowObjectChangedEventArgs e)
        {

            DataRow dr = gridView2.GetDataRow(gridView2.FocusedRowHandle);
            if (dr != null)
            {
                YoklamaAd.Text = dr["OgrenciAd"].ToString();
                YoklamaSoyad.Text = dr["OgrenciSoyad"].ToString();
                YoklamaNo.Text = dr["OgrenciNo"].ToString();
                YoklamaSinif.Text = dr["OgrenciSinif"].ToString();
                TxtID.Text = dr["OgrenciID"].ToString();
                TxtAd.Text = dr["OgrenciAd"].ToString();
                TxtSoyad.Text = dr["OgrenciSoyad"].ToString();
                comboSinif.Text = dr["OgrenciSinif"].ToString();
                MaskedTC.Text = dr["OgrenciTC"].ToString();
                maskedTel.Text = dr["OgrenciTel"].ToString();
                maskedOgrenciNo.Text = dr["OgrenciNo"].ToString();
                if (dr["OgrenciCinsiyet"].ToString() == "Kız")
                {
                    rdnKiz.Checked = true;
                }
                else { rdnErkek.Checked = true; }
            }
        }

        private void gridView3_FocusedRowObjectChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowObjectChangedEventArgs e)
        {
            DataRow dr = gridView3.GetDataRow(gridView3.FocusedRowHandle);
            if (dr != null)
            {
                YoklamaAd.Text = dr["OgrenciAd"].ToString();
                YoklamaSoyad.Text = dr["OgrenciSoyad"].ToString();
                YoklamaNo.Text = dr["OgrenciNo"].ToString();
                YoklamaSinif.Text = dr["OgrenciSinif"].ToString();
                TxtID.Text = dr["OgrenciID"].ToString();
                TxtAd.Text = dr["OgrenciAd"].ToString();
                TxtSoyad.Text = dr["OgrenciSoyad"].ToString();
                comboSinif.Text = dr["OgrenciSinif"].ToString();
                MaskedTC.Text = dr["OgrenciTC"].ToString();
                maskedTel.Text = dr["OgrenciTel"].ToString();
                maskedOgrenciNo.Text = dr["OgrenciNo"].ToString();
                if (dr["OgrenciCinsiyet"].ToString() == "Kız")
                {
                    rdnKiz.Checked = true;
                }
                else { rdnErkek.Checked = true; }
            }
        }

        private void gridView4_FocusedRowObjectChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowObjectChangedEventArgs e)
        {

            DataRow dr = gridView4.GetDataRow(gridView4.FocusedRowHandle);
            if (dr != null)
            {
                YoklamaAd.Text = dr["OgrenciAd"].ToString();
                YoklamaSoyad.Text = dr["OgrenciSoyad"].ToString();
                YoklamaNo.Text = dr["OgrenciNo"].ToString();
                YoklamaSinif.Text = dr["OgrenciSinif"].ToString();
                TxtID.Text = dr["OgrenciID"].ToString();
                TxtAd.Text = dr["OgrenciAd"].ToString();
                TxtSoyad.Text = dr["OgrenciSoyad"].ToString();
                comboSinif.Text = dr["OgrenciSinif"].ToString();
                MaskedTC.Text = dr["OgrenciTC"].ToString();
                maskedTel.Text = dr["OgrenciTel"].ToString();
                maskedOgrenciNo.Text = dr["OgrenciNo"].ToString();
                if (dr["OgrenciCinsiyet"].ToString() == "Kız")
                {
                    rdnKiz.Checked = true;
                }
                else { rdnErkek.Checked = true; }
            }
        }

        private void gridView5_FocusedRowObjectChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowObjectChangedEventArgs e)
        {

            DataRow dr = gridView5.GetDataRow(gridView5.FocusedRowHandle);
            if (dr != null)
            {
                YoklamaAd.Text = dr["OgrenciAd"].ToString();
                YoklamaSoyad.Text = dr["OgrenciSoyad"].ToString();
                YoklamaNo.Text = dr["OgrenciNo"].ToString();
                YoklamaSinif.Text = dr["OgrenciSinif"].ToString();
                TxtID.Text = dr["OgrenciID"].ToString();
                TxtAd.Text = dr["OgrenciAd"].ToString();
                TxtSoyad.Text = dr["OgrenciSoyad"].ToString();
                comboSinif.Text = dr["OgrenciSinif"].ToString();
                MaskedTC.Text = dr["OgrenciTC"].ToString();
                maskedTel.Text = dr["OgrenciTel"].ToString();
                maskedOgrenciNo.Text = dr["OgrenciNo"].ToString();
                if (dr["OgrenciCinsiyet"].ToString() == "Kız")
                {
                    rdnKiz.Checked = true;
                }
                else { rdnErkek.Checked = true; }
            }
        }

        private void gridView6_FocusedRowObjectChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowObjectChangedEventArgs e)
        {

            DataRow dr = gridView6.GetDataRow(gridView6.FocusedRowHandle);
            if (dr != null)
            {
                YoklamaAd.Text = dr["OgrenciAd"].ToString();
                YoklamaSoyad.Text = dr["OgrenciSoyad"].ToString();
                YoklamaNo.Text = dr["OgrenciNo"].ToString();
                YoklamaSinif.Text = dr["OgrenciSinif"].ToString();
                TxtID.Text = dr["OgrenciID"].ToString();
                TxtAd.Text = dr["OgrenciAd"].ToString();
                TxtSoyad.Text = dr["OgrenciSoyad"].ToString();
                comboSinif.Text = dr["OgrenciSinif"].ToString();
                MaskedTC.Text = dr["OgrenciTC"].ToString();
                maskedTel.Text = dr["OgrenciTel"].ToString();
                maskedOgrenciNo.Text = dr["OgrenciNo"].ToString();
                if (dr["OgrenciCinsiyet"].ToString() == "Kız")
                {
                    rdnKiz.Checked = true;
                }
                else { rdnErkek.Checked = true; }
            }
        }
        public String cinsiyet;

        private void btnKaydet_Click_1(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into Ogrenci (OgrenciAd, OgrenciSoyad, OgrenciNo, OgrenciSinif, OgrenciCinsiyet , OgrenciTC, OgrenciTel) values(@p1,@p2,@p3,@p4,@p5,@p6,@p7)", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", TxtAd.Text);
            komut.Parameters.AddWithValue("@p2", TxtSoyad.Text);
            komut.Parameters.AddWithValue("@p3", maskedOgrenciNo.Text);
            komut.Parameters.AddWithValue("@p4", comboSinif.Text);
            komut.Parameters.AddWithValue("@p6", MaskedTC.Text);
            komut.Parameters.AddWithValue("@p7", maskedTel.Text);
            
            if (rdnKiz.Checked == true)
            {
                komut.Parameters.AddWithValue("@p5", cinsiyet="Kız");
            }
            else
            {
                komut.Parameters.AddWithValue("@p5", cinsiyet="Erkek");
            }
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Öğrenci Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();
        }

        private void btnUpdate_Click_1(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Update Ogrenci set OgrenciAd=@p1, OgrenciSoyad=@p2, OgrenciNo=@p3, OgrenciSinif=@p4, OgrenciCinsiyet=@p5, OgrenciTC=@p6, OgrenciTel=@p7 where OgrenciID=@p8", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", TxtAd.Text);
            komut.Parameters.AddWithValue("@p2", TxtSoyad.Text);
            komut.Parameters.AddWithValue("@p3", maskedOgrenciNo.Text);
            komut.Parameters.AddWithValue("@p4", comboSinif.Text);
            komut.Parameters.AddWithValue("@p6", MaskedTC.Text);
            komut.Parameters.AddWithValue("@p7", maskedTel.Text);
            komut.Parameters.AddWithValue("@p8", TxtID.Text);
            if (rdnKiz.Checked == true)
            {
                komut.Parameters.AddWithValue("@p5", cinsiyet = "Kız");
            }
            else
            {
                komut.Parameters.AddWithValue("@p5", cinsiyet = "Erkek");
            }
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Bilgiler Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();
        }

        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Delete from Ogrenci where OgrenciID=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", TxtID.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Bilgiler Silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            listele();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            temizle();
        }

        private void btnOnay_Click(object sender, EventArgs e)
        {
            string durum = gridView1.IsFocusedView ? (rdnVar.Checked ? "Var" : "Yok") :
        gridView2.IsFocusedView ? (rdnVar.Checked ? "Var" : "Yok") :
        gridView3.IsFocusedView ? (rdnVar.Checked ? "Var" : "Yok") :
        gridView4.IsFocusedView ? (rdnVar.Checked ? "Var" : "Yok") :
        gridView5.IsFocusedView ? (rdnVar.Checked ? "Var" : "Yok") :
        gridView6.IsFocusedView ? (rdnVar.Checked ? "Var" : "Yok") : "";
            int ogrenciID = (int)(gridView1.IsFocusedView ? gridView1.GetFocusedRowCellValue("OgrenciID") :
                     gridView2.IsFocusedView ? gridView2.GetFocusedRowCellValue("OgrenciID") :
                     gridView3.IsFocusedView ? gridView3.GetFocusedRowCellValue("OgrenciID") :
                     gridView4.IsFocusedView ? gridView4.GetFocusedRowCellValue("OgrenciID") :
                     gridView5.IsFocusedView ? gridView5.GetFocusedRowCellValue("OgrenciID") :
                     gridView6.IsFocusedView ? gridView6.GetFocusedRowCellValue("OgrenciID") : 0);
            DateTime tarih = DateTime.Now.Date; // Bugünün tarihi

            // GridView'in odaklanıp odaklanmadığını kontrol et
            if (gridView1.IsFocusedView)
            {
                durum = rdnVar.Checked ? "Var" : "Yok";
                ogrenciID = (int)gridView1.GetFocusedRowCellValue("OgrenciID");
            }
            else if (gridView2.IsFocusedView)
            {
                durum = rdnVar.Checked ? "Var" : "Yok";
                ogrenciID = (int)gridView2.GetFocusedRowCellValue("OgrenciID");
            }
            else if (gridView3.IsFocusedView)
            {
                durum = rdnVar.Checked ? "Var" : "Yok";
                ogrenciID = (int)gridView3.GetFocusedRowCellValue("OgrenciID");
            }
            else if (gridView4.IsFocusedView)
            {
                durum = rdnVar.Checked ? "Var" : "Yok";
                ogrenciID = (int)gridView4.GetFocusedRowCellValue("OgrenciID");
            }
            else if (gridView5.IsFocusedView)
            {
                durum = rdnVar.Checked ? "Var" : "Yok";
                ogrenciID = (int)gridView5.GetFocusedRowCellValue("OgrenciID");
            }
            else if (gridView6.IsFocusedView)
            {
                durum = rdnVar.Checked ? "Var" : "Yok";
                ogrenciID = (int)gridView6.GetFocusedRowCellValue("OgrenciID");
            }


            using (SqlCommand cmd = new SqlCommand("INSERT INTO Yoklama (OgrenciID, Tarih, Durum) VALUES (@OgrenciID, @Tarih, @Durum)", bgl.baglanti()))
            {
                cmd.Parameters.AddWithValue("@OgrenciID", ogrenciID);
                cmd.Parameters.AddWithValue("@Tarih", tarih);
                cmd.Parameters.AddWithValue("@Durum", durum);
                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Yoklama kaydedildi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }    
    }
}
