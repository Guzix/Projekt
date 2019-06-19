using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Statystyki_OSP.Dane
{


  
    [Table("Wyjazd")]
    public class Accident
    {

        int accidentId = 0;
        string opis = "";
        DateTime dataWyjazdu = DateTime.Now;
        

        [Key]
        public int AccidentId
        {
            get { return accidentId; }
            set { accidentId = value; }
        }
        public string Opis
        {
            get { return opis; }
            set { opis = value; }
        }

        public DateTime DataWyjazdu { get => dataWyjazdu; set => dataWyjazdu = value; }
      

        public virtual Vehicle VehicleData { get; set; }
        public virtual Fireman FiremanDataKierowca { get; set; }
        public virtual Fireman FiremanDataDowodca { get; set; }
        public virtual Fireman FiremanDataIRota { get; set; }
        public virtual Fireman FiremanDataIRotaPomoc { get; set; }
        public virtual Fireman FiremanDataIIRota { get; set; }
        public virtual Fireman FiremanDataIIRotaPomoc { get; set; }
        public virtual Fireman FiremanDataIIIRota { get; set; }
        public virtual Fireman FiremanDataIIIRotaPomoc { get; set; }


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
