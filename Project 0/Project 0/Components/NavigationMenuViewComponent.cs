/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using Project_0.Models;
namespace Project_0.Components
{
    public class NavigationMenuViewComponent : ViewComponent
    {
        private IVolunteerRepository repository;
        public NavigationMenuViewComponent(IVolunteerRepository repo)
        {
            repository = repo;
        }
        public IViewComponentResult Invoke()
        {
            return View(repository.Volunteers
            .Distinct()
            .OrderBy(x => x));
        }
    }
}*/