using Microsoft.EntityFrameworkCore;
using INStudio.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace INStudio.Services
{
    public class ProjectService : IProjectService
    {
        public ApplicationDbContext db { get; set; }

        public ProjectService(ApplicationDbContext dbContext)
        {
            this.db = dbContext;
        }

        public bool AddProject(Project project)
        {
            bool operatinOk = true;

            try
            {
                this.db.Projects.Add(project);

            this.db.SaveChanges();
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message + " --- ProjectService Add");
                operatinOk = false;
            }
            return operatinOk;
        }

        public bool DeleteProject(string id)
        {

            bool operatinOk = true;

            try
            {
                Project projectToRemove = this.db.Projects.FirstOrDefault(x => x.Id == id);
            this.db.Remove(projectToRemove);
            this.db.SaveChanges();
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message + " --- ProjectService Delete");
                operatinOk = false;
            }
            return operatinOk;
        }

        public bool EditProject(string id, Project project)
        {
            bool operatinOk = true;

            try
            {
                Project projectToEdit = this.db.Projects.FirstOrDefault(x => x.Id == id);
            projectToEdit = project;

            this.db.SaveChanges();
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message + " --- ProjectService Edit");
                operatinOk = false;
            }
            return operatinOk;
        }

        public Project GetProject(string id)
        {
            if (id != null && id != String.Empty)
            {
                Project project = this.db.Projects.Include(g => g.Gallery).Include(gi => gi.Gallery.GalleryImages).Include(i => i.Image).FirstOrDefault(x => x.Id == id);
                return project;
            }
            else
            {
                Project project = this.db.Projects.Include(g => g.Gallery).Include(gi => gi.Gallery.GalleryImages).Include(i => i.Image).FirstOrDefault();
                return project;
            }

            
        }

        public HashSet<Project> GetProjects()
        {
            HashSet<Project> projects = new HashSet<Project>();
            projects = this.db.Projects.Include(i => i.Image).Include(g => g.Gallery).ToHashSet();

            return projects;
        }

        public bool IsProjectExist(string id)
        {
            bool isItExist = false;
            if (id != null)
            {
                isItExist = this.db.Projects.Any(p => p.Id == id);

            }
            return isItExist;
        }
    }
}
