using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DefectFinder.Model;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace DefectFinder.Core
{
    public static class JsonDeserializer
    {
        public static List<Project> DeserializeProjects(string response)
        {
            List<Project> projectsLst = null; 

            if (!String.IsNullOrEmpty(response))
            {
                JObject jsonRespons = JObject.Parse(response);
                IList<JToken> values = jsonRespons[Constants.JsonTfsNodes.Value].Children().ToList();

                projectsLst = values.Select(value => JsonConvert.DeserializeObject<Project>(value.ToString())).ToList();
            }

            return projectsLst;
        }

        internal static Changeset DeserializeChangeset(string response)
        {
            throw new NotImplementedException();
        }

        internal static List<ChangesetChange> DeserializeChangesetChange(string response)
        {
            throw new NotImplementedException();
        }
    }
}
