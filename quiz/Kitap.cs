using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quiz
{
    internal class Kitap
    {
        private string ISBN;
        private string kitapAdi;
        private string kitapYazari;
        private double kitapfiyati;

        public Kitap(string ad, string yazar, string isbn, double fiyat)
        {
            this.kitapAdi = ad;
            this.kitapYazari = yazar;
            this.ISBN = isbn;
            this.kitapfiyati = fiyat;
        }

        public string getAd() => kitapAdi;
        public string getYazar() => kitapYazari;
        public string getISBN() => ISBN;
        public double getFiyat() => kitapfiyati;

        public override string ToString()
        {
            return $"Ad {kitapAdi} Yazar {kitapYazari} ISBN {ISBN} Fiyat {kitapfiyati}";
        }
    }
}

