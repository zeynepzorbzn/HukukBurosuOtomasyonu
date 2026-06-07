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

namespace HukukBurosuOtomasyon
{
    public partial class FrmMuvekkiller : Form
    {
        public FrmMuvekkiller()
        {
            InitializeComponent();
        }

        sqlbaglantisi bglnt = new sqlbaglantisi();  

        void Listele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From TBL_MUVEKKILLER", bglnt.baglanti());
            da.Fill(dt);
            gridControl1.DataSource = dt;

        }

        void temizle()
        {
            TxtId.Text = "";
            TxtAdSoyad.Text = "";
            MaskedTxtDgmTarih.Text = "";
            TxtDavaAdi.Text = "";
            TxtDavaDosyaNo.Text = "";
            MaskedTxtTc.Text = "";
            MaskedTxtTelefon.Text = "";
            TxtMail.Text = "";
            RichTxtAdres.Text = "";
            ComboIl.Text = "";
            ComboIlce.Text = "";
            TxtDavaAvukati.Text = "";
            ComboMuvekkiller.Text = "";
            TxtAdSoyad.Focus();
        }
        void SehirListesi()
        {
            SqlCommand komut = new SqlCommand("Select Sehir From TBL_ILLER", bglnt.baglanti());
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                ComboIl.Properties.Items.Add(dr[0]);
            }
            bglnt.baglanti().Close();
        }

        private void FrmMuvekkiller_Load(object sender, EventArgs e)
        {
            Listele();
            temizle();
            SehirListesi();
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into TBL_MUVEKKILLER (ADSOYAD, TC, TARIH, IL, ILCE, TELEFON," +
                "MAIL, DAVAAD, DAVADOSYANO, DAVAAVUKAT, MUVEKKILTUR, ADRES) values (@p1, @p2, @p3, @p4, @p5, @p6, @p7," +
                "@p8, @p9, @p10, @p11, @p12)", bglnt.baglanti());
            komut.Parameters.AddWithValue("@p1", TxtAdSoyad.Text);
            komut.Parameters.AddWithValue("@p2", MaskedTxtTc.Text);
            komut.Parameters.AddWithValue("@p3", MaskedTxtDgmTarih.Text);
            komut.Parameters.AddWithValue("@p4", ComboIl.Text);
            komut.Parameters.AddWithValue("@p5", ComboIlce.Text);
            komut.Parameters.AddWithValue("@p6", MaskedTxtTelefon.Text);
            komut.Parameters.AddWithValue("@p7", TxtMail.Text);
            komut.Parameters.AddWithValue("@p8", TxtDavaAdi.Text);
            komut.Parameters.AddWithValue("@p9", TxtDavaDosyaNo.Text);
            komut.Parameters.AddWithValue("@p10", TxtDavaAvukati.Text);
            komut.Parameters.AddWithValue("@p11",ComboMuvekkiller.Text);
            komut.Parameters.AddWithValue("@p12", RichTxtAdres.Text);
            komut.ExecuteNonQuery();
            bglnt.baglanti().Close();
            MessageBox.Show("Müvekkil bilgileri kaydedildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Listele();
            temizle();
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update TBL_MUVEKKILLER set ADSOYAD=@p1, TC=@p2, TARIH=@p3, IL=@p4, ILCE=@p5," +
               "TELEFON=@p6, MAIL=@p7, DAVAAD=@p8, DAVADOSYANO=@p9, DAVAAVUKAT=@p10, MUVEKKILTUR=@p11, ADRES=@p12 where ID=@P13", bglnt.baglanti());
            komut.Parameters.AddWithValue("@p1", TxtAdSoyad.Text);
            komut.Parameters.AddWithValue("@p2", MaskedTxtTc.Text);
            komut.Parameters.AddWithValue("@p3", MaskedTxtDgmTarih.Text);
            komut.Parameters.AddWithValue("@p4", ComboIl.Text);
            komut.Parameters.AddWithValue("@p5", ComboIlce.Text);
            komut.Parameters.AddWithValue("@p6", MaskedTxtTelefon.Text);
            komut.Parameters.AddWithValue("@p7", TxtMail.Text);
            komut.Parameters.AddWithValue("@p8", TxtDavaAdi.Text);
            komut.Parameters.AddWithValue("@p9", TxtDavaDosyaNo.Text);
            komut.Parameters.AddWithValue("@p10", TxtDavaAvukati.Text);
            komut.Parameters.AddWithValue("@p11", ComboMuvekkiller.Text);
            komut.Parameters.AddWithValue("@p12", RichTxtAdres.Text);
            komut.Parameters.AddWithValue("@p13", TxtId.Text);
            komut.ExecuteNonQuery();
            bglnt.baglanti().Close();
            MessageBox.Show("Müvekkil bilgileri güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Listele();
            temizle();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);

            if (dr != null)
            {
                TxtId.Text = dr["ID"].ToString();
                TxtAdSoyad.Text = dr["ADSOYAD"].ToString();
                MaskedTxtTc.Text = dr["TC"].ToString();
                MaskedTxtDgmTarih.Text = dr["TARIH"].ToString();
                ComboIl.Text = dr["IL"].ToString();
                ComboIlce.Text = dr["ILCE"].ToString();
                MaskedTxtTelefon.Text = dr["TELEFON"].ToString();
                TxtAdSoyad.Text = dr["ADSOYAD"].ToString();
                TxtMail.Text = dr["MAIL"].ToString();
                TxtAdSoyad.Text = dr["ADSOYAD"].ToString();
                TxtDavaDosyaNo.Text = dr["DAVADOSYANO"].ToString();
                TxtDavaAvukati.Text = dr["DAVAAVUKAT"].ToString();
                TxtDavaAdi.Text = dr["DAVAAD"].ToString();
                ComboMuvekkiller.Text = dr["MUVEKKILTUR"].ToString();
                RichTxtAdres.Text = dr["ADRES"].ToString();

            }
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Delete From TBL_MUVEKKILLER where ID=@P1", bglnt.baglanti());
            komut.Parameters.AddWithValue("@P1", TxtId.Text);
            komut.ExecuteNonQuery();
            bglnt.baglanti();
            MessageBox.Show("Müvekkil bilgileri silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            Listele();
            temizle();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            temizle();
        }

        private void ComboIl_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboIlce.Properties.Items.Clear();
            SqlCommand komut1 = new SqlCommand("Select ilce From TBL_ILCELER where Sehir=@p1 ", bglnt.baglanti());
            komut1.Parameters.AddWithValue("@p1", ComboIl.SelectedIndex + 1);
            SqlDataReader dr = komut1.ExecuteReader();
            while (dr.Read())
            {
                ComboIlce.Properties.Items.Add(dr[0]);
            }
            bglnt.baglanti().Close();
        }
    }
}
