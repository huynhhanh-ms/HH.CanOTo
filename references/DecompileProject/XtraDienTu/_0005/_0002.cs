// Decompiled with JetBrains decompiler
// Type: .
// Assembly: XtraDienTu, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8F0E94B6-F573-4BC5-92AB-CE54C0CE94F8
// Assembly location: C:\Project\HH.CanOTo\references\CAN TRI VIET\ViNaCaFe\ViNaCaFe\Update VINA CAPHE 2014-11-24\XtraDienTu.exe

using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Repository;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Objects;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Xtra.Data;

namespace \u0005
{
  internal class \u0002 : XtraForm
  {
    private IContainer \u0001;
    private LabelControl \u0002;
    private LabelControl \u0003;
    private DateEdit \u0004;
    private DateEdit \u0005;
    private TextEdit \u0006;
    private SimpleButton \u0007;
    private SimpleButton \u0008;
    private SimpleButton \u000E;
    private SimpleButton \u000F;
    private PanelControl \u0010;
    private GroupControl \u0011;
    private GridControl \u0012;
    private GridView \u0013;
    private BindingSource \u0014;
    private GridColumn \u0015;
    private GridColumn \u0016;
    private GridColumn \u0017;
    private GridColumn \u0018;
    private GridColumn \u0019;
    private GridColumn \u001A;
    private GridColumn \u001B;
    private GridColumn \u001C;
    private GridColumn \u001D;
    private GridColumn \u001E;
    private GridColumn \u001F;
    private GridColumn \u007F;
    private LabelControl \u0080;
    private LabelControl \u0081;
    private LabelControl \u0082;
    private SearchLookUpEdit \u0083;
    private GridView \u0084;
    private SearchLookUpEdit \u0086;
    private GridView \u0087;
    private BindingSource \u0088;
    private GridColumn \u0089;
    private GridColumn \u008A;
    private BindingSource \u008B;
    private GridColumn \u008C;
    private GridColumn \u008D;
    private TextEdit \u008E;
    private LabelControl \u008F;
    private GridColumn \u0090;
    private CanDienTuEntities \u0091;

    virtual void XtraForm.\u0001(bool _param1)
    {
      bool flag;
      try
      {
        do
        {
          if (_param1)
            goto label_10;
label_1:
          int num1 = 1;
          goto label_11;
label_4:
          int num2;
          if (num2 == 0)
          {
            if (true)
              this.\u0001.Dispose();
            else
              continue;
          }
          else
            goto label_7;
label_6:
          if (false)
            goto label_1;
label_7:
          if (true)
          {
            // ISSUE: explicit non-virtual call
            __nonvirtual (((XtraForm) this).Dispose(_param1));
            continue;
          }
          goto label_6;
label_10:
          int num3 = this.\u0001 == null ? 1 : 0;
          if (false)
          {
            num2 = num3;
            goto label_4;
          }
          else
            num1 = num3;
label_11:
          flag = num1 != 0;
          num2 = flag ? 1 : 0;
          goto label_4;
        }
        while (false);
      }
      catch (Exception ex)
      {
        // ISSUE: variable of a boxed type
        __Boxed<bool> local1 = (ValueType) flag;
        // ISSUE: variable of a boxed type
        __Boxed<bool> local2 = (ValueType) _param1;
        \u0005.\u0008.\u0001(ex, (object) local1, (object) this, (object) local2);
        throw;
      }
    }

