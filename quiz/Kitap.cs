using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quiz
{
    internal class Kitap
    {
        public string ISBN { get; }
        public string kitapAdi { get; }
        public string kitapYazari { get; }
        public double kitapfiyati { get; }

        public Kitap(string ad, string yazar, string isbn, double fiyat)
        {
            this.kitapAdi = ad;
            this.kitapYazari = yazar;
            this.ISBN = isbn;
            this.kitapfiyati = fiyat;
        }

        public override string ToString()
        {
            return $"Ad {kitapAdi} Yazar {kitapYazari} ISBN {ISBN} Fiyat {kitapfiyati}";
        }
    }
}

