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
    public partial class frmLoadData : MetroFramework.Forms.MetroForm
    {
        public frmLoadData()
        {
            InitializeComponent();
            this.StyleManager = frmDashboard.Instance.StyleManager;
            Application.ApplicationExit += new EventHandler(Application_ApplicationExit);
        }

        private void Application_ApplicationExit(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            Thread.Sleep(10);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (metroProgressSpinner.Value < 100)
            {
                metroProgressSpinner.Value += 1;
            } else metroProgressSpinner.Value = 0;            
        }

        private void frmLoadData_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }
    }
}
