using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using DishesApp.Models;

namespace DishesApp.Data
{
    public class DishesAppContext : DbContext
    {
        public DishesAppContext (DbContextOptions<DishesAppContext> options)
            : base(options)
        {
        }

        public DbSet<DishesApp.Models.Dish> Dish { get; set; }
    }
}
