using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PodroznikApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textBoxNazwaSamochodu.Text = "Nazwa...";
            textBoxSrednieSpalanie.Text = "6,00";
            textBoxCenaPaliwa.Text = "8,00";
            numericUpDownPojemnoscZbiornika.Value = 60.0m;
            numericUpDownSredniaPredkosc.Value = 60.0m;
        }

        private void buttonPrzelicz_Click(object sender, EventArgs e)
        {
            decimal sredniaPredkosc = numericUpDownSredniaPredkosc.Value;
            decimal pojemnoscZbiornika = Convert.ToDecimal(numericUpDownPojemnoscZbiornika.Value);
            decimal srednieSpalanie = Convert.ToDecimal(textBoxSrednieSpalanie.Text);
            decimal odleglosc;
            decimal cenaPaliwaZaLitr;

            bool czyUdanyKonwertCenyPaliwa = decimal.TryParse(textBoxCenaPaliwa.Text, out cenaPaliwaZaLitr);
            if (!czyUdanyKonwertCenyPaliwa)
            {
                cenaPaliwaZaLitr = 0;
            }

            Samochod samochod = new Samochod(textBoxNazwaSamochodu.Text, srednieSpalanie, sredniaPredkosc, pojemnoscZbiornika);

            if (textBoxPodroz1.Text != "")
            {
                odleglosc = numericUpDownIloscKmPodroz1.Value;
                Podroz podroz1 = new Podroz(textBoxPodroz1.Text, odleglosc, maskedTextBoxCzasWyjazduPodroz1.Text, sredniaPredkosc);
                labelCzasPodrozy1.Text = Convert.ToString(podroz1.obliczCzasPodrozy());
                labelCzasPrzyjazdu1.Text = Convert.ToString(podroz1.dodajCzasPodrozyDoGodzinyWyjazdu(podroz1.obliczCzasPodrozy()));
                samochod.zwiekszStanLicznika(odleglosc);
            }
            else
            {
                labelCzasPrzyjazdu1.Text = "00:00";
                labelCzasPodrozy1.Text = "0";
                numericUpDownIloscKmPodroz1.Value = 0;
            }

            if (textBoxPodroz2.Text != "")
            {
                odleglosc = numericUpDownIloscKmPodroz2.Value;
                Podroz podroz2 = new Podroz(textBoxPodroz2.Text, odleglosc, maskedTextBoxCzasWyjazduPodroz2.Text, sredniaPredkosc);
                labelCzasPodrozy2.Text = Convert.ToString(podroz2.obliczCzasPodrozy());
                labelCzasPrzyjazdu2.Text = Convert.ToString(podroz2.dodajCzasPodrozyDoGodzinyWyjazdu(podroz2.obliczCzasPodrozy()));
                samochod.zwiekszStanLicznika(odleglosc);
            }
            else
            {
                labelCzasPrzyjazdu2.Text = "00:00";
                labelCzasPodrozy2.Text = "0";
                numericUpDownIloscKmPodroz2.Value = 0;
            }

            if (textBoxPodroz3.Text != "")
            {
                odleglosc = numericUpDownIloscKmPodroz3.Value;
                Podroz podroz3 = new Podroz(textBoxPodroz3.Text, odleglosc, maskedTextBoxCzasWyjazduPodroz3.Text, sredniaPredkosc);
                labelCzasPodrozy3.Text = Convert.ToString(podroz3.obliczCzasPodrozy());
                labelCzasPrzyjazdu3.Text = Convert.ToString(podroz3.dodajCzasPodrozyDoGodzinyWyjazdu(podroz3.obliczCzasPodrozy()));
                samochod.zwiekszStanLicznika(odleglosc);
            }
            else
            {
                labelCzasPrzyjazdu3.Text = "00:00";
                labelCzasPodrozy3.Text = "0";
                numericUpDownIloscKmPodroz3.Value = 0;
            }

            if (textBoxPodroz4.Text != "")
            {
                odleglosc = numericUpDownIloscKmPodroz4.Value;
                Podroz podroz4 = new Podroz(textBoxPodroz4.Text, odleglosc, maskedTextBoxCzasWyjazduPodroz4.Text, sredniaPredkosc);
                labelCzasPodrozy4.Text = Convert.ToString(podroz4.obliczCzasPodrozy());
                labelCzasPrzyjazdu4.Text = Convert.ToString(podroz4.dodajCzasPodrozyDoGodzinyWyjazdu(podroz4.obliczCzasPodrozy()));
                samochod.zwiekszStanLicznika(odleglosc);
            }
            else
            {
                labelCzasPrzyjazdu4.Text = "00:00";
                labelCzasPodrozy4.Text = "0";
                numericUpDownIloscKmPodroz4.Value = 0;
            }

            if (textBoxPodroz5.Text != "")
            {
                odleglosc = numericUpDownIloscKmPodroz5.Value;
                Podroz podroz5 = new Podroz(textBoxPodroz5.Text, odleglosc, maskedTextBoxCzasWyjazduPodroz5.Text, sredniaPredkosc);
                labelCzasPodrozy5.Text = Convert.ToString(podroz5.obliczCzasPodrozy());
                labelCzasPrzyjazdu5.Text = Convert.ToString(podroz5.dodajCzasPodrozyDoGodzinyWyjazdu(podroz5.obliczCzasPodrozy()));
                samochod.zwiekszStanLicznika(odleglosc);
            }
            else
            {
                labelCzasPrzyjazdu5.Text = "00:00";
                labelCzasPodrozy5.Text = "0";
                numericUpDownIloscKmPodroz5.Value = 0;
            }

            if (textBoxPodroz6.Text != "")
            {
                odleglosc = numericUpDownIloscKmPodroz6.Value;
                Podroz podroz6 = new Podroz(textBoxPodroz6.Text, odleglosc, maskedTextBoxCzasWyjazduPodroz6.Text, sredniaPredkosc);
                labelCzasPodrozy6.Text = Convert.ToString(podroz6.obliczCzasPodrozy());
                labelCzasPrzyjazdu6.Text = Convert.ToString(podroz6.dodajCzasPodrozyDoGodzinyWyjazdu(podroz6.obliczCzasPodrozy()));
                samochod.zwiekszStanLicznika(odleglosc);
            }
            else
            {
                labelCzasPrzyjazdu6.Text = "00:00";
                labelCzasPodrozy6.Text = "0";
                numericUpDownIloscKmPodroz6.Value = 0;
            }

            if (textBoxPodroz7.Text != "")
            {
                odleglosc = numericUpDownIloscKmPodroz7.Value;
                Podroz podroz7 = new Podroz(textBoxPodroz7.Text, odleglosc, maskedTextBoxCzasWyjazduPodroz7.Text, sredniaPredkosc);
                labelCzasPodrozy7.Text = Convert.ToString(podroz7.obliczCzasPodrozy());
                labelCzasPrzyjazdu7.Text = Convert.ToString(podroz7.dodajCzasPodrozyDoGodzinyWyjazdu(podroz7.obliczCzasPodrozy()));
                samochod.zwiekszStanLicznika(odleglosc);
            }
            else
            {
                labelCzasPrzyjazdu7.Text = "00:00";
                labelCzasPodrozy7.Text = "0";
                numericUpDownIloscKmPodroz7.Value = 0;
            }

            if (textBoxPodroz8.Text != "")
            {
                odleglosc = numericUpDownIloscKmPodroz8.Value;
                Podroz podroz8 = new Podroz(textBoxPodroz8.Text, odleglosc, maskedTextBoxCzasWyjazduPodroz8.Text, sredniaPredkosc);
                labelCzasPodrozy8.Text = Convert.ToString(podroz8.obliczCzasPodrozy());
                labelCzasPrzyjazdu8.Text = Convert.ToString(podroz8.dodajCzasPodrozyDoGodzinyWyjazdu(podroz8.obliczCzasPodrozy()));
                samochod.zwiekszStanLicznika(odleglosc);
            }
            else
            {
                labelCzasPrzyjazdu8.Text = "00:00";
                labelCzasPodrozy8.Text = "0";
                numericUpDownIloscKmPodroz8.Value = 0;
            }

            if (textBoxPodroz9.Text != "")
            {
                odleglosc = numericUpDownIloscKmPodroz9.Value;
                Podroz podroz9 = new Podroz(textBoxPodroz9.Text, odleglosc, maskedTextBoxCzasWyjazduPodroz9.Text, sredniaPredkosc);
                labelCzasPodrozy9.Text = Convert.ToString(podroz9.obliczCzasPodrozy());
                labelCzasPrzyjazdu9.Text = Convert.ToString(podroz9.dodajCzasPodrozyDoGodzinyWyjazdu(podroz9.obliczCzasPodrozy()));
                samochod.zwiekszStanLicznika(odleglosc);
            }
            else
            {
                labelCzasPrzyjazdu9.Text = "00:00";
                labelCzasPodrozy9.Text = "0";
                numericUpDownIloscKmPodroz9.Value = 0;
            }

            if (textBoxPodroz10.Text != "")
            {
                odleglosc = numericUpDownIloscKmPodroz10.Value;
                Podroz podroz10 = new Podroz(textBoxPodroz10.Text, odleglosc, maskedTextBoxCzasWyjazduPodroz10.Text, sredniaPredkosc);
                labelCzasPodrozy10.Text = Convert.ToString(podroz10.obliczCzasPodrozy());
                labelCzasPrzyjazdu10.Text = Convert.ToString(podroz10.dodajCzasPodrozyDoGodzinyWyjazdu(podroz10.obliczCzasPodrozy()));
                samochod.zwiekszStanLicznika(odleglosc);
            }
            else
            {
                labelCzasPrzyjazdu10.Text = "00:00";
                labelCzasPodrozy10.Text = "0";
                numericUpDownIloscKmPodroz10.Value = 0;
            }

            if (textBoxPodroz11.Text != "")
            {
                odleglosc = numericUpDownIloscKmPodroz11.Value;
                Podroz podroz11 = new Podroz(textBoxPodroz11.Text, odleglosc, maskedTextBoxCzasWyjazduPodroz11.Text, sredniaPredkosc);
                labelCzasPodrozy11.Text = Convert.ToString(podroz11.obliczCzasPodrozy());
                labelCzasPrzyjazdu11.Text = Convert.ToString(podroz11.dodajCzasPodrozyDoGodzinyWyjazdu(podroz11.obliczCzasPodrozy()));
                samochod.zwiekszStanLicznika(odleglosc);
            }
            else
            {
                labelCzasPrzyjazdu11.Text = "00:00";
                labelCzasPodrozy11.Text = "0";
                numericUpDownIloscKmPodroz11.Value = 0;
            }

            if (textBoxPodroz12.Text != "")
            {
                odleglosc = numericUpDownIloscKmPodroz12.Value;
                Podroz podroz12 = new Podroz(textBoxPodroz12.Text, odleglosc, maskedTextBoxCzasWyjazduPodroz12.Text, sredniaPredkosc);
                labelCzasPodrozy12.Text = Convert.ToString(podroz12.obliczCzasPodrozy());
                labelCzasPrzyjazdu12.Text = Convert.ToString(podroz12.dodajCzasPodrozyDoGodzinyWyjazdu(podroz12.obliczCzasPodrozy()));
                samochod.zwiekszStanLicznika(odleglosc);
            }
            else
            {
                labelCzasPrzyjazdu12.Text = "00:00";
                labelCzasPodrozy12.Text = "0";
                numericUpDownIloscKmPodroz12.Value = 0;
            }

            Wycieczka wycieczka = new Wycieczka();
            labelIloscKm.Text = Convert.ToString(samochod.Licznik);
            labelIloscTankowan.Text = Convert.ToString(samochod.ileZbiornikowPaliwa());
            labelIloscZuzytegoPaliwa.Text = Convert.ToString(samochod.iloscZuzytegoPaliwa()) + "[l]";
            labelSzacunkowyKosztPodrozy.Text = Convert.ToString(wycieczka.kosztPodrozy(cenaPaliwaZaLitr, samochod.iloscZuzytegoPaliwa())) + "PLN";
            labelIloscGodzinPodrozy.Text = Convert.ToString(wycieczka.iloscGodzinPodrozy(samochod.Licznik, sredniaPredkosc)) + " hh:mm:ss";
        }
    }
}
