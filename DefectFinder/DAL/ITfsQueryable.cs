using System.Collections.Generic;
using System.Threading.Tasks;
using DefectFinder.Model;

namespace DefectFinder.DAL
{
    internal interface ITfsQueryable
    {
        Task<List<Project>> GetProjects(int top, int skip);
    }
}