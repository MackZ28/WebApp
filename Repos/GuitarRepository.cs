using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApp.Interfaces;
using WebApp.Models;

namespace WebApp.Repos
{
    public class GuitarRepository : IAllGuitars
    {

        private readonly AppDBContent appDBContent;

        public GuitarRepository(AppDBContent appDBContent)
        {
            this.appDBContent = appDBContent;
        }
        public IEnumerable<Guitar> Guitars => appDBContent.Guitar.Include(c => c.Category);

        public IEnumerable<Guitar> getFavGuitars => appDBContent.Guitar.Where(p => p.ifFavourite).Include(c => c.Category);

        public Guitar getObjectGuitar(int guitarId) => appDBContent.Guitar.FirstOrDefault(p => p.id == guitarId);
       
    }
}
