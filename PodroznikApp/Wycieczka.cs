using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PodroznikApp
{
    public class Wycieczka
    {

        public Wycieczka()
        {

        }

        public decimal kosztPodrozy(decimal cenaPaliwaZaLitr, decimal iloscZuzytegoPaliwa)
        {
            return cenaPaliwaZaLitr * iloscZuzytegoPaliwa;
        }

        public TimeSpan iloscGodzinPodrozy(decimal licznik, decimal sredniaPredkosc)
        {
            decimal ileGodzin = 0;

            try
            {
                ileGodzin = (licznik / sredniaPredkosc);
            }
            catch (Exception)
            {
                MessageBox.Show("Błędna odległość lub srednia prękość!"
                    + "\nOdległość: " + licznik + "[km]"
                    + "\nSrednia prędkość: " + sredniaPredkosc + "[km/h]", "Komunikat", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            var ileMinut = ileGodzin * 60;
            return new TimeSpan(0,Convert.ToInt32(ileMinut),0);
        }
    }
}
