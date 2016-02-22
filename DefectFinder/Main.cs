using System;
using System.Windows.Forms;

namespace DefectFinder
{
    public partial class MainForm : Form
    {
        // Public methods
        public MainForm()
        {
            InitializeComponent();
        }

        private void tfsRequestPanel1_Load(object sender, EventArgs e)
        {

        }

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
}
