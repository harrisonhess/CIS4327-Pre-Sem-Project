using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Project_0.Models;
using Project_0.Models.ViewModels;
namespace Project_0.Controllers
{
    public class VolunteerController : Controller
    {
        private IVolunteerRepository repository;
        public int PageSize = 5;
        public VolunteerController(IVolunteerRepository repo)
        {
            repository = repo;
        }

        public ViewResult List(int page = 1)
            => View(new VolunteerListViewModel
            {
                Volunteers = repository.Volunteers
                        .Skip((page - 1) * PageSize)
                        .Take(PageSize),
                PagingInfo = new PagingInfo
                {
                    CurrentPage = page,
                    ItemsPerPage = PageSize,
                    TotalItems = repository.Volunteers.Count()
                },
            });
    }
}
