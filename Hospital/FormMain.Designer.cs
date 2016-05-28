namespace Hospital
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.menu = new System.Windows.Forms.MenuStrip();
            this.menuServer = new System.Windows.Forms.ToolStripMenuItem();
            this.menuServerConnect = new System.Windows.Forms.ToolStripMenuItem();
            this.menuServerDisconnect = new System.Windows.Forms.ToolStripMenuItem();
            this.menuData = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDataChange = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDataShow = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSecurity = new System.Windows.Forms.ToolStripMenuItem();
            this.menuReports = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.status = new System.Windows.Forms.StatusStrip();
            this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.menu.SuspendLayout();
            this.status.SuspendLayout();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.BackColor = System.Drawing.Color.White;
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuServer,
            this.menuData,
            this.menuSecurity,
            this.menuReports,
            this.menuAbout});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(636, 24);
            this.menu.TabIndex = 1;
            this.menu.Text = "menu";
            // 
            // menuServer
            // 
            this.menuServer.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuServerConnect,
            this.menuServerDisconnect});
            this.menuServer.Name = "menuServer";
            this.menuServer.Size = new System.Drawing.Size(59, 20);
            this.menuServer.Text = "Сервер";
            // 
            // menuServerConnect
            // 
            this.menuServerConnect.Name = "menuServerConnect";
            this.menuServerConnect.Size = new System.Drawing.Size(156, 22);
            this.menuServerConnect.Text = "Подключиться";
            this.menuServerConnect.Click += new System.EventHandler(this.menuServerConnect_Click);
            // 
            // menuServerDisconnect
            // 
            this.menuServerDisconnect.Enabled = false;
            this.menuServerDisconnect.Name = "menuServerDisconnect";
            this.menuServerDisconnect.Size = new System.Drawing.Size(156, 22);
            this.menuServerDisconnect.Text = "Отключиться";
            this.menuServerDisconnect.Click += new System.EventHandler(this.menuServerDisconnect_Click);
            // 
            // menuData
            // 
            this.menuData.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuDataChange,
            this.menuDataShow});
            this.menuData.Name = "menuData";
            this.menuData.Size = new System.Drawing.Size(62, 20);
            this.menuData.Text = "Данные";
            this.menuData.Visible = false;
            // 
            // menuDataChange
            // 
            this.menuDataChange.Name = "menuDataChange";
            this.menuDataChange.Size = new System.Drawing.Size(179, 22);
            this.menuDataChange.Text = "Изменение данных";
            this.menuDataChange.Click += new System.EventHandler(this.menuDataChange_Click);
            // 
            // menuDataShow
            // 
            this.menuDataShow.Name = "menuDataShow";
            this.menuDataShow.Size = new System.Drawing.Size(179, 22);
            this.menuDataShow.Text = "Просмотр данных";
            this.menuDataShow.Click += new System.EventHandler(this.menuDataShow_Click);
            // 
            // menuSecurity
            // 
            this.menuSecurity.Name = "menuSecurity";
            this.menuSecurity.Size = new System.Drawing.Size(94, 20);
            this.menuSecurity.Text = "Безопасность";
            this.menuSecurity.Visible = false;
            this.menuSecurity.Click += new System.EventHandler(this.menuSecurity_Click);
            // 
            // menuReports
            // 
            this.menuReports.Name = "menuReports";
            this.menuReports.Size = new System.Drawing.Size(60, 20);
            this.menuReports.Text = "Отчеты";
            this.menuReports.Visible = false;
            this.menuReports.Click += new System.EventHandler(this.menuReports_Click);
            // 
            // menuAbout
            // 
            this.menuAbout.Name = "menuAbout";
            this.menuAbout.Size = new System.Drawing.Size(94, 20);
            this.menuAbout.Text = "О программе";
            this.menuAbout.Click += new System.EventHandler(this.menuAbout_Click);
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // status
            // 
            this.status.BackColor = System.Drawing.Color.White;
            this.status.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatus});
            this.status.Location = new System.Drawing.Point(0, 258);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(636, 22);
            this.status.TabIndex = 3;
            this.status.Text = "status";
            // 
            // lblStatus
            // 
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(590, 17);
            this.lblStatus.Spring = true;
            this.lblStatus.Tag = "Подключение отсутствует";
            this.lblStatus.Text = "Подключение отсутствует";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 280);
            this.Controls.Add(this.status);
            this.Controls.Add(this.menu);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menu;
            this.MinimumSize = new System.Drawing.Size(400, 200);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Программная система \"Ведение карточек пациентов в больнице\"";
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.status.ResumeLayout(false);
            this.status.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem menuServer;
        private System.Windows.Forms.ToolStripMenuItem menuServerConnect;
        private System.Windows.Forms.ToolStripMenuItem menuServerDisconnect;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.ToolStripMenuItem menuReports;
        private System.Windows.Forms.ToolStripMenuItem menuData;
        private System.Windows.Forms.ToolStripMenuItem menuDataChange;
        private System.Windows.Forms.ToolStripMenuItem menuDataShow;
        private System.Windows.Forms.ToolStripMenuItem menuSecurity;
        private System.Windows.Forms.ToolStripMenuItem menuAbout;
        private System.Windows.Forms.StatusStrip status;
        private System.Windows.Forms.ToolStripStatusLabel lblStatus;
    }
}