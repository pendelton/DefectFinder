using System.Collections.Generic;
using DefectFinder.Model;

namespace DefectFinder.DAL
{
    internal interface ITfsQueryable
    {
        List<Project> GetProjects();
    }
}