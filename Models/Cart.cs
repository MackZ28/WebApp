using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using WebApp.Repos;

namespace WebApp.Models
{
    public class Cart
    {
        private readonly AppDBContent appDBContent;
        public Cart(AppDBContent appDBContent)
        {
            this.appDBContent = appDBContent;
        }
        public string CartId { get; set; }

        public List<CartItem> listItems { get; set; }

        public static Cart GetCart(IServiceProvider services)
        {
            ISession session = services.GetRequiredService<IHttpContextAccessor>()?.HttpContext.Session;
            var context = services.GetService<AppDBContent>();
            string CartId = session.GetString("CartId") ?? Guid.NewGuid().ToString();

            session.SetString("CartId", CartId);

            return new Cart(context) { CartId = CartId };
        }

        public void AddToCart(Guitar guitar)
        {
            this.appDBContent.CartItem.Add(new CartItem    
            {
                CartId = CartId,
                guitar = guitar,
                price = guitar.price
            });

            appDBContent.SaveChanges();
        }

        public void RemoveFromCart(Guitar guitar)
        {
            
            this.appDBContent.CartItem.Remove(listItems.ElementAt(guitar.id));
        }

        public List<CartItem> getShopItems()
        {
            return appDBContent.CartItem.Where(c => c.CartId == CartId).Include(s => s.guitar).ToList();
        }
    }
}
