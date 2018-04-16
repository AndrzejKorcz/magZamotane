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
using System.IO;
using MagZamotane4.Services;

namespace MagZamotane4
{
    public partial class ucBackup : MetroFramework.Controls.MetroUserControl
    {
        public ucBackup()
        {
            InitializeComponent();
            this.StyleManager = frmDashboard.Instance.StyleManager;
        }

        public void setDefaultValues() {
            txtLog.Clear();
            progressBar.Value = 0;
         }

        private void btnFolder_Click(object sender, EventArgs e)
        {
            //FolderBrowserDialog fld = new FolderBrowserDialog();
            //fld.Description = "Select your path.";
            //if(fld.ShowDialog() == DialogResult.OK)
            //{
            //    txtFolder.Text = fld.SelectedPath;
            //}
        }

        private void btnFile_Click(object sender, EventArgs e)
        {
            //using(OpenFileDialog ofd=new OpenFileDialog() { Filter="All files|*.*", ValidateNames=true, Multiselect=false })
            //{
            //    if (ofd.ShowDialog() == DialogResult.OK) txtFile.Text = ofd.FileName;
            //}
        }

        private void btnZipFolder_Click(object sender, EventArgs e)
        {
            //if (string.IsNullOrEmpty(txtFolder.Text))
            //{
            //    MessageBox.Show("Please select your folder.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    txtFolder.Focus();
            //    return;
            //}
            //string path = txtFolder.Text;
            //Thread thread = new Thread(t =>
            //{
            //    using(Ionic.Zip.ZipFile zip=new Ionic.Zip.ZipFile() )
            //    {
            //        zip.AddDirectory(path);
            //        DirectoryInfo di = new DirectoryInfo(path);
            //        zip.SaveProgress += Zip_SaveProgress;
            //        zip.Save(string.Format("{0}{1}.zip", di.Parent.FullName, di.Name));
            //    }
            //})
            //{ IsBackground = true };
            //thread.Start();
        }

        private void Zip_SaveProgress(object sender, Ionic.Zip.SaveProgressEventArgs e)
        {
            //if (e.EventType == Ionic.Zip.ZipProgressEventType.Saving_BeforeWriteEntry)
            //{
            //    progressBar.Invoke(new MethodInvoker(delegate
            //    {
            //        progressBar.Maximum = e.EntriesTotal;
            //        progressBar.Value = e.EntriesSaved + 1;
            //        progressBar.Update();
            //    }));
            //}
        }

        private void btnZipFile_Click(object sender, EventArgs e)
        {
            //if (string.IsNullOrEmpty(txtFile.Text))
            //{
            //    MessageBox.Show("Please select your file.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    txtFile.Focus();
            //    return;
            //}
            //string fileName = txtFile.Text;
            //Thread thread = new Thread(t =>
            //{
            //    using (Ionic.Zip.ZipFile zip = new Ionic.Zip.ZipFile())
            //    {
            //        FileInfo fi = new FileInfo(fileName);
            //        zip.AddFile(fileName);

            //        DirectoryInfo di = new DirectoryInfo(fileName);
            //        zip.SaveProgress += Zip_SaveFileProgress;
            //        zip.Save(string.Format("{0}{1}.zip", di.Parent.FullName, di.Name));
            //    }
            //})
            //{ IsBackground = true };
            //thread.Start();
        }


        private void Zip_SaveFileProgress(object sender, Ionic.Zip.SaveProgressEventArgs e)
        {
            if (e.EventType == Ionic.Zip.ZipProgressEventType.Saving_Started)
            {
                txtLog.Invoke(new MethodInvoker(delegate
                {
                    txtLog.Text += string.Format("\r\n {0}{1}", "Tworzenie archiwum: ", e.ArchiveName);
                    txtLog.Update();
                }));        
            }
            else if (e.EventType == Ionic.Zip.ZipProgressEventType.Saving_BeforeWriteEntry)
            {
                txtLog.Invoke(new MethodInvoker(delegate
                {
                    txtLog.Text += "\r\n Zapis do archiwum: " + e.CurrentEntry.FileName + " (" + (e.EntriesSaved + 1) + "/" + e.EntriesTotal + ")";
                    txtLog.Text += string.Format("\r\n {0}{1}", "Nazwa pliku: ", e.CurrentEntry.FileName);
                    txtLog.Update();
                }));

                progressBar.Invoke(new MethodInvoker(delegate
                {
                    progressBar.Maximum = e.EntriesTotal;
                    progressBar.Value = (int)e.EntriesSaved + 1;
                    progressBar.Update();
                }));
            }
            else if (e.EventType == Ionic.Zip.ZipProgressEventType.Saving_EntryBytesRead)
            {
                progressBar.Invoke(new MethodInvoker(delegate
                {
                    progressBar.Maximum = 100;
                    progressBar.Value = (int)((e.BytesTransferred * 100) / e.TotalBytesToTransfer);
                    progressBar.Update();                                      
                }));
            }
            else if (e.EventType == Ionic.Zip.ZipProgressEventType.Saving_Completed)
            {
                txtLog.Invoke(new MethodInvoker(delegate
                {
                    txtLog.Text += string.Format("\r\n {0}{1}", "Koniec: ", e.ArchiveName);                   
                    txtLog.Update();
                }));
            }
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            string currentDirectory = Directory.GetCurrentDirectory();
            string databaseDirectory = currentDirectory + @"\db\";

            txtLog.Text = "Log zdarzeń.";

            ProductService.Disconnect();
            Thread.Sleep(100);

            Thread thread = new Thread(t =>
            {
                using (Ionic.Zip.ZipFile zip = new Ionic.Zip.ZipFile())
                {
                    foreach (string file in Directory.GetFiles(databaseDirectory))
                    {
                        
                        txtLog.Invoke(new MethodInvoker(delegate
                        {
                            txtLog.Text += string.Format("\r\n Plik bazy danych: {0}", file);
                            txtLog.Update();
                        }));
                        zip.AddFile(file, "");
                    }
                    //Path.GetFileName(file)
                    //FileInfo fi = new FileInfo(fileName_accdb);
           
                    zip.SaveProgress += Zip_SaveFileProgress;

                    try
                    {
                        zip.Save(string.Format("{0}/backup/DB_{1}.zip", currentDirectory, DateTime.Now.ToString("yyyyMMddHHmmss")));
                    }
                    catch (Exception ex)
                    {
                        txtLog.Invoke(new MethodInvoker(delegate
                        {
                            txtLog.Text += string.Format("\r\n Błąd: {0}", ex.Message);
                            txtLog.Update();
                        }));
                        MessageBox.Show(ex.Message);                     
                    }
                  
                }
            })
            { IsBackground = true };
            thread.Start();
        }

        private async void txtLog_Click(object sender, EventArgs e)
        {
            string logDirectory = Directory.GetCurrentDirectory() + @"\log\";
            string logName = String.Format("{0}_logBackup", DateTime.Now.ToString("yyyyMMddHHmmss"));

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
    }
}
