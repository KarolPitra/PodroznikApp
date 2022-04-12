using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PodroznikApp
{
    public class Samochod
    {
        string _nazwaSamochodu;
        decimal _srednieSpalanie;
        decimal _sredniaPredkosc;
        decimal _pojemnoscZbiornika;
        decimal _stanLicznika;
        
        public decimal Licznik
        {
            get 
            {
                return _stanLicznika;
            }
            set { }
        }

        public Samochod(string nazwaSamochodu, decimal srednieSpalanie, decimal sredniaPredkosc, decimal pojemnoscZbiornika)
        {
            this._nazwaSamochodu = nazwaSamochodu;
            this._srednieSpalanie = srednieSpalanie;
            this._sredniaPredkosc = sredniaPredkosc;
            this._pojemnoscZbiornika = pojemnoscZbiornika;
        }

        public decimal zasiegNaPelnymZbiorniku()
        {
            var zasieg = this._pojemnoscZbiornika / this._srednieSpalanie * 100;
            return zasieg;
        }

        public decimal ileZbiornikowPaliwa()
        {
            decimal ileZbiornikow;

            try
            {
                ileZbiornikow = iloscZuzytegoPaliwa() / this._pojemnoscZbiornika;
            }
            catch (Exception)
            {

                ileZbiornikow = 0;
            }
            
            return ileZbiornikow;
        }

        public void zwiekszStanLicznika(decimal iloscKm)
        {
            this._stanLicznika += iloscKm;
        }

        public decimal iloscZuzytegoPaliwa()
        {
            decimal ileSetek;
            try
            {
                ileSetek = this._stanLicznika / 100;
            }
            catch (Exception)
            {

                ileSetek = 0;
            }

            return ileSetek*this._srednieSpalanie;
        }

    }
}
