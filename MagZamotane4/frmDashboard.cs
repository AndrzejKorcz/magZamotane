using MagZamotane4.Core;
using MagZamotane4.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MagZamotane4
{
    public partial class frmDashboard : MetroFramework.Forms.MetroForm
    {
        #region comunication interface

        static frmDashboard _instance;

        public static frmDashboard Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new frmDashboard();
                return _instance;
            }
        }

        public MetroFramework.Controls.MetroPanel MetroContainer
        {
            get { return panel; }
            set { panel = value; }
        }

        public MetroFramework.Controls.MetroLink MetroBack
        {
            get { return lblBack; }
            set { lblBack = value; }
        }

        public List<Product> Products { get; set;  }

        public bool refreshData { get; set; }

        public List<Enumerator> Enumerator { get; set; }

        private List<string> listPages = new List<string>();
        public void setPage(string value)
        {
                listPages.Add(value);
        }
        public string getPage()
        {
            string page = listPages[listPages.Count-1];
            listPages.Remove(listPages.Last());
            return page;
        }

        #endregion

        public frmDashboard()
        {
            Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("pl");
            InitializeComponent();
            this.StyleManager = metroStyleManager;
            metroStyleManager.Theme = MetroFramework.MetroThemeStyle.Light;
            metroStyleManager.Style = MetroFramework.MetroColorStyle.Silver;
        }

        private void getAllProducts()
        {
            frmSplashScreen frm = new frmSplashScreen();
            frm.ShowDialog();
        }

        private void frmDashboard_Load(object sender, EventArgs e)
        {
            _instance = this;
            lblBack.Visible = false;

            getAllProducts();
                 
            ucDashboard uc = new ucDashboard();
            uc.Dock = DockStyle.Fill;
            panel.Controls.Add(uc);
        }

        private void lblBack_Click(object sender, EventArgs e)
        {
            string lastPage = getPage();
            if (!string.IsNullOrEmpty(lastPage))
            {
                panel.Controls[lastPage].BringToFront();
                lblBack.Visible = !(lastPage == "ucDashboard");
            }   
        }

        private void pokarzToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Show();
        }

        private void zakończToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmDashboard_Move(object sender, EventArgs e)
        {
            //if (this.WindowState == FormWindowState.Minimized)
            //{
            //    this.Hide();
            //    notifyIcon.ShowBalloonTip(1000, "Ważna informacja", "Program został zminimalizowany do kontenera z ukrytymi ikonami.", ToolTipIcon.Info);
            //}
        }

        private void notifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Show();
        }
    }
}
