using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Configuration;
using MagZamotane4.Services;

namespace MagZamotane4
{
    public partial class ucDashboard : MetroFramework.Controls.MetroUserControl
    {
        public ucDashboard()
        {
            InitializeComponent();
            this.StyleManager = frmDashboard.Instance.StyleManager;
        }

        private void mtProduct_Click(object sender, EventArgs e)
        {
            if (!frmDashboard.Instance.MetroContainer.Controls.ContainsKey("ucProduct"))
            {
                ucProduct uc = new ucProduct();
                uc.setAllProduct(frmDashboard.Instance.Products, true);
                uc.Dock = DockStyle.Fill;
                frmDashboard.Instance.MetroContainer.Controls.Add(uc);            
            } else
            {
                if (frmDashboard.Instance.refreshData)
                {
                    ucProduct uc = (frmDashboard.Instance.MetroContainer.Controls["ucProduct"]) as ucProduct;
                    uc.setAllProduct(frmDashboard.Instance.Products, false);                
                }
            }
            frmDashboard.Instance.refreshData = false;
            frmDashboard.Instance.MetroContainer.Controls["ucProduct"].BringToFront();
            frmDashboard.Instance.MetroBack.Visible = true;
            frmDashboard.Instance.setPage("ucDashboard");
           
        }

        private void mtBackupDB_Click(object sender, EventArgs e)
        {
            if (!frmDashboard.Instance.MetroContainer.Controls.ContainsKey("ucBackup"))
            {
                ucBackup uc = new ucBackup();
                uc.Dock = DockStyle.Fill;
                frmDashboard.Instance.MetroContainer.Controls.Add(uc);
            }
            else
            {
                ucBackup uc = (frmDashboard.Instance.MetroContainer.Controls["ucBackup"]) as ucBackup;
                uc.setDefaultValues();
            }

            frmDashboard.Instance.MetroContainer.Controls["ucBackup"].BringToFront();
            frmDashboard.Instance.MetroBack.Visible = true;
            frmDashboard.Instance.setPage("ucDashboard");
        }

        private void mtSale_Click(object sender, EventArgs e)
        {
            ucSale uc;
            if (!frmDashboard.Instance.MetroContainer.Controls.ContainsKey("ucSale"))
            {
                uc = new ucSale();
                uc.Dock = DockStyle.Fill;
                frmDashboard.Instance.MetroContainer.Controls.Add(uc);
            }
            else
            {
                uc = (frmDashboard.Instance.MetroContainer.Controls["ucSale"]) as ucSale;
            }
            uc.setAllProduct(frmDashboard.Instance.Products);
            frmDashboard.Instance.MetroContainer.Controls["ucSale"].BringToFront();
            frmDashboard.Instance.MetroBack.Visible = true;
            frmDashboard.Instance.refreshData = true;
            frmDashboard.Instance.setPage("ucDashboard");
        }

        private void mtWebBrowser_Click(object sender, EventArgs e)
        {
            if (!frmDashboard.Instance.MetroContainer.Controls.ContainsKey("ucWebBrowser"))
            {
                ucWebBrowser uc = new ucWebBrowser();
                uc.Dock = DockStyle.Fill;
                frmDashboard.Instance.MetroContainer.Controls.Add(uc);
            }
            frmDashboard.Instance.MetroContainer.Controls["ucWebBrowser"].BringToFront();
            frmDashboard.Instance.MetroBack.Visible = true;
            frmDashboard.Instance.setPage("ucDashboard");
        }

        private void mtBarCodes_Click(object sender, EventArgs e)
        {
            if (!frmDashboard.Instance.MetroContainer.Controls.ContainsKey("ucBarCode"))
            {
                ucBarCode uc = new ucBarCode();
                uc.Dock = DockStyle.Fill;
                frmDashboard.Instance.MetroContainer.Controls.Add(uc);
            }
            frmDashboard.Instance.MetroContainer.Controls["ucBarCode"].BringToFront();
            frmDashboard.Instance.MetroBack.Visible = true;
            frmDashboard.Instance.setPage("ucDashboard");
        }

        private void checkStocktaking()
        {
            var stockTaking = frmDashboard.Instance.stockTaking;           
            var newMode = !stockTaking ? "Rozpocznij" : "Zakończ";
            String text = String.Format("{0} inwenturę", newMode);
            mtStocktaking.Text = text;
            mtStocktaking.BackColor = stockTaking ? Color.Firebrick : Color.ForestGreen;
            mtStocktaking.Refresh();
        }

        private void AddUpdateAppSettings(string key, string value)
        {
            try
            {
                var configFile = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                var settings = configFile.AppSettings.Settings;
                if (settings[key] == null)
                {
                    settings.Add(key, value);
                }
                else
                {
                    settings[key].Value = value;
                }
                configFile.Save(ConfigurationSaveMode.Modified);
                ConfigurationManager.RefreshSection(configFile.AppSettings.SectionInformation.Name);
            }
            catch (ConfigurationErrorsException ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Komunikat błędu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
  

        private void mtStocktaking_Click(object sender, EventArgs e)
        {
            var newStockTaking = !frmDashboard.Instance.stockTaking;
            var newMode = newStockTaking ? "rozpocząć" : "zakończyć";
            String question = String.Format("Czy na pewno chcesz {0} inwentaryzację? Potwierdzenie spowoduje restart programu.",
                         newMode);

            if (MetroFramework.MetroMessageBox.Show(this, question, "Konieczne potwierdzenie", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if(newStockTaking)
                {
                    var result = ProductService.ClearStocktaking();
                    if (result) 
                    MetroFramework.MetroMessageBox.Show(this, "Weryfikacja towarów w ramach inwentaryzacji została wyzerowana. Oznacza to, że wszystkie inwentaryzowane towary będzie trzeba sprawdzić od nowa.", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                AddUpdateAppSettings("Stocktaking", newStockTaking.ToString());

                Application.Restart();
                Environment.Exit(0);



                //frmDashboard.Instance.stockTaking = newStockTaking;
                //checkStocktaking();
            }
        }

      

        private void ucDashboard_Load(object sender, EventArgs e)
        {
           checkStocktaking();
        }
    }
}
