using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bicycles
{
    public class BicycleContext : DbContext
    {
        public BicycleContext()
            :base("Bicycles.Properties.Settings.DbBicyclesConnection")
        { }

        public DbSet<Bicycle> Bicycles { get; set; }
        public DbSet<BicycleType> BicycleTypes { get; set; }
        public DbSet<AmortizationType> AmortizationTypes { get; set; }
    }
}
