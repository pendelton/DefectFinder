using System;
using System.Configuration;
using System.Windows.Forms;
using DefectFinder.DAL;

namespace DefectFinder
{
    public partial class MainForm : Form
    {
        // Private variables
        private TfsHttpClient _tfsHttpClient;

        // Properties
        public TfsHttpClient TfsHttpClient
        {
            get
            {
                if (_tfsHttpClient == null)
                {
                    _tfsHttpClient = new TfsHttpClient(ConfigurationManager.AppSettings[Constants.AppConfig.TfsServer],
                        ConfigurationManager.AppSettings[Constants.AppConfig.UsernameKey],
                        ConfigurationManager.AppSettings[Constants.AppConfig.PasswordKey],
                        ConfigurationManager.AppSettings[Constants.AppConfig.WebApiVersion]);

                    return _tfsHttpClient;
                }

                return _tfsHttpClient;
            }
        }

        // Public methods
        public MainForm()
        {
            InitializeComponent();

            textBox_Id.Enabled = false;
            textBox_Skip.Enabled = false;
            textBox_Top.Enabled = false;
            comboBox_ProjectState.Enabled = false;
        }

        /*
         * Private Events Methods 
         */

        private void button_SendRequest_Click(object sender, EventArgs e)
        {
            switch (comboBox_RequestType.SelectedItem.ToString())
            {
                case "Project":
                    RequestForProject();
                    break;
                case "Projects":
                    RequestForProjects();
                    break;
                case "Changeset":
                    RequestForChangeset();
                    break;
                case "Changesets":
                    RequestForChangesets();
                    break;
            }
        }

        private void comboBox_RequestType_SelectedValueChanged(object sender, EventArgs e)
        {
            switch (comboBox_RequestType.SelectedItem.ToString())
            {
                case "Project":
                    DecorateProjectFields();
                    break;
                case "Projects":
                    DecorateProjectsFields();
                    break;
                case "Changeset":
                    DecorateChangesetFields();
                    break;
                case "Changesets":
                    DecorateChangesetsFields();
                    break;
            }
        }

        private void DecorateChangesetsFields()
        {
            throw new NotImplementedException();
        }

        private void DecorateChangesetFields()
        {
            throw new NotImplementedException();
        }

        private void DecorateProjectsFields()
        {
            textBox_Id.Enabled = false;
            textBox_Skip.Enabled = true;
            textBox_Top.Enabled = true;
            comboBox_ProjectState.Enabled = true;
        }

        private void DecorateProjectFields()
        {
            textBox_Id.Enabled = true;
            textBox_Skip.Enabled = false;
            textBox_Top.Enabled = false;
            comboBox_ProjectState.Enabled = false;
        }

        private void button_clearConsole_Click(object sender, EventArgs e)
        {
            textBox_Console.Clear();
        }

        /*
         * Private Methods 
         */

        private async void RequestForChangesets()
        {
            throw new NotImplementedException();
        }

        private async void RequestForChangeset()
        {
            throw new NotImplementedException();
        }

        private async void RequestForProjects()
        {
            var projects = await TfsHttpClient.GetProjects(comboBox_ProjectState.SelectedItem.ToString(),
                        Convert.ToInt32(textBox_Top.Text), Convert.ToInt32(textBox_Skip.Text));

            foreach (var project in projects)
            {
                textBox_Console.Text += project + Environment.NewLine;
            }
        }

        private async void RequestForProject()
        {
            try
            {
                var projects = await TfsHttpClient.GetProject(textBox_Id.Text);
            }

            catch (Exception ex)
            {
                textBox_Console.Text = ex.Message;
            }
        }
    }
}
