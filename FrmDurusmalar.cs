using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HukukBurosuOtomasyon
{
    public partial class FrmDurusmalar : Form
    {
        public FrmDurusmalar()
        {
            InitializeComponent();
        }

        sqlbaglantisi bglnt = new sqlbaglantisi();

        void Listele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter dr = new SqlDataAdapter("Select * From TBL_DURUSMALAR", bglnt.baglanti());
            dr.Fill(dt);
            gridControl1.DataSource = dt;

        }

        void temizle()
        {
            TxtId.Text = "";
            TxtAdSoyad.Text = "";
            MaskedTxtTarih.Text = "";
            TxtMahkeme.Text = "";
            TxtDavaAvukati.Text = "";
            TxtDosyaNo.Text = "";
            MaskedTxtSaat.Text = "";
            TxtDavaAdi.Text = "";
            TxtAdSoyad.Focus();
        }

        private void FrmDurusmalar_Load(object sender, EventArgs e)
        {
            Listele();
            temizle();
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {

            SqlCommand komut = new SqlCommand("insert into TBL_DURUSMALAR (MUVEKKILAD, DAVAAD, DAVADOSYANO, " +
                "AVUKATAD, DURUSMATARIH, DURUSMASAAT, DURUSMAMAHKEME) values (@p1, @p2, @p3, @p4," +
                " @p5, @p6, @p7)", bglnt.baglanti());
            komut.Parameters.AddWithValue("@p1", TxtAdSoyad.Text);
            komut.Parameters.AddWithValue("@p2", TxtDavaAdi.Text);
            komut.Parameters.AddWithValue("@p3", TxtDosyaNo.Text);
            komut.Parameters.AddWithValue("@p4", TxtDavaAvukati.Text);
            komut.Parameters.AddWithValue("@p5", MaskedTxtTarih.Text);
            komut.Parameters.AddWithValue("@p6", MaskedTxtSaat.Text);
            komut.Parameters.AddWithValue("@p7", TxtMahkeme.Text);
            komut.ExecuteNonQuery();
            bglnt.baglanti().Close();
            MessageBox.Show("Duruşma bilgileri kaydedildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Listele();
            temizle();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);

            if (dr != null)
            {
                TxtId.Text = dr["ID"].ToString();
                TxtAdSoyad.Text = dr["MUVEKKILAD"].ToString();
                MaskedTxtTarih.Text = dr["DURUSMATARIH"].ToString();
                MaskedTxtSaat.Text = dr["DURUSMASAAT"].ToString();
                TxtDosyaNo.Text = dr["DAVADOSYANO"].ToString();
                TxtDavaAdi.Text = dr["DAVAAD"].ToString();
                TxtDavaAvukati.Text = dr["AVUKATAD"].ToString();
                TxtMahkeme.Text = dr["DURUSMAMAHKEME"].ToString();
            }
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update TBL_DURUSMALAR set MUVEKKILAD=@p1, DAVAAD=@p2, DAVADOSYANO=@p3," +
                "AVUKATAD=@p4, DURUSMATARIH=@p5, DURUSMASAAT=@p6, DURUSMAMAHKEME=@p7 where ID=@p8 ", bglnt.baglanti());
            komut.Parameters.AddWithValue("@p1", TxtAdSoyad.Text);
            komut.Parameters.AddWithValue("@p2", TxtDavaAdi.Text);
            komut.Parameters.AddWithValue("@p3", TxtDosyaNo.Text);
            komut.Parameters.AddWithValue("@p4", TxtDavaAvukati.Text);
            komut.Parameters.AddWithValue("@p5", MaskedTxtTarih.Text);
            komut.Parameters.AddWithValue("@p6", MaskedTxtSaat.Text);
            komut.Parameters.AddWithValue("@p7", TxtMahkeme.Text);
            komut.Parameters.AddWithValue("@p8", TxtId.Text);

            komut.ExecuteNonQuery();
            bglnt.baglanti().Close();
            MessageBox.Show("Duruşma bilgileri güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Listele();
            temizle();
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Delete From TBL_DURUSMALAR where ID=@P1", bglnt.baglanti());
            komut.Parameters.AddWithValue("@P1", TxtId.Text);
            komut.ExecuteNonQuery();
            bglnt.baglanti().Close();
            MessageBox.Show("Duruşma bilgileri silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            Listele();
            temizle();
        }
    }
}
