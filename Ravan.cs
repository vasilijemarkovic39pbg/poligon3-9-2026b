using poligon_3_9b_2026b;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poligon3_9_2026b
{
    internal class Ravan
    {
        public static int SIS(Vektor A, Tacka B, Tacka C)
        {
            // 0 sa iste strane prave
            //-1 sa raznih strana
            // 1 kolinearna bar jedna sa pravom/vektorom
            Vektor PB = new Vektor(A.pocetak, B);
            Vektor PC = new Vektor(A.pocetak, C);
            double PKPB = Vektor.VP(A, PB);
            double PKPC = Vektor.VP(A, PC);
            if (PKPB * PKPC > 0) return 0;
            if (PKPB * PKPC < 0) return -1;
            else return 1;
        }
    }
}
