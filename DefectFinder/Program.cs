using System;
using System.Configuration;
using System.Windows.Forms;
using DefectFinder.DAL;
using DefectFinder.Presenter;

namespace DefectFinder
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            var mainFormView = new MainFormView();

            var tfsHttpClient = new TfsHttpClient(ConfigurationManager.AppSettings[Constants.AppConfig.TfsServer],
                        ConfigurationManager.AppSettings[Constants.AppConfig.UsernameKey],
                        ConfigurationManager.AppSettings[Constants.AppConfig.PasswordKey],
                        ConfigurationManager.AppSettings[Constants.AppConfig.WebApiVersion]);

            var presenter = new MainFormPresenter(mainFormView, tfsHttpClient);
            Application.Run(mainFormView);
        }
    }
}
