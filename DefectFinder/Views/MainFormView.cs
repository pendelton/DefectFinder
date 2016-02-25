using System;
using System.Drawing;
using System.Windows.Forms;
using DefectFinder.Views;

namespace DefectFinder
{
    public partial class MainFormView : Form, IMainFormView
    {
        private readonly ConsoleView _consoleView;
        private readonly TfsRequestPanelView _tfsRequestPanelView;
        private readonly ToolbarView _toolbarView;

        // Public methods
        public MainFormView()
        {
            InitializeComponent();
            _consoleView = new ConsoleView() {Dock = DockStyle.Bottom};
            _tfsRequestPanelView = new TfsRequestPanelView() { Dock = DockStyle.Bottom };
            _toolbarView = new ToolbarView() { Dock = DockStyle.Top };

            Controls.Add(_toolbarView);
            Controls.Add(_tfsRequestPanelView);
            Controls.Add(_consoleView);
        }

        public IConsoleView ConsoleView => _consoleView;
        public ITfsRequestPanelView TfsRequestPanelView => _tfsRequestPanelView;
        public IToolbarView ToolbarView => _toolbarView;
    }

    public interface IMainFormView
    {
        event EventHandler Load;
        event FormClosedEventHandler FormClosed;
        
        IConsoleView ConsoleView { get; }
        ITfsRequestPanelView TfsRequestPanelView { get; }
        IToolbarView ToolbarView { get; }

        Color BackColor { get; set; }
    }
}
