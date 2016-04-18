using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Data.Entity;

namespace WildLifeTracker.Models
{
    public class WildLifeTrackerContext : DbContext
    {
        public virtual DbSet<Specie> Species { get; set; } 
        public virtual DbSet<Sighting> Sightings { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=WildLifeTracker;integrated security=True;");
        }
    }
}
