namespace MagZamotane4
{
    partial class ucBarCode
    {
        /// <summary> 
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod wygenerowany przez Projektanta składników

        /// <summary> 
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować 
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblBarCodeNumber = new MetroFramework.Controls.MetroLabel();
            this.lblViewGenCode = new MetroFramework.Controls.MetroLabel();
            this.txtCodeNumber = new MetroFramework.Controls.MetroTextBox();
            this.btnAddCode = new MetroFramework.Controls.MetroButton();
            this.btnClearView = new MetroFramework.Controls.MetroButton();
            this.txtCodeDesc = new MetroFramework.Controls.MetroTextBox();
            this.lblBarCodeDesc = new MetroFramework.Controls.MetroLabel();
            this.lblCodeNumber = new MetroFramework.Controls.MetroLabel();
            this.lblCodeDesc = new MetroFramework.Controls.MetroLabel();
            this.picQRCode = new System.Windows.Forms.PictureBox();
            this.txtCode = new MetroFramework.Controls.MetroTextBox();
            this.picBarCode = new System.Windows.Forms.PictureBox();
            this.lblCode = new MetroFramework.Controls.MetroLabel();
            this.btnGenerate = new MetroFramework.Controls.MetroButton();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.lblQRCode = new MetroFramework.Controls.MetroLabel();
            this.crystalReportViewer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.picQRCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBarCode)).BeginInit();
            this.metroPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblBarCodeNumber
            // 
            this.lblBarCodeNumber.FontSize = MetroFramework.MetroLabelSize.Small;
            this.lblBarCodeNumber.ForeColor = System.Drawing.Color.Black;
            this.lblBarCodeNumber.Location = new System.Drawing.Point(18, 233);
            this.lblBarCodeNumber.Name = "lblBarCodeNumber";
            this.lblBarCodeNumber.Size = new System.Drawing.Size(181, 15);
            this.lblBarCodeNumber.TabIndex = 15;
            this.lblBarCodeNumber.Text = "brak kodu";
            this.lblBarCodeNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblViewGenCode
            // 
            this.lblViewGenCode.AutoSize = true;
            this.lblViewGenCode.Location = new System.Drawing.Point(9, 115);
            this.lblViewGenCode.Name = "lblViewGenCode";
            this.lblViewGenCode.Size = new System.Drawing.Size(201, 19);
            this.lblViewGenCode.TabIndex = 14;
            this.lblViewGenCode.Text = "Podgląd wygenerowanego kodu.";
            // 
            // txtCodeNumber
            // 
            // 
            // 
            // 
            this.txtCodeNumber.CustomButton.Image = null;
            this.txtCodeNumber.CustomButton.Location = new System.Drawing.Point(53, 1);
            this.txtCodeNumber.CustomButton.Name = "";
            this.txtCodeNumber.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtCodeNumber.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCodeNumber.CustomButton.TabIndex = 1;
            this.txtCodeNumber.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCodeNumber.CustomButton.UseSelectable = true;
            this.txtCodeNumber.CustomButton.Visible = false;
            this.txtCodeNumber.Lines = new string[] {
        "1"};
            this.txtCodeNumber.Location = new System.Drawing.Point(569, 16);
            this.txtCodeNumber.MaxLength = 32767;
            this.txtCodeNumber.Name = "txtCodeNumber";
            this.txtCodeNumber.PasswordChar = '\0';
            this.txtCodeNumber.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCodeNumber.SelectedText = "";
            this.txtCodeNumber.SelectionLength = 0;
            this.txtCodeNumber.SelectionStart = 0;
            this.txtCodeNumber.ShortcutsEnabled = true;
            this.txtCodeNumber.Size = new System.Drawing.Size(75, 23);
            this.txtCodeNumber.TabIndex = 7;
            this.txtCodeNumber.Text = "1";
            this.txtCodeNumber.UseSelectable = true;
            this.txtCodeNumber.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCodeNumber.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtCodeNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodeNumber_KeyPress);
            // 
            // btnAddCode
            // 
            this.btnAddCode.Location = new System.Drawing.Point(491, 49);
            this.btnAddCode.Name = "btnAddCode";
            this.btnAddCode.Size = new System.Drawing.Size(72, 23);
            this.btnAddCode.TabIndex = 6;
            this.btnAddCode.Text = "Dodaj";
            this.btnAddCode.UseSelectable = true;
            this.btnAddCode.Click += new System.EventHandler(this.btnAddCode_Click);
            // 
            // btnClearView
            // 
            this.btnClearView.Location = new System.Drawing.Point(569, 49);
            this.btnClearView.Name = "btnClearView";
            this.btnClearView.Size = new System.Drawing.Size(72, 23);
            this.btnClearView.TabIndex = 6;
            this.btnClearView.Text = "Wyczyść";
            this.btnClearView.UseSelectable = true;
            this.btnClearView.Click += new System.EventHandler(this.btnClearView_Click);
            // 
            // txtCodeDesc
            // 
            // 
            // 
            // 
            this.txtCodeDesc.CustomButton.Image = null;
            this.txtCodeDesc.CustomButton.Location = new System.Drawing.Point(270, 1);
            this.txtCodeDesc.CustomButton.Name = "";
            this.txtCodeDesc.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtCodeDesc.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCodeDesc.CustomButton.TabIndex = 1;
            this.txtCodeDesc.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCodeDesc.CustomButton.UseSelectable = true;
            this.txtCodeDesc.CustomButton.Visible = false;
            this.txtCodeDesc.Lines = new string[] {
        "brak opisu"};
            this.txtCodeDesc.Location = new System.Drawing.Point(97, 49);
            this.txtCodeDesc.MaxLength = 32767;
            this.txtCodeDesc.Name = "txtCodeDesc";
            this.txtCodeDesc.PasswordChar = '\0';
            this.txtCodeDesc.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCodeDesc.SelectedText = "";
            this.txtCodeDesc.SelectionLength = 0;
            this.txtCodeDesc.SelectionStart = 0;
            this.txtCodeDesc.ShortcutsEnabled = true;
            this.txtCodeDesc.Size = new System.Drawing.Size(292, 23);
            this.txtCodeDesc.TabIndex = 5;
            this.txtCodeDesc.Text = "brak opisu";
            this.txtCodeDesc.UseSelectable = true;
            this.txtCodeDesc.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCodeDesc.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblBarCodeDesc
            // 
            this.lblBarCodeDesc.BackColor = System.Drawing.Color.White;
            this.lblBarCodeDesc.FontSize = MetroFramework.MetroLabelSize.Small;
            this.lblBarCodeDesc.Location = new System.Drawing.Point(18, 162);
            this.lblBarCodeDesc.Name = "lblBarCodeDesc";
            this.lblBarCodeDesc.Size = new System.Drawing.Size(180, 15);
            this.lblBarCodeDesc.TabIndex = 11;
            this.lblBarCodeDesc.Text = "brak opisu";
            this.lblBarCodeDesc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblBarCodeDesc.UseCustomBackColor = true;
            // 
            // lblCodeNumber
            // 
            this.lblCodeNumber.AutoSize = true;
            this.lblCodeNumber.Location = new System.Drawing.Point(472, 20);
            this.lblCodeNumber.Name = "lblCodeNumber";
            this.lblCodeNumber.Size = new System.Drawing.Size(91, 19);
            this.lblCodeNumber.TabIndex = 4;
            this.lblCodeNumber.Text = "Liczba kodów:";
            this.lblCodeNumber.UseCustomBackColor = true;
            // 
            // lblCodeDesc
            // 
            this.lblCodeDesc.AutoSize = true;
            this.lblCodeDesc.Location = new System.Drawing.Point(19, 49);
            this.lblCodeDesc.Name = "lblCodeDesc";
            this.lblCodeDesc.Size = new System.Drawing.Size(72, 19);
            this.lblCodeDesc.TabIndex = 4;
            this.lblCodeDesc.Text = "Opis kodu:";
            this.lblCodeDesc.UseCustomBackColor = true;
            // 
            // picQRCode
            // 
            this.picQRCode.BackColor = System.Drawing.SystemColors.Window;
            this.picQRCode.Location = new System.Drawing.Point(18, 313);
            this.picQRCode.Name = "picQRCode";
            this.picQRCode.Size = new System.Drawing.Size(180, 180);
            this.picQRCode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picQRCode.TabIndex = 9;
            this.picQRCode.TabStop = false;
            // 
            // txtCode
            // 
            // 
            // 
            // 
            this.txtCode.CustomButton.Image = null;
            this.txtCode.CustomButton.Location = new System.Drawing.Point(189, 1);
            this.txtCode.CustomButton.Name = "";
            this.txtCode.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtCode.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCode.CustomButton.TabIndex = 1;
            this.txtCode.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCode.CustomButton.UseSelectable = true;
            this.txtCode.CustomButton.Visible = false;
            this.txtCode.Lines = new string[] {
        "brak kodu"};
            this.txtCode.Location = new System.Drawing.Point(97, 16);
            this.txtCode.MaxLength = 32767;
            this.txtCode.Name = "txtCode";
            this.txtCode.PasswordChar = '\0';
            this.txtCode.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCode.SelectedText = "";
            this.txtCode.SelectionLength = 0;
            this.txtCode.SelectionStart = 0;
            this.txtCode.ShortcutsEnabled = true;
            this.txtCode.Size = new System.Drawing.Size(211, 23);
            this.txtCode.TabIndex = 3;
            this.txtCode.Text = "brak kodu";
            this.txtCode.UseSelectable = true;
            this.txtCode.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCode.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // picBarCode
            // 
            this.picBarCode.BackColor = System.Drawing.SystemColors.Window;
            this.picBarCode.Location = new System.Drawing.Point(18, 172);
            this.picBarCode.Name = "picBarCode";
            this.picBarCode.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.picBarCode.Size = new System.Drawing.Size(180, 65);
            this.picBarCode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBarCode.TabIndex = 10;
            this.picBarCode.TabStop = false;
            // 
            // lblCode
            // 
            this.lblCode.AutoSize = true;
            this.lblCode.Location = new System.Drawing.Point(19, 20);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(35, 19);
            this.lblCode.TabIndex = 1;
            this.lblCode.Text = "Kod:";
            this.lblCode.UseCustomBackColor = true;
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(314, 16);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(75, 23);
            this.btnGenerate.TabIndex = 0;
            this.btnGenerate.Text = "Podgląd";
            this.btnGenerate.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnGenerate.UseSelectable = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // metroPanel1
            // 
            this.metroPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.metroPanel1.Controls.Add(this.txtCodeNumber);
            this.metroPanel1.Controls.Add(this.btnAddCode);
            this.metroPanel1.Controls.Add(this.btnClearView);
            this.metroPanel1.Controls.Add(this.txtCodeDesc);
            this.metroPanel1.Controls.Add(this.lblCodeNumber);
            this.metroPanel1.Controls.Add(this.lblCodeDesc);
            this.metroPanel1.Controls.Add(this.txtCode);
            this.metroPanel1.Controls.Add(this.lblCode);
            this.metroPanel1.Controls.Add(this.btnGenerate);
            this.metroPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(0, 0);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(737, 93);
            this.metroPanel1.TabIndex = 13;
            this.metroPanel1.UseCustomBackColor = true;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // lblQRCode
            // 
            this.lblQRCode.AutoSize = true;
            this.lblQRCode.BackColor = System.Drawing.Color.White;
            this.lblQRCode.Location = new System.Drawing.Point(83, 291);
            this.lblQRCode.Name = "lblQRCode";
            this.lblQRCode.Size = new System.Drawing.Size(54, 19);
            this.lblQRCode.TabIndex = 12;
            this.lblQRCode.Text = "QR kod";
            this.lblQRCode.UseCustomBackColor = true;
            // 
            // crystalReportViewer
            // 
            this.crystalReportViewer.ActiveViewIndex = -1;
            this.crystalReportViewer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.crystalReportViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer.DisplayStatusBar = false;
            this.crystalReportViewer.Location = new System.Drawing.Point(229, 99);
            this.crystalReportViewer.Name = "crystalReportViewer";
            this.crystalReportViewer.ShowCloseButton = false;
            this.crystalReportViewer.ShowGotoPageButton = false;
            this.crystalReportViewer.ShowGroupTreeButton = false;
            this.crystalReportViewer.ShowLogo = false;
            this.crystalReportViewer.ShowParameterPanelButton = false;
            this.crystalReportViewer.Size = new System.Drawing.Size(508, 406);
            this.crystalReportViewer.TabIndex = 16;
            this.crystalReportViewer.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // ucBarCode
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.crystalReportViewer);
            this.Controls.Add(this.lblBarCodeNumber);
            this.Controls.Add(this.lblViewGenCode);
            this.Controls.Add(this.lblBarCodeDesc);
            this.Controls.Add(this.picQRCode);
            this.Controls.Add(this.picBarCode);
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.lblQRCode);
            this.Name = "ucBarCode";
            this.Size = new System.Drawing.Size(737, 505);
            this.Load += new System.EventHandler(this.ucBarCode_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picQRCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBarCode)).EndInit();
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel lblBarCodeNumber;
        private MetroFramework.Controls.MetroLabel lblViewGenCode;
        private MetroFramework.Controls.MetroTextBox txtCodeNumber;
        private MetroFramework.Controls.MetroButton btnAddCode;
        private MetroFramework.Controls.MetroButton btnClearView;
        private MetroFramework.Controls.MetroTextBox txtCodeDesc;
        private MetroFramework.Controls.MetroLabel lblBarCodeDesc;
        private MetroFramework.Controls.MetroLabel lblCodeNumber;
        private MetroFramework.Controls.MetroLabel lblCodeDesc;
        private System.Windows.Forms.PictureBox picQRCode;
        private MetroFramework.Controls.MetroTextBox txtCode;
        private System.Windows.Forms.PictureBox picBarCode;
        private MetroFramework.Controls.MetroLabel lblCode;
        private MetroFramework.Controls.MetroButton btnGenerate;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroLabel lblQRCode;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer;
    }
}
