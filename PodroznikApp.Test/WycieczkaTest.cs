using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace PodroznikApp.Test
{
    [TestClass]
    public class WycieczkaTest
    {

        [TestMethod]
        public void konstruktor()
        {
            var wycieczka = new Wycieczka();
        }

        [TestMethod]
        public void kosztPodrozyZa1000km()
        {
            var wycieczka = new Wycieczka();
            var koszt = wycieczka.kosztPodrozy(8.00m, 10);

            Assert.AreEqual(koszt, 80);
        }
    }
}
