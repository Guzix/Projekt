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
    /// Vehicle
    /// </summary>
    [Table("Pojazdy")]
    public class Vehicle
    {
        int vehicleId = 0; 
        string marka = "";
        string model = "";
        int iloscMiejsc = 0;

        /// <summary>
        /// VehicleId
        /// </summary>
        /// <remarks>
        /// Podaje lub zmienia wartosc pola vehicleId
        /// </remarks>
        [Key]
        public int VehicleId
        {
            get { return vehicleId; }
            set { vehicleId = value; }
        }
        /// <summary>
        /// Marka
        /// </summary>
        /// <remarks>
        /// Podaje lub zmienia wartosc pola marka
        /// </remarks>
        public string Marka
        {
            get { return marka; }
            set {  marka= value; }
        }
        /// <summary>
        /// Model
        /// </summary>
        /// <remarks>
        /// Podaje lub zmienia wartosc pola model
        /// </remarks>
        public string Model
        {
            get { return model; }
            set {  model= value; }
        }
        /// <summary>
        /// IloscMiejsc
        /// </summary>
        /// <remarks>
        /// Podaje lub zmienia wartosc pola iloscMiejsc
        /// </remarks>
        public int IloscMiejsc
        {
            get { return iloscMiejsc; }
            set {  iloscMiejsc= value; }
        }
    }
}
