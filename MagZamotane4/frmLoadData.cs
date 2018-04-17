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
        }

        public void CloseSplash()
        {
            Invoke((MethodInvoker)delegate
            {
                this.Close();
            });
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (metroProgressSpinner.Value < 100)
            {
                metroProgressSpinner.Value += 1;
            }
            else
            {
                while (metroProgressSpinner.Value > 0)
                {
                    metroProgressSpinner.Value -= 1;
                    Thread.Sleep(3);
                }           
            }
                
        }

        private void frmLoadData_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            metroProgressSpinner.Spinning = true;
        }

        private void frmLoadData_FormClosing(object sender, FormClosingEventArgs e)
        {
            timer1.Enabled = false;
            metroProgressSpinner.Spinning = false;
            Thread.Sleep(10);
        }
    }
}
