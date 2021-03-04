using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using WaterProject.Models;

namespace WaterProject.Components
{
    public class NavigationMenuViewComponent : ViewComponent
    {
        private ICharityRepository repository;   // Instance of a template connected with EFCharityRepository connected with DBContext


        public NavigationMenuViewComponent (ICharityRepository r)
        {
            repository = r;
        }

        public IViewComponentResult Invoke()    // Drop a partial view into a view
        {
            return View(repository.Projects
                .Select(x => x.Type)
                .Distinct()
                .OrderBy(x => x));
        }
    }
}
