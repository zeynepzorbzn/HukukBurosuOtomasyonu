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
    public partial class FrmOdemeler : Form
    {
        public FrmOdemeler()
        {
            InitializeComponent();
        }

        sqlbaglantisi bglnt = new sqlbaglantisi();

        void Listele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From TBL_ODEMELER", bglnt.baglanti());
            da.Fill(dt);
            gridControl1.DataSource = dt;
        }

        void temizle()
        {
            TxtId.Text = "";
            TxtMuvekkil.Text = "";
            MaskedTxtDurusmaSayisi.Text = "";
            TxtDavaAdi.Text = "";
            TxtAvukat.Text = "";
            TxtSekreter.Text = "";
            MaskedTxtSonOdeme.Text = "";
            MaskedTxtOdemeTutari.Text = "";
            RichTxtEkstra.Text = "";
            TxtMuvekkil.Focus();
        }
        
        private void FrmOdemeler_Load(object sender, EventArgs e)
        {
            Listele();
            temizle();
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
             SqlCommand komut = new SqlCommand("insert into TBL_ODEMELER (MUVEKKILAD, AVUKATAD, DAVAAD, DURUSMASAYISI, " +
                 "ODEMETUTAR, SONODEMETARIH, SEKRETER, EKSTRA) values (@p1, @p2, @p3, @p4, @p5, @p6, @p7, @p8)", bglnt.baglanti());
            komut.Parameters.AddWithValue("@p1", TxtMuvekkil.Text);
            komut.Parameters.AddWithValue("@p2", TxtAvukat.Text);
            komut.Parameters.AddWithValue("@p3", TxtDavaAdi.Text);
            komut.Parameters.AddWithValue("@p4", MaskedTxtDurusmaSayisi.Text);
            komut.Parameters.AddWithValue("@p5", MaskedTxtOdemeTutari.Text);
            komut.Parameters.AddWithValue("@p6", MaskedTxtSonOdeme.Text);
            komut.Parameters.AddWithValue("@p7", TxtSekreter.Text);
            komut.Parameters.AddWithValue("@p8", RichTxtEkstra.Text);
            komut.ExecuteNonQuery();
            bglnt.baglanti().Close();
            MessageBox.Show("Ödeme bilgileri kaydedildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Listele();
            temizle();
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update TBL_ODEMELER set MUVEKKILAD=@p1, AVUKATAD=@p2, DAVAAD=@p3, DURUSMASAYISI=@p4," +
                "ODEMETUTAR=@p5, SONODEMETARIH=@p6, SEKRETER=@p7, EKSTRA=@p8 where ID=@p9", bglnt.baglanti());
            komut.Parameters.AddWithValue("@p1", TxtMuvekkil.Text);
            komut.Parameters.AddWithValue("@p2", TxtAvukat.Text);
            komut.Parameters.AddWithValue("@p3", TxtDavaAdi.Text);
            komut.Parameters.AddWithValue("@p4", MaskedTxtDurusmaSayisi.Text);
            komut.Parameters.AddWithValue("@p5", MaskedTxtOdemeTutari.Text);
            komut.Parameters.AddWithValue("@p6", MaskedTxtSonOdeme.Text);
            komut.Parameters.AddWithValue("@p7", TxtSekreter.Text);
            komut.Parameters.AddWithValue("@p8", RichTxtEkstra.Text);
            komut.Parameters.AddWithValue("@p9", TxtId.Text);
            komut.ExecuteNonQuery();
            bglnt.baglanti().Close();
            MessageBox.Show("Ödeme bilgileri güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Listele();
            temizle();
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Delete From TBL_ODEMELER where ID=@P1", bglnt.baglanti());
            komut.Parameters.AddWithValue("@P1", TxtId.Text);
            komut.ExecuteNonQuery();
            bglnt.baglanti();
            MessageBox.Show("Ödeme bilgileri silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            Listele();
            temizle();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            temizle();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);

            if (dr != null)
            {
                TxtId.Text = dr["ID"].ToString();
                TxtMuvekkil.Text = dr["MUVEKKILAD"].ToString();
                MaskedTxtSonOdeme.Text = dr["SONODEMETARIH"].ToString();
                TxtAvukat.Text = dr["AVUKATAD"].ToString();
                TxtDavaAdi.Text = dr["DAVAAD"].ToString();
                MaskedTxtDurusmaSayisi.Text = dr["DURUSMASAYISI"].ToString();
                RichTxtEkstra.Text = dr["EKSTRA"].ToString();
                MaskedTxtOdemeTutari.Text = dr["ODEMETUTAR"].ToString();
                TxtSekreter.Text = dr["SEKRETER"].ToString();
            }
        }
    }
}
