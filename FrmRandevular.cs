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
    public partial class FrmRandevular : Form
    {
        public FrmRandevular()
        {
            InitializeComponent();
        }

        sqlbaglantisi bglnt = new sqlbaglantisi();

        void Listele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From TBL_RANDEVULAR", bglnt.baglanti());
            da.Fill(dt);
            gridControl1.DataSource = dt;

        }
        void temizle()
        {
            TxtId.Text = "";
            TxtMuvekkil.Text = "";
            MaskedTxtTarih.Text = "";
            TxtAvukat.Text = "";
            MaskedTxtSaat.Text = "";
            TxtDavaAdi.Text = "";
            TxtSekreter.Text = "";
            RichTxtAdres.Text = "";
            TxtMuvekkil.Focus();
        }

        private void FrmRandevular_Load(object sender, EventArgs e)
        {
            Listele();
            temizle();
        }


        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into TBL_RANDEVULAR (MUVEKKILAD, AVUKATAD, DAVAD, RANDEVUTARIH," +
                "RANDEVUSAAT, SEKRETER, ADRES) values (@p1, @p2, @p3, @p4, @p5, @p6, @p7)", bglnt.baglanti());
            komut.Parameters.AddWithValue("@p1", TxtMuvekkil.Text);
            komut.Parameters.AddWithValue("@p2", TxtAvukat.Text);
            komut.Parameters.AddWithValue("@p3", TxtDavaAdi.Text);
            komut.Parameters.AddWithValue("@p4", MaskedTxtTarih.Text);
            komut.Parameters.AddWithValue("@p5", MaskedTxtSaat.Text);
            komut.Parameters.AddWithValue("@p6", TxtSekreter.Text);
            komut.Parameters.AddWithValue("@p7", RichTxtAdres.Text);
            komut.ExecuteNonQuery();
            bglnt.baglanti().Close();
            MessageBox.Show("Randevu bilgileri kaydedildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Listele();
            temizle();
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update TBL_RANDEVULAR set MUVEKKILAD=@p1, AVUKATAD=@p2, DAVAD=@p3, " +
                "RANDEVUTARIH=@p4, RANDEVUSAAT=@p5, SEKRETER=@p6, ADRES=@p7 where ID=@p8", bglnt.baglanti());
            komut.Parameters.AddWithValue("@p1", TxtMuvekkil.Text);
            komut.Parameters.AddWithValue("@p2", TxtAvukat.Text);
            komut.Parameters.AddWithValue("@p3", TxtDavaAdi.Text);
            komut.Parameters.AddWithValue("@p4", MaskedTxtTarih.Text);
            komut.Parameters.AddWithValue("@p5", MaskedTxtSaat.Text);
            komut.Parameters.AddWithValue("@p6", TxtSekreter.Text);
            komut.Parameters.AddWithValue("@p7", RichTxtAdres.Text);
            komut.Parameters.AddWithValue("@p8", TxtId.Text);
            komut.ExecuteNonQuery();
            bglnt.baglanti().Close();
            MessageBox.Show("Randevu bilgileri güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Listele();
            temizle();
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Delete From TBL_RANDEVULAR where ID=@P1", bglnt.baglanti());
            komut.Parameters.AddWithValue("@P1", TxtId.Text);
            komut.ExecuteNonQuery();
            bglnt.baglanti();
            MessageBox.Show("Randevu silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            Listele();
            temizle();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);

            if (dr != null)
            {
                TxtId.Text = dr["ID"].ToString();
                TxtMuvekkil.Text = dr["MUVEKKILAD"].ToString();
                MaskedTxtTarih.Text = dr["RANDEVUTARIH"].ToString();
                MaskedTxtSaat.Text = dr["RANDEVUSAAT"].ToString();
                TxtDavaAdi.Text = dr["DAVAD"].ToString();
                TxtAvukat.Text = dr["AVUKATAD"].ToString();
                RichTxtAdres.Text = dr["ADRES"].ToString();
                TxtSekreter.Text = dr["SEKRETER"].ToString();

            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            temizle();
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }
    }
}
