using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quiz
{
    internal class OgrenciKarti : Kart
    {
        private double bonus;

        public OgrenciKarti(string id, string sahip, double bakiye)
            : base(id, sahip, bakiye)
        {
            this.bonus = 0;
        }
        public override bool odemeYap(double tutar)
        {
            double toplamKullanilabilir = getBakiye() + bonus;

            if (toplamKullanilabilir >= tutar)
            {
                if (getBakiye() >= tutar)
                {
                    setBakiye(getBakiye() - tutar);
                    double kazanilanBonus = tutar * 0.25;
                    bonus += kazanilanBonus;
                }
                else
                {
                    double onceBakiye = getBakiye();
                    double kalan = tutar - onceBakiye;
                    setBakiye(0);
                    bonus -= kalan;
                }
                return true;
            }
            return false;
        }
        public double getBonus()
        {
            return bonus;
        }
        public override string ToString()
        {
            return $"Ogrenci Kart - ID: {getID()}, Sahip: {getSahip()}, Bakiye: {getBakiye():0.00}, Bonus: {bonus:0.00}";
        }
    }
}
