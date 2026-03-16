using poligon_3_9b_2026b;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poligon3_9_2026b
{
    internal class Vektor
    {
        Tacka pocetak, kraj;
        public Vektor(Tacka A, Tacka B) { pocetak = A; kraj = B; }
        public Tacka Centriraj()
        {
            Tacka Nova = new Tacka(kraj.x - pocetak.x, kraj.y - pocetak.y);
            return Nova;
        }

        public double SP(Vektor a, Vektor b)
        {
            Tacka aC = a.Centriraj();
            Tacka bC = b.Centriraj();
            return aC.x*bC.x + aC.y*bC.y;
        }
        public double VP(Vektor a, Vektor b)
        {
            Tacka aC = a.Centriraj();
            Tacka bC = b.Centriraj();
            return aC.x * bC.y - aC.y * bC.x;
        }
    }
}
