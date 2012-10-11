using System;
using System.Windows.Forms;
using TestProject.Network.Properties;

namespace TestProject.Network
{
    public partial class DatabaseListView : Form
    {
        private readonly BindingSource _serverBindingSource = new BindingSource();
        private readonly BindingSource _databaseBindingSource = new BindingSource();
        public DatabaseListView()
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
            ServersCombo.DisplayMember = "Name";
            ServersCombo.DataSource = _serverBindingSource;
        }

        private void OnLoadButtonClick(object sender, EventArgs e)
        {
            progressBar1.Value = 0;
            progressBar1.Show();
            DatabaseGrid.Rows.Clear();
            try
            {
                Machine machine;
                progressBar1.Increment(20);
                machine = ServersCombo.SelectedItem == null
                              ? new Machine(new ServerInfo
                                                {
                                                    Name = ServersCombo.Text,
                                                    Credential = new Credential
                                                    {
                                                        Username = txtUsername.Text,
                                                        Password = txtPassword.Text
                                                    }
                                                })
                              : new Machine((ServerInfo)ServersCombo.SelectedItem);
                progressBar1.Increment(20);
                _databaseBindingSource.DataSource = machine.GetDatabases();
                progressBar1.Increment(20);
                DatabaseGrid.AutoGenerateColumns = false;
                progressBar1.Increment(20);
                DatabaseGrid.DataSource = _databaseBindingSource;
                progressBar1.Increment(20);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Resources.ErrorOccured);
            }
            finally
            {
                progressBar1.Visible = false;
            }
        }

        private void OnAddNewButtonClick(object sender, EventArgs e)
        {
            try
            {
                if (AuthRequired.Checked)
                    ServerCollection.Add(new ServerInfo
                                             {
                                                 Name = ServersCombo.Text,
                                                 Credential = new Credential
                                                 {
                                                     Username = txtUsername.Text,
                                                     Password = txtPassword.Text
                                                 }
                                             });
                else
                    ServerCollection.Add(ServersCombo.Text);

                _serverBindingSource.DataSource = ServerCollection.GetAll();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, Resources.ErrorOccured);
            }
        }

        private void OnAuthRequiredCheckedChanged(object sender, EventArgs e)
        {
            SQLAuthGroup.Enabled = AuthRequired.Checked;
        }
    }
}
