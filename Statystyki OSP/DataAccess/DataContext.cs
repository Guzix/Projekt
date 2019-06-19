using Statystyki_OSP.Dane;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Statystyki_OSP.DataAccess
{
    /// <summary>
    /// DataContext
    /// </summary>
    public class DataContext
    {
        static StoreContext context = new StoreContext();
        /// <summary>
        /// Contect
        /// </summary>
        /// <remarks>
        /// metoda typu StoreContext zwracajaca context
        /// </remarks>
        public static StoreContext Context
        {
            get { return context; }
        }
        /// <summary>
        /// GetFiremanList
        /// </summary>
        /// <returns>List</returns>
        /// <remarks>
        /// Metoda zwraca listę strazakow zapisanych w bazie danych
        /// </remarks>
        public static List<Fireman> GetFiremanList()
        {
            return context.Firemans.ToList();
        }
        /// <summary>
        /// GetVehicleList
        /// </summary>
        /// <returns>List</returns>
        /// <remarks>
        /// Metoda zwraca listę pojazdow zapisanych w bazie danych
        /// </remarks>
        public static List<Vehicle> GetVehiclesList()
        {
            return context.Vehicles.ToList();
        }
        /// <summary>
        /// GetAccidentList
        /// </summary>
        /// <returns>List</returns>
        /// <remarks>
        /// Metoda zwraca listę wyjazdow zapisanych w bazie danych
        /// </remarks>
        public static List<Accident> GetAccidentsList()
        {
            return context.Accidents.ToList();
        }
        /// <summary>
        /// AddOrEditFiremans
        /// </summary>
        /// <param name="value">strazak</param>
        /// <returns>wartosc true</returns>
        /// <remarks>
        /// Metoda dodaje nowego lub edytuje juz istniejacego strazaka
        /// </remarks>
        public static bool AddOrEditFiremans(Fireman value)
        {
            if (value.FiremanId == 0)
            {
                value.FiremanId = GetFiremanList().Count() > 0 ?GetFiremanList().Max(x => x.FiremanId) + 1 : 1;
                context.Firemans.Add(value);
            }
            else
            {
                Fireman fireman = GetFiremanList().FirstOrDefault(x => x.FiremanId == value.FiremanId);
                if(fireman !=null)
                {
                    fireman.Nazwisko = value.Nazwisko;
                    fireman.KursPodstawowy = value.KursPodstawowy;
                    fireman.KursTechniczny = value.KursTechniczny;
                    fireman.KursDowodcy = value.KursDowodcy;
                    fireman.KursPilarza = value.KursPilarza;
                    fireman.KPP = value.KPP;
                    fireman.PrawoJazdyC = value.PrawoJazdyC;
                }
            }
            context.SaveChanges();
            return true;
        }
        /// <summary>
        /// AddOrEditVehicles
        /// </summary>
        /// <param name="value">Pojazd</param>
        /// <returns>wartosc true</returns>
        /// <remarks>
        /// Metoda dodaje nowy lub edytuje juz istniejacy pojazd
        /// </remarks>
        public static bool AddOrEditVehicles(Vehicle value)
        {
            if (value.VehicleId == 0)
            {
                value.VehicleId = context.Vehicles.Count() > 0 ? context.Vehicles.Max(x => x.VehicleId) + 1 : 1;
                context.Vehicles.Add(value);
            }
            else
            {
                Vehicle vehicle = context.Vehicles.FirstOrDefault(x => x.VehicleId == value.VehicleId);
                if (vehicle != null)
                {
                    vehicle.Marka = value.Marka;
                    vehicle.Model = value.Model;
                    vehicle.IloscMiejsc = value.IloscMiejsc;
                    
                }
            }
            context.SaveChanges();
            return true;
        }

        /// <summary>
        /// AddOrEditAccidents
        /// </summary>
        /// <param name="value">wyjazd</param>
        /// <returns>wartosc true</returns>
        /// <remarks>
        /// Metoda dodaje nowy lub edytuje juz istniejacy wyjazd
        /// </remarks>
        public static bool AddOrEditAccidents( Accident value)
        {
            if(value.AccidentId == 0)
            {
                value.AccidentId = context.Accidents.Count() > 0 ? context.Vehicles.Max(x => x.VehicleId) + 1 : 1;
                context.Accidents.Add(value);

            }
            else
            {
                Accident accident = context.Accidents.FirstOrDefault(x => x.AccidentId == value.AccidentId);
                if(accident != null)
                {
                    accident.Opis = value.Opis;
                    accident.DataWyjazdu = value.DataWyjazdu;
                    accident.VehicleData = value.VehicleData;
                    accident.FiremanDataDowodca = value.FiremanDataDowodca;
                    accident.FiremanDataKierowca = value.FiremanDataKierowca;
                    accident.FiremanDataIRota = value.FiremanDataIRota;
                    accident.FiremanDataIRotaPomoc = value.FiremanDataIRotaPomoc;
                    accident.FiremanDataIIRota = value.FiremanDataIIRota;
                    accident.FiremanDataIIRotaPomoc = value.FiremanDataIIRotaPomoc;
                    accident.FiremanDataIIIRota = value.FiremanDataIIIRota;
                    accident.FiremanDataIIIRotaPomoc = value.FiremanDataIIIRotaPomoc;
                }
            }
            context.SaveChanges();
            return true;
        }
    }
}
