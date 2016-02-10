using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using DefectFinder.Model;

namespace DefectFinder.DAL
{
    class TfsHttpClient : HttpClient, ITfsQueryable
    {
        public TfsHttpClient(string baseAddress, string user, string pass)
        {
            BaseAddress = new Uri(baseAddress);
            DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic",
                Convert.ToBase64String(System.Text.Encoding.ASCII.GetBytes($"{user}:{pass}")));
        }

        public List<Project> GetProjects()
        {
            throw new NotImplementedException();
        }
    }
}
