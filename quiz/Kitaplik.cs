using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quiz
{
    internal class Kitaplik
    {
        private Raf[] raflar;

        public Kitaplik(int rafSayisi)
        {
            raflar = new Raf[rafSayisi];
            for (int i = 0; i < rafSayisi; i++)
            {
                raflar[i] = new Raf();
            }
        }

        public void kitapEkle(Kitap kitap, int rafNo)
        {
            if (rafNo >= 0 && rafNo < raflar.Length)
                raflar[rafNo].kitapEkle(kitap);
        }

        public void kitapSil(int rafNo, Kitap kitap)
        {
            if (rafNo >= 0 && rafNo < raflar.Length)
                raflar[rafNo].kitapSil(kitap);
        }

        public void kitapAra(string kitapAdi)
        {
            for (int i = 0; i < raflar.Length; i++)
            {
                if (raflar[i].kitapAra(kitapAdi) != null)
                {
                    Console.WriteLine($"Kitap {i}. Rafta");
                    return;
                }
            }
            Console.WriteLine("Kitap bulunamadı.");
        }

        public void tumRaflariGoster()
        {
            for (int i = 0; i < raflar.Length; i++)
            {
                Console.WriteLine($"{i}. Raf");
                Console.Write(raflar[i].ToString());
            }
        }

        public Raf[] getRaflar()
        {
            return raflar;
        }
    }
}
