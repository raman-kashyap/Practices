namespace TestProject.Network
{
    partial class DatabaseListView
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
            this.DatabaseGrid = new System.Windows.Forms.DataGridView();
            this.DatabaseName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DefaultSchema = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Size = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastBackupDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastLogBackupDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ServersCombo = new System.Windows.Forms.ComboBox();
            this.LoadButton = new System.Windows.Forms.Button();
            this.AddNewButton = new System.Windows.Forms.Button();
            this.AuthRequired = new System.Windows.Forms.CheckBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.SQLAuthGroup = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.DatabaseGrid)).BeginInit();
            this.SQLAuthGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // DatabaseGrid
            // 
            this.DatabaseGrid.AllowUserToAddRows = false;
            this.DatabaseGrid.AllowUserToDeleteRows = false;
            this.DatabaseGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DatabaseGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DatabaseName,
            this.DefaultSchema,
            this.Size,
            this.LastBackupDate,
            this.LastLogBackupDate});
            this.DatabaseGrid.Location = new System.Drawing.Point(0, 109);
            this.DatabaseGrid.Name = "DatabaseGrid";
            this.DatabaseGrid.ReadOnly = true;
            this.DatabaseGrid.Size = new System.Drawing.Size(659, 510);
            this.DatabaseGrid.TabIndex = 0;
            // 
            // DatabaseName
            // 
            this.DatabaseName.DataPropertyName = "Name";
            this.DatabaseName.HeaderText = "Name";
            this.DatabaseName.Name = "DatabaseName";
            this.DatabaseName.ReadOnly = true;
            // 
            // DefaultSchema
            // 
            this.DefaultSchema.DataPropertyName = "DefaultSchema";
            this.DefaultSchema.HeaderText = "Schema";
            this.DefaultSchema.Name = "DefaultSchema";
            this.DefaultSchema.ReadOnly = true;
            // 
            // Size
            // 
            this.Size.DataPropertyName = "Size";
            this.Size.HeaderText = "Size";
            this.Size.Name = "Size";
            this.Size.ReadOnly = true;
            this.Size.Width = 50;
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
            // ServersCombo
            // 
            this.ServersCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ServersCombo.FormattingEnabled = true;
            this.ServersCombo.Location = new System.Drawing.Point(4, 13);
            this.ServersCombo.Name = "ServersCombo";
            this.ServersCombo.Size = new System.Drawing.Size(233, 21);
            this.ServersCombo.TabIndex = 1;
            // 
            // LoadButton
            // 
            this.LoadButton.Location = new System.Drawing.Point(243, 13);
            this.LoadButton.Name = "LoadButton";
            this.LoadButton.Size = new System.Drawing.Size(75, 23);
            this.LoadButton.TabIndex = 2;
            this.LoadButton.Text = "Load";
            this.LoadButton.UseVisualStyleBackColor = true;
            this.LoadButton.Click += new System.EventHandler(this.OnLoadButtonClick);
            // 
            // AddNewButton
            // 
            this.AddNewButton.Location = new System.Drawing.Point(324, 13);
            this.AddNewButton.Name = "AddNewButton";
            this.AddNewButton.Size = new System.Drawing.Size(75, 23);
            this.AddNewButton.TabIndex = 3;
            this.AddNewButton.Text = "Add New";
            this.AddNewButton.UseVisualStyleBackColor = true;
            this.AddNewButton.Click += new System.EventHandler(this.OnAddNewButtonClick);
            // 
            // AuthRequired
            // 
            this.AuthRequired.AutoSize = true;
            this.AuthRequired.Location = new System.Drawing.Point(405, 17);
            this.AuthRequired.Name = "AuthRequired";
            this.AuthRequired.Size = new System.Drawing.Size(118, 17);
            this.AuthRequired.TabIndex = 4;
            this.AuthRequired.Text = "SQL Authentication";
            this.AuthRequired.UseVisualStyleBackColor = true;
            this.AuthRequired.CheckedChanged += new System.EventHandler(this.OnAuthRequiredCheckedChanged);
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(68, 31);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(113, 20);
            this.txtUsername.TabIndex = 5;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(246, 31);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(114, 20);
            this.txtPassword.TabIndex = 6;
            // 
            // SQLAuthGroup
            // 
            this.SQLAuthGroup.Controls.Add(this.label2);
            this.SQLAuthGroup.Controls.Add(this.label1);
            this.SQLAuthGroup.Controls.Add(this.txtUsername);
            this.SQLAuthGroup.Controls.Add(this.txtPassword);
            this.SQLAuthGroup.Enabled = false;
            this.SQLAuthGroup.Location = new System.Drawing.Point(4, 41);
            this.SQLAuthGroup.Name = "SQLAuthGroup";
            this.SQLAuthGroup.Size = new System.Drawing.Size(519, 62);
            this.SQLAuthGroup.TabIndex = 7;
            this.SQLAuthGroup.TabStop = false;
            this.SQLAuthGroup.Text = "SQL Server Authentication";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(187, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Username";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(170, 269);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(194, 23);
            this.progressBar1.TabIndex = 8;
            this.progressBar1.Visible = false;
            // 
            // DatabaseListView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 619);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.SQLAuthGroup);
            this.Controls.Add(this.AuthRequired);
            this.Controls.Add(this.AddNewButton);
            this.Controls.Add(this.LoadButton);
            this.Controls.Add(this.ServersCombo);
            this.Controls.Add(this.DatabaseGrid);
            this.Name = "DatabaseListView";
            this.Text = "Database List";
            this.Load += new System.EventHandler(this.OnFormLoad);
            ((System.ComponentModel.ISupportInitialize)(this.DatabaseGrid)).EndInit();
            this.SQLAuthGroup.ResumeLayout(false);
            this.SQLAuthGroup.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DatabaseGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn DatabaseSize;
        private System.Windows.Forms.ComboBox ServersCombo;
        private System.Windows.Forms.Button LoadButton;
        private System.Windows.Forms.Button AddNewButton;
        private System.Windows.Forms.CheckBox AuthRequired;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.GroupBox SQLAuthGroup;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn DatabaseName;
        private System.Windows.Forms.DataGridViewTextBoxColumn DefaultSchema;
        private System.Windows.Forms.DataGridViewTextBoxColumn Size;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastBackupDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastLogBackupDate;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}

