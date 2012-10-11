namespace TestProject.Network
{
    partial class DatabaseListView2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DatabaseListView2));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ListPanel = new System.Windows.Forms.Panel();
            this.btnExportToExcel = new System.Windows.Forms.Button();
            this.uxProgressBar = new System.Windows.Forms.ProgressBar();
            this.lblConnectionString = new System.Windows.Forms.Label();
            this.btnAddNewServer = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.ddlServers = new System.Windows.Forms.ComboBox();
            this.DatabaseGridView = new System.Windows.Forms.DataGridView();
            this.AddServerPanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.AuthPanel = new System.Windows.Forms.Panel();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.chkSqlAuth = new System.Windows.Forms.CheckBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtServerName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SerialNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Instance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DatabaseName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Size = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastBackupDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastLogBackupDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ListPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DatabaseGridView)).BeginInit();
            this.AddServerPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.AuthPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // ListPanel
            // 
            this.ListPanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ListPanel.Controls.Add(this.btnExportToExcel);
            this.ListPanel.Controls.Add(this.uxProgressBar);
            this.ListPanel.Controls.Add(this.lblConnectionString);
            this.ListPanel.Controls.Add(this.btnAddNewServer);
            this.ListPanel.Controls.Add(this.btnLoad);
            this.ListPanel.Controls.Add(this.ddlServers);
            this.ListPanel.Controls.Add(this.DatabaseGridView);
            this.ListPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListPanel.Location = new System.Drawing.Point(0, 0);
            this.ListPanel.Name = "ListPanel";
            this.ListPanel.Size = new System.Drawing.Size(659, 623);
            this.ListPanel.TabIndex = 0;
            // 
            // btnExportToExcel
            // 
            this.btnExportToExcel.Image = ((System.Drawing.Image)(resources.GetObject("btnExportToExcel.Image")));
            this.btnExportToExcel.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnExportToExcel.Location = new System.Drawing.Point(533, 595);
            this.btnExportToExcel.Name = "btnExportToExcel";
            this.btnExportToExcel.Size = new System.Drawing.Size(114, 23);
            this.btnExportToExcel.TabIndex = 6;
            this.btnExportToExcel.Text = "Export to Excel";
            this.btnExportToExcel.UseVisualStyleBackColor = true;
            this.btnExportToExcel.Visible = false;
            this.btnExportToExcel.Click += new System.EventHandler(this.btnExportToExcel_Click);
            // 
            // uxProgressBar
            // 
            this.uxProgressBar.Location = new System.Drawing.Point(250, 163);
            this.uxProgressBar.Name = "uxProgressBar";
            this.uxProgressBar.Size = new System.Drawing.Size(159, 23);
            this.uxProgressBar.TabIndex = 5;
            this.uxProgressBar.Visible = false;
            // 
            // lblConnectionString
            // 
            this.lblConnectionString.AutoSize = true;
            this.lblConnectionString.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConnectionString.ForeColor = System.Drawing.Color.Black;
            this.lblConnectionString.Location = new System.Drawing.Point(12, 36);
            this.lblConnectionString.Name = "lblConnectionString";
            this.lblConnectionString.Size = new System.Drawing.Size(0, 20);
            this.lblConnectionString.TabIndex = 3;
            // 
            // btnAddNewServer
            // 
            this.btnAddNewServer.Location = new System.Drawing.Point(350, 12);
            this.btnAddNewServer.Name = "btnAddNewServer";
            this.btnAddNewServer.Size = new System.Drawing.Size(104, 23);
            this.btnAddNewServer.TabIndex = 4;
            this.btnAddNewServer.Text = "Add New Server";
            this.btnAddNewServer.UseVisualStyleBackColor = true;
            this.btnAddNewServer.Click += new System.EventHandler(this.OnAddNewServerClick);
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(269, 12);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(75, 23);
            this.btnLoad.TabIndex = 1;
            this.btnLoad.Text = "Fetch";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.OnLoadButtonClick);
            // 
            // ddlServers
            // 
            this.ddlServers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlServers.FormattingEnabled = true;
            this.ddlServers.Location = new System.Drawing.Point(12, 12);
            this.ddlServers.Name = "ddlServers";
            this.ddlServers.Size = new System.Drawing.Size(251, 21);
            this.ddlServers.TabIndex = 0;
            this.ddlServers.SelectedIndexChanged += new System.EventHandler(this.OnServerSelectionChanged);
            // 
            // DatabaseGridView
            // 
            this.DatabaseGridView.AllowUserToAddRows = false;
            this.DatabaseGridView.AllowUserToDeleteRows = false;
            this.DatabaseGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DatabaseGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SerialNumber,
            this.Instance,
            this.DatabaseName,
            this.Size,
            this.LastBackupDate,
            this.LastLogBackupDate});
            this.DatabaseGridView.Location = new System.Drawing.Point(12, 59);
            this.DatabaseGridView.Name = "DatabaseGridView";
            this.DatabaseGridView.ReadOnly = true;
            this.DatabaseGridView.RowHeadersVisible = false;
            this.DatabaseGridView.Size = new System.Drawing.Size(635, 530);
            this.DatabaseGridView.TabIndex = 4;
            this.DatabaseGridView.VirtualMode = true;
            this.DatabaseGridView.CellValueNeeded += new System.Windows.Forms.DataGridViewCellValueEventHandler(this.DatabaseGridView_CellValueNeeded);
            // 
            // AddServerPanel
            // 
            this.AddServerPanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.AddServerPanel.Controls.Add(this.panel1);
            this.AddServerPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AddServerPanel.Location = new System.Drawing.Point(0, 0);
            this.AddServerPanel.Name = "AddServerPanel";
            this.AddServerPanel.Size = new System.Drawing.Size(659, 623);
            this.AddServerPanel.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.AuthPanel);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.chkSqlAuth);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.txtServerName);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 21);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(635, 234);
            this.panel1.TabIndex = 4;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(391, 147);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 16;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.OnCancelClick);
            // 
            // AuthPanel
            // 
            this.AuthPanel.Controls.Add(this.txtPassword);
            this.AuthPanel.Controls.Add(this.label3);
            this.AuthPanel.Controls.Add(this.label2);
            this.AuthPanel.Controls.Add(this.txtUsername);
            this.AuthPanel.Enabled = false;
            this.AuthPanel.Location = new System.Drawing.Point(162, 81);
            this.AuthPanel.Name = "AuthPanel";
            this.AuthPanel.Size = new System.Drawing.Size(358, 60);
            this.AuthPanel.TabIndex = 15;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(169, 35);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(182, 20);
            this.txtPassword.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Username:";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(169, 6);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(182, 20);
            this.txtUsername.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(182, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Sql Server Authentication";
            // 
            // chkSqlAuth
            // 
            this.chkSqlAuth.AutoSize = true;
            this.chkSqlAuth.Location = new System.Drawing.Point(331, 61);
            this.chkSqlAuth.Name = "chkSqlAuth";
            this.chkSqlAuth.Size = new System.Drawing.Size(15, 14);
            this.chkSqlAuth.TabIndex = 13;
            this.chkSqlAuth.UseVisualStyleBackColor = true;
            this.chkSqlAuth.CheckedChanged += new System.EventHandler(this.OnAuthModeChanged);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(331, 147);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(54, 23);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.OnSaveClick);
            // 
            // txtServerName
            // 
            this.txtServerName.Location = new System.Drawing.Point(331, 30);
            this.txtServerName.Name = "txtServerName";
            this.txtServerName.Size = new System.Drawing.Size(182, 20);
            this.txtServerName.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(182, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Server:";
            // 
            // SerialNumber
            // 
            this.SerialNumber.Frozen = true;
            this.SerialNumber.HeaderText = "";
            this.SerialNumber.Name = "SerialNumber";
            this.SerialNumber.ReadOnly = true;
            this.SerialNumber.Width = 41;
            // 
            // Instance
            // 
            this.Instance.DataPropertyName = "InstanceName";
            this.Instance.Frozen = true;
            this.Instance.HeaderText = "Instance";
            this.Instance.Name = "Instance";
            this.Instance.ReadOnly = true;
            // 
            // DatabaseName
            // 
            this.DatabaseName.DataPropertyName = "Name";
            this.DatabaseName.HeaderText = "Name";
            this.DatabaseName.Name = "DatabaseName";
            this.DatabaseName.ReadOnly = true;
            this.DatabaseName.Width = 130;
            // 
            // Size
            // 
            this.Size.DataPropertyName = "Size";
            dataGridViewCellStyle1.Format = "0 MB";
            this.Size.DefaultCellStyle = dataGridViewCellStyle1;
            this.Size.HeaderText = "Size";
            this.Size.Name = "Size";
            this.Size.ReadOnly = true;
            // 
            // LastBackupDate
            // 
            this.LastBackupDate.DataPropertyName = "LastBackupDate";
            this.LastBackupDate.HeaderText = "Last Backup Date";
            this.LastBackupDate.Name = "LastBackupDate";
            this.LastBackupDate.ReadOnly = true;
            this.LastBackupDate.Width = 120;
            // 
            // LastLogBackupDate
            // 
            this.LastLogBackupDate.DataPropertyName = "LastLogBackupDate";
            this.LastLogBackupDate.HeaderText = "Last Log Backup Date";
            this.LastLogBackupDate.Name = "LastLogBackupDate";
            this.LastLogBackupDate.ReadOnly = true;
            this.LastLogBackupDate.Width = 140;
            // 
            // DatabaseListView2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(659, 623);
            this.Controls.Add(this.ListPanel);
            this.Controls.Add(this.AddServerPanel);
            this.Name = "DatabaseListView2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Database List";
            this.Load += new System.EventHandler(this.OnFormLoad);
            this.ListPanel.ResumeLayout(false);
            this.ListPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DatabaseGridView)).EndInit();
            this.AddServerPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.AuthPanel.ResumeLayout(false);
            this.AuthPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridViewTextBoxColumn DatabaseSize;
        private System.Windows.Forms.Panel ListPanel;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.ComboBox ddlServers;
        private System.Windows.Forms.Label lblConnectionString;
        private System.Windows.Forms.Button btnAddNewServer;
        private System.Windows.Forms.Panel AddServerPanel;
        private System.Windows.Forms.DataGridView DatabaseGridView;
        private System.Windows.Forms.ProgressBar uxProgressBar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Panel AuthPanel;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox chkSqlAuth;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtServerName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnExportToExcel;
        private System.Windows.Forms.DataGridViewTextBoxColumn SerialNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn Instance;
        private System.Windows.Forms.DataGridViewTextBoxColumn DatabaseName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Size;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastBackupDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastLogBackupDate;
    }
}

