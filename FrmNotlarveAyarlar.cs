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
    public partial class FrmNotlarveAyarlar : DevExpress.XtraEditors.XtraForm
    {
        public FrmNotlarveAyarlar()
        {
            InitializeComponent();
        }


        FrmNotlar fr;
        private void barButtonItem13_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            if (fr == null)
            {
                fr = new FrmNotlar();
                fr.MdiParent = this;
                fr.Show();
            }
        }

        FrmAnaSayfa fr1;
        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr1 == null)
            {
                fr1 = new FrmAnaSayfa();

                fr1.Show();
            }
        }


        FrmAyarlar fr2;
        private void barButtonItem14_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            if (fr2 == null)
            {
                fr2 = new FrmAyarlar();

                fr2.Show();
            }
        }

        private void FrmNotlarveAyarlar_Load(object sender, EventArgs e)
        {

        }
    }
}
