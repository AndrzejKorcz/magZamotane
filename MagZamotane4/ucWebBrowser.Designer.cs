namespace MagZamotane4
{
    partial class ucWebBrowser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucWebBrowser));
            this.metroTabControl = new MetroFramework.Controls.MetroTabControl();
            this.btnNewTab = new MetroFramework.Controls.MetroButton();
            this.txtUrl = new MetroFramework.Controls.MetroTextBox();
            this.lnkForward = new MetroFramework.Controls.MetroLink();
            this.lnkBack = new MetroFramework.Controls.MetroLink();
            this.SuspendLayout();
            // 
            // metroTabControl
            // 
            this.metroTabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroTabControl.Location = new System.Drawing.Point(14, 43);
            this.metroTabControl.Name = "metroTabControl";
            this.metroTabControl.Size = new System.Drawing.Size(662, 442);
            this.metroTabControl.TabIndex = 14;
            this.metroTabControl.UseSelectable = true;
            // 
            // btnNewTab
            // 
            this.btnNewTab.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNewTab.Location = new System.Drawing.Point(581, 12);
            this.btnNewTab.Name = "btnNewTab";
            this.btnNewTab.Size = new System.Drawing.Size(95, 26);
            this.btnNewTab.TabIndex = 13;
            this.btnNewTab.Text = "Nowa zakładka";
            this.btnNewTab.UseSelectable = true;
            this.btnNewTab.Click += new System.EventHandler(this.btnNewTab_Click);
            // 
            // txtUrl
            // 
            this.txtUrl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.txtUrl.CustomButton.Image = global::MagZamotane4.Properties.Resources.go_to;
            this.txtUrl.CustomButton.Location = new System.Drawing.Point(462, 1);
            this.txtUrl.CustomButton.Name = "";
            this.txtUrl.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtUrl.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtUrl.CustomButton.TabIndex = 1;
            this.txtUrl.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtUrl.CustomButton.UseSelectable = true;
            this.txtUrl.DisplayIcon = true;
            this.txtUrl.Lines = new string[0];
            this.txtUrl.Location = new System.Drawing.Point(79, 14);
            this.txtUrl.MaxLength = 32767;
            this.txtUrl.Name = "txtUrl";
            this.txtUrl.PasswordChar = '\0';
            this.txtUrl.PromptText = "Wpisz adres strony do której chcesz iść";
            this.txtUrl.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtUrl.SelectedText = "";
            this.txtUrl.SelectionLength = 0;
            this.txtUrl.SelectionStart = 0;
            this.txtUrl.ShortcutsEnabled = true;
            this.txtUrl.ShowButton = true;
            this.txtUrl.Size = new System.Drawing.Size(484, 23);
            this.txtUrl.TabIndex = 12;
            this.txtUrl.UseSelectable = true;
            this.txtUrl.WaterMark = "Wpisz adres strony do której chcesz iść";
            this.txtUrl.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtUrl.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtUrl.ButtonClick += new MetroFramework.Controls.MetroTextBox.ButClick(this.txtUrl_ButtonClick);
            this.txtUrl.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUrl_KeyPress);
            // 
            // lnkForward
            // 
            this.lnkForward.AutoSize = true;
            this.lnkForward.Image = ((System.Drawing.Image)(resources.GetObject("lnkForward.Image")));
            this.lnkForward.ImageSize = 22;
            this.lnkForward.Location = new System.Drawing.Point(41, 9);
            this.lnkForward.Name = "lnkForward";
            this.lnkForward.Size = new System.Drawing.Size(27, 34);
            this.lnkForward.TabIndex = 10;
            this.lnkForward.UseSelectable = true;
            this.lnkForward.Click += new System.EventHandler(this.lnkForward_Click);
            // 
            // lnkBack
            // 
            this.lnkBack.AutoSize = true;
            this.lnkBack.Image = ((System.Drawing.Image)(resources.GetObject("lnkBack.Image")));
            this.lnkBack.ImageSize = 22;
            this.lnkBack.Location = new System.Drawing.Point(10, 9);
            this.lnkBack.Name = "lnkBack";
            this.lnkBack.Size = new System.Drawing.Size(29, 34);
            this.lnkBack.TabIndex = 11;
            this.lnkBack.UseSelectable = true;
            this.lnkBack.Click += new System.EventHandler(this.lnkBack_Click);
            // 
            // ucWebBrowser
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.metroTabControl);
            this.Controls.Add(this.btnNewTab);
            this.Controls.Add(this.txtUrl);
            this.Controls.Add(this.lnkForward);
            this.Controls.Add(this.lnkBack);
            this.Name = "ucWebBrowser";
            this.Size = new System.Drawing.Size(687, 495);
            this.Load += new System.EventHandler(this.ucWebBrowser_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl metroTabControl;
        private MetroFramework.Controls.MetroButton btnNewTab;
        private MetroFramework.Controls.MetroTextBox txtUrl;
        private MetroFramework.Controls.MetroLink lnkForward;
        private MetroFramework.Controls.MetroLink lnkBack;
    }
}
