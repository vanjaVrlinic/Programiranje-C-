// Vanja Vrlinič, ITK 2 - VS, Št.indexa: E1065215
/* Izdelajte postopek, ki poiščite vse realne rešitve kvadratne enačbe a*x2+b*x+c=0. Vhodni podatki so vrednosti a, b in c. Postopek naj 
 * izpiše, koliko realnih ničel ima kvadratna enačba (nobeno, eno ali dve). Nato naj rešitve izračuna in jih izpiše.
 * Opomba: dovoljena je uporaba Math.Sqrt(double). */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vrlinic_vanja_e1065215_naloga8_sklop1
{
    class Program
    {
        static void Main(string[] args)
        {
            //deklaracija spremenljivk
            double a, b, c;
            double x1, x2;
            double D = 0;

            //branje podatkov
            Console.WriteLine("Vnesite podatke za izračun kvadratne enačbe!");
            Console.Write("Vnesite a: ");
            a = double.Parse(Console.ReadLine());
            Console.Write("Vnesite b: ");
            b = double.Parse(Console.ReadLine());
            Console.Write("Vnesite c: ");
            c = double.Parse(Console.ReadLine());

            //izračun diskriminante
            D = (b * b) - 4 * a * c;

            //preverjanje diskriminante in izpis rešitev ter izračun ničel
            if (D > 0)
            {
                Console.WriteLine("Kvadratna enačba ima dve realni rešitvi!");
                x1 = (-b + Math.Sqrt(D)) / (2 * a);
                x2 = (-b - Math.Sqrt(D)) / (2 * a);
                Console.WriteLine("x1 = {0:0.00}    x2 = {1:0.00}", x1, x2);
            }
            if (D == 0)
            {
                Console.WriteLine("Kvadratna enačba ima eno realno rešitev!");
                x1 = (-b + Math.Sqrt(D)) / (2 * a);
                x2 = (-b - Math.Sqrt(D)) / (2 * a);
                Console.WriteLine("x1 = {0:0.00}    x2 = {1:0.00}", x1, x2);
            }
            if (D < 0)
            {
                Console.WriteLine("Kvadratna enačba nima realnih rešitev!");
                x1 = (-b + Math.Sqrt(D)) / (2 * a);
                x2 = (-b - Math.Sqrt(D)) / (2 * a);
                Console.WriteLine("x1 = {0:0.00}    x2 = {1:0.00}", x1, x2);
            }
            Console.ReadLine();
        }
    }
}
