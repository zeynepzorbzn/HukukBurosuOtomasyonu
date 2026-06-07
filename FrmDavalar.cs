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
    public partial class FrmDavalar : Form
    {
        public FrmDavalar()
        {
            InitializeComponent();
        }

        sqlbaglantisi bglnt = new sqlbaglantisi();

        void Listele()
        {
          DataTable dt = new DataTable();
            SqlDataAdapter dr = new SqlDataAdapter("Select * From TBL_DAVALAR", bglnt.baglanti());
            dr.Fill(dt);
            gridControl1.DataSource = dt;

        }

        void temizle()
        {
            TxtId.Text = "";
            TxtAdSoyad.Text = "";
            MaskedTxtBaslangic.Text = "";
            TxtMahkeme.Text = "";
            TxtDavaAvukati.Text = "";
            TxtDosyaNo.Text = "";
            MaskedTxtBitis.Text = "";
            TxtDavaAdi.Text = "";
            RichTxtDetay.Text = "";
            TxtMahkeme.Text = "";
            TxtDavaTuru.Text = "";
            TxtAdSoyad.Focus();
        }


        private void FrmDavalar_Load(object sender, EventArgs e)
        {
            Listele();

        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into TBL_DAVALAR (MUVEKKILADSOYAD, DAVAAD, DAVADOSYANO, DAVATUR, " +
                "DAVAAVUKAT, DAVADURUM, DAVABASLANGIC, DAVABITIS, DAVAMAHKEME, DAVADETAY) values (@p1, @p2, @p3, @p4," +
                " @p5, @p6, @p7, @p8, @p9, @p10)", bglnt.baglanti());
            komut.Parameters.AddWithValue("@p1", TxtAdSoyad.Text );
            komut.Parameters.AddWithValue("@p2", TxtDavaAdi.Text);
            komut.Parameters.AddWithValue("@p3", TxtDosyaNo.Text);
            komut.Parameters.AddWithValue("@p4", TxtDavaTuru.Text);
            komut.Parameters.AddWithValue("@p5", TxtDavaAvukati.Text);
            komut.Parameters.AddWithValue("@p6", TxtDavaDurumu.Text);
            komut.Parameters.AddWithValue("@p7", MaskedTxtBaslangic.Text);
            komut.Parameters.AddWithValue("@p8", MaskedTxtBitis.Text);
            komut.Parameters.AddWithValue("@p9", TxtMahkeme.Text);
            komut.Parameters.AddWithValue("@p10", RichTxtDetay.Text);
            komut.ExecuteNonQuery();
            bglnt.baglanti().Close();
            MessageBox.Show("Dava bilgileri kaydedildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Listele();
            temizle();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);

            if (dr != null)
            {
                TxtId.Text = dr["ID"].ToString();
                TxtAdSoyad.Text = dr["MUVEKKILADSOYAD"].ToString();
                MaskedTxtBaslangic.Text = dr["DAVABASLANGIC"].ToString();
                MaskedTxtBitis.Text = dr["DAVABITIS"].ToString();
                TxtDosyaNo.Text = dr["DAVADOSYANO"].ToString();
                TxtDavaAdi.Text = dr["DAVAAD"].ToString();
                TxtDavaAvukati.Text = dr["DAVAAVUKAT"].ToString();
                TxtDavaDurumu.Text = dr["DAVADURUM"].ToString();
                TxtDavaTuru.Text = dr["DAVATUR"].ToString();
                TxtMahkeme.Text = dr["DAVAMAHKEME"].ToString();
                RichTxtDetay.Text = dr["DAVADETAY"].ToString();
            }
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update TBL_DAVALAR set MUVEKKILADSOYAD=@p1, DAVAAD=@p2, DAVADOSYANO=@p3, DAVATUR=@p4, " +
                "DAVAAVUKAT=@p5, DAVADURUM=@p6, DAVABASLANGIC=@p7, DAVABITIS=@p8, DAVAMAHKEME=@p9, DAVADETAY=@p10 where ID=@p11 ", bglnt.baglanti());
            komut.Parameters.AddWithValue("@p1", TxtAdSoyad.Text);
            komut.Parameters.AddWithValue("@p2", TxtDavaAdi.Text);
            komut.Parameters.AddWithValue("@p3", TxtDosyaNo.Text);
            komut.Parameters.AddWithValue("@p4", TxtDavaTuru.Text);
            komut.Parameters.AddWithValue("@p5", TxtDavaAvukati.Text);
            komut.Parameters.AddWithValue("@p6", TxtDavaDurumu.Text);
            komut.Parameters.AddWithValue("@p7", MaskedTxtBaslangic.Text);
            komut.Parameters.AddWithValue("@p8", MaskedTxtBitis.Text);
            komut.Parameters.AddWithValue("@p9", TxtMahkeme.Text);
            komut.Parameters.AddWithValue("@p10", RichTxtDetay.Text);
            komut.Parameters.AddWithValue("@p11", TxtId.Text);
            komut.ExecuteNonQuery();
            bglnt.baglanti().Close();
            MessageBox.Show("Dava bilgileri güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Listele();
            temizle();
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Delete From TBL_DAVALAR where ID=@P1", bglnt.baglanti());
            komut.Parameters.AddWithValue("@P1", TxtId.Text);
            komut.ExecuteNonQuery();
            bglnt.baglanti().Close();
            MessageBox.Show("Dava bilgileri silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            Listele();
            temizle();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            temizle();
        }
    }
}
