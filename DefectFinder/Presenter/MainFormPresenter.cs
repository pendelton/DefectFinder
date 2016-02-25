using System;
using DefectFinder.DAL;
using DefectFinder.Model;
using DefectFinder.Views;

namespace DefectFinder.Presenter
{
    class MainFormPresenter
    {
        // Private variables
        private readonly IMainFormView _mainFormView;
        private readonly IConsoleView _consoleView;
        private readonly IToolbarView _toolbarView;
        private readonly ITfsRequestPanelView _tfsRequestPanelView;

        private readonly ITfsHttpClient _tfsHttpClient;

        public MainFormPresenter(IMainFormView mainFormView, ITfsHttpClient tfsHttpClient)
        {
            this._mainFormView = mainFormView;

            _consoleView = mainFormView.ConsoleView;
            _toolbarView = mainFormView.ToolbarView;
            _tfsRequestPanelView = mainFormView.TfsRequestPanelView;

            mainFormView.Load += MainFormView_Load;
            mainFormView.FormClosed += MainFormView_FormClosed;

            _toolbarView.StartClicked += ToolbarView_StartClicked;
            _toolbarView.TrashClicked += ToolbarView_TrashClicked;

            _tfsHttpClient = tfsHttpClient;
        }

        private void ToolbarView_TrashClicked(object sender, EventArgs e)
        {
            _consoleView.Clear();
        }

        private void ToolbarView_StartClicked(object sender, EventArgs e)
        {
            switch (_tfsRequestPanelView.RequestType)
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

        // Private methods
        private void MainFormView_FormClosed(object sender, System.Windows.Forms.FormClosedEventArgs e)
        {
            //throw new NotImplementedException();
        }

        private void MainFormView_Load(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
        }

        private async void RequestForProjects()
        {
            var projects = await _tfsHttpClient.GetProjects(_tfsRequestPanelView.ProjectState,
                                                           _tfsRequestPanelView.Top, 
                                                           _tfsRequestPanelView.Skip);

            _consoleView.PrintProjects(projects);
        }

        private async void RequestForProject()
        {
            Project project = null;
            try
            {
                project = await _tfsHttpClient.GetProject(_tfsRequestPanelView.ProjectId);
            }
            catch (Exception ex)
            {
                _consoleView.PrintError(ex);
            }

            _consoleView.PrintProject(project);
        }

        private void RequestForChangesets()
        {
            throw new NotImplementedException();
        }

        private void RequestForChangeset()
        {
            throw new NotImplementedException();
        }
    }
}
