using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MagZamotane4
{
    public partial class frmWait : MetroFramework.Forms.MetroForm
    {
        public Action Worker { get; set; }
        public string Info { get; set; }

        public frmWait(Action worker)
        {
            InitializeComponent();
            if (worker == null)
                throw new ArgumentNullException();
            Worker = worker;                
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            Task.Factory.StartNew(Worker).ContinueWith(t => { this.Close(); }, TaskScheduler.FromCurrentSynchronizationContext());
        }

        private void frmWait_Load(object sender, EventArgs e)
        {
            lblInfo.Text = Info;
        }

        private void frmWait_FormClosing(object sender, FormClosingEventArgs e)
        {
            timer1.Enabled = false;
        }

        private void frmWait_Shown(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (metroProgressSpinner.Value < 100)
            {
                metroProgressSpinner.Value += 1;
            }
            else metroProgressSpinner.Value = 0;
        }
    }
}
