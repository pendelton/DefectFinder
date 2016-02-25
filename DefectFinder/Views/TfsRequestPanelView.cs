using System;
using System.Windows.Forms;

namespace DefectFinder.Views
{
    public partial class TfsRequestPanelView : UserControl, ITfsRequestPanelView
    {
        public event EventHandler RequestTypeSelectionChanged;

        public string RequestType => comboBox_RequestType.SelectedItem.ToString();
        public string ProjectState => comboBox_ProjectState.SelectedItem.ToString();
        public int Skip => Convert.ToInt32(textBox_Skip.Text);
        public new int Top => Convert.ToInt32(textBox_Top.Text);
        public string ProjectId => textBox_Id.Text;

        public TfsRequestPanelView()
        {
            InitializeComponent();

            textBox_Id.Enabled = false;
            textBox_Skip.Enabled = false;
            textBox_Top.Enabled = false;
            comboBox_ProjectState.Enabled = false;

            this.comboBox_RequestType.SelectedValueChanged += ComboBox_RequestType_SelectedValueChanged;
        }

        private void ComboBox_RequestType_SelectedValueChanged(object sender, EventArgs e)
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
    }

    public interface ITfsRequestPanelView
    {
        event EventHandler RequestTypeSelectionChanged;
        string RequestType { get; }
        string ProjectState { get; }
        int Skip { get; }
        int Top { get; }
        string ProjectId { get; }
    }
}
