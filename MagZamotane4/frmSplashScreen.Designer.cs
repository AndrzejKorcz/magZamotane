namespace MagZamotane4
{
    partial class frmSplashScreen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSplashScreen));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.metroProgressBar = new MetroFramework.Controls.MetroProgressBar();
            this.lblStatus = new MetroFramework.Controls.MetroLabel();
            this.lblInfo = new MetroFramework.Controls.MetroLabel();
            this.timer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(20, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(401, 198);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // metroProgressBar
            // 
            this.metroProgressBar.Enabled = false;
            this.metroProgressBar.Location = new System.Drawing.Point(37, 184);
            this.metroProgressBar.MarqueeAnimationSpeed = 10;
            this.metroProgressBar.Name = "metroProgressBar";
            this.metroProgressBar.ProgressBarStyle = System.Windows.Forms.ProgressBarStyle.Blocks;
            this.metroProgressBar.Size = new System.Drawing.Size(365, 20);
            this.metroProgressBar.Step = 1;
            this.metroProgressBar.Style = MetroFramework.MetroColorStyle.Silver;
            this.metroProgressBar.TabIndex = 2;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(20, 8);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(121, 19);
            this.lblStatus.TabIndex = 3;
            this.lblStatus.Text = "Przetwarzanie... 0%";
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Location = new System.Drawing.Point(316, 8);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(104, 19);
            this.lblInfo.TabIndex = 3;
            this.lblInfo.Text = "Czas: 0 sekunda.";
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // frmSplashScreen
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(441, 248);
            this.ControlBox = false;
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.metroProgressBar);
            this.Controls.Add(this.pictureBox1);
            this.DisplayHeader = false;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Movable = false;
            this.Name = "frmSplashScreen";
            this.Padding = new System.Windows.Forms.Padding(20, 30, 20, 20);
            this.Resizable = false;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Style = MetroFramework.MetroColorStyle.Default;
            this.Load += new System.EventHandler(this.frmSplashScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroProgressBar metroProgressBar;
        private MetroFramework.Controls.MetroLabel lblStatus;
        private MetroFramework.Controls.MetroLabel lblInfo;
        private System.Windows.Forms.Timer timer;
    }
}