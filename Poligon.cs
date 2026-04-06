using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using poligon_3_9b_2026b;
using poligon3_9_2026b;

namespace poligon3_9_2026b
{
    internal class Poligon
    {
        public int br_temena;
        public Tacka[] teme;
        public Poligon(int n)
        {
            br_temena = n;
            teme = new Tacka[n];
        }
        public static Poligon unos()
        {
            Console.WriteLine("Koliko temena?");
            int n = Convert.ToInt32(Console.ReadLine());
            Poligon novi = new Poligon(n);
            for (int i = 0; i < n; i++)
            {
                novi.teme[i] = new Tacka();
                Console.WriteLine("T[{0}].x =", i + 1);
                novi.teme[i].x = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("y koord tacke T({0})=", i + 1);
                novi.teme[i].y = Convert.ToDouble(Console.ReadLine());
            }
            return novi;
        }
        public void stampa()
        {
            Console.WriteLine("Poligon ima {0} temena", br_temena);
            for (int i = 0; i < br_temena; i++)
            {
                Console.WriteLine("Koordinate {0}. tacke su x={1} i y={2}", i + 1, teme[i].x, teme[i].y);
            }
        }
        public void snimi()
        {
            StreamWriter izlaz = new StreamWriter("poligon.txt");
            izlaz.WriteLine(br_temena);
            for (int i = 0; i < br_temena; i++)
            {
                izlaz.WriteLine(teme[i].x);
                izlaz.WriteLine(teme[i].y);
            }
            izlaz.Close();
        }
        public static Poligon ucitaj()
        {
            StreamReader ulaz = new StreamReader("poligon.txt");
            int n = Convert.ToInt32(ulaz.ReadLine());
            Poligon novi = new Poligon(n);
            for (int i = 0; i < n; i++)
            {
                novi.teme[i] = new Tacka();
                novi.teme[i].x = Convert.ToDouble(ulaz.ReadLine());
                novi.teme[i].y = Convert.ToDouble(ulaz.ReadLine());
            }
            return novi;
        }
        public double obim()
        {
            Vektor a;
            double obim = 0;
            for (int i = 0; i < br_temena - 1; i++)
            {
                a = new Vektor(teme[i], teme[i + 1]);
                obim += a.duzina();
            }
            a = new Vektor(teme[br_temena - 1], teme[0]);
            obim += a.duzina();
            return obim;
        }
        public bool prost()
        {
            for (int i = 0; i < br_temena - 1; i++)
            {
                for (int j = i + 1; j < br_temena; j++)
                {
                    if (Tacka.jednake(teme[i], teme[j]))
                    {
                        return false;
                    }
                }
            }
            Vektor[] stranica = new Vektor[br_temena];
            for (int i = 0; i < br_temena - 1; i++)
            {
                stranica[i] = new Vektor(teme[i], teme[i + 1]);
            }
            stranica[br_temena - 1] = new Vektor(teme[br_temena - 1], teme[0]);
            for (int i = 0; i < br_temena; i++)
            {
                int kraj;
                if (i == 0) kraj = br_temena - 1;
                else kraj = br_temena;
                for (int j = i + 2; j < kraj; j++)
                {
                    if (Vektor.seku_se(stranica[i], stranica[j]))
                    {
                        return false;
                    }
                }
            }
            return true;
        }
    }
}