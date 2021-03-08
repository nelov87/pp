using INStudio.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace INStudio.Services
{
    public class SettingsService : ISettingsService
    {
        public ApplicationDbContext db { get; set; }


        public SettingsService(ApplicationDbContext dbContext)
        {
            this.db = dbContext;
        }

        public bool Edit(string key, string newValue)
        {
            bool operationOk = true;

            try
            {
                Setting setting = db.Settings.FirstOrDefault(x => x.Key == key);
            setting.Value = newValue;
            this.db.SaveChanges();
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message + " --- SettingsSetvice Edit");
                operationOk = false;
            }
            return operationOk;
        }

        public ICollection<Setting> GetAll()
        {
            HashSet<Setting> AllSettings = new HashSet<Setting>();

            AllSettings = this.db.Settings.ToHashSet();

            return AllSettings;
        }

        public string GetByKey(string key)
        {
            try
            {
                var seting = this.db.Settings.FirstOrDefault(x => x.Key == key).Value;
                return seting;
            }
            catch(Exception e)
            {
                return new string (String.Empty);
            }

            
        }

        public void Add(Setting setting)
        {
            this.db.Settings.Add(setting);
            this.db.SaveChanges();
        }

        public void Delete(string id)
        {
            Setting setting = this.db.Settings.FirstOrDefault(x => x.Id == id);
            db.Settings.Remove(setting);
        }
        public Setting GetById(string id)
        {
            Setting setting = this.db.Settings.FirstOrDefault(x => x.Id == id);
            return setting;
        }
    }
}
