using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quiz
{
    internal class YetiskinKarti:Kart
    {
        public YetiskinKarti(string id, string sahip, double bakiye) : base(id, sahip, bakiye)
        {
        }

        public override bool odemeYap(double tutar)
        {
            if (getBakiye() >= tutar)
            {
                setBakiye(getBakiye() - tutar);
                return true;
            }
            return false;
        }

        public override string ToString()
        {
            return $"Yetiskin Kart - ID: {getID()}, Sahip: {getSahip()}, Bakiye: {getBakiye():0.00}";
        }
    }
}
