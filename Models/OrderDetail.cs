using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Models
{
    public class OrderDetail
    {
        public int id { get; set; }

        public int orderID { get; set; }

        public int GuitarID { get; set; }

        public int price { get; set; }

        public virtual Guitar guitar { get; set; }

        public virtual Order email { get; set; }
    }
}
