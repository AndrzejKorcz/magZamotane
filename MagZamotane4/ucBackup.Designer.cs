namespace MagZamotane4
{
    partial class ucBackup
    {
        /// <summary> 
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod wygenerowany przez Projektanta składników

        /// <summary> 
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować 
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucBackup));
            this.progressBar = new MetroFramework.Controls.MetroProgressBar();
            this.btnZipDb = new MetroFramework.Controls.MetroButton();
            this.picture = new System.Windows.Forms.PictureBox();
            this.txtLog = new MetroFramework.Controls.MetroTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).BeginInit();
            this.SuspendLayout();
            // 
            // progressBar
            // 
            this.progressBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar.HideProgressText = false;
            this.progressBar.Location = new System.Drawing.Point(44, 322);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(498, 27);
            this.progressBar.Step = 1;
            this.progressBar.TabIndex = 3;
            // 
            // btnZipDb
            // 
            this.btnZipDb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnZipDb.Location = new System.Drawing.Point(561, 322);
            this.btnZipDb.Name = "btnZipDb";
            this.btnZipDb.Size = new System.Drawing.Size(75, 27);
            this.btnZipDb.TabIndex = 4;
            this.btnZipDb.Text = "Uruchom";
            this.btnZipDb.UseSelectable = true;
            this.btnZipDb.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // picture
            // 
            this.picture.Image = ((System.Drawing.Image)(resources.GetObject("picture.Image")));
            this.picture.Location = new System.Drawing.Point(44, 45);
            this.picture.Name = "picture";
            this.picture.Size = new System.Drawing.Size(256, 256);
            this.picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picture.TabIndex = 5;
            this.picture.TabStop = false;
            // 
            // txtLog
            // 
            this.txtLog.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.txtLog.CustomButton.Image = null;
            this.txtLog.CustomButton.Location = new System.Drawing.Point(76, 2);
            this.txtLog.CustomButton.Name = "";
            this.txtLog.CustomButton.Size = new System.Drawing.Size(251, 251);
            this.txtLog.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtLog.CustomButton.TabIndex = 1;
            this.txtLog.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtLog.CustomButton.UseSelectable = true;
            this.txtLog.CustomButton.Visible = false;
            this.txtLog.Lines = new string[0];
            this.txtLog.Location = new System.Drawing.Point(306, 45);
            this.txtLog.MaxLength = 32767;
            this.txtLog.Multiline = true;
            this.txtLog.Name = "txtLog";
            this.txtLog.PasswordChar = '\0';
            this.txtLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtLog.SelectedText = "";
            this.txtLog.SelectionLength = 0;
            this.txtLog.SelectionStart = 0;
            this.txtLog.ShortcutsEnabled = true;
            this.txtLog.Size = new System.Drawing.Size(330, 256);
            this.txtLog.TabIndex = 8;
            this.txtLog.UseSelectable = true;
            this.txtLog.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtLog.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtLog.Click += new System.EventHandler(this.txtLog_Click);
            // 
            // ucBackup
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.txtLog);
            this.Controls.Add(this.picture);
            this.Controls.Add(this.btnZipDb);
            this.Controls.Add(this.progressBar);
            this.Name = "ucBackup";
            this.Size = new System.Drawing.Size(690, 476);
            ((System.ComponentModel.ISupportInitialize)(this.picture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroProgressBar progressBar;
        private MetroFramework.Controls.MetroButton btnZipDb;
        private System.Windows.Forms.PictureBox picture;
        private MetroFramework.Controls.MetroTextBox txtLog;
    }
}
