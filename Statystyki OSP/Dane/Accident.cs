using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Statystyki_OSP.Dane
{
    /// <summary>
    /// Accident
    /// </summary>
    [Table("Wyjazd")]
    public class Accident
    {

        int accidentId = 0;
        string opis = "";
        DateTime dataWyjazdu = DateTime.Now;

        /// <summary>
        /// AccidentId
        /// </summary>
        /// <remarks>
        /// Podaje lub zmienia wartosc pola accidentId
        /// </remarks>
        [Key]
        public int AccidentId
        {
            get { return accidentId; }
            set { accidentId = value; }
        }
        /// <summary>
        /// Opis
        /// </summary>
        /// <remarks>
        /// Podaje lub zmienia wartosc pola opis
        /// </remarks>
        public string Opis
        {
            get { return opis; }
            set { opis = value; }
        }
        /// <summary>
        /// DataWyjazdu
        /// </summary>
        /// <remarks>
        /// Podaje lub zmienia wartosc pola dataWyjazdu
        /// </remarks>

        public DateTime DataWyjazdu { get => dataWyjazdu; set => dataWyjazdu = value; }
      
        /// <summary>
        /// VehicleData
        /// </summary>
        /// <remarks>
        /// metoda wirtualna typu Vehice podaje lub zmienia wartosc pola
        /// </remarks>
        public virtual Vehicle VehicleData { get; set; }
        /// <summary>
        /// FiremanDataKierowca
        /// </summary>
        /// <remarks>
        /// metoda wirtualna typu fireman podaje lub zmienia wartosc pola
        /// </remarks>
        public virtual Fireman FiremanDataKierowca { get; set; }
        /// <summary>
        /// FiremanDataDowodca
        /// </summary>
        /// <remarks>
        /// metoda wirtualna typu fireman podaje lub zmienia wartosc pola
        /// </remarks>
        public virtual Fireman FiremanDataDowodca { get; set; }
        /// <summary>
        /// FiremanDataIRota
        /// </summary>
        /// <remarks>
        /// metoda wirtualna typu fireman podaje lub zmienia wartosc pola
        /// </remarks>
        public virtual Fireman FiremanDataIRota { get; set; }
        /// <summary>
        /// FiremanDataIRotaPomoc
        /// </summary>
        /// <remarks>
        /// metoda wirtualna typu fireman podaje lub zmienia wartosc pola
        /// </remarks>
        public virtual Fireman FiremanDataIRotaPomoc { get; set; }
        /// <summary>
        /// FiremanDataIIRota
        /// </summary>
        /// <remarks>
        /// metoda wirtualna typu fireman podaje lub zmienia wartosc pola
        /// </remarks>
        public virtual Fireman FiremanDataIIRota { get; set; }
        /// <summary>
        /// FiremanDataIIRotaPomoc
        /// </summary>
        /// <remarks>
        /// metoda wirtualna typu fireman podaje lub zmienia wartosc pola
        /// </remarks>
        public virtual Fireman FiremanDataIIRotaPomoc { get; set; }
        /// <summary>
        /// FiremanDataIIIRota
        /// </summary>
        /// <remarks>
        /// metoda wirtualna typu fireman podaje lub zmienia wartosc pola
        /// </remarks>
        public virtual Fireman FiremanDataIIIRota { get; set; }
        /// <summary>
        /// FiremanDataIIIRotaPomoc
        /// </summary>
        /// <remarks>
        /// metoda wirtualna typu fireman podaje lub zmienia wartosc pola
        /// </remarks>
        public virtual Fireman FiremanDataIIIRotaPomoc { get; set; }

        /// <summary>
        /// FiremanName
        /// </summary>
        /// <remarks>
        /// metoda zwracajaca nazwisko lub pusty string w przypadku gdy nie ma nazwiska
        /// </remarks>
        [NotMapped]
        public string FiremanNameKierowca
        {
            get
            {
                if (FiremanDataKierowca != null)
                    return FiremanDataKierowca.Nazwisko;
                else
                    return "";
            }
        }
        /// <summary>
        /// FiremanNameDowodca
        /// </summary>
        /// <remarks>
        /// metoda zwracajaca nazwisko lub pusty string w przypadku gdy nie ma nazwiska
        /// </remarks>
        [NotMapped]
        public string FiremanNameDowodca
        {
            get
            {
                if (FiremanDataDowodca != null)
                    return FiremanDataDowodca.Nazwisko;
                else
                    return "";
            }
        }
        /// <summary>
        /// FiremanNameIRota
        /// </summary>
        /// <remarks>
        /// metoda zwracajaca nazwisko lub pusty string w przypadku gdy nie ma nazwiska
        /// </remarks>
        [NotMapped]
        public string FiremanNameIRota
        {
            get
            {
                if (FiremanDataIRota != null)
                    return FiremanDataIRota.Nazwisko;
                else
                    return "";
            }
        }
        /// <summary>
        /// FiremanNameIRotaPomoc
        /// </summary>
        /// <remarks>
        /// metoda zwracajaca nazwisko lub pusty string w przypadku gdy nie ma nazwiska
        /// </remarks>
        [NotMapped]
        public string FiremanNameIRotaPomoc
        {
            get
            {
                if (FiremanDataIRotaPomoc != null)
                    return FiremanDataIRotaPomoc.Nazwisko;
                else
                    return "";
            }
        }
        /// <summary>
        /// FiremanNameIIRota
        /// </summary>
        /// <remarks>
        /// metoda zwracajaca nazwisko lub pusty string w przypadku gdy nie ma nazwiska
        /// </remarks>
        [NotMapped]
        public string FiremanNameIIRota
        {
            get
            {
                if (FiremanDataIIRota != null)
                    return FiremanDataIIRota.Nazwisko;
                else
                    return "";
            }
        }
        /// <summary>
        /// FiremanNameIIRotaPomoc
        /// </summary>
        /// <remarks>
        /// metoda zwracajaca nazwisko lub pusty string w przypadku gdy nie ma nazwiska
        /// </remarks>
        [NotMapped]
        public string FiremanNameIIRotaPomoc
        {
            get
            {
                if (FiremanDataIIRotaPomoc != null)
                    return FiremanDataIIRotaPomoc.Nazwisko;
                else
                    return "";
            }
        }
        /// <summary>
        /// FiremanNameIIIRota
        /// </summary>
        /// <remarks>
        /// metoda zwracajaca nazwisko lub pusty string w przypadku gdy nie ma nazwiska
        /// </remarks>
        [NotMapped]
        public string FiremanNameIIIRota
        {
            get
            {
                if (FiremanDataIIIRota != null)
                    return FiremanDataIIIRota.Nazwisko;
                else
                    return "";
            }
        }
        /// <summary>
        /// FiremanNameIIIRotaPomoc
        /// </summary>
        /// <remarks>
        /// metoda zwracajaca nazwisko lub pusty string w przypadku gdy nie ma nazwiska
        /// </remarks>
        [NotMapped]
        public string FiremanNameIIIRotaPomoc
        {
            get
            {
                if (FiremanDataIIIRotaPomoc != null)
                    return FiremanDataIIIRotaPomoc.Nazwisko;
                else
                    return "";
            }
        }
        /// <summary>
        /// VehicleModel
        /// </summary>
        /// <remarks>
        /// metoda zwracajaca marke lub pusty string w przypadku gdy nie ma marki
        /// </remarks>

        [NotMapped]
        public string VehicleModel
        { 
            get
            {
                if (VehicleData != null)
                    return VehicleData.Marka;
                else
                    return "";
            }
        }
    }
}
