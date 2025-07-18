using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quiz
{
    internal class Raf
    {
        private List<Kitap> kitaplar;

        public Raf()
        {
            kitaplar = new List<Kitap>();
        }

        public void kitapEkle(Kitap kitap)
        {
            kitaplar.Add(kitap);
        }

        public void kitapSil(Kitap kitap)
        {
            kitaplar.Remove(kitap);
        }

        public Kitap kitapAra(string kitapAdi)
        {
            return kitaplar.Find(k => k.getAd() == kitapAdi);
        }

        public List<Kitap> getKitaplar()
        {
            return kitaplar;
        }

        public override string ToString()
        {
            if (kitaplar.Count == 0)
                return "Raf boş.";
            string sonuc = "";
            foreach (Kitap kitap in kitaplar)
            {
                sonuc += kitap.ToString() + "\n";
            }
            return sonuc;
        }
    }
}
