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
    public partial class FrmAdmin : DevExpress.XtraEditors.XtraForm
    {
        public FrmAdmin()
        {
            InitializeComponent();
        }

        sqlbaglantisi bglnt = new sqlbaglantisi();


      

        private void simpleButton1_MouseHover(object sender, EventArgs e)
        {
            BtnGirisYap.BackColor = Color.BurlyWood;
        }

        private void simpleButton1_MouseLeave(object sender, EventArgs e)
        {
            BtnGirisYap.BackColor = Color.Sienna;
        }

        private void FrmAdmin_Load(object sender, EventArgs e)
        {

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Select * from TBL_ADMIN where KullaniciAd=@p1 and Sifre=@p2",
                bglnt.baglanti());
            komut.Parameters.AddWithValue("@p1", TxtKullaniciAdi.Text);
            komut.Parameters.AddWithValue("@p2", TxtSifre.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                FrmAnaSayfa fr = new FrmAnaSayfa();
                fr.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı Kullanıcı Adı veya Şifre", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            bglnt.baglanti().Close(); 
        }
    }
}
