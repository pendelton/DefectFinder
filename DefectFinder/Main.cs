using System;
using System.Drawing;
using System.Windows.Forms;
using DefectFinder.Views;

namespace DefectFinder
{
    public partial class MainForm : Form, IMainForm
    {
        private readonly ConsoleView _consoleView;
        private readonly TfsRequestPanelView _tfsRequestPanelView;
        private readonly ToolbarView _toolbarView;

        // Public methods
        public MainForm()
        {
            InitializeComponent();
            _consoleView = new ConsoleView() {Dock = DockStyle.Bottom};
            _tfsRequestPanelView = new TfsRequestPanelView() { Dock = DockStyle.Bottom };
            _toolbarView = new ToolbarView() { Dock = DockStyle.Top };

            this.Controls.Add(_toolbarView);
            this.Controls.Add(_tfsRequestPanelView);
            this.Controls.Add(_consoleView);
        }

        public IConsoleView ConsoleView => _consoleView;
        public ITfsRequestPanelView TfsRequestPanelView => _tfsRequestPanelView;
        public IToolbarView ToolbarView => _toolbarView;

        /*
         * Private Events Methods 
         */

        //private void button_SendRequest_Click(object sender, EventArgs e)
        //{
        //    switch (comboBox_RequestType.SelectedItem.ToString())
        //    {
        //        case "Project":
        //            RequestForProject();
        //            break;
        //        case "Projects":
        //            RequestForProjects();
        //            break;
        //        case "Changeset":
        //            RequestForChangeset();
        //            break;
        //        case "Changesets":
        //            RequestForChangesets();
        //            break;
        //    }
        //}

        //private void comboBox_RequestType_SelectedValueChanged(object sender, EventArgs e)
        //{
        //    switch (comboBox_RequestType.SelectedItem.ToString())
        //    {
        //        case "Project":
        //            DecorateProjectFields();
        //            break;
        //        case "Projects":
        //            DecorateProjectsFields();
        //            break;
        //        case "Changeset":
        //            DecorateChangesetFields();
        //            break;
        //        case "Changesets":
        //            DecorateChangesetsFields();
        //            break;
        //    }
        //}

    }

    public interface IMainForm
    {
        event EventHandler Load;
        event FormClosedEventHandler FormClosed;
        
        IConsoleView ConsoleView { get; }
        ITfsRequestPanelView TfsRequestPanelView { get; }
        IToolbarView ToolbarView { get; }

        Color BackColor { get; set; }
    }
}
