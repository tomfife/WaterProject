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
            ViewBag.SelectedCategory = RouteData?.Values["category"];   // Pulls from the url and says this is our selected category

            return View(repository.Projects
                .Select(x => x.Type)
                .Distinct()
                .OrderBy(x => x));
        }
    }
}
