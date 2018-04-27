namespace MagZamotane4
{
    partial class ucDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucDashboard));
            this.mtBackupDB = new MetroFramework.Controls.MetroTile();
            this.mtSale = new MetroFramework.Controls.MetroTile();
            this.mtWebBrowser = new MetroFramework.Controls.MetroTile();
            this.mtProduct = new MetroFramework.Controls.MetroTile();
            this.mtBarCodes = new MetroFramework.Controls.MetroTile();
            this.mtStocktaking = new MetroFramework.Controls.MetroTile();
            this.SuspendLayout();
            // 
            // mtBackupDB
            // 
            this.mtBackupDB.ActiveControl = null;
            this.mtBackupDB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(171)))), ((int)(((byte)(171)))));
            this.mtBackupDB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.mtBackupDB.Location = new System.Drawing.Point(375, 21);
            this.mtBackupDB.Name = "mtBackupDB";
            this.mtBackupDB.Size = new System.Drawing.Size(153, 134);
            this.mtBackupDB.TabIndex = 9;
            this.mtBackupDB.Text = "Zrób kopię bazy";
            this.mtBackupDB.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.mtBackupDB.TileImage = ((System.Drawing.Image)(resources.GetObject("mtBackupDB.TileImage")));
            this.mtBackupDB.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mtBackupDB.UseCustomBackColor = true;
            this.mtBackupDB.UseSelectable = true;
            this.mtBackupDB.UseTileImage = true;
            this.mtBackupDB.Click += new System.EventHandler(this.mtBackupDB_Click);
            // 
            // mtSale
            // 
            this.mtSale.ActiveControl = null;
            this.mtSale.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(87)))), ((int)(((byte)(0)))));
            this.mtSale.Location = new System.Drawing.Point(23, 21);
            this.mtSale.Name = "mtSale";
            this.mtSale.Size = new System.Drawing.Size(153, 134);
            this.mtSale.TabIndex = 5;
            this.mtSale.Text = "Sprzedaj produkt";
            this.mtSale.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.mtSale.TileImage = ((System.Drawing.Image)(resources.GetObject("mtSale.TileImage")));
            this.mtSale.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mtSale.UseCustomBackColor = true;
            this.mtSale.UseSelectable = true;
            this.mtSale.UseTileImage = true;
            this.mtSale.Click += new System.EventHandler(this.mtSale_Click);
            // 
            // mtWebBrowser
            // 
            this.mtWebBrowser.ActiveControl = null;
            this.mtWebBrowser.Location = new System.Drawing.Point(182, 161);
            this.mtWebBrowser.Name = "mtWebBrowser";
            this.mtWebBrowser.Size = new System.Drawing.Size(153, 134);
            this.mtWebBrowser.TabIndex = 8;
            this.mtWebBrowser.Text = "Przeglądaj internet";
            this.mtWebBrowser.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.mtWebBrowser.TileImage = ((System.Drawing.Image)(resources.GetObject("mtWebBrowser.TileImage")));
            this.mtWebBrowser.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mtWebBrowser.UseSelectable = true;
            this.mtWebBrowser.UseTileImage = true;
            this.mtWebBrowser.Click += new System.EventHandler(this.mtWebBrowser_Click);
            // 
            // mtProduct
            // 
            this.mtProduct.ActiveControl = null;
            this.mtProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(32)))), ((int)(((byte)(135)))));
            this.mtProduct.Location = new System.Drawing.Point(182, 21);
            this.mtProduct.Name = "mtProduct";
            this.mtProduct.Size = new System.Drawing.Size(153, 134);
            this.mtProduct.TabIndex = 6;
            this.mtProduct.Text = "Pracuj z produktami";
            this.mtProduct.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.mtProduct.TileImage = ((System.Drawing.Image)(resources.GetObject("mtProduct.TileImage")));
            this.mtProduct.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mtProduct.UseCustomBackColor = true;
            this.mtProduct.UseSelectable = true;
            this.mtProduct.UseStyleColors = true;
            this.mtProduct.UseTileImage = true;
            this.mtProduct.Click += new System.EventHandler(this.mtProduct_Click);
            // 
            // mtBarCodes
            // 
            this.mtBarCodes.ActiveControl = null;
            this.mtBarCodes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(16)))), ((int)(((byte)(9)))));
            this.mtBarCodes.Location = new System.Drawing.Point(23, 161);
            this.mtBarCodes.Name = "mtBarCodes";
            this.mtBarCodes.Size = new System.Drawing.Size(153, 134);
            this.mtBarCodes.TabIndex = 7;
            this.mtBarCodes.Text = "Generuj kod paskowy";
            this.mtBarCodes.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.mtBarCodes.TileImage = ((System.Drawing.Image)(resources.GetObject("mtBarCodes.TileImage")));
            this.mtBarCodes.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mtBarCodes.UseCustomBackColor = true;
            this.mtBarCodes.UseSelectable = true;
            this.mtBarCodes.UseTileImage = true;
            this.mtBarCodes.Click += new System.EventHandler(this.mtBarCodes_Click);
            // 
            // mtStocktaking
            // 
            this.mtStocktaking.ActiveControl = null;
            this.mtStocktaking.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(171)))), ((int)(((byte)(171)))));
            this.mtStocktaking.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.mtStocktaking.Location = new System.Drawing.Point(375, 161);
            this.mtStocktaking.Name = "mtStocktaking";
            this.mtStocktaking.Size = new System.Drawing.Size(153, 134);
            this.mtStocktaking.TabIndex = 9;
            this.mtStocktaking.Text = "Inwentaryzacja";
            this.mtStocktaking.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.mtStocktaking.TileImage = ((System.Drawing.Image)(resources.GetObject("mtStocktaking.TileImage")));
            this.mtStocktaking.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mtStocktaking.UseCustomBackColor = true;
            this.mtStocktaking.UseSelectable = true;
            this.mtStocktaking.UseTileImage = true;
            this.mtStocktaking.Click += new System.EventHandler(this.mtStocktaking_Click);
            // 
            // ucDashboard
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.mtStocktaking);
            this.Controls.Add(this.mtBackupDB);
            this.Controls.Add(this.mtSale);
            this.Controls.Add(this.mtWebBrowser);
            this.Controls.Add(this.mtProduct);
            this.Controls.Add(this.mtBarCodes);
            this.Name = "ucDashboard";
            this.Size = new System.Drawing.Size(757, 453);
            this.Load += new System.EventHandler(this.ucDashboard_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTile mtBackupDB;
        private MetroFramework.Controls.MetroTile mtSale;
        private MetroFramework.Controls.MetroTile mtWebBrowser;
        private MetroFramework.Controls.MetroTile mtProduct;
        private MetroFramework.Controls.MetroTile mtBarCodes;
        private MetroFramework.Controls.MetroTile mtStocktaking;
    }
}
