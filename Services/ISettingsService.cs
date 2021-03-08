using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using INStudio.Data;

namespace INStudio.Services
{
    public interface ISettingsService
    {
        ICollection<Setting> GetAll();

        string GetByKey(string key);

        bool Edit(string key, string newValue);

        void Add(Setting setting);

        void Delete(string id);
        Setting GetById(string id);
    }
}
