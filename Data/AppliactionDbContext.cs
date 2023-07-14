using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Test2.Models;

namespace Test2.Data
{
    public class AppliactionDbContext : DbContext
    {
        public AppliactionDbContext (DbContextOptions<AppliactionDbContext> options)
            : base(options)
        {
        }

        public DbSet<Test2.Models.CompanyNTS999> CompanyNTS999 { get; set; } = default!;
    }
}
