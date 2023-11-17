// Decompiled with JetBrains decompiler
// Type: .
// Assembly: XtraDienTu, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8F0E94B6-F573-4BC5-92AB-CE54C0CE94F8
// Assembly location: C:\Project\HH.CanOTo\references\CAN TRI VIET\ViNaCaFe\ViNaCaFe\Update VINA CAPHE 2014-11-24\XtraDienTu.exe

using DevExpress.Utils;
using DevExpress.Utils.Drawing;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
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
using System.IO.Ports;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Xtra.Data;

namespace \u0005
{
  internal class \u0001 : XtraForm
  {
    private IContainer \u0001;
    private SimpleButton \u0002;
    private SimpleButton \u0003;
    private SimpleButton \u0004;
    private SimpleButton \u0005;
    private PanelControl \u0006;
    private GridControl \u0007;
    private GridView \u0008;
    private BindingSource \u000E;
    private GridColumn \u000F;
    private GridColumn \u0010;
    private GridColumn \u0011;
    private GridColumn \u0012;
    private GridColumn \u0013;
    private GridColumn \u0014;
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
    private RepositoryItemGridLookUpEdit \u007F;
    private BindingSource \u0080;
    private GridView \u0081;
    private GridColumn \u0082;
    private GridColumn \u0083;
    private RepositoryItemGridLookUpEdit \u0084;
    private BindingSource \u0086;
    private GridView \u0087;
    private GridColumn \u0088;
    private GridColumn \u0089;
    private RepositoryItemSpinEdit \u008A;
    private SimpleButton \u008B;
    private SimpleButton \u008C;
    private SimpleButton \u008D;
    private SimpleButton \u008E;
    private SimpleButton \u008F;
    private RepositoryItemDateEdit \u0090;
    private GridColumn \u0091;
    private GridColumn \u0092;
    private GridColumn \u0093;
    private GridColumn \u0094;
    private GridColumn \u0095;
    private RepositoryItemSearchLookUpEdit \u0096;
    private GridView \u0097;
    private GridColumn \u0098;
    private GridColumn \u0099;
    private TextBox \u009A;
    private RepositoryItemSearchLookUpEdit \u009B;
    private GridView \u009C;
    private GridColumn \u009D;
    private GridColumn \u009E;
    private GridColumn \u009F;
    private GridColumn \u0001\u0002;
    private SerialPort \u0002\u0002;
    private RepositoryItemSpinEdit \u0003\u0002;
    private DateEdit \u0004\u0002;
    private LabelControl \u0005\u0002;
    private LabelControl \u0006\u0002;
    private DateEdit \u0007\u0002;
    private GridColumn \u0008\u0002;
    private PanelControl \u000E\u0002;
    private RepositoryItemDateEdit \u000F\u0002;
    private SimpleButton \u0010\u0002;
    private GroupControl \u0011\u0002;
    private TextEdit \u0012\u0002;
    private SearchLookUpEdit \u0013\u0002;
    private GridView \u0014\u0002;
    private GridColumn \u0015\u0002;
    private GridColumn \u0016\u0002;
    private SpinEdit \u0017\u0002;
    private SpinEdit \u0018\u0002;
    private SpinEdit \u0019\u0002;
    private SpinEdit \u001A\u0002;
    private TextEdit \u001B\u0002;
    private TextEdit \u001C\u0002;
    private SpinEdit \u001D\u0002;
    private SearchLookUpEdit \u001E\u0002;
    private GridView \u001F\u0002;
    private DateEdit \u007F\u0002;
    private SpinEdit \u0080\u0002;
    private GridColumn \u0081\u0002;
    private GridColumn \u0082\u0002;
    private GroupControl \u0083\u0002;
    private TextBox \u0084\u0002;
    private CanDienTuEntities \u0086\u0002;
    private string \u0087\u0002;

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
      Label label1;
      Label label2;
      Label label3;
      Label label4;
      Label label5;
      Label label6;
      Label label7;
      Label label8;
      Label label9;
      Label label10;
      Label label11;
      Label label12;
      Label label13;
      EditorButton[] editorButtonArray;
      RepositoryItem[] repositoryItemArray;
      BaseView[] baseViewArray;
      GridColumn[] gridColumnArray;
      int[] bits;
      try
      {
        this.\u0001 = (IContainer) new System.ComponentModel.Container();
        this.\u0002 = new SimpleButton();
        this.\u009A = new TextBox();
        this.\u0006\u0002 = new LabelControl();
        this.\u008D = new SimpleButton();
        this.\u0005\u0002 = new LabelControl();
        this.\u0005 = new SimpleButton();
        this.\u008F = new SimpleButton();
        this.\u0007\u0002 = new DateEdit();
        this.\u0004 = new SimpleButton();
        this.\u0004\u0002 = new DateEdit();
        this.\u008B = new SimpleButton();
        this.\u0003 = new SimpleButton();
        this.\u008E = new SimpleButton();
        this.\u008C = new SimpleButton();
        this.\u0006 = new PanelControl();
        this.\u0007 = new GridControl();
        this.\u000E = new BindingSource(this.\u0001);
        this.\u0008 = new GridView();
        this.\u0095 = new GridColumn();
        this.\u000F = new GridColumn();
        this.\u0010 = new GridColumn();
        this.\u0011 = new GridColumn();
        this.\u0012 = new GridColumn();
        this.\u0013 = new GridColumn();
        this.\u0014 = new GridColumn();
        this.\u0003\u0002 = new RepositoryItemSpinEdit();
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
        this.\u0096 = new RepositoryItemSearchLookUpEdit();
        this.\u0080 = new BindingSource(this.\u0001);
        this.\u0097 = new GridView();
        this.\u0098 = new GridColumn();
        this.\u0099 = new GridColumn();
        this.\u001F = new GridColumn();
        this.\u009B = new RepositoryItemSearchLookUpEdit();
        this.\u0086 = new BindingSource(this.\u0001);
        this.\u009C = new GridView();
        this.\u009F = new GridColumn();
        this.\u0001\u0002 = new GridColumn();
        this.\u0091 = new GridColumn();
        this.\u0092 = new GridColumn();
        this.\u0093 = new GridColumn();
        this.\u0094 = new GridColumn();
        this.\u0008\u0002 = new GridColumn();
        this.\u007F = new RepositoryItemGridLookUpEdit();
        this.\u0081 = new GridView();
        this.\u0082 = new GridColumn();
        this.\u0083 = new GridColumn();
        this.\u0084 = new RepositoryItemGridLookUpEdit();
        this.\u0087 = new GridView();
        this.\u0088 = new GridColumn();
        this.\u0089 = new GridColumn();
        this.\u008A = new RepositoryItemSpinEdit();
        this.\u0090 = new RepositoryItemDateEdit();
        this.\u000F\u0002 = new RepositoryItemDateEdit();
        this.\u009D = new GridColumn();
        this.\u009E = new GridColumn();
        this.\u0002\u0002 = new SerialPort(this.\u0001);
        this.\u000E\u0002 = new PanelControl();
        this.\u0083\u0002 = new GroupControl();
        this.\u0011\u0002 = new GroupControl();
        this.\u0084\u0002 = new TextBox();
        this.\u001D\u0002 = new SpinEdit();
        this.\u001E\u0002 = new SearchLookUpEdit();
        this.\u001F\u0002 = new GridView();
        this.\u0081\u0002 = new GridColumn();
        this.\u0082\u0002 = new GridColumn();
        this.\u007F\u0002 = new DateEdit();
        this.\u0080\u0002 = new SpinEdit();
        this.\u0012\u0002 = new TextEdit();
        this.\u0010\u0002 = new SimpleButton();
        this.\u0013\u0002 = new SearchLookUpEdit();
        this.\u0014\u0002 = new GridView();
        this.\u0015\u0002 = new GridColumn();
        this.\u0016\u0002 = new GridColumn();
        this.\u0017\u0002 = new SpinEdit();
        this.\u0018\u0002 = new SpinEdit();
        this.\u0019\u0002 = new SpinEdit();
        this.\u001A\u0002 = new SpinEdit();
        this.\u001B\u0002 = new TextEdit();
        this.\u001C\u0002 = new TextEdit();
        label1 = new Label();
        label2 = new Label();
        label3 = new Label();
        label4 = new Label();
        label5 = new Label();
        label6 = new Label();
        label7 = new Label();
        label8 = new Label();
        label9 = new Label();
        label10 = new Label();
        label11 = new Label();
        label12 = new Label();
        label13 = new Label();
        this.\u0007\u0002.Properties.CalendarTimeProperties.BeginInit();
        this.\u0007\u0002.Properties.BeginInit();
        this.\u0004\u0002.Properties.CalendarTimeProperties.BeginInit();
        this.\u0004\u0002.Properties.BeginInit();
        this.\u0006.BeginInit();
        this.\u0007.BeginInit();
        ((ISupportInitialize) this.\u000E).BeginInit();
        this.\u0008.BeginInit();
        this.\u0003\u0002.BeginInit();
        this.\u0096.BeginInit();
        ((ISupportInitialize) this.\u0080).BeginInit();
        this.\u0097.BeginInit();
        this.\u009B.BeginInit();
        ((ISupportInitialize) this.\u0086).BeginInit();
        this.\u009C.BeginInit();
        this.\u007F.BeginInit();
        this.\u0081.BeginInit();
        this.\u0084.BeginInit();
        this.\u0087.BeginInit();
        this.\u008A.BeginInit();
        this.\u0090.BeginInit();
        this.\u0090.CalendarTimeProperties.BeginInit();
        this.\u000F\u0002.BeginInit();
        this.\u000F\u0002.CalendarTimeProperties.BeginInit();
        this.\u000E\u0002.BeginInit();
        this.\u000E\u0002.SuspendLayout();
        this.\u0083\u0002.BeginInit();
        this.\u0083\u0002.SuspendLayout();
        this.\u0011\u0002.BeginInit();
        this.\u0011\u0002.SuspendLayout();
        this.\u001D\u0002.Properties.BeginInit();
        this.\u001E\u0002.Properties.BeginInit();
        this.\u001F\u0002.BeginInit();
        this.\u007F\u0002.Properties.CalendarTimeProperties.BeginInit();
        this.\u007F\u0002.Properties.BeginInit();
        this.\u0080\u0002.Properties.BeginInit();
        this.\u0012\u0002.Properties.BeginInit();
        this.\u0013\u0002.Properties.BeginInit();
        this.\u0014\u0002.BeginInit();
        this.\u0017\u0002.Properties.BeginInit();
        this.\u0018\u0002.Properties.BeginInit();
        this.\u0019\u0002.Properties.BeginInit();
        this.\u001A\u0002.Properties.BeginInit();
        this.\u001B\u0002.Properties.BeginInit();
        this.\u001C\u0002.Properties.BeginInit();
        this.SuspendLayout();
        label1.AutoSize = true;
        label1.Location = new Point(8, 111);
        label1.Name = \u0005.\u0004.\u0001(784);
        label1.Size = new Size(45, 13);
        label1.TabIndex = 15;
        label1.Text = \u0005.\u0004.\u0001((int) byte.MaxValue);
        label2.AutoSize = true;
        label2.Location = new Point(5, 158);
        label2.Name = \u0005.\u0004.\u0001(801);
        label2.Size = new Size(48, 13);
        label2.TabIndex = 17;
        label2.Text = \u0005.\u0004.\u0001(818);
        label3.AutoSize = true;
        label3.Location = new Point(268, 90);
        label3.Name = \u0005.\u0004.\u0001(831);
        label3.Size = new Size(46, 13);
        label3.TabIndex = 45;
        label3.Text = \u0005.\u0004.\u0001(848);
        label4.AutoSize = true;
        label4.Location = new Point(8, 69);
        label4.Name = \u0005.\u0004.\u0001(861);
        label4.Size = new Size(41, 13);
        label4.TabIndex = 21;
        label4.Text = \u0005.\u0004.\u0001(886);
        label5.AutoSize = true;
        label5.Location = new Point(268, 48);
        label5.Name = \u0005.\u0004.\u0001(899);
        label5.Size = new Size(65, 13);
        label5.TabIndex = 43;
        label5.Text = \u0005.\u0004.\u0001(920);
        label6.AutoSize = true;
        label6.Location = new Point(268, 69);
        label6.Name = \u0005.\u0004.\u0001(937);
        label6.Size = new Size(37, 13);
        label6.TabIndex = 41;
        label6.Text = \u0005.\u0004.\u0001(950);
        label7.AutoSize = true;
        label7.Location = new Point(8, 27);
        label7.Name = \u0005.\u0004.\u0001(959);
        label7.Size = new Size(74, 13);
        label7.TabIndex = 25;
        label7.Text = \u0005.\u0004.\u0001(980);
        label8.AutoSize = true;
        label8.Location = new Point(8, 132);
        label8.Name = \u0005.\u0004.\u0001(1005);
        label8.Size = new Size(38, 13);
        label8.TabIndex = 27;
        label8.Text = \u0005.\u0004.\u0001(1018);
        label9.AutoSize = true;
        label9.Location = new Point(8, 90);
        label9.Name = \u0005.\u0004.\u0001(1031);
        label9.Size = new Size(45, 13);
        label9.TabIndex = 29;
        label9.Text = \u0005.\u0004.\u0001(1048);
        label10.AutoSize = true;
        label10.Location = new Point(269, 113);
        label10.Name = \u0005.\u0004.\u0001(1061);
        label10.Size = new Size(49, 13);
        label10.TabIndex = 49;
        if (true)
        {
          label10.Text = \u0005.\u0004.\u0001(1078);
          label11.AutoSize = true;
          label11.Location = new Point(9, 48);
          label11.Name = \u0005.\u0004.\u0001(1091);
          label11.Size = new Size(36, 13);
          label11.TabIndex = 50;
          label11.Text = \u0005.\u0004.\u0001(1104);
          label12.AutoSize = true;
          label12.Location = new Point(268, 27);
          label12.Name = \u0005.\u0004.\u0001(1113);
          label12.Size = new Size(42, 13);
          label12.TabIndex = 51;
          label12.Text = \u0005.\u0004.\u0001(1134);
          label13.AutoSize = true;
          label13.Location = new Point(268, 139);
          label13.Name = \u0005.\u0004.\u0001(1147);
          label13.Size = new Size(64, 13);
          label13.TabIndex = 52;
          label13.Text = \u0005.\u0004.\u0001(1168);
          this.\u0002.Appearance.Font = new Font(\u0005.\u0004.\u0001(1189), 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 163);
          this.\u0002.Appearance.Options.UseFont = true;
          this.\u0002.Image = (Image) \u0008.\u0004.delete;
          this.\u0002.Location = new Point(182, 132);
          this.\u0002.LookAndFeel.SkinName = \u0005.\u0004.\u0001(160);
          this.\u0002.LookAndFeel.UseDefaultLookAndFeel = false;
          this.\u0002.Name = \u0005.\u0004.\u0001(1218);
          this.\u0002.Size = new Size(129, 48);
          this.\u0002.TabIndex = 0;
          this.\u0002.Text = \u0005.\u0004.\u0001(1227);
          this.\u009A.BackColor = Color.White;
          this.\u009A.Font = new Font(\u0005.\u0004.\u0001(100), 42f, FontStyle.Bold, GraphicsUnit.Point, (byte) 163);
          this.\u009A.ForeColor = Color.Red;
          this.\u009A.Location = new Point(4, 4);
          this.\u009A.Multiline = true;
          this.\u009A.Name = \u0005.\u0004.\u0001(1236);
          this.\u009A.ReadOnly = true;
          this.\u009A.Size = new Size(267, 70);
          this.\u009A.TabIndex = 2;
          this.\u009A.TextAlign = HorizontalAlignment.Center;
          this.\u0006\u0002.Location = new Point(252, 36);
          this.\u0006\u0002.Name = \u0005.\u0004.\u0001(234);
          this.\u0006\u0002.Size = new Size(48, 13);
          this.\u0006\u0002.TabIndex = 1;
          this.\u0006\u0002.Text = \u0005.\u0004.\u0001(1249);
          this.\u008D.Appearance.Font = new Font(\u0005.\u0004.\u0001(1189), 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 163);
          this.\u008D.Appearance.Options.UseFont = true;
          this.\u008D.Image = (Image) \u0008.\u0004.chitiets;
          this.\u008D.Location = new Point(649, 6);
          this.\u008D.LookAndFeel.SkinName = \u0005.\u0004.\u0001(160);
          this.\u008D.LookAndFeel.UseDefaultLookAndFeel = false;
          this.\u008D.Name = \u0005.\u0004.\u0001(1266);
          this.\u008D.Size = new Size(157, 68);
          this.\u008D.TabIndex = 1;
          this.\u008D.Text = \u0005.\u0004.\u0001(1279);
          this.\u0005\u0002.Location = new Point(28, 35);
          this.\u0005\u0002.Name = \u0005.\u0004.\u0001(109);
          this.\u0005\u0002.Size = new Size(41, 13);
          this.\u0005\u0002.TabIndex = 1;
          this.\u0005\u0002.Text = \u0005.\u0004.\u0001(1296);
          this.\u0005.Appearance.Font = new Font(\u0005.\u0004.\u0001(1189), 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 163);
          this.\u0005.Appearance.Options.UseFont = true;
          this.\u0005.Image = (Image) \u0008.\u0004._new;
          this.\u0005.Location = new Point(23, 69);
          this.\u0005.LookAndFeel.SkinName = \u0005.\u0004.\u0001(160);
          this.\u0005.LookAndFeel.UseDefaultLookAndFeel = false;
          this.\u0005.Name = \u0005.\u0004.\u0001(1313);
          this.\u0005.Size = new Size(129, 48);
          this.\u0005.TabIndex = 0;
          this.\u0005.Text = \u0005.\u0004.\u0001(1326);
          this.\u008F.Appearance.Font = new Font(\u0005.\u0004.\u0001(1189), 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 163);
          this.\u008F.Appearance.Options.UseFont = true;
          this.\u008F.Image = (Image) \u0008.\u0004.xehang;
          this.\u008F.Location = new Point(277, 7);
          this.\u008F.LookAndFeel.SkinName = \u0005.\u0004.\u0001(160);
          this.\u008F.LookAndFeel.UseDefaultLookAndFeel = false;
          this.\u008F.Name = \u0005.\u0004.\u0001(1335);
          this.\u008F.Size = new Size(157, 67);
          this.\u008F.TabIndex = 1;
          this.\u008F.Text = \u0005.\u0004.\u0001(1348);
          this.\u0007\u0002.EditValue = (object) null;
          this.\u0007\u0002.Location = new Point(317, 32);
          this.\u0007\u0002.Name = \u0005.\u0004.\u0001(1369);
          EditorButtonCollection buttons1 = this.\u0007\u0002.Properties.Buttons;
          editorButtonArray = new EditorButton[1]
          {
            new EditorButton(ButtonPredefines.Combo)
          };
          EditorButton[] buttons2 = editorButtonArray;
          buttons1.AddRange(buttons2);
          EditorButtonCollection buttons3 = this.\u0007\u0002.Properties.CalendarTimeProperties.Buttons;
          editorButtonArray = new EditorButton[1]
          {
            new EditorButton()
          };
          EditorButton[] buttons4 = editorButtonArray;
          buttons3.AddRange(buttons4);
          this.\u0007\u0002.Size = new Size(153, 20);
          this.\u0007\u0002.TabIndex = 0;
          this.\u0007\u0002.EditValueChanged += new EventHandler(this.\u0003);
          this.\u0004.Appearance.Font = new Font(\u0005.\u0004.\u0001(1189), 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 163);
          this.\u0004.Appearance.Options.UseFont = true;
          this.\u0004.Image = (Image) \u0008.\u0004.save;
          this.\u0004.Location = new Point(23, 132);
          this.\u0004.LookAndFeel.SkinName = \u0005.\u0004.\u0001(160);
          this.\u0004.LookAndFeel.UseDefaultLookAndFeel = false;
          this.\u0004.Name = \u0005.\u0004.\u0001(216);
          this.\u0004.Size = new Size(129, 48);
          this.\u0004.TabIndex = 0;
          this.\u0004.Text = \u0005.\u0004.\u0001(225);
          this.\u0004\u0002.EditValue = (object) null;
          this.\u0004\u0002.Location = new Point(80, 32);
          this.\u0004\u0002.Name = \u0005.\u0004.\u0001(1382);
          EditorButtonCollection buttons5 = this.\u0004\u0002.Properties.Buttons;
          editorButtonArray = new EditorButton[1]
          {
            new EditorButton(ButtonPredefines.Combo)
          };
          EditorButton[] buttons6 = editorButtonArray;
          buttons5.AddRange(buttons6);
          EditorButtonCollection buttons7 = this.\u0004\u0002.Properties.CalendarTimeProperties.Buttons;
          editorButtonArray = new EditorButton[1]
          {
            new EditorButton()
          };
          EditorButton[] buttons8 = editorButtonArray;
          buttons7.AddRange(buttons8);
          this.\u0004\u0002.Size = new Size(153, 20);
          this.\u0004\u0002.TabIndex = 0;
          this.\u0004\u0002.EditValueChanged += new EventHandler(this.\u0002);
          this.\u008B.Appearance.Font = new Font(\u0005.\u0004.\u0001(1189), 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 163);
          this.\u008B.Appearance.Options.UseFont = true;
          this.\u008B.Image = (Image) \u0008.\u0004.cuoi;
          this.\u008B.Location = new Point(349, 69);
          this.\u008B.LookAndFeel.SkinName = \u0005.\u0004.\u0001(160);
          this.\u008B.LookAndFeel.UseDefaultLookAndFeel = false;
          this.\u008B.Name = \u0005.\u0004.\u0001(1391);
          this.\u008B.Size = new Size(129, 48);
          this.\u008B.TabIndex = 1;
          this.\u008B.Text = \u0005.\u0004.\u0001(1404);
          this.\u0003.Appearance.Font = new Font(\u0005.\u0004.\u0001(1189), 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 163);
          this.\u0003.Appearance.Options.UseFont = true;
          this.\u0003.Image = (Image) \u0008.\u0004.exit;
          this.\u0003.Location = new Point(349, 132);
          this.\u0003.LookAndFeel.SkinName = \u0005.\u0004.\u0001(160);
          this.\u0003.LookAndFeel.UseDefaultLookAndFeel = false;
          this.\u0003.Name = \u0005.\u0004.\u0001(194);
          this.\u0003.Size = new Size(129, 48);
          this.\u0003.TabIndex = 0;
          this.\u0003.Text = \u0005.\u0004.\u0001(207);
          this.\u008E.Appearance.Font = new Font(\u0005.\u0004.\u0001(1189), 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 163);
          this.\u008E.Appearance.Options.UseFont = true;
          this.\u008E.Image = (Image) \u0008.\u0004.car;
          this.\u008E.Location = new Point(462, 7);
          this.\u008E.LookAndFeel.SkinName = \u0005.\u0004.\u0001(160);
          this.\u008E.LookAndFeel.UseDefaultLookAndFeel = false;
          this.\u008E.Name = \u0005.\u0004.\u0001(1413);
          this.\u008E.Size = new Size(157, 67);
          this.\u008E.TabIndex = 1;
        }
        else
          goto label_7;
label_2:
        this.\u008E.Text = \u0005.\u0004.\u0001(1426);
        this.\u008C.Appearance.Font = new Font(\u0005.\u0004.\u0001(1189), 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 163);
        this.\u008C.Appearance.Options.UseFont = true;
        this.\u008C.Image = (Image) \u0008.\u0004.dau;
        this.\u008C.Location = new Point(182, 69);
        this.\u008C.LookAndFeel.SkinName = \u0005.\u0004.\u0001(160);
        this.\u008C.LookAndFeel.UseDefaultLookAndFeel = false;
        this.\u008C.Name = \u0005.\u0004.\u0001(1435);
        this.\u008C.Size = new Size(129, 48);
        this.\u008C.TabIndex = 1;
        this.\u008C.Text = \u0005.\u0004.\u0001(1444);
        this.\u0006.Dock = DockStyle.Bottom;
        this.\u0006.Location = new Point(0, 451);
        this.\u0006.Name = \u0005.\u0004.\u0001(1453);
        this.\u0006.Size = new Size(1034, 10);
        this.\u0006.TabIndex = 9;
        this.\u0007.DataSource = (object) this.\u000E;
        this.\u0007.Dock = DockStyle.Fill;
        this.\u0007.EmbeddedNavigator.Appearance.BackColor = Color.White;
        this.\u0007.EmbeddedNavigator.Appearance.Font = new Font(\u0005.\u0004.\u0001(100), 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 163);
        this.\u0007.EmbeddedNavigator.Appearance.ForeColor = Color.White;
        this.\u0007.EmbeddedNavigator.Appearance.Options.UseBackColor = true;
        this.\u0007.EmbeddedNavigator.Appearance.Options.UseFont = true;
        this.\u0007.EmbeddedNavigator.Appearance.Options.UseForeColor = true;
        this.\u0007.Font = new Font(\u0005.\u0004.\u0001(100), 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 163);
        this.\u0007.Location = new Point(0, 301);
        this.\u0007.LookAndFeel.SkinName = \u0005.\u0004.\u0001(160);
        this.\u0007.LookAndFeel.UseWindowsXPTheme = true;
        this.\u0007.MainView = (BaseView) this.\u0008;
        this.\u0007.Name = \u0005.\u0004.\u0001(1474);
        if (true)
        {
          RepositoryItemCollection repositoryItems = this.\u0007.RepositoryItems;
          repositoryItemArray = new RepositoryItem[8]
          {
            (RepositoryItem) this.\u007F,
            (RepositoryItem) this.\u0084,
            (RepositoryItem) this.\u008A,
            (RepositoryItem) this.\u0090,
            (RepositoryItem) this.\u0096,
            (RepositoryItem) this.\u009B,
            (RepositoryItem) this.\u0003\u0002,
            (RepositoryItem) this.\u000F\u0002
          };
          RepositoryItem[] items = repositoryItemArray;
          repositoryItems.AddRange(items);
          this.\u0007.Size = new Size(1034, 150);
          this.\u0007.TabIndex = 10;
          ViewRepositoryCollection viewCollection = this.\u0007.ViewCollection;
          baseViewArray = new BaseView[1]
          {
            (BaseView) this.\u0008
          };
          BaseView[] views = baseViewArray;
          viewCollection.AddRange(views);
          this.\u000E.DataSource = (object) typeof (XeHang);
          this.\u0008.Appearance.EvenRow.Font = new Font(\u0005.\u0004.\u0001(100), 11.25f);
          this.\u0008.Appearance.EvenRow.Options.UseFont = true;
          this.\u0008.Appearance.HeaderPanel.Font = new Font(\u0005.\u0004.\u0001(100), 9f, FontStyle.Bold);
          this.\u0008.Appearance.HeaderPanel.Options.UseFont = true;
          this.\u0008.Appearance.HeaderPanel.Options.UseTextOptions = true;
          this.\u0008.Appearance.HeaderPanel.TextOptions.HAlignment = HorzAlignment.Center;
          this.\u0008.Appearance.OddRow.Font = new Font(\u0005.\u0004.\u0001(100), 11.25f);
          this.\u0008.Appearance.OddRow.Options.UseFont = true;
          this.\u0008.Appearance.Row.Font = new Font(\u0005.\u0004.\u0001(100), 12f);
          this.\u0008.Appearance.Row.Options.UseFont = true;
          this.\u0008.Appearance.SelectedRow.Options.UseFont = true;
          this.\u0008.AppearancePrint.Row.ForeColor = Color.White;
          this.\u0008.AppearancePrint.Row.Options.UseFont = true;
          this.\u0008.AppearancePrint.Row.Options.UseForeColor = true;
          GridColumnCollection columns1 = this.\u0008.Columns;
          gridColumnArray = new GridColumn[23]
          {
            this.\u0095,
            this.\u000F,
            this.\u0010,
            this.\u0011,
            this.\u0012,
            this.\u0013,
            this.\u0014,
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
            this.\u0091,
            this.\u0092,
            this.\u0093,
            this.\u0094,
            this.\u0008\u0002
          };
          GridColumn[] columns2 = gridColumnArray;
          columns1.AddRange(columns2);
          this.\u0008.GridControl = this.\u0007;
          this.\u0008.IndicatorWidth = 45;
          this.\u0008.Name = \u0005.\u0004.\u0001(1491);
          this.\u0008.OptionsCustomization.AllowSort = false;
          this.\u0008.OptionsView.ColumnAutoWidth = false;
          this.\u0008.OptionsView.EnableAppearanceEvenRow = true;
          this.\u0008.OptionsView.EnableAppearanceOddRow = true;
          this.\u0008.OptionsView.ShowAutoFilterRow = true;
          this.\u0008.OptionsView.ShowGroupPanel = false;
          this.\u0008.RowHeight = 27;
          this.\u0008.CustomDrawRowIndicator += new RowIndicatorCustomDrawEventHandler(this.\u0001);
          this.\u0008.CustomUnboundColumnData += new CustomColumnDataEventHandler(this.\u0001);
          this.\u0095.Caption = \u0005.\u0004.\u0001(1504);
          this.\u0095.FieldName = \u0005.\u0004.\u0001(1525);
          this.\u0095.Name = \u0005.\u0004.\u0001(1542);
          this.\u0095.Visible = true;
          this.\u0095.VisibleIndex = 5;
          this.\u0095.Width = 101;
          this.\u000F.FieldName = \u0005.\u0004.\u0001(1555);
          this.\u000F.Name = \u0005.\u0004.\u0001(1560);
          this.\u0010.Caption = \u0005.\u0004.\u0001(1569);
          this.\u0010.FieldName = \u0005.\u0004.\u0001(1574);
          this.\u0010.Name = \u0005.\u0004.\u0001(1587);
          this.\u0010.Visible = true;
          this.\u0010.VisibleIndex = 0;
          this.\u0010.Width = 43;
          this.\u0011.Caption = \u0005.\u0004.\u0001(1604);
          this.\u0011.FieldName = \u0005.\u0004.\u0001(1617);
          this.\u0011.Name = \u0005.\u0004.\u0001(1626);
          this.\u0011.Visible = true;
          this.\u0011.VisibleIndex = 6;
          this.\u0011.Width = 90;
          this.\u0012.Caption = \u0005.\u0004.\u0001(1639);
          this.\u0012.DisplayFormat.FormatString = \u0005.\u0004.\u0001(1656);
          this.\u0012.DisplayFormat.FormatType = FormatType.Numeric;
          this.\u0012.FieldName = \u0005.\u0004.\u0001(1661);
          this.\u0012.Name = \u0005.\u0004.\u0001(1674);
          this.\u0012.Visible = true;
          this.\u0012.VisibleIndex = 7;
          this.\u0012.Width = 77;
          this.\u0013.Caption = \u0005.\u0004.\u0001(1691);
          this.\u0013.DisplayFormat.FormatString = \u0005.\u0004.\u0001(1656);
          this.\u0013.DisplayFormat.FormatType = FormatType.Numeric;
          this.\u0013.FieldName = \u0005.\u0004.\u0001(1700);
          this.\u0013.Name = \u0005.\u0004.\u0001(1709);
          this.\u0013.Visible = true;
          this.\u0013.VisibleIndex = 8;
          this.\u0013.Width = 52;
          this.\u0014.Caption = \u0005.\u0004.\u0001(1722);
          this.\u0014.ColumnEdit = (RepositoryItem) this.\u0003\u0002;
          this.\u0014.FieldName = \u0005.\u0004.\u0001(1727);
          this.\u0014.Name = \u0005.\u0004.\u0001(1740);
          this.\u0014.Width = 48;
          this.\u0003\u0002.AutoHeight = false;
          EditorButtonCollection buttons9 = this.\u0003\u0002.Buttons;
          editorButtonArray = new EditorButton[1]
          {
            new EditorButton()
          };
          EditorButton[] buttons10 = editorButtonArray;
          buttons9.AddRange(buttons10);
          this.\u0003\u0002.Name = \u0005.\u0004.\u0001(1757);
          this.\u0015.Caption = \u0005.\u0004.\u0001(1790);
          this.\u0015.FieldName = \u0005.\u0004.\u0001(1803);
          this.\u0015.Name = \u0005.\u0004.\u0001(1812);
          this.\u0015.Width = 66;
          this.\u0016.Caption = \u0005.\u0004.\u0001(848);
          this.\u0016.DisplayFormat.FormatString = \u0005.\u0004.\u0001(1656);
          this.\u0016.DisplayFormat.FormatType = FormatType.Numeric;
          this.\u0016.FieldName = \u0005.\u0004.\u0001(1825);
          this.\u0016.Name = \u0005.\u0004.\u0001(1834);
          this.\u0016.OptionsColumn.AllowEdit = false;
          this.\u0016.Visible = true;
          this.\u0016.VisibleIndex = 9;
          this.\u0016.Width = 69;
          this.\u0017.Caption = \u0005.\u0004.\u0001(1847);
          this.\u0017.FieldName = \u0005.\u0004.\u0001(1868);
          this.\u0017.Name = \u0005.\u0004.\u0001(1881);
          this.\u0017.Width = 82;
          this.\u0018.Caption = \u0005.\u0004.\u0001(1898);
          this.\u0018.FieldName = \u0005.\u0004.\u0001(1907);
          this.\u0018.Name = \u0005.\u0004.\u0001(1916);
          this.\u0018.Width = 59;
        }
        this.\u0019.Caption = \u0005.\u0004.\u0001(1929);
        this.\u0019.FieldName = \u0005.\u0004.\u0001(1946);
        this.\u0019.Name = \u0005.\u0004.\u0001(1959);
        this.\u0019.OptionsColumn.AllowEdit = false;
        this.\u0019.Width = 69;
        this.\u001A.Caption = \u0005.\u0004.\u0001(1976);
        this.\u001A.FieldName = \u0005.\u0004.\u0001(1997);
        this.\u001A.Name = \u0005.\u0004.\u0001(2006);
        this.\u001A.OptionsColumn.AllowEdit = false;
        this.\u001A.Width = 93;
        this.\u001B.Caption = \u0005.\u0004.\u0001(2019);
        this.\u001B.FieldName = \u0005.\u0004.\u0001(2036);
        this.\u001B.Name = \u0005.\u0004.\u0001(2045);
        this.\u001B.OptionsColumn.AllowEdit = false;
        this.\u001B.Visible = true;
        this.\u001B.VisibleIndex = 12;
        this.\u001B.Width = 107;
        this.\u001C.Caption = \u0005.\u0004.\u0001(2058);
        this.\u001C.DisplayFormat.FormatString = \u0005.\u0004.\u0001(2071);
        this.\u001C.DisplayFormat.FormatType = FormatType.DateTime;
        this.\u001C.FieldName = \u0005.\u0004.\u0001(2080);
        this.\u001C.Name = \u0005.\u0004.\u0001(2093);
        this.\u001C.OptionsColumn.AllowEdit = false;
        this.\u001C.Visible = true;
        this.\u001C.VisibleIndex = 13;
        this.\u001C.Width = 59;
        this.\u001D.Caption = \u0005.\u0004.\u0001(2110);
        this.\u001D.DisplayFormat.FormatString = \u0005.\u0004.\u0001(2071);
        this.\u001D.DisplayFormat.FormatType = FormatType.DateTime;
        this.\u001D.FieldName = \u0005.\u0004.\u0001(2123);
        this.\u001D.Name = \u0005.\u0004.\u0001(2132);
        this.\u001D.OptionsColumn.AllowEdit = false;
        this.\u001D.Visible = true;
        this.\u001D.VisibleIndex = 14;
        this.\u001D.Width = 57;
        this.\u001E.Caption = \u0005.\u0004.\u0001(2145);
        this.\u001E.ColumnEdit = (RepositoryItem) this.\u0096;
        this.\u001E.FieldName = \u0005.\u0004.\u0001(2154);
        this.\u001E.Name = \u0005.\u0004.\u0001(2171);
        this.\u001E.Visible = true;
        this.\u001E.VisibleIndex = 1;
        this.\u001E.Width = 57;
        this.\u0096.AllowNullInput = DefaultBoolean.True;
        this.\u0096.AutoHeight = false;
        EditorButtonCollection buttons11 = this.\u0096.Buttons;
        editorButtonArray = new EditorButton[1]
        {
          new EditorButton(ButtonPredefines.Combo)
        };
        EditorButton[] buttons12 = editorButtonArray;
        buttons11.AddRange(buttons12);
        this.\u0096.DataSource = (object) this.\u0080;
        this.\u0096.DisplayMember = \u0005.\u0004.\u0001(2192);
        this.\u0096.Name = \u0005.\u0004.\u0001(2201);
        this.\u0096.NullText = \u0005.\u0004.\u0001(2246);
        this.\u0096.ValueMember = \u0005.\u0004.\u0001(1555);
        this.\u0096.View = this.\u0097;
        this.\u0080.DataSource = (object) typeof (KhachHang);
        GridColumnCollection columns3 = this.\u0097.Columns;
        gridColumnArray = new GridColumn[2]
        {
          this.\u0098,
          this.\u0099
        };
        GridColumn[] columns4 = gridColumnArray;
        columns3.AddRange(columns4);
        this.\u0097.FocusRectStyle = DrawFocusRectStyle.RowFocus;
        this.\u0097.Name = \u0005.\u0004.\u0001(2275);
        this.\u0097.OptionsSelection.EnableAppearanceFocusedCell = false;
        this.\u0097.OptionsView.ShowGroupPanel = false;
        this.\u0098.Caption = \u0005.\u0004.\u0001(2324);
        this.\u0098.FieldName = \u0005.\u0004.\u0001(2192);
        this.\u0098.Name = \u0005.\u0004.\u0001(2337);
        this.\u0098.Visible = true;
        this.\u0098.VisibleIndex = 0;
        this.\u0098.Width = 137;
        this.\u0099.Caption = \u0005.\u0004.\u0001(2350);
        this.\u0099.FieldName = \u0005.\u0004.\u0001(2375);
        this.\u0099.Name = \u0005.\u0004.\u0001(2380);
        this.\u0099.Visible = true;
        this.\u0099.VisibleIndex = 1;
        this.\u0099.Width = 361;
        this.\u001F.Caption = \u0005.\u0004.\u0001(2393);
        this.\u001F.ColumnEdit = (RepositoryItem) this.\u009B;
        this.\u001F.FieldName = \u0005.\u0004.\u0001(2402);
        this.\u001F.Name = \u0005.\u0004.\u0001(2415);
        this.\u001F.Visible = true;
        this.\u001F.VisibleIndex = 4;
        this.\u001F.Width = 66;
        this.\u009B.AutoHeight = false;
        EditorButtonCollection buttons13 = this.\u009B.Buttons;
        editorButtonArray = new EditorButton[1]
        {
          new EditorButton(ButtonPredefines.Combo)
        };
        EditorButton[] buttons14 = editorButtonArray;
        buttons13.AddRange(buttons14);
        this.\u009B.DataSource = (object) this.\u0086;
        this.\u009B.DisplayMember = \u0005.\u0004.\u0001(2192);
        this.\u009B.Name = \u0005.\u0004.\u0001(2432);
        this.\u009B.NullText = \u0005.\u0004.\u0001(2461);
        this.\u009B.ValueMember = \u0005.\u0004.\u0001(1555);
        this.\u009B.View = this.\u009C;
        this.\u0086.DataSource = (object) typeof (HangHoa);
        GridColumnCollection columns5 = this.\u009C.Columns;
        gridColumnArray = new GridColumn[2]
        {
          this.\u009F,
          this.\u0001\u0002
        };
        GridColumn[] columns6 = gridColumnArray;
        columns5.AddRange(columns6);
        this.\u009C.FocusRectStyle = DrawFocusRectStyle.RowFocus;
        this.\u009C.Name = \u0005.\u0004.\u0001(2486);
        this.\u009C.OptionsSelection.EnableAppearanceFocusedCell = false;
        this.\u009C.OptionsView.ShowGroupPanel = false;
        this.\u009F.Caption = \u0005.\u0004.\u0001(2499);
        this.\u009F.FieldName = \u0005.\u0004.\u0001(2192);
        this.\u009F.Name = \u0005.\u0004.\u0001(2512);
        this.\u009F.Visible = true;
        this.\u009F.VisibleIndex = 0;
        this.\u009F.Width = 99;
        this.\u0001\u0002.Caption = \u0005.\u0004.\u0001(1504);
        this.\u0001\u0002.FieldName = \u0005.\u0004.\u0001(2375);
        this.\u0001\u0002.Name = \u0005.\u0004.\u0001(2525);
        this.\u0001\u0002.Visible = true;
        this.\u0001\u0002.VisibleIndex = 1;
        this.\u0001\u0002.Width = 399;
        this.\u0091.Caption = \u0005.\u0004.\u0001(2538);
        this.\u0091.FieldName = \u0005.\u0004.\u0001(2551);
        this.\u0091.Name = \u0005.\u0004.\u0001(2560);
        this.\u0091.Visible = true;
        this.\u0091.VisibleIndex = 10;
        this.\u0091.Width = 73;
        this.\u0092.Caption = \u0005.\u0004.\u0001(2573);
        this.\u0092.DisplayFormat.FormatString = \u0005.\u0004.\u0001(2594);
        this.\u0092.DisplayFormat.FormatType = FormatType.Numeric;
        this.\u0092.FieldName = \u0005.\u0004.\u0001(2599);
        this.\u0092.Name = \u0005.\u0004.\u0001(2612);
        this.\u0092.OptionsColumn.AllowEdit = false;
        this.\u0092.Visible = true;
        this.\u0092.VisibleIndex = 11;
        this.\u0092.Width = 122;
        this.\u0093.Caption = \u0005.\u0004.\u0001(2629);
        this.\u0093.FieldName = \u0005.\u0004.\u0001(2646);
        this.\u0093.Name = \u0005.\u0004.\u0001(2655);
        this.\u0093.Visible = true;
        this.\u0093.VisibleIndex = 3;
        this.\u0093.Width = 120;
        this.\u0094.Caption = \u0005.\u0004.\u0001(2350);
        this.\u0094.FieldName = \u0005.\u0004.\u0001(2668);
        this.\u0094.Name = \u0005.\u0004.\u0001(2677);
        this.\u0094.Visible = true;
        this.\u0094.VisibleIndex = 2;
        this.\u0094.Width = 163;
        this.\u0008\u0002.Caption = \u0005.\u0004.\u0001(2690);
        this.\u0008\u0002.FieldName = \u0005.\u0004.\u0001(2703);
        this.\u0008\u0002.Name = \u0005.\u0004.\u0001(2712);
        this.\u0008\u0002.Visible = true;
        this.\u0008\u0002.VisibleIndex = 15;
        this.\u0008\u0002.Width = 84;
        this.\u007F.AutoHeight = false;
        EditorButtonCollection buttons15 = this.\u007F.Buttons;
        editorButtonArray = new EditorButton[1]
        {
          new EditorButton(ButtonPredefines.Combo)
        };
        EditorButton[] buttons16 = editorButtonArray;
        buttons15.AddRange(buttons16);
        this.\u007F.DataSource = (object) this.\u0080;
        this.\u007F.DisplayMember = \u0005.\u0004.\u0001(2192);
        this.\u007F.Name = \u0005.\u0004.\u0001(2725);
        this.\u007F.ValueMember = \u0005.\u0004.\u0001(1555);
        this.\u007F.View = this.\u0081;
        GridColumnCollection columns7 = this.\u0081.Columns;
        gridColumnArray = new GridColumn[2]
        {
          this.\u0082,
          this.\u0083
        };
        GridColumn[] columns8 = gridColumnArray;
        columns7.AddRange(columns8);
        this.\u0081.FocusRectStyle = DrawFocusRectStyle.RowFocus;
        this.\u0081.Name = \u0005.\u0004.\u0001(2754);
        this.\u0081.OptionsSelection.EnableAppearanceFocusedCell = false;
        this.\u0081.OptionsView.EnableAppearanceEvenRow = true;
        this.\u0081.OptionsView.EnableAppearanceOddRow = true;
        this.\u0081.OptionsView.ShowGroupPanel = false;
        this.\u0082.Caption = \u0005.\u0004.\u0001(2324);
        this.\u0082.FieldName = \u0005.\u0004.\u0001(2192);
        this.\u0082.Name = \u0005.\u0004.\u0001(2799);
        this.\u0082.Visible = true;
        this.\u0082.VisibleIndex = 0;
        this.\u0082.Width = 86;
        this.\u0083.Caption = \u0005.\u0004.\u0001(2812);
        this.\u0083.FieldName = \u0005.\u0004.\u0001(2375);
        this.\u0083.Name = \u0005.\u0004.\u0001(2821);
        this.\u0083.Visible = true;
        this.\u0083.VisibleIndex = 1;
        this.\u0083.Width = 412;
        this.\u0084.AutoHeight = false;
        EditorButtonCollection buttons17 = this.\u0084.Buttons;
        editorButtonArray = new EditorButton[1]
        {
          new EditorButton(ButtonPredefines.Combo)
        };
        EditorButton[] buttons18 = editorButtonArray;
        buttons17.AddRange(buttons18);
        this.\u0084.DataSource = (object) this.\u0086;
        this.\u0084.DisplayMember = \u0005.\u0004.\u0001(2192);
        this.\u0084.Name = \u0005.\u0004.\u0001(2830);
        this.\u0084.ValueMember = \u0005.\u0004.\u0001(1555);
        this.\u0084.View = this.\u0087;
        GridColumnCollection columns9 = this.\u0087.Columns;
        gridColumnArray = new GridColumn[2]
        {
          this.\u0088,
          this.\u0089
        };
        GridColumn[] columns10 = gridColumnArray;
        columns9.AddRange(columns10);
        this.\u0087.FocusRectStyle = DrawFocusRectStyle.RowFocus;
        this.\u0087.Name = \u0005.\u0004.\u0001(2855);
        this.\u0087.OptionsSelection.EnableAppearanceFocusedCell = false;
        this.\u0087.OptionsView.EnableAppearanceEvenRow = true;
        this.\u0087.OptionsView.EnableAppearanceOddRow = true;
        this.\u0087.OptionsView.ShowGroupPanel = false;
        this.\u0088.Caption = \u0005.\u0004.\u0001(2324);
        this.\u0088.FieldName = \u0005.\u0004.\u0001(2192);
        this.\u0088.Name = \u0005.\u0004.\u0001(2868);
        this.\u0088.Visible = true;
        this.\u0088.VisibleIndex = 0;
        this.\u0088.Width = 91;
        this.\u0089.Caption = \u0005.\u0004.\u0001(2812);
        this.\u0089.FieldName = \u0005.\u0004.\u0001(2375);
        this.\u0089.Name = \u0005.\u0004.\u0001(2881);
        this.\u0089.Visible = true;
        this.\u0089.VisibleIndex = 1;
        this.\u0089.Width = 407;
        this.\u008A.AutoHeight = false;
        EditorButtonCollection buttons19 = this.\u008A.Buttons;
        editorButtonArray = new EditorButton[1]
        {
          new EditorButton()
        };
        EditorButton[] buttons20 = editorButtonArray;
        buttons19.AddRange(buttons20);
        RepositoryItemSpinEdit repositoryItemSpinEdit = this.\u008A;
        bits = new int[4]{ 1000, 0, 0, 0 };
        Decimal num = new Decimal(bits);
        repositoryItemSpinEdit.Increment = num;
        this.\u008A.Name = \u0005.\u0004.\u0001(2894);
        this.\u0090.AutoHeight = false;
        EditorButtonCollection buttons21 = this.\u0090.Buttons;
        editorButtonArray = new EditorButton[1]
        {
          new EditorButton(ButtonPredefines.Combo)
        };
        EditorButton[] buttons22 = editorButtonArray;
        buttons21.AddRange(buttons22);
        EditorButtonCollection buttons23 = this.\u0090.CalendarTimeProperties.Buttons;
        editorButtonArray = new EditorButton[1]
        {
          new EditorButton()
        };
        EditorButton[] buttons24 = editorButtonArray;
        buttons23.AddRange(buttons24);
        this.\u0090.DisplayFormat.FormatString = \u0005.\u0004.\u0001(2927);
        this.\u0090.DisplayFormat.FormatType = FormatType.DateTime;
        this.\u0090.Name = \u0005.\u0004.\u0001(2940);
        this.\u000F\u0002.AutoHeight = false;
        EditorButtonCollection buttons25 = this.\u000F\u0002.Buttons;
        editorButtonArray = new EditorButton[1]
        {
          new EditorButton(ButtonPredefines.Combo)
        };
        EditorButton[] buttons26 = editorButtonArray;
        buttons25.AddRange(buttons26);
        this.\u000F\u0002.CalendarTimeEditing = DefaultBoolean.True;
        EditorButtonCollection buttons27 = this.\u000F\u0002.CalendarTimeProperties.Buttons;
        editorButtonArray = new EditorButton[1]
        {
          new EditorButton()
        };
        EditorButton[] buttons28 = editorButtonArray;
        buttons27.AddRange(buttons28);
        this.\u000F\u0002.CalendarView = CalendarView.Vista;
        this.\u000F\u0002.DisplayFormat.FormatString = \u0005.\u0004.\u0001(2973);
        this.\u000F\u0002.DisplayFormat.FormatType = FormatType.DateTime;
        this.\u000F\u0002.EditFormat.FormatString = \u0005.\u0004.\u0001(2973);
        this.\u000F\u0002.EditFormat.FormatType = FormatType.DateTime;
        this.\u000F\u0002.Mask.EditMask = \u0005.\u0004.\u0001(2973);
        this.\u000F\u0002.Name = \u0005.\u0004.\u0001(2998);
        this.\u000F\u0002.VistaDisplayMode = DefaultBoolean.True;
        this.\u009D.Caption = \u0005.\u0004.\u0001(2324);
        this.\u009D.FieldName = \u0005.\u0004.\u0001(2192);
        this.\u009D.Name = \u0005.\u0004.\u0001(3031);
        this.\u009D.Visible = true;
        this.\u009D.VisibleIndex = 0;
        this.\u009E.Caption = \u0005.\u0004.\u0001(1504);
        do
        {
          this.\u009E.FieldName = \u0005.\u0004.\u0001(2375);
          this.\u009E.Name = \u0005.\u0004.\u0001(3044);
          this.\u009E.Visible = true;
          this.\u009E.VisibleIndex = 1;
          this.\u0002\u0002.DataReceived += new SerialDataReceivedEventHandler(this.\u0001);
          this.\u000E\u0002.Controls.Add((Control) this.\u0083\u0002);
          this.\u000E\u0002.Controls.Add((Control) this.\u0011\u0002);
          this.\u000E\u0002.Controls.Add((Control) this.\u008F);
          this.\u000E\u0002.Controls.Add((Control) this.\u009A);
          this.\u000E\u0002.Controls.Add((Control) this.\u008E);
          this.\u000E\u0002.Controls.Add((Control) this.\u008D);
          this.\u000E\u0002.Dock = DockStyle.Top;
          this.\u000E\u0002.Location = new Point(0, 0);
          this.\u000E\u0002.LookAndFeel.SkinName = \u0005.\u0004.\u0001(3057);
          this.\u000E\u0002.Name = \u0005.\u0004.\u0001(173);
          this.\u000E\u0002.Size = new Size(1034, 301);
          this.\u000E\u0002.TabIndex = 8;
          this.\u0083\u0002.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
          this.\u0083\u0002.Controls.Add((Control) this.\u0005);
          this.\u0083\u0002.Controls.Add((Control) this.\u0007\u0002);
          this.\u0083\u0002.Controls.Add((Control) this.\u0002);
          this.\u0083\u0002.Controls.Add((Control) this.\u0006\u0002);
          this.\u0083\u0002.Controls.Add((Control) this.\u0003);
          this.\u0083\u0002.Controls.Add((Control) this.\u0004\u0002);
          this.\u0083\u0002.Controls.Add((Control) this.\u008C);
          this.\u0083\u0002.Controls.Add((Control) this.\u0005\u0002);
          this.\u0083\u0002.Controls.Add((Control) this.\u008B);
          this.\u0083\u0002.Controls.Add((Control) this.\u0004);
          this.\u0083\u0002.Location = new Point(529, 82);
          this.\u0083\u0002.LookAndFeel.SkinName = \u0005.\u0004.\u0001(160);
          this.\u0083\u0002.LookAndFeel.UseDefaultLookAndFeel = false;
          this.\u0083\u0002.Name = \u0005.\u0004.\u0001(3066);
          this.\u0083\u0002.Size = new Size(500, 207);
          this.\u0083\u0002.TabIndex = 54;
          this.\u0083\u0002.Text = \u0005.\u0004.\u0001(3087);
          this.\u0011\u0002.Controls.Add((Control) this.\u0084\u0002);
          this.\u0011\u0002.Controls.Add((Control) label13);
          this.\u0011\u0002.Controls.Add((Control) this.\u001D\u0002);
          this.\u0011\u0002.Controls.Add((Control) label12);
          this.\u0011\u0002.Controls.Add((Control) this.\u001E\u0002);
          this.\u0011\u0002.Controls.Add((Control) label11);
          this.\u0011\u0002.Controls.Add((Control) this.\u007F\u0002);
          this.\u0011\u0002.Controls.Add((Control) label10);
          this.\u0011\u0002.Controls.Add((Control) this.\u0080\u0002);
          this.\u0011\u0002.Controls.Add((Control) this.\u0012\u0002);
          this.\u0011\u0002.Controls.Add((Control) this.\u0010\u0002);
          this.\u0011\u0002.Controls.Add((Control) label1);
        }
        while (false);
        this.\u0011\u0002.Controls.Add((Control) label2);
        this.\u0011\u0002.Controls.Add((Control) label3);
        this.\u0011\u0002.Controls.Add((Control) this.\u0013\u0002);
        this.\u0011\u0002.Controls.Add((Control) this.\u0017\u0002);
        this.\u0011\u0002.Controls.Add((Control) label4);
        this.\u0011\u0002.Controls.Add((Control) label5);
        this.\u0011\u0002.Controls.Add((Control) this.\u0018\u0002);
        this.\u0011\u0002.Controls.Add((Control) label6);
        this.\u0011\u0002.Controls.Add((Control) this.\u0019\u0002);
        this.\u0011\u0002.Controls.Add((Control) this.\u001A\u0002);
        this.\u0011\u0002.Controls.Add((Control) label7);
        this.\u0011\u0002.Controls.Add((Control) this.\u001B\u0002);
        this.\u0011\u0002.Controls.Add((Control) label8);
        this.\u0011\u0002.Controls.Add((Control) this.\u001C\u0002);
        this.\u0011\u0002.Controls.Add((Control) label9);
        this.\u0011\u0002.Location = new Point(5, 82);
        this.\u0011\u0002.LookAndFeel.SkinName = \u0005.\u0004.\u0001(160);
        this.\u0011\u0002.LookAndFeel.UseDefaultLookAndFeel = false;
        this.\u0011\u0002.Name = \u0005.\u0004.\u0001(3104);
        this.\u0011\u0002.Size = new Size(505, 207);
        this.\u0011\u0002.TabIndex = 54;
        this.\u0011\u0002.Text = \u0005.\u0004.\u0001(3125);
        this.\u0084\u0002.DataBindings.Add(new Binding(\u0005.\u0004.\u0001(3154), (object) this.\u000E, \u0005.\u0004.\u0001(2703), true));
        this.\u0084\u0002.Location = new Point(55, 159);
        this.\u0084\u0002.Multiline = true;
        this.\u0084\u0002.Name = \u0005.\u0004.\u0001(3163);
        this.\u0084\u0002.Size = new Size(277, 37);
        this.\u0084\u0002.TabIndex = 54;
        this.\u001D\u0002.DataBindings.Add(new Binding(\u0005.\u0004.\u0001(3176), (object) this.\u000E, \u0005.\u0004.\u0001(2599), true));
        SpinEdit spinEdit1 = this.\u001D\u0002;
        bits = new int[4];
        // ISSUE: variable of a boxed type
        __Boxed<Decimal> local1 = (ValueType) new Decimal(bits);
        spinEdit1.EditValue = (object) local1;
        this.\u001D\u0002.Location = new Point(346, 136);
        this.\u001D\u0002.Name = \u0005.\u0004.\u0001(3189);
        EditorButtonCollection buttons29 = this.\u001D\u0002.Properties.Buttons;
        editorButtonArray = new EditorButton[1]
        {
          new EditorButton()
        };
        EditorButton[] buttons30 = editorButtonArray;
        buttons29.AddRange(buttons30);
        this.\u001D\u0002.Properties.DisplayFormat.FormatString = \u0005.\u0004.\u0001(2594);
        this.\u001D\u0002.Properties.DisplayFormat.FormatType = FormatType.Numeric;
        this.\u001D\u0002.Properties.EditFormat.FormatString = \u0005.\u0004.\u0001(2594);
        this.\u001D\u0002.Properties.EditFormat.FormatType = FormatType.Numeric;
        this.\u001D\u0002.Properties.Mask.EditMask = \u0005.\u0004.\u0001(2594);
        this.\u001D\u0002.Size = new Size(147, 20);
        this.\u001D\u0002.TabIndex = 53;
        this.\u001E\u0002.DataBindings.Add(new Binding(\u0005.\u0004.\u0001(3176), (object) this.\u000E, \u0005.\u0004.\u0001(2402), true));
        this.\u001E\u0002.Location = new Point(346, 24);
        this.\u001E\u0002.Name = \u0005.\u0004.\u0001(3214);
        EditorButtonCollection buttons31 = this.\u001E\u0002.Properties.Buttons;
        editorButtonArray = new EditorButton[1]
        {
          new EditorButton(ButtonPredefines.Combo)
        };
        EditorButton[] buttons32 = editorButtonArray;
        buttons31.AddRange(buttons32);
        this.\u001E\u0002.Properties.DataSource = (object) this.\u0086;
        this.\u001E\u0002.Properties.DisplayMember = \u0005.\u0004.\u0001(2192);
        this.\u001E\u0002.Properties.ValueMember = \u0005.\u0004.\u0001(1555);
        this.\u001E\u0002.Properties.View = this.\u001F\u0002;
        this.\u001E\u0002.Size = new Size(147, 20);
        this.\u001E\u0002.TabIndex = 52;
        GridColumnCollection columns11 = this.\u001F\u0002.Columns;
        gridColumnArray = new GridColumn[2]
        {
          this.\u0081\u0002,
          this.\u0082\u0002
        };
        GridColumn[] columns12 = gridColumnArray;
        columns11.AddRange(columns12);
        this.\u001F\u0002.FocusRectStyle = DrawFocusRectStyle.RowFocus;
        this.\u001F\u0002.Name = \u0005.\u0004.\u0001(3251);
        this.\u001F\u0002.OptionsSelection.EnableAppearanceFocusedCell = false;
        this.\u001F\u0002.OptionsView.ShowGroupPanel = false;
        this.\u0081\u0002.Caption = \u0005.\u0004.\u0001(2393);
        this.\u0081\u0002.FieldName = \u0005.\u0004.\u0001(2192);
        this.\u0081\u0002.Name = \u0005.\u0004.\u0001(3292);
        this.\u0081\u0002.Visible = true;
        this.\u0081\u0002.VisibleIndex = 0;
        this.\u0081\u0002.Width = 113;
        this.\u0082\u0002.Caption = \u0005.\u0004.\u0001(3305);
        this.\u0082\u0002.FieldName = \u0005.\u0004.\u0001(2375);
        this.\u0082\u0002.Name = \u0005.\u0004.\u0001(3318);
        this.\u0082\u0002.Visible = true;
        this.\u0082\u0002.VisibleIndex = 1;
        this.\u0082\u0002.Width = 385;
        this.\u007F\u0002.DataBindings.Add(new Binding(\u0005.\u0004.\u0001(3176), (object) this.\u000E, \u0005.\u0004.\u0001(2036), true));
        this.\u007F\u0002.EditValue = (object) null;
        this.\u007F\u0002.Enabled = false;
        this.\u007F\u0002.Location = new Point(55, 45);
        this.\u007F\u0002.Name = \u0005.\u0004.\u0001(3331);
        EditorButtonCollection buttons33 = this.\u007F\u0002.Properties.Buttons;
        editorButtonArray = new EditorButton[1]
        {
          new EditorButton(ButtonPredefines.Combo)
        };
        EditorButton[] buttons34 = editorButtonArray;
        buttons33.AddRange(buttons34);
        EditorButtonCollection buttons35 = this.\u007F\u0002.Properties.CalendarTimeProperties.Buttons;
        editorButtonArray = new EditorButton[1]
        {
          new EditorButton()
        };
        EditorButton[] buttons36 = editorButtonArray;
        buttons35.AddRange(buttons36);
        this.\u007F\u0002.Size = new Size(184, 20);
        this.\u007F\u0002.TabIndex = 51;
        this.\u0080\u0002.DataBindings.Add(new Binding(\u0005.\u0004.\u0001(3176), (object) this.\u000E, \u0005.\u0004.\u0001(2551), true));
        SpinEdit spinEdit2 = this.\u0080\u0002;
        bits = new int[4];
        // ISSUE: variable of a boxed type
        __Boxed<Decimal> local2 = (ValueType) new Decimal(bits);
        spinEdit2.EditValue = (object) local2;
        this.\u0080\u0002.Location = new Point(346, 110);
        this.\u0080\u0002.Name = \u0005.\u0004.\u0001(3348);
        EditorButtonCollection buttons37 = this.\u0080\u0002.Properties.Buttons;
        editorButtonArray = new EditorButton[1]
        {
          new EditorButton()
        };
        EditorButton[] buttons38 = editorButtonArray;
        buttons37.AddRange(buttons38);
        this.\u0080\u0002.Size = new Size(147, 20);
        this.\u0080\u0002.TabIndex = 50;
        this.\u0012\u0002.DataBindings.Add(new Binding(\u0005.\u0004.\u0001(3176), (object) this.\u000E, \u0005.\u0004.\u0001(2646), true));
        this.\u0012\u0002.Location = new Point(55, 108);
        this.\u0012\u0002.Name = \u0005.\u0004.\u0001(3369);
        this.\u0012\u0002.Size = new Size(184, 20);
        this.\u0012\u0002.TabIndex = 24;
        this.\u0010\u0002.Appearance.Font = new Font(\u0005.\u0004.\u0001(1189), 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 163);
        this.\u0010\u0002.Appearance.Options.UseFont = true;
        this.\u0010\u0002.Image = (Image) \u0008.\u0004.refesh;
        this.\u0010\u0002.Location = new Point(346, 162);
        this.\u0010\u0002.LookAndFeel.SkinName = \u0005.\u0004.\u0001(160);
        this.\u0010\u0002.LookAndFeel.UseDefaultLookAndFeel = false;
        this.\u0010\u0002.Name = \u0005.\u0004.\u0001(3390);
        this.\u0010\u0002.Size = new Size(147, 34);
        this.\u0010\u0002.TabIndex = 1;
        this.\u0010\u0002.Text = \u0005.\u0004.\u0001(3403);
        this.\u0013\u0002.DataBindings.Add(new Binding(\u0005.\u0004.\u0001(3176), (object) this.\u000E, \u0005.\u0004.\u0001(2154), true));
        this.\u0013\u0002.Location = new Point(55, 66);
        this.\u0013\u0002.Name = \u0005.\u0004.\u0001(3412);
        EditorButtonCollection buttons39 = this.\u0013\u0002.Properties.Buttons;
        editorButtonArray = new EditorButton[2]
        {
          new EditorButton(ButtonPredefines.Combo),
          new EditorButton(ButtonPredefines.Delete)
        };
        EditorButton[] buttons40 = editorButtonArray;
        buttons39.AddRange(buttons40);
        this.\u0013\u0002.Properties.DataSource = (object) this.\u0080;
        this.\u0013\u0002.Properties.DisplayMember = \u0005.\u0004.\u0001(2192);
        this.\u0013\u0002.Properties.NullText = \u0005.\u0004.\u0001(3449);
        this.\u0013\u0002.Properties.ValueMember = \u0005.\u0004.\u0001(1555);
        this.\u0013\u0002.Properties.View = this.\u0014\u0002;
        this.\u0013\u0002.Size = new Size(184, 20);
        this.\u0013\u0002.TabIndex = 22;
        this.\u0013\u0002.ButtonClick += new ButtonPressedEventHandler(this.\u0001);
        GridColumnCollection columns13 = this.\u0014\u0002.Columns;
        gridColumnArray = new GridColumn[2]
        {
          this.\u0015\u0002,
          this.\u0016\u0002
        };
        GridColumn[] columns14 = gridColumnArray;
        columns13.AddRange(columns14);
        this.\u0014\u0002.FocusRectStyle = DrawFocusRectStyle.RowFocus;
        this.\u0014\u0002.Name = \u0005.\u0004.\u0001(3478);
        this.\u0014\u0002.OptionsSelection.EnableAppearanceFocusedCell = false;
        this.\u0014\u0002.OptionsView.ShowGroupPanel = false;
        this.\u0015\u0002.Caption = \u0005.\u0004.\u0001(2499);
        this.\u0015\u0002.FieldName = \u0005.\u0004.\u0001(2192);
        this.\u0015\u0002.Name = \u0005.\u0004.\u0001(3523);
        this.\u0015\u0002.Visible = true;
        this.\u0015\u0002.VisibleIndex = 0;
        this.\u0015\u0002.Width = 122;
        this.\u0016\u0002.Caption = \u0005.\u0004.\u0001(3536);
        this.\u0016\u0002.FieldName = \u0005.\u0004.\u0001(2375);
        this.\u0016\u0002.Name = \u0005.\u0004.\u0001(3549);
        this.\u0016\u0002.Visible = true;
        this.\u0016\u0002.VisibleIndex = 1;
        this.\u0016\u0002.Width = 388;
        this.\u0017\u0002.DataBindings.Add(new Binding(\u0005.\u0004.\u0001(3176), (object) this.\u000E, \u0005.\u0004.\u0001(1825), true));
        SpinEdit spinEdit3 = this.\u0017\u0002;
        bits = new int[4];
        // ISSUE: variable of a boxed type
        __Boxed<Decimal> local3 = (ValueType) new Decimal(bits);
        spinEdit3.EditValue = (object) local3;
        this.\u0017\u0002.Enabled = false;
        this.\u0017\u0002.Location = new Point(346, 87);
        this.\u0017\u0002.Name = \u0005.\u0004.\u0001(3562);
        this.\u0017\u0002.Properties.Appearance.Font = new Font(\u0005.\u0004.\u0001(100), 8.25f, FontStyle.Bold);
        this.\u0017\u0002.Properties.Appearance.ForeColor = Color.DeepSkyBlue;
        this.\u0017\u0002.Properties.Appearance.Options.UseFont = true;
        this.\u0017\u0002.Properties.Appearance.Options.UseForeColor = true;
        EditorButtonCollection buttons41 = this.\u0017\u0002.Properties.Buttons;
        editorButtonArray = new EditorButton[1]
        {
          new EditorButton()
        };
        EditorButton[] buttons42 = editorButtonArray;
        buttons41.AddRange(buttons42);
        this.\u0017\u0002.Properties.DisplayFormat.FormatString = \u0005.\u0004.\u0001(1656);
        this.\u0017\u0002.Properties.DisplayFormat.FormatType = FormatType.Numeric;
        this.\u0017\u0002.Properties.EditFormat.FormatString = \u0005.\u0004.\u0001(1656);
        this.\u0017\u0002.Properties.EditFormat.FormatType = FormatType.Numeric;
label_7:
        this.\u0017\u0002.Properties.Mask.EditMask = \u0005.\u0004.\u0001(1656);
        this.\u0017\u0002.Size = new Size(147, 20);
        this.\u0017\u0002.TabIndex = 34;
        this.\u0018\u0002.DataBindings.Add(new Binding(\u0005.\u0004.\u0001(3176), (object) this.\u000E, \u0005.\u0004.\u0001(1661), true));
        SpinEdit spinEdit4 = this.\u0018\u0002;
        bits = new int[4];
        // ISSUE: variable of a boxed type
        __Boxed<Decimal> local4 = (ValueType) new Decimal(bits);
        spinEdit4.EditValue = (object) local4;
        this.\u0018\u0002.Location = new Point(346, 45);
        this.\u0018\u0002.Name = \u0005.\u0004.\u0001(3583);
        this.\u0018\u0002.Properties.Appearance.BackColor = Color.White;
        this.\u0018\u0002.Properties.Appearance.ForeColor = Color.Black;
        this.\u0018\u0002.Properties.Appearance.Options.UseBackColor = true;
        this.\u0018\u0002.Properties.Appearance.Options.UseForeColor = true;
        EditorButtonCollection buttons43 = this.\u0018\u0002.Properties.Buttons;
        editorButtonArray = new EditorButton[1]
        {
          new EditorButton()
        };
        EditorButton[] buttons44 = editorButtonArray;
        buttons43.AddRange(buttons44);
        this.\u0018\u0002.Properties.DisplayFormat.FormatString = \u0005.\u0004.\u0001(1656);
        this.\u0018\u0002.Properties.DisplayFormat.FormatType = FormatType.Numeric;
        this.\u0018\u0002.Properties.EditFormat.FormatString = \u0005.\u0004.\u0001(1656);
        this.\u0018\u0002.Properties.EditFormat.FormatType = FormatType.Numeric;
        this.\u0018\u0002.Properties.Mask.EditMask = \u0005.\u0004.\u0001(1656);
        this.\u0018\u0002.Size = new Size(147, 20);
        this.\u0018\u0002.TabIndex = 28;
        this.\u0019\u0002.DataBindings.Add(new Binding(\u0005.\u0004.\u0001(3176), (object) this.\u000E, \u0005.\u0004.\u0001(1574), true));
        SpinEdit spinEdit5 = this.\u0019\u0002;
        bits = new int[4];
        // ISSUE: variable of a boxed type
        __Boxed<Decimal> local5 = (ValueType) new Decimal(bits);
        spinEdit5.EditValue = (object) local5;
        this.\u0019\u0002.Enabled = false;
        this.\u0019\u0002.Location = new Point(92, 24);
        this.\u0019\u0002.Name = \u0005.\u0004.\u0001(3608);
        EditorButtonCollection buttons45 = this.\u0019\u0002.Properties.Buttons;
        editorButtonArray = new EditorButton[1]
        {
          new EditorButton()
        };
        EditorButton[] buttons46 = editorButtonArray;
        buttons45.AddRange(buttons46);
        this.\u0019\u0002.Size = new Size(147, 20);
        this.\u0019\u0002.TabIndex = 25;
        this.\u001A\u0002.DataBindings.Add(new Binding(\u0005.\u0004.\u0001(3176), (object) this.\u000E, \u0005.\u0004.\u0001(1700), true));
        SpinEdit spinEdit6 = this.\u001A\u0002;
        bits = new int[4];
        // ISSUE: variable of a boxed type
        __Boxed<Decimal> local6 = (ValueType) new Decimal(bits);
        spinEdit6.EditValue = (object) local6;
        this.\u001A\u0002.Location = new Point(346, 66);
        this.\u001A\u0002.Name = \u0005.\u0004.\u0001(3633);
        this.\u001A\u0002.Properties.Appearance.BackColor = Color.White;
        this.\u001A\u0002.Properties.Appearance.ForeColor = Color.Black;
        this.\u001A\u0002.Properties.Appearance.Options.UseBackColor = true;
        this.\u001A\u0002.Properties.Appearance.Options.UseForeColor = true;
        EditorButtonCollection buttons47 = this.\u001A\u0002.Properties.Buttons;
        editorButtonArray = new EditorButton[1]
        {
          new EditorButton()
        };
        EditorButton[] buttons48 = editorButtonArray;
        buttons47.AddRange(buttons48);
        this.\u001A\u0002.Properties.DisplayFormat.FormatString = \u0005.\u0004.\u0001(1656);
        this.\u001A\u0002.Properties.DisplayFormat.FormatType = FormatType.Numeric;
        this.\u001A\u0002.Properties.EditFormat.FormatString = \u0005.\u0004.\u0001(1656);
        this.\u001A\u0002.Properties.EditFormat.FormatType = FormatType.Numeric;
        this.\u001A\u0002.Properties.Mask.EditMask = \u0005.\u0004.\u0001(1656);
        this.\u001A\u0002.Size = new Size(147, 20);
        this.\u001A\u0002.TabIndex = 31;
        if (true)
        {
          this.\u001B\u0002.DataBindings.Add(new Binding(\u0005.\u0004.\u0001(3176), (object) this.\u000E, \u0005.\u0004.\u0001(1617), true));
          this.\u001B\u0002.Location = new Point(55, 129);
          this.\u001B\u0002.Name = \u0005.\u0004.\u0001(3650);
          this.\u001B\u0002.Size = new Size(184, 20);
          this.\u001B\u0002.TabIndex = 26;
          this.\u001C\u0002.DataBindings.Add(new Binding(\u0005.\u0004.\u0001(3176), (object) this.\u000E, \u0005.\u0004.\u0001(2668), true));
          this.\u001C\u0002.Location = new Point(55, 87);
          this.\u001C\u0002.Name = \u0005.\u0004.\u0001(3667);
          this.\u001C\u0002.Size = new Size(184, 20);
          this.\u001C\u0002.TabIndex = 23;
          this.AutoScaleDimensions = new SizeF(6f, 13f);
          this.AutoScaleMode = AutoScaleMode.Font;
          this.ClientSize = new Size(1034, 461);
          this.ControlBox = false;
          this.Controls.Add((Control) this.\u0007);
          this.Controls.Add((Control) this.\u0006);
          this.Controls.Add((Control) this.\u000E\u0002);
          this.LookAndFeel.SkinName = \u0005.\u0004.\u0001(3057);
          this.LookAndFeel.UseDefaultLookAndFeel = false;
          this.Name = \u0005.\u0004.\u0001(3688);
          this.Text = \u0005.\u0004.\u0001(3701);
          this.WindowState = FormWindowState.Maximized;
          this.\u0007\u0002.Properties.CalendarTimeProperties.EndInit();
          this.\u0007\u0002.Properties.EndInit();
          this.\u0004\u0002.Properties.CalendarTimeProperties.EndInit();
          this.\u0004\u0002.Properties.EndInit();
          this.\u0006.EndInit();
          this.\u0007.EndInit();
          ((ISupportInitialize) this.\u000E).EndInit();
          this.\u0008.EndInit();
          this.\u0003\u0002.EndInit();
          this.\u0096.EndInit();
          ((ISupportInitialize) this.\u0080).EndInit();
          this.\u0097.EndInit();
          this.\u009B.EndInit();
          ((ISupportInitialize) this.\u0086).EndInit();
          this.\u009C.EndInit();
          this.\u007F.EndInit();
          this.\u0081.EndInit();
          this.\u0084.EndInit();
          this.\u0087.EndInit();
          this.\u008A.EndInit();
          this.\u0090.CalendarTimeProperties.EndInit();
          this.\u0090.EndInit();
          this.\u000F\u0002.CalendarTimeProperties.EndInit();
          this.\u000F\u0002.EndInit();
          this.\u000E\u0002.EndInit();
          this.\u000E\u0002.ResumeLayout(false);
          this.\u000E\u0002.PerformLayout();
          this.\u0083\u0002.EndInit();
          this.\u0083\u0002.ResumeLayout(false);
          this.\u0083\u0002.PerformLayout();
          this.\u0011\u0002.EndInit();
          this.\u0011\u0002.ResumeLayout(false);
          this.\u0011\u0002.PerformLayout();
          this.\u001D\u0002.Properties.EndInit();
          this.\u001E\u0002.Properties.EndInit();
          this.\u001F\u0002.EndInit();
          this.\u007F\u0002.Properties.CalendarTimeProperties.EndInit();
          this.\u007F\u0002.Properties.EndInit();
          this.\u0080\u0002.Properties.EndInit();
          this.\u0012\u0002.Properties.EndInit();
          this.\u0013\u0002.Properties.EndInit();
          this.\u0014\u0002.EndInit();
          this.\u0017\u0002.Properties.EndInit();
          this.\u0018\u0002.Properties.EndInit();
          this.\u0019\u0002.Properties.EndInit();
          this.\u001A\u0002.Properties.EndInit();
          this.\u001B\u0002.Properties.EndInit();
          this.\u001C\u0002.Properties.EndInit();
          this.ResumeLayout(false);
        }
        else
          goto label_2;
      }
      catch (Exception ex)
      {
        object[] objArray = new object[19]
        {
          (object) label1,
          (object) label2,
          (object) label3,
          (object) label4,
          (object) label5,
          (object) label6,
          (object) label7,
          (object) label8,
          (object) label9,
          (object) label10,
          (object) label11,
          (object) label12,
          (object) label13,
          (object) editorButtonArray,
          (object) repositoryItemArray,
          (object) baseViewArray,
          (object) gridColumnArray,
          (object) bits,
          (object) this
        };
        \u0005.\u0008.\u0001(ex, objArray);
        throw;
      }
    }

    public unsafe \u0001()
    {
      EventHandler eventHandler1 = (EventHandler) null;
      EventHandler eventHandler2 = (EventHandler) null;
      EventHandler eventHandler3 = (EventHandler) null;
      EventHandler eventHandler4 = (EventHandler) null;
      AddingNewEventHandler addingNewEventHandler1 = (AddingNewEventHandler) null;
      EventHandler eventHandler5 = (EventHandler) null;
      EventHandler eventHandler6 = (EventHandler) null;
      EventHandler eventHandler7 = (EventHandler) null;
      EventHandler eventHandler8 = (EventHandler) null;
      EventHandler eventHandler9 = (EventHandler) null;
      EventHandler eventHandler10 = (EventHandler) null;
      EventHandler eventHandler11 = (EventHandler) null;
      FormClosingEventHandler closingEventHandler = (FormClosingEventHandler) null;
      EventHandler eventHandler12 = (EventHandler) null;
      this.\u0001 = (IContainer) null;
      this.\u0086\u0002 = new CanDienTuEntities();
      this.\u0087\u0002 = \u0005.\u0004.\u0001(720);
      // ISSUE: explicit constructor call
      base.\u002Ector();
      try
      {
        this.\u0001();
        if (eventHandler1 == null)
          eventHandler1 = (EventHandler) ((_param1, _param2) =>
          {
            DateTime now;
            try
            {
              if (true)
                this.\u0003();
              this.\u0086.DataSource = (object) this.\u0086\u0002.HangHoa;
              this.\u0080.DataSource = (object) this.\u0086\u0002.KhachHang;
              this.\u0005();
              this.\u0004\u0002.EditValue = (object) DateTime.Today;
              now = DateTime.Now;
              this.\u0007\u0002.EditValue = (object) now;
            }
            catch (Exception ex)
            {
              // ISSUE: variable of a boxed type
              __Boxed<DateTime> local = (ValueType) now;
              object obj = _param1;
              EventArgs eventArgs = _param2;
              \u0005.\u0008.\u0001(ex, (object) local, (object) this, obj, (object) eventArgs);
              throw;
            }
          });
        this.Load += eventHandler1;
        SimpleButton simpleButton1 = this.\u0010\u0002;
        if (eventHandler2 == null)
          eventHandler2 = (EventHandler) ((_param1, _param2) =>
          {
            DateTime now;
            try
            {
              if (true)
                goto label_3;
label_2:
              this.\u0004();
              return;
label_3:
              this.\u0086\u0002.SaveChanges();
              this.\u0004\u0002.EditValue = (object) DateTime.Today;
              now = DateTime.Now;
              if (true)
                goto label_4;
label_1:
              this.\u0080.DataSource = (object) this.\u0086\u0002.KhachHang.ToList<KhachHang>();
              goto label_2;
label_4:
              this.\u0007\u0002.EditValue = (object) now;
              this.\u0086.DataSource = (object) this.\u0086\u0002.HangHoa.ToList<HangHoa>();
              goto label_1;
            }
            catch (Exception ex)
            {
              // ISSUE: variable of a boxed type
              __Boxed<DateTime> local = (ValueType) now;
              object obj = _param1;
              EventArgs eventArgs = _param2;
              \u0005.\u0008.\u0001(ex, (object) local, (object) this, obj, (object) eventArgs);
              throw;
            }
          });
        EventHandler eventHandler13 = eventHandler2;
        simpleButton1.Click += eventHandler13;
        if (eventHandler3 == null)
          eventHandler3 = (EventHandler) ((_param1, _param2) =>
          {
            try
            {
              if (false)
                goto label_2;
label_1:
              if (false)
                return;
              this.\u0004();
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
        this.Shown += eventHandler3;
        SimpleButton simpleButton2 = this.\u0005;
        if (eventHandler4 == null)
          eventHandler4 = (EventHandler) ((_param1, _param2) =>
          {
            try
            {
              do
              {
                do
                  ;
                while (false);
                this.\u000E.AddNew();
              }
              while (false);
            }
            catch (Exception ex)
            {
              object obj = _param1;
              EventArgs eventArgs = _param2;
              \u0005.\u0008.\u0001(ex, (object) this, obj, (object) eventArgs);
              throw;
            }
          });
        EventHandler eventHandler14 = eventHandler4;
        simpleButton2.Click += eventHandler14;
        BindingSource bindingSource1 = this.\u000E;
        if (addingNewEventHandler1 == null)
          addingNewEventHandler1 = (AddingNewEventHandler) ((_param1, _param2) =>
          {
            // ISSUE: untyped stack allocation
            void* voidPtr1 = (void*) __untypedstackalloc(9);
            DateTime dateTime;
            string str1;
            // ISSUE: variable of a compiler-generated type
            \u0005.\u0001.\u0001 obj1;
            ParameterExpression parameterExpression;
            ParameterExpression[] parameterExpressionArray1;
            List<XeHang> list;
            XeHang xeHang1;
            \u0001.\u0002 obj2;
            XeHang xeHang2;
            try
            {
              // ISSUE: object of a compiler-generated type is created
              obj1 = new \u0005.\u0001.\u0001();
              this.\u0086\u0002.SaveChanges();
              *(int*) voidPtr1 = 0;
              DateTime now = DateTime.Now;
              if (true)
                goto label_6;
label_2:
              string str2 = \u0005.\u0004.\u0001(4102);
              *(int*) ((IntPtr) voidPtr1 + 4) = dateTime.Month;
              string str3 = ((int*) ((IntPtr) voidPtr1 + 4))->ToString();
              string str4 = \u0005.\u0004.\u0001(4107);
              *(int*) ((IntPtr) voidPtr1 + 4) = dateTime.Year;
              string str5 = ((int*) ((IntPtr) voidPtr1 + 4))->ToString();
              str1 = str2 + str3 + str4 + str5;
              // ISSUE: reference to a compiler-generated field
              obj1.\u0001 = this.\u0001(str1);
              IntPtr num1 = (IntPtr) voidPtr1 + 8;
              ObjectSet<XeHang> xeHang3 = this.\u0086\u0002.XeHang;
              parameterExpression = Expression.Parameter(typeof (XeHang), \u0005.\u0004.\u0001(4088));
              // ISSUE: method reference
              // ISSUE: field reference
              // ISSUE: method reference
              BinaryExpression body1 = Expression.GreaterThanOrEqual((Expression) Expression.Property((Expression) parameterExpression, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (XeHang.get_Ngay))), (Expression) Expression.Convert((Expression) Expression.Field((Expression) Expression.Constant((object) obj1), FieldInfo.GetFieldFromHandle(__fieldref (\u0005.\u0001.\u0001.\u0001))), typeof (DateTime?)), false, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (DateTime.op_GreaterThanOrEqual)));
              parameterExpressionArray1 = new ParameterExpression[1]
              {
                parameterExpression
              };
              ParameterExpression[] parameterExpressionArray2 = parameterExpressionArray1;
              Expression<Func<XeHang, bool>> predicate1 = Expression.Lambda<Func<XeHang, bool>>((Expression) body1, parameterExpressionArray2);
              int num2 = xeHang3.Where<XeHang>(predicate1).ToList<XeHang>().Count <= 0 ? 1 : 0;
              *(sbyte*) num1 = (sbyte) num2;
              if (*(sbyte*) ((IntPtr) voidPtr1 + 8) == (sbyte) 0)
              {
                ObjectSet<XeHang> xeHang4 = this.\u0086\u0002.XeHang;
                parameterExpression = Expression.Parameter(typeof (XeHang), \u0005.\u0004.\u0001(4088));
                // ISSUE: method reference
                // ISSUE: field reference
                // ISSUE: method reference
                BinaryExpression body2 = Expression.GreaterThanOrEqual((Expression) Expression.Property((Expression) parameterExpression, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (XeHang.get_Ngay))), (Expression) Expression.Convert((Expression) Expression.Field((Expression) Expression.Constant((object) obj1), FieldInfo.GetFieldFromHandle(__fieldref (\u0005.\u0001.\u0001.\u0001))), typeof (DateTime?)), false, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (DateTime.op_GreaterThanOrEqual)));
                parameterExpressionArray1 = new ParameterExpression[1]
                {
                  parameterExpression
                };
                ParameterExpression[] parameterExpressionArray3 = parameterExpressionArray1;
                Expression<Func<XeHang, bool>> predicate2 = Expression.Lambda<Func<XeHang, bool>>((Expression) body2, parameterExpressionArray3);
                list = xeHang4.Where<XeHang>(predicate2).ToList<XeHang>();
                xeHang1 = list.ToList<XeHang>().OrderByDescending<XeHang, int>((Func<XeHang, int>) (_param0 =>
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
                      XeHang xeHang5 = _param0;
                      \u0005.\u0008.\u0001(ex, (object) local, (object) xeHang5);
                      throw;
                    }
                  }
                  while (false);
                  return *(int*) ((IntPtr) voidPtr2 + 4);
                })).First<XeHang>();
                *(int*) voidPtr1 = xeHang1.SoChungTu + 1;
              }
              else
                *(int*) voidPtr1 = 1;
              obj2 = new \u0001.\u0002();
              AddingNewEventArgs addingNewEventArgs = _param2;
              xeHang2 = new XeHang();
              xeHang2.Id = Guid.NewGuid();
              xeHang2.Ngay = new DateTime?(DateTime.Now);
              xeHang2.SoChungTu = *(int*) voidPtr1;
              XeHang xeHang6 = xeHang2;
              ObjectSet<HangHoa> hangHoa1 = this.\u0086\u0002.HangHoa;
              parameterExpression = Expression.Parameter(typeof (HangHoa), \u0005.\u0004.\u0001(4088));
              // ISSUE: method reference
              MemberExpression body3 = Expression.Property((Expression) parameterExpression, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (HangHoa.get_SapXep)));
              parameterExpressionArray1 = new ParameterExpression[1]
              {
                parameterExpression
              };
              ParameterExpression[] parameterExpressionArray4 = parameterExpressionArray1;
              Expression<Func<HangHoa, int>> keySelector = Expression.Lambda<Func<HangHoa, int>>((Expression) body3, parameterExpressionArray4);
              HangHoa hangHoa2 = hangHoa1.OrderBy<HangHoa, int>(keySelector).First<HangHoa>();
              xeHang6.HangHoa = hangHoa2;
              XeHang xeHang7 = xeHang2;
              addingNewEventArgs.NewObject = (object) xeHang7;
              return;
label_6:
              dateTime = now;
              goto label_2;
            }
            catch (Exception ex)
            {
              object[] objArray = new object[15]
              {
                (object) *(int*) voidPtr1,
                (object) dateTime,
                (object) str1,
                (object) list,
                (object) xeHang1,
                (object) obj2,
                (object) xeHang2,
                (object) obj1,
                (object) *(int*) ((IntPtr) voidPtr1 + 4),
                (object) parameterExpression,
                (object) parameterExpressionArray1,
                (object) (bool) *(sbyte*) ((IntPtr) voidPtr1 + 8),
                (object) this,
                _param1,
                (object) _param2
              };
              \u0005.\u0008.\u0001(ex, objArray);
              throw;
            }
          });
        AddingNewEventHandler addingNewEventHandler2 = addingNewEventHandler1;
        bindingSource1.AddingNew += addingNewEventHandler2;
        SimpleButton simpleButton3 = this.\u008D;
        if (eventHandler5 == null)
          eventHandler5 = (EventHandler) ((_param1, _param2) =>
          {
            bool flag;
            DateTime now;
            \u0008.\u0005 obj3;
            \u0001.\u0002 obj4;
            try
            {
              flag = this.\u000E.Current == null;
              do
              {
                if (false)
                  goto label_6;
                else
                  goto label_11;
label_2:
                if (!flag)
                {
                  if (true)
                  {
                    now = DateTime.Now;
                    \u0004.\u0006.\u0002(this.\u000E.Current, obj3.DiaChi, obj3.Ten, obj3.DienThoai, obj3.CongTyCan, obj3.TieuDeLoGo, now);
                    goto label_8;
                  }
                  else
                    goto label_8;
                }
                else
                  flag = !(obj4.GiayInOto == \u0005.\u0004.\u0001(4125));
label_6:
                if (!flag)
                {
                  now = DateTime.Now;
                  \u0004.\u0006.\u0001(this.\u000E.Current, obj3.DiaChi, obj3.Ten, obj3.DienThoai, obj3.CongTyCan, obj3.TieuDeLoGo, now);
                  if (false)
                    goto label_2;
                }
label_8:
label_9:
                continue;
label_11:
                if (!flag)
                {
                  obj3 = new \u0008.\u0005();
                  \u0001.\u0002 obj5 = new \u0001.\u0002();
                  if (true)
                    obj4 = obj5;
                  flag = !(obj4.GiayInOto == \u0005.\u0004.\u0001(4112));
                  goto label_2;
                }
                else
                  goto label_9;
              }
              while (false);
            }
            catch (Exception ex)
            {
              \u0008.\u0005 obj6 = obj3;
              \u0001.\u0002 obj7 = obj4;
              // ISSUE: variable of a boxed type
              __Boxed<DateTime> local1 = (ValueType) now;
              // ISSUE: variable of a boxed type
              __Boxed<bool> local2 = (ValueType) flag;
              object obj8 = _param1;
              EventArgs eventArgs = _param2;
              \u0005.\u0008.\u0001(ex, (object) obj6, (object) obj7, (object) local1, (object) local2, (object) this, obj8, (object) eventArgs);
              throw;
            }
          });
        EventHandler eventHandler15 = eventHandler5;
        simpleButton3.Click += eventHandler15;
        SimpleButton simpleButton4 = this.\u0002;
        if (eventHandler6 == null)
          eventHandler6 = (EventHandler) ((_param1, _param2) =>
          {
label_0:
            XeHang current;
            bool flag;
            try
            {
              flag = this.\u000E.Current == null;
              if (flag)
                return;
              flag = XtraMessageBox.Show(\u0005.\u0004.\u0001(4138), \u0005.\u0004.\u0001(4171), MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes;
              if (flag)
                goto label_6;
label_3:
              if (false)
                return;
              current = (XeHang) this.\u000E.Current;
              if (true)
              {
                this.\u0086\u0002.XeHang.DeleteObject(current);
                this.\u0086\u0002.SaveChanges();
                this.\u0004();
              }
              else
                goto label_0;
label_6:
              if (false)
                goto label_3;
            }
            catch (Exception ex)
            {
              XeHang xeHang = current;
              // ISSUE: variable of a boxed type
              __Boxed<bool> local = (ValueType) flag;
              object obj = _param1;
              EventArgs eventArgs = _param2;
              \u0005.\u0008.\u0001(ex, (object) xeHang, (object) local, (object) this, obj, (object) eventArgs);
              throw;
            }
          });
        EventHandler eventHandler16 = eventHandler6;
        simpleButton4.Click += eventHandler16;
        SimpleButton simpleButton5 = this.\u008E;
        if (eventHandler7 == null)
          eventHandler7 = (EventHandler) ((_param1, _param2) =>
          {
            // ISSUE: untyped stack allocation
            void* voidPtr = (void*) __untypedstackalloc(5);
            \u0001.\u0002 obj9;
            object rowCellValue;
            try
            {
              *(int*) voidPtr = this.\u000E.Position;
              rowCellValue = this.\u0008.GetRowCellValue(*(int*) voidPtr, \u0005.\u0004.\u0001(1700));
              *(sbyte*) ((IntPtr) voidPtr + 4) = (sbyte) (*(int*) voidPtr >= 0);
              if (*(sbyte*) ((IntPtr) voidPtr + 4) == (sbyte) 0)
              {
                int num3 = (int) XtraMessageBox.Show(\u0005.\u0004.\u0001(4188), \u0005.\u0004.\u0001(643), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
              }
              else
              {
                obj9 = new \u0001.\u0002();
                *(sbyte*) ((IntPtr) voidPtr + 4) = (sbyte) !(obj9.CanTiep == \u0005.\u0004.\u0001(3771));
                if (*(sbyte*) ((IntPtr) voidPtr + 4) == (sbyte) 0)
                {
                  if (true)
                    this.\u0008.SetRowCellValue(*(int*) voidPtr, \u0005.\u0004.\u0001(1700), (object) this.\u009A.Text.ToString());
                  else
                    goto label_10;
                }
                else
                  goto label_7;
label_6:
                this.\u0008.SetRowCellValue(*(int*) voidPtr, \u0005.\u0004.\u0001(2123), (object) DateTime.Now);
                this.\u0008.RefreshData();
                goto label_14;
label_7:
                *(sbyte*) ((IntPtr) voidPtr + 4) = (sbyte) !(obj9.CanTiep == \u0005.\u0004.\u0001(4213));
                if (*(sbyte*) ((IntPtr) voidPtr + 4) == (sbyte) 0)
                {
                  *(sbyte*) ((IntPtr) voidPtr + 4) = (sbyte) ((double) rowCellValue <= 1.0);
                  if (*(sbyte*) ((IntPtr) voidPtr + 4) == (sbyte) 0)
                  {
                    int num4 = (int) XtraMessageBox.Show(\u0005.\u0004.\u0001(4218), \u0005.\u0004.\u0001(643), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    goto label_12;
                  }
                }
                else
                  goto label_13;
label_10:
                this.\u0008.SetRowCellValue(*(int*) voidPtr, \u0005.\u0004.\u0001(1700), (object) this.\u009A.Text.ToString());
                if (true)
                {
                  this.\u0008.SetRowCellValue(*(int*) voidPtr, \u0005.\u0004.\u0001(2123), (object) DateTime.Now);
                  this.\u0008.RefreshData();
                }
                else
                  goto label_6;
label_12:
label_13:
label_14:;
              }
            }
            catch (Exception ex)
            {
              // ISSUE: variable of a boxed type
              __Boxed<int> local3 = (ValueType) *(int*) voidPtr;
              object obj10 = rowCellValue;
              \u0001.\u0002 obj11 = obj9;
              // ISSUE: variable of a boxed type
              __Boxed<bool> local4 = (ValueType) (bool) *(sbyte*) ((IntPtr) voidPtr + 4);
              object obj12 = _param1;
              EventArgs eventArgs = _param2;
              \u0005.\u0008.\u0001(ex, (object) local3, obj10, (object) obj11, (object) local4, (object) this, obj12, (object) eventArgs);
              throw;
            }
          });
        EventHandler eventHandler17 = eventHandler7;
        simpleButton5.Click += eventHandler17;
        SimpleButton simpleButton6 = this.\u008F;
        if (eventHandler8 == null)
          eventHandler8 = (EventHandler) ((_param1, _param2) =>
          {
            // ISSUE: untyped stack allocation
            void* voidPtr = (void*) __untypedstackalloc(5);
            \u0001.\u0002 obj13;
            object rowCellValue;
            try
            {
              *(int*) voidPtr = this.\u000E.Position;
              rowCellValue = this.\u0008.GetRowCellValue(*(int*) voidPtr, \u0005.\u0004.\u0001(1661));
              *(sbyte*) ((IntPtr) voidPtr + 4) = (sbyte) (*(int*) voidPtr >= 0);
              if (*(sbyte*) ((IntPtr) voidPtr + 4) == (sbyte) 0)
              {
                int num5 = (int) XtraMessageBox.Show(\u0005.\u0004.\u0001(4188), \u0005.\u0004.\u0001(643), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
              }
              else
              {
                obj13 = new \u0001.\u0002();
                *(sbyte*) ((IntPtr) voidPtr + 4) = (sbyte) !(obj13.CanTiep == \u0005.\u0004.\u0001(3771));
                if (*(sbyte*) ((IntPtr) voidPtr + 4) == (sbyte) 0)
                {
                  if (true)
                    this.\u0008.SetRowCellValue(*(int*) voidPtr, \u0005.\u0004.\u0001(1661), (object) this.\u009A.Text.ToString());
                  else
                    goto label_10;
                }
                else
                  goto label_7;
label_6:
                this.\u0008.SetRowCellValue(*(int*) voidPtr, \u0005.\u0004.\u0001(2080), (object) DateTime.Now);
                this.\u0008.RefreshData();
                goto label_14;
label_7:
                *(sbyte*) ((IntPtr) voidPtr + 4) = (sbyte) !(obj13.CanTiep == \u0005.\u0004.\u0001(4213));
                if (*(sbyte*) ((IntPtr) voidPtr + 4) == (sbyte) 0)
                {
                  *(sbyte*) ((IntPtr) voidPtr + 4) = (sbyte) ((double) rowCellValue <= 1.0);
                  if (*(sbyte*) ((IntPtr) voidPtr + 4) == (sbyte) 0)
                  {
                    int num6 = (int) XtraMessageBox.Show(\u0005.\u0004.\u0001(4218), \u0005.\u0004.\u0001(643), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    goto label_12;
                  }
                }
                else
                  goto label_13;
label_10:
                this.\u0008.SetRowCellValue(*(int*) voidPtr, \u0005.\u0004.\u0001(1661), (object) this.\u009A.Text.ToString());
                if (true)
                {
                  this.\u0008.SetRowCellValue(*(int*) voidPtr, \u0005.\u0004.\u0001(2080), (object) DateTime.Now);
                  this.\u0008.RefreshData();
                }
                else
                  goto label_6;
label_12:
label_13:
label_14:;
              }
            }
            catch (Exception ex)
            {
              // ISSUE: variable of a boxed type
              __Boxed<int> local5 = (ValueType) *(int*) voidPtr;
              object obj14 = rowCellValue;
              \u0001.\u0002 obj15 = obj13;
              // ISSUE: variable of a boxed type
              __Boxed<bool> local6 = (ValueType) (bool) *(sbyte*) ((IntPtr) voidPtr + 4);
              object obj16 = _param1;
              EventArgs eventArgs = _param2;
              \u0005.\u0008.\u0001(ex, (object) local5, obj14, (object) obj15, (object) local6, (object) this, obj16, (object) eventArgs);
              throw;
            }
          });
        EventHandler eventHandler18 = eventHandler8;
        simpleButton6.Click += eventHandler18;
        SimpleButton simpleButton7 = this.\u008C;
        if (eventHandler9 == null)
          eventHandler9 = (EventHandler) ((_param1, _param2) =>
          {
label_0:
            try
            {
              if (false)
                goto label_3;
label_1:
              if (true)
              {
                BindingSource bindingSource2 = this.\u000E;
                if (true)
                  goto label_6;
label_2:
                goto label_3;
label_6:
                bindingSource2.Position = 0;
                goto label_2;
              }
              else
                goto label_0;
label_3:
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
        EventHandler eventHandler19 = eventHandler9;
        simpleButton7.Click += eventHandler19;
        SimpleButton simpleButton8 = this.\u008B;
        if (eventHandler10 == null)
          eventHandler10 = (EventHandler) ((_param1, _param2) =>
          {
            int num;
            try
            {
              do
              {
                if (true)
                {
                  if (false)
                    ;
                  if (true)
                  {
                    int rowCount = this.\u0008.RowCount;
                    if (true)
                      num = rowCount;
                  }
                  this.\u000E.Position = num - 1;
                }
              }
              while (false);
            }
            catch (Exception ex)
            {
              // ISSUE: variable of a boxed type
              __Boxed<int> local = (ValueType) num;
              object obj = _param1;
              EventArgs eventArgs = _param2;
              \u0005.\u0008.\u0001(ex, (object) local, (object) this, obj, (object) eventArgs);
              throw;
            }
          });
        EventHandler eventHandler20 = eventHandler10;
        simpleButton8.Click += eventHandler20;
        SimpleButton simpleButton9 = this.\u0004;
        if (eventHandler11 == null)
          eventHandler11 = (EventHandler) ((_param1, _param2) =>
          {
            try
            {
              do
              {
                do
                  ;
                while (false);
                this.\u0086\u0002.SaveChanges();
              }
              while (false);
            }
            catch (Exception ex)
            {
              object obj = _param1;
              EventArgs eventArgs = _param2;
              \u0005.\u0008.\u0001(ex, (object) this, obj, (object) eventArgs);
              throw;
            }
          });
        EventHandler eventHandler21 = eventHandler11;
        simpleButton9.Click += eventHandler21;
        if (closingEventHandler == null)
          closingEventHandler = (FormClosingEventHandler) ((_param1, _param2) =>
          {
            bool flag;
            try
            {
              int num = \u0004.\u0005.\u0001(this.\u0086\u0002) ? 1 : 0;
              if (true)
                goto label_3;
label_1:
              if (num != 0)
                return;
              _param2.Cancel = true;
              return;
label_3:
              flag = num != 0;
              num = flag ? 1 : 0;
              goto label_1;
            }
            catch (Exception ex)
            {
              // ISSUE: variable of a boxed type
              __Boxed<bool> local = (ValueType) flag;
              object obj = _param1;
              FormClosingEventArgs closingEventArgs = _param2;
              \u0005.\u0008.\u0001(ex, (object) local, (object) this, obj, (object) closingEventArgs);
              throw;
            }
          });
        this.FormClosing += closingEventHandler;
        SimpleButton simpleButton10 = this.\u0003;
        if (eventHandler12 == null)
          eventHandler12 = (EventHandler) ((_param1, _param2) =>
          {
            try
            {
              do
              {
                this.\u0086\u0002.SaveChanges();
                this.Close();
              }
              while (false);
            }
            catch (Exception ex)
            {
              object obj = _param1;
              EventArgs eventArgs = _param2;
              \u0005.\u0008.\u0001(ex, (object) this, obj, (object) eventArgs);
              throw;
            }
          });
        EventHandler eventHandler22 = eventHandler12;
        simpleButton10.Click += eventHandler22;
      }
      catch (Exception ex)
      {
        object[] objArray = new object[15]
        {
          (object) eventHandler1,
          (object) eventHandler2,
          (object) eventHandler3,
          (object) eventHandler4,
          (object) addingNewEventHandler1,
          (object) eventHandler5,
          (object) eventHandler6,
          (object) eventHandler7,
          (object) eventHandler8,
          (object) eventHandler9,
          (object) eventHandler10,
          (object) eventHandler11,
          (object) closingEventHandler,
          (object) eventHandler12,
          (object) this
        };
        \u0005.\u0008.\u0001(ex, objArray);
        throw;
      }
    }

    private void \u0002()
    {
      bool flag;
      WaitDialogForm waitDialogForm1;
      try
      {
        waitDialogForm1 = new WaitDialogForm(\u0005.\u0004.\u0001(3734));
        try
        {
          while (true)
          {
            flag = !this.\u0002\u0002.IsOpen;
            if (true)
            {
              if (!flag)
              {
                Application.DoEvents();
                goto label_10;
              }
              else
                goto label_6;
            }
          }
label_3:
label_4:
          if (true)
            Thread.Sleep(600);
          else
            goto label_10;
label_6:
          if (true)
            return;
          goto label_4;
label_10:
          this.\u0002\u0002.Dispose();
          this.\u0002\u0002.Close();
          Application.DoEvents();
          goto label_3;
        }
        finally
        {
          if (true)
          {
            flag = waitDialogForm1 == null;
            if (!flag)
              waitDialogForm1.Dispose();
          }
        }
      }
      catch (Exception ex)
      {
        WaitDialogForm waitDialogForm2 = waitDialogForm1;
        // ISSUE: variable of a boxed type
        __Boxed<bool> local = (ValueType) flag;
        \u0005.\u0008.\u0001(ex, (object) waitDialogForm2, (object) local, (object) this);
        throw;
      }
    }

    virtual void Form.\u0001(CancelEventArgs _param1)
    {
      try
      {
        if (true)
          goto label_4;
label_2:
        if (true)
          return;
label_4:
        if (true)
          goto label_5;
label_1:
        do
        {
          // ISSUE: explicit non-virtual call
          __nonvirtual (((Form) this).OnClosing(_param1));
        }
        while (false);
        goto label_2;
label_5:
        this.\u0002();
        goto label_1;
      }
      catch (Exception ex)
      {
        CancelEventArgs cancelEventArgs = _param1;
        \u0005.\u0008.\u0001(ex, (object) this, (object) cancelEventArgs);
        throw;
      }
    }

    public void \u0003()
    {
label_0:
      \u0001.\u0002 obj1;
      bool flag;
      try
      {
        obj1 = new \u0001.\u0002();
        flag = !(obj1.CanTuDongOto == \u0005.\u0004.\u0001(3771));
        if (flag)
          return;
        this.\u0013.OptionsColumn.AllowEdit = false;
        this.\u0012.OptionsColumn.AllowEdit = false;
        if (true)
        {
          this.\u0018\u0002.Enabled = false;
          if (false)
            ;
          this.\u001A\u0002.Enabled = false;
          this.\u001D.OptionsColumn.AllowEdit = false;
          this.\u001C.OptionsColumn.AllowEdit = false;
        }
        else
          goto label_0;
      }
      catch (Exception ex)
      {
        \u0001.\u0002 obj2 = obj1;
        // ISSUE: variable of a boxed type
        __Boxed<bool> local = (ValueType) flag;
        \u0005.\u0008.\u0001(ex, (object) obj2, (object) local, (object) this);
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

    private unsafe int \u0001(object _param1)
    {
      // ISSUE: untyped stack allocation
      void* voidPtr = (void*) __untypedstackalloc(13);
      try
      {
        *(sbyte*) ((IntPtr) voidPtr + 12) = (sbyte) (_param1 != null);
        if (*(sbyte*) ((IntPtr) voidPtr + 12) != (sbyte) 0)
          goto label_4;
        else
          goto label_3;
label_2:
        *(int*) ((IntPtr) voidPtr + 8) = *(int*) ((IntPtr) voidPtr + 4);
        goto label_6;
label_3:
        *(int*) ((IntPtr) voidPtr + 4) = 0;
        goto label_2;
label_4:
        *(int*) voidPtr = 0;
        int.TryParse(_param1.ToString(), out *(int*) voidPtr);
        *(int*) ((IntPtr) voidPtr + 4) = *(int*) voidPtr;
        goto label_2;
      }
      catch (Exception ex)
      {
        // ISSUE: variable of a boxed type
        __Boxed<int> local1 = (ValueType) *(int*) voidPtr;
        // ISSUE: variable of a boxed type
        __Boxed<int> local2 = (ValueType) *(int*) ((IntPtr) voidPtr + 4);
        // ISSUE: variable of a boxed type
        __Boxed<bool> local3 = (ValueType) (bool) *(sbyte*) ((IntPtr) voidPtr + 12);
        object obj = _param1;
        \u0005.\u0008.\u0001(ex, (object) local1, (object) local2, (object) local3, (object) this, obj);
        throw;
      }
label_6:
      return *(int*) ((IntPtr) voidPtr + 8);
    }

    public void \u0001(object _param1)
    {
      object[] objArray1;
      bool flag;
      try
      {
        if (false)
          return;
        flag = !this.InvokeRequired;
        if (flag)
        {
          this.\u000E.DataSource = _param1;
        }
        else
        {
          // ISSUE: method pointer
          Action<object> method = new Action<object>((object) this, __methodptr(\u0001));
          objArray1 = new object[1]{ _param1 };
          object[] objArray2 = objArray1;
          this.Invoke((Delegate) method, objArray2);
        }
      }
      catch (Exception ex)
      {
        // ISSUE: variable of a boxed type
        __Boxed<bool> local = (ValueType) flag;
        object[] objArray3 = objArray1;
        object obj = _param1;
        \u0005.\u0008.\u0001(ex, (object) local, (object) objArray3, (object) this, obj);
        throw;
      }
    }

    private void \u0004()
    {
      try
      {
        do
          ;
        while (false);
        // ISSUE: method pointer
        new Task(new Action((object) this, __methodptr(\u0006))).Start();
      }
      catch (Exception ex)
      {
        \u0005.\u0008.\u0001(ex, (object) this);
        throw;
      }
    }

    private void \u0001(object _param1, CustomColumnDataEventArgs _param2)
    {
      bool flag;
      try
      {
        if (false)
          ;
label_11:
        int num1 = _param2.Column.FieldName == \u0005.\u0004.\u0001(1574) ? 1 : 0;
        int num2;
        while (true)
        {
          if (num1 != 0)
          {
            if (true)
              num2 = _param2.IsSetData ? 1 : 0;
            else
              goto label_11;
          }
          else
            goto label_4;
label_3:
          int num3 = num2 == 0 ? 1 : 0;
          goto label_13;
label_4:
          num3 = 1;
label_13:
          while (true)
          {
            flag = num3 != 0;
            num2 = flag ? 1 : 0;
            if (false)
              num3 = num2;
            else
              break;
          }
          if (false)
            num1 = num2;
          else if (false)
            goto label_3;
          else
            break;
        }
        if (num2 != 0)
          return;
        _param2.Value = (object) (_param2.ListSourceRowIndex + 1);
      }
      catch (Exception ex)
      {
        // ISSUE: variable of a boxed type
        __Boxed<bool> local = (ValueType) flag;
        object obj = _param1;
        CustomColumnDataEventArgs columnDataEventArgs = _param2;
        \u0005.\u0008.\u0001(ex, (object) local, (object) this, obj, (object) columnDataEventArgs);
        throw;
      }
    }

    public void \u0005()
    {
      \u0004.\u0002 obj1;
      string patityOto;
      bool isOpen;
      try
      {
        obj1 = new \u0004.\u0002();
        isOpen = this.\u0002\u0002.IsOpen;
        if (!isOpen)
        {
          try
          {
            this.\u0002\u0002.PortName = obj1.PortNameOto;
label_4:
            this.\u0002\u0002.BaudRate = int.Parse(obj1.BaudrateOto);
label_5:
            this.\u0002\u0002.DataBits = int.Parse(obj1.DataBitsOto);
            do
            {
              if (true)
              {
                patityOto = obj1.PatityOto;
                if (patityOto != null)
                {
                  int num1 = patityOto == \u0005.\u0004.\u0001(3793) ? 1 : 0;
                  while (num1 == 0)
                  {
                    int num2 = patityOto == \u0005.\u0004.\u0001(3798) ? 1 : 0;
                    if (false)
                      num1 = num2;
                    else if (num2 == 0)
                    {
                      if (true)
                      {
                        int num3 = patityOto == \u0005.\u0004.\u0001(3807) ? 1 : 0;
                        if (false)
                          num1 = num3;
                        else if (num3 != 0)
                        {
                          this.\u0002\u0002.Parity = Parity.Even;
                          if (false)
                            goto label_18;
                          else
                            goto label_18;
                        }
                        else
                          goto label_18;
                      }
                      else
                        goto label_5;
                    }
                    else
                    {
                      this.\u0002\u0002.Parity = Parity.None;
                      goto label_18;
                    }
                  }
                  this.\u0002\u0002.Parity = Parity.Odd;
                }
label_18:;
              }
              else
                goto label_4;
            }
            while (false);
            this.\u0002\u0002.StopBits = StopBits.One;
            this.\u0002\u0002.Open();
          }
          catch
          {
            do
            {
              int num = (int) MessageBox.Show(\u0005.\u0004.\u0001(3816), \u0005.\u0004.\u0001(609));
            }
            while (false);
          }
        }
        else
          this.\u0002\u0002.Close();
      }
      catch (Exception ex)
      {
        \u0004.\u0002 obj2 = obj1;
        // ISSUE: variable of a boxed type
        __Boxed<bool> local = (ValueType) isOpen;
        string str = patityOto;
        \u0005.\u0008.\u0001(ex, (object) obj2, (object) local, (object) str, (object) this);
        throw;
      }
    }

    private unsafe void \u0001(object _param1, EventArgs _param2)
    {
      // ISSUE: untyped stack allocation
      void* voidPtr = (void*) __untypedstackalloc(49);
      string[] strArray1;
      string[] strArray2;
      string str1;
      string str2;
      \u0004.\u0002 obj;
      string str3;
      string str4;
      try
      {
        obj = new \u0004.\u0002();
        *(sbyte*) ((IntPtr) voidPtr + 48) = (sbyte) !(obj.ModelCanOto == \u0005.\u0004.\u0001(3966));
        if (*(sbyte*) ((IntPtr) voidPtr + 48) == (sbyte) 0)
        {
          Thread.Sleep(50);
          this.\u0087\u0002 = this.\u0002\u0002.ReadExisting();
          *(sbyte*) ((IntPtr) voidPtr + 48) = (sbyte) (this.\u0087\u0002.Trim().Count<char>() >= 1);
          if (*(sbyte*) ((IntPtr) voidPtr + 48) == (sbyte) 0)
          {
            this.\u0087\u0002 = (string) null;
            int num = (int) MessageBox.Show(\u0005.\u0004.\u0001(3971), \u0005.\u0004.\u0001(4040), MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
          }
          else
          {
            strArray1 = \u0005.\u0001.\u0001(\u0005.\u0001.\u0002(\u0005.\u0001.\u0001(this.\u0087\u0002)), \u0005.\u0004.\u0001(4053));
            strArray2 = strArray1;
            *(int*) ((IntPtr) voidPtr + 44) = 0;
            while (true)
            {
              *(sbyte*) ((IntPtr) voidPtr + 48) = (sbyte) (*(int*) ((IntPtr) voidPtr + 44) < strArray2.Length);
              if (*(sbyte*) ((IntPtr) voidPtr + 48) != (sbyte) 0)
              {
                str1 = strArray2[*(int*) ((IntPtr) voidPtr + 44)];
                str2 = str1;
                *(double*) voidPtr = double.Parse(str2.ToString(), (IFormatProvider) CultureInfo.InvariantCulture);
                this.\u009A.Text = ((double*) voidPtr)->ToString();
                *(int*) ((IntPtr) voidPtr + 44) = *(int*) ((IntPtr) voidPtr + 44) + 1;
              }
              else
                break;
            }
          }
        }
        else
        {
          *(sbyte*) ((IntPtr) voidPtr + 48) = (sbyte) !(obj.ModelCanOto == \u0005.\u0004.\u0001(4058));
          if (*(sbyte*) ((IntPtr) voidPtr + 48) == (sbyte) 0)
          {
            *(double*) ((IntPtr) voidPtr + 8) = (double) this.\u0002\u0002.ReadByte();
            *(sbyte*) ((IntPtr) voidPtr + 48) = (sbyte) (*(double*) ((IntPtr) voidPtr + 8) != 2.0);
            if (*(sbyte*) ((IntPtr) voidPtr + 48) != (sbyte) 0)
              return;
            this.\u0087\u0002 = this.\u0002\u0002.ReadExisting();
            Thread.Sleep(50);
            *(sbyte*) ((IntPtr) voidPtr + 48) = (sbyte) (this.\u0087\u0002.Length < 9);
            if (*(sbyte*) ((IntPtr) voidPtr + 48) == (sbyte) 0)
            {
              str3 = this.\u0087\u0002.Substring(0, 1);
              str4 = this.\u0087\u0002.Substring(1, 7);
              str4 = str4.ToString().Trim();
              this.\u0087\u0002 = str3 + str4;
              *(double*) voidPtr = double.Parse(this.\u0087\u0002.ToString(), (IFormatProvider) CultureInfo.InvariantCulture);
              this.\u009A.Text = ((double*) voidPtr)->ToString();
            }
          }
          else
          {
            *(double*) ((IntPtr) voidPtr + 16) = (double) this.\u0002\u0002.ReadByte();
            *(double*) ((IntPtr) voidPtr + 24) = double.Parse(obj.Kytudau);
            *(int*) ((IntPtr) voidPtr + 32) = int.Parse(obj.Vitridau);
            *(int*) ((IntPtr) voidPtr + 36) = int.Parse(obj.Vitriketthuc);
            *(int*) ((IntPtr) voidPtr + 40) = int.Parse(obj.Dodai);
            *(sbyte*) ((IntPtr) voidPtr + 48) = (sbyte) (*(double*) ((IntPtr) voidPtr + 16) != *(double*) ((IntPtr) voidPtr + 24));
            if (*(sbyte*) ((IntPtr) voidPtr + 48) == (sbyte) 0)
            {
              this.\u0087\u0002 = this.\u0002\u0002.ReadExisting();
              Thread.Sleep(50);
              *(sbyte*) ((IntPtr) voidPtr + 48) = (sbyte) (this.\u0087\u0002.Length < *(int*) ((IntPtr) voidPtr + 40));
              if (*(sbyte*) ((IntPtr) voidPtr + 48) == (sbyte) 0)
              {
                this.\u0087\u0002 = this.\u0087\u0002.Substring(*(int*) ((IntPtr) voidPtr + 32), *(int*) ((IntPtr) voidPtr + 36));
                *(double*) voidPtr = double.Parse(this.\u0087\u0002.ToString(), (IFormatProvider) CultureInfo.InvariantCulture);
                *(sbyte*) ((IntPtr) voidPtr + 48) = (sbyte) (double.Parse(obj.ThapPhan) != 0.0);
                if (*(sbyte*) ((IntPtr) voidPtr + 48) == (sbyte) 0)
                  *(double*) voidPtr = *(double*) voidPtr / 1.0;
                *(sbyte*) ((IntPtr) voidPtr + 48) = (sbyte) (double.Parse(obj.ThapPhan) != 1.0);
                if (*(sbyte*) ((IntPtr) voidPtr + 48) == (sbyte) 0)
                  *(double*) voidPtr = *(double*) voidPtr / 10.0;
                *(sbyte*) ((IntPtr) voidPtr + 48) = (sbyte) (double.Parse(obj.ThapPhan) != 2.0);
                if (*(sbyte*) ((IntPtr) voidPtr + 48) == (sbyte) 0)
                  *(double*) voidPtr = *(double*) voidPtr / 100.0;
                *(sbyte*) ((IntPtr) voidPtr + 48) = (sbyte) (double.Parse(obj.ThapPhan) != 3.0);
                if (*(sbyte*) ((IntPtr) voidPtr + 48) == (sbyte) 0)
                  *(double*) voidPtr = *(double*) voidPtr / 1000.0;
                this.\u009A.Text = ((double*) voidPtr)->ToString();
              }
            }
          }
        }
      }
      catch (Exception ex)
      {
        object[] objArray = new object[19]
        {
          (object) obj,
          (object) strArray1,
          (object) str1,
          (object) str2,
          (object) *(double*) voidPtr,
          (object) *(double*) ((IntPtr) voidPtr + 8),
          (object) str3,
          (object) str4,
          (object) *(double*) ((IntPtr) voidPtr + 16),
          (object) *(double*) ((IntPtr) voidPtr + 24),
          (object) *(int*) ((IntPtr) voidPtr + 32),
          (object) *(int*) ((IntPtr) voidPtr + 36),
          (object) *(int*) ((IntPtr) voidPtr + 40),
          (object) (bool) *(sbyte*) ((IntPtr) voidPtr + 48),
          (object) strArray2,
          (object) *(int*) ((IntPtr) voidPtr + 44),
          (object) this,
          _param1,
          (object) _param2
        };
        \u0005.\u0008.\u0001(ex, objArray);
        throw;
      }
    }

    public static string \u0001(string _param0)
    {
      string pattern;
      Regex regex1;
      try
      {
        pattern = \u0005.\u0004.\u0001(4067);
        regex1 = new Regex(pattern);
        return regex1.Replace(_param0, \u0005.\u0004.\u0001(4053));
      }
      catch (Exception ex)
      {
        string str1 = pattern;
        Regex regex2 = regex1;
        string str2;
        string str3 = str2;
        string str4 = _param0;
        \u0005.\u0008.\u0001(ex, (object) str1, (object) regex2, (object) str3, (object) str4);
        throw;
      }
    }

    public static string[] \u0001(string _param0, string _param1)
    {
      string[] strArray1;
      string[] separator;
      try
      {
        strArray1 = new string[1]{ _param1 };
        separator = strArray1;
        return _param0.Split(separator, StringSplitOptions.RemoveEmptyEntries);
      }
      catch (Exception ex)
      {
        string[] strArray2;
        string[] strArray3 = strArray2;
        string[] strArray4 = separator;
        string[] strArray5;
        string[] strArray6 = strArray5;
        string[] strArray7 = strArray1;
        string str1 = _param0;
        string str2 = _param1;
        \u0005.\u0008.\u0001(ex, (object) strArray3, (object) strArray4, (object) strArray6, (object) strArray7, (object) str1, (object) str2);
        throw;
      }
    }

    public static unsafe string \u0002(string _param0)
    {
      // ISSUE: untyped stack allocation
      void* voidPtr = (void*) __untypedstackalloc(5);
      char ch;
      try
      {
        *(int*) voidPtr = 0;
label_6:
        ch = _param0[*(int*) voidPtr];
        *(sbyte*) ((IntPtr) voidPtr + 4) = (sbyte) ch.Equals('0');
        while (*(sbyte*) ((IntPtr) voidPtr + 4) != (sbyte) 0)
        {
          if (true)
          {
            *(int*) voidPtr = *(int*) voidPtr + 1;
            goto label_6;
          }
        }
        return _param0.Substring(*(int*) voidPtr, _param0.Length - *(int*) voidPtr);
      }
      catch (Exception ex)
      {
        // ISSUE: variable of a boxed type
        __Boxed<int> local1 = (ValueType) *(int*) voidPtr;
        string str1;
        string str2 = str1;
        // ISSUE: variable of a boxed type
        __Boxed<char> local2 = (ValueType) ch;
        // ISSUE: variable of a boxed type
        __Boxed<bool> local3 = (ValueType) (bool) *(sbyte*) ((IntPtr) voidPtr + 4);
        string str3 = _param0;
        \u0005.\u0008.\u0001(ex, (object) local1, (object) str2, (object) local2, (object) local3, (object) str3);
        throw;
      }
    }

    private void \u0001(object _param1, SerialDataReceivedEventArgs _param2)
    {
      bool flag;
      \u0001.\u0002 obj1;
      try
      {
        if (false)
          goto label_4;
        else
          goto label_7;
label_1:
        int num1;
        int num2;
        flag = num1 == num2;
        if (flag)
          goto label_6;
label_2:
        if (true)
        {
          num1 = obj1.CanTuDongOto == \u0005.\u0004.\u0001(3771) ? 1 : 0;
          num2 = 0;
          if (num2 == 0)
          {
            flag = num1 == num2;
            if (flag)
              goto label_6;
          }
          else
            goto label_1;
        }
        else
          goto label_5;
label_4:
        this.Invoke((Delegate) new EventHandler(this.\u0001));
label_5:
        if (false)
          goto label_2;
label_6:
        return;
label_7:
        obj1 = new \u0001.\u0002();
        Thread.Sleep(50);
        int num3 = this.\u0002\u0002.IsOpen ? 1 : 0;
        num2 = 0;
        num1 = num3;
        goto label_1;
      }
      catch (Exception ex)
      {
        \u0001.\u0002 obj2 = obj1;
        // ISSUE: variable of a boxed type
        __Boxed<bool> local = (ValueType) flag;
        object obj3 = _param1;
        SerialDataReceivedEventArgs receivedEventArgs = _param2;
        \u0005.\u0008.\u0001(ex, (object) obj2, (object) local, (object) this, obj3, (object) receivedEventArgs);
        throw;
      }
    }

    private void \u0002(object _param1, EventArgs _param2)
    {
      // ISSUE: variable of a compiler-generated type
      \u0005.\u0001.\u0003 obj1;
      bool flag;
      ParameterExpression parameterExpression1;
      ParameterExpression[] parameterExpressionArray1;
      try
      {
        int num1;
        if (this.\u0004\u0002.EditValue == null)
        {
          num1 = 1;
          goto label_6;
        }
        else
          goto label_5;
label_3:
        int num2;
        flag = num2 == 0;
        BindingSource bindingSource = this.\u000E;
        ObjectSet<XeHang> xeHang = this.\u0086\u0002.XeHang;
        parameterExpression1 = Expression.Parameter(typeof (XeHang), \u0005.\u0004.\u0001(4088));
        // ISSUE: method reference
        // ISSUE: field reference
        // ISSUE: method reference
        // ISSUE: method reference
        // ISSUE: field reference
        // ISSUE: method reference
        BinaryExpression body = Expression.AndAlso((Expression) Expression.GreaterThanOrEqual((Expression) Expression.Property((Expression) parameterExpression1, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (XeHang.get_Ngay))), (Expression) Expression.Convert((Expression) Expression.Field((Expression) Expression.Constant((object) obj1), FieldInfo.GetFieldFromHandle(__fieldref (\u0005.\u0001.\u0003.\u0001))), typeof (DateTime?)), false, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (DateTime.op_GreaterThanOrEqual))), (Expression) Expression.LessThanOrEqual((Expression) Expression.Property((Expression) parameterExpression1, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (XeHang.get_Ngay))), (Expression) Expression.Convert((Expression) Expression.Field((Expression) Expression.Constant((object) obj1), FieldInfo.GetFieldFromHandle(__fieldref (\u0005.\u0001.\u0003.\u0002))), typeof (DateTime?)), false, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (DateTime.op_LessThanOrEqual))));
        parameterExpressionArray1 = new ParameterExpression[1]
        {
          parameterExpression1
        };
        ParameterExpression[] parameterExpressionArray2 = parameterExpressionArray1;
        Expression<Func<XeHang, bool>> predicate = Expression.Lambda<Func<XeHang, bool>>((Expression) body, parameterExpressionArray2);
        List<XeHang> list = xeHang.Where<XeHang>(predicate).ToList<XeHang>();
        bindingSource.DataSource = (object) list;
        return;
label_5:
        int num3 = this.\u0007\u0002.EditValue == null ? 1 : 0;
        if (false)
        {
          num2 = num3;
          goto label_3;
        }
        else
          num1 = num3;
label_6:
        flag = num1 != 0;
        if (flag)
          return;
        // ISSUE: object of a compiler-generated type is created
        obj1 = new \u0005.\u0001.\u0003();
        // ISSUE: reference to a compiler-generated field
        obj1.\u0001 = (DateTime) this.\u0004\u0002.EditValue;
        // ISSUE: reference to a compiler-generated field
        obj1.\u0002 = (DateTime) this.\u0007\u0002.EditValue;
        num2 = 1;
        goto label_3;
      }
      catch (Exception ex)
      {
        // ISSUE: variable of a compiler-generated type
        \u0005.\u0001.\u0003 obj2 = obj1;
        // ISSUE: variable of a boxed type
        __Boxed<bool> local = (ValueType) flag;
        ParameterExpression parameterExpression2 = parameterExpression1;
        ParameterExpression[] parameterExpressionArray3 = parameterExpressionArray1;
        object obj3 = _param1;
        EventArgs eventArgs = _param2;
        \u0005.\u0008.\u0001(ex, (object) obj2, (object) local, (object) parameterExpression2, (object) parameterExpressionArray3, (object) this, obj3, (object) eventArgs);
        throw;
      }
    }

    private void \u0003(object _param1, EventArgs _param2)
    {
      // ISSUE: variable of a compiler-generated type
      \u0005.\u0001.\u0004 obj1;
      bool flag;
      ParameterExpression parameterExpression1;
      ParameterExpression[] parameterExpressionArray1;
      try
      {
        int num1;
        if (this.\u0004\u0002.EditValue == null)
        {
          num1 = 1;
          goto label_6;
        }
        else
          goto label_5;
label_3:
        int num2;
        flag = num2 == 0;
        BindingSource bindingSource = this.\u000E;
        ObjectSet<XeHang> xeHang = this.\u0086\u0002.XeHang;
        parameterExpression1 = Expression.Parameter(typeof (XeHang), \u0005.\u0004.\u0001(4088));
        // ISSUE: method reference
        // ISSUE: field reference
        // ISSUE: method reference
        // ISSUE: method reference
        // ISSUE: field reference
        // ISSUE: method reference
        BinaryExpression body = Expression.AndAlso((Expression) Expression.GreaterThanOrEqual((Expression) Expression.Property((Expression) parameterExpression1, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (XeHang.get_Ngay))), (Expression) Expression.Convert((Expression) Expression.Field((Expression) Expression.Constant((object) obj1), FieldInfo.GetFieldFromHandle(__fieldref (\u0005.\u0001.\u0004.\u0001))), typeof (DateTime?)), false, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (DateTime.op_GreaterThanOrEqual))), (Expression) Expression.LessThanOrEqual((Expression) Expression.Property((Expression) parameterExpression1, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (XeHang.get_Ngay))), (Expression) Expression.Convert((Expression) Expression.Field((Expression) Expression.Constant((object) obj1), FieldInfo.GetFieldFromHandle(__fieldref (\u0005.\u0001.\u0004.\u0002))), typeof (DateTime?)), false, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (DateTime.op_LessThanOrEqual))));
        parameterExpressionArray1 = new ParameterExpression[1]
        {
          parameterExpression1
        };
        ParameterExpression[] parameterExpressionArray2 = parameterExpressionArray1;
        Expression<Func<XeHang, bool>> predicate = Expression.Lambda<Func<XeHang, bool>>((Expression) body, parameterExpressionArray2);
        List<XeHang> list = xeHang.Where<XeHang>(predicate).ToList<XeHang>();
        bindingSource.DataSource = (object) list;
        return;
label_5:
        int num3 = this.\u0007\u0002.EditValue == null ? 1 : 0;
        if (false)
        {
          num2 = num3;
          goto label_3;
        }
        else
          num1 = num3;
label_6:
        flag = num1 != 0;
        if (flag)
          return;
        // ISSUE: object of a compiler-generated type is created
        obj1 = new \u0005.\u0001.\u0004();
        // ISSUE: reference to a compiler-generated field
        obj1.\u0001 = (DateTime) this.\u0004\u0002.EditValue;
        // ISSUE: reference to a compiler-generated field
        obj1.\u0002 = (DateTime) this.\u0007\u0002.EditValue;
        num2 = 1;
        goto label_3;
      }
      catch (Exception ex)
      {
        // ISSUE: variable of a compiler-generated type
        \u0005.\u0001.\u0004 obj2 = obj1;
        // ISSUE: variable of a boxed type
        __Boxed<bool> local = (ValueType) flag;
        ParameterExpression parameterExpression2 = parameterExpression1;
        ParameterExpression[] parameterExpressionArray3 = parameterExpressionArray1;
        object obj3 = _param1;
        EventArgs eventArgs = _param2;
        \u0005.\u0008.\u0001(ex, (object) obj2, (object) local, (object) parameterExpression2, (object) parameterExpressionArray3, (object) this, obj3, (object) eventArgs);
        throw;
      }
    }

    private void \u0001(object _param1, RowIndicatorCustomDrawEventArgs _param2)
    {
      int num1;
      bool flag;
      try
      {
        if (true)
          goto label_14;
label_12:
        _param2.Handled = false;
        return;
label_14:
        int num2;
        int num3;
        for (int index = _param2.Info.IsRowIndicator ? 1 : 0; index != 0; index = num3)
        {
          num3 = _param2.RowHandle;
          while (true)
          {
            if (true)
              num3 = num3 < 0 ? 1 : 0;
            if (true)
            {
              num2 = num3;
              goto label_16;
            }
          }
        }
        num2 = 1;
label_16:
        flag = num2 != 0;
        while (!flag)
        {
          IndicatorObjectInfoArgs info = _param2.Info;
          num1 = _param2.RowHandle + 1;
          string str = num1.ToString(\u0005.\u0004.\u0001(4093));
          info.DisplayText = str;
          do
            ;
          while (false);
          _param2.Appearance.TextOptions.HAlignment = HorzAlignment.Far;
          if (true)
          {
            _param2.Appearance.Font = new Font(_param2.Appearance.Font, FontStyle.Italic);
            goto label_12;
          }
        }
      }
      catch (Exception ex)
      {
        // ISSUE: variable of a boxed type
        __Boxed<bool> local1 = (ValueType) flag;
        // ISSUE: variable of a boxed type
        __Boxed<int> local2 = (ValueType) num1;
        object obj = _param1;
        RowIndicatorCustomDrawEventArgs customDrawEventArgs = _param2;
        \u0005.\u0008.\u0001(ex, (object) local1, (object) local2, (object) this, obj, (object) customDrawEventArgs);
        throw;
      }
    }

    private void \u0001(object _param1, ButtonPressedEventArgs _param2)
    {
      XeHang current;
      bool flag;
      try
      {
        if (false)
          goto label_5;
        else
          goto label_12;
label_2:
        current = (XeHang) this.\u000E.Current;
        flag = this.\u0013\u0002.EditValue == null;
        if (!flag)
          current.KhachHangID = Guid.Empty;
        else
          goto label_9;
label_4:
label_5:
        if (true)
          current.DiaChi = (string) null;
        else
          goto label_4;
label_7:
        current.TenKH = (string) null;
        this.\u0013\u0002.EditValue = (object) null;
        current.NotifyPropertyChanged(\u0005.\u0004.\u0001(2599));
        if (true)
          this.\u0086\u0002.SaveChanges();
        else
          goto label_2;
label_9:
label_10:
        return;
label_12:
        flag = this.\u000E.Current == null;
        if (flag)
          return;
        if (true)
        {
          flag = _param2.Button.Kind != ButtonPredefines.Delete;
          if (flag)
            goto label_10;
          else
            goto label_2;
        }
        else
          goto label_7;
      }
      catch (Exception ex)
      {
        XeHang xeHang = current;
        // ISSUE: variable of a boxed type
        __Boxed<bool> local = (ValueType) flag;
        object obj = _param1;
        ButtonPressedEventArgs pressedEventArgs = _param2;
        \u0005.\u0008.\u0001(ex, (object) xeHang, (object) local, (object) this, obj, (object) pressedEventArgs);
        throw;
      }
    }
  }
}
