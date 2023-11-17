// Decompiled with JetBrains decompiler
// Type: Xtra.Utility.ThreadExceptionDialog
// Assembly: Xtra.Utility, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F0A554BF-0B1B-420F-A5E2-9214C58F15B4
// Assembly location: C:\Project\HH.CanOTo\references\CAN TRI VIET\Xtra.Utility.dll

using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraSplashScreen;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Net;
using System.Net.Mail;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Xtra.Utility
{
  public class ThreadExceptionDialog : XtraForm
  {
    private Exception e;
    private bool details;
    private LabelControl label1;
    private MemoEdit textBoxDetails;
    private SimpleButton buttonAbort;
    private SimpleButton buttonIgnore;
    private SimpleButton buttonDetails;
    private SimpleButton simpleButton2;
    private MarqueeProgressBarControl marqueeProgressBarControl1;
    private GroupControl groupControl1;
    private MemoEdit labelException;
    private SimpleButton simpleButton1;

    private void InitializeComponent()
    {
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (ThreadExceptionDialog));
      this.textBoxDetails = new MemoEdit();
      this.label1 = new LabelControl();
      this.simpleButton1 = new SimpleButton();
      this.buttonAbort = new SimpleButton();
      this.buttonIgnore = new SimpleButton();
      this.buttonDetails = new SimpleButton();
      this.simpleButton2 = new SimpleButton();
      this.marqueeProgressBarControl1 = new MarqueeProgressBarControl();
      this.groupControl1 = new GroupControl();
      this.labelException = new MemoEdit();
      ((ISupportInitialize) this.textBoxDetails.Properties).BeginInit();
      ((ISupportInitialize) this.marqueeProgressBarControl1.Properties).BeginInit();
      ((ISupportInitialize) this.groupControl1).BeginInit();
      ((Control) this.groupControl1).SuspendLayout();
      ((ISupportInitialize) this.labelException.Properties).BeginInit();
      this.SuspendLayout();
      ((Control) this.textBoxDetails).Location = new Point(4, 171);
      ((Control) this.textBoxDetails).Name = "textBoxDetails";
      ((Control) this.textBoxDetails).Size = new Size(420, 211);
      ((Control) this.textBoxDetails).TabIndex = 5;
      ((BaseEdit) this.textBoxDetails).TabStop = false;
      ((Control) this.label1).Location = new Point(10, 154);
      ((Control) this.label1).Name = "label1";
      ((Control) this.label1).Size = new Size(167, 13);
      ((Control) this.label1).TabIndex = 0;
      ((Control) this.label1).Text = "Thông tin chi tiết phát sinh ngoại lệ";
      ((Control) this.simpleButton1).Location = new Point(342, 389);
      ((Control) this.simpleButton1).Name = "simpleButton1";
      ((Control) this.simpleButton1).Size = new Size(75, 23);
      ((Control) this.simpleButton1).TabIndex = 6;
      ((Control) this.simpleButton1).Text = "Gởi mail";
      ((Control) this.simpleButton1).Click += new EventHandler(this.simpleButton1_Click);
      ((BaseButton) this.buttonAbort).DialogResult = DialogResult.Abort;
      ((Control) this.buttonAbort).Location = new Point(332, 121);
      ((Control) this.buttonAbort).Name = "buttonAbort";
      ((Control) this.buttonAbort).Size = new Size(85, 24);
      ((Control) this.buttonAbort).TabIndex = 4;
      ((Control) this.buttonAbort).Text = "&Thoát";
      ((Control) this.buttonAbort).Click += new EventHandler(this.buttonAbort_Click);
      ((BaseButton) this.buttonIgnore).DialogResult = DialogResult.Ignore;
      ((Control) this.buttonIgnore).Location = new Point(235, 121);
      ((Control) this.buttonIgnore).Name = "buttonIgnore";
      ((Control) this.buttonIgnore).Size = new Size(85, 24);
      ((Control) this.buttonIgnore).TabIndex = 3;
      ((Control) this.buttonIgnore).Text = "&Bỏ qua";
      ((Control) this.buttonDetails).Location = new Point(138, 121);
      ((Control) this.buttonDetails).Name = "buttonDetails";
      ((Control) this.buttonDetails).Size = new Size(85, 24);
      ((Control) this.buttonDetails).TabIndex = 2;
      ((Control) this.buttonDetails).Text = "&Hiện chi tiết";
      ((Control) this.buttonDetails).Click += new EventHandler(this.buttonDetails_Click);
      ((Control) this.simpleButton2).Location = new Point(240, 389);
      ((Control) this.simpleButton2).Name = "simpleButton2";
      ((Control) this.simpleButton2).Size = new Size(96, 23);
      ((Control) this.simpleButton2).TabIndex = 6;
      ((Control) this.simpleButton2).Text = "Hỗ trợ trực tuyến";
      ((Control) this.simpleButton2).Click += new EventHandler(this.simpleButton2_Click);
      ((BaseEdit) this.marqueeProgressBarControl1).EditValue = (object) 0;
      ((Control) this.marqueeProgressBarControl1).Location = new Point(6, 392);
      ((Control) this.marqueeProgressBarControl1).Name = "marqueeProgressBarControl1";
      ((Control) this.marqueeProgressBarControl1).Size = new Size(210, 18);
      ((Control) this.marqueeProgressBarControl1).TabIndex = 9;
      ((Control) this.marqueeProgressBarControl1).Visible = false;
      ((Control) this.groupControl1).Controls.Add((Control) this.labelException);
      ((Control) this.groupControl1).Location = new Point(6, 3);
      ((Control) this.groupControl1).Name = "groupControl1";
      this.groupControl1.ShowCaption = false;
      ((Control) this.groupControl1).Size = new Size(418, 112);
      ((Control) this.groupControl1).TabIndex = 10;
      ((Control) this.groupControl1).Text = "Thông tin ngoại lệ";
      ((Control) this.labelException).Dock = DockStyle.Fill;
      ((Control) this.labelException).Location = new Point(2, 2);
      ((Control) this.labelException).Name = "labelException";
      ((RepositoryItem) this.labelException.Properties).Appearance.BackColor = Color.Transparent;
      ((RepositoryItem) this.labelException.Properties).Appearance.Options.UseBackColor = true;
      ((RepositoryItem) this.labelException.Properties).BorderStyle = (BorderStyles) 0;
      this.labelException.Properties.ScrollBars = ScrollBars.None;
      ((RepositoryItem) this.labelException.Properties).UseParentBackground = true;
      ((Control) this.labelException).Size = new Size(414, 108);
      ((Control) this.labelException).TabIndex = 5;
      ((BaseEdit) this.labelException).TabStop = false;
      ((Form) this).AcceptButton = (IButtonControl) this.buttonIgnore;
      ((Form) this).AutoScaleBaseSize = new Size(5, 14);
      ((Form) this).CancelButton = (IButtonControl) this.buttonAbort;
      ((Form) this).ClientSize = new Size(428, 424);
      ((Control) this).Controls.Add((Control) this.groupControl1);
      ((Control) this).Controls.Add((Control) this.buttonDetails);
      ((Control) this).Controls.Add((Control) this.marqueeProgressBarControl1);
      ((Control) this).Controls.Add((Control) this.buttonIgnore);
      ((Control) this).Controls.Add((Control) this.buttonAbort);
      ((Control) this).Controls.Add((Control) this.simpleButton2);
      ((Control) this).Controls.Add((Control) this.simpleButton1);
      ((Control) this).Controls.Add((Control) this.label1);
      ((Control) this).Controls.Add((Control) this.textBoxDetails);
      ((Form) this).Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
      ((Form) this).MaximizeBox = false;
      ((Form) this).MinimizeBox = false;
      ((Control) this).Name = nameof (ThreadExceptionDialog);
      ((Form) this).ShowInTaskbar = false;
      ((Form) this).StartPosition = FormStartPosition.CenterScreen;
      ((Control) this).Text = "Ngoại lệ";
      ((ISupportInitialize) this.textBoxDetails.Properties).EndInit();
      ((ISupportInitialize) this.marqueeProgressBarControl1.Properties).EndInit();
      ((ISupportInitialize) this.groupControl1).EndInit();
      ((Control) this.groupControl1).ResumeLayout(false);
      ((ISupportInitialize) this.labelException.Properties).EndInit();
      this.ResumeLayout(false);
      ((Control) this).PerformLayout();
    }

    public ThreadExceptionDialog(Exception e)
    {
      ((Control) this).Cursor = Cursors.Default;
      this.e = e;
      SplashScreenManager.CloseForm(false);
      this.InitializeComponent();
      if (e.InnerException != null)
        ((Control) this.labelException).Text = e.Message + Environment.NewLine + e.InnerException.Message;
      else
        ((Control) this.labelException).Text = e.Message;
      if (Form.ActiveForm != null)
        ((Control) this).Text = Form.ActiveForm.Text;
      else
        ((Control) this).Text = Application.ProductName + Application.ProductVersion;
      ((Control) this.buttonAbort).Enabled = Application.AllowQuit;
      this.RefreshDetails();
      this.FillExceptionDetails();
      ((Form) this).Shown += (EventHandler) ((a1, e1) => Cursor.Current = Cursors.Default);
    }

    private void buttonDetails_Click(object sender, EventArgs e)
    {
      this.details = !this.details;
      this.RefreshDetails();
    }

    private void FillExceptionDetails()
    {
      StringBuilder stringBuilder = new StringBuilder();
      stringBuilder.Append(this.e.ToString());
      stringBuilder.Append(Environment.NewLine + Environment.NewLine);
      stringBuilder.Append("Loaded assemblies:" + Environment.NewLine + Environment.NewLine);
      foreach (Assembly assembly in AppDomain.CurrentDomain.GetAssemblies())
      {
        AssemblyName name = assembly.GetName();
        stringBuilder.AppendFormat("Name:\t{0}" + Environment.NewLine, (object) name.Name);
        stringBuilder.AppendFormat("Version:\t{0}" + Environment.NewLine, (object) name.Version);
        stringBuilder.AppendFormat("Location:\t{0}" + Environment.NewLine, (object) name.CodeBase);
        stringBuilder.Append(Environment.NewLine);
      }
      ((Control) this.textBoxDetails).Text = stringBuilder.ToString();
    }

    private void RefreshDetails()
    {
      if (this.details)
      {
        ((Control) this.buttonDetails).Text = "Ẩn chi tiết";
        ((Control) this).Height = 450;
      }
      else
      {
        ((Control) this.buttonDetails).Text = "&Hiện chi tiết";
        ((Control) this).Height = 180;
      }
    }

    private void buttonAbort_Click(object sender, EventArgs e)
    {
      if (XtraMessageBox.Show("Bạn muốn thoát khỏi chương trình?", "Xác nhận?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
        return;
      Environment.Exit(-1);
    }

    private void simpleButton1_Click(object sender, EventArgs e)
    {
      Thread thread = new Thread(new ThreadStart(this.SendMail));
      ((Control) this.marqueeProgressBarControl1).Visible = true;
      thread.Start();
    }

    private void SendMail()
    {
      string text = ((Control) this.textBoxDetails).Text;
      string str = Application.ProductName + " v" + Application.ProductVersion + " - " + DateTime.Now.ToString("dd/MM/yyyy hh:mm");
      try
      {
        new SmtpClient("smtp.gmail.com")
        {
          Port = 587,
          Credentials = ((ICredentialsByHost) new NetworkCredential("support@aibip.com", "567leduan")),
          EnableSsl = true
        }.Send(new MailMessage()
        {
          From = new MailAddress("support@aibip.com"),
          To = {
            "thuyenvinh@gmail.com"
          },
          Subject = str,
          Body = text
        });
      }
      catch (Exception ex)
      {
        ((Control) this.marqueeProgressBarControl1).Visible = false;
      }
      ((Control) this.marqueeProgressBarControl1).Visible = false;
    }

    private void simpleButton2_Click(object sender, EventArgs e)
    {
      Process.Start("http://aibip.com");
      ((Form) this).Close();
    }
  }
}
