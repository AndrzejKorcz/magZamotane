namespace MagZamotane4
{
    partial class frmDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDashboard));
            this.metroStyleManager = new MetroFramework.Components.MetroStyleManager(this.components);
            this.lblBack = new MetroFramework.Controls.MetroLink();
            this.panel = new MetroFramework.Controls.MetroPanel();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.pokarzToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zakończToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager)).BeginInit();
            this.contextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroStyleManager
            // 
            this.metroStyleManager.Owner = null;
            // 
            // lblBack
            // 
            this.lblBack.Image = ((System.Drawing.Image)(resources.GetObject("lblBack.Image")));
            this.lblBack.ImageSize = 28;
            this.lblBack.Location = new System.Drawing.Point(10, 16);
            this.lblBack.Name = "lblBack";
            this.lblBack.Size = new System.Drawing.Size(32, 38);
            this.lblBack.TabIndex = 5;
            this.lblBack.UseSelectable = true;
            this.lblBack.Click += new System.EventHandler(this.lblBack_Click);
            // 
            // panel
            // 
            this.panel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel.HorizontalScrollbarBarColor = true;
            this.panel.HorizontalScrollbarHighlightOnWheel = false;
            this.panel.HorizontalScrollbarSize = 10;
            this.panel.Location = new System.Drawing.Point(6, 71);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(970, 539);
            this.panel.TabIndex = 4;
            this.panel.VerticalScrollbarBarColor = true;
            this.panel.VerticalScrollbarHighlightOnWheel = false;
            this.panel.VerticalScrollbarSize = 10;
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pokarzToolStripMenuItem,
            this.zakończToolStripMenuItem});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(168, 64);
            // 
            // pokarzToolStripMenuItem
            // 
            this.pokarzToolStripMenuItem.Name = "pokarzToolStripMenuItem";
            this.pokarzToolStripMenuItem.Size = new System.Drawing.Size(211, 30);
            this.pokarzToolStripMenuItem.Text = "Wyświetl";
            this.pokarzToolStripMenuItem.Click += new System.EventHandler(this.pokarzToolStripMenuItem_Click);
            // 
            // zakończToolStripMenuItem
            // 
            this.zakończToolStripMenuItem.Name = "zakończToolStripMenuItem";
            this.zakończToolStripMenuItem.Size = new System.Drawing.Size(211, 30);
            this.zakończToolStripMenuItem.Text = "Zakończ";
            this.zakończToolStripMenuItem.Click += new System.EventHandler(this.zakończToolStripMenuItem_Click);
            // 
            // notifyIcon
            // 
            this.notifyIcon.ContextMenuStrip = this.contextMenuStrip;
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "Ustawienia";
            //this.notifyIcon.DoubleClick += new System.EventHandler(this.notifyIcon_DoubleClick);
            this.notifyIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon_MouseDoubleClick);
            // 
            // frmDashboard
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(981, 629);
            this.Controls.Add(this.lblBack);
            this.Controls.Add(this.panel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmDashboard";
            this.Text = "    Magazyn Zamotane.pl";
            this.Load += new System.EventHandler(this.frmDashboard_Load);
            this.Move += new System.EventHandler(this.frmDashboard_Move);
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager)).EndInit();
            this.contextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Components.MetroStyleManager metroStyleManager;
        private MetroFramework.Controls.MetroLink lblBack;
        private MetroFramework.Controls.MetroPanel panel;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem pokarzToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zakończToolStripMenuItem;
        private System.Windows.Forms.NotifyIcon notifyIcon;
    }
}