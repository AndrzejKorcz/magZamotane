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
                uc.setAllProduct(frmDashboard.Instance.Products);
                uc.Dock = DockStyle.Fill;
                frmDashboard.Instance.MetroContainer.Controls.Add(uc);            
            } else
            {
                if (frmDashboard.Instance.refreshData)
                {
                    ucProduct uc = (frmDashboard.Instance.MetroContainer.Controls["ucProduct"]) as ucProduct;
                    uc.setAllProduct(frmDashboard.Instance.Products);                
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

        private void ucDashboard_VisibleChanged(object sender, EventArgs e)
        {
        }
    }
}
