using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Models
{
    public class Guitar
    {
        public int id { get; set; }
        public string name { get; set; }
        public string shortDesc { get; set; }
        public string longDesc { get; set; }
        public int price { get; set; }
        public string img { get; set; }
        public bool available { get; set; }
        public int categoryID { get; set; }
        public bool ifFavourite { get; set; }
        public virtual Category Category { get; set; }
    }
}
