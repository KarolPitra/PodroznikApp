using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PodroznikApp
{
    public class Podroz
    {
        string _nazwaMiasta;
        decimal _odleglosc;
        TimeSpan _czasWyjazdu;
        decimal _sredniaPredkosc;

        public Podroz(string nazwaMiasta, decimal odleglosc, string czasWyjazdu, decimal sredniaPredkosc)
        {
            this._nazwaMiasta = nazwaMiasta;
            this._odleglosc = odleglosc;
            this._czasWyjazdu = czasWyjazduConvertStringToTimeSpan(czasWyjazdu);
            this._sredniaPredkosc = sredniaPredkosc;
        }

        public int obliczCzasPodrozy()
        {
            decimal ileGodzin = 0;

            try
            {
                ileGodzin = (this._odleglosc / this._sredniaPredkosc);
            }
            catch (Exception)
            {
                MessageBox.Show("Błędna odległość lub srednia prękość!" 
                    + "\nOdległość: " + this._odleglosc + "[km]"
                    + "\nSrednia prędkość: " + this._sredniaPredkosc + "[km/h]", "Komunikat", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
            var ileMinut = ileGodzin * 60;
            return Convert.ToInt32(ileMinut);
        }

        public TimeSpan dodajCzasPodrozyDoGodzinyWyjazdu(int ileMinut)
        {
            TimeSpan czasPodrozy = new TimeSpan(0, ileMinut, 0);
            return this._czasWyjazdu.Add(czasPodrozy);
        }

        public TimeSpan czasWyjazduConvertStringToTimeSpan(string czasWyjazduString)
        {
            int godziny = 0;
            int minuty = 0;

            try
            {
                godziny = Convert.ToInt32(czasWyjazduString.Substring(0, 2));
                minuty = Convert.ToInt32(czasWyjazduString.Substring(3, 2));
            }
            catch (Exception)
            {
                MessageBox.Show("Błędny czas odjazdu: " + czasWyjazduString + "[hh:mm]", "Komunikat", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }           

            return new TimeSpan(godziny, minuty, 0);
        }
    }
}
