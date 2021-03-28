// Vanja Vrlinič, ITK 2 - VS, Št.index: E1065215
/* Izdelajte program, ki bo izračunal povprečno vrednost in standardni odklon vnesenih števil. Na začetku uporabnik vnese največ 20 
 * vrednosti. Vnos se lahko predhodno zaključi z vnosom vrednosti 0 (vrednost 0 pomeni prekinitev nadaljnjega vnašanja podatkov in se ne 
 * upošteva v izračun povprečne vrednosti ter standardnega odklona). Na koncu se izpiše povprečna vrednost ter standardni odklon. */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vrlinic_vanja_e1065215_naloga4_sklop2
{
    class Program
    {
        //podprogram za štetje vnesenih števil in preverjanje ali je vnesena vrednost 0
        static int StetjeStevil(double[] polje)
        {
            int stevec = 0;
            for (stevec = 0; stevec < polje.Length; stevec++)
            {
                if (polje[stevec] == 0)
                {
                    break;
                }
            }
            return stevec;
        }

        //prodprogram za izračun povprečne vrednosti
        static double PovprecnaVrednost(double[] polje)
        {
            double vsota = 0;

            for (int i = 0; i < polje.Length; i++)
            {
                vsota += polje[i] / StetjeStevil(polje);
            }
            return vsota;
        }

        //podprogram za izračun standardnega odklona
        static double StandardniOdklon(double[] polje)
        {
            //deklaracija spremenljivk
            double stevila = 0;
            double povprecjeKvadrat = Math.Pow(PovprecnaVrednost(polje), 2);
            double varianca;
            double standardniOdklon;

            //sprehod čez polje števil ter kvadriranje in seštevanje le teh
            foreach (int x in polje)
            {
                stevila += Math.Pow(x, 2);
            }

            varianca = (stevila / StetjeStevil(polje) - povprecjeKvadrat);
            standardniOdklon = Math.Sqrt(varianca);

            return standardniOdklon;
        }

        //glavni program
        static void Main(string[] args)
        {
            //deklaracija spremenljivk
            double[] polje = new double[20];
            int stevilo = 0;
            int stevec = 0;

            Console.WriteLine("Vnesite 20 števil. Vnos lahko predčasno prekinete z vnosom vrednosti 0!");

            //branje števil
            for (stevec = 0; stevec < polje.Length; stevec++)
            {
                Console.Write("Vnesite število {0}: ", stevec + 1);
                stevilo = int.Parse(Console.ReadLine());

                if (stevilo <= 0)
                {
                    break;
                }
                else
                {
                    polje[stevec] = stevilo;
                }
            }
                //preverimo, če ni bilo vneseno število javimo opozorilo, sicer izpišemo rezultate podprogramov
                if (polje[0] == 0)
                {
                    Console.WriteLine("Niste vnesli nobene vrednosti!");
                }
                else
                { 
                    Console.WriteLine("Frekvenca je: {0}", StetjeStevil(polje));
                    Console.WriteLine("Povprečna vrednost je: {0}", PovprecnaVrednost(polje));
                    Console.WriteLine("Standardni odklon je: {0}", StandardniOdklon(polje));
                }
                Console.ReadLine();
        }
    }
}
