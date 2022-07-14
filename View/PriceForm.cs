// Decompiled with JetBrains decompiler
// Type: POSChecker.View.PriceForm
// Assembly: POSChecker, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 27B58231-3079-4A91-AAFA-F2D8454612CA
// Assembly location: D:\Respaldo Su_Plaza_Actopan\PosCheker\POSChecker.exe

using POSChecker.Controller;
using POSChecker.Domain;
using POSChecker.Entities;
using Symbol.Barcode2;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;

namespace POSChecker.View
{
  public class PriceForm : Form
  {
    private const byte VK_RETURN = 13;
    private const int KEYEVENTF_KEYUP = 2;
    private const int KEYEVENTF_KEYDOWN = 0;
    private IContainer components = (IContainer) null;
    private Label lblBarCode;
    private PictureBox pbxBarCode;
    private Label lblSubtitle3;
    private Label label1;
    private Label lblDescription;
    private Label lblPrice;
    private PictureBox pictureBox1;
    private Label label2;
    private Symbol.Barcode2.Design.Barcode2 barCode;
    private Thread threadDownload;
    private SynchronizerDAO sync;

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (PriceForm));
      this.lblBarCode = new Label();
      this.pbxBarCode = new PictureBox();
      this.lblSubtitle3 = new Label();
      this.label1 = new Label();
      this.lblDescription = new Label();
      this.lblPrice = new Label();
      this.pictureBox1 = new PictureBox();
      this.label2 = new Label();
      this.SuspendLayout();
      this.lblBarCode.BackColor = Color.White;
      this.lblBarCode.Font = new Font("Tahoma", 24f, FontStyle.Bold);
      this.lblBarCode.ForeColor = Color.Black;
      this.lblBarCode.Location = new Point(160, 337);
      this.lblBarCode.Name = "lblBarCode";
      this.lblBarCode.Size = new Size(478, 39);
      this.lblBarCode.Text = "00000000";
      this.lblBarCode.TextAlign = ContentAlignment.TopCenter;
      this.pbxBarCode.Image = (Image) componentResourceManager.GetObject("pbxBarCode.Image");
      this.pbxBarCode.Location = new Point(141, 337);
      this.pbxBarCode.Name = "pbxBarCode";
      this.pbxBarCode.Size = new Size(512, 62);
      this.lblSubtitle3.Font = new Font("Tahoma", 20f, FontStyle.Bold);
      this.lblSubtitle3.Location = new Point(3, 414);
      this.lblSubtitle3.Name = "lblSubtitle3";
      this.lblSubtitle3.Size = new Size(792, 36);
      this.lblSubtitle3.Text = "Verificador de Precios";
      this.lblSubtitle3.TextAlign = ContentAlignment.TopCenter;
      this.label1.Font = new Font("Tahoma", 36f, FontStyle.Bold);
      this.label1.ForeColor = Color.MidnightBlue;
      this.label1.Location = new Point(324, 16);
      this.label1.Name = "label1";
      this.label1.Size = new Size(471, 56);
      this.label1.Text = "Bienvenidos a";
      this.label1.TextAlign = ContentAlignment.TopCenter;
      this.lblDescription.Font = new Font("Tahoma", 24f, FontStyle.Bold);
      this.lblDescription.ForeColor = Color.Maroon;
      this.lblDescription.Location = new Point(3, 171);
      this.lblDescription.Name = "lblDescription";
      this.lblDescription.Size = new Size(792, 40);
      this.lblDescription.Text = "Descripción del artículo";
      this.lblDescription.TextAlign = ContentAlignment.TopCenter;
      this.lblPrice.Font = new Font("Tahoma", 36f, FontStyle.Bold);
      this.lblPrice.ForeColor = Color.Blue;
      this.lblPrice.Location = new Point(3, 218);
      this.lblPrice.Name = "lblPrice";
      this.lblPrice.Size = new Size(792, 62);
      this.lblPrice.Text = "$ 0.00";
      this.lblPrice.TextAlign = ContentAlignment.TopCenter;
      this.pictureBox1.Image = (Image) componentResourceManager.GetObject("pictureBox1.Image");
      this.pictureBox1.Location = new Point(11, 11);
      this.pictureBox1.Name = "pictureBox1";
      this.pictureBox1.Size = new Size(318, 147);
      this.pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
      this.label2.Font = new Font("Tahoma", 36f, FontStyle.Bold);
      this.label2.ForeColor = Color.MidnightBlue;
      this.label2.Location = new Point(324, 72);
      this.label2.Name = "label2";
      this.label2.Size = new Size(471, 56);
      this.label2.Text = "Super Plaza";
      this.label2.TextAlign = ContentAlignment.TopCenter;
      this.AutoScaleDimensions = new SizeF(96f, 96f);
      this.AutoScaleMode = AutoScaleMode.Dpi;
      this.AutoScroll = true;
      this.BackColor = Color.White;
      ((Control) this).ClientSize = new Size(798, 455);
      this.Controls.Add((Control) this.label2);
      this.Controls.Add((Control) this.label1);
      this.Controls.Add((Control) this.lblPrice);
      this.Controls.Add((Control) this.lblDescription);
      this.Controls.Add((Control) this.lblSubtitle3);
      this.Controls.Add((Control) this.lblBarCode);
      this.Controls.Add((Control) this.pbxBarCode);
      this.Controls.Add((Control) this.pictureBox1);
      this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = nameof (PriceForm);
      this.Text = "POSChecker v3.5 :: Verificador de Precios";
      this.TopMost = true;
      this.Load += new EventHandler(this.PriceForm_Load);
      this.Closing += new CancelEventHandler(this.PriceForm_Closing);
      this.ResumeLayout(false);
    }

    [DllImport("coredll.dll", SetLastError = true)]
    private static extern void keybd_event(byte bVk, byte bScan, int dwFlags, int dwExtraInfo);

    public PriceForm()
    {
      this.InitializeComponent();
      this.barCode = new ReadBarCode().getReaderBarCode();
      // ISSUE: method pointer
      this.barCode.OnScan += new Symbol.Barcode2.Design.Barcode2.OnScanEventHandler((object) this, __methodptr(ReadBarCode_OnScan));
    }

    private void ReadBarCode_OnScan(ScanDataCollection scanDataCollection)
    {
      try
      {
        ScanData getFirst = scanDataCollection.GetFirst;
        if (getFirst.Result != 0)
          return;
        articulo articulo = ArticuloController.getArticulo(getFirst.Text);
        this.lblBarCode.Text = articulo.cod_barras;
        this.lblDescription.Text = articulo.descripcion;
        this.lblPrice.Text = articulo.precio_oferta > 0M ? articulo.precio_oferta.ToString("C2") : articulo.precio_venta.ToString("C2");
        PriceForm.keybd_event((byte) 13, (byte) 0, 0, 0);
      }
      catch (Exception ex)
      {
        this.lblBarCode.Text = "0000000";
        this.lblDescription.Text = ex.Message;
        this.lblPrice.Text = 0.0.ToString("C2");
      }
    }

    private void PriceForm_Load(object sender, EventArgs e)
    {
      try
      {
        this.sync = new SynchronizerDAO();
        this.threadDownload = new Thread(new ThreadStart(this.DownloadNow));
        this.threadDownload.Start();
      }
      catch (Exception ex)
      {
        CtrlException.SetError(ex.Message);
      }
    }

    private void DownloadNow()
    {
      while (true)
      {
        try
        {
          this.sync.syncArticulos();
          Thread.Sleep(5000);
          this.sync.syncOfertas();
          Thread.Sleep(5000);
          this.sync.deleteOffers();
          Thread.Sleep(50000);
        }
        catch (Exception ex)
        {
          if (!ex.Message.Equals("ThreadAbortException"))
            CtrlException.SetError(ex.Message);
          Thread.Sleep(180000);
        }
      }
    }

    private void PriceForm_Closing(object sender, CancelEventArgs e)
    {
      e.Cancel = MessageBox.Show("Deseas salir del Verificador?", "Salir de Verificador", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) != DialogResult.Yes;
      if (e.Cancel)
        return;
      this.barCode.EnableScanner = e.Cancel;
      ((Component) this.barCode).Dispose();
      pos_checker.CloseConnection();
      this.threadDownload.Abort();
      this.threadDownload = (Thread) null;
      Application.Exit();
    }
  }
}
