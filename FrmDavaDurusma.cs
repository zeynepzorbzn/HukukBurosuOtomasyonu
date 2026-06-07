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
    public partial class FrmDavaDurusma : DevExpress.XtraEditors.XtraForm
    {
        public FrmDavaDurusma()
        {
            InitializeComponent();
        }
       
        FrmDavalar fr; 
        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr == null)
            {
                fr = new FrmDavalar();
                fr.MdiParent = this;
                fr.Show();
            }

        }

        FrmDurusmalar fr1;
        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr == null)
            {
                fr1= new FrmDurusmalar();
                fr1.MdiParent = this;
                fr1.Show();
            }

        } 
        private void FrmDavaDurusma_Load(object sender, EventArgs e)
        {

        }

        FrmAnaSayfa fr2;
        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr2 == null)
            {
                fr2 = new FrmAnaSayfa();
                fr2.Show();

            }
        }


        FrmNotlarveAyarlar fr3;
        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr3 == null)
            {
                fr3 = new FrmNotlarveAyarlar();
                fr3.Show();

            }
        }
    }
}
