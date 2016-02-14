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
        }

        /*
         * Private Methods
         */
        private async void button_SendRequest_Click(object sender, EventArgs e)
        {
            try
            {
                var projects = await TfsHttpClient.GetProjects(Constants.StateFilter.All);
                foreach (var project in projects)
                {
                    textBox_Console.Text += project + Environment.NewLine;
                }
            }
            catch (Exception ex)
            {
                textBox_Console.Text = ex.Message;
            }
        }
    }
}
