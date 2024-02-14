using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MyAutoHelper.Database.Models;

namespace MyAutoHelper.Database.Context
{
    public class AppContext: DbContext
    {
        public AppContext()
        {
            //Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=MyAutoHelper;Username=USERNAME;Password=PASSWORD");
        }

        public DbSet<User> Users { get; set; }
    }
}
