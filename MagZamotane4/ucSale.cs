using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using MagZamotane4.Services;
using System.Threading;
using MagZamotane4.Core;
using System.IO;
using Tulpep.NotificationWindow;

namespace MagZamotane4
{
    public partial class ucSale : MetroFramework.Controls.MetroUserControl
    {
        #region UI const and variables

        private string temp = "";
        private string CodeText = string.Empty;
        EntityState objState;

        #endregion

        #region UI constractor

        public ucSale()
        {
            Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("pl");
            InitializeComponent();
            this.StyleManager = frmDashboard.Instance.StyleManager;
        }

        #endregion

        #region UI public methods

        public void setAllProduct(List<Product> products)
        {
            AutoCompleteStringCollection acName = new AutoCompleteStringCollection();
            foreach (Product p in products as List<Product>)
            {
                if (!string.IsNullOrEmpty(p.Nazwa))
                {
                    acName.Add(p.Nazwa);
                    txtSearch.AutoCompleteCustomSource = acName;
                }
            }
        }

        #endregion

        #region UI private methods

        private void goToUcProduct()
        {
            if (!frmDashboard.Instance.MetroContainer.Controls.ContainsKey("ucProduct"))
            {
                ucProduct uc = new ucProduct();
                uc.setAllProduct(frmDashboard.Instance.Products);
                uc.Dock = DockStyle.Fill;
                frmDashboard.Instance.MetroContainer.Controls.Add(uc);
            }
            else
            {
                ucProduct uc = (frmDashboard.Instance.MetroContainer.Controls["ucProduct"]) as ucProduct;
                uc.setAllProduct(frmDashboard.Instance.Products);
            }
            frmDashboard.Instance.MetroContainer.Controls["ucProduct"].BringToFront();
            frmDashboard.Instance.MetroBack.Visible = true;
            frmDashboard.Instance.setPage("ucSale");
        }

        private void setDefault()
        {
            txtCode.Focus();
            txtLog.Text = " Log zdarzeń.";
        }

        private List<Product> searchList(string txtSearch)
        {
            List<Product> list = null;

            if (!string.IsNullOrEmpty(txtSearch))
            {
                var query = from o in (frmDashboard.Instance.Products)
                            where o.Nazwa.ToUpper().Contains(txtSearch.ToUpper()) || o.Kod == txtSearch
                            select o;
                list = query.ToList();
            }
            return list;

        }

        private List<Product> searchListByCode(string txtSearch)
        {
            List<Product> list = null;

            if (!string.IsNullOrEmpty(txtSearch))
            {
                var query = from o in (frmDashboard.Instance.Products)
                            where o.Kod == txtSearch
                            select o;
                list = query.ToList();
            }
            return list;
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

        private void addProductBindingSource(List<Product> products)
        {
            foreach (var item in products)
            {
                productBindingSource.Add(item);
                txtLog.AppendText(string.Format("\r\n[Czas: {0}] Nazwa: {1}.   Ilość towaru przed zmianą: {2}", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"), item.Nazwa, item.Ilosc));
            }
            productBindingSource.MoveLast();
        }

        #endregion

        #region UI events

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
                        obj.Ilosc = Calculate.calculateReduceAmount(obj.Ilosc, txtQuantity.Text);
                        obj.Wartosc = Calculate.calculatePriceValue(obj.CenaNetto, obj.Ilosc); 

                        obj = ProductService.Save(obj, objState);
                        var _obj = frmDashboard.Instance.Products.Find(obj.Equals);
                        _obj.Ilosc = obj.Ilosc;
                        _obj.Wartosc = obj.Wartosc;
                        metroGrid.Refresh();
                        objState = EntityState.Unchanged;
                        txtLog.AppendText(string.Format("\r\n[Czas: {0}] Nazwa: {1}.   Ilość towaru po zmianie: {2}", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"), obj.Nazwa, obj.Ilosc));
                        showNotification("Zmiana ilości", "Pomyślnie zapisano zmiany do bazy danych");
                        txtQuantity.Text = "0";
                        txtCode.Focus();
                    }

                }
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Komunikat błędu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            try
            {
                if (txtCode.Text != "" && txtCode.Text == temp)
                {
                    CodeText = txtCode.Text;
                    txtCode.Text = string.Empty;
                    objState = EntityState.Unchanged;

                    var products = searchListByCode(CodeText);

                    if (products.Count > 0)
                    {
                        addProductBindingSource(products);
                    }
                    else
                    {
                        if (!string.IsNullOrEmpty(CodeText))
                        {
                            if (MetroFramework.MetroMessageBox.Show(this, "Nie znaleziono kodu w bazie danych. Czy chcesz go dodać ?", "Konieczne potwierdzenie", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            {
                                goToUcProduct();
                            }                          
                        }
                        txtCode.Focus();
                    }
                   ;
                }
                else temp = txtCode.Text;
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                productBindingSource.ResetBindings(false);
            }
        }

        private void ucSale_Load(object sender, EventArgs e)
        {
            setDefault();
            timer.Enabled = true;
        }

        private void txtQuantity_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtQuantity_KeyUp(object sender, KeyEventArgs e)
        {
            //Product obj = productBindingSource.Current as Product;
            //if (obj != null)
            //{
            objState = EntityState.Changed;
            //    obj.Ilosc = Calculate.calculateReduceAmount(obj.Ilosc, txtQuantity.Text);
            //    obj.Wartosc = Calculate.calculatePriceValue(obj.CenaNetto, obj.Ilosc); 
            //}  
        }

        private void lnkClrLog_Click(object sender, EventArgs e)
        {
            setDefault();
        }

        private async void lnkSaveLog_Click(object sender, EventArgs e)
        {
            string logDirectory = Directory.GetCurrentDirectory() + @"\log\";
            string logName = String.Format("{0}_logSale", DateTime.Now.ToString("yyyyMMddHHmmss"));

            using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "Plik tekstowy|*.txt", ValidateNames = true, InitialDirectory = logDirectory, FileName = logName })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    using (StreamWriter sw = new StreamWriter(sfd.FileName))
                    {
                        await sw.WriteLineAsync(txtLog.Text);
                        MetroFramework.MetroMessageBox.Show(this, "Zawartość logu została zapisana.", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        private void txtQuantity_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSave_Click(sender, e);
            }
        }

        private void metroGrid_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (metroGrid.Columns[e.ColumnIndex].Name == "Delete")
            {
                if(e.RowIndex > -1)                
                metroGrid.Rows.RemoveAt(e.RowIndex);
            }
        }

        private void txtSearch_ButtonClick(object sender, EventArgs e)
        {
            addProductBindingSource(searchList(txtSearch.Text));
            txtQuantity.Focus();
        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                addProductBindingSource(searchList(txtSearch.Text));            
                txtQuantity.Focus();
            }
        }

        #endregion
   
    }
    
}