    private void \u0001()
    {
      EditorButton[] editorButtonArray1;
      GridColumn[] gridColumnArray1;
      BaseView[] baseViewArray1;
      try
      {
        this.\u0001 = (IContainer) new System.ComponentModel.Container();
        this.\u0002 = new LabelControl();
        this.\u0003 = new LabelControl();
        this.\u0004 = new DateEdit();
        this.\u0005 = new DateEdit();
        this.\u0006 = new TextEdit();
        this.\u0007 = new SimpleButton();
        this.\u0008 = new SimpleButton();
        this.\u000E = new SimpleButton();
        this.\u000F = new SimpleButton();
        this.\u0010 = new PanelControl();
        this.\u0011 = new GroupControl();
        this.\u0086 = new SearchLookUpEdit();
        this.\u0088 = new BindingSource(this.\u0001);
        this.\u0087 = new GridView();
        this.\u0089 = new GridColumn();
        this.\u008A = new GridColumn();
        this.\u0083 = new SearchLookUpEdit();
        this.\u008B = new BindingSource(this.\u0001);
        this.\u0084 = new GridView();
        this.\u008C = new GridColumn();
        this.\u008D = new GridColumn();
        this.\u0081 = new LabelControl();
        this.\u008E = new TextEdit();
        this.\u008F = new LabelControl();
        this.\u0082 = new LabelControl();
        this.\u0080 = new LabelControl();
        this.\u0012 = new GridControl();
        this.\u0014 = new BindingSource(this.\u0001);
        this.\u0013 = new GridView();
        this.\u0090 = new GridColumn();
        this.\u0015 = new GridColumn();
        this.\u0016 = new GridColumn();
        this.\u0017 = new GridColumn();
        this.\u0018 = new GridColumn();
        this.\u0019 = new GridColumn();
        this.\u001A = new GridColumn();
        this.\u001B = new GridColumn();
        this.\u001C = new GridColumn();
        this.\u001D = new GridColumn();
        this.\u001E = new GridColumn();
        this.\u001F = new GridColumn();
        this.\u007F = new GridColumn();
        this.\u0004.Properties.VistaTimeProperties.BeginInit();
        this.\u0004.Properties.BeginInit();
        this.\u0005.Properties.VistaTimeProperties.BeginInit();
        this.\u0005.Properties.BeginInit();
        this.\u0006.Properties.BeginInit();
        this.\u0010.BeginInit();
        this.\u0010.SuspendLayout();
        this.\u0011.BeginInit();
        this.\u0011.SuspendLayout();
        this.\u0086.Properties.BeginInit();
        ((ISupportInitialize) this.\u0088).BeginInit();
        this.\u0087.BeginInit();
        this.\u0083.Properties.BeginInit();
        ((ISupportInitialize) this.\u008B).BeginInit();
        this.\u0084.BeginInit();
        this.\u008E.Properties.BeginInit();
        this.\u0012.BeginInit();
        ((ISupportInitialize) this.\u0014).BeginInit();
        this.\u0013.BeginInit();
        this.SuspendLayout();
        this.\u0002.Location = new Point(9, 8);
        this.\u0002.Name = \u0005.\u0004.\u0001(109);
        this.\u0002.Size = new Size(41, 13);
        this.\u0002.TabIndex = 0;
        this.\u0002.Text = \u0005.\u0004.\u0001(1296);
        this.\u0003.Location = new Point(180, 8);
        this.\u0003.Name = \u0005.\u0004.\u0001(234);
        this.\u0003.Size = new Size(48, 13);
        this.\u0003.TabIndex = 0;
        this.\u0003.Text = \u0005.\u0004.\u0001(1249);
        this.\u0004.EditValue = (object) null;
        this.\u0004.Location = new Point(56, 5);
        this.\u0004.Name = \u0005.\u0004.\u0001(1382);
        EditorButtonCollection buttons1 = this.\u0004.Properties.Buttons;
        editorButtonArray1 = new EditorButton[1]
        {
          new EditorButton(ButtonPredefines.Combo)
        };
        EditorButton[] buttons2 = editorButtonArray1;
        buttons1.AddRange(buttons2);
        EditorButtonCollection buttons3 = this.\u0004.Properties.VistaTimeProperties.Buttons;
        editorButtonArray1 = new EditorButton[1]
        {
          new EditorButton()
        };
        EditorButton[] buttons4 = editorButtonArray1;
        buttons3.AddRange(buttons4);
        this.\u0004.Size = new Size(109, 20);
        this.\u0004.TabIndex = 1;
        this.\u0005.EditValue = (object) null;
        this.\u0005.Location = new Point(234, 5);
        this.\u0005.Name = \u0005.\u0004.\u0001(1369);
        EditorButtonCollection buttons5 = this.\u0005.Properties.Buttons;
        editorButtonArray1 = new EditorButton[1]
        {
          new EditorButton(ButtonPredefines.Combo)
        };
        EditorButton[] buttons6 = editorButtonArray1;
        buttons5.AddRange(buttons6);
        EditorButtonCollection buttons7 = this.\u0005.Properties.VistaTimeProperties.Buttons;
        editorButtonArray1 = new EditorButton[1]
        {
          new EditorButton()
        };
        EditorButton[] buttons8 = editorButtonArray1;
        buttons7.AddRange(buttons8);
        this.\u0005.Size = new Size(109, 20);
        this.\u0005.TabIndex = 1;
        this.\u0006.Location = new Point(47, 25);
        this.\u0006.Name = \u0005.\u0004.\u0001(5041);
        this.\u0006.Size = new Size(119, 20);
        this.\u0006.TabIndex = 3;
        this.\u0007.Location = new Point(360, 5);
        this.\u0007.LookAndFeel.SkinName = \u0005.\u0004.\u0001(160);
        this.\u0007.LookAndFeel.UseDefaultLookAndFeel = false;
        this.\u0007.Name = \u0005.\u0004.\u0001(5054);
        this.\u0007.Size = new Size(75, 23);
        this.\u0007.TabIndex = 4;
        this.\u0007.Text = \u0005.\u0004.\u0001(5063);
        this.\u0008.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        this.\u0008.Location = new Point(1023, 5);
        this.\u0008.LookAndFeel.SkinName = \u0005.\u0004.\u0001(160);
        this.\u0008.LookAndFeel.UseDefaultLookAndFeel = false;
        this.\u0008.Name = \u0005.\u0004.\u0001(5068);
        this.\u0008.Size = new Size(75, 23);
        this.\u0008.TabIndex = 4;
        this.\u0008.Text = \u0005.\u0004.\u0001(5077);
        this.\u000E.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        this.\u000E.Location = new Point(1104, 5);
        this.\u000E.LookAndFeel.SkinName = \u0005.\u0004.\u0001(160);
        this.\u000E.LookAndFeel.UseDefaultLookAndFeel = false;
        this.\u000E.Name = \u0005.\u0004.\u0001(5082);
        this.\u000E.Size = new Size(75, 23);
        this.\u000E.TabIndex = 4;
        this.\u000E.Text = \u0005.\u0004.\u0001(5095);
        this.\u000F.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        this.\u000F.Location = new Point(1185, 5);
        this.\u000F.LookAndFeel.SkinName = \u0005.\u0004.\u0001(160);
        this.\u000F.LookAndFeel.UseDefaultLookAndFeel = false;
        this.\u000F.Name = \u0005.\u0004.\u0001(194);
        this.\u000F.Size = new Size(75, 23);
        this.\u000F.TabIndex = 4;
        this.\u000F.Text = \u0005.\u0004.\u0001(207);
        this.\u0010.Controls.Add((Control) this.\u0011);
        this.\u0010.Controls.Add((Control) this.\u0005);
        this.\u0010.Controls.Add((Control) this.\u000F);
        this.\u0010.Controls.Add((Control) this.\u0002);
        this.\u0010.Controls.Add((Control) this.\u000E);
        this.\u0010.Controls.Add((Control) this.\u0003);
        this.\u0010.Controls.Add((Control) this.\u0008);
        this.\u0010.Controls.Add((Control) this.\u0004);
        this.\u0010.Controls.Add((Control) this.\u0007);
        this.\u0010.Dock = DockStyle.Top;
        this.\u0010.Location = new Point(0, 0);
        this.\u0010.Name = \u0005.\u0004.\u0001(173);
        this.\u0010.Size = new Size(1265, 92);
        this.\u0010.TabIndex = 5;
        this.\u0011.Controls.Add((Control) this.\u0086);
        this.\u0011.Controls.Add((Control) this.\u0083);
        this.\u0011.Controls.Add((Control) this.\u0081);
        this.\u0011.Controls.Add((Control) this.\u008E);
        this.\u0011.Controls.Add((Control) this.\u0006);
        this.\u0011.Controls.Add((Control) this.\u008F);
        this.\u0011.Controls.Add((Control) this.\u0082);
        this.\u0011.Controls.Add((Control) this.\u0080);
        this.\u0011.Location = new Point(9, 34);
        this.\u0011.LookAndFeel.SkinName = \u0005.\u0004.\u0001(160);
        this.\u0011.LookAndFeel.UseDefaultLookAndFeel = false;
        this.\u0011.Name = \u0005.\u0004.\u0001(3104);
        this.\u0011.Size = new Size(1251, 53);
        this.\u0011.TabIndex = 5;
        this.\u0011.Text = \u0005.\u0004.\u0001(5104);
        this.\u0086.Location = new Point(263, 24);
        this.\u0086.Name = \u0005.\u0004.\u0001(5129);
        EditorButtonCollection buttons9 = this.\u0086.Properties.Buttons;
        editorButtonArray1 = new EditorButton[1]
        {
          new EditorButton(ButtonPredefines.Combo)
        };
        EditorButton[] buttons10 = editorButtonArray1;
        buttons9.AddRange(buttons10);
        this.\u0086.Properties.DataSource = (object) this.\u0088;
        this.\u0086.Properties.DisplayMember = \u0005.\u0004.\u0001(2192);
        this.\u0086.Properties.NullText = \u0005.\u0004.\u0001(2246);
        this.\u0086.Properties.ValueMember = \u0005.\u0004.\u0001(1555);
        this.\u0086.Properties.View = this.\u0087;
        this.\u0086.Size = new Size(138, 20);
        this.\u0086.TabIndex = 5;
        this.\u0088.DataSource = (object) typeof (KhachHang);
        GridColumnCollection columns1 = this.\u0087.Columns;
        gridColumnArray1 = new GridColumn[2]
        {
          this.\u0089,
          this.\u008A
        };
        GridColumn[] columns2 = gridColumnArray1;
        columns1.AddRange(columns2);
        this.\u0087.FocusRectStyle = DrawFocusRectStyle.RowFocus;
        this.\u0087.Name = \u0005.\u0004.\u0001(2855);
        this.\u0087.OptionsSelection.EnableAppearanceFocusedCell = false;
        this.\u0087.OptionsView.ShowGroupPanel = false;
        this.\u0089.FieldName = \u0005.\u0004.\u0001(2192);
        this.\u0089.Name = \u0005.\u0004.\u0001(2799);
        this.\u0089.Visible = true;
        this.\u0089.VisibleIndex = 0;
        this.\u008A.FieldName = \u0005.\u0004.\u0001(2375);
        this.\u008A.Name = \u0005.\u0004.\u0001(2821);
        this.\u008A.Visible = true;
        this.\u008A.VisibleIndex = 1;
        this.\u0083.Location = new Point(713, 24);
        this.\u0083.Name = \u0005.\u0004.\u0001(5158);
        EditorButtonCollection buttons11 = this.\u0083.Properties.Buttons;
        editorButtonArray1 = new EditorButton[1]
        {
          new EditorButton(ButtonPredefines.Combo)
        };
        EditorButton[] buttons12 = editorButtonArray1;
        buttons11.AddRange(buttons12);
        this.\u0083.Properties.DataSource = (object) this.\u008B;
        this.\u0083.Properties.DisplayMember = \u0005.\u0004.\u0001(2192);
        this.\u0083.Properties.NullText = \u0005.\u0004.\u0001(5183);
        this.\u0083.Properties.ValueMember = \u0005.\u0004.\u0001(1555);
        this.\u0083.Properties.View = this.\u0084;
        this.\u0083.Size = new Size(169, 20);
        this.\u0083.TabIndex = 4;
        this.\u008B.DataSource = (object) typeof (HangHoa);
        GridColumnCollection columns3 = this.\u0084.Columns;
        gridColumnArray1 = new GridColumn[2]
        {
          this.\u008C,
          this.\u008D
        };
        GridColumn[] columns4 = gridColumnArray1;
        columns3.AddRange(columns4);
        this.\u0084.FocusRectStyle = DrawFocusRectStyle.RowFocus;
        this.\u0084.Name = \u0005.\u0004.\u0001(5208);
        this.\u0084.OptionsSelection.EnableAppearanceFocusedCell = false;
        this.\u0084.OptionsView.ShowGroupPanel = false;
        this.\u008C.FieldName = \u0005.\u0004.\u0001(2192);
        this.\u008C.Name = \u0005.\u0004.\u0001(2868);
        this.\u008C.Visible = true;
        this.\u008C.VisibleIndex = 0;
        this.\u008D.FieldName = \u0005.\u0004.\u0001(2375);
        this.\u008D.Name = \u0005.\u0004.\u0001(2881);
        this.\u008D.Visible = true;
        this.\u008D.VisibleIndex = 1;
        this.\u0081.Location = new Point(661, 28);
        this.\u0081.Name = \u0005.\u0004.\u0001(399);
        this.\u0081.Size = new Size(46, 13);
        this.\u0081.TabIndex = 0;
        this.\u0081.Text = \u0005.\u0004.\u0001(5237);
        this.\u008E.Location = new Point(500, 24);
        this.\u008E.Name = \u0005.\u0004.\u0001(5254);
        this.\u008E.Size = new Size(155, 20);
        this.\u008E.TabIndex = 3;
        this.\u008F.Location = new Point(416, 28);
        this.\u008F.Name = \u0005.\u0004.\u0001(462);
        this.\u008F.Size = new Size(78, 13);
        this.\u008F.TabIndex = 0;
        this.\u008F.Text = \u0005.\u0004.\u0001(2350);
        this.\u0082.Location = new Point(183, 28);
        this.\u0082.Name = \u0005.\u0004.\u0001(348);
        this.\u0082.Size = new Size(74, 13);
        this.\u0082.TabIndex = 0;
        this.\u0082.Text = \u0005.\u0004.\u0001(5267);
        this.\u0080.Location = new Point(14, 28);
        this.\u0080.Name = \u0005.\u0004.\u0001(289);
        this.\u0080.Size = new Size(27, 13);
        this.\u0080.TabIndex = 0;
        this.\u0080.Text = \u0005.\u0004.\u0001(1604);
        this.\u0012.DataSource = (object) this.\u0014;
        this.\u0012.Dock = DockStyle.Fill;
        this.\u0012.Location = new Point(0, 92);
        this.\u0012.MainView = (BaseView) this.\u0013;
        this.\u0012.Name = \u0005.\u0004.\u0001(1474);
        this.\u0012.Size = new Size(1265, 395);
        this.\u0012.TabIndex = 6;
        ViewRepositoryCollection viewCollection = this.\u0012.ViewCollection;
        baseViewArray1 = new BaseView[1]
        {
          (BaseView) this.\u0013
        };
        BaseView[] views = baseViewArray1;
        viewCollection.AddRange(views);
        this.\u0014.DataSource = (object) typeof (XeHang);
        GridColumnCollection columns5 = this.\u0013.Columns;
        gridColumnArray1 = new GridColumn[13]
        {
          this.\u0090,
          this.\u0015,
          this.\u0016,
          this.\u0017,
          this.\u0018,
          this.\u0019,
          this.\u001A,
          this.\u001B,
          this.\u001C,
          this.\u001D,
          this.\u001E,
          this.\u001F,
          this.\u007F
        };
        GridColumn[] columns6 = gridColumnArray1;
        columns5.AddRange(columns6);
        this.\u0013.GridControl = this.\u0012;
        this.\u0013.Name = \u0005.\u0004.\u0001(1491);
        this.\u0013.OptionsBehavior.Editable = false;
        this.\u0013.OptionsCustomization.AllowFilter = false;
        this.\u0013.OptionsCustomization.AllowSort = false;
        this.\u0013.OptionsView.ColumnAutoWidth = false;
        this.\u0013.OptionsView.EnableAppearanceEvenRow = true;
        this.\u0013.OptionsView.EnableAppearanceOddRow = true;
        this.\u0013.OptionsView.ShowGroupPanel = false;
        this.\u0090.Caption = \u0005.\u0004.\u0001(5292);
        this.\u0090.FieldName = \u0005.\u0004.\u0001(1525);
        this.\u0090.Name = \u0005.\u0004.\u0001(5309);
        this.\u0090.Visible = true;
        this.\u0090.VisibleIndex = 4;
        this.\u0090.Width = 122;
        this.\u0015.Caption = \u0005.\u0004.\u0001(2573);
        this.\u0015.DisplayFormat.FormatString = \u0005.\u0004.\u0001(5326);
        this.\u0015.DisplayFormat.FormatType = FormatType.Numeric;
        this.\u0015.FieldName = \u0005.\u0004.\u0001(2599);
        this.\u0015.Name = \u0005.\u0004.\u0001(2612);
        this.\u0015.OptionsColumn.ReadOnly = true;
        this.\u0015.Visible = true;
        this.\u0015.VisibleIndex = 11;
        this.\u0015.Width = 115;
        this.\u0016.Caption = \u0005.\u0004.\u0001(5335);
        this.\u0016.FieldName = \u0005.\u0004.\u0001(1574);
        this.\u0016.Name = \u0005.\u0004.\u0001(1587);
        this.\u0016.Visible = true;
        this.\u0016.VisibleIndex = 0;
        this.\u0016.Width = 57;
        this.\u0017.Caption = \u0005.\u0004.\u0001(1604);
        this.\u0017.FieldName = \u0005.\u0004.\u0001(1617);
        this.\u0017.Name = \u0005.\u0004.\u0001(1626);
        this.\u0017.Visible = true;
        this.\u0017.VisibleIndex = 2;
        this.\u0017.Width = 86;
        this.\u0018.Caption = \u0005.\u0004.\u0001(1639);
        this.\u0018.FieldName = \u0005.\u0004.\u0001(1661);
        this.\u0018.Name = \u0005.\u0004.\u0001(1674);
        this.\u0018.Visible = true;
        this.\u0018.VisibleIndex = 5;
        this.\u0019.Caption = \u0005.\u0004.\u0001(1691);
        this.\u0019.FieldName = \u0005.\u0004.\u0001(1700);
        this.\u0019.Name = \u0005.\u0004.\u0001(1709);
        this.\u0019.Visible = true;
        this.\u0019.VisibleIndex = 6;
        this.\u0019.Width = 69;
        this.\u001A.Caption = \u0005.\u0004.\u0001(1722);
        this.\u001A.FieldName = \u0005.\u0004.\u0001(1727);
        this.\u001A.Name = \u0005.\u0004.\u0001(1740);
        this.\u001A.Visible = true;
        this.\u001A.VisibleIndex = 8;
        this.\u001B.Caption = \u0005.\u0004.\u0001(848);
        this.\u001B.FieldName = \u0005.\u0004.\u0001(1825);
        this.\u001B.Name = \u0005.\u0004.\u0001(1834);
        this.\u001B.Visible = true;
        this.\u001B.VisibleIndex = 7;
        this.\u001C.FieldName = \u0005.\u0004.\u0001(1868);
        this.\u001C.Name = \u0005.\u0004.\u0001(1881);
        this.\u001D.Caption = \u0005.\u0004.\u0001(5348);
        this.\u001D.FieldName = \u0005.\u0004.\u0001(1997);
        this.\u001D.Name = \u0005.\u0004.\u0001(2006);
        this.\u001D.Visible = true;
        this.\u001D.VisibleIndex = 9;
        this.\u001D.Width = 72;
        this.\u001E.Caption = \u0005.\u0004.\u0001(5361);
        this.\u001E.FieldName = \u0005.\u0004.\u0001(2036);
        this.\u001E.Name = \u0005.\u0004.\u0001(2045);
        this.\u001E.Visible = true;
        this.\u001E.VisibleIndex = 1;
        this.\u001E.Width = 86;
        this.\u001F.Caption = \u0005.\u0004.\u0001(5370);
        this.\u001F.DisplayFormat.FormatString = \u0005.\u0004.\u0001(5326);
        this.\u001F.DisplayFormat.FormatType = FormatType.Numeric;
        this.\u001F.FieldName = \u0005.\u0004.\u0001(2551);
        this.\u001F.Name = \u0005.\u0004.\u0001(2560);
        this.\u001F.Visible = true;
        this.\u001F.VisibleIndex = 10;
        this.\u007F.Caption = \u0005.\u0004.\u0001(2350);
        this.\u007F.FieldName = \u0005.\u0004.\u0001(2668);
        this.\u007F.Name = \u0005.\u0004.\u0001(2677);
        this.\u007F.Visible = true;
        this.\u007F.VisibleIndex = 3;
        this.\u007F.Width = 189;
        this.AutoScaleDimensions = new SizeF(6f, 13f);
        this.AutoScaleMode = AutoScaleMode.Font;
        this.ClientSize = new Size(1265, 487);
        this.Controls.Add((Control) this.\u0012);
        this.Controls.Add((Control) this.\u0010);
        this.LookAndFeel.SkinName = \u0005.\u0004.\u0001(3057);
        this.LookAndFeel.UseDefaultLookAndFeel = false;
        this.Name = \u0005.\u0004.\u0001(5379);
        this.Text = \u0005.\u0004.\u0001(5392);
        this.\u0004.Properties.VistaTimeProperties.EndInit();
        this.\u0004.Properties.EndInit();
        this.\u0005.Properties.VistaTimeProperties.EndInit();
        this.\u0005.Properties.EndInit();
        this.\u0006.Properties.EndInit();
        this.\u0010.EndInit();
        this.\u0010.ResumeLayout(false);
        this.\u0010.PerformLayout();
        this.\u0011.EndInit();
        this.\u0011.ResumeLayout(false);
        this.\u0011.PerformLayout();
        this.\u0086.Properties.EndInit();
        ((ISupportInitialize) this.\u0088).EndInit();
        this.\u0087.EndInit();
        this.\u0083.Properties.EndInit();
        ((ISupportInitialize) this.\u008B).EndInit();
        this.\u0084.EndInit();
        this.\u008E.Properties.EndInit();
        this.\u0012.EndInit();
        ((ISupportInitialize) this.\u0014).EndInit();
        this.\u0013.EndInit();
        this.ResumeLayout(false);
      }
      catch (Exception ex)
      {
        EditorButton[] editorButtonArray2 = editorButtonArray1;
        GridColumn[] gridColumnArray2 = gridColumnArray1;
        BaseView[] baseViewArray2 = baseViewArray1;
        \u0005.\u0008.\u0001(ex, (object) editorButtonArray2, (object) gridColumnArray2, (object) baseViewArray2, (object) this);
        throw;
      }
    }

