using poligon_3_9b_2026b;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace poligon3_9_2026b
{
    internal class Poligon
    {
        public int broj_temena;
        public Tacka[] teme;
        public Poligon(int n)
        {
            broj_temena = n;
            teme = new Tacka[n];
        }
        public static Poligon unos() 
        {
            Console.WriteLine("Koliko temena unosite?");
            int n = Convert.ToInt32(Console.ReadLine());
            Poligon novi = new Poligon(n);
            for (int i = 0; i < n; i++)
            {
                novi.teme[i] = new Tacka();
                Console.Write("A[{0}].x = ", i+1);
                novi.teme[i].x = Convert.ToInt32(Console.ReadLine());
                Console.Write("A[{0}].y = ", i+1);
                novi.teme[i].y = Convert.ToInt32(Console.ReadLine());
            }
            return novi;
        }
        public void stampa()
        {
            Console.WriteLine("Poligon ima {0} temena. Koordinate temena su: ", broj_temena);
            for (int i = 0; i < broj_temena; i++)
            {
                Console.WriteLine("A[{0}] = ({1},{2})", i+1, teme[i].x, teme[i].y);
            }
        }
        public void snimi()
        {
            StreamWriter sw = new StreamWriter("poligon.txt");
            sw.WriteLine(broj_temena);
            for ( int i = 0; i < broj_temena; i++)
            {
                sw.WriteLine(teme[i].x);
                sw.WriteLine(teme[i].y);
            }
            sw.Close();
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
    }
}
