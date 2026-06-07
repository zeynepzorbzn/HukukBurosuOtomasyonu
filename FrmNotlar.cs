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
    public partial class FrmNotlar : Form
    {
        public FrmNotlar()
        {
            InitializeComponent();
        }

        sqlbaglantisi bglnt = new sqlbaglantisi();

        void Listele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From TBL_NOTLAR", bglnt.baglanti());
            da.Fill(dt);
            gridControl1.DataSource = dt;
        }

        void temizle()
        {
            TxtId.Text = "";
            TxtBaslik.Text = "";
            MaskedTxtTarih.Text = "";
            TxtOlusturan.Text = "";
            TxtHitap.Text = "";
            MaskedTxtSaat.Text = "";
            RichTxtDetay.Text = "";
            TxtBaslik.Focus();
        }
        private void FrmNotlar_Load(object sender, EventArgs e)
        {
            Listele();
            temizle();

        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into TBL_NOTLAR (NOTBASLIK, NOTDETAY, NOTTARIH, NOTSAAT, " +
                "NOTOLUSTURAN, NOTHITAP) values (@p1, @p2, @p3, @p4, @p5, @p6) ", bglnt.baglanti());
            komut.Parameters.AddWithValue("@p1", TxtBaslik.Text);
            komut.Parameters.AddWithValue("@p2", RichTxtDetay.Text);
            komut.Parameters.AddWithValue("@p3", MaskedTxtTarih.Text);
            komut.Parameters.AddWithValue("@p4", MaskedTxtSaat.Text);
            komut.Parameters.AddWithValue("@p5", TxtOlusturan.Text);
            komut.Parameters.AddWithValue("@p6", TxtHitap.Text);
            komut.ExecuteNonQuery();
            bglnt.baglanti().Close();
            MessageBox.Show("Notlar kaydedildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Listele();
            temizle();

        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update TBL_NOTLAR set NOTBASLIK=@p1, NOTDETAY=@p2, NOTTARIH=@p3, NOTSAAT=@p4," +
                "NOTOLUSTURAN=@p5, NOTHITAP=@p6 where ID=@p7 ", bglnt.baglanti());
            komut.Parameters.AddWithValue("@p1", TxtBaslik.Text);
            komut.Parameters.AddWithValue("@p2", RichTxtDetay.Text);
            komut.Parameters.AddWithValue("@p3", MaskedTxtTarih.Text);
            komut.Parameters.AddWithValue("@p4", MaskedTxtSaat.Text);
            komut.Parameters.AddWithValue("@p5", TxtOlusturan.Text);
            komut.Parameters.AddWithValue("@p6", TxtHitap.Text);
            komut.Parameters.AddWithValue("@p7", TxtId.Text);
            komut.ExecuteNonQuery();
            bglnt.baglanti().Close();
            MessageBox.Show("Notlar güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Listele();
            temizle();
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {

            SqlCommand komut = new SqlCommand("Delete From TBL_NOTLAR where ID=@P1", bglnt.baglanti());
            komut.Parameters.AddWithValue("@P1", TxtId.Text);
            komut.ExecuteNonQuery();
            bglnt.baglanti().Close();
            MessageBox.Show("Not silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
                TxtBaslik.Text = dr["NOTBASLIK"].ToString();
                MaskedTxtTarih.Text = dr["NOTTARIH"].ToString();
                TxtOlusturan.Text = dr["NOTOLUSTURAN"].ToString();
                TxtHitap.Text = dr["NOTHITAP"].ToString();
                MaskedTxtSaat.Text = dr["NOTSAAT"].ToString();
                RichTxtDetay.Text = dr["NOTDETAY"].ToString();
                
            }
        }
    }
}
