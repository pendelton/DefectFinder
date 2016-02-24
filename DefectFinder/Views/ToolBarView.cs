using System;
using System.Windows.Forms;

namespace DefectFinder.Views
{
    public partial class ToolbarView : UserControl, IToolbarView
    {
        public ToolbarView()
        {
            InitializeComponent();
        }

        public event EventHandler SettingsClicked
        {
            add { buttonSettings.Click += value; }
            remove { buttonSettings.Click -= value; }
        }

        public event EventHandler DataClicked
        {
            add { buttonData.Click += value; }
            remove { buttonData.Click -= value; }
        }

        public event EventHandler StartClicked
        {
            add { buttonStart.Click += value; }
            remove { buttonStart.Click -= value; }
        }

        public event EventHandler TrashClicked
        {
            add { buttonTrash.Click += value; }
            remove { buttonTrash.Click -= value; }
        }

        public event EventHandler FilterClicked
        {
            add { buttonFilter.Click += value; }
            remove { buttonFilter.Click -= value; }
        }
    }

    public interface IToolbarView
    {
        event EventHandler SettingsClicked;
        event EventHandler DataClicked;
        event EventHandler StartClicked;
        event EventHandler TrashClicked;
        event EventHandler FilterClicked;
    }
}
