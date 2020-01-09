using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApp.Models;

namespace WebApp.Interfaces
{
    public interface IAllGuitars
    {
        IEnumerable<Guitar> Guitars { get; }
        IEnumerable<Guitar> getFavGuitars { get; }
        Guitar getObjectGuitar(int carId);
    }
}
