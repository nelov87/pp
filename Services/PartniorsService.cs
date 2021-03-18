using Microsoft.EntityFrameworkCore;
using INStudio.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace INStudio.Services
{
    public class PartniorsService : IPartniorsService
    {
        public ApplicationDbContext db { get; set; }

        public PartniorsService(ApplicationDbContext dbContext)
        {
            this.db = dbContext;
        }

        public bool AddPartnior(Partnior partnior)
        {
            bool operatinOk = true;

            try
            {
                this.db.Partniors.Add(partnior);

            this.db.SaveChanges();
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message + " --- PartniorsService Add");
                operatinOk = false;
            }
            return operatinOk;
        }

        public bool DeletePartnior(string id)
        {

            bool operatinOk = true;

            try
            {
                Partnior partnioroRemove = this.db.Partniors.FirstOrDefault(x => x.Id == id);
            this.db.Partniors.Remove(partnioroRemove);
            this.db.SaveChanges();
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message + " --- PartniorsService Delete");
                operatinOk = false;
            }
            return operatinOk;
        }

        public bool EditPartnior(string id, Partnior partnior)
        {
            bool operatinOk = true;

            try
            {
                Partnior partniorToEdit = this.db.Partniors.FirstOrDefault(x => x.Id == id);
            partniorToEdit = partnior;

            this.db.SaveChanges();
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message + " --- PartniorsService Edit");
                operatinOk = false;
            }
            return operatinOk;
        }

        public Partnior GetPartnior(string id)
        {
            if (id != null && id != String.Empty)
            {
                Partnior partnior = this.db.Partniors.Include(g => g.Galery).Include(gi => gi.Galery.GalleryImages).Include(i => i.Image).FirstOrDefault(x => x.Id == id);
                return partnior;
            }
            else
            {
                Partnior partnior = this.db.Partniors.Include(g => g.Galery).Include(gi => gi.Galery.GalleryImages).Include(i => i.Image).FirstOrDefault();
                return partnior;
            }

            
        }

        public HashSet<Partnior> GetPartniors()
        {
            HashSet<Partnior> partniors = new HashSet<Partnior>();
            partniors = this.db.Partniors.Include(i => i.Image).Include(g => g.Galery).ToHashSet();

            return partniors;
        }

        public bool IsPartniorExist(string id)
        {
            bool isItExist = false;
            if (id != null)
            {
                isItExist = this.db.Partniors.Any(p => p.Id == id);

            }
            return isItExist;
        }
    }
}
