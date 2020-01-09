using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApp.Interfaces;
using WebApp.Models;

namespace WebApp.Controllers
{
    public class GuitarsController : Controller
    {
        private readonly IAllGuitars _allGuitars;
        private readonly IGuitarsCategory _allCategories;


        public GuitarsController(IAllGuitars iAllGuitars, IGuitarsCategory iGuitarCat)
        {
            _allGuitars = iAllGuitars;
            _allCategories = iGuitarCat;
        }

        public ViewResult List(string category)
        {
            string _category = category;
            IEnumerable<Guitar> guitars = null;
            string currCategory = "";

            if (string.IsNullOrEmpty(category))
            {
                guitars = _allGuitars.Guitars.OrderBy(i => i.id);
            }
            else
            {
                if (string.Equals("electro", category, StringComparison.OrdinalIgnoreCase))
                {
                    guitars = _allGuitars.Guitars.Where(i => i.Category.categoryName.Equals("Электромобили")).OrderBy(i => i.id);
                    currCategory = "Элктромобили";
                }
                else if (string.Equals("fuel", category, StringComparison.OrdinalIgnoreCase))
                {
                    guitars = _allGuitars.Guitars.Where(i => i.Category.categoryName.Equals("Классический автомобиль")).OrderBy(i => i.id);
                    currCategory = "Бензиновые авто";
                }


                currCategory = _category;


            }

            var guitarObj = new GuitarListViewModel
            {
                allGuitars = guitars,
                currCategory = currCategory
            };

            ViewBag.Title = "Страница с автомобилями";

            return View(guitarObj);
        }
    }
}
