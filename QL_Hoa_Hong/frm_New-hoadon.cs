using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
namespace QL_Hoa_Hong
{
    public partial class frm_New_hoadon : DevExpress.XtraEditors.XtraForm
    {
        public frm_New_hoadon()
        {
            InitializeComponent();
        }

        private void frm_New_hoadon_Load(object sender, EventArgs e)
        {
            //textEdit4.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
         //   textEdit4.Properties.Mask.EditMask = ""; //Use the default pattern for decimal values 
            txt_TongtienHD.Properties.Mask.UseMaskAsDisplayFormat = true;
          //  textEdit4.Properties.Appearance.TextOptions.HAlignment = HorzAlignment.Far;
        }
       
        private void lookUpEdit1_EditValueChanged(object sender, EventArgs e)
        {
            
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            txt_TongtienHD.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            MessageBox.Show(txt_TongtienHD.Text);
        }

        private void but_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
       
    }
}