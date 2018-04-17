using System;
using System.Collections.Generic;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using MagZamotane4.Core;
using MagZamotane4.Services;
using System.IO;
using System.Threading;
using Tulpep.NotificationWindow;

namespace MagZamotane4
{
    public partial class ucProduct : MetroFramework.Controls.MetroUserControl
    {

        #region UI const and variable

        EntityState objState;
        private bool generatedNumber = false;
        Product tmpobj = new Product();

        #endregion

        #region UI constractor

        public ucProduct()
        {
            InitializeComponent();
            this.StyleManager = frmDashboard.Instance.StyleManager;
        }

        #endregion

        #region UI public methods

        private static frmLoadData _splash = null;
        public static void CloseSplash()
        {
            if (_splash != null)
            {
                _splash.CloseSplash();
            }
        }

        public void setAllProduct(List<Product> products, bool autoCompleteCustomSource)
        {
            Thread t = new Thread(new ThreadStart(delegate
            {
                _splash = new frmLoadData();
                _splash.ShowDialog();
            }));
            try
            {
                t.Start();
                metroGrid.ColumnHeadersVisible = false;
                productBindingSource.ResetBindings(false);
                productBindingSource.DataSource = products;
                metroGrid.ColumnHeadersVisible = true;
                productBindingSource.MoveFirst();
                if (autoCompleteCustomSource)
                fillAutoCompleteCustomSource();
               
                pnlContainer.Enabled = false;
                generatedNumber = false;
                objState = EntityState.Unchanged;
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Komunikat błędu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                _splash.CloseSplash();
            }
        }

        #endregion

        #region UI private methods

        private void addAutoCompleteCustomSource(Product p)
        {
                if (!string.IsNullOrEmpty(p.Nazwa)) txtSearch.AutoCompleteCustomSource.Add(p.Nazwa);
                if (!string.IsNullOrEmpty(p.Jednostka)) txtUnit.AutoCompleteCustomSource.Add(p.Jednostka);
                if (!string.IsNullOrEmpty(p.Kod)) txtCode.AutoCompleteCustomSource.Add(p.Kod);
                if (!string.IsNullOrEmpty(p.NumFaktura)) txtInvoiceNumber.AutoCompleteCustomSource.Insert(0, p.NumFaktura);
        }

        private void fillAutoCompleteCustomSource()
        {
            AutoCompleteStringCollection acName = new AutoCompleteStringCollection();
            AutoCompleteStringCollection acUnit = new AutoCompleteStringCollection();
            AutoCompleteStringCollection acCode = new AutoCompleteStringCollection();
            AutoCompleteStringCollection acInvoiceNumber = new AutoCompleteStringCollection();
            foreach (Product p in productBindingSource.DataSource as List<Product>)
            {
                if (!string.IsNullOrEmpty(p.Nazwa))
                {
                    acName.Add(p.Nazwa);
                    txtSearch.AutoCompleteCustomSource = acName;
                }
                if (!string.IsNullOrEmpty(p.Jednostka))
                {
                    acUnit.Add(p.Jednostka);
                    txtUnit.AutoCompleteCustomSource = acUnit;
                }
                if (!string.IsNullOrEmpty(p.Kod))
                {
                    acCode.Add(p.Kod);
                    txtCode.AutoCompleteCustomSource = acCode;
                }

                if (!string.IsNullOrEmpty(p.NumFaktura))
                {
                    acInvoiceNumber.Add(p.NumFaktura);
                    txtInvoiceNumber.AutoCompleteCustomSource = acInvoiceNumber;
                }
            }

        }

        private IEnumerable<Product> QueryByKey(int key, string searchText)
        {
            IEnumerable<Product> productQuery = null;
            productQuery = from o in (productBindingSource.DataSource as List<Product>)
                           select o;
            switch (key)
            {
                case (1):
                    productQuery = productQuery.Where(o => o.Nazwa.ToUpper().Contains(searchText.ToUpper()) || o.Kod == searchText);
                    //  productQuery = productQuery.Where(o => o.Nazwa.ToUpper().Contains(searchText.ToUpper()) || o.Kod == searchText);

                    break;
                case (2):
                    productQuery = productQuery.Where(o => o.Kod == searchText);
                    break;

                default:
                    break;
            }   

            return productQuery;
        }

