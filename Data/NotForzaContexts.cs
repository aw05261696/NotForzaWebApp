using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using NotForza.Models;
 
namespace NotForza.Data
{
    public class NotForzaContext : DbContext
    {
        public NotForzaContext (DbContextOptions<NotForzaContext> options)
            : base(options)
        {
        }
 
        public DbSet<NotForza.Models.Car> Car { get; set; } = default!;
    }
}
 
 