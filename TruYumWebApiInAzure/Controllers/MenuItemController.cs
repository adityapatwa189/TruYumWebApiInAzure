using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TruYumWebApiInAzure.ViewModels;
using TruYumWebApiInAzure.Repository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Authentication.JwtBearer;

namespace TruYumWebApiInAzure.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class MenuItemController : ControllerBase
    {
        public IMenuRepository _menuRepository { get; set; }
        
        public MenuItemController(IMenuRepository menuRepository)
        {
            _menuRepository = menuRepository;
            
        }
        [HttpGet]
        public IEnumerable<Item> GetList()
        {
            return _menuRepository.GetMenuItemList();
        }

        [HttpGet("{Id}")]
        public IActionResult GetName(int Id)
        {
            return Ok(_menuRepository.GetMenuItemName(Id));
        }
    }
}
