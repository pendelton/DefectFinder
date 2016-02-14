using System.Collections.Generic;
using System.Threading.Tasks;
using DefectFinder.Model;

namespace DefectFinder.DAL
{
    internal interface ITfsQueryable
    {
        Task<Project> GetProject(string id);
        Task<List<Project>> GetProjects(string stateFilter, int top, int skip);

        Task<Changeset> GetChangeset(string id);
        Task<List<ChangesetChange>> GetChangesetChange(string id);
    }
}