using poligon_3_9b_2026b;
using poligon3_9_2026b;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poligon3_9_2026b
{
    internal class Vektor
    {
        public Tacka pocetak, kraj;
        public Vektor(Tacka A, Tacka B)
        {
            pocetak = A;
            kraj = B;
        }
        public Tacka Centriraj()
        {
            Tacka Nova = new Tacka(kraj.x - pocetak.x, kraj.y - pocetak.y);
            return Nova;
        }
        public static double SP(Vektor a, Vektor b)
        {
            Tacka aC = a.Centriraj();
            Tacka bC = b.Centriraj();
            return aC.x * bC.x + aC.y * bC.y;
        }
        public static double VP(Vektor a, Vektor b)
        {
            Tacka aC = a.Centriraj();
            Tacka bC = b.Centriraj();
            return aC.x * bC.y - bC.x * aC.y;
        }
        public double duzina()
        {
            Tacka A = this.Centriraj();
            double duzina = A.d();
            return duzina;
        }
        public static bool seku_se(Vektor a, Vektor b)
        {
            int a_b = Ravan.SIS(a, b.pocetak, b.kraj);
            int b_a = Ravan.SIS(b, a.pocetak, a.kraj);
            if ((a_b != 0) && (b_a != 0)) return true;
            return false;
        }
    }


}