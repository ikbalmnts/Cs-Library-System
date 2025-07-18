using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quiz
{
    internal class KitaplikYonetim
    {
        private Kitaplik kitaplik;

        public KitaplikYonetim(Kitaplik kitaplik)
        {
            this.kitaplik = kitaplik;
        }

        public bool KitapSat(Kitap kitap, Kart kart)
        {
            double fiyat = kitap.kitapfiyati;
            bool odemeBasarili = kart.odemeYap(fiyat);
            if (odemeBasarili)
            {
                Console.WriteLine("Ödeme gerçekleştirildi.");
                return true;
            }
            else if (kart is OgrenciKarti ogrenciKart && ogrenciKart.getBonus() >= fiyat)
            {
                // Bonus ile ödeme
                ogrenciKart.odemeYap(fiyat);
                Console.WriteLine("Ödeme bonus ile gerçekleştirildi.");
                return true;
            }
            else
            {
                Console.WriteLine("Bakiye Yetersiz");
                return false;
            }
        }
    }
}