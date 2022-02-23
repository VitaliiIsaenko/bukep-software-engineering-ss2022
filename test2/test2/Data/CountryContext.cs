using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using test2.Models;

namespace test2.Data
{
    public class CountryContext : DbContext
    {
        public CountryContext()
        {
        }

        public CountryContext (DbContextOptions<CountryContext> options)
            : base(options)
        {
        }

        public DbSet<test2.Models.CountryModel> CountryModel { get; set; }
    }
}
