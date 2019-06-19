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
    /// Fireman
    /// </summary>
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

        /// <summary>
        /// FiremanId
        /// </summary>
        /// <remarks>
        /// Podaje lub zmienia wartosc pola firemanID
        /// </remarks>
        [Key]
        public int FiremanId
        {
            get { return firemanId; }
            set { firemanId = value; }
        }
        /// <summary>
        /// Nazwisko
        /// </summary>
        /// <remarks>
        /// Podaje lub zmienia wartosc pola nazwisko
        /// </remarks>
        public string Nazwisko
        {
            get { return nazwisko; }
            set { nazwisko = value; }
        }
        /// <summary>
        /// DataUrodzenia
        /// </summary>
        /// <remarks>
        /// Podaje lub zmienia wartosc pola dataUrodzenia
        /// </remarks>
        public DateTime DataUrodzenia
        {
            get { return dataUrodzenia ; }
            set { dataUrodzenia = value; }
        }
        /// <summary>
        /// BadaniaWazneDo
        /// </summary>
        /// <remarks>
        /// Podaje lub zmienia wartosc pola badaniaWazneDo
        /// </remarks>
        public DateTime BadaniaWazneDo
        {
            get { return badaniaWazneDo; }
            set { badaniaWazneDo = value; }
        }
        /// <summary>
        /// KursPodstawowy
        /// </summary>
        /// <remarks>
        /// Podaje lub zmienia wartosc pola kursPodstawowy
        /// </remarks>
        public bool KursPodstawowy
        {
            get { return kursPodstawowy; }
            set {  kursPodstawowy= value; }
        }
        /// <summary>
        /// KursTechniczny
        /// </summary>
        /// <remarks>
        /// Podaje lub zmienia wartosc pola kursTechniczny
        /// </remarks>
        public bool KursTechniczny
        {
            get { return kursTechniczny; }
            set { kursTechniczny = value; }
        }
        /// <summary>
        /// KursDowodcy
        /// </summary>
        /// <remarks>
        /// Podaje lub zmienia wartosc pola kursDowodcy
        /// </remarks>
        public bool KursDowodcy
        {
            get { return kursDowodcy; }
            set {  kursDowodcy= value; }
        }
        /// <summary>
        /// KursPilarza
        /// </summary>
        /// <remarks>
        /// Podaje lub zmienia wartosc pola kursPilarza
        /// </remarks>
        public bool KursPilarza
        {
            get { return kursPilarza; }
            set { kursPilarza = value; }
        }
        /// <summary>
        /// KPP
        /// </summary>
        /// <remarks>
        /// Podaje lub zmienia wartosc pola kpp
        /// </remarks>
        public bool KPP
        {
            get { return kpp; }
            set { kpp = value; }
        }
        /// <summary>
        /// PrawoJazdyC
        /// </summary>
        /// <remarks>
        /// Podaje lub zmienia wartosc pola prawoJazdyC
        /// </remarks>
        public bool PrawoJazdyC
        {
            get { return prawoJazdyC; }
            set {  prawoJazdyC= value; }
        }

    }
}
