using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Statystyki_OSP.Dane
{
    
    [Table("Pojazdy")]
    public class Vehicle
    {
        int vehicleId = 0; 
        string marka = "";
        string model = "";
        int iloscMiejsc = 0;

        [Key]
        public int VehicleId
        {
            get { return vehicleId; }
            set { vehicleId = value; }
        }
        public  string Marka
        {
            get { return marka; }
            set {  marka= value; }
        }
        public string Model
        {
            get { return model; }
            set {  model= value; }
        }
        public int IloscMiejsc
        {
            get { return iloscMiejsc; }
            set {  iloscMiejsc= value; }
        }
    }
}
