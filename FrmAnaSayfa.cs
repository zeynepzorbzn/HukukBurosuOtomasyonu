using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HukukBurosuOtomasyon
{
    public partial class FrmAnaSayfa : DevExpress.XtraEditors.XtraForm
    {
        public FrmAnaSayfa()
        {
            InitializeComponent();
        }

        private void FrmAnaSayfa_Load(object sender, EventArgs e)
        {

        }

        FrmKisilerr fr;
        private void simpleButton2_Click(object sender, EventArgs e)
        {
            if (fr == null)
            {
                fr = new FrmKisilerr();
                
                fr.Show();
              //  this.Hide();
            }
        }

        FrmDavaDurusma fr1;
        private void simpleButton3_Click(object sender, EventArgs e)
        {
            if (fr1 == null)
            {
                fr1 = new FrmDavaDurusma();
               
                fr1.Show();
               // this.Hide();
            }
        }

        FrmSekreterlik fr2;
        private void simpleButton4_Click(object sender, EventArgs e)
        {
            if (fr2 == null)
            {
                fr2 = new FrmSekreterlik();

                fr2.Show();
                // this.Hide();
            }


        }

        FrmGiderlerveOdemeler fr3;
        private void simpleButton5_Click(object sender, EventArgs e)
        {
            if (fr3 == null)
            {
                fr3 = new FrmGiderlerveOdemeler();

                fr3.Show();
                // this.Hide();
            }
        }

        FrmNotlarveAyarlar fr4;
        private void simpleButton6_Click(object sender, EventArgs e)
        {
            if (fr4 == null)
            {
                fr4 = new FrmNotlarveAyarlar();

                fr4.Show();
                // this.Hide();
            }
        }
    }
}
