using Statystyki_OSP.Dane;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Statystyki_OSP.DataAccess
{
    public class StoreContext : DbContext
    {
        public StoreContext() : base("Statystyki_OSPDbContext")
        {
        }
        public DbSet<Accident> Accidents { get; set; }
        public DbSet<Vehicle> Vehicles { get; set; }
        public DbSet<Fireman> Firemans { get; set; }
    }
    
}
