using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApp.Interfaces;
using WebApp.Models;
using WebApp.ViewModels;

namespace WebApp.Controllers
{
    public class HomeController : Controller
    {

        private IAllGuitars _guitarRep;
        public HomeController(IAllGuitars guitarRep)
        {
            _guitarRep = guitarRep;
        }

        public ViewResult Index()
        {
            var homeCars = new HomeViewModel
            {
                favGuitars = _guitarRep.getFavGuitars
            };

            return View(homeCars);
        }

    }
}
