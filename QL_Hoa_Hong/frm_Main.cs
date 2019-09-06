using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraBars;

namespace QL_Hoa_Hong
{
    public partial class frm_Main : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public frm_Main()
        {
            InitializeComponent();
           
        }
        private Form kiemtraform(Type ftype)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.GetType() == ftype)
                {
                    return f;
                }
            }
            return null;
        }
         //Form frm = kiemtraform(typeof(XtraForm2));
         //   if (frm == null)
         //   {
         //       XtraForm2 forms = new XtraForm2();
         //       forms.MdiParent = this;
         //       forms.Show();
         //   }
         //   else
         //   {
         //       frm.Activate();
         //   }

        private void frm_Main_Load(object sender, EventArgs e)
        {

        }

        private void bnt_Dangnhap_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = kiemtraform(typeof(frm_New_hoadon));
            if (frm == null)
            {
                frm_New_hoadon forms = new frm_New_hoadon();
                forms.MdiParent = this;
                forms.Show();
            }
            else
            {
                frm.Activate();
            }
        }

        private void bnt_donvi_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = kiemtraform(typeof(frm_Thongtindonvi));
            if (frm == null)
            {
                frm_Thongtindonvi forms = new frm_Thongtindonvi();
                forms.MdiParent = this;
                forms.Show();
            }
            else
            {
                frm.Activate();
            }
        }

        private void bnt_Chinhanh_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = kiemtraform(typeof(frm_QLChinhanh));
            if (frm == null)
            {
                frm_QLChinhanh forms = new frm_QLChinhanh();
                forms.MdiParent = this;
                forms.Show();
            }
            else
            {
                frm.Activate();
            }
        }

        
    }
}