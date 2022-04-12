using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace PodroznikApp.Test
{
    [TestClass]
    public class SamochodTest
    {
        [TestMethod]
        public void konstruktor()
        {
            var samochod = new Samochod("Peugeot", 6.6m, 66.0m, 60);
        }

        [TestMethod]
        public void ileKmNaPelnymZbiorniku()
        {
            var samochod = new Samochod("Peugeot", 6.0m, 66.0m, 60);
            var zasieg = samochod.zasiegNaPelnymZbiorniku();

            Assert.AreEqual(zasieg, 1000);
        }

        [TestMethod]
        public void ileZbiornikowPaliwaNaCalaPodroz()
        {
            var samochod = new Samochod("Peugeot", 6.0m, 66.0m, 60);
            samochod.zwiekszStanLicznika(6000);
            var ileZbiornikow = samochod.ileZbiornikowPaliwa();

            Assert.AreEqual(6, ileZbiornikow);
        }

        [TestMethod]
        public void ileZbiornikowPaliwaNaCalaPodrozKiedyJednaZLiczbJestZerem()
        {
            var samochod = new Samochod("Peugeot", 0, 0, 0);
            samochod.zwiekszStanLicznika(0);
            var ileZbiornokow = samochod.ileZbiornikowPaliwa();

            Assert.AreEqual(ileZbiornokow, 0);
        }

        [TestMethod]
        public void zwiekszStanLicznikaO100km()
        {
            var samochod = new Samochod("Peugeot", 0, 0, 0);
            samochod.zwiekszStanLicznika(100);
            var stanLicznika = samochod.Licznik;

            Assert.AreEqual(stanLicznika, 100);
        }

        [TestMethod]
        public void ileZuzytegoPaliwaNa100km()
        {
            var samochod = new Samochod("Peugeot", 6.00m, 0, 0);
            samochod.zwiekszStanLicznika(100);
            var iloscZuzytegoPaliwa = samochod.iloscZuzytegoPaliwa();

            Assert.AreEqual(iloscZuzytegoPaliwa, 6.00m);
        }

        [TestMethod]
        public void ileZuzytegoPaliwaNa1000km()
        {
            var samochod = new Samochod("Peugeot", 6.00m, 0, 0);
            samochod.zwiekszStanLicznika(1000);
            var iloscZuzytegoPaliwa = samochod.iloscZuzytegoPaliwa();

            Assert.AreEqual(iloscZuzytegoPaliwa, 60.00m);
        }
    }
}