        private void searchProductBindingSource(string searchText)
        {
            if (string.IsNullOrEmpty(searchText))
            {
                setAllProduct(frmDashboard.Instance.Products, false);
            }
            else
            {
              productBindingSource.DataSource = QueryByKey(1, searchText).ToList();
            }
        }

        private void loadPicture()
        {
            try
            {
                Product obj = productBindingSource.Current as Product;
                if (obj != null)
                {
                    pic.Image = Properties.Resources.noimage;
                    if (!string.IsNullOrEmpty(obj.Obrazek))
                        if (File.Exists(obj.Obrazek))
                        {
                            pic.Image = resizeImage(Image.FromFile(obj.Obrazek));
                            pic.Refresh();
                        }
                }
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Komunikat błędu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private Image resizeImage(Image img)
        {
            Bitmap original = new Bitmap(img);
            var x = Convert.ToInt32(Math.Ceiling(original.Width / 150.00));
            return new Bitmap(original, new Size(original.Width / x, original.Height / x));
        }

        int nextNumber = 0;
        private string getNextNumber()
        {
            string maskZero = "0000000000";
            string result = string.Empty;
            try
            {
                nextNumber = Int32.Parse(frmDashboard.Instance.Enumerator[0].numer) + 1;
                generatedNumber = true;
                result = maskZero + nextNumber.ToString();
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Komunikat błędu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return result;
        }

        private void printCode()
        {
            Product obj = productBindingSource.Current as Product;
            if (obj != null)
            {
                ucBarCode uc;
                if (!frmDashboard.Instance.MetroContainer.Controls.ContainsKey("ucBarCode"))
                {
                    uc = new ucBarCode();
                    uc.Dock = DockStyle.Fill;
                    frmDashboard.Instance.MetroContainer.Controls.Add(uc);
                }
                else
                {
                    uc = (frmDashboard.Instance.MetroContainer.Controls["ucBarCode"]) as ucBarCode;
                }

                uc.generateCode(obj.Kod, obj.Nazwa);

                frmDashboard.Instance.MetroContainer.Controls["ucBarCode"].BringToFront();
                frmDashboard.Instance.MetroBack.Visible = true;
                frmDashboard.Instance.setPage("ucProduct");
            }

        }

        private void deleteRecord()
        {
            if (MetroFramework.MetroMessageBox.Show(this, "Czy na pewno chcesz usunąć ten rekord z bazy?", "Konieczne potwierdzenie", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                objState = EntityState.Deleted;
                try
                {
                    Product obj = productBindingSource.Current as Product;
                    if (obj != null)
                    {
                        bool result = ProductService.Delete(obj.Identyfikator);
                        if (result)
                        {
                            productBindingSource.RemoveCurrent();
                            var index = productBindingSource.IndexOf(productBindingSource.Current);
                            metroGrid.Rows[index].Selected = true;                         
                            metroGrid.Refresh();
                            pnlContainer.Enabled = false;
                            //pic.Image = null;
                            objState = EntityState.Unchanged;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MetroFramework.MetroMessageBox.Show(this, ex.Message, "Komunikat błędu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        #endregion

        #region UI events

        #region UI events - buttons

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "JPEG|*.jpg|PNG|*.png", ValidateNames = true })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    pic.Image = resizeImage(Image.FromFile(ofd.FileName));
                    Product obj = productBindingSource.Current as Product;
                    if (obj != null)
                    {
                        obj.Obrazek = ofd.FileName;
                        lblPicturePath.Text = obj.Obrazek;
                    }
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (objState == EntityState.Unchanged)
            {
                objState = EntityState.Added;
                pic.Image = null;
                pnlContainer.Enabled = true;
                productBindingSource.Add(new Product());
                productBindingSource.MoveLast();
                txtCode.Focus();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            pic.Image = Properties.Resources.noimage;
          
            Product obj = productBindingSource.Current as Product;
            if(objState == EntityState.Added)
            {
                productBindingSource.MovePrevious();
                productBindingSource.Remove(obj);
            }
            if (objState == EntityState.Changed)
            {
                obj.Copy(tmpobj);
                productBindingSource.ResetBindings(false);
                metroGrid.Refresh();
            }

            pnlContainer.Enabled = false;
            generatedNumber = false;
            objState = EntityState.Unchanged;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (objState == EntityState.Unchanged)
            {
            tmpobj = (productBindingSource.Current as Product).Clone();
            objState = EntityState.Changed;
            pnlContainer.Enabled = true;
            txtName.Focus();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                productBindingSource.EndEdit();
                Product obj = productBindingSource.Current as Product;
                if (obj != null)
                {
                    if (objState != EntityState.Unchanged)
                    {
                        if (!string.IsNullOrEmpty(obj.Kod) && !string.IsNullOrEmpty(obj.Nazwa))
                        {                      
                        if (generatedNumber)
                        {
                            frmDashboard.Instance.Enumerator[0].numer = nextNumber.ToString();
                            if (EnumeratorService.Update(frmDashboard.Instance.Enumerator[0]))                          
                                obj = ProductService.Save(obj, objState);                                                        
                        }
                        else obj = ProductService.Save(obj, objState);
                            showNotification("Informacja", "Pomyślnie wprowadzono zmiany do bazy danych");
                            if (objState == EntityState.Added)
                        {
                            addAutoCompleteCustomSource(obj);
                        }

                        var _obj = frmDashboard.Instance.Products.Find(obj.Equals);
                        _obj = obj;
                       
                        metroGrid.Refresh();
                        pnlContainer.Enabled = false ;
                        objState = EntityState.Unchanged;

                        } else
                            MetroFramework.MetroMessageBox.Show(this, "Musi być wypełniony kod i nazwa produktu!", "Komunikat błędu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Komunikat błędu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            using (frmPrint frm = new frmPrint(productBindingSource.DataSource as List<Product>))
            {
                frm.ShowDialog();
            }
        }

        #endregion

        #region UI events - text

        private void validateTextBox(object sender, KeyPressEventArgs e)
        {
            const char commaConst = ',';

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != commaConst))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == commaConst) && ((sender as MetroFramework.Controls.MetroTextBox).Text.IndexOf(commaConst) > -1))
            {
                e.Handled = true;
            }
        }

        private void txtNetPrice_KeyUp(object sender, KeyEventArgs e)
        {
            txtVat.Text = txtVat.Text != "" ? txtVat.Text : "23";
            txtGrossPrice.Text = Calculate.calculateGrossPrice(txtNetPrice.Text, txtVat.Text);

            Product obj = productBindingSource.Current as Product;
            if (obj != null)
            {
                obj.Vat = txtVat.Text;
                obj.CenaBrutto = txtGrossPrice.Text;
            }
        }

        private void txtVat_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtVat_KeyUp(object sender, KeyEventArgs e)
        {
            var VatText = txtVat.Text != "" ? txtVat.Text : "23";
            txtGrossPrice.Text = Calculate.calculateGrossPrice(txtNetPrice.Text, VatText);

            Product obj = productBindingSource.Current as Product;
            if (obj != null)
            {
                obj.Vat = txtVat.Text;
                obj.CenaBrutto = txtGrossPrice.Text;
            }
        }

        private void txtPrice_KeyUp(object sender, KeyEventArgs e)
        {
            txtMargin.Text = Calculate.calculateMargin(txtGrossPrice.Text, txtPrice.Text);
            Product obj = productBindingSource.Current as Product;
            if (obj != null)
                obj.Marza = txtMargin.Text;
        }

        private void txtQuantity_KeyUp(object sender, KeyEventArgs e)
        {
            txtValue.Text = Calculate.calculatePriceValue(txtNetPrice.Text, txtQuantity.Text);
            Product obj = productBindingSource.Current as Product;
            if (obj != null)
                obj.Wartosc = txtValue.Text;
        }

        private void txtCode_ButtonClick(object sender, EventArgs e)
        {
            txtCode.Text = getNextNumber();
        }

        private void mtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                searchProductBindingSource(txtSearch.Text);
            }
        }

        private void mtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if (e.KeyChar == (char)13)
            //{
            //    searchProductBindingSource(txtSearch.Text);
            //}
        }

        private void mtSearch_ButtonClick(object sender, EventArgs e)
        {
            searchProductBindingSource(txtSearch.Text);
        }

        private void showNotification(string TitleText, string ContentText)
        {
            PopupNotifier popup = new PopupNotifier();
            popup.ImagePadding = new Padding(4, 4, 4, 4); ;
            popup.Image = Properties.Resources.info48;
            popup.TitleText = TitleText;
            popup.ContentText = ContentText;
            popup.Popup();
        }


        #endregion

        private void lblClrImage_Click(object sender, EventArgs e)
        {
            Product obj = productBindingSource.Current as Product;
            if (obj != null)
            {
                obj.Obrazek = string.Empty;
                lblPicturePath.Text = string.Empty;
                pic.Image = Properties.Resources.noimage;
                objState = EntityState.Changed;
            }
        }

        private void metroGrid_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                if (metroGrid.Columns[e.ColumnIndex].Name == "Print")
                    printCode();
                else if (metroGrid.Columns[e.ColumnIndex].Name == "Delete")
                    deleteRecord();
            } 

        }

        private void lnkRefresh_Click(object sender, EventArgs e)
        {
            //setAllProduct(frmDashboard.Instance.Products);
            foreach (var item in frmDashboard.Instance.Products)
            {
                var Value = Calculate.calculatePriceValue(item.CenaNetto, item.Ilosc);
                if(Value != item.Wartosc)
                MetroFramework.MetroMessageBox.Show(this, string.Format("Sprawdzenie wartości. Nazwa: {0}. Wyliczono {1}. Jest {2}.", item.Nazwa, Value, item.Wartosc), "Komunikat", MessageBoxButtons.OK, MessageBoxIcon.None);

                var GrossPrice = Calculate.calculateGrossPrice(item.CenaNetto, item.Vat);
                if(GrossPrice != item.CenaBrutto)
                MetroFramework.MetroMessageBox.Show(this, string.Format("Sprawdzenie ceny brutto. Nazwa: {0}. Wyliczono {1}. Jest {2}.", item.Nazwa, GrossPrice, item.CenaBrutto), "Komunikat", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
        }

        private void lblPicturePath_TextChanged(object sender, EventArgs e)
        {
            loadPicture();
        }

        private void txtCode_Leave(object sender, EventArgs e)
        {
            if (objState == EntityState.Added)
            {
                var query = from o in (productBindingSource.DataSource as List<Product>)
                            where o.Kod == txtCode.Text
                            select o;

                if (query.ToList().Count > 0)
                {
                    if (MetroFramework.MetroMessageBox.Show(this, "Podany kod już istnieje w bazie danych. Czy chcesz dalej kontynuwać?", "Konieczne potwierdzenie", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                    {
                        txtCode.Text = string.Empty;
                        txtCode.Focus();
                    }

                }
            }
            
        }

        private void metroGrid_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            lblTotal.Text = string.Format("Liczba rekordów: {0}", this.productBindingSource.Count);
        }

        private bool toggleCode { get; set; }
        private bool toggleName { get; set; }
        private bool toggleInvDate { get; set; }
        private bool toggleQuantity { get; set; }

        private void metroGrid_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {            
            var unSort = productBindingSource.DataSource as List<Product>;
            const byte CodeFild = 0;
            const byte NameFild = 2;
            const byte InvDateFild = 6;
            const byte QuantityFild = 11;

            switch (e.ColumnIndex)
            {
                case (CodeFild):
                    if (toggleCode)
                        productBindingSource.DataSource = unSort.OrderBy(r => r.Kod).ToList();
                    else
                        productBindingSource.DataSource = unSort.OrderByDescending(r => r.Kod).ToList();
                    toggleCode = !toggleCode;
                    break;
                case (NameFild):
                    if(toggleName)
                            productBindingSource.DataSource = unSort.OrderBy(r => r.Nazwa).ToList();
                    else
                            productBindingSource.DataSource = unSort.OrderByDescending(r => r.Nazwa).ToList();
                    toggleName = !toggleName;
                    break;
                case (InvDateFild):
                    if (toggleInvDate)
                        productBindingSource.DataSource = unSort.OrderBy(r => r.Ilosc).ToList();
                    else
                        productBindingSource.DataSource = unSort.OrderByDescending(r => r.Ilosc).ToList();
                    toggleInvDate = !toggleInvDate;
                    break;
                case (QuantityFild):
                    if (toggleQuantity)
                        productBindingSource.DataSource = unSort.OrderBy(r => r.NumFaktura).ToList();
                    else
                        productBindingSource.DataSource = unSort.OrderByDescending(r => r.NumFaktura).ToList();
                    toggleQuantity = !toggleQuantity;
                    break;

                default:
                    break;
            }
        }


        #endregion

        private void metroGrid_SelectionChanged(object sender, EventArgs e)
        {
            lblPosition.Text = string.Format("Pozycja: {0}", this.productBindingSource.Position + 1);
        }


    }
}
