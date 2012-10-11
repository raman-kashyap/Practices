using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Spreadsheet;
using TestProject.Network.Excel;
using TestProject.Network.Helpers;
using TestProject.Network.Properties;

namespace TestProject.Network
{
    public partial class DatabaseListView2 : Form
    {
        private readonly BindingSource _serverBindingSource = new BindingSource();
        private readonly BindingSource _databaseBindingSource = new BindingSource();
        private ICellFactory _factory;
        const int Interval = 200;

        public DatabaseListView2()
        {
            InitializeComponent();
        }

        private void OnFormLoad(object sender, EventArgs e)
        {
            BindServers();
        }

        private void BindServers()
        {
            _serverBindingSource.DataSource = ServerCollection.GetAll();
            ddlServers.DisplayMember = "Name";
            ddlServers.DataSource = _serverBindingSource;
        }

        private void OnLoadButtonClick(object sender, EventArgs e)
        {
            uxProgressBar.Show();
            uxProgressBar.Minimum = 0;
            uxProgressBar.Maximum = 100;
            uxProgressBar.Value = 0;

            Increment(20);

            DatabaseGridView.Rows.Clear();
            try
            {
                var machine = new Machine((ServerInfo) ddlServers.SelectedItem);
                var databases = machine.GetDatabases();
                Increment(40);
                
                _databaseBindingSource.DataSource = databases;
                DatabaseGridView.AutoGenerateColumns = false;
                DatabaseGridView.DataSource = _databaseBindingSource;
                Increment(20);

                btnExportToExcel.Visible = databases.Any();
                Increment(20);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Resources.ErrorOccured);
            }
            finally
            {
                uxProgressBar.Hide();
                uxProgressBar.Value = 0;
            }
        }

        private void Increment(int step)
        {
            uxProgressBar.Increment(step);
            System.Threading.Thread.Sleep(Interval);
        }

        private void OnServerSelectionChanged(object sender, EventArgs e)
        {
            lblConnectionString.Text = new Machine((ServerInfo) ddlServers.SelectedItem).GetConnectionString();
        }

        private void OnAddNewServerClick(object sender, EventArgs e)
        {
            lblConnectionString.Visible = false;
            AddServerPanel.BringToFront();
        }

        private void OnSaveClick(object sender, EventArgs e)
        {
            try
            {
                if (chkSqlAuth.Checked)
                    ServerCollection.Add(new ServerInfo
                                             {
                                                 Name = txtServerName.Text,
                                                 Credential = new Credential
                                                 {
                                                     Username = txtUsername.Text,
                                                     Password = txtPassword.Text
                                                 }
                                             });
                else
                    ServerCollection.Add(txtServerName.Text);

                _serverBindingSource.DataSource = ServerCollection.GetAll();

                lblConnectionString.Visible = true;
                AddServerPanel.SendToBack();

                MessageBox.Show(string.Format("Server: {0} added successfully.", txtServerName.Text),
                                Resources.DataSavedCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Resources.ErrorOccured);
            }
        }

        private void OnCancelClick(object sender, EventArgs e)
        {
            lblConnectionString.Visible = true;
            AddServerPanel.SendToBack();
        }

        private void OnAuthModeChanged(object sender, EventArgs e)
        {
            AuthPanel.Enabled = chkSqlAuth.Checked;
        }

        private void DatabaseGridView_CellValueNeeded(object sender, DataGridViewCellValueEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == 0)
            {
                e.Value = e.RowIndex + 1;
            }
        }

        private void btnExportToExcel_Click(object sender, EventArgs e)
        {
            //Make a copy of the template file
            var filename =
                string.Format("{0}.xlsx", ((ServerInfo) ddlServers.SelectedItem).Name.ReplaceSpecialCharacters("_"));
            
            File.Copy("template.xlsx", filename, true);
            Write(filename);
            MessageBox.Show(Resources.ExportToExcelSuccessMessage, Resources.ExportToExcelCaption, MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
        }

        private void Write(string filename)
        {
            using (var spreadSheet = SpreadsheetDocument.Open(filename, true))
            {
                _factory = new CellFactory();

                var workbookPart = spreadSheet.WorkbookPart;
                var worksheetPart = workbookPart.WorksheetParts.First();
                
                var sheetData = worksheetPart.Worksheet.GetFirstChild<SheetData>();

                var startRowIndex = 2;
                foreach (DataGridViewRow dataRow in DatabaseGridView.Rows)
                {
                    var contentRow = CreateContentRow(dataRow, startRowIndex);

                    sheetData.AppendChild(contentRow);
                    startRowIndex++;
                }
            }
        }

        private readonly string[] _headerColumns = new[]
                                                       {
                                                           "A", "B", "C", "D", "E", "F"
                                                       };
        private Row CreateContentRow(DataGridViewRow dataRow, int startRowIndex)
        {
            var row = new Row { RowIndex = (UInt32)startRowIndex };

            for (var i = 0; i < _headerColumns.Length; i++)
            {
                var cell = _factory.Create(dataRow.Cells[i].Value);
                cell.CellReference = _headerColumns[i] + startRowIndex;
                
                row.AppendChild(cell);
            }
            
            return row;
        }
    }
}