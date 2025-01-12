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
    public partial class Ogretmen : Form
    {
        public Ogretmen()
        {
            InitializeComponent();
        }

        private void labelControl1_Click(object sender, EventArgs e)
        {

        }

        private void labelControl5_Click(object sender, EventArgs e)
        {

        }

        private void textEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void groupControl2_Paint(object sender, PaintEventArgs e)
        {

        }

        sqlBaglanti bgl = new sqlBaglanti();

        void listele ()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from Ogretmen",bgl.baglanti());
            da.Fill(dt);
            gridControl1.DataSource = dt;
        }

        void clear()
        {
            textEdit3.Text = "";
            textEdit1.Text = "";
            textEdit2.Text = "";
            maskedTextBox1.Text = "";
            maskedTextBox2.Text = "";
            textEdit4.Text = "";
        }

        private void Ogretmen_Load(object sender, EventArgs e)
        {
            listele();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("INSERT INTO Ogretmen ( OgretmenAdi, OgretmenSoyadi, OgretmenTC, OgretmenTel, OgretmenBrans) VALUES (@p1,@p2,@p3,@p4,@p5)",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", textEdit1.Text );
            komut.Parameters.AddWithValue("@p2", textEdit2.Text);
            komut.Parameters.AddWithValue("@p3", maskedTextBox1.Text);
            komut.Parameters.AddWithValue("@p4", maskedTextBox2.Text);
            komut.Parameters.AddWithValue("@p5", textEdit4.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Öğretmen Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();
        }

        private void gridView1_FocusedRowObjectChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowObjectChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if(dr != null)
            {
                textEdit3.Text = dr["OgretmenID"].ToString();
                textEdit1.Text = dr["OgretmenAdi"].ToString();
                textEdit2.Text = dr["OgretmenSoyadi"].ToString();
                maskedTextBox1.Text = dr["OgretmenTC"].ToString();
                maskedTextBox2.Text = dr["OgretmenTel"].ToString();
                textEdit4.Text = dr["OgretmenBrans"].ToString();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Update Ogretmen set  OgretmenAdi=@p1, OgretmenSoyadi=@p2, OgretmenTC=@p3, OgretmenTel=@p4, OgretmenBrans =@p5 where OgretmenID =@p6 ", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", textEdit1.Text);
            komut.Parameters.AddWithValue("@p2", textEdit2.Text);
            komut.Parameters.AddWithValue("@p6", textEdit3.Text);
            komut.Parameters.AddWithValue("@p3", maskedTextBox1.Text);
            komut.Parameters.AddWithValue("@p4", maskedTextBox2.Text);
            komut.Parameters.AddWithValue("@p5", textEdit4.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Bilgiler Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Delete from Ogretmen where OgretmenID=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", textEdit3.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Öğretmen Silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            listele();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clear();
        }

        
    }
}
