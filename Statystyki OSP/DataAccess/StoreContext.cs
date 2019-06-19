using Statystyki_OSP.Dane;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Statystyki_OSP.DataAccess
{
    /// <summary>
    /// StoreContext
    /// </summary>
    public class StoreContext : DbContext
    {
        /// <summary>
        /// StoreContext
        /// </summary>
        /// <remarks>Konstruktor</remarks>
        public StoreContext() : base("Statystyki_OSPDbContext")
        {
        }
        /// <summary>
        /// Accidents
        /// </summary>
        /// <remarks>
        /// Laczy sie z bazda danych i pobiera dane z tabeli Accident
        /// </remarks>
        public DbSet<Accident> Accidents { get; set; }
        /// <summary>
        /// Vehicles
        /// </summary>
        /// <remarks>
        /// Laczy sie z bazda danych i pobiera dane z tabeli Vehicle
        /// </remarks>
        public DbSet<Vehicle> Vehicles { get; set; }
        /// <summary>
        /// Firemans
        /// </summary>
        /// <remarks>
        /// Laczy sie z bazda danych i pobiera dane z tabeli Fireman
        /// </remarks>
        public DbSet<Fireman> Firemans { get; set; }
    }
    
}
