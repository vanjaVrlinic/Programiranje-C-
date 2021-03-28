// Vanja Vrlinič, ITK 2 - VS, Št.indexa: E1065215
/* Izdelajte postopek, ki izračuna vsoto, razliko ter skalarni produkt dveh krajevnih vektorjev v ravnini. Vhodni podatki so koordinate 
 * dveh vektorjev. Kot rezultat naj se izpišejo koordinate njune vsote, njune razlike ter vrednost skalarnega produkta. */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vrlinic_vanja_e1065215_naloga4_sklop1
{
    class Program
    {
        static void Main(string[] args)
        {
            //deklaracija spremenljivk
            int k1, k2, k3, k4, k5, k6;
            int ko1;
            int ko2;
            int ko3;
            int kr1;
            int kr2;
            int kr3;
            int produkt;

            //branje koordinat vektorjev a in b
            Console.WriteLine("Vnesite koordinate vektorjev a=(k1, k2, k3) in b=(k4, k5, k6)!");
            Console.Write("Vnesite k1: ");
            k1 = int.Parse(Console.ReadLine());
            Console.Write("Vnesite k2: ");
            k2 = int.Parse(Console.ReadLine());
            Console.Write("Vnesite k3: ");
            k3 = int.Parse(Console.ReadLine());
            Console.Write("Vnesite k4: ");
            k4 = int.Parse(Console.ReadLine());
            Console.Write("Vnesite k5: ");
            k5 = int.Parse(Console.ReadLine());
            Console.Write("Vnesite k6: ");
            k6 = int.Parse(Console.ReadLine());

            //računanje vsote dveh vektorjev a + b
            ko1 = k1 + k4;
            ko2 = k2 + k5;
            ko3 = k3 + k6;

            //računanje razlike dveh vektorjev b - a
            kr1 = k4 - k1;
            kr2 = k5 - k2;
            kr3 = k6 - k3;

            //računanje skalarnega produkta dveh vektorjev a * b
            produkt = k1 * k4 + k2 * k5 + k3 * k6;

            //izpis dobljenih rezultatov: vsota, razlika, skalarni produkt
            Console.WriteLine("Vsota dveh vektorjev a + b = ({0}, {1}, {2})", ko1, ko2, ko3);
            Console.WriteLine("Razlika dveh vektorjev b - a = ({0}, {1}, {2})", kr1, kr2, kr3);
            Console.WriteLine("Skalarni produkt vektorjev a * b = {0}", produkt);

            Console.ReadLine();
        }
    }
}
