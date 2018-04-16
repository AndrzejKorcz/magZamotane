namespace MagZamotane4
{
    partial class frmWait
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.metroProgressSpinner = new MetroFramework.Controls.MetroProgressSpinner();
            this.lblInfo = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 16;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // metroProgressSpinner
            // 
            this.metroProgressSpinner.Location = new System.Drawing.Point(33, 22);
            this.metroProgressSpinner.Maximum = 100;
            this.metroProgressSpinner.Name = "metroProgressSpinner";
            this.metroProgressSpinner.Size = new System.Drawing.Size(134, 134);
            this.metroProgressSpinner.TabIndex = 1;
            this.metroProgressSpinner.UseSelectable = true;
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Location = new System.Drawing.Point(13, 171);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(40, 19);
            this.lblInfo.TabIndex = 2;
            this.lblInfo.Text = "Info...";
            // 
            // frmWait
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(191, 201);
            this.ControlBox = false;
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.metroProgressSpinner);
            this.DisplayHeader = false;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Movable = false;
            this.Name = "frmWait";
            this.Padding = new System.Windows.Forms.Padding(20, 30, 20, 20);
            this.Resizable = false;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmWait_FormClosing);
            this.Load += new System.EventHandler(this.frmWait_Load);
            this.Shown += new System.EventHandler(this.frmWait_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private MetroFramework.Controls.MetroProgressSpinner metroProgressSpinner;
        private MetroFramework.Controls.MetroLabel lblInfo;
    }
}