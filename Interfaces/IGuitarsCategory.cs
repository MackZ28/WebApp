using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApp.Models;

namespace WebApp.Interfaces
{
    public interface IGuitarsCategory
    {
        IEnumerable<Category> AllCategories { get; }
    }
}
