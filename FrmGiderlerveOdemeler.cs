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
    public partial class FrmGiderlerveOdemeler : Form
    {
        public FrmGiderlerveOdemeler()
        {
            InitializeComponent();
        }

        

        private void FrmGiderlerveOdemeler_Load(object sender, EventArgs e)
        {

        }
        FrmGiderler fr;
        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr == null)
            {
                fr = new FrmGiderler();
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

        FrmOdemeler fr2;
        private void barButtonItem5_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr2 == null)
            {
                fr2 = new FrmOdemeler();
                fr2.MdiParent = this;
                fr2.Show();
            }

        }
        FrmNotlarveAyarlar fr3;
        private void barButtonItem13_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr3 == null)
            {
                fr3 = new FrmNotlarveAyarlar();
                fr3.Show();

            }
        }
    }
}
