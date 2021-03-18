using INStudio.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace INStudio.Services
{
    public interface IPartniorsService
    {
         HashSet<Partnior> GetPartniors();

        bool AddPartnior(Partnior partnior);

        bool EditPartnior(string id, Partnior partnior);

        bool DeletePartnior(string id);

        Partnior GetPartnior(string id);

        bool IsPartniorExist(string id);
    }
}