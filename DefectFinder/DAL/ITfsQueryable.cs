using System.Collections.Generic;
using System.Threading.Tasks;
using DefectFinder.Model;

namespace DefectFinder.DAL
{
    internal interface ITfsQueryable
    {
        Task<List<Project>> GetProjects(string stateFilter, int top, int skip);
        Task<Project> GetProject(string id);
    }
}