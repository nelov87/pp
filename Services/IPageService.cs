using INStudio.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace INStudio.Services
{
    public interface IPageService
    {

        ICollection<Page> GetPages();

        bool AddPage(Page page);

        bool EditPage(string id, Page page);

        bool DeletePage(string id);

        Page GetPageById(string id);

        Page GetPageByName(string name);

        bool IsPageExist(string id);

    }
}
