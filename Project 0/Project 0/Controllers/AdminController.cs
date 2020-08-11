using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Project_0.Controllers
{
    public class AdminController : Controller
    {
        public ViewResult Index()
        {
            return View();
        }
    }
}
