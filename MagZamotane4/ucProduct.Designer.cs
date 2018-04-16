namespace MagZamotane4
{
    partial class ucProduct
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucProduct));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtSearch = new MetroFramework.Controls.MetroTextBox();
            this.mlSearch = new MetroFramework.Controls.MetroLabel();
            this.btnAdd = new MetroFramework.Controls.MetroButton();
            this.btnEdit = new MetroFramework.Controls.MetroButton();
            this.btnCancel = new MetroFramework.Controls.MetroButton();
            this.btnSave = new MetroFramework.Controls.MetroButton();
            this.txtVat = new MetroFramework.Controls.MetroTextBox();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblVat = new MetroFramework.Controls.MetroLabel();
            this.pnlContainer = new MetroFramework.Controls.MetroPanel();
            this.lnkClrImage = new MetroFramework.Controls.MetroLink();
            this.pic = new System.Windows.Forms.PictureBox();
            this.lblPicturePath = new MetroFramework.Controls.MetroLabel();
            this.dtInvoiceDate = new MetroFramework.Controls.MetroDateTime();
            this.txtInvoiceNumber = new MetroFramework.Controls.MetroTextBox();
            this.txtMargin = new MetroFramework.Controls.MetroTextBox();
            this.lbInvoiceDate = new MetroFramework.Controls.MetroLabel();
            this.mlInvoiceNumber = new MetroFramework.Controls.MetroLabel();
            this.mlMargin = new MetroFramework.Controls.MetroLabel();
            this.txtValue = new MetroFramework.Controls.MetroTextBox();
            this.txtUnit = new MetroFramework.Controls.MetroTextBox();
            this.mlValue = new MetroFramework.Controls.MetroLabel();
            this.mlUnit = new MetroFramework.Controls.MetroLabel();
            this.txtQuantity = new MetroFramework.Controls.MetroTextBox();
            this.mlQuantity = new MetroFramework.Controls.MetroLabel();
            this.txtPrice = new MetroFramework.Controls.MetroTextBox();
            this.txtGrossPrice = new MetroFramework.Controls.MetroTextBox();
            this.txtNetPrice = new MetroFramework.Controls.MetroTextBox();
            this.lblPrice = new MetroFramework.Controls.MetroLabel();
            this.lblGrossPrice = new MetroFramework.Controls.MetroLabel();
            this.lblNetPrice = new MetroFramework.Controls.MetroLabel();
            this.lblName = new MetroFramework.Controls.MetroLabel();
            this.txtName = new MetroFramework.Controls.MetroTextBox();
            this.lblCode = new MetroFramework.Controls.MetroLabel();
            this.txtCode = new MetroFramework.Controls.MetroTextBox();
            this.btnBrowse = new MetroFramework.Controls.MetroButton();
            this.metroGrid = new MetroFramework.Controls.MetroGrid();
            this.kodDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Print = new System.Windows.Forms.DataGridViewImageColumn();
            this.nazwaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cenaNettoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cenaBruttoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cenaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iloscDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wartoscDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jednostkaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.marzaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numFakturaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataFakturaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Delete = new System.Windows.Forms.DataGridViewImageColumn();
            this.btnPrint = new MetroFramework.Controls.MetroButton();
            this.lblTotal = new MetroFramework.Controls.MetroLabel();
            this.lblPosition = new MetroFramework.Controls.MetroLabel();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.lnkRefresh = new MetroFramework.Controls.MetroLink();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            this.pnlContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSearch
            // 
            this.txtSearch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtSearch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            // 
            // 
            // 
            this.txtSearch.CustomButton.BackColor = System.Drawing.SystemColors.Control;
            this.txtSearch.CustomButton.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.txtSearch.CustomButton.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            this.txtSearch.CustomButton.Location = new System.Drawing.Point(222, 1);
            this.txtSearch.CustomButton.Name = "";
            this.txtSearch.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtSearch.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSearch.CustomButton.TabIndex = 1;
            this.txtSearch.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSearch.CustomButton.UseCompatibleTextRendering = true;
            this.txtSearch.CustomButton.UseSelectable = true;
            this.txtSearch.CustomButton.UseVisualStyleBackColor = false;
            this.txtSearch.Lines = new string[0];
            this.txtSearch.Location = new System.Drawing.Point(57, 238);
            this.txtSearch.MaxLength = 32767;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.PromptText = "szukaj po nazwie lub kodzie";
            this.txtSearch.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSearch.SelectedText = "";
            this.txtSearch.SelectionLength = 0;
            this.txtSearch.SelectionStart = 0;
            this.txtSearch.ShortcutsEnabled = true;
            this.txtSearch.ShowButton = true;
            this.txtSearch.ShowClearButton = true;
            this.txtSearch.Size = new System.Drawing.Size(244, 23);
            this.txtSearch.TabIndex = 3;
            this.txtSearch.UseSelectable = true;
            this.txtSearch.WaterMark = "szukaj po nazwie lub kodzie";
            this.txtSearch.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSearch.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtSearch.ButtonClick += new MetroFramework.Controls.MetroTextBox.ButClick(this.mtSearch_ButtonClick);
            this.txtSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.mtSearch_KeyDown);
            this.txtSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mtSearch_KeyPress);
            // 
            // mlSearch
            // 
            this.mlSearch.AutoSize = true;
            this.mlSearch.Location = new System.Drawing.Point(3, 238);
            this.mlSearch.Name = "mlSearch";
            this.mlSearch.Size = new System.Drawing.Size(48, 19);
            this.mlSearch.TabIndex = 2;
            this.mlSearch.Text = "Szukaj:";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(179)))), ((int)(((byte)(188)))));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(364, 238);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Dodaj";
            this.btnAdd.UseCustomBackColor = true;
            this.btnAdd.UseCustomForeColor = true;
            this.btnAdd.UseSelectable = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(54)))), ((int)(((byte)(103)))));
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.Location = new System.Drawing.Point(445, 238);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 5;
            this.btnEdit.Text = "Edytuj";
            this.btnEdit.UseCustomBackColor = true;
            this.btnEdit.UseCustomForeColor = true;
            this.btnEdit.UseSelectable = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(157)))), ((int)(((byte)(39)))));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(526, 238);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Anuluj";
            this.btnCancel.UseCustomBackColor = true;
            this.btnCancel.UseCustomForeColor = true;
            this.btnCancel.UseSelectable = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(193)))), ((int)(((byte)(17)))));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(607, 238);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Zapisz";
            this.btnSave.UseCustomBackColor = true;
            this.btnSave.UseCustomForeColor = true;
            this.btnSave.UseSelectable = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtVat
            // 
            this.txtVat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            // 
            // 
            // 
            this.txtVat.CustomButton.Image = null;
            this.txtVat.CustomButton.Location = new System.Drawing.Point(36, 1);
            this.txtVat.CustomButton.Name = "";
            this.txtVat.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtVat.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtVat.CustomButton.TabIndex = 1;
            this.txtVat.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtVat.CustomButton.UseSelectable = true;
            this.txtVat.CustomButton.Visible = false;
            this.txtVat.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "Vat", true));
            this.txtVat.Lines = new string[0];
            this.txtVat.Location = new System.Drawing.Point(558, 74);
            this.txtVat.MaxLength = 32767;
            this.txtVat.Name = "txtVat";
            this.txtVat.PasswordChar = '\0';
            this.txtVat.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtVat.SelectedText = "";
            this.txtVat.SelectionLength = 0;
            this.txtVat.SelectionStart = 0;
            this.txtVat.ShortcutsEnabled = true;
            this.txtVat.Size = new System.Drawing.Size(58, 23);
            this.txtVat.TabIndex = 3;
            this.txtVat.UseCustomBackColor = true;
            this.txtVat.UseSelectable = true;
            this.txtVat.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtVat.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtVat.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtVat_KeyPress);
            this.txtVat.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtVat_KeyUp);
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataSource = typeof(MagZamotane4.Core.Product);
            this.productBindingSource.Filter = "";
            // 
            // lblVat
            // 
            this.lblVat.AutoSize = true;
            this.lblVat.Location = new System.Drawing.Point(476, 76);
            this.lblVat.Name = "lblVat";
            this.lblVat.Size = new System.Drawing.Size(80, 19);
            this.lblVat.TabIndex = 10;
            this.lblVat.Text = "Podatek Vat:";
            this.lblVat.UseCustomBackColor = true;
            // 
            // pnlContainer
            // 
            this.pnlContainer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlContainer.Controls.Add(this.lnkClrImage);
            this.pnlContainer.Controls.Add(this.pic);
            this.pnlContainer.Controls.Add(this.lblPicturePath);
            this.pnlContainer.Controls.Add(this.dtInvoiceDate);
            this.pnlContainer.Controls.Add(this.txtInvoiceNumber);
            this.pnlContainer.Controls.Add(this.txtMargin);
            this.pnlContainer.Controls.Add(this.lbInvoiceDate);
            this.pnlContainer.Controls.Add(this.mlInvoiceNumber);
            this.pnlContainer.Controls.Add(this.mlMargin);
            this.pnlContainer.Controls.Add(this.txtValue);
            this.pnlContainer.Controls.Add(this.txtUnit);
            this.pnlContainer.Controls.Add(this.mlValue);
            this.pnlContainer.Controls.Add(this.mlUnit);
            this.pnlContainer.Controls.Add(this.txtQuantity);
            this.pnlContainer.Controls.Add(this.mlQuantity);
            this.pnlContainer.Controls.Add(this.txtVat);
            this.pnlContainer.Controls.Add(this.lblVat);
            this.pnlContainer.Controls.Add(this.txtPrice);
            this.pnlContainer.Controls.Add(this.txtGrossPrice);
            this.pnlContainer.Controls.Add(this.txtNetPrice);
            this.pnlContainer.Controls.Add(this.lblPrice);
            this.pnlContainer.Controls.Add(this.lblGrossPrice);
            this.pnlContainer.Controls.Add(this.lblNetPrice);
            this.pnlContainer.Controls.Add(this.lblName);
            this.pnlContainer.Controls.Add(this.txtName);
            this.pnlContainer.Controls.Add(this.lblCode);
            this.pnlContainer.Controls.Add(this.txtCode);
            this.pnlContainer.Controls.Add(this.btnBrowse);
            this.pnlContainer.HorizontalScrollbarBarColor = true;
            this.pnlContainer.HorizontalScrollbarHighlightOnWheel = false;
            this.pnlContainer.HorizontalScrollbarSize = 10;
            this.pnlContainer.Location = new System.Drawing.Point(3, 3);
            this.pnlContainer.Name = "pnlContainer";
            this.pnlContainer.Size = new System.Drawing.Size(787, 220);
            this.pnlContainer.TabIndex = 0;
            this.pnlContainer.VerticalScrollbarBarColor = true;
            this.pnlContainer.VerticalScrollbarHighlightOnWheel = false;
            this.pnlContainer.VerticalScrollbarSize = 10;
            // 
            // lnkClrImage
            // 
            this.lnkClrImage.AutoSize = true;
            this.lnkClrImage.Image = ((System.Drawing.Image)(resources.GetObject("lnkClrImage.Image")));
            this.lnkClrImage.ImageSize = 18;
            this.lnkClrImage.Location = new System.Drawing.Point(136, 16);
            this.lnkClrImage.Name = "lnkClrImage";
            this.lnkClrImage.Size = new System.Drawing.Size(22, 22);
            this.lnkClrImage.TabIndex = 14;
            this.lnkClrImage.UseSelectable = true;
            this.lnkClrImage.Click += new System.EventHandler(this.lblClrImage_Click);
            // 
            // pic
            // 
            this.pic.Image = ((System.Drawing.Image)(resources.GetObject("pic.Image")));
            this.pic.Location = new System.Drawing.Point(8, 44);
            this.pic.Name = "pic";
            this.pic.Size = new System.Drawing.Size(150, 150);
            this.pic.TabIndex = 2;
            this.pic.TabStop = false;
            // 
            // lblPicturePath
            // 
            this.lblPicturePath.AutoSize = true;
            this.lblPicturePath.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "Obrazek", true));
            this.lblPicturePath.FontSize = MetroFramework.MetroLabelSize.Small;
            this.lblPicturePath.ForeColor = System.Drawing.Color.Silver;
            this.lblPicturePath.Location = new System.Drawing.Point(8, 199);
            this.lblPicturePath.Name = "lblPicturePath";
            this.lblPicturePath.Size = new System.Drawing.Size(0, 0);
            this.lblPicturePath.TabIndex = 11;
            this.lblPicturePath.UseCustomForeColor = true;
            this.lblPicturePath.TextChanged += new System.EventHandler(this.lblPicturePath_TextChanged);
            // 
            // dtInvoiceDate
            // 
            this.dtInvoiceDate.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "DataFaktura", true));
            this.dtInvoiceDate.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.productBindingSource, "DataFaktura", true));
            this.dtInvoiceDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtInvoiceDate.Location = new System.Drawing.Point(557, 158);
            this.dtInvoiceDate.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtInvoiceDate.Name = "dtInvoiceDate";
            this.dtInvoiceDate.Size = new System.Drawing.Size(213, 29);
            this.dtInvoiceDate.TabIndex = 12;
            // 
            // txtInvoiceNumber
            // 
            this.txtInvoiceNumber.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtInvoiceNumber.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            // 
            // 
            // 
            this.txtInvoiceNumber.CustomButton.Image = null;
            this.txtInvoiceNumber.CustomButton.Location = new System.Drawing.Point(191, 1);
            this.txtInvoiceNumber.CustomButton.Name = "";
            this.txtInvoiceNumber.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtInvoiceNumber.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtInvoiceNumber.CustomButton.TabIndex = 1;
            this.txtInvoiceNumber.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtInvoiceNumber.CustomButton.UseSelectable = true;
            this.txtInvoiceNumber.CustomButton.Visible = false;
            this.txtInvoiceNumber.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "NumFaktura", true));
            this.txtInvoiceNumber.Lines = new string[0];
            this.txtInvoiceNumber.Location = new System.Drawing.Point(558, 131);
            this.txtInvoiceNumber.MaxLength = 32767;
            this.txtInvoiceNumber.Name = "txtInvoiceNumber";
            this.txtInvoiceNumber.PasswordChar = '\0';
            this.txtInvoiceNumber.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtInvoiceNumber.SelectedText = "";
            this.txtInvoiceNumber.SelectionLength = 0;
            this.txtInvoiceNumber.SelectionStart = 0;
            this.txtInvoiceNumber.ShortcutsEnabled = true;
            this.txtInvoiceNumber.Size = new System.Drawing.Size(213, 23);
            this.txtInvoiceNumber.TabIndex = 11;
            this.txtInvoiceNumber.UseSelectable = true;
            this.txtInvoiceNumber.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtInvoiceNumber.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtMargin
            // 
            this.txtMargin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            // 
            // 
            // 
            this.txtMargin.CustomButton.Image = null;
            this.txtMargin.CustomButton.Location = new System.Drawing.Point(36, 1);
            this.txtMargin.CustomButton.Name = "";
            this.txtMargin.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtMargin.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtMargin.CustomButton.TabIndex = 1;
            this.txtMargin.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtMargin.CustomButton.UseSelectable = true;
            this.txtMargin.CustomButton.Visible = false;
            this.txtMargin.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "Marza", true));
            this.txtMargin.Lines = new string[0];
            this.txtMargin.Location = new System.Drawing.Point(558, 102);
            this.txtMargin.MaxLength = 32767;
            this.txtMargin.Name = "txtMargin";
            this.txtMargin.PasswordChar = '\0';
            this.txtMargin.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtMargin.SelectedText = "";
            this.txtMargin.SelectionLength = 0;
            this.txtMargin.SelectionStart = 0;
            this.txtMargin.ShortcutsEnabled = true;
            this.txtMargin.Size = new System.Drawing.Size(58, 23);
            this.txtMargin.TabIndex = 10;
            this.txtMargin.UseCustomBackColor = true;
            this.txtMargin.UseSelectable = true;
            this.txtMargin.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtMargin.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtMargin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.validateTextBox);
            // 
            // lbInvoiceDate
            // 
            this.lbInvoiceDate.AutoSize = true;
            this.lbInvoiceDate.Location = new System.Drawing.Point(475, 162);
            this.lbInvoiceDate.Name = "lbInvoiceDate";
            this.lbInvoiceDate.Size = new System.Drawing.Size(67, 19);
            this.lbInvoiceDate.TabIndex = 13;
            this.lbInvoiceDate.Text = "Data fakt.:";
            this.lbInvoiceDate.UseCustomBackColor = true;
            // 
            // mlInvoiceNumber
            // 
            this.mlInvoiceNumber.AutoSize = true;
            this.mlInvoiceNumber.Location = new System.Drawing.Point(475, 135);
            this.mlInvoiceNumber.Name = "mlInvoiceNumber";
            this.mlInvoiceNumber.Size = new System.Drawing.Size(81, 19);
            this.mlInvoiceNumber.TabIndex = 12;
            this.mlInvoiceNumber.Text = "Numer fakt.:";
            this.mlInvoiceNumber.UseCustomBackColor = true;
            // 
            // mlMargin
            // 
            this.mlMargin.AutoSize = true;
            this.mlMargin.Location = new System.Drawing.Point(476, 105);
            this.mlMargin.Name = "mlMargin";
            this.mlMargin.Size = new System.Drawing.Size(49, 19);
            this.mlMargin.TabIndex = 11;
            this.mlMargin.Text = "Marża:";
            this.mlMargin.UseCustomBackColor = true;
            // 
            // txtValue
            // 
            this.txtValue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            // 
            // 
            // 
            this.txtValue.CustomButton.Image = null;
            this.txtValue.CustomButton.Location = new System.Drawing.Point(191, 1);
            this.txtValue.CustomButton.Name = "";
            this.txtValue.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtValue.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtValue.CustomButton.TabIndex = 1;
            this.txtValue.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtValue.CustomButton.UseSelectable = true;
            this.txtValue.CustomButton.Visible = false;
            this.txtValue.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "Wartosc", true));
            this.txtValue.Lines = new string[0];
            this.txtValue.Location = new System.Drawing.Point(558, 14);
            this.txtValue.MaxLength = 32767;
            this.txtValue.Name = "txtValue";
            this.txtValue.PasswordChar = '\0';
            this.txtValue.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtValue.SelectedText = "";
            this.txtValue.SelectionLength = 0;
            this.txtValue.SelectionStart = 0;
            this.txtValue.ShortcutsEnabled = true;
            this.txtValue.Size = new System.Drawing.Size(213, 23);
            this.txtValue.TabIndex = 7;
            this.txtValue.UseCustomBackColor = true;
            this.txtValue.UseSelectable = true;
            this.txtValue.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtValue.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.validateTextBox);
            // 
            // txtUnit
            // 
            this.txtUnit.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtUnit.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            // 
            // 
            // 
            this.txtUnit.CustomButton.Image = null;
            this.txtUnit.CustomButton.Location = new System.Drawing.Point(36, 1);
            this.txtUnit.CustomButton.Name = "";
            this.txtUnit.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtUnit.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtUnit.CustomButton.TabIndex = 1;
            this.txtUnit.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtUnit.CustomButton.UseSelectable = true;
            this.txtUnit.CustomButton.Visible = false;
            this.txtUnit.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "Jednostka", true));
            this.txtUnit.Lines = new string[0];
            this.txtUnit.Location = new System.Drawing.Point(558, 43);
            this.txtUnit.MaxLength = 32767;
            this.txtUnit.Name = "txtUnit";
            this.txtUnit.PasswordChar = '\0';
            this.txtUnit.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtUnit.SelectedText = "";
            this.txtUnit.SelectionLength = 0;
            this.txtUnit.SelectionStart = 0;
            this.txtUnit.ShortcutsEnabled = true;
            this.txtUnit.Size = new System.Drawing.Size(58, 23);
            this.txtUnit.TabIndex = 8;
            this.txtUnit.UseSelectable = true;
            this.txtUnit.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtUnit.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // mlValue
            // 
            this.mlValue.AutoSize = true;
            this.mlValue.Location = new System.Drawing.Point(476, 14);
            this.mlValue.Name = "mlValue";
            this.mlValue.Size = new System.Drawing.Size(60, 19);
            this.mlValue.TabIndex = 8;
            this.mlValue.Text = "Wartość:";
            this.mlValue.UseCustomBackColor = true;
            // 
            // mlUnit
            // 
            this.mlUnit.AutoSize = true;
            this.mlUnit.Location = new System.Drawing.Point(476, 43);
            this.mlUnit.Name = "mlUnit";
            this.mlUnit.Size = new System.Drawing.Size(69, 19);
            this.mlUnit.TabIndex = 9;
            this.mlUnit.Text = "Jednostka:";
            this.mlUnit.UseCustomBackColor = true;
            // 
            // txtQuantity
            // 
            // 
            // 
            // 
            this.txtQuantity.CustomButton.Image = null;
            this.txtQuantity.CustomButton.Location = new System.Drawing.Point(184, 1);
            this.txtQuantity.CustomButton.Name = "";
            this.txtQuantity.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtQuantity.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtQuantity.CustomButton.TabIndex = 1;
            this.txtQuantity.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtQuantity.CustomButton.UseSelectable = true;
            this.txtQuantity.CustomButton.Visible = false;
            this.txtQuantity.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "Ilosc", true));
            this.txtQuantity.Lines = new string[0];
            this.txtQuantity.Location = new System.Drawing.Point(256, 160);
            this.txtQuantity.MaxLength = 32767;
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.PasswordChar = '\0';
            this.txtQuantity.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtQuantity.SelectedText = "";
            this.txtQuantity.SelectionLength = 0;
            this.txtQuantity.SelectionStart = 0;
            this.txtQuantity.ShortcutsEnabled = true;
            this.txtQuantity.Size = new System.Drawing.Size(206, 23);
            this.txtQuantity.TabIndex = 6;
            this.txtQuantity.UseSelectable = true;
            this.txtQuantity.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtQuantity.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtQuantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.validateTextBox);
            this.txtQuantity.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtQuantity_KeyUp);
            // 
            // mlQuantity
            // 
            this.mlQuantity.AutoSize = true;
            this.mlQuantity.Location = new System.Drawing.Point(173, 164);
            this.mlQuantity.Name = "mlQuantity";
            this.mlQuantity.Size = new System.Drawing.Size(37, 19);
            this.mlQuantity.TabIndex = 7;
            this.mlQuantity.Text = "Ilość:";
            this.mlQuantity.UseCustomBackColor = true;
            // 
            // txtPrice
            // 
            // 
            // 
            // 
            this.txtPrice.CustomButton.Image = null;
            this.txtPrice.CustomButton.Location = new System.Drawing.Point(184, 1);
            this.txtPrice.CustomButton.Name = "";
            this.txtPrice.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtPrice.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPrice.CustomButton.TabIndex = 1;
            this.txtPrice.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPrice.CustomButton.UseSelectable = true;
            this.txtPrice.CustomButton.Visible = false;
            this.txtPrice.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "Cena", true));
            this.txtPrice.Lines = new string[0];
            this.txtPrice.Location = new System.Drawing.Point(255, 131);
            this.txtPrice.MaxLength = 32767;
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.PasswordChar = '\0';
            this.txtPrice.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPrice.SelectedText = "";
            this.txtPrice.SelectionLength = 0;
            this.txtPrice.SelectionStart = 0;
            this.txtPrice.ShortcutsEnabled = true;
            this.txtPrice.Size = new System.Drawing.Size(206, 23);
            this.txtPrice.TabIndex = 5;
            this.txtPrice.UseSelectable = true;
            this.txtPrice.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPrice.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.validateTextBox);
            this.txtPrice.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtPrice_KeyUp);
            // 
            // txtGrossPrice
            // 
            this.txtGrossPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            // 
            // 
            // 
            this.txtGrossPrice.CustomButton.Image = null;
            this.txtGrossPrice.CustomButton.Location = new System.Drawing.Point(185, 1);
            this.txtGrossPrice.CustomButton.Name = "";
            this.txtGrossPrice.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtGrossPrice.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtGrossPrice.CustomButton.TabIndex = 1;
            this.txtGrossPrice.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtGrossPrice.CustomButton.UseSelectable = true;
            this.txtGrossPrice.CustomButton.Visible = false;
            this.txtGrossPrice.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "CenaBrutto", true));
            this.txtGrossPrice.Lines = new string[0];
            this.txtGrossPrice.Location = new System.Drawing.Point(255, 100);
            this.txtGrossPrice.MaxLength = 32767;
            this.txtGrossPrice.Name = "txtGrossPrice";
            this.txtGrossPrice.PasswordChar = '\0';
            this.txtGrossPrice.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtGrossPrice.SelectedText = "";
            this.txtGrossPrice.SelectionLength = 0;
            this.txtGrossPrice.SelectionStart = 0;
            this.txtGrossPrice.ShortcutsEnabled = true;
            this.txtGrossPrice.Size = new System.Drawing.Size(207, 23);
            this.txtGrossPrice.TabIndex = 4;
            this.txtGrossPrice.UseCustomBackColor = true;
            this.txtGrossPrice.UseSelectable = true;
            this.txtGrossPrice.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtGrossPrice.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtGrossPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.validateTextBox);
            // 
            // txtNetPrice
            // 
            // 
            // 
            // 
            this.txtNetPrice.CustomButton.Image = null;
            this.txtNetPrice.CustomButton.Location = new System.Drawing.Point(184, 1);
            this.txtNetPrice.CustomButton.Name = "";
            this.txtNetPrice.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtNetPrice.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNetPrice.CustomButton.TabIndex = 1;
            this.txtNetPrice.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNetPrice.CustomButton.UseSelectable = true;
            this.txtNetPrice.CustomButton.Visible = false;
            this.txtNetPrice.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "CenaNetto", true));
            this.txtNetPrice.Lines = new string[0];
            this.txtNetPrice.Location = new System.Drawing.Point(255, 71);
            this.txtNetPrice.MaxLength = 32767;
            this.txtNetPrice.Name = "txtNetPrice";
            this.txtNetPrice.PasswordChar = '\0';
            this.txtNetPrice.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNetPrice.SelectedText = "";
            this.txtNetPrice.SelectionLength = 0;
            this.txtNetPrice.SelectionStart = 0;
            this.txtNetPrice.ShortcutsEnabled = true;
            this.txtNetPrice.Size = new System.Drawing.Size(206, 23);
            this.txtNetPrice.TabIndex = 2;
            this.txtNetPrice.UseSelectable = true;
            this.txtNetPrice.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNetPrice.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtNetPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.validateTextBox);
            this.txtNetPrice.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtNetPrice_KeyUp);
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(173, 134);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(82, 19);
            this.lblPrice.TabIndex = 6;
            this.lblPrice.Text = "Cena sklepu:";
            this.lblPrice.UseCustomBackColor = true;
            // 
            // lblGrossPrice
            // 
            this.lblGrossPrice.AutoSize = true;
            this.lblGrossPrice.Location = new System.Drawing.Point(173, 104);
            this.lblGrossPrice.Name = "lblGrossPrice";
            this.lblGrossPrice.Size = new System.Drawing.Size(82, 19);
            this.lblGrossPrice.TabIndex = 5;
            this.lblGrossPrice.Text = "Cena brutto:";
            this.lblGrossPrice.UseCustomBackColor = true;
            // 
            // lblNetPrice
            // 
            this.lblNetPrice.AutoSize = true;
            this.lblNetPrice.Location = new System.Drawing.Point(173, 74);
            this.lblNetPrice.Name = "lblNetPrice";
            this.lblNetPrice.Size = new System.Drawing.Size(76, 19);
            this.lblNetPrice.TabIndex = 4;
            this.lblNetPrice.Text = "Cena netto:";
            this.lblNetPrice.UseCustomBackColor = true;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(176, 43);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(51, 19);
            this.lblName.TabIndex = 3;
            this.lblName.Text = "Nazwa:";
            // 
            // txtName
            // 
            // 
            // 
            // 
            this.txtName.CustomButton.Image = null;
            this.txtName.CustomButton.Location = new System.Drawing.Point(185, 1);
            this.txtName.CustomButton.Name = "";
            this.txtName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtName.CustomButton.TabIndex = 1;
            this.txtName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtName.CustomButton.UseSelectable = true;
            this.txtName.CustomButton.Visible = false;
            this.txtName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "Nazwa", true));
            this.txtName.Lines = new string[0];
            this.txtName.Location = new System.Drawing.Point(255, 42);
            this.txtName.MaxLength = 32767;
            this.txtName.Name = "txtName";
            this.txtName.PasswordChar = '\0';
            this.txtName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtName.SelectedText = "";
            this.txtName.SelectionLength = 0;
            this.txtName.SelectionStart = 0;
            this.txtName.ShortcutsEnabled = true;
            this.txtName.Size = new System.Drawing.Size(207, 23);
            this.txtName.TabIndex = 1;
            this.txtName.UseSelectable = true;
            this.txtName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblCode
            // 
            this.lblCode.AutoSize = true;
            this.lblCode.Location = new System.Drawing.Point(176, 14);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(35, 19);
            this.lblCode.TabIndex = 2;
            this.lblCode.Text = "Kod:";
            // 
            // txtCode
            // 
            this.txtCode.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtCode.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            // 
            // 
            // 
            this.txtCode.CustomButton.Image = global::MagZamotane4.Properties.Resources.genblack;
            this.txtCode.CustomButton.Location = new System.Drawing.Point(185, 1);
            this.txtCode.CustomButton.Name = "";
            this.txtCode.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtCode.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCode.CustomButton.TabIndex = 1;
            this.txtCode.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCode.CustomButton.UseSelectable = true;
            this.txtCode.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "Kod", true));
            this.txtCode.Lines = new string[0];
            this.txtCode.Location = new System.Drawing.Point(255, 13);
            this.txtCode.MaxLength = 32767;
            this.txtCode.Name = "txtCode";
            this.txtCode.PasswordChar = '\0';
            this.txtCode.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCode.SelectedText = "";
            this.txtCode.SelectionLength = 0;
            this.txtCode.SelectionStart = 0;
            this.txtCode.ShortcutsEnabled = true;
            this.txtCode.ShowButton = true;
            this.txtCode.Size = new System.Drawing.Size(207, 23);
            this.txtCode.TabIndex = 0;
            this.txtCode.UseSelectable = true;
            this.txtCode.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCode.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtCode.ButtonClick += new MetroFramework.Controls.MetroTextBox.ButClick(this.txtCode_ButtonClick);
            this.txtCode.Leave += new System.EventHandler(this.txtCode_Leave);
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(44, 16);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnBrowse.TabIndex = 13;
            this.btnBrowse.Text = "Wybierz";
            this.btnBrowse.UseSelectable = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // metroGrid
            // 
            this.metroGrid.AllowUserToAddRows = false;
            this.metroGrid.AllowUserToOrderColumns = true;
            this.metroGrid.AllowUserToResizeRows = false;
            this.metroGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroGrid.AutoGenerateColumns = false;
            this.metroGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.metroGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.metroGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.metroGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.metroGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.metroGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.metroGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.kodDataGridViewTextBoxColumn,
            this.Print,
            this.nazwaDataGridViewTextBoxColumn,
            this.cenaNettoDataGridViewTextBoxColumn,
            this.cenaBruttoDataGridViewTextBoxColumn,
            this.cenaDataGridViewTextBoxColumn,
            this.iloscDataGridViewTextBoxColumn,
            this.wartoscDataGridViewTextBoxColumn,
            this.jednostkaDataGridViewTextBoxColumn,
            this.vatDataGridViewTextBoxColumn,
            this.marzaDataGridViewTextBoxColumn,
            this.numFakturaDataGridViewTextBoxColumn,
            this.dataFakturaDataGridViewTextBoxColumn,
            this.Delete});
            this.metroGrid.DataSource = this.productBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.metroGrid.EnableHeadersVisualStyles = false;
            this.metroGrid.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid.Location = new System.Drawing.Point(5, 276);
            this.metroGrid.MultiSelect = false;
            this.metroGrid.Name = "metroGrid";
            this.metroGrid.ReadOnly = true;
            this.metroGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.metroGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.metroGrid.RowTemplate.Height = 28;
            this.metroGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGrid.Size = new System.Drawing.Size(785, 164);
            this.metroGrid.TabIndex = 8;
            this.metroGrid.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.metroGrid_CellContentDoubleClick);
            this.metroGrid.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.metroGrid_ColumnHeaderMouseClick);
            this.metroGrid.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.metroGrid_DataBindingComplete);
            this.metroGrid.SelectionChanged += new System.EventHandler(this.metroGrid_SelectionChanged);
            // 
            // kodDataGridViewTextBoxColumn
            // 
            this.kodDataGridViewTextBoxColumn.DataPropertyName = "Kod";
            this.kodDataGridViewTextBoxColumn.HeaderText = "Kod";
            this.kodDataGridViewTextBoxColumn.Name = "kodDataGridViewTextBoxColumn";
            this.kodDataGridViewTextBoxColumn.ReadOnly = true;
            this.kodDataGridViewTextBoxColumn.Width = 61;
            // 
            // Print
            // 
            this.Print.HeaderText = "Drukuj";
            this.Print.Image = global::MagZamotane4.Properties.Resources.print3;
            this.Print.Name = "Print";
            this.Print.ReadOnly = true;
            this.Print.Width = 46;
            // 
            // nazwaDataGridViewTextBoxColumn
            // 
            this.nazwaDataGridViewTextBoxColumn.DataPropertyName = "Nazwa";
            this.nazwaDataGridViewTextBoxColumn.HeaderText = "Nazwa";
            this.nazwaDataGridViewTextBoxColumn.Name = "nazwaDataGridViewTextBoxColumn";
            this.nazwaDataGridViewTextBoxColumn.ReadOnly = true;
            this.nazwaDataGridViewTextBoxColumn.Width = 75;
            // 
            // cenaNettoDataGridViewTextBoxColumn
            // 
            this.cenaNettoDataGridViewTextBoxColumn.DataPropertyName = "CenaNetto";
            this.cenaNettoDataGridViewTextBoxColumn.HeaderText = "Cena netto";
            this.cenaNettoDataGridViewTextBoxColumn.Name = "cenaNettoDataGridViewTextBoxColumn";
            this.cenaNettoDataGridViewTextBoxColumn.ReadOnly = true;
            this.cenaNettoDataGridViewTextBoxColumn.Width = 91;
            // 
            // cenaBruttoDataGridViewTextBoxColumn
            // 
            this.cenaBruttoDataGridViewTextBoxColumn.DataPropertyName = "CenaBrutto";
            this.cenaBruttoDataGridViewTextBoxColumn.HeaderText = "Cena brutto";
            this.cenaBruttoDataGridViewTextBoxColumn.Name = "cenaBruttoDataGridViewTextBoxColumn";
            this.cenaBruttoDataGridViewTextBoxColumn.ReadOnly = true;
            this.cenaBruttoDataGridViewTextBoxColumn.Width = 96;
            // 
            // cenaDataGridViewTextBoxColumn
            // 
            this.cenaDataGridViewTextBoxColumn.DataPropertyName = "Cena";
            this.cenaDataGridViewTextBoxColumn.HeaderText = "Cena sklepu";
            this.cenaDataGridViewTextBoxColumn.Name = "cenaDataGridViewTextBoxColumn";
            this.cenaDataGridViewTextBoxColumn.ReadOnly = true;
            this.cenaDataGridViewTextBoxColumn.Width = 96;
            // 
            // iloscDataGridViewTextBoxColumn
            // 
            this.iloscDataGridViewTextBoxColumn.DataPropertyName = "Ilosc";
            this.iloscDataGridViewTextBoxColumn.HeaderText = "Ilość";
            this.iloscDataGridViewTextBoxColumn.Name = "iloscDataGridViewTextBoxColumn";
            this.iloscDataGridViewTextBoxColumn.ReadOnly = true;
            this.iloscDataGridViewTextBoxColumn.Width = 64;
            // 
            // wartoscDataGridViewTextBoxColumn
            // 
            this.wartoscDataGridViewTextBoxColumn.DataPropertyName = "Wartosc";
            this.wartoscDataGridViewTextBoxColumn.HeaderText = "Wartość";
            this.wartoscDataGridViewTextBoxColumn.Name = "wartoscDataGridViewTextBoxColumn";
            this.wartoscDataGridViewTextBoxColumn.ReadOnly = true;
            this.wartoscDataGridViewTextBoxColumn.Width = 83;
            // 
            // jednostkaDataGridViewTextBoxColumn
            // 
            this.jednostkaDataGridViewTextBoxColumn.DataPropertyName = "Jednostka";
            this.jednostkaDataGridViewTextBoxColumn.HeaderText = "Jednostka";
            this.jednostkaDataGridViewTextBoxColumn.Name = "jednostkaDataGridViewTextBoxColumn";
            this.jednostkaDataGridViewTextBoxColumn.ReadOnly = true;
            this.jednostkaDataGridViewTextBoxColumn.Width = 93;
            // 
            // vatDataGridViewTextBoxColumn
            // 
            this.vatDataGridViewTextBoxColumn.DataPropertyName = "Vat";
            this.vatDataGridViewTextBoxColumn.HeaderText = "Podatek Vat";
            this.vatDataGridViewTextBoxColumn.Name = "vatDataGridViewTextBoxColumn";
            this.vatDataGridViewTextBoxColumn.ReadOnly = true;
            this.vatDataGridViewTextBoxColumn.Width = 95;
            // 
            // marzaDataGridViewTextBoxColumn
            // 
            this.marzaDataGridViewTextBoxColumn.DataPropertyName = "Marza";
            this.marzaDataGridViewTextBoxColumn.HeaderText = "Marża";
            this.marzaDataGridViewTextBoxColumn.Name = "marzaDataGridViewTextBoxColumn";
            this.marzaDataGridViewTextBoxColumn.ReadOnly = true;
            this.marzaDataGridViewTextBoxColumn.Width = 72;
            // 
            // numFakturaDataGridViewTextBoxColumn
            // 
            this.numFakturaDataGridViewTextBoxColumn.DataPropertyName = "NumFaktura";
            this.numFakturaDataGridViewTextBoxColumn.HeaderText = "Numer faktury";
            this.numFakturaDataGridViewTextBoxColumn.Name = "numFakturaDataGridViewTextBoxColumn";
            this.numFakturaDataGridViewTextBoxColumn.ReadOnly = true;
            this.numFakturaDataGridViewTextBoxColumn.Width = 105;
            // 
            // dataFakturaDataGridViewTextBoxColumn
            // 
            this.dataFakturaDataGridViewTextBoxColumn.DataPropertyName = "DataFaktura";
            this.dataFakturaDataGridViewTextBoxColumn.HeaderText = "Data faktury";
            this.dataFakturaDataGridViewTextBoxColumn.Name = "dataFakturaDataGridViewTextBoxColumn";
            this.dataFakturaDataGridViewTextBoxColumn.ReadOnly = true;
            this.dataFakturaDataGridViewTextBoxColumn.Width = 96;
            // 
            // Delete
            // 
            this.Delete.HeaderText = "Usuń";
            this.Delete.Image = global::MagZamotane4.Properties.Resources.delete2;
            this.Delete.Name = "Delete";
            this.Delete.ReadOnly = true;
            this.Delete.Width = 38;
            // 
            // btnPrint
            // 
            this.btnPrint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrint.Location = new System.Drawing.Point(712, 238);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(75, 23);
            this.btnPrint.TabIndex = 9;
            this.btnPrint.Text = "Drukuj";
            this.btnPrint.UseSelectable = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(5, 446);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(119, 19);
            this.lblTotal.TabIndex = 10;
            this.lblTotal.Text = "Liczba rekordów: 0";
            // 
            // lblPosition
            // 
            this.lblPosition.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblPosition.AutoSize = true;
            this.lblPosition.Location = new System.Drawing.Point(140, 446);
            this.lblPosition.Name = "lblPosition";
            this.lblPosition.Size = new System.Drawing.Size(66, 19);
            this.lblPosition.TabIndex = 10;
            this.lblPosition.Text = "Pozycja: 0";
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.HeaderText = "Drukuj";
            this.dataGridViewImageColumn1.Image = global::MagZamotane4.Properties.Resources.Print;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.ReadOnly = true;
            this.dataGridViewImageColumn1.Width = 46;
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.HeaderText = "Usuń";
            this.dataGridViewImageColumn2.Image = global::MagZamotane4.Properties.Resources.delete1;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.ReadOnly = true;
            this.dataGridViewImageColumn2.Width = 38;
            // 
            // lnkRefresh
            // 
            this.lnkRefresh.AutoSize = true;
            this.lnkRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.lnkRefresh.Image = global::MagZamotane4.Properties.Resources.checked16;
            this.lnkRefresh.ImageSize = 14;
            this.lnkRefresh.Location = new System.Drawing.Point(12, 280);
            this.lnkRefresh.Name = "lnkRefresh";
            this.lnkRefresh.Size = new System.Drawing.Size(18, 18);
            this.lnkRefresh.TabIndex = 1;
            this.lnkRefresh.UseCustomBackColor = true;
            this.lnkRefresh.UseSelectable = true;
            this.lnkRefresh.Click += new System.EventHandler(this.lnkRefresh_Click);
            // 
            // ucProduct
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.lblPosition);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.lnkRefresh);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.mlSearch);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.pnlContainer);
            this.Controls.Add(this.metroGrid);
            this.Name = "ucProduct";
            this.Size = new System.Drawing.Size(796, 472);
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            this.pnlContainer.ResumeLayout(false);
            this.pnlContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox txtSearch;
        private MetroFramework.Controls.MetroLabel mlSearch;
        private MetroFramework.Controls.MetroButton btnAdd;
        private MetroFramework.Controls.MetroButton btnEdit;
        private MetroFramework.Controls.MetroButton btnCancel;
        private MetroFramework.Controls.MetroButton btnSave;
        private MetroFramework.Controls.MetroTextBox txtVat;
        private System.Windows.Forms.BindingSource productBindingSource;
        private MetroFramework.Controls.MetroLabel lblVat;
        private MetroFramework.Controls.MetroPanel pnlContainer;
        private MetroFramework.Controls.MetroTextBox txtPrice;
        private MetroFramework.Controls.MetroTextBox txtGrossPrice;
        private MetroFramework.Controls.MetroTextBox txtNetPrice;
        private MetroFramework.Controls.MetroLabel lblPrice;
        private MetroFramework.Controls.MetroLabel lblGrossPrice;
        private MetroFramework.Controls.MetroLabel lblNetPrice;
        private MetroFramework.Controls.MetroLabel lblName;
        private MetroFramework.Controls.MetroTextBox txtName;
        private MetroFramework.Controls.MetroLabel lblCode;
        private MetroFramework.Controls.MetroTextBox txtCode;
        private MetroFramework.Controls.MetroButton btnBrowse;
        private System.Windows.Forms.PictureBox pic;
        private MetroFramework.Controls.MetroGrid metroGrid;
        private MetroFramework.Controls.MetroDateTime dtInvoiceDate;
        private MetroFramework.Controls.MetroTextBox txtInvoiceNumber;
        private MetroFramework.Controls.MetroTextBox txtMargin;
        private MetroFramework.Controls.MetroLabel lbInvoiceDate;
        private MetroFramework.Controls.MetroLabel mlInvoiceNumber;
        private MetroFramework.Controls.MetroLabel mlMargin;
        private MetroFramework.Controls.MetroTextBox txtValue;
        private MetroFramework.Controls.MetroTextBox txtUnit;
        private MetroFramework.Controls.MetroLabel mlValue;
        private MetroFramework.Controls.MetroLabel mlUnit;
        private MetroFramework.Controls.MetroTextBox txtQuantity;
        private MetroFramework.Controls.MetroLabel mlQuantity;
        private MetroFramework.Controls.MetroLabel lblPicturePath;
        private MetroFramework.Controls.MetroLink lnkClrImage;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn kodDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn Print;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazwaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cenaNettoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cenaBruttoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cenaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iloscDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn wartoscDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jednostkaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn marzaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numFakturaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataFakturaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn Delete;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private MetroFramework.Controls.MetroLink lnkRefresh;
        private MetroFramework.Controls.MetroButton btnPrint;
        private MetroFramework.Controls.MetroLabel lblTotal;
        private MetroFramework.Controls.MetroLabel lblPosition;
    }
}
