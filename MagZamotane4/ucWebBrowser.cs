using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MagZamotane4
{
    public partial class ucWebBrowser : MetroFramework.Controls.MetroUserControl
    {
        public ucWebBrowser()
        {
            InitializeComponent();
            this.StyleManager = frmDashboard.Instance.StyleManager;
        }

        private void NewTab(string url)
        {
            TabPage tab = new TabPage();
            tab.Text = "nowa zakładka";
            metroTabControl.Controls.Add(tab);
            metroTabControl.SelectTab(metroTabControl.TabCount - 1);
            WebBrowser browser = new WebBrowser()
            {
                ScriptErrorsSuppressed = true
            };
            browser.Parent = tab;
            browser.Dock = DockStyle.Fill;
            browser.Navigate(url);
            txtUrl.Text = url;
            browser.DocumentCompleted += Browser_DocumentCompleted;
        }

        private void goUrl(string url)
        {
            WebBrowser browser = metroTabControl.SelectedTab.Controls[0] as WebBrowser;
            if (browser != null)
            {
                browser.Navigate(url);
            }
        }

        private void Browser_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            WebBrowser browser = metroTabControl.SelectedTab.Controls[0] as WebBrowser;
            if (browser != null) metroTabControl.SelectedTab.Text = browser.DocumentTitle;
        }

        private void lnkBack_Click(object sender, EventArgs e)
        {
            WebBrowser browser = metroTabControl.SelectedTab.Controls[0] as WebBrowser;
            if (browser != null)
            {
                if (browser.CanGoBack) browser.GoBack();
            }
        }

        private void lnkForward_Click(object sender, EventArgs e)
        {
            WebBrowser browser = metroTabControl.SelectedTab.Controls[0] as WebBrowser;
            if (browser != null)
            {
                if (browser.CanGoForward) browser.GoForward();
            }
        }

        private void btnNewTab_Click(object sender, EventArgs e)
        {
            NewTab("https://google.com");
        }

        private void ucWebBrowser_Load(object sender, EventArgs e)
        {
            NewTab("http://zamotane.pl/admin");
        }

        private void txtUrl_ButtonClick(object sender, EventArgs e)
        {
            goUrl(txtUrl.Text);
        }

        private void txtUrl_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                goUrl(txtUrl.Text);
            }
        }

    }
}
