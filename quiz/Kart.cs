using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quiz
{
    internal abstract class Kart
    {
        private string ID;
        private string sahip;
        private double bakiye;

        protected Kart(string id, string sahip, double bakiye)
        {
            this.ID = id;
            this.sahip = sahip;
            this.bakiye = bakiye;
        }
        public string getID()
        {
            return ID;
        }
        public string getSahip()
        {
            return sahip;
        }
        public double getBakiye()
        {
            return bakiye;
        }
        public void setBakiye(double yeniBakiye)
        {
            this.bakiye = yeniBakiye;
        }
        public abstract bool odemeYap(double tutar);
    }
}
