using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Models
{
    public class CartItem
    {
        public int Id { get; set; }
        public Guitar guitar { get; set; }
        public int price { get; set; }
        public string CartId { get; set; }
    }
}
