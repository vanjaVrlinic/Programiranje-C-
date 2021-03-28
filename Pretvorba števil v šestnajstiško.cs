// Vanja Vrlinič, ITK VS - 2, Št. indexa: E1065215
/* Potrebno je implementirati:
     * podprogram za pretvorbo iz naravnega v šestnajstiško število,
     * podprogram za pretvorbo iz šestnajstiškega v naravno število,
     * podprogram za izračun vsote dveh šestnajstiških števil.
Prvi podprogram prejme naravno število in ga pretvori v šestnajstiško število ter ga vrne [v obliki niza znakov].
Drugi podprogram prejme šestnajstiško število [v obliki niza znakov], ga pretvori v naravno število ter ga vrne.
Tretji podprogram prejme dva niza šestnajstiških števk ter izračuna in vrne vsoto teh dveh šestnajstiških števil [v obliki niza znakov].
V glavnem programu boste uporabniku ponudili izbiro podprograma, ki naj se izvrši. Poskrbite, da bo uporabnik pri posamezni izbiri vpisal samo tisto, kar izbrani podprogram 
zahteva (v primeru, da je zahtevan vpis šestnajstiškega števila in uporabnik vpiše kakšen znak, ki mu ne pripada, naj se izpiše napaka). Rezultat, ki ga vrne podprogram, v 
glavnem programu nato izpišite uporabniku. Opomba: pri 3. podprogramu, si lahko pomagate z uporabo 1. in 2. podprograma.
Opomba 2: metod, ki samodejno pretvarjajo števila med posameznimi številskimi osnovami, ni dovoljeno uporabiti (npr. Convert.ToInt32()). Lahko jih uporabite samo v primeru, če 
jih implementirate sami.  */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vrlinic_vanja_e1065215_naloga1_sklop3
{
    class Program
    {
        //podprogram pretvori naravno število v šestnajstiško število
        public static string[] PretvorbaIzNaravnegaŠest(int stevilo, int[] poljeOstankov, string[] poljeSest, string[] sestPolje)
        { 
            int[] poljeStevil = new int[16];
            int ostanek;
            int stevec = 0;
            int index = 0;
            
            //pridobimo polje stevil deljivih s 16
            while (stevilo > 0)
            {
                poljeStevil[stevec] = stevilo;
                stevilo = stevilo / 16;
                stevec++;
            }

            //pridobimo polje ostankov
            for (int i = 0; i < poljeStevil.Length; i++)
            {
                ostanek = poljeStevil[i] % 16;
                poljeOstankov[index] = ostanek;
                index++;
            }

            //pretvorimo iz int v string
            for (int j = 0; j < poljeSest.Length; j++)
            {
                poljeSest[j] = poljeOstankov[j].ToString();
            }

            int stev = 0;
            //v polje shranimo vrednosti, ki jih bomo izpisali oz. zamenjamo vrednosti za črke 
            for (int k = 0; k < poljeSest.Length; k++)
            {
                if (poljeSest[k] == "0" || poljeSest[k] == "1" || poljeSest[k] == "2" ||poljeSest[k] == "3" ||poljeSest[k] == "4" ||poljeSest[k] == "5" ||poljeSest[k] == "6" ||poljeSest[k] == "7" ||poljeSest[k] == "8" ||poljeSest[k] == "9")
                {
                    sestPolje[stev] = poljeSest[k];
                    stev++;
                }
                else if (poljeSest[k] == "10")
                {
                    sestPolje[stev] = "A";
                    stev++;
                }
                else if (poljeSest[k] == "11")
                {
                    sestPolje[stev] = "B";
                    stev++;
                }
                else if (poljeSest[k] == "12")
                {
                    sestPolje[stev] = "C";
                    stev++;
                }
                else if (poljeSest[k] == "13")
                {
                    sestPolje[stev] = "D";
                    stev++;
                }
                else if (poljeSest[k] == "14")
                {
                    sestPolje[stev] = "E";
                    stev++;
                }
                else if (poljeSest[k] == "15")
                {
                    sestPolje[stev] = "F";
                    stev++;
                }
            }
            return sestPolje;
        }

        //podprogram pretvori šestnajstiško število v naravno število
        public static double PretvorbaIzŠestNaravno(char[] stevilo)
        {
            int[] poljeStevil = new int[stevilo.Length];

            //primerjanje znakov in shranjevanje njihovih vrednosti v polje stevil
            for (int i = 0; i < stevilo.Length; i++)
            {
                switch (stevilo[i])
                {
                    case '1': poljeStevil[i] = 1;
                        break;
                    case '2': poljeStevil[i] = 2;
                        break;
                    case '3': poljeStevil[i] = 3;
                        break;
                    case '4': poljeStevil[i] = 4;
                        break;
                    case '5': poljeStevil[i] = 5;
                        break;
                    case '6': poljeStevil[i] = 6;
                        break;
                    case '7': poljeStevil[i] = 7;
                        break;
                    case '8': poljeStevil[i] = 8;
                        break;
                    case '9': poljeStevil[i] = 9;
                        break;
                    case 'A': poljeStevil[i] = 10;
                        break;
                    case 'B': poljeStevil[i] = 11;
                        break;
                    case 'C': poljeStevil[i] = 12;
                        break;
                    case 'D': poljeStevil[i] = 13;
                        break;
                    case 'E': poljeStevil[i] = 14;
                        break;
                    case 'F': poljeStevil[i] = 15;
                        break;
                    default:
                        break;
                }
            }

            double rezultat = 0.0;
            //števila iz polja po vrsti množimo z 16^n in zmnožke seštevamo
            for (int j = 0; j < poljeStevil.Length; j++)
            {
                rezultat += poljeStevil[j] * Math.Pow(16, j);
            }
           
            return rezultat;
        }

        //podprogram izračuna vsoto dveh šestnajstiških števil
        public static string[] IzracunVsote(char[] stevilo1, char[] stevilo2, int[] poljeOstank, string[] poljeSe, string[] sesPolje)
        {
            double rezultat1 = 0.0;
            double rezultat2 = 0.0;
            int rezultat = 0;

            int[] poljeStevil = new int[stevilo1.Length];
            int[] poljeStevil2 = new int[stevilo2.Length];

            //primerjanje znakov in shranjevanje njihovih vrednosti v polje stevil
            for (int i = 0; i < stevilo1.Length; i++)
            {
                switch (stevilo1[i])
                {
                    case '1': poljeStevil[i] = 1;
                        break;
                    case '2': poljeStevil[i] = 2;
                        break;
                    case '3': poljeStevil[i] = 3;
                        break;
                    case '4': poljeStevil[i] = 4;
                        break;
                    case '5': poljeStevil[i] = 5;
                        break;
                    case '6': poljeStevil[i] = 6;
                        break;
                    case '7': poljeStevil[i] = 7;
                        break;
                    case '8': poljeStevil[i] = 8;
                        break;
                    case '9': poljeStevil[i] = 9;
                        break;
                    case 'A': poljeStevil[i] = 10;
                        break;
                    case 'B': poljeStevil[i] = 11;
                        break;
                    case 'C': poljeStevil[i] = 12;
                        break;
                    case 'D': poljeStevil[i] = 13;
                        break;
                    case 'E': poljeStevil[i] = 14;
                        break;
                    case 'F': poljeStevil[i] = 15;
                        break;
                    default:
                        break;
                }
            }

            //števila iz polja po vrsti množimo z 16^n in zmnožke seštevamo
            for (int j = 0; j < poljeStevil.Length; j++)
            {
                rezultat1 += poljeStevil[j] * Math.Pow(16, j);
            }

            //primerjanje znakov in shranjevanje njihovih vrednosti v polje stevil
            for (int i = 0; i < stevilo2.Length; i++)
            {
                switch (stevilo2[i])
                {
                    case '1': poljeStevil2[i] = 1;
                        break;
                    case '2': poljeStevil2[i] = 2;
                        break;
                    case '3': poljeStevil2[i] = 3;
                        break;
                    case '4': poljeStevil2[i] = 4;
                        break;
                    case '5': poljeStevil2[i] = 5;
                        break;
                    case '6': poljeStevil2[i] = 6;
                        break;
                    case '7': poljeStevil2[i] = 7;
                        break;
                    case '8': poljeStevil2[i] = 8;
                        break;
                    case '9': poljeStevil2[i] = 9;
                        break;
                    case 'A': poljeStevil2[i] = 10;
                        break;
                    case 'B': poljeStevil2[i] = 11;
                        break;
                    case 'C': poljeStevil2[i] = 12;
                        break;
                    case 'D': poljeStevil2[i] = 13;
                        break;
                    case 'E': poljeStevil2[i] = 14;
                        break;
                    case 'F': poljeStevil2[i] = 15;
                        break;
                    default:
                        break;
                }
            }
            //števila iz polja po vrsti množimo z 16^n in zmnožke seštevamo
            for (int j = 0; j < poljeStevil2.Length; j++)
            {
                rezultat2 += poljeStevil2[j] * Math.Pow(16, j);
            }
            //rezultat tipa intiger
            rezultat = (int)rezultat1 + (int)rezultat2;

            //pretvorba rezultata v šestnajstiško število
            int[] poljeSestnajst = new int[16];
            int ostanek;
            int stevec = 0;
            int index = 0;

            //pridobimo polje stevil deljivih s 16
            while (rezultat > 0)
            {
                poljeSestnajst[stevec] = rezultat;
                rezultat = rezultat / 16;
                stevec++;
            }

            //pridobimo polje ostankov
            for (int i = 0; i < poljeSestnajst.Length; i++)
            {
                ostanek = poljeSestnajst[i] % 16;
                poljeOstank[index] = ostanek;
                index++;
            }

            //pretvorimo iz int v string
            for (int j = 0; j < poljeSe.Length; j++)
            {
                poljeSe[j] = poljeOstank[j].ToString();
            }

            int stev = 0;
            //v polje shranimo vrednosti, ki jih bomo izpisali oz. zamenjamo vrednosti za črke 
            for (int k = 0; k < poljeSe.Length; k++)
            {
                if (poljeSe[k] == "0" || poljeSe[k] == "1" || poljeSe[k] == "2" || poljeSe[k] == "3" || poljeSe[k] == "4" || poljeSe[k] == "5" || poljeSe[k] == "6" || poljeSe[k] == "7" || poljeSe[k] == "8" || poljeSe[k] == "9")
                {
                    sesPolje[stev] = poljeSe[k];
                    stev++;
                }
                else if (poljeSe[k] == "10")
                {
                    sesPolje[stev] = "A";
                    stev++;
                }
                else if (poljeSe[k] == "11")
                {
                    sesPolje[stev] = "B";
                    stev++;
                }
                else if (poljeSe[k] == "12")
                {
                    sesPolje[stev] = "C";
                    stev++;
                }
                else if (poljeSe[k] == "13")
                {
                    sesPolje[stev] = "D";
                    stev++;
                }
                else if (poljeSe[k] == "14")
                {
                    sesPolje[stev] = "E";
                    stev++;
                }
                else if (poljeSe[k] == "15")
                {
                    sesPolje[stev] = "F";
                    stev++;
                }
            }
            return sesPolje;
        }
        static void Main(string[] args)
        {
            int niz;
            //Uporabnik izbere eno od možnosti
            do
            {
                Console.WriteLine("Izberite eno izmed naslednjih možnosti: ");
                Console.WriteLine("1 - pretvorba iz naravnega v šestnajstiško število!");
                Console.WriteLine("2 - pretvorba iz šestnajstiškega v naravno število!");
                Console.WriteLine("3 - izračun vsote dveh šestnajstiških števil!");
                Console.Write("Vaša izbira: ");
                niz = int.Parse(Console.ReadLine());
                //Zanka se ponavlja dokler ni vnesena izbira 1 ali 2 ali 3
            } while (!(niz == 1 || niz == 2 || niz == 3));  

            if (niz == 1)
            {
                int[] poljeOstankov = new int[16];
                string[] poljeSest = new string[16];
                string[] sestPolje = new string[16];

                //preberemo naravno število
                int stevilo;
                Console.Write("Vnesite naravno število: ");
                stevilo = int.Parse(Console.ReadLine());

                Console.Write("Rezultat: ");
                //klic podprograma
                PretvorbaIzNaravnegaŠest(stevilo, poljeOstankov, poljeSest, sestPolje);

                //izpišemo rezultat
                for (int i = 0; i < sestPolje.Length; i++)
                {
                    if (sestPolje[i] != "0")
                    {
                        Console.Write(sestPolje[i]);
                    }
                }
            }
            else if (niz == 2)
            {
                //preberemo šestnajstiško število
                Console.Write("Vnesite šestnajstiško število: ");
                string besedilo = Console.ReadLine();

                char[] stevilo = new char[besedilo.Length];
                //Vsak znak iz niza prepišemo v polje znakov
                for (int i = 0; i < stevilo.Length; i++)
                { 
                    stevilo[i] = besedilo[i];
                }

                //javljanje napake ob napačnem vnosu za drugo število
                for (int j = 0; j < stevilo.Length; j++)
                {
                    if (stevilo[j] != '0' && stevilo[j] != '1' && stevilo[j] != '2' && stevilo[j] != '3' && stevilo[j] != '4' && stevilo[j] != '5' && stevilo[j] != '6' && stevilo[j] != '7' && stevilo[j] != '8' && stevilo[j] != '9' && stevilo[j] != 'A' && stevilo[j] != 'B' && stevilo[j] != 'C' && stevilo[j] != 'D' && stevilo[j] != 'E' && stevilo[j] != 'F')
                    {
                        Console.WriteLine("Napaka! Vnesli ste nepravilne podatke!");
                        return;
                    }
                }
                //s klicem podprograma izpišemo rezultat
                Console.Write("Rezultat: {0} ", PretvorbaIzŠestNaravno(stevilo));
            }
            else if (niz == 3)
            {
                int[] poljeOstank = new int[16];
                string[] poljeSe = new string[poljeOstank.Length];
                string[] sesPolje = new string[poljeSe.Length];

                //preberemo prvo šestnajstiško število
                Console.Write("Vnesite prvo šestnajstiško število: ");
                string besedilo1 = Console.ReadLine();

                char[] stevilo1 = new char[besedilo1.Length];
                //Vsak znak iz niza prepišemo v polje znakov
                for (int i = 0; i < stevilo1.Length; i++)
                {
                    stevilo1[i] = besedilo1[i];
                }

                //javljanje napake ob napačnem vnosu za drugo število
                for (int z = 0; z < stevilo1.Length; z++)
                {
                    if (stevilo1[z] != '0' && stevilo1[z] != '1' && stevilo1[z] != '2' && stevilo1[z] != '3' && stevilo1[z] != '4' && stevilo1[z] != '5' && stevilo1[z] != '6' && stevilo1[z] != '7' && stevilo1[z] != '8' && stevilo1[z] != '9' && stevilo1[z] != 'A' && stevilo1[z] != 'B' && stevilo1[z] != 'C' && stevilo1[z] != 'D' && stevilo1[z] != 'E' && stevilo1[z] != 'F')
                    {
                        Console.WriteLine("Napaka! Vnesli ste nepravilne podatke!");
                        return;
                    }
                }

                //preberemo drugo šestnajstiško število
                Console.Write("Vnesite drugo šestnajstiško število: ");
                string besedilo2 = Console.ReadLine();

                char[] stevilo2 = new char[besedilo2.Length];
                //Vsak znak iz niza prepišemo v polje znakov
                for (int i = 0; i < stevilo2.Length; i++)
                {
                    stevilo2[i] = besedilo2[i];
                }

                //javljanje napake ob napačnem vnosu za drugo število
                for (int k = 0; k < stevilo2.Length; k++)
                {
                    if (stevilo2[k] != '0' && stevilo2[k] != '1' && stevilo2[k] != '2' && stevilo2[k] != '3' && stevilo2[k] != '4' && stevilo2[k] != '5' && stevilo2[k] != '6' && stevilo2[k] != '7' && stevilo2[k] != '8' && stevilo2[k] != '9' && stevilo2[k] != 'A' && stevilo2[k] != 'B' && stevilo2[k] != 'C' && stevilo2[k] != 'D' && stevilo2[k] != 'E' && stevilo2[k] != 'F')
                    {
                        Console.WriteLine("Napaka! Vnesli ste nepravilne podatke!");
                        return;
                    }
                } 

                Console.Write("Rezultat: ");
                //kličemo podprogram
                IzracunVsote(stevilo1, stevilo2, poljeOstank, poljeSe, sesPolje);

                //izpišemo rezultat
                for (int j = 0; j < sesPolje.Length; j++)
                {
                    if (sesPolje[j] != "0")
                    {
                        Console.Write(sesPolje[j]);
                    }
                }
            }
            Console.ReadLine();
        }
    }
}
