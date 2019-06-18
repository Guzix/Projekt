using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Statystyki_OSP.Dane
{
    [Table("Strazacy")]
    public class Fireman
    {
       
        int firemanId = 0;
        string nazwisko = "";
        DateTime dataUrodzenia = DateTime.Today;
        DateTime badaniaWazneDo = DateTime.Today;
        bool kursPodstawowy = false;
        bool kursTechniczny = false;
        bool kursDowodcy = false;
        bool kursPilarza = false;
        bool kpp = false;
        bool prawoJazdyC = false;

        [Key]
        public int FiremanId
        {
            get { return firemanId; }
            set { firemanId = value; }
        }
        public string Nazwisko
        {
            get { return nazwisko; }
            set { nazwisko = value; }
        }
        public DateTime DataUrodzenia
        {
            get { return dataUrodzenia ; }
            set { dataUrodzenia = value; }
        }
        public DateTime BadaniaWazneDo
        {
            get { return badaniaWazneDo; }
            set { badaniaWazneDo = value; }
        }
        public bool KursPodstawowy
        {
            get { return kursPodstawowy; }
            set {  kursPodstawowy= value; }
        }
        public bool KursTechniczny
        {
            get { return kursTechniczny; }
            set { kursTechniczny = value; }
        }
        public bool KursDowodcy
        {
            get { return kursDowodcy; }
            set {  kursDowodcy= value; }
        }
        public bool KursPilarza
        {
            get { return kursPilarza; }
            set { kursPilarza = value; }
        }
        public bool KPP
        {
            get { return kpp; }
            set { kpp = value; }
        }
        public bool PrawoJazdyC
        {
            get { return prawoJazdyC; }
            set {  prawoJazdyC= value; }
        }

    }
}
