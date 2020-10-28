using DairyFarmWebApp.BusinessLayer;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DairyFarmWebApp.Data
{
    public class DairyFarmDataContext : DbContext
    {
        public DairyFarmDataContext(DbContextOptions<DairyFarmDataContext> options) : base(options)
        {

        }

        public DbSet<Category> Courses { get; set; }

        public DbSet<Company> Students { get; set; }

        public DbSet<Product> StudentCourses { get; set; }

        public DbSet<Order> Branches { get; set; }
    }
}
