namespace QL_Hoa_Hong
{
    partial class frm_Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Main));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.bnt_Dangnhap = new DevExpress.XtraBars.BarButtonItem();
            this.bnt_Dangxuat = new DevExpress.XtraBars.BarButtonItem();
            this.bnt_Nguoidung = new DevExpress.XtraBars.BarButtonItem();
            this.bnt_Nhanvien = new DevExpress.XtraBars.BarButtonItem();
            this.bnt_Nhomquyen = new DevExpress.XtraBars.BarButtonItem();
            this.bnt_Phanquyen = new DevExpress.XtraBars.BarButtonItem();
            this.bnt_donvi = new DevExpress.XtraBars.BarButtonItem();
            this.bnt_Chinhanh = new DevExpress.XtraBars.BarButtonItem();
            this.skinRibbonGalleryBarItem1 = new DevExpress.XtraBars.SkinRibbonGalleryBarItem();
            this.barHeaderItem1 = new DevExpress.XtraBars.BarHeaderItem();
            this.barStaticItem1 = new DevExpress.XtraBars.BarStaticItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup5 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.ForeColor = System.Drawing.Color.Black;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.bnt_Dangnhap,
            this.bnt_Dangxuat,
            this.bnt_Nguoidung,
            this.bnt_Nhanvien,
            this.bnt_Nhomquyen,
            this.bnt_Phanquyen,
            this.bnt_donvi,
            this.bnt_Chinhanh,
            this.skinRibbonGalleryBarItem1,
            this.barHeaderItem1,
            this.barStaticItem1});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ribbon.MaxItemId = 14;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1,
            this.ribbonPage2});
            this.ribbon.Size = new System.Drawing.Size(1393, 146);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            // 
            // bnt_Dangnhap
            // 
            this.bnt_Dangnhap.Caption = "Đăng nhập";
            this.bnt_Dangnhap.Id = 3;
            this.bnt_Dangnhap.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bnt_Dangnhap.ImageOptions.Image")));
            this.bnt_Dangnhap.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("bnt_Dangnhap.ImageOptions.LargeImage")));
            this.bnt_Dangnhap.ItemInMenuAppearance.Disabled.Font = new System.Drawing.Font("Tahoma", 10F);
            this.bnt_Dangnhap.ItemInMenuAppearance.Disabled.Options.UseFont = true;
            this.bnt_Dangnhap.ItemInMenuAppearance.Hovered.Font = new System.Drawing.Font("Tahoma", 10F);
            this.bnt_Dangnhap.ItemInMenuAppearance.Hovered.Options.UseFont = true;
            this.bnt_Dangnhap.ItemInMenuAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 10F);
            this.bnt_Dangnhap.ItemInMenuAppearance.Normal.Options.UseFont = true;
            this.bnt_Dangnhap.ItemInMenuAppearance.Pressed.Font = new System.Drawing.Font("Tahoma", 10F);
            this.bnt_Dangnhap.ItemInMenuAppearance.Pressed.Options.UseFont = true;
            this.bnt_Dangnhap.LargeWidth = 100;
            this.bnt_Dangnhap.Name = "bnt_Dangnhap";
            this.bnt_Dangnhap.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bnt_Dangnhap_ItemClick);
            // 
            // bnt_Dangxuat
            // 
            this.bnt_Dangxuat.Caption = "Đăng xuất";
            this.bnt_Dangxuat.Id = 4;
            this.bnt_Dangxuat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bnt_Dangxuat.ImageOptions.Image")));
            this.bnt_Dangxuat.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("bnt_Dangxuat.ImageOptions.LargeImage")));
            this.bnt_Dangxuat.LargeWidth = 100;
            this.bnt_Dangxuat.Name = "bnt_Dangxuat";
            // 
            // bnt_Nguoidung
            // 
            this.bnt_Nguoidung.Caption = "Người dùng";
            this.bnt_Nguoidung.Id = 5;
            this.bnt_Nguoidung.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bnt_Nguoidung.ImageOptions.Image")));
            this.bnt_Nguoidung.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("bnt_Nguoidung.ImageOptions.LargeImage")));
            this.bnt_Nguoidung.LargeWidth = 100;
            this.bnt_Nguoidung.Name = "bnt_Nguoidung";
            // 
            // bnt_Nhanvien
            // 
            this.bnt_Nhanvien.Caption = "QL Nhân viên";
            this.bnt_Nhanvien.Id = 6;
            this.bnt_Nhanvien.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bnt_Nhanvien.ImageOptions.Image")));
            this.bnt_Nhanvien.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("bnt_Nhanvien.ImageOptions.LargeImage")));
            this.bnt_Nhanvien.LargeWidth = 100;
            this.bnt_Nhanvien.Name = "bnt_Nhanvien";
            // 
            // bnt_Nhomquyen
            // 
            this.bnt_Nhomquyen.Caption = "Nhóm quyền";
            this.bnt_Nhomquyen.Id = 7;
            this.bnt_Nhomquyen.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bnt_Nhomquyen.ImageOptions.Image")));
            this.bnt_Nhomquyen.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("bnt_Nhomquyen.ImageOptions.LargeImage")));
            this.bnt_Nhomquyen.LargeWidth = 100;
            this.bnt_Nhomquyen.Name = "bnt_Nhomquyen";
            // 
            // bnt_Phanquyen
            // 
            this.bnt_Phanquyen.Caption = "Phân quyền";
            this.bnt_Phanquyen.Id = 8;
            this.bnt_Phanquyen.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bnt_Phanquyen.ImageOptions.Image")));
            this.bnt_Phanquyen.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("bnt_Phanquyen.ImageOptions.LargeImage")));
            this.bnt_Phanquyen.LargeWidth = 100;
            this.bnt_Phanquyen.Name = "bnt_Phanquyen";
            // 
            // bnt_donvi
            // 
            this.bnt_donvi.Caption = "Đơn vị";
            this.bnt_donvi.Id = 9;
            this.bnt_donvi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bnt_donvi.ImageOptions.Image")));
            this.bnt_donvi.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("bnt_donvi.ImageOptions.LargeImage")));
            this.bnt_donvi.LargeWidth = 100;
            this.bnt_donvi.Name = "bnt_donvi";
            this.bnt_donvi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bnt_donvi_ItemClick);
            // 
            // bnt_Chinhanh
            // 
            this.bnt_Chinhanh.Caption = "Chi nhánh";
            this.bnt_Chinhanh.Id = 10;
            this.bnt_Chinhanh.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bnt_Chinhanh.ImageOptions.Image")));
            this.bnt_Chinhanh.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("bnt_Chinhanh.ImageOptions.LargeImage")));
            this.bnt_Chinhanh.LargeWidth = 100;
            this.bnt_Chinhanh.Name = "bnt_Chinhanh";
            this.bnt_Chinhanh.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bnt_Chinhanh_ItemClick);
            // 
            // skinRibbonGalleryBarItem1
            // 
            this.skinRibbonGalleryBarItem1.Caption = "skinRibbonGalleryBarItem1";
            this.skinRibbonGalleryBarItem1.Id = 11;
            this.skinRibbonGalleryBarItem1.Name = "skinRibbonGalleryBarItem1";
            // 
            // barHeaderItem1
            // 
            this.barHeaderItem1.Caption = "Người dùng:";
            this.barHeaderItem1.Id = 12;
            this.barHeaderItem1.Name = "barHeaderItem1";
            // 
            // barStaticItem1
            // 
            this.barStaticItem1.Caption = "Admin";
            this.barStaticItem1.Id = 13;
            this.barStaticItem1.Name = "barStaticItem1";
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.ribbonPage1.Appearance.Options.UseFont = true;
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup2,
            this.ribbonPageGroup3,
            this.ribbonPageGroup4});
            this.ribbonPage1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ribbonPage1.ImageOptions.Image")));
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Hệ thống";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.bnt_Dangnhap);
            this.ribbonPageGroup1.ItemLinks.Add(this.bnt_Dangxuat);
            this.ribbonPageGroup1.ItemLinks.Add(this.bnt_Nguoidung);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.ShowCaptionButton = false;
            this.ribbonPageGroup1.Text = "Tài khoản cá nhân";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.bnt_Nhanvien);
            this.ribbonPageGroup2.ItemLinks.Add(this.bnt_Phanquyen);
            this.ribbonPageGroup2.ItemLinks.Add(this.bnt_Nhomquyen);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.ShowCaptionButton = false;
            this.ribbonPageGroup2.Text = "Quản lý Nhân viên";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.bnt_donvi);
            this.ribbonPageGroup3.ItemLinks.Add(this.bnt_Chinhanh);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.ShowCaptionButton = false;
            this.ribbonPageGroup3.Text = "Thông tin đơn vị";
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.ItemLinks.Add(this.skinRibbonGalleryBarItem1);
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            this.ribbonPageGroup4.ShowCaptionButton = false;
            this.ribbonPageGroup4.Text = "Giao diện";
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.ribbonPage2.Appearance.Options.UseFont = true;
            this.ribbonPage2.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup5});
            this.ribbonPage2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ribbonPage2.ImageOptions.Image")));
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = "Danh mục";
            // 
            // ribbonPageGroup5
            // 
            this.ribbonPageGroup5.Name = "ribbonPageGroup5";
            this.ribbonPageGroup5.Text = "ribbonPageGroup5";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.ItemLinks.Add(this.barHeaderItem1);
            this.ribbonStatusBar.ItemLinks.Add(this.barStaticItem1);
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 720);
            this.ribbonStatusBar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(1393, 31);
            // 
            // xtraTabbedMdiManager1
            // 
            this.xtraTabbedMdiManager1.MdiParent = this;
            // 
            // frm_Main
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1393, 751);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.Font = new System.Drawing.Font("Tahoma", 10F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frm_Main";
            this.Ribbon = this.ribbon;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "Chương trình Quản lý hoa hồng";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm_Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;
        private DevExpress.XtraBars.BarButtonItem bnt_Dangnhap;
        private DevExpress.XtraBars.BarButtonItem bnt_Dangxuat;
        private DevExpress.XtraBars.BarButtonItem bnt_Nguoidung;
        private DevExpress.XtraBars.BarButtonItem bnt_Nhanvien;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.BarButtonItem bnt_Nhomquyen;
        private DevExpress.XtraBars.BarButtonItem bnt_Phanquyen;
        private DevExpress.XtraBars.BarButtonItem bnt_donvi;
        private DevExpress.XtraBars.BarButtonItem bnt_Chinhanh;
        private DevExpress.XtraBars.SkinRibbonGalleryBarItem skinRibbonGalleryBarItem1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup5;
        private DevExpress.XtraBars.BarHeaderItem barHeaderItem1;
        private DevExpress.XtraBars.BarStaticItem barStaticItem1;
    }
}