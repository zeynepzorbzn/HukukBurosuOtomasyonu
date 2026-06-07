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
    public partial class FrmKisilerr : DevExpress.XtraEditors.XtraForm
    {
        public FrmKisilerr()
        {
            InitializeComponent();
        }

        FrmAvukatlar fr;
        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr == null)
            {
                fr = new FrmAvukatlar();
                fr.MdiParent = this;
                fr.Show();
            }
        }

        FrmMuvekkiller fr2;
        private void barButtonItem5_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr2 == null)
            {
                fr2 = new FrmMuvekkiller();
                fr2.MdiParent = this;
                fr2.Show();
            }

        }

        FrmAnaSayfa fr3;
        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr3 == null)
            {
                fr3 = new FrmAnaSayfa();
                fr3.Show();

            }
        }

        FrmNotlarveAyarlar fr4;
        private void barButtonItem13_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr4 == null)
            {
                fr4 = new FrmNotlarveAyarlar();
                fr4.Show();

            }
        }

        private void FrmKisilerr_Load(object sender, EventArgs e)
        {

        }
    }
}
