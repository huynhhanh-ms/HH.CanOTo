// Decompiled with JetBrains decompiler
// Type: Xtra.Utility.TiengViet.CustomizationControl
// Assembly: Xtra.Utility, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F0A554BF-0B1B-420F-A5E2-9214C58F15B4
// Assembly location: C:\Project\HH.CanOTo\references\CAN TRI VIET\Xtra.Utility.dll

using DevExpress.XtraBars.Customization;
using DevExpress.XtraEditors;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Xtra.Utility.TiengViet
{
  internal class CustomizationControl : CustomizationControl
  {
    public CustomizationControl() => this.InitializeComponent();

    private void InitializeComponent()
    {
      ((Control) this.tpOptions).SuspendLayout();
      ((Control) this.tpCommands).SuspendLayout();
      ((Control) this.tpToolbars).SuspendLayout();
      ((ISupportInitialize) this.toolBarsList).BeginInit();
      ((ISupportInitialize) this.lbCommands).BeginInit();
      ((ISupportInitialize) this.lbCategories).BeginInit();
      ((ISupportInitialize) this.cbOptionsShowFullMenus.Properties).BeginInit();
      ((ISupportInitialize) this.cbOptions_showFullMenusAfterDelay.Properties).BeginInit();
      ((ISupportInitialize) this.cbOptions_showTips.Properties).BeginInit();
      ((ISupportInitialize) this.cbOptions_ShowShortcutInTips.Properties).BeginInit();
      ((ISupportInitialize) this.tabControl).BeginInit();
      ((Control) this.tabControl).SuspendLayout();
      ((ISupportInitialize) this.tbNBDlgName.Properties).BeginInit();
      this.pnlNBDlg.SuspendLayout();
      ((ISupportInitialize) this.cbOptions_largeIcons.Properties).BeginInit();
      ((ISupportInitialize) this.cbOptions_MenuAnimation.Properties).BeginInit();
      ((Control) this).SuspendLayout();
      ((Control) this.btClose).Text = "Đóng";
      this.tpOptions.Size = new Size(354, 245);
      ((Control) this.tpOptions).Text = "Tùy chọn";
      ((Control) this.tpCommands).Text = "Chức năng";
      ((Control) this.tpToolbars).Text = "Thanh công cụ";
      ((Control) this.btNewBar).Text = "&Tạo mới";
      ((Control) this.btDeleteBar).Text = "Xóa";
      ((BaseStyleControl) this.lbCommands).Appearance.BackColor = SystemColors.Window;
      ((BaseStyleControl) this.lbCommands).Appearance.Options.UseBackColor = true;
      this.cbOptionsShowFullMenus.Properties.Caption = "Thường xuyên hiện đầy đủ chức năng";
      this.cbOptions_showFullMenusAfterDelay.Properties.Caption = "Hiển thị đầy đủ các chức năng sau khi vẽ lại";
      ((Control) this.btOptions_Reset).Text = "Khởi tạo lại tùy chỉnh";
      this.cbOptions_showTips.Properties.Caption = "Hiển thị Screen&Tips trên thanh công cụ";
      this.cbOptions_ShowShortcutInTips.Properties.Caption = "Hiển thị phím tắt trên ScreenTips";
      this.lbDescCaption.Size = new Size(34, 13);
      this.lbDescCaption.Text = "Mô tả";
      this.lbOptions_Other.Size = new Size(81, 13);
      this.lbOptions_Other.Text = "Tùy chỉnh khác";
      this.lbOptions_PCaption.Size = new Size(140, 13);
      this.lbOptions_PCaption.Text = "Cá nhân hóa thanh công cụ";
      this.tabControl.SelectedTabPage = this.tpOptions;
      ((Control) this.tabControl).Click += new EventHandler(this.tabControl_Click);
      this.lbCategoriesCaption.Size = new Size(80, 13);
      this.lbCategoriesCaption.Text = "Nhóm công cụ:";
      this.lbCommandsCaption.Text = "Chức năng:";
      ((Control) this.btResetBar).Text = "Tạo lại";
      ((Control) this.btRenameBar).Text = "Đổi tên";
      this.cbOptions_largeIcons.Properties.Caption = "Biểu tượng lớn";
      this.lbOptions_MenuAnimation.Size = new Size(125, 13);
      this.lbOptions_MenuAnimation.Text = "Hiệu ứng thanh công cụ:";
      ((Control) this.cbOptions_MenuAnimation).Location = new Point(147, 213);
      ((Control) this).Name = nameof (CustomizationControl);
      ((UserControl) this).Load += new EventHandler(this.CustomizationControl_Load);
      ((Control) this.tpOptions).ResumeLayout(false);
      ((Control) this.tpOptions).PerformLayout();
      ((Control) this.tpCommands).ResumeLayout(false);
      ((Control) this.tpCommands).PerformLayout();
      ((Control) this.tpToolbars).ResumeLayout(false);
      ((Control) this.tpToolbars).PerformLayout();
      ((ISupportInitialize) this.toolBarsList).EndInit();
      ((ISupportInitialize) this.lbCommands).EndInit();
      ((ISupportInitialize) this.lbCategories).EndInit();
      ((ISupportInitialize) this.cbOptionsShowFullMenus.Properties).EndInit();
      ((ISupportInitialize) this.cbOptions_showFullMenusAfterDelay.Properties).EndInit();
      ((ISupportInitialize) this.cbOptions_showTips.Properties).EndInit();
      ((ISupportInitialize) this.cbOptions_ShowShortcutInTips.Properties).EndInit();
      ((ISupportInitialize) this.tabControl).EndInit();
      ((Control) this.tabControl).ResumeLayout(false);
      ((ISupportInitialize) this.tbNBDlgName.Properties).EndInit();
      this.pnlNBDlg.ResumeLayout(false);
      ((ISupportInitialize) this.cbOptions_largeIcons.Properties).EndInit();
      ((ISupportInitialize) this.cbOptions_MenuAnimation.Properties).EndInit();
      ((Control) this).ResumeLayout(false);
    }

    private void tabControl_Click(object sender, EventArgs e)
    {
    }

    private void CustomizationControl_Load(object sender, EventArgs e)
    {
    }
  }
}