    public unsafe \u0002()
    {
      EventHandler eventHandler1 = (EventHandler) null;
      EventHandler eventHandler2 = (EventHandler) null;
      EventHandler eventHandler3 = (EventHandler) null;
      EventHandler eventHandler4 = (EventHandler) null;
      EventHandler eventHandler5 = (EventHandler) null;
      this.\u0001 = (IContainer) null;
      this.\u0091 = new CanDienTuEntities();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      try
      {
        this.\u0001();
        if (eventHandler1 == null)
          eventHandler1 = (EventHandler) ((_param1, _param2) =>
          {
            DateTime dateTime1;
            int num;
            string str1;
            DateTime dateTime2;
            try
            {
              if (true)
                goto label_7;
label_4:
              this.\u0088.DataSource = (object) this.\u0091.KhachHang;
              if (false)
                return;
label_5:
              this.\u008B.DataSource = (object) this.\u0091.HangHoa;
              return;
label_7:
              DateTime now = DateTime.Now;
              if (true)
                goto label_8;
label_1:
              if (true)
              {
                if (true)
                  goto label_9;
label_3:
                dateTime2 = this.\u0001(str1);
                this.\u0004.EditValue = (object) dateTime2;
                goto label_4;
label_9:
                this.\u0005.EditValue = (object) dateTime1;
                string str2 = \u0005.\u0004.\u0001(4102);
                num = dateTime1.Month;
                string str3 = num.ToString();
                string str4 = \u0005.\u0004.\u0001(4107);
                num = dateTime1.Year;
                string str5 = num.ToString();
                str1 = str2 + str3 + str4 + str5;
                goto label_3;
              }
              else
                goto label_5;
label_8:
              dateTime1 = now;
              goto label_1;
            }
            catch (Exception ex)
            {
              // ISSUE: variable of a boxed type
              __Boxed<DateTime> local1 = (ValueType) dateTime1;
              string str6 = str1;
              // ISSUE: variable of a boxed type
              __Boxed<DateTime> local2 = (ValueType) dateTime2;
              // ISSUE: variable of a boxed type
              __Boxed<int> local3 = (ValueType) num;
              object obj = _param1;
              EventArgs eventArgs = _param2;
              \u0005.\u0008.\u0001(ex, (object) local1, (object) str6, (object) local2, (object) local3, (object) this, obj, (object) eventArgs);
              throw;
            }
          });
        this.Load += eventHandler1;
        SimpleButton simpleButton1 = this.\u000F;
        if (eventHandler2 == null)
          eventHandler2 = (EventHandler) ((_param1, _param2) =>
          {
            try
            {
              if (false)
                goto label_2;
label_1:
              if (false)
                return;
              this.Close();
label_2:
              if (false)
                goto label_1;
            }
            catch (Exception ex)
            {
              object obj = _param1;
              EventArgs eventArgs = _param2;
              \u0005.\u0008.\u0001(ex, (object) this, obj, (object) eventArgs);
              throw;
            }
          });
        EventHandler eventHandler6 = eventHandler2;
        simpleButton1.Click += eventHandler6;
        SimpleButton simpleButton2 = this.\u0008;
        if (eventHandler3 == null)
          eventHandler3 = (EventHandler) ((_param1, _param2) =>
          {
            DateTime editValue1;
            DateTime editValue2;
            \u0008.\u0005 obj1;
            bool flag;
            try
            {
              flag = this.\u0014.List.Count < 1;
              if (flag)
                return;
              obj1 = new \u0008.\u0005();
              if (false)
                return;
              editValue1 = (DateTime) this.\u0004.EditValue;
              editValue2 = (DateTime) this.\u0005.EditValue;
              \u0004.\u0006.\u0001((object) this.\u0014.List, editValue1, obj1.DiaChi, obj1.Ten, obj1.DienThoai, obj1.CongTyCan, obj1.TieuDeLoGo, editValue2);
            }
            catch (Exception ex)
            {
              \u0008.\u0005 obj2 = obj1;
              // ISSUE: variable of a boxed type
              __Boxed<DateTime> local4 = (ValueType) editValue1;
              // ISSUE: variable of a boxed type
              __Boxed<DateTime> local5 = (ValueType) editValue2;
              // ISSUE: variable of a boxed type
              __Boxed<bool> local6 = (ValueType) flag;
              object obj3 = _param1;
              EventArgs eventArgs = _param2;
              \u0005.\u0008.\u0001(ex, (object) obj2, (object) local4, (object) local5, (object) local6, (object) this, obj3, (object) eventArgs);
              throw;
            }
          });
        EventHandler eventHandler7 = eventHandler3;
        simpleButton2.Click += eventHandler7;
        SimpleButton simpleButton3 = this.\u000E;
        if (eventHandler4 == null)
          eventHandler4 = (EventHandler) ((_param1, _param2) =>
          {
            SaveFileDialog saveFileDialog1;
            string fileName;
            string extension;
            string str7;
            bool flag;
            try
            {
              do
              {
                if (true)
                  goto label_24;
label_22:
                continue;
label_24:
                saveFileDialog1 = new SaveFileDialog();
                try
                {
                  saveFileDialog1.Filter = \u0005.\u0004.\u0001(5421);
                  flag = saveFileDialog1.ShowDialog() == DialogResult.Cancel;
                  if (!flag)
                    fileName = saveFileDialog1.FileName;
                  else
                    goto label_16;
label_3:
                  extension = new FileInfo(fileName).Extension;
                  try
                  {
                    do
                    {
                      str7 = extension;
                      if (str7 != null)
                      {
                        if (!(str7 == \u0005.\u0004.\u0001(5526)))
                        {
                          if (!(str7 == \u0005.\u0004.\u0001(5535)))
                          {
                            if (str7 == \u0005.\u0004.\u0001(5544))
                              this.\u0012.ExportToPdf(fileName);
                          }
                          else if (true)
                            this.\u0012.ExportToXlsx(fileName);
                        }
                        else
                          this.\u0012.ExportToXls(fileName);
                      }
                      int num = (int) XtraMessageBox.Show(\u0005.\u0004.\u0001(5553), \u0005.\u0004.\u0001(609), MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                    while (false);
                  }
                  catch (Exception ex)
                  {
                    int num = (int) XtraMessageBox.Show(\u0005.\u0004.\u0001(5590), \u0005.\u0004.\u0001(643), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                  }
label_16:
                  if (false)
                    goto label_3;
                  else
                    goto label_22;
                }
                finally
                {
                  int num = saveFileDialog1 == null ? 1 : 0;
                  if (true)
                  {
                    flag = num != 0;
                    num = flag ? 1 : 0;
                  }
                  if (num == 0)
                    saveFileDialog1.Dispose();
                }
              }
              while (false);
            }
            catch (Exception ex)
            {
              SaveFileDialog saveFileDialog2 = saveFileDialog1;
              string str8 = fileName;
              string str9 = extension;
              // ISSUE: variable of a boxed type
              __Boxed<bool> local = (ValueType) flag;
              string str10 = str7;
              object obj = _param1;
              EventArgs eventArgs = _param2;
              \u0005.\u0008.\u0001(ex, (object) saveFileDialog2, (object) str8, (object) str9, (object) local, (object) str10, (object) this, obj, (object) eventArgs);
              throw;
            }
          });
        EventHandler eventHandler8 = eventHandler4;
        simpleButton3.Click += eventHandler8;
        SimpleButton simpleButton4 = this.\u0007;
        if (eventHandler5 == null)
          eventHandler5 = (EventHandler) ((_param1, _param2) =>
          {
            // ISSUE: untyped stack allocation
            void* voidPtr1 = (void*) __untypedstackalloc(5);
            string str;
            string commandText;
            Guid guid;
            object[] objArray1;
            List<XeHang> list;
            // ISSUE: variable of a compiler-generated type
            \u0005.\u0002.\u0001 obj;
            try
            {
              // ISSUE: object of a compiler-generated type is created
              obj = new \u0005.\u0002.\u0001();
              // ISSUE: reference to a compiler-generated field
              obj.\u0001 = (DateTime) this.\u0004.EditValue;
              // ISSUE: reference to a compiler-generated field
              obj.\u0002 = (DateTime) this.\u0005.EditValue;
              str = \u0005.\u0004.\u0001(5627);
              commandText = \u0005.\u0004.\u0001(720);
              *(int*) voidPtr1 = 0;
              *(sbyte*) ((IntPtr) voidPtr1 + 4) = (sbyte) (this.\u0006.Text == null);
              if (*(sbyte*) ((IntPtr) voidPtr1 + 4) == (sbyte) 0)
              {
                *(sbyte*) ((IntPtr) voidPtr1 + 4) = (sbyte) string.IsNullOrWhiteSpace(this.\u0006.Text.ToString());
                if (*(sbyte*) ((IntPtr) voidPtr1 + 4) == (sbyte) 0)
                {
                  *(int*) voidPtr1 = *(int*) voidPtr1 + 1;
                  commandText = commandText + \u0005.\u0004.\u0001(5668) + this.\u0006.Text + \u0005.\u0004.\u0001(5689);
                }
              }
              *(sbyte*) ((IntPtr) voidPtr1 + 4) = (sbyte) (this.\u008E.Text == null);
              if (*(sbyte*) ((IntPtr) voidPtr1 + 4) == (sbyte) 0)
              {
                *(sbyte*) ((IntPtr) voidPtr1 + 4) = (sbyte) string.IsNullOrWhiteSpace(this.\u008E.Text.ToString());
                if (*(sbyte*) ((IntPtr) voidPtr1 + 4) == (sbyte) 0)
                {
                  *(int*) voidPtr1 = *(int*) voidPtr1 + 1;
                  commandText = commandText + \u0005.\u0004.\u0001(5694) + this.\u008E.Text + \u0005.\u0004.\u0001(5689);
                }
              }
              *(sbyte*) ((IntPtr) voidPtr1 + 4) = (sbyte) (this.\u0086.EditValue == null);
              if (*(sbyte*) ((IntPtr) voidPtr1 + 4) == (sbyte) 0)
              {
                guid = Guid.Parse(this.\u0086.EditValue.ToString());
                *(int*) voidPtr1 = *(int*) voidPtr1 + 1;
                objArray1 = new object[4]
                {
                  (object) commandText,
                  (object) \u0005.\u0004.\u0001(5719),
                  (object) guid,
                  (object) \u0005.\u0004.\u0001(5744)
                };
                commandText = string.Concat(objArray1);
              }
              *(sbyte*) ((IntPtr) voidPtr1 + 4) = (sbyte) (this.\u0083.EditValue == null);
              if (*(sbyte*) ((IntPtr) voidPtr1 + 4) == (sbyte) 0)
              {
                guid = Guid.Parse(this.\u0083.EditValue.ToString());
                *(int*) voidPtr1 = *(int*) voidPtr1 + 1;
                objArray1 = new object[4]
                {
                  (object) commandText,
                  (object) \u0005.\u0004.\u0001(5749),
                  (object) guid,
                  (object) \u0005.\u0004.\u0001(5744)
                };
                commandText = string.Concat(objArray1);
              }
              *(sbyte*) ((IntPtr) voidPtr1 + 4) = (sbyte) !commandText.StartsWith(\u0005.\u0004.\u0001(5774));
              if (*(sbyte*) ((IntPtr) voidPtr1 + 4) == (sbyte) 0)
                commandText = commandText.Substring(3);
              *(sbyte*) ((IntPtr) voidPtr1 + 4) = (sbyte) (*(int*) voidPtr1 != 0);
              commandText = *(sbyte*) ((IntPtr) voidPtr1 + 4) != (sbyte) 0 ? str + commandText : \u0005.\u0004.\u0001(5779);
              list = this.\u0091.ExecuteStoreQuery<XeHang>(commandText, \u0005.\u0004.\u0001(5812), MergeOption.AppendOnly).ToList<XeHang>();
              // ISSUE: reference to a compiler-generated method
              this.\u0014.DataSource = (object) list.Where<XeHang>(new Func<XeHang, bool>(obj.\u0001)).OrderBy<XeHang, int>((Func<XeHang, int>) (_param0 =>
              {
                void* voidPtr2;
                do
                {
                  // ISSUE: untyped stack allocation
                  voidPtr2 = (void*) __untypedstackalloc(8);
                  try
                  {
                    if (true)
                      *(int*) voidPtr2 = _param0.SoChungTu;
                    *(int*) ((IntPtr) voidPtr2 + 4) = *(int*) voidPtr2;
                  }
                  catch (Exception ex)
                  {
                    // ISSUE: variable of a boxed type
                    __Boxed<int> local = (ValueType) *(int*) voidPtr2;
                    XeHang xeHang = _param0;
                    \u0005.\u0008.\u0001(ex, (object) local, (object) xeHang);
                    throw;
                  }
                }
                while (false);
                return *(int*) ((IntPtr) voidPtr2 + 4);
              }));
            }
            catch (Exception ex)
            {
              object[] objArray2 = new object[11]
              {
                (object) str,
                (object) commandText,
                (object) *(int*) voidPtr1,
                (object) guid,
                (object) list,
                (object) obj,
                (object) (bool) *(sbyte*) ((IntPtr) voidPtr1 + 4),
                (object) objArray1,
                (object) this,
                _param1,
                (object) _param2
              };
              \u0005.\u0008.\u0001(ex, objArray2);
              throw;
            }
          });
        EventHandler eventHandler9 = eventHandler5;
        simpleButton4.Click += eventHandler9;
      }
      catch (Exception ex)
      {
        EventHandler eventHandler10 = eventHandler1;
        EventHandler eventHandler11 = eventHandler2;
        EventHandler eventHandler12 = eventHandler3;
        EventHandler eventHandler13 = eventHandler4;
        EventHandler eventHandler14 = eventHandler5;
        \u0005.\u0008.\u0001(ex, (object) eventHandler10, (object) eventHandler11, (object) eventHandler12, (object) eventHandler13, (object) eventHandler14, (object) this);
        throw;
      }
    }

    public unsafe DateTime \u0001(string _param1)
    {
      // ISSUE: untyped stack allocation
      void* voidPtr = (void*) __untypedstackalloc(9);
      DateTime result;
      DateTimeFormatInfo provider;
      try
      {
        *(sbyte*) ((IntPtr) voidPtr + 8) = (sbyte) DateTime.TryParse(_param1, out result);
        if (*(sbyte*) ((IntPtr) voidPtr + 8) == (sbyte) 0)
          goto label_8;
label_7:
        return result;
label_8:
        *(sbyte*) ((IntPtr) voidPtr + 8) = (sbyte) !double.TryParse(_param1, out *(double*) voidPtr);
        if (*(sbyte*) ((IntPtr) voidPtr + 8) == (sbyte) 0)
        {
          if (true)
          {
            result = DateTime.FromOADate(*(double*) voidPtr);
            if (true)
              goto label_6;
          }
        }
        else
        {
          provider = new DateTimeFormatInfo();
          provider.ShortDatePattern = \u0005.\u0004.\u0001(3776);
          result = Convert.ToDateTime(_param1, (IFormatProvider) provider);
        }
label_6:
        goto label_7;
      }
      catch (Exception ex)
      {
        // ISSUE: variable of a boxed type
        __Boxed<DateTime> local1 = (ValueType) result;
        // ISSUE: variable of a boxed type
        __Boxed<double> local2 = (ValueType) *(double*) voidPtr;
        DateTimeFormatInfo dateTimeFormatInfo = provider;
        DateTime dateTime;
        // ISSUE: variable of a boxed type
        __Boxed<DateTime> local3 = (ValueType) dateTime;
        // ISSUE: variable of a boxed type
        __Boxed<bool> local4 = (ValueType) (bool) *(sbyte*) ((IntPtr) voidPtr + 8);
        string str = _param1;
        \u0005.\u0008.\u0001(ex, (object) local1, (object) local2, (object) dateTimeFormatInfo, (object) local3, (object) local4, (object) this, (object) str);
        throw;
      }
    }
  }
}
