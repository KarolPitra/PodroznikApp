using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace PodroznikApp.Test
{
    [TestClass]
    public class PodrozTest
    {
        [TestMethod]
        public void konstruktor()
        {
            var podroz = new Podroz("Rzeszów", 75.0m, "12:55", 66);
        }

        [TestMethod]
        public void obliczCzasPodrozy()
        {
            var podroz = new Podroz("Rzeszów", 150.0m, "12:55", 75.0m);
            var ileMinut = podroz.obliczCzasPodrozy();

            Assert.AreEqual(ileMinut, 120);
        }

        [TestMethod]
        public void podajGodzinePrzyjazdu()
        {
            var podroz = new Podroz("Rzeszów", 75.0m, "12:55", 75.0m);
            var ileMinut = podroz.obliczCzasPodrozy();
            var godzinaPrzyjazdu = podroz.dodajCzasPodrozyDoGodzinyWyjazdu(ileMinut);

            Assert.AreEqual(godzinaPrzyjazdu, new TimeSpan(13,55,0));
        }

        [TestMethod]
        public void konwertujMaskedTextBoxDoTimeSpan()
        {
            var podroz = new Podroz("Rzeszów", 75.0m, "12:55", 75.0m);
            var timeSpanPoKonwersji = podroz.czasWyjazduConvertStringToTimeSpan("12:55");

            Assert.AreEqual(timeSpanPoKonwersji, new TimeSpan(12, 55, 0));
        }

        [TestMethod]
        public void konwertujMaskedTextBoxDoTimeSpanKiedyNieWypelnionoPolaPrzezUzytkownika()
        {
            var podroz = new Podroz("Rzeszów", 75.0m, "__:__", 75.0m);
            var timeSpanPoKonwersji = podroz.czasWyjazduConvertStringToTimeSpan("__:__");

            Assert.AreEqual(timeSpanPoKonwersji, new TimeSpan(0, 0, 0));
        }

        [TestMethod]
        public void obliczCzasPodrozyKiedyPodanoWartosci0()
        {
            var podroz = new Podroz("Rzeszów", 0, "__:__", 0);
            var ileMinut = podroz.obliczCzasPodrozy();

            Assert.AreEqual(ileMinut, 0);
        }
    }        
}
