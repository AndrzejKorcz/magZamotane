using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using System.IO;

namespace MagZamotane4
{
    public partial class ucBarCode : MetroFramework.Controls.MetroUserControl
    {
        private DataTable dt;
        private ReportDocument cry = new ReportDocument();

        public ucBarCode()
        {
            InitializeComponent();
            this.StyleManager = frmDashboard.Instance.StyleManager;
        }

        public void generateCode(string codeText, string codeDesc)
        {
            txtCode.Text = codeText;
            txtCodeDesc.Text = codeDesc;
            generateCodes(codeText);
            lblBarCodeNumber.Text = codeText;
            lblBarCodeDesc.Text = codeDesc;
        }

        private void createDataTable()
        {
            dt = new DataTable();
            dt.TableName = "temp";
            dt.Columns.Add("Code", typeof(string));
            dt.Columns.Add("Name", typeof(string));
            dt.Columns.Add("Image", System.Type.GetType("System.Byte[]"));
        }

        private byte[] ConvertImageToBinary(Image img)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                img.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                return ms.ToArray();
            }
        }

        private void generateCodes(string codeText)
        {
            Zen.Barcode.Code128BarcodeDraw barcode = Zen.Barcode.BarcodeDrawFactory.Code128WithChecksum;
            picBarCode.Image = barcode.Draw(codeText, 50);

            Zen.Barcode.CodeQrBarcodeDraw qrcode = Zen.Barcode.BarcodeDrawFactory.CodeQr;
            picQRCode.Image = qrcode.Draw(codeText, 50);
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            generateCode(txtCode.Text, txtCodeDesc.Text);
        }

        private void ucBarCode_Load(object sender, EventArgs e)
        {
            createDataTable();
            generateCodes(txtCode.Text);
        }

        private void btnClearView_Click(object sender, EventArgs e)
        {
            dt.Clear();
            crystalReportViewer.ReportSource = null;
        }

        private void txtCodeNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void btnAddCode_Click(object sender, EventArgs e)
        {
            int iCounter = 1;
            generateCode(txtCode.Text, txtCodeDesc.Text);

            if (!string.IsNullOrEmpty(txtCodeNumber.Text))
            {
                iCounter = Convert.ToInt32(txtCodeNumber.Text);
            }
            for (int i = 0; i < iCounter; i++)
            {
                byte[] Image = ConvertImageToBinary(picBarCode.Image);
                dt.Rows.Add(txtCode.Text, txtCodeDesc.Text, Image);
            }
            cry.Load(Directory.GetCurrentDirectory() + @"\rpt\CrystalReport1.rpt");
            cry.SetDataSource(dt);
            crystalReportViewer.ReportSource = cry;
        }
    }
}
