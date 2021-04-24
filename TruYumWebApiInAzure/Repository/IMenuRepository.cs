using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TruYumWebApiInAzure.ViewModels;

namespace TruYumWebApiInAzure.Repository
{
    public interface IMenuRepository
    {
        string GetMenuItemName(int Id);
        IEnumerable<Item> GetMenuItemList();
    }
}
