using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Windows.Forms;
using DefectFinder.DAL;
using DefectFinder.Model;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace DefectFinder
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button_SendRequest_Click(object sender, EventArgs e)
        {
            GetProjects();
        }

        public async void GetProjects()
        {
            try
            {
                using (TfsHttpClient tfsClient = new TfsHttpClient("https://lewicki.VisualStudio.com/DefaultCollection/", textBox_Username.Text, textBox_Password.Text))
                {
                    using (HttpResponseMessage response = tfsClient.GetAsync("_apis/projects?api-version=2.0").Result)
                    {
                        response.EnsureSuccessStatusCode();
                        string responseBody = await response.Content.ReadAsStringAsync();

                        textBox_Console.Text = responseBody;

                        JObject test = JObject.Parse(responseBody);
                        IList<JToken> values = test["value"].Children().ToList();

                        List<Project> projects = values.Select(value => JsonConvert.DeserializeObject<Project>(value.ToString())).ToList();
                    }
                }
            }
            catch (Exception ex)
            {
                textBox_Console.Text = ex.ToString();
            }
        }
    }
}
