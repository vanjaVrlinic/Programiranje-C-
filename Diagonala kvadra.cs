// Vanja Vrlinič, ITK 2 - VS, Št.indexa: E1065215
/* Izdelajte postopek, ki izračuna telesno diagonalo kvadra (uporabite Pitagorov izrek). Vhodni podatki so dolžine vseh treh stranic 
 * (a, b in c). Postopek naj preveri, ali so vhodni podatki veljavni (večji od nič). V primeru napačnih vrednosti vhodnih podatkov 
 * naj namesto rezultata izpiše opozorilo o napaki.  Opomba: dovoljeno je uporabiti Math.Sqrt(double). */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vrlinic_vanja_e1065215_naloga7_sklop1
{
    class Program
    {
        static void Main(string[] args)
        {
            //deklaracija spremenljivk
            double a, b, c;
            double diagonala = 0;

            //branje dolžine stranic
            Console.WriteLine("Vnesite dolžine stranic kvadra!");
            Console.Write("Vnesite a: ");
            a = double.Parse(Console.ReadLine());
            Console.Write("Vnesite b: ");
            b = double.Parse(Console.ReadLine());
            Console.Write("Vnesite c: ");
            c = double.Parse(Console.ReadLine());

            // preverjanje ali so vnesene vrednosti večje od nič
            if (a <= 0)
            {
                Console.WriteLine("Napaka! Vnesena vrednost a mora biti večja od 0!");
            }
            else
            {
                if (b <= 0)
                {
                    Console.WriteLine("Napaka! Vnesena vrednost b mora biti večja od 0!");
                }
                else
                {
                    if (c <= 0)
                    {
                        Console.WriteLine("Napaka! Vnesena vrednost c mora biti večja od 0!");
                    }
                    else
                    { 
                       // izračun telesne diagonale kvadra in izpis rezultata
                        diagonala = Math.Sqrt((a * a) + (b * b) + (c * c));
                        Console.WriteLine("Telesna diagonala kvadra: " + diagonala);
                    }
                }
            }
            Console.ReadLine();
        }
    }
}
