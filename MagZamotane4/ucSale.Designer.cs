namespace MagZamotane4
{
    partial class ucSale
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucSale));
            this.lblCode = new MetroFramework.Controls.MetroLabel();
            this.btnSave = new MetroFramework.Controls.MetroButton();
            this.txtQuantity = new MetroFramework.Controls.MetroTextBox();
            this.lblChangeQuantity = new MetroFramework.Controls.MetroLabel();
            this.txtCode = new MetroFramework.Controls.MetroTextBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.metroGrid = new MetroFramework.Controls.MetroGrid();
            this.nazwaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kodDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iloscDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jednostkaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cenaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cenaNettoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cenaBruttoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wartoscDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Delete = new System.Windows.Forms.DataGridViewImageColumn();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtLog = new MetroFramework.Controls.MetroTextBox();
            this.panelTop = new MetroFramework.Controls.MetroPanel();
            this.txtSearch = new MetroFramework.Controls.MetroTextBox();
            this.mlSearch = new MetroFramework.Controls.MetroLabel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.lnkSaveLog = new MetroFramework.Controls.MetroLink();
            this.lnkClrLog = new MetroFramework.Controls.MetroLink();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCode
            // 
            this.lblCode.AutoSize = true;
            this.lblCode.Location = new System.Drawing.Point(318, 46);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(91, 19);
            this.lblCode.TabIndex = 12;
            this.lblCode.Text = "Kod kreskowy:";
            this.lblCode.UseCustomBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(570, 162);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 32);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Zapisz";
            this.btnSave.UseSelectable = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtQuantity
            // 
            // 
            // 
            // 
            this.txtQuantity.CustomButton.Image = null;
            this.txtQuantity.CustomButton.Location = new System.Drawing.Point(99, 2);
            this.txtQuantity.CustomButton.Name = "";
            this.txtQuantity.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.txtQuantity.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtQuantity.CustomButton.TabIndex = 1;
            this.txtQuantity.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtQuantity.CustomButton.UseSelectable = true;
            this.txtQuantity.CustomButton.Visible = false;
            this.txtQuantity.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtQuantity.Lines = new string[] {
        "0"};
            this.txtQuantity.Location = new System.Drawing.Point(435, 162);
            this.txtQuantity.MaxLength = 32767;
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.PasswordChar = '\0';
            this.txtQuantity.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtQuantity.SelectedText = "";
            this.txtQuantity.SelectionLength = 0;
            this.txtQuantity.SelectionStart = 0;
            this.txtQuantity.ShortcutsEnabled = true;
            this.txtQuantity.Size = new System.Drawing.Size(129, 32);
            this.txtQuantity.TabIndex = 2;
            this.txtQuantity.Text = "0";
            this.txtQuantity.UseSelectable = true;
            this.txtQuantity.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtQuantity.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtQuantity.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtQuantity_KeyDown);
            this.txtQuantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQuantity_KeyPress);
            this.txtQuantity.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtQuantity_KeyUp);
            // 
            // lblChangeQuantity
            // 
            this.lblChangeQuantity.AutoSize = true;
            this.lblChangeQuantity.Location = new System.Drawing.Point(318, 167);
            this.lblChangeQuantity.Name = "lblChangeQuantity";
            this.lblChangeQuantity.Size = new System.Drawing.Size(111, 19);
            this.lblChangeQuantity.TabIndex = 13;
            this.lblChangeQuantity.Text = "Pomniejsz ilość o:";
            this.lblChangeQuantity.UseCustomBackColor = true;
            // 
            // txtCode
            // 
            // 
            // 
            // 
            this.txtCode.CustomButton.Image = null;
            this.txtCode.CustomButton.Location = new System.Drawing.Point(222, 1);
            this.txtCode.CustomButton.Name = "";
            this.txtCode.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtCode.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCode.CustomButton.TabIndex = 1;
            this.txtCode.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCode.CustomButton.UseSelectable = true;
            this.txtCode.CustomButton.Visible = false;
            this.txtCode.Lines = new string[0];
            this.txtCode.Location = new System.Drawing.Point(415, 46);
            this.txtCode.MaxLength = 32767;
            this.txtCode.Name = "txtCode";
            this.txtCode.PasswordChar = '\0';
            this.txtCode.PromptText = "kod kreskowy";
            this.txtCode.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCode.SelectedText = "";
            this.txtCode.SelectionLength = 0;
            this.txtCode.SelectionStart = 0;
            this.txtCode.ShortcutsEnabled = true;
            this.txtCode.Size = new System.Drawing.Size(244, 23);
            this.txtCode.TabIndex = 0;
            this.txtCode.UseSelectable = true;
            this.txtCode.WaterMark = "kod kreskowy";
            this.txtCode.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCode.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // timer
            // 
            this.timer.Interval = 500;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // metroGrid
            // 
            this.metroGrid.AllowUserToAddRows = false;
            this.metroGrid.AllowUserToDeleteRows = false;
            this.metroGrid.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.metroGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
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
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.metroGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.metroGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nazwaDataGridViewTextBoxColumn,
            this.kodDataGridViewTextBoxColumn,
            this.iloscDataGridViewTextBoxColumn,
            this.jednostkaDataGridViewTextBoxColumn,
            this.cenaDataGridViewTextBoxColumn,
            this.cenaNettoDataGridViewTextBoxColumn,
            this.cenaBruttoDataGridViewTextBoxColumn,
            this.wartoscDataGridViewTextBoxColumn,
            this.Delete});
            this.metroGrid.DataSource = this.productBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGrid.DefaultCellStyle = dataGridViewCellStyle3;
            this.metroGrid.EnableHeadersVisualStyles = false;
            this.metroGrid.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid.Location = new System.Drawing.Point(3, 268);
            this.metroGrid.MultiSelect = false;
            this.metroGrid.Name = "metroGrid";
            this.metroGrid.ReadOnly = true;
            this.metroGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.metroGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.metroGrid.RowTemplate.Height = 28;
            this.metroGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGrid.Size = new System.Drawing.Size(960, 120);
            this.metroGrid.TabIndex = 0;
            this.metroGrid.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroGrid.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.metroGrid_CellContentDoubleClick);
            // 
            // nazwaDataGridViewTextBoxColumn
            // 
            this.nazwaDataGridViewTextBoxColumn.DataPropertyName = "Nazwa";
            this.nazwaDataGridViewTextBoxColumn.HeaderText = "Nazwa";
            this.nazwaDataGridViewTextBoxColumn.Name = "nazwaDataGridViewTextBoxColumn";
            this.nazwaDataGridViewTextBoxColumn.ReadOnly = true;
            this.nazwaDataGridViewTextBoxColumn.Width = 116;
            // 
            // kodDataGridViewTextBoxColumn
            // 
            this.kodDataGridViewTextBoxColumn.DataPropertyName = "Kod";
            this.kodDataGridViewTextBoxColumn.HeaderText = "Kod";
            this.kodDataGridViewTextBoxColumn.Name = "kodDataGridViewTextBoxColumn";
            this.kodDataGridViewTextBoxColumn.ReadOnly = true;
            this.kodDataGridViewTextBoxColumn.Width = 87;
            // 
            // iloscDataGridViewTextBoxColumn
            // 
            this.iloscDataGridViewTextBoxColumn.DataPropertyName = "Ilosc";
            this.iloscDataGridViewTextBoxColumn.HeaderText = "Ilość";
            this.iloscDataGridViewTextBoxColumn.Name = "iloscDataGridViewTextBoxColumn";
            this.iloscDataGridViewTextBoxColumn.ReadOnly = true;
            this.iloscDataGridViewTextBoxColumn.Width = 94;
            // 
            // jednostkaDataGridViewTextBoxColumn
            // 
            this.jednostkaDataGridViewTextBoxColumn.DataPropertyName = "Jednostka";
            this.jednostkaDataGridViewTextBoxColumn.HeaderText = "Jednostka";
            this.jednostkaDataGridViewTextBoxColumn.Name = "jednostkaDataGridViewTextBoxColumn";
            this.jednostkaDataGridViewTextBoxColumn.ReadOnly = true;
            this.jednostkaDataGridViewTextBoxColumn.Width = 149;
            // 
            // cenaDataGridViewTextBoxColumn
            // 
            this.cenaDataGridViewTextBoxColumn.DataPropertyName = "Cena";
            this.cenaDataGridViewTextBoxColumn.HeaderText = "Cena sklepowa";
            this.cenaDataGridViewTextBoxColumn.Name = "cenaDataGridViewTextBoxColumn";
            this.cenaDataGridViewTextBoxColumn.ReadOnly = true;
            this.cenaDataGridViewTextBoxColumn.Width = 200;
            // 
            // cenaNettoDataGridViewTextBoxColumn
            // 
            this.cenaNettoDataGridViewTextBoxColumn.DataPropertyName = "CenaNetto";
            this.cenaNettoDataGridViewTextBoxColumn.HeaderText = "Cena netto";
            this.cenaNettoDataGridViewTextBoxColumn.Name = "cenaNettoDataGridViewTextBoxColumn";
            this.cenaNettoDataGridViewTextBoxColumn.ReadOnly = true;
            this.cenaNettoDataGridViewTextBoxColumn.Width = 159;
            // 
            // cenaBruttoDataGridViewTextBoxColumn
            // 
            this.cenaBruttoDataGridViewTextBoxColumn.DataPropertyName = "CenaBrutto";
            this.cenaBruttoDataGridViewTextBoxColumn.HeaderText = "Cena brutto";
            this.cenaBruttoDataGridViewTextBoxColumn.Name = "cenaBruttoDataGridViewTextBoxColumn";
            this.cenaBruttoDataGridViewTextBoxColumn.ReadOnly = true;
            this.cenaBruttoDataGridViewTextBoxColumn.Width = 169;
            // 
            // wartoscDataGridViewTextBoxColumn
            // 
            this.wartoscDataGridViewTextBoxColumn.DataPropertyName = "Wartosc";
            this.wartoscDataGridViewTextBoxColumn.HeaderText = "Wartość";
            this.wartoscDataGridViewTextBoxColumn.Name = "wartoscDataGridViewTextBoxColumn";
            this.wartoscDataGridViewTextBoxColumn.ReadOnly = true;
            this.wartoscDataGridViewTextBoxColumn.Width = 130;
            // 
            // Delete
            // 
            this.Delete.HeaderText = "Usuń z listy";
            this.Delete.Image = global::MagZamotane4.Properties.Resources.delete2;
            this.Delete.Name = "Delete";
            this.Delete.ReadOnly = true;
            this.Delete.Width = 133;
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataSource = typeof(MagZamotane4.Core.Product);
            // 
            // txtLog
            // 
            this.txtLog.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            // 
            // 
            // 
            this.txtLog.CustomButton.Image = null;
            this.txtLog.CustomButton.Location = new System.Drawing.Point(880, 1);
            this.txtLog.CustomButton.Name = "";
            this.txtLog.CustomButton.Size = new System.Drawing.Size(79, 79);
            this.txtLog.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtLog.CustomButton.TabIndex = 1;
            this.txtLog.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtLog.CustomButton.UseSelectable = true;
            this.txtLog.CustomButton.Visible = false;
            this.txtLog.Lines = new string[0];
            this.txtLog.Location = new System.Drawing.Point(3, 422);
            this.txtLog.MaxLength = 32767;
            this.txtLog.Multiline = true;
            this.txtLog.Name = "txtLog";
            this.txtLog.PasswordChar = '\0';
            this.txtLog.ReadOnly = true;
            this.txtLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtLog.SelectedText = "";
            this.txtLog.SelectionLength = 0;
            this.txtLog.SelectionStart = 0;
            this.txtLog.ShortcutsEnabled = true;
            this.txtLog.Size = new System.Drawing.Size(960, 81);
            this.txtLog.TabIndex = 3;
            this.txtLog.UseCustomBackColor = true;
            this.txtLog.UseSelectable = true;
            this.txtLog.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtLog.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // panelTop
            // 
            this.panelTop.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.panelTop.Controls.Add(this.txtSearch);
            this.panelTop.Controls.Add(this.mlSearch);
            this.panelTop.Controls.Add(this.pictureBox3);
            this.panelTop.Controls.Add(this.txtCode);
            this.panelTop.Controls.Add(this.lblChangeQuantity);
            this.panelTop.Controls.Add(this.lblCode);
            this.panelTop.Controls.Add(this.txtQuantity);
            this.panelTop.Controls.Add(this.btnSave);
            this.panelTop.HorizontalScrollbarBarColor = true;
            this.panelTop.HorizontalScrollbarHighlightOnWheel = false;
            this.panelTop.HorizontalScrollbarSize = 10;
            this.panelTop.Location = new System.Drawing.Point(3, 3);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(963, 259);
            this.panelTop.TabIndex = 20;
            this.panelTop.UseCustomBackColor = true;
            this.panelTop.VerticalScrollbarBarColor = true;
            this.panelTop.VerticalScrollbarHighlightOnWheel = false;
            this.panelTop.VerticalScrollbarSize = 10;
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
            this.txtSearch.Location = new System.Drawing.Point(415, 84);
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
            this.txtSearch.TabIndex = 1;
            this.txtSearch.UseSelectable = true;
            this.txtSearch.WaterMark = "szukaj po nazwie lub kodzie";
            this.txtSearch.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSearch.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtSearch.ButtonClick += new MetroFramework.Controls.MetroTextBox.ButClick(this.txtSearch_ButtonClick);
            this.txtSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSearch_KeyDown);
            // 
            // mlSearch
            // 
            this.mlSearch.AutoSize = true;
            this.mlSearch.Location = new System.Drawing.Point(361, 84);
            this.mlSearch.Name = "mlSearch";
            this.mlSearch.Size = new System.Drawing.Size(48, 19);
            this.mlSearch.TabIndex = 19;
            this.mlSearch.Text = "Szukaj:";
            this.mlSearch.UseCustomBackColor = true;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(27, 12);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(214, 235);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox3.TabIndex = 18;
            this.pictureBox3.TabStop = false;
            // 
            // lnkSaveLog
            // 
            this.lnkSaveLog.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lnkSaveLog.AutoSize = true;
            this.lnkSaveLog.Image = global::MagZamotane4.Properties.Resources.saveas26;
            this.lnkSaveLog.ImageSize = 18;
            this.lnkSaveLog.Location = new System.Drawing.Point(906, 394);
            this.lnkSaveLog.Name = "lnkSaveLog";
            this.lnkSaveLog.Size = new System.Drawing.Size(22, 22);
            this.lnkSaveLog.TabIndex = 1;
            this.lnkSaveLog.UseSelectable = true;
            this.lnkSaveLog.Click += new System.EventHandler(this.lnkSaveLog_Click);
            // 
            // lnkClrLog
            // 
            this.lnkClrLog.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lnkClrLog.AutoSize = true;
            this.lnkClrLog.Image = ((System.Drawing.Image)(resources.GetObject("lnkClrLog.Image")));
            this.lnkClrLog.ImageSize = 18;
            this.lnkClrLog.Location = new System.Drawing.Point(934, 394);
            this.lnkClrLog.Name = "lnkClrLog";
            this.lnkClrLog.Size = new System.Drawing.Size(22, 22);
            this.lnkClrLog.TabIndex = 2;
            this.lnkClrLog.UseSelectable = true;
            this.lnkClrLog.Click += new System.EventHandler(this.lnkClrLog_Click);
            // 
            // ucSale
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.lnkSaveLog);
            this.Controls.Add(this.lnkClrLog);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.txtLog);
            this.Controls.Add(this.metroGrid);
            this.Name = "ucSale";
            this.Size = new System.Drawing.Size(966, 506);
            this.Load += new System.EventHandler(this.ucSale_Load);
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroLabel lblCode;
        private MetroFramework.Controls.MetroButton btnSave;
        private MetroFramework.Controls.MetroTextBox txtQuantity;
        private MetroFramework.Controls.MetroLabel lblChangeQuantity;
        private MetroFramework.Controls.MetroTextBox txtCode;
        private System.Windows.Forms.Timer timer;
        private MetroFramework.Controls.MetroGrid metroGrid;
        private System.Windows.Forms.BindingSource productBindingSource;
        private System.Windows.Forms.PictureBox pictureBox3;
        private MetroFramework.Controls.MetroTextBox txtLog;
        private MetroFramework.Controls.MetroPanel panelTop;
        private MetroFramework.Controls.MetroLink lnkClrLog;
        private MetroFramework.Controls.MetroLink lnkSaveLog;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazwaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kodDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iloscDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jednostkaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cenaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cenaNettoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cenaBruttoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn wartoscDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn Delete;
        private MetroFramework.Controls.MetroTextBox txtSearch;
        private MetroFramework.Controls.MetroLabel mlSearch;
    }
}
