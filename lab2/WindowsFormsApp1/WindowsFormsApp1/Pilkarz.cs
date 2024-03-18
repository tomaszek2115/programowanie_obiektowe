using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Pilkarz
    {
        public string Imie { get; set; }
        public string Nazwisko { get; set; }
        public int Wiek { get; set; }
        public int Waga { get; set; }
        public int Wzrost { get; set; }
        public Pilkarz(string imie, string nazwisko, int wiek, int waga, int wzrost)
        {
            Imie = imie;
            Nazwisko = nazwisko;
            Wiek = wiek;
            Waga = waga;
            Wzrost = wzrost;
        }
        public override string ToString()
        {
            return $"{Nazwisko} {Imie}, {Wiek} lat, {Waga} kg, {Wzrost} cm";
        }
    }
}
