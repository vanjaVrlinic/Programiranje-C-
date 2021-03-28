// Vanja Vrlinič, ITK VS - 2, Št.indexa: E1065215
/* Izdelajte program, ki bo prebral do 10 števil in si jih shranil v polje. Nato pa bo prebral še do 15 števil, in si jih shranil v 
 * drugo polje. Vnos podatkov lahko predhodno zaključimo z vnosom vrednosti 0 (vrednost 0 pomeni prekinitev nadaljnjega vnašanja podatkov 
 * in se naj ne upošteva pri zlivanju).
 * Program naj nato združi ti dve polji tako, da bo rezultat združitve/zlivanja eno samo polje. Končno polje naj bo tudi urejeno 
 * naraščajoče. Po končanem zlivanju in urejanju, naj se urejeno polje izpiše uporabniku. */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vrlinic_vanja_e1065215_naloga11_sklop2
{
    class Program
    {
        //Prodprogram za vnos 10-ih števil v prvo polje
        public static void VnosPrvegaPolja(int[] poljeStevil1)
        {
            int stevilo = 0;
            Console.WriteLine("Vnos lahko prečasno zaključite z vnosom števila 0!");
            Console.WriteLine("Vnesite do 10 števil v prvo polje!");

            for (int i = 0; i < poljeStevil1.Length; i++)
            {
                Console.Write("Vnesite število {0}: ", i + 1);
                stevilo = int.Parse(Console.ReadLine());
                if (stevilo == 0)
                {
                    break;
                }
                else
                {
                    poljeStevil1[i] = stevilo;
                }
            }
        }

        //Podprogram za vnos 15-ih števil v drugo polje
        public static void VnosDrugegaPolja(int[] poljeStevil2)
        {
            int stevilo = 0;
            Console.WriteLine("Vnesite do 15 števil v drugo polje!");

            for (int i = 0; i < poljeStevil2.Length; i++)
            {
                Console.Write("Vnesite število {0}: ", i + 1);
                stevilo = int.Parse(Console.ReadLine());
                if (stevilo == 0)
                {
                    break;
                }
                else
                {
                    poljeStevil2[i] = stevilo;
                }
            }
        }

        //Preštejemo koliko števil je v polju
        public static int VelikostPrvegaPolja(int[] poljeStevil1)
        {
            int stevec = 0;
            for (int i = 0; i < poljeStevil1.Length; i++)
            {
                if (poljeStevil1[i] != 0)
                {
                    stevec++;
                }
            }
            return stevec;
        }

        //Preštejemo koliko števil je v prvem polju, ki so večja od 0
        public static int[] SteviloStevilPrvega(int[] poljeStevil1)
        {
            int[] poljeBrezNicle1 = new int[VelikostPrvegaPolja(poljeStevil1)];
            int stevec = 0;

            for (int i = 0; i < poljeStevil1.Length; i++)
            {
                if (poljeStevil1[i] != 0)
                {
                    poljeBrezNicle1[stevec] = poljeStevil1[i];
                    stevec++;
                }
            }
            return poljeBrezNicle1;
        }

        //Preštejemo koliko števil je v drugem polju, ki so večja od 0
        public static int[] SteviloStevilDrugega(int[] poljeStevil2)
        {
            int[] poljeBrezNicle2 = new int[VelikostPrvegaPolja(poljeStevil2)];
            int stevec = 0;

            for (int i = 0; i < poljeStevil2.Length; i++)
            {
                if (poljeStevil2[i] != 0)
                {
                    poljeBrezNicle2[stevec] = poljeStevil2[i];
                    stevec++;
                }
            }
            return poljeBrezNicle2;
        }

        //Podprogram, ki združi obe polji v eno
        public static int[] Zdruzi(int[] poljeStevil1, int[] poljeStevil2, int[] zdruzenoPolje)
        {
            zdruzenoPolje = new int[VelikostPrvegaPolja(poljeStevil1) + VelikostPrvegaPolja(poljeStevil2)];
            for (int i = 0; i < poljeStevil1.Length; i++)
            {
                zdruzenoPolje[i] = poljeStevil1[i];
            }
            for (int i = 0; i < poljeStevil2.Length; i++)
            {
                zdruzenoPolje[poljeStevil1.Length+i] = poljeStevil2[i];
            }
            return zdruzenoPolje;
        }

        //Podprogram uredi združeno polje naraščajoče
        public static int[] Uredi(int[] zdruzenoPolje)
        {
            for (int i = 0; i < zdruzenoPolje.Length; i++)
            { 
                int najmansi = i;
                for (int j = i + 1; j < zdruzenoPolje.Length; j++)
                {
                    if (zdruzenoPolje[j] < zdruzenoPolje[najmansi])
                    {
                        najmansi = j;
                    }
                }
                int zacasna = zdruzenoPolje[i];
                zdruzenoPolje[i] = zdruzenoPolje[najmansi];
                zdruzenoPolje[najmansi] = zacasna;
            }
            return zdruzenoPolje;
        }

        //Glavni program
        static void Main(string[] args)
        {
            //deklaracija polj
            int[] poljeStevil1 = new int[10];
            int[] poljeStevil2 = new int[15];
            int[] zdruzenoPolje = new int[poljeStevil1.Length + poljeStevil2.Length];

            //Klic podprogramov
            VnosPrvegaPolja(poljeStevil1);
            VnosDrugegaPolja(poljeStevil2);

            poljeStevil1 = SteviloStevilPrvega(poljeStevil1);
            poljeStevil2 = SteviloStevilDrugega(poljeStevil2);

            zdruzenoPolje = Zdruzi(poljeStevil1, poljeStevil2, zdruzenoPolje);
            zdruzenoPolje = Uredi(zdruzenoPolje);

            //Izpis združenega polja naraščajoče
            if (zdruzenoPolje.Length == 0)
            {
                Console.WriteLine("Niste vnesli števil, zato je polje prazno!");
            }
            else
            {
                Console.WriteLine("Združeno polje urejeno naraščajoče: ");
                for (int i = 0; i < zdruzenoPolje.Length; i++)
                {
                    Console.WriteLine(zdruzenoPolje[i]);
                }
            }
            Console.ReadLine();
        }
    }
}
