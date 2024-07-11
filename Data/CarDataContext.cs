using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using NotForza.Models;

namespace NotForza_web_app.Data
{
    public class CarDataContext : DbContext
    {
        public CarDataContext (DbContextOptions<CarDataContext> options)
            : base(options)
        {
        }

        public DbSet<NotForza.Models.Car> Car { get; set; } = default!;
    }
}
