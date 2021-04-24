using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TruYumWebApiInAzure.DataContext;
using TruYumWebApiInAzure.ViewModels;

namespace TruYumWebApiInAzure.Repository
{
    public class MenuRepository:IMenuRepository
    {
        public MenuItemContext _menuItemContext { get; set; }
        public List<MenuItem> MenuItems { get; set; }
        public MenuRepository(MenuItemContext menuItemContext)
        {
            _menuItemContext = menuItemContext;
            MenuItems = new List<MenuItem>()
            {
                new MenuItem {Id=1, Name = "aloo ke parathe", FreeDelivery = true, Price =30, DateOfLaunch = new DateTime(2018,08,06), Active = true },
                new MenuItem {Id=2, Name = "samosa", FreeDelivery = true, Price =10, DateOfLaunch = new DateTime(2017,12,30), Active = true },
                new MenuItem {Id=3, Name = "paneer makhani", FreeDelivery = true, Price =90, DateOfLaunch = new DateTime(2009,7,9), Active = true },
                new MenuItem {Id=4, Name = "biryani", FreeDelivery = true, Price =130, DateOfLaunch = new DateTime(1997,5,6), Active = true },
                new MenuItem {Id=5, Name = "roti", FreeDelivery = true, Price =15, DateOfLaunch = new DateTime(2015,4,8), Active = true },
                new MenuItem {Id=6, Name = "ice cream", FreeDelivery = true, Price =70, DateOfLaunch = new DateTime(1800,1,3), Active = true }

            };
        }
        public string GetMenuItemName(int Id)
        {
            var m=MenuItems.Find(m=>m.Id==Id);
            return m.Name;
        }
        public IEnumerable<Item> GetMenuItemList()
        {
            return MenuItems.Where(m => m.Active == true && m.DateOfLaunch < DateTime.Now).Select(m => new Item {Id=m.Id,Name=m.Name,FreeDelivery=m.FreeDelivery,Price=m.Price });
        }
    }
}
