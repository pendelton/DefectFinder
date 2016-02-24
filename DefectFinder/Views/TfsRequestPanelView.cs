using System;
using System.Collections.Generic;
using System.Configuration;
using System.Threading.Tasks;
using System.Windows.Forms;
using DefectFinder.DAL;
using DefectFinder.Model;

namespace DefectFinder.Views
{
    public partial class TfsRequestPanelView : UserControl, ITfsRequestPanelView
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

        public TfsRequestPanelView()
        {
            InitializeComponent();

            textBox_Id.Enabled = false;
            textBox_Skip.Enabled = false;
            textBox_Top.Enabled = false;
            comboBox_ProjectState.Enabled = false;
        }

        public event EventHandler RequestTypeSelectionChanged;

        public async void RequestForChangesets()
        {
            throw new NotImplementedException();
        }

        public async void RequestForChangeset()
        {
            throw new NotImplementedException();
        }

        public async Task<List<Project>> RequestForProjects()
        {
            var projects = await TfsHttpClient.GetProjects(comboBox_ProjectState.SelectedItem.ToString(),
                        Convert.ToInt32(textBox_Top.Text), Convert.ToInt32(textBox_Skip.Text));

            return projects;
            //consoleView.PrintProjects(projects);
        }

        public async Task<Project> RequestForProject()
        {
            Project project = null;
            try
            {
                project = await TfsHttpClient.GetProject(textBox_Id.Text);
            }
            catch (Exception)
            {
                throw;
            }

            return project;
            //try
            //{
            //    var project = await TfsHttpClient.GetProject(textBox_Id.Text);
            //}

            //catch (Exception ex)
            //{
            //    consoleView.PrintError(ex);
            //}
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
    }

    public interface ITfsRequestPanelView
    {
        Task<Project> RequestForProject();
        Task<List<Project>> RequestForProjects();
        void RequestForChangesets();
        void RequestForChangeset();

        event EventHandler RequestTypeSelectionChanged;
    }
}
