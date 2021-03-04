using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WaterProject.Models;
using WaterProject.Models.ViewModels;

namespace WaterProject.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private ICharityRepository _repository;

        public int PageSize = 2; // Setting this up to only have 2 projects per page

        public HomeController(ILogger<HomeController> logger, ICharityRepository repository)
        {
            _logger = logger;
            _repository = repository;
        }

        public IActionResult Index(string category, int page = 1) // We are passing in the page, but we set a default of 1
        {
            return View(new ProjectListViewModel
            {
                Projects = _repository.Projects
                    .Where(p => category == null || p.Type == category) // If category is null or category is = to the category passed in
                    .OrderBy(p => p.ProjectId)                              // The select it
                    .Skip((page - 1) * PageSize)
                    .Take(PageSize)
                ,
                PagingInfo = new PagingInfo
                {
                    CurrentPage = page,
                    ItemsPerPage = PageSize,
                    TotalNumItems = category == null ? _repository.Projects.Count() :
                        _repository.Projects.Where(x => x.Type == category).Count()
                },
                CurrentCategory = category
            });
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
