using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Sushi_Bar.Data
{
    public class Sushi_BarContext : DbContext
    {
        public Sushi_BarContext (DbContextOptions<Sushi_BarContext> options)
            : base(options)
        {
        }

        public DbSet<Dish> Dish { get; set; } = default!;
        public DbSet<Ingredient> Ingredient { get; set; } = default!;
        public DbSet<Order> Order { get; set; } = default!;
    }
}
