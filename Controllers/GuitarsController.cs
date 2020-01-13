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


        [Route("Guitars/List")]
        [Route("Guitars/List/{category}")]
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
                 if (string.Equals("6_strings", category, StringComparison.OrdinalIgnoreCase))
                {
                    guitars = _allGuitars.Guitars.Where(i => i.Category.categoryName.Equals("Электрогитары_6")).OrderBy(i => i.id);
                    currCategory = "Электрогитары 6 струн";
                }
                else if (string.Equals("7_strings", category, StringComparison.OrdinalIgnoreCase))
                {
                    guitars = _allGuitars.Guitars.Where(i => i.Category.categoryName.Equals("Электрогитары_7")).OrderBy(i => i.id);
                    currCategory = "Электрогитары 7 струн";
                }
                else if (string.Equals("acoustic", category, StringComparison.OrdinalIgnoreCase))
                {
                    guitars = _allGuitars.Guitars.Where(i => i.Category.categoryName.Equals("Акустические гитары")).OrderBy(i => i.id);
                    currCategory = "Акустические гитары";
                }


                //currCategory = _category;


            }

            var guitarObj = new GuitarListViewModel
            {
                allGuitars = guitars,
                currCategory = currCategory
            };
            ViewBag.Title = "FuseGuitars  " + currCategory;
            
            return View(guitarObj);
        }
    }
}
