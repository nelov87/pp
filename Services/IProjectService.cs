using INStudio.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace INStudio.Services
{
    public interface IProjectService
    {
        HashSet<Project> GetProjects();

        bool AddProject(Project project);

        bool EditProject(string id, Project project);

        bool DeleteProject(string id);

        Project GetProject(string id);

        bool IsProjectExist(string id);
    }
}
