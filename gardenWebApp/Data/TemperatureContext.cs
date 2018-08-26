using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using gardenWebApp.Models;

namespace gardenApp.Data
{
    public class TemperatureContext : DbContext
    {
        public TemperatureContext(DbContextOptions<TemperatureContext> options) : base(options)
        {
        }

        public DbSet<Temperature> Temperature { get; set; }

    }
}
