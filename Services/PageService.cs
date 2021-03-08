using Microsoft.EntityFrameworkCore;
using INStudio.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace INStudio.Services
{
    public class PageService : IPageService
    {

        public ApplicationDbContext db { get; set; }

        public PageService(ApplicationDbContext dbContext)
        {
            this.db = dbContext;
        }

        public bool AddPage(Page page)
        {
            bool operatinOk = true;

            try
            {
                this.db.Pages.Add(page);

                this.db.SaveChanges();
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message + " --- PageService Add");
                operatinOk = false;
            }
            return operatinOk;
        }

        public bool DeletePage(string id)
        {

            bool operatinOk = true;

            try
            {
                Page pageToRemove = this.db.Pages.FirstOrDefault(x => x.Id == id);
            this.db.Remove(pageToRemove);
            this.db.SaveChanges();
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message + " --- PageService Delete");
                operatinOk = false;
            }
            return operatinOk;
        }

        public bool EditPage(string id, Page page)
        {
            bool operatinOk = true;

            try
            {
                Page pageToEdit = this.db.Pages.FirstOrDefault(x => x.Id == id);
            pageToEdit = page;

            this.db.SaveChanges();
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message + " --- PageService Edit");
                operatinOk = false;
            }
            return operatinOk;
        }

        public Page GetPageById(string id)
        {
            Page page = this.db.Pages.Include(p => p.Image).FirstOrDefault(x => x.Id == id);

            return page;
        }
        public Page GetPageByName(string name)
        {
            Page page = this.db.Pages.Include(p => p.Image).FirstOrDefault(x => x.Title == name);

            return page;
        }

        public ICollection<Page> GetPages()
        {
            HashSet<Page> pages = new HashSet<Page>();
            pages = this.db.Pages.ToHashSet();

            return pages;
        }

        public bool IsPageExist(string id)
        {
            bool isItExist = false;
            if (id != null)
            {
                isItExist = this.db.Pages.Any(p => p.Id == id);
                
            }
            return isItExist;
        }


    }
}
