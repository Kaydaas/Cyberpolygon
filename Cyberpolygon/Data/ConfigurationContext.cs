using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Cyberpolygon.Models;

namespace Cyberpolygon.Data
{
    public class ConfigurationContext : DbContext
    {
        public ConfigurationContext(DbContextOptions<ConfigurationContext> options)
            : base(options)
        {
        }

        public DbSet<Configuration> Configuration { get; set; } = default!;

        public void EnsureCreatedIfNotExists()
        {
            if (!Database.CanConnect())
            {
                Database.EnsureCreated();
            }
        }
    }
}