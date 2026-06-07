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
    public partial class FrmSekreterler : Form
    {
        public FrmSekreterler()
        {
            InitializeComponent();
        }

        sqlbaglantisi bglnt= new sqlbaglantisi();

        void Listele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From TBL_SEKRETERLER", bglnt.baglanti());
            da.Fill(dt);
            gridControl1.DataSource = dt;

        }

        void temizle()
        {
            TxtId.Text = "";
            TxtAdSoyad.Text = "";
            MaskedTxtMaas.Text = "";
            TxtAvukat.Text = "";
            MaskedTxtTc.Text = "";
            MaskedTxtTelefon.Text = "";
            TxtMail.Text = "";
            RichTxtAdres.Text = "";
            TxtAdSoyad.Focus();
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into TBL_SEKRETERLER (SEKRETERADSOYAD, TC, TELEFON, MAIL," +
                "AVUKAT, MAAS, ADRES)  values (@p1, @p2, @p3, @p4, @p5, @p6, @p7)", bglnt.baglanti());
            komut.Parameters.AddWithValue("@p1", TxtAdSoyad.Text);
            komut.Parameters.AddWithValue("@p2", MaskedTxtTc.Text);
            komut.Parameters.AddWithValue("@p3", MaskedTxtTelefon.Text);
            komut.Parameters.AddWithValue("@p4", TxtMail.Text);
            komut.Parameters.AddWithValue("@p5", TxtAvukat.Text);
            komut.Parameters.AddWithValue("@p6", MaskedTxtMaas.Text);
            komut.Parameters.AddWithValue("@p7", RichTxtAdres.Text);
            komut.ExecuteNonQuery();
            bglnt.baglanti().Close();
            MessageBox.Show("Sekreter bilgileri kaydedildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Listele();
            temizle();

        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update  TBL_SEKRETERLER set SEKRETERADSOYAD=@p1, TC=@p2, TELEFON=@p3," +
                "MAIL=@p4, AVUKAT=@p5, MAAS=@p6, ADRES=@p7 where ID=@p8", bglnt.baglanti());
            komut.Parameters.AddWithValue("@p1", TxtAdSoyad.Text);
            komut.Parameters.AddWithValue("@p2", MaskedTxtTc.Text);
            komut.Parameters.AddWithValue("@p3", MaskedTxtTelefon.Text);
            komut.Parameters.AddWithValue("@p4", TxtMail.Text);
            komut.Parameters.AddWithValue("@p5", TxtAvukat.Text);
            komut.Parameters.AddWithValue("@p6", MaskedTxtMaas.Text);
            komut.Parameters.AddWithValue("@p7", RichTxtAdres.Text);
            komut.Parameters.AddWithValue("@p8", TxtId.Text);
            komut.ExecuteNonQuery();
            bglnt.baglanti().Close();
            MessageBox.Show("Sekreter bilgileri güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Listele();
            temizle();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);

            if (dr != null)
            {
                TxtId.Text = dr["ID"].ToString();
                TxtAdSoyad.Text = dr["SEKRETERADSOYAD"].ToString();
                MaskedTxtTc.Text = dr["TC"].ToString();
                MaskedTxtMaas.Text = dr["MAAS"].ToString();
                MaskedTxtTelefon.Text = dr["TELEFON"].ToString();
                TxtMail.Text = dr["MAIL"].ToString();
                TxtAvukat.Text = dr["AVUKAT"].ToString();
                RichTxtAdres.Text = dr["ADRES"].ToString();

            }
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Delete From TBL_SEKRETERLER where ID=@P1", bglnt.baglanti());
            komut.Parameters.AddWithValue("@P1", TxtId.Text);
            komut.ExecuteNonQuery();
            bglnt.baglanti();
            MessageBox.Show("Sekreter bilgileri silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            Listele();
            temizle();

        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            temizle();
        }

        private void FrmSekreterler_Load(object sender, EventArgs e)
        {
            Listele();
            temizle();
        }
    }
}
