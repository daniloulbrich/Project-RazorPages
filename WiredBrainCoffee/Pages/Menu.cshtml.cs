using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using WiredBrainCoffee.Models;
using WiredBrainCoffee.Services;

namespace WiredBrainCoffee.Pages
{
    public class MenuModel : PageModel
    {
        private IMenuService menuService;
        private ILogger<MenuModel> logger;

        public List<MenuItem> Menu { get; set; }

        //Esto es inyeccion de dependecias
        public MenuModel(IMenuService menuService, ILogger<MenuModel> logger)
        {
            this.menuService = menuService;
            this.logger = logger; 
        }
        public void OnGet()
        {
            //Esto crea una gran dependecia por lo que no hay inyeccion de dependecia
            //var menuService = new MenuService();

            Menu = menuService.GetMenuItems();
        }
    }
}
