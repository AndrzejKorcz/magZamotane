using MagZamotane4.Services;
using MagZamotane4.Core;
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
    public partial class frmSplashScreen : MetroFramework.Forms.MetroForm
    {
        public frmSplashScreen()
        { 
            InitializeComponent();
            this.StyleManager = frmDashboard.Instance.StyleManager;
            Shown += frmSplashScreen_Shown;
            Application.ApplicationExit += new EventHandler(Application_ApplicationExit);
        }

        private void frmSplashScreen_Shown(object sender, EventArgs e)
        {
            start(sender, e);
        }

        private Task ProcessData(IProgress<ProgressReport> progress)
        {
            int index = 1;
            int totalProcess = 3;
            var processReport = new ProgressReport();
            return Task.Run(() =>
            {
                processReport.PercentComplete = index++ * 100 / totalProcess;
                progress.Report(processReport);
                ProductService.Connect();


                processReport.PercentComplete = index++ * 100 / totalProcess;
                progress.Report(processReport);
                frmDashboard.Instance.Products = ProductService.GetAll();


                processReport.PercentComplete = index++ * 100 / totalProcess;
                progress.Report(processReport);
                Enumerator enumerator = new Enumerator { Identyfikator = 1, grupa = "A" };
                frmDashboard.Instance.Enumerator = EnumeratorService.GetNumber(enumerator);

            });
        }


        private async void start(object sender, EventArgs e)
        {
            lblInfo.Text = string.Format("Czas: {0} sekunda.", second.ToString());
            timer.Enabled = true;

            var progress = new Progress<ProgressReport>();
            progress.ProgressChanged += (o, report) =>
            {
                lblStatus.Text = string.Format("Przetwarzanie... {0}%", report.PercentComplete);
                metroProgressBar.Value = report.PercentComplete;
                metroProgressBar.Update();
            };
            await ProcessData(progress);

            lblStatus.Text = "Koniec !";

            timer.Enabled = false;

           this.Close();
        }

        private void Application_ApplicationExit(object sender, EventArgs e)
        {
            //metroProgressBar.Enabled = false;
            //Thread.Sleep(10);
        }

        private void frmSplashScreen_Load(object sender, EventArgs e)
        {
            //metroProgressBar.Enabled = true;
        }

        int second = 1;
        private void timer_Tick(object sender, EventArgs e)
        {
            second++;
            lblInfo.Text = string.Format("Czas: {0} sekunda.", second.ToString());
        }
    }
}
