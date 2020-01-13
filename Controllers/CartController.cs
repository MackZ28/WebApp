using Microsoft.AspNetCore.Mvc;
using WebApp.Interfaces;
using WebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApp.ViewModels;

namespace WebApp.Controllers
{
    public class CartController : Controller
    {
        private IAllGuitars allGuitars;
        private readonly Cart _cart;

        public CartController(IAllGuitars guitarRep, Cart cart)
        {
            allGuitars = guitarRep;
            _cart = cart;
        }

        public ViewResult Index()
        {
            var items = _cart.getShopItems();
            _cart.listItems = items;

            var obj = new CartViewModel
            {
                cart = _cart
            };

            return View(obj);
        }

        public RedirectToActionResult addToCart(int id)
        {
            var item = allGuitars.Guitars.FirstOrDefault(i => i.id == id);
            if (item != null)
            {
                _cart.AddToCart(item);
            }
            return RedirectToAction("Index");
        }
    }
}
