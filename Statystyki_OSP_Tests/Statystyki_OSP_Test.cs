using Microsoft.VisualStudio.TestTools.UnitTesting;
using Statystyki_OSP.Dane;
using Statystyki_OSP.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Statystyki_OSP_Tests
{
    [TestClass]
    class Statystyki_OSP_Test
    {
        [TestMethod]
        public void SaveFireman()
        {
            Fireman f1 = new Fireman {  Nazwisko = "Kuc", KursPodstawowy = true };
            Fireman f2 = new Fireman {  Nazwisko = "Filipiak", KursPodstawowy = false };

            DataContext.AddOrEditFiremans(f1);
            DataContext.AddOrEditFiremans(f2);

            Assert.AreEqual(DataContext.GetFiremanList().Count, 2);
            Assert.AreEqual(DataContext.GetFiremanList()[0], f1);
            Assert.AreEqual(DataContext.GetFiremanList()[1], f2);
            Assert.AreEqual(DataContext.GetFiremanList()[0].KursPodstawowy, true);
            Assert.AreEqual(DataContext.GetFiremanList()[1].KursPodstawowy, false);
        }

        public void SaveVehicle()
        {
            Vehicle v1 = new Vehicle { Marka = "Star", IloscMiejsc = 4 };
            Vehicle v2 = new Vehicle { Marka = "Man", IloscMiejsc = 1 };

            DataContext.AddOrEditVehicles(v1);
            DataContext.AddOrEditVehicles(v2);

            Assert.AreEqual(DataContext.GetVehiclesList().Count, 2);
            Assert.AreEqual(DataContext.GetVehiclesList()[0], v1);
            Assert.AreEqual(DataContext.GetVehiclesList()[1], v2);
            Assert.AreEqual(DataContext.GetVehiclesList()[0].IloscMiejsc,4);
            Assert.AreEqual(DataContext.GetVehiclesList()[1].IloscMiejsc,1);
        }
    }
}
