using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using DefectFinder.Model;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace DefectFinder.DAL
{
    public class TfsHttpClient : HttpClient, ITfsQueryable
    {
        private readonly string _apiVersion;

        public TfsHttpClient(string baseAddress, string user, string pass, string apiVersion)
        {
            BaseAddress = new Uri(baseAddress);
            DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic",
                Convert.ToBase64String(System.Text.Encoding.ASCII.GetBytes($"{user}:{pass}")));
            _apiVersion = apiVersion;
        }

        public async Task<List<Project>> GetProjects(string stateFilter, int top = 100, int skip = 0)
        {
            HttpResponseMessage response = await GetAsync("_apis/projects?statefilter="+ stateFilter + "&$top=" + top +"&$skip="+ skip + "&api-version=" + _apiVersion);

            response.EnsureSuccessStatusCode();

            var responseBody = await response.Content.ReadAsStringAsync();

            return DeserializeProjectsJsonResponse(responseBody);
        }

        public async Task<Project> GetProject(string id)
        {
            HttpResponseMessage response = await GetAsync("_apis/projects/"+ id + "?api-version=" + _apiVersion);

            response.EnsureSuccessStatusCode();

            var responseBody = await response.Content.ReadAsStringAsync();

            return new Project() { Name = "not implemented yet"};
        }

        //Private methods
        private List<Project> DeserializeProjectsJsonResponse(string jsonResponseBody)
        {
            JObject jsonResponsBody = JObject.Parse(jsonResponseBody);
            IList<JToken> values = jsonResponsBody[Constants.JsonTfsNodes.Value].Children().ToList();

            return values.Select(value => JsonConvert.DeserializeObject<Project>(value.ToString())).ToList();
        }
    }
}
