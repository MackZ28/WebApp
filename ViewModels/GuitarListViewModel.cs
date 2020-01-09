using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApp.Models;

namespace WebApp
{
    public class GuitarListViewModel
    {
        public IEnumerable<Guitar> allGuitars { get; set; }
        public string currCategory { get; set; }
    }
}
