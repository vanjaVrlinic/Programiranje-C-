// Vanja Vrlinič, ITK 2 - VS, Št.indexa: E1065215
/* Izdelajte postopek, ki bo razvrstil štiri števila a, b, c in d od največjega do najmanjšega. Na začetku naj uporabnik vpiše vse štiri 
 * vrednosti, po končanem postopku pa naj se ta razvrščena števila izpišejo. V primeru, da imata dve ali več števil enako vrednost, naj se 
 * tako število izpiše samo enkrat. 
 * Primer:  Vhod: -5 4 -5 1
 *         Izhod: 4 1 -5  */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vrlinic_vanja_e1065215_naloga11_sklop1
{
    class Program
    {
        static void Main(string[] args)
        {
            //deklaracija spremenljivk
            int a, b, c, d;

            //branje podatkov iz konzole
            Console.WriteLine("Vnesite štiri cela števila!");
            Console.Write("Vnesite a: ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Vnesite b: ");
            b = int.Parse(Console.ReadLine());
            Console.Write("Vnesite c: ");
            c = int.Parse(Console.ReadLine());
            Console.Write("Vnesite d: ");
            d = int.Parse(Console.ReadLine());

            //preverjanje ali se vrednosti ponavljajo ter urejanje števil od največjega do najmanjšega
            if (a == b && a == c && a == d && b == c && b == d && c == d)
            {
                Console.WriteLine("Urejena števila od največjega do najmanjšega: {0}", a);
            }

            // preverjanje ponavljanja po dva in izpis dveh vrednosti
            if (a == b && a != c && a == d && b == d)
            {
                if (a < c)
                    Console.WriteLine("Urejena števila od največjega do najmanjšega: {0}, {1}", c, a);
                else
                    Console.WriteLine("Urejena števila od največjega do najmanjšega: {0}, {1}", a, c);
            }

            if (a == c && a != b && a == d && c == d)
            { 
                if(a < b)
                    Console.WriteLine("Urejena števila od največjega do najmanjšega: {0}, {1}", b, a);
                else
                    Console.WriteLine("Urejena števila od največjega do najmanjšega: {0}, {1}", a, b);
            }

            if (b == c && b == d && c == d && b != a)
            { 
                if(a < b)
                    Console.WriteLine("Urejena števila od največjega do najmanjšega: {0}, {1}", b, a);
                else
                    Console.WriteLine("Urejena števila od največjega do najmanjšega: {0}, {1}", a, b);
            }

            if (a != d && a == b && a == c && b == c)
            {
                if (a < d)
                    Console.WriteLine("Urejena števila od največjega do najmanjšega: {0}, {1}", d, a);
                else
                    Console.WriteLine("Urejena števila od največjega do najmanjšega: {0}, {1}", a, d);
            }

            if (a == b && d == c && a != d && a != c)
            {
                if (a < c)
                    Console.WriteLine("Urejena števila od največjega do najmanjšega: {0}, {1}", c, a);
                else
                    Console.WriteLine("Urejena števila od največjega do najmanjšega: {0}, {1}", a, c);
            }

            if (a == c && b == d && a != b && a != d)
            {
                if (a < b)
                    Console.WriteLine("Urejena števila od največjega do najmanjšega: {0}, {1}", b, a);
                else
                    Console.WriteLine("Urejena števila od največjega do najmanjšega: {0}, {1}", a, b);
            }

            if (a == d && b == c && a != b && a != c)
            {
                if (a < b)
                    Console.WriteLine("Urejena števila od največjega do najmanjšega: {0}, {1}", b, a);
                else
                    Console.WriteLine("Urejena števila od največjega do najmanjšega: {0}, {1}", a, b);
            }

            // preverjanje ponavljanja in izpis treh vrednosti
            if (a == b && a != c && a != d && c != d)
            {
                if (a < c && c < d && a < d)
                {
                    Console.WriteLine("Urejena števila od največjega do najmanjšega: {0}, {1}, {2}", d, c, a);
                }
                if (a > c && a > d && c > d)
                {
                    Console.WriteLine("Urejena števila od največjega do najmanjšega: {0}, {1}, {2}", a, c, d);
                }
                if (c > a && a > d && c > d)
                {
                    Console.WriteLine("Urejena števila od največjega do najmanjšega: {0}, {1}, {2}", c, a, d);
                }
                if (c > a && c > d && d > a)
                {
                    Console.WriteLine("Urejena števila od največjega do najmanjšega: {0}, {1}, {2}", c, d, a);
                }
                if (a > d && a > c && d > c)
                {
                    Console.WriteLine("Urejena števila od največjega do najmanjšega: {0}, {1}, {2}", a, d, c);
                }
                if (d > a && d > c && a > c)
                {
                    Console.WriteLine("Urejena števila od največjega do najmanjšega: {0}, {1}, {2}", d, a, c);
                }
            }

            if (a != b && a == c && a != d && b != d)
            {
                if (d < b && d < a && b < a)
                {
                    Console.WriteLine("Urejena števila od največjega do najmanjšega: {0}, {1}, {2}", a, b, d);
                }
                if (b < d && b < a && d < a)
                {
                    Console.WriteLine("Urejena števila od največjega do najmanjšega: {0}, {1}, {2}", a, d, b);
                }
                if (d < a && d < b && a < b)
                {
                    Console.WriteLine("Urejena števila od največjega do najmanjšega: {0}, {1}, {2}", b, a, d);
                }
                if (a < d && a < b && d < b)
                {
                    Console.WriteLine("Urejena števila od največjega do najmanjšega: {0}, {1}, {2}", b, d, a);
                }
                if (a < b && a < d && b < d)
                {
                    Console.WriteLine("Urejena števila od največjega do najmanjšega: {0}, {1}, {2}", d, b, a);
                }
                if (b < a && b < d && a < d)
                {
                    Console.WriteLine("Urejena števila od največjega do najmanjšega: {0}, {1}, {2}", d, a, b);
                }
            }

            if (a != b && a != c && a == d && b != c)
            {
                if (c < b && c < a && b < a)
                {
                    Console.WriteLine("Urejena števila od največjega do najmanjšega: {0}, {1}, {2}", a, b, c);
                }
                if (b < c && b < a && c < a)
                {
                    Console.WriteLine("Urejena števila od največjega do najmanjšega: {0}, {1}, {2}", a, c, b);
                }
                if (a < c && a < b && c < b)
                {
                    Console.WriteLine("Urejena števila od največjega do najmanjšega: {0}, {1}, {2}", b, c, a);
                }
                if (c < a && c < b && a < b)
                {
                    Console.WriteLine("Urejena števila od največjega do najmanjšega: {0}, {1}, {2}", b, a, c);
                }
                if (b < a && b < c && a < c)
                {
                    Console.WriteLine("Urejena števila od največjega do najmanjšega: {0}, {1}, {2}", c, a, b);
                }
                if (a < b && a < b && b < c)
                {
                    Console.WriteLine("Urejena števila od največjega do najmanjšega: {0}, {1}, {2}", c, b, a);
                }
            }

            // preverjanje ponavljanja in izpis štirih vrednosti
            if (a != b && a != c && a != d && b != c && b != d && c != d)
            {
                if (a < b && a < c && a < d && b < c && b < d && c < d)
                {
                    Console.WriteLine("Urejena števila od največjega do najmanjšega: {0}, {1}, {2}, {3}", d, c, b, a);
                }
                if (a < c && a < d && b < a && c < d && b < c && b < d)
                {
                    Console.WriteLine("Urejena števila od največjega do najmanjšega: {0}, {1}, {2}, {3}", d, c, a, b);
                }
                if (b < c && b < a && b < d && c < a && c < d && a < d)
                {
                    Console.WriteLine("Urejena števila od največjega do najmanjšega: {0}, {1}, {2}, {3}", d, a, c, b);
                }
                if (a < c && a < b && a < d && c < b && c < d && b < d)
                {
                    Console.WriteLine("Urejena števila od največjega do najmanjšega: {0}, {1}, {2}, {3}", d, b, c, a);
                }
                if (c < a && c < b && c < d && a < d && a < b && b < d)
                {
                    Console.WriteLine("Urejena števila od največjega do najmanjšega: {0}, {1}, {2}, {3}", d, b, a, c);
                }
                if (c < b && c < a && c < d && b < a && b < d && a < d)
                {
                    Console.WriteLine("Urejena števila od največjega do najmanjšega: {0}, {1}, {2}, {3}", d, a, b, c);
                }
                if (d < c && d < b && d < a && c < b && c < a && b < a)
                {
                    Console.WriteLine("Urejena števila od največjega do najmanjšega: {0}, {1}, {2}, {3}", a, b, c, d);
                }
                if (d < b && d < c && d < a && b < c && b < a && c < a)
                {
                    Console.WriteLine("Urejena števila od največjega do najmanjšega: {0}, {1}, {2}, {3}", a, c, b, d);
                }
                if (c < b && c < d && c < a && b < d && b < a && d < a)
                {
                    Console.WriteLine("Urejena števila od največjega do najmanjšega: {0}, {1}, {2}, {3}", a, d, b, c);
                }
                if (c < d && c < b && c < a && d < b && d < a && b < a)
                {
                    Console.WriteLine("Urejena števila od največjega do najmanjšega: {0}, {1}, {2}, {3}", a, b, d, c);
                }
                if (b < d && b < c && b < a && d < c && d < a && c < a)
                {
                    Console.WriteLine("Urejena števila od največjega do najmanjšega: {0}, {1}, {2}, {3}", a, c, d, b);
                }
                if (b < c && b < d && b < a && c < d && c < a && d < a)
                {
                    Console.WriteLine("Urejena števila od največjega do najmanjšega: {0}, {1}, {2}, {3}", a, d, c, b);
                }
                if (d < c && d < a && d < b && c < a && c < b && a < b)
                {
                    Console.WriteLine("Urejena števila od največjega do najmanjšega: {0}, {1}, {2}, {3}", b, a, c, d);
                }
                if (d < a && d < c && d < b && a < c && a < b && c < b)
                {
                    Console.WriteLine("Urejena števila od največjega do najmanjšega: {0}, {1}, {2}, {3}", b, c, a, d);
                }
                if (a < d && a < c && a < b && d < c && d < b && c < b)
                {
                    Console.WriteLine("Urejena števila od največjega do najmanjšega: {0}, {1}, {2}, {3}", b, c, d, a);
                }
                if (c < d && c < a && c < b && d < a && d < b && a < b)
                {
                    Console.WriteLine("Urejena števila od največjega do najmanjšega: {0}, {1}, {2}, {3}", b, a, d, c);
                }
                if (c < a && c < d && c < b && a < d && a < b && d < b)
                {
                    Console.WriteLine("Urejena števila od največjega do najmanjšega: {0}, {1}, {2}, {3}", b, d, a, c);
                }
                if (a < c && a < d && a < b && c < d && c < b && d < b)
                {
                    Console.WriteLine("Urejena števila od največjega do najmanjšega: {0}, {1}, {2}, {3}", b, d, c, a);
                }
                if (d < a && d < b && d < c && a < b && a < c && b < c)
                {
                    Console.WriteLine("Urejena števila od največjega do najmanjšega: {0}, {1}, {2}, {3}", c, b, a, d);
                }
                if (a < d && a < b && a < c && d < b && d < c && b < c)
                {
                    Console.WriteLine("Urejena števila od največjega do najmanjšega: {0}, {1}, {2}, {3}", c, b, d, a);
                }
                if (b < d && b < a && b < c && d < a && d < c && a < c)
                {
                    Console.WriteLine("Urejena števila od največjega do najmanjšega: {0}, {1}, {2}, {3}", c, a, d, b);
                }
                if (d < b && d < a && d < c && b < a && b < c && a < c)
                {
                    Console.WriteLine("Urejena števila od največjega do najmanjšega: {0}, {1}, {2}, {3}", c, a, b, d);
                }
                if (a < c && a < b && a < d && b < d && b < c && d < c)
                {
                    Console.WriteLine("Urejena števila od največjega do najmanjšega: {0}, {1}, {2}, {3}", c, d, b, a);
                }
                if (b < a && b < d && b < c && a < d && a < c && d < c)
                {
                    Console.WriteLine("Urejena števila od največjega do najmanjšega: {0}, {1}, {2}, {3}", c, d, a, b);
                }
            }
            Console.ReadLine();
        }
    }
}
