// Vanja Vrlinič, ITK VS - 2, Št.index: E1065215
/* Izdelajte program za enostaven "kalkulator".
Program naj prebere niz, ki vsebuje do štiri pozitivna števila in do tri operatorje (število1 operator1 število2 ali število1 operator1 število2 operator2 število3 ali 
število1 operator1 število2 operator2 število3 operator3 število4 - primer vhoda: "5 ^ 2 / 3.5 * 4.1"). 
Program naj vpisan niz razbije na posamezna števila in operatorje ter preveri pravilnost vnesenega izraza. Nato izračuna njegov rezultat ter ga izpiše nazaj uporabniku, 
pri čemer se upošteva prednost operatorjev (npr. množenje se izvede pred seštevanjem). Če rezultata zaradi kakršnegakoli razloga (npr. manjka število za operatorjem) ni 
mogoče izračunati, naj se uporabniku izpiše opozorilo. Operatorji so lahko: +, -, *, /, ^ (potenca).
Opomba: znak ^ ne boste mogli uporabiti direktno v v C# kodi, ker le-tega prevajalnik smatra kot operator za XOR. Tako da v primeru tega znaka, potenciranje implementirajte sami ali pa si pomagajte z matematično knjižnico.
Opomba 2: pri nalogi lahko uporabite Convert.ToInt32() ter Convert.ToDouble(). */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vrlinic_vanja_e1065215_naloga5_sklop3
{
    class Program
    {
        //preštejemo koliko nizov imamo
        static int SteviloStevil(char[] besedilo)
        {
            int stevec = 1;
            for (int i = 0; i < besedilo.Length; i++)
            {
                if (besedilo[i] == ' ')
                {
                    stevec++;
                }
            }
            return stevec;
        }
        //podprogram za razdelitev niza na posamezne nize, ki jih shranimo v polje nizov
        static string[] LocevanjeStevil(char[] besedilo, string[] locenaStevila)
        {
            string stevilo = "";
            int index = 0;
            for (int i = 0; i < besedilo.Length; i++)
            {
                if (besedilo[i] != ' ')
                {
                    stevilo += besedilo[i];
                }
                else
                {
                    locenaStevila[index] = stevilo;
                    index++;
                    stevilo = "";
                }
            }
            locenaStevila[index] = stevilo;
            return locenaStevila;
        }

        //podprogram za izračun dveh števil
        static double IzracunDvehStevil(double stevilo1, double stevilo2, char operater1)
        {
            double rezultat = 0;

            if (operater1 == '+')
            {
                rezultat = stevilo1 + stevilo2;
            }
            else if (operater1 == '-')
            {
                rezultat = stevilo1 - stevilo2;
            }
            else if (operater1 == '*')
            {
                rezultat = stevilo1 * stevilo2;
            }
            else if (operater1 == '/')
            {
                rezultat = stevilo1 / stevilo2;
            }
            else if (operater1 == '^')
            {
                rezultat = Math.Pow(stevilo1, stevilo2);
            }
            return rezultat;
        }

        //podprogrami za računanje s tremi števili
        //podprogram, ki vrača rezultat, če je prvi operator +
        static double SestevanjeTri(double stevilo1, double stevilo2, double stevilo3, char operater2)
        {
            double rezultat = 0;
            double zacasna = 0;
            if (operater2 == '+')
            {
                rezultat = stevilo1 + stevilo2 + stevilo3;
            }
            else if (operater2 == '-')
            {
                rezultat = stevilo1 + stevilo2 - stevilo3;
            }
            else if (operater2 == '*')
            {
                zacasna = stevilo2 * stevilo3;
                rezultat = zacasna + stevilo1;
            }
            else if (operater2 == '/')
            {
                zacasna = stevilo2 / stevilo3;
                rezultat = zacasna + stevilo1;
            }
            else if (operater2 == '^')
            {
                zacasna = Math.Pow(stevilo2, stevilo3);
                rezultat = stevilo1 + zacasna;
            }
            return rezultat;
        }
        //podprogram, ki vrača rezultat, če je prvi operator -
        static double OdstevanjeTri(double stevilo1, double stevilo2, double stevilo3, char operater2)
        {
            double rezultat = 0;
            double zacasna = 0;
            if (operater2 == '+')
            {
                rezultat = stevilo1 - stevilo2 + stevilo3;
            }
            else if (operater2 == '-')
            {
                rezultat = stevilo1 - stevilo2 - stevilo3;
            }
            else if (operater2 == '*')
            {
                zacasna = stevilo2 * stevilo3;
                rezultat = stevilo1 - zacasna;
            }
            else if (operater2 == '/')
            {
                zacasna = stevilo2 / stevilo3;
                rezultat = stevilo1 - zacasna;
            }
            else if (operater2 == '^')
            {
                zacasna = Math.Pow(stevilo2, stevilo3);
                rezultat = stevilo1 - zacasna;
            }
            return rezultat;
        }
        //podprogram, ki vrača rezultat, če je prvi operator *
        static double MnozenjeTri(double stevilo1, double stevilo2, double stevilo3, char operater2)
        {
            double rezultat = 0;
            double zacasna = 0;
            if (operater2 == '+')
            {
                zacasna = stevilo1 * stevilo2;
                rezultat = zacasna + stevilo3;
            }
            else if (operater2 == '-')
            {
                zacasna = stevilo1 * stevilo2;
                rezultat = zacasna - stevilo3;
            }
            else if (operater2 == '*')
            {
                rezultat = stevilo1 * stevilo2 * stevilo3;
            }
            else if (operater2 == '/')
            {
                zacasna = stevilo1 * stevilo2;
                rezultat = zacasna / stevilo3;
            }
            else if (operater2 == '^')
            {
                zacasna = Math.Pow(stevilo2, stevilo3);
                rezultat = zacasna * stevilo1;
            }
            return rezultat;
        }
        //podprogram, ki vrača rezultat, če je prvi operator /
        static double DeljenjeTri(double stevilo1, double stevilo2, double stevilo3, char operater2)
        {
            double rezultat = 0;
            double zacasna = 0;
            if (operater2 == '+')
            {
                zacasna = stevilo1 / stevilo2;
                rezultat = zacasna + 3;
            }
            else if (operater2 == '-')
            {
                zacasna = stevilo1 / stevilo2;
                rezultat = zacasna - stevilo3;
            }
            else if (operater2 == '*')
            {
                zacasna = stevilo1 / stevilo2;
                rezultat = zacasna * stevilo3;
            }
            else if (operater2 == '/')
            {
                zacasna = stevilo1 / stevilo2;
                rezultat = zacasna / stevilo3;
            }
            else if (operater2 == '^')
            {
                zacasna = Math.Pow(stevilo2, stevilo3);
                rezultat = stevilo1 / zacasna;
            }
            return rezultat;
        }
        //podprogram, ki vrača rezultat, če je prvi operator ^(potenca)
        static double PotencaTri(double stevilo1, double stevilo2, double stevilo3, char operater2)
        {
            double rezultat = 0;
            double zacasna = 0;
            if (operater2 == '+')
            {
                zacasna = Math.Pow(stevilo1, stevilo2);
                rezultat = zacasna + stevilo3;
            }
            else if (operater2 == '-')
            {
                zacasna = Math.Pow(stevilo1, stevilo2);
                rezultat = zacasna - stevilo3;
            }
            else if (operater2 == '*')
            {
                zacasna = Math.Pow(stevilo1, stevilo2);
                rezultat = zacasna * stevilo3;
            }
            else if (operater2 == '/')
            {
                zacasna = Math.Pow(stevilo1, stevilo2);
                rezultat = zacasna / stevilo3;
            }
            else if (operater2 == '^')
            {
                zacasna = Math.Pow(stevilo1, stevilo2);
                rezultat = Math.Pow(zacasna, stevilo3);
            }
            return rezultat;
        }
        
        //podprogrami za računanje s štirimi števili
        //podprogram, ki vrača rezultat, če sta prva dva operatorja +, +
        static double SestevanjePlusPlus(double stevilo1, double stevilo2, double stevilo3, double stevilo4, char operater3)
        {
            double rezultat = 0;
            double zacasna = 0;

            if (operater3 == '+')
            {
                rezultat = stevilo1 + stevilo2 + stevilo3 + stevilo4;
            }
            else if (operater3 == '-')
            {
                rezultat = stevilo1 + stevilo2 + stevilo3 - stevilo4;
            }
            else if (operater3 == '*')
            {
                zacasna = stevilo3 * stevilo4;
                rezultat = stevilo1 + stevilo2 + zacasna;
            }
            else if (operater3 == '/')
            {
                zacasna = stevilo3 / stevilo4;
                rezultat = stevilo1 + stevilo2 + zacasna;
            }
            else if (operater3 == '^')
            {
                zacasna = Math.Pow(stevilo3, stevilo4);
                rezultat = stevilo1 + stevilo2 + zacasna;
            }
            return rezultat;
        }
        //podprogram, ki vrača rezultat, če sta prva dva operatorja +, -
        static double SestevanjePlusMinus(double stevilo1, double stevilo2, double stevilo3, double stevilo4, char operater3)
        {
            double rezultat = 0;
            double zacasna = 0;
            if (operater3 == '+')
            {
                rezultat = stevilo1 + stevilo2 - stevilo3 + stevilo4;
            }
            else if (operater3 == '-')
            {
                rezultat = stevilo1 + stevilo2 - stevilo3 - stevilo4;
            }
            else if (operater3 == '*')
            {
                zacasna = stevilo3 * stevilo4;
                rezultat = stevilo1 + stevilo2 - zacasna;
            }
            else if (operater3 == '/')
            {
                zacasna = stevilo3 / stevilo4;
                rezultat = stevilo1 + stevilo2 - zacasna;
            }
            else if (operater3 == '^')
            {
                zacasna = Math.Pow(stevilo3, stevilo4);
                rezultat = stevilo1 + stevilo2 - zacasna;
            }
            return rezultat;
        }
        //podprogram, ki vrača rezultat, če sta prva dva operatorja +, *
        static double SestevanjePlusMnozenje(double stevilo1, double stevilo2, double stevilo3, double stevilo4, char operater3)
        {
            double rezultat = 0;
            double zacasna = 0;
            double vmesna = 0;

            if (operater3 == '+')
            {
                zacasna = stevilo2 * stevilo3;
                rezultat = stevilo1 + zacasna + stevilo4;
            }
            else if (operater3 == '-')
            {
                zacasna = stevilo2 * stevilo3;
                rezultat = stevilo1 + zacasna - stevilo4;
            }
            else if (operater3 == '*')
            {
                zacasna = stevilo2 * stevilo3;
                vmesna = zacasna * stevilo4;
                rezultat = stevilo1 + vmesna;
            }
            else if (operater3 == '/')
            {
                zacasna = stevilo2 * stevilo3;
                vmesna = zacasna / stevilo4;
                rezultat = stevilo1 + vmesna;
            }
            else if (operater3 == '^')
            {
                zacasna = Math.Pow(stevilo3, stevilo4);
                vmesna = stevilo2 * zacasna;
                rezultat = stevilo1 + vmesna;
            }
            return rezultat;
        }
        //podprogram, ki vrača rezultat, če sta prva dva operatorja +, /
        static double SestevanjePlusDeljenje(double stevilo1, double stevilo2, double stevilo3, double stevilo4, char operater3)
        {
            double rezultat = 0;
            double zacasna = 0;
            double vmesna = 0;
            if (operater3 == '+')
            {
                zacasna = stevilo2 / stevilo3;
                rezultat = stevilo1 + zacasna + stevilo4;
            }
            else if (operater3 == '-')
            {
                zacasna = stevilo2 / stevilo3;
                rezultat = stevilo1 + zacasna - stevilo4;
            }
            else if (operater3 == '*')
            {
                zacasna = stevilo2 / stevilo3;
                vmesna = zacasna * stevilo4;
                rezultat = stevilo1 + vmesna;
            }
            else if (operater3 == '/')
            {
                zacasna = stevilo2 / stevilo3;
                vmesna = zacasna / stevilo4;
                rezultat = stevilo1 + vmesna;
            }
            else if (operater3 == '^')
            {
                zacasna = Math.Pow(stevilo3, stevilo4);
                vmesna = stevilo2 / zacasna;
                rezultat = stevilo1 + vmesna;
            }
            return rezultat;
        }
        //podprogram, ki vrača rezultat, če sta prva dva operatorja +, ^ (potenca)
        static double SestevanjePlusPotenca(double stevilo1, double stevilo2, double stevilo3, double stevilo4, char operater3)
        {
            double rezultat = 0;
            double zacasna = 0;
            double vmesna = 0;
            if (operater3 == '+')
            {
                zacasna = Math.Pow(stevilo2, stevilo3);
                rezultat = stevilo1 + zacasna + stevilo4;
            }
            else if (operater3 == '-')
            {
                zacasna = Math.Pow(stevilo2, stevilo3);
                rezultat = stevilo1 + zacasna - stevilo4;
            }
            else if (operater3 == '*')
            {
                zacasna = Math.Pow(stevilo2, stevilo3);
                vmesna = zacasna * stevilo4;
                rezultat = stevilo1 + vmesna;
            }
            else if (operater3 == '/')
            {
                zacasna = Math.Pow(stevilo2, stevilo3);
                vmesna = zacasna / stevilo4;
                rezultat = stevilo1 + vmesna;
            }
            else if (operater3 == '^')
            {
                zacasna = Math.Pow(stevilo2, stevilo3);
                vmesna = Math.Pow(zacasna, stevilo4);
                rezultat = stevilo1 + vmesna;
            }
            return rezultat;
        }
        //podprogram, ki vrača rezultat, če sta prva dva operatorja -, +
        static double OdstevanjeMinusPlus(double stevilo1, double stevilo2, double stevilo3, double stevilo4, char operater3)
        {
            double rezultat = 0;
            double zacasna = 0;

            if (operater3 == '+')
            {
                rezultat = stevilo1 - stevilo2 + stevilo3 + stevilo4;
            }
            else if (operater3 == '-')
            {
                rezultat = stevilo1 - stevilo2 + stevilo3 - stevilo4;
            }
            else if (operater3 == '*')
            {
                zacasna = stevilo3 * stevilo4;
                rezultat = stevilo1 - stevilo2 + zacasna;
            }
            else if (operater3 == '/')
            {
                zacasna = stevilo3 / stevilo4;
                rezultat = stevilo1 - stevilo2 + zacasna;
            }
            else if (operater3 == '^')
            {
                zacasna = Math.Pow(stevilo3, stevilo4);
                rezultat = stevilo1 - stevilo2 + zacasna;
            }
            return rezultat;
        }
        //podprogram, ki vrača rezultat, če sta prva dva operatorja -, -
        static double OdstevanjeMinusMinus(double stevilo1, double stevilo2, double stevilo3, double stevilo4, char operater3)
        {
            double rezultat = 0;
            double zacasna = 0;
 
            if (operater3 == '+')
            {
                rezultat = stevilo1 - stevilo2 - stevilo3 + stevilo4;
            }
            else if (operater3 == '-')
            {
                rezultat = stevilo1 - stevilo2 - stevilo3 - stevilo4;
            }
            else if (operater3 == '*')
            {
                zacasna = stevilo3 * stevilo4;
                rezultat = stevilo1 - stevilo2 - zacasna;
            }
            else if (operater3 == '/')
            {
                zacasna = stevilo3 / stevilo4;
                rezultat = stevilo1 - stevilo2 - zacasna;
            }
            else if (operater3 == '^')
            {
                zacasna = Math.Pow(stevilo3, stevilo4);
                rezultat = stevilo1 - stevilo2 - zacasna;
            }
            return rezultat;
        }
        //podprogram, ki vrača rezultat, če sta prva dva operatorja -, *
        static double OdstevanjeMinusMnozenje(double stevilo1, double stevilo2, double stevilo3, double stevilo4, char operater3)
        {
            double rezultat = 0;
            double zacasna = 0;
            double vmesna = 0;
            if (operater3 == '+')
            {
                zacasna = stevilo2 * stevilo3;
                rezultat = stevilo1 - zacasna + stevilo4;
            }
            else if (operater3 == '-')
            {
                zacasna = stevilo2 * stevilo3;
                rezultat = stevilo1 - zacasna - stevilo4;
            }
            else if (operater3 == '*')
            {
                zacasna = stevilo2 * stevilo3 * stevilo4;
                rezultat = stevilo1 - zacasna;
            }
            else if (operater3 == '/')
            {
                zacasna = stevilo3 / stevilo4;
                vmesna = stevilo2 * zacasna;
                rezultat = stevilo1 - vmesna;
            }
            else if (operater3 == '^')
            {
                zacasna = Math.Pow(stevilo3, stevilo4);
                vmesna = stevilo2 * zacasna;
                rezultat = stevilo1 - vmesna;
            }
            return rezultat;
        }
        //podprogram, ki vrača rezultat, če sta prva dva operatorja -, /
        static double OdstevanjeMinusDeljenje(double stevilo1, double stevilo2, double stevilo3, double stevilo4, char operater3)
        {
            double rezultat = 0;
            double zacasna = 0;
            double vmesna = 0;
            if (operater3 == '+')
            {
                zacasna = stevilo2 / stevilo3;
                rezultat = stevilo1 - zacasna + stevilo4;
            }
            else if (operater3 == '-')
            {
                zacasna = stevilo2 / stevilo3;
                rezultat = stevilo1 - zacasna - stevilo4;
            }
            else if (operater3 == '*')
            {
                zacasna = stevilo2 / stevilo3;
                vmesna = zacasna * stevilo4;
                rezultat = stevilo1 - vmesna;
            }
            else if (operater3 == '/')
            {
                zacasna = stevilo2 / stevilo3 / stevilo4;
                rezultat = stevilo1 - zacasna;
            }
            else if (operater3 == '^')
            {
                zacasna = Math.Pow(stevilo3, stevilo4);
                vmesna = stevilo2 / zacasna;
                rezultat = stevilo1 - vmesna;
            }
            return rezultat;
        }
        //podprogram, ki vrača rezultat, če sta prva dva operatorja -, ^ (potenca)
        static double OdstevanjeMinusPotenca(double stevilo1, double stevilo2, double stevilo3, double stevilo4, char operater3)
        {
            double rezultat = 0;
            double zacasna = 0;
            double vmesna = 0;
            if (operater3 == '+')
            {
                zacasna = Math.Pow(stevilo2, stevilo3);
                rezultat = stevilo1 - zacasna + stevilo4;
            }
            else if (operater3 == '-')
            {
                zacasna = Math.Pow(stevilo2, stevilo3);
                rezultat = stevilo1 - zacasna - stevilo4;
            }
            else if (operater3 == '*')
            {
                zacasna = Math.Pow(stevilo2, stevilo3);
                vmesna = zacasna * stevilo4;
                rezultat = stevilo1 - vmesna;

            }
            else if (operater3 == '/')
            {
                zacasna = Math.Pow(stevilo2, stevilo3);
                vmesna = zacasna / stevilo4;
                rezultat = stevilo1 - vmesna;
            }
            else if (operater3 == '^')
            {
                zacasna = Math.Pow(stevilo2, stevilo3);
                vmesna = Math.Pow(zacasna, stevilo4);
                rezultat = stevilo1 - vmesna;
            }
            return rezultat;
        }
        //podprogram, ki vrača rezultat, če sta prva dva operatorja *, +
        static double MnozenjeMnozenjePlus(double stevilo1, double stevilo2, double stevilo3, double stevilo4, char operater3)
        {
            double rezultat = 0;
            double zacasna = 0;
            double vmesna = 0;
            if (operater3 == '+')
            {
                zacasna = stevilo1 * stevilo2;
                rezultat = zacasna + stevilo3 + stevilo4;
            }
            else if (operater3 == '-')
            {
                zacasna = stevilo1 * stevilo2;
                rezultat = zacasna + stevilo3 - stevilo4;
            }
            else if (operater3 == '*')
            {
                zacasna = stevilo1 * stevilo2;
                vmesna = stevilo3 * stevilo4;
                rezultat = zacasna + vmesna;
            }
            else if (operater3 == '/')
            {
                zacasna = stevilo1 * stevilo2;
                vmesna = stevilo3 / stevilo4;
                rezultat = zacasna + vmesna;
            }
            else if (operater3 == '^')
            {
                zacasna = stevilo1 * stevilo2;
                vmesna = Math.Pow(stevilo3, stevilo4);
                rezultat = zacasna + vmesna;
            }
            return rezultat;
        }
        //podprogram, ki vrača rezultat, če sta prva dva operatorja *, -
        static double MnozenjeMnozenjeMinus(double stevilo1, double stevilo2, double stevilo3, double stevilo4, char operater3)
        {
            double rezultat = 0;
            double zacasna = 0;
            double vmesna = 0;
            if (operater3 == '+')
            {
                zacasna = stevilo1 * stevilo2;
                rezultat = zacasna - stevilo3 + stevilo4;
            }
            else if (operater3 == '-')
            {
                zacasna = stevilo1 * stevilo2;
                rezultat = zacasna - stevilo3 - stevilo4;
            }
            else if (operater3 == '*')
            {
                zacasna = stevilo1 * stevilo2;
                vmesna = stevilo3 * stevilo4;
                rezultat = zacasna - vmesna;
            }
            else if (operater3 == '/')
            {
                zacasna = stevilo1 * stevilo2;
                vmesna = stevilo3 / stevilo4;
                rezultat = zacasna - vmesna;
            }
            else if (operater3 == '^')
            {
                zacasna = stevilo1 * stevilo2;
                vmesna = Math.Pow(stevilo3, stevilo4);
                rezultat = zacasna - vmesna;
            }
            return rezultat;
        }
        //podprogram, ki vrača rezultat, če sta prva dva operatorja *, *
        static double MnozenjeMnozenjeMnozenje(double stevilo1, double stevilo2, double stevilo3, double stevilo4, char operater3)
        {
            double rezultat = 0;
            double zacasna = 0;
         
            if (operater3 == '+')
            {
                zacasna = stevilo1 * stevilo2 * stevilo3;
                rezultat = zacasna + stevilo4;
            }
            else if (operater3 == '-')
            {
                zacasna = stevilo1 * stevilo2 * stevilo3;
                rezultat = zacasna - stevilo4;
            }
            else if (operater3 == '*')
            {
                rezultat = stevilo1 * stevilo2 * stevilo3 * stevilo4;
            }
            else if (operater3 == '/')
            {
                zacasna = stevilo3 / stevilo4;
                rezultat = stevilo1 * stevilo2 * zacasna;
            }
            else if (operater3 == '^')
            {
                zacasna = Math.Pow(stevilo3, stevilo4);
                rezultat = stevilo1 * stevilo2 * zacasna;
            }
            return rezultat;
        }
        //podprogram, ki vrača rezultat, če sta prva dva operatorja *, /
        static double MnozenjeMnozenjeDeljenje(double stevilo1, double stevilo2, double stevilo3, double stevilo4, char operater3)
        {
            double rezultat = 0;
            double zacasna = 0;
            double vmesna = 0;
            if (operater3 == '+')
            {
                zacasna = stevilo2 / stevilo3;
                vmesna = stevilo1 * zacasna;
                rezultat = vmesna + stevilo4;
            }
            else if (operater3 == '-')
            {
                zacasna = stevilo2 / stevilo3;
                vmesna = stevilo1 * zacasna;
                rezultat = vmesna - stevilo4;
            }
            else if (operater3 == '*')
            {
                zacasna = stevilo2 / stevilo3;
                rezultat = stevilo1 * zacasna * stevilo4;
            }
            else if (operater3 == '/')
            {
                zacasna = stevilo2 / stevilo3 / stevilo4;
                rezultat = stevilo1 * zacasna;
            }
            else if (operater3 == '^')
            {
                zacasna = Math.Pow(stevilo3, stevilo4);
                vmesna = stevilo2 / zacasna;
                rezultat = stevilo1 * vmesna;
            }
            return rezultat;
        }
        //podprogram, ki vrača rezultat, če sta prva dva operatorja *, ^ (potenca)
        static double MnozenjeMnozenjePotenca(double stevilo1, double stevilo2, double stevilo3, double stevilo4, char operater3)
        {
            double rezultat = 0;
            double zacasna = 0;
            double vmesna = 0;
            if (operater3 == '+')
            {
                zacasna = Math.Pow(stevilo2, stevilo3);
                vmesna = stevilo1 * zacasna;
                rezultat = vmesna + stevilo4;
            }
            else if (operater3 == '-')
            {
                zacasna = Math.Pow(stevilo2, stevilo3);
                vmesna = stevilo1 * zacasna;
                rezultat = vmesna - stevilo4;
            }
            else if (operater3 == '*')
            {
                zacasna = Math.Pow(stevilo2, stevilo3);
                rezultat = stevilo1 * zacasna * stevilo4;
            }
            else if (operater3 == '/')
            {
                zacasna = Math.Pow(stevilo2, stevilo3);
                vmesna = zacasna / stevilo4;
                rezultat = stevilo1 * vmesna;
            }
            else if (operater3 == '^')
            {
                zacasna = Math.Pow(stevilo2, stevilo3);
                vmesna = Math.Pow(zacasna, stevilo4);
                rezultat = stevilo1 * vmesna;
            }
            return rezultat;
        }
        //podprogram, ki vrača rezultat, če sta prva dva operatorja /, +
        static double DeljenjeDeljenjePlus(double stevilo1, double stevilo2, double stevilo3, double stevilo4, char operater3)
        {
            double rezultat = 0;
            double zacasna = 0;
            double vmesna = 0;
            if (operater3 == '+')
            {
                zacasna = stevilo1 / stevilo2;
                rezultat = zacasna + stevilo3 + stevilo4;
            }
            else if (operater3 == '-')
            {
                zacasna = stevilo1 / stevilo2;
                rezultat = zacasna + stevilo3 - stevilo4;
            }
            else if (operater3 == '*')
            {
                zacasna = stevilo1 / stevilo2;
                vmesna = stevilo3 * stevilo4;
                rezultat = zacasna + vmesna;
            }
            else if (operater3 == '/')
            {
                zacasna = stevilo1 / stevilo2;
                vmesna = stevilo3 / stevilo4;
                rezultat = zacasna + vmesna;
            }
            else if (operater3 == '^')
            {
                zacasna = stevilo1 / stevilo2;
                vmesna = Math.Pow(stevilo3, stevilo4);
                rezultat = zacasna + vmesna;
            }
            return rezultat;
        }
        //podprogram, ki vrača rezultat, če sta prva dva operatorja /, -
        static double DeljenjeDeljenjeMinus(double stevilo1, double stevilo2, double stevilo3, double stevilo4, char operater3)
        {
            double rezultat = 0;
            double zacasna = 0;
            double vmesna = 0;
            if (operater3 == '+')
            {
                zacasna = stevilo1 / stevilo2;
                rezultat = zacasna - stevilo3 + stevilo4;
            }
            else if (operater3 == '-')
            {
                zacasna = stevilo1 / stevilo2;
                rezultat = zacasna - stevilo3 - stevilo4;
            }
            else if (operater3 == '*')
            {
                zacasna = stevilo1 / stevilo2;
                vmesna = stevilo3 * stevilo4;
                rezultat = zacasna - vmesna;
            }
            else if (operater3 == '/')
            {
                zacasna = stevilo1 / stevilo2;
                vmesna = stevilo3 / stevilo4;
                rezultat = zacasna - vmesna;
            }
            else if (operater3 == '^')
            {
                zacasna = stevilo1 / stevilo2;
                vmesna = Math.Pow(stevilo3, stevilo4);
                rezultat = zacasna - vmesna;
            }
            return rezultat;
        }

        //podprogram, ki vrača rezultat, če sta prva dva operatorja /, *
        static double DeljenjeDeljenjeMnozenje(double stevilo1, double stevilo2, double stevilo3, double stevilo4, char operater3)
        {
            double rezultat = 0;
            double zacasna = 0;
            double vmesna = 0;
            if (operater3 == '+')
            {
                zacasna = stevilo1 / stevilo2;
                vmesna = zacasna * stevilo3;
                rezultat = vmesna + stevilo4;
            }
            else if (operater3 == '-')
            {
                zacasna = stevilo1 / stevilo2;
                vmesna = zacasna * stevilo3;
                rezultat = vmesna - stevilo4;
            }
            else if (operater3 == '*')
            {
                zacasna = stevilo1 / stevilo2;
                rezultat = zacasna * stevilo3 * stevilo4;
            }
            else if (operater3 == '/')
            {
                zacasna = stevilo1 / stevilo2;
                vmesna = stevilo3 / stevilo4;
                rezultat = zacasna * vmesna;
            }
            else if (operater3 == '^')
            {
                zacasna = stevilo1 / stevilo2;
                vmesna = Math.Pow(stevilo3, stevilo4);
                rezultat = zacasna * vmesna;
            }
            return rezultat;
        }

        //podprogram, ki vrača rezultat, če sta prva dva operatorja /, /
        static double DeljenjeDeljenjeDeljenje(double stevilo1, double stevilo2, double stevilo3, double stevilo4, char operater3)
        {
            double rezultat = 0;
            double zacasna = 0;
            double vmesna = 0;
            if (operater3 == '+')
            {
                zacasna = stevilo1 / stevilo2 / stevilo3;
                rezultat = zacasna + stevilo4;
            }
            else if (operater3 == '-')
            {
                zacasna = stevilo1 / stevilo2 / stevilo3;
                rezultat = zacasna - stevilo4;
            }
            else if (operater3 == '*')
            {
                zacasna = stevilo1 / stevilo2 / stevilo3;
                rezultat = zacasna * stevilo4;
            }
            else if (operater3 == '/')
            {
                rezultat = stevilo1 / stevilo2 / stevilo3 / stevilo4;
            }
            else if (operater3 == '^')
            {
                zacasna = stevilo1 / stevilo2;
                vmesna = Math.Pow(stevilo3, stevilo4);
                rezultat = zacasna / vmesna;
            }
            return rezultat;
        }

        //podprogram, ki vrača rezultat, če sta prva dva operatorja /, ^ (potenca)
        static double DeljenjeDeljenjePotenca(double stevilo1, double stevilo2, double stevilo3, double stevilo4, char operater3)
        {
            double rezultat = 0;
            double zacasna = 0;
            double vmesna = 0;
            if (operater3 == '+')
            {
                zacasna = Math.Pow(stevilo2, stevilo3);
                vmesna = stevilo1 / zacasna;
                rezultat = vmesna + stevilo4;
            }
            else if (operater3 == '-')
            {
                zacasna = Math.Pow(stevilo2, stevilo3);
                vmesna = stevilo1 / zacasna;
                rezultat = vmesna - stevilo4;
            }
            else if (operater3 == '*')
            {
                zacasna = Math.Pow(stevilo2, stevilo3);
                vmesna = stevilo1 / zacasna;
                rezultat = vmesna * stevilo4;
            }
            else if (operater3 == '/')
            {
                zacasna = Math.Pow(stevilo2, stevilo3);
                rezultat = stevilo1 / zacasna / stevilo4;
            }
            else if (operater3 == '^')
            {
                zacasna = Math.Pow(stevilo2, stevilo3);
                vmesna = Math.Pow(zacasna, stevilo4);
                rezultat = stevilo1 / vmesna;
            }
            return rezultat;
        }
        //podprogram, ki vrača rezultat, če sta prva dva operatorja  ^ (potenca), +
        static double PotencaPotencaPlus(double stevilo1, double stevilo2, double stevilo3, double stevilo4, char operater3)
        {
            double rezultat = 0;
            double zacasna = 0;
            double vmesna = 0;
            if (operater3 == '+')
            {
                zacasna = Math.Pow(stevilo1, stevilo2);
                rezultat = zacasna + stevilo3 + stevilo4;
            }
            else if (operater3 == '-')
            {
                zacasna = Math.Pow(stevilo1, stevilo2);
                rezultat = zacasna + stevilo3 - stevilo4;
            }
            else if (operater3 == '*')
            {
                zacasna = Math.Pow(stevilo1, stevilo2);
                vmesna = stevilo3 * stevilo4;
                rezultat = zacasna + vmesna;
            }
            else if (operater3 == '/')
            {
                zacasna = Math.Pow(stevilo1, stevilo2);
                vmesna = stevilo3 / stevilo4;
                rezultat = zacasna + vmesna;
            }
            else if (operater3 == '^')
            {
                zacasna = Math.Pow(stevilo1, stevilo2);
                vmesna = Math.Pow(stevilo3, stevilo4);
                rezultat = zacasna + vmesna;
            }
            return rezultat;
        }

        //podprogram, ki vrača rezultat, če sta prva dva operatorja  ^ (potenca), -
        static double PotencaPotencaMinus(double stevilo1, double stevilo2, double stevilo3, double stevilo4, char operater3)
        {
            double rezultat = 0;
            double zacasna = 0;
            double vmesna = 0;
            if (operater3 == '+')
            {
                zacasna = Math.Pow(stevilo1, stevilo2);
                rezultat = zacasna - stevilo3 + stevilo4;
            }
            else if (operater3 == '-')
            {
                zacasna = Math.Pow(stevilo1, stevilo2);
                rezultat = zacasna - stevilo3 - stevilo4;
            }
            else if (operater3 == '*')
            {
                zacasna = Math.Pow(stevilo1, stevilo2);
                vmesna = stevilo3 * stevilo4;
                rezultat = zacasna - vmesna;
            }
            else if (operater3 == '/')
            {
                zacasna = Math.Pow(stevilo1, stevilo2);
                vmesna = stevilo3 / stevilo4;
                rezultat = zacasna - vmesna;
            }
            else if (operater3 == '^')
            {
                zacasna = Math.Pow(stevilo1, stevilo2);
                vmesna = Math.Pow(stevilo3, stevilo4);
                rezultat = zacasna - vmesna;
            }
            return rezultat;
        }

        //podprogram, ki vrača rezultat, če sta prva dva operatorja  ^ (potenca), *
        static double PotencaPotencaMnozenje(double stevilo1, double stevilo2, double stevilo3, double stevilo4, char operater3)
        {
            double rezultat = 0;
            double zacasna = 0;
            double vmesna = 0;
            if (operater3 == '+')
            {
                zacasna = Math.Pow(stevilo1, stevilo2);
                vmesna = zacasna * stevilo3;
                rezultat = vmesna + stevilo4;
            }
            else if (operater3 == '-')
            {
                zacasna = Math.Pow(stevilo1, stevilo2);
                vmesna = zacasna * stevilo3;
                rezultat = vmesna - stevilo4;
            }
            else if (operater3 == '*')
            {
                zacasna = Math.Pow(stevilo1, stevilo2);
                rezultat = zacasna * stevilo3 * stevilo4;
            }
            else if (operater3 == '/')
            {
                zacasna = Math.Pow(stevilo1, stevilo2);
                vmesna = stevilo3 / stevilo4;
                rezultat = zacasna * vmesna;
            }
            else if (operater3 == '^')
            {
                zacasna = Math.Pow(stevilo1, stevilo2);
                vmesna = Math.Pow(stevilo3, stevilo4);
                rezultat = zacasna * vmesna;
            }
            return rezultat;
        }

        //podprogram, ki vrača rezultat, če sta prva dva operatorja  ^ (potenca), /
        static double PotencaPotencaDeljenje(double stevilo1, double stevilo2, double stevilo3, double stevilo4, char operater3)
        {
            double rezultat = 0;
            double zacasna = 0;
            double vmesna = 0;
            if (operater3 == '+')
            {
                zacasna = Math.Pow(stevilo1, stevilo2);
                vmesna = zacasna / stevilo3;
                rezultat = vmesna + stevilo4;
            }
            else if (operater3 == '-')
            {
                zacasna = Math.Pow(stevilo1, stevilo2);
                vmesna = zacasna / stevilo3;
                rezultat = vmesna - stevilo4;
            }
            else if (operater3 == '*')
            {
                zacasna = Math.Pow(stevilo1, stevilo2);
                vmesna = zacasna / stevilo3;
                rezultat = vmesna * stevilo4;
            }
            else if (operater3 == '/')
            {
                zacasna = Math.Pow(stevilo1, stevilo2);
                rezultat = zacasna / stevilo3 / stevilo4;
            }
            else if (operater3 == '^')
            {
                zacasna = Math.Pow(stevilo1, stevilo2);
                vmesna = Math.Pow(stevilo3, stevilo4);
                rezultat = zacasna / vmesna;
            }
            return rezultat;
        }
        //podprogram, ki vrača rezultat, če sta prva dva operatorja  ^ ^ (potenci)
        static double PotencaPotencaPotenca(double stevilo1, double stevilo2, double stevilo3, double stevilo4, char operater3)
        {
            double rezultat = 0;
            double zacasna = 0;
            double vmesna = 0;
            if (operater3 == '+')
            {
                zacasna = Math.Pow(stevilo1, stevilo2);
                vmesna = Math.Pow(zacasna, stevilo3);
                rezultat = vmesna + stevilo4;
            }
            else if (operater3 == '-')
            {
                zacasna = Math.Pow(stevilo1, stevilo2);
                vmesna = Math.Pow(zacasna, stevilo3);
                rezultat = vmesna - stevilo4;
            }
            else if (operater3 == '*')
            {
                zacasna = Math.Pow(stevilo1, stevilo2);
                vmesna = Math.Pow(zacasna, stevilo3);
                rezultat = vmesna * stevilo4;

            }
            else if (operater3 == '/')
            {
                zacasna = Math.Pow(stevilo1, stevilo2);
                vmesna = Math.Pow(zacasna, stevilo3);
                rezultat = vmesna / stevilo4;
            }
            else if (operater3 == '^')
            {
                zacasna = Math.Pow(stevilo1, stevilo2);
                vmesna = Math.Pow(zacasna, stevilo3);
                rezultat = Math.Pow(vmesna, stevilo4);
            }
            return rezultat;
        }
        static void Main(string[] args)
        {
            int niz;
            //Uporabnik izbere s koliko števili bo računal
            do
            {
                Console.WriteLine("Izberite eno izmed naslednjih možnosti: ");
                Console.WriteLine("2 - računanje z dvema številoma!");
                Console.WriteLine("3 - računanje s tremi števili!");
                Console.WriteLine("4 - računanje s štirimi števili!");
                niz = int.Parse(Console.ReadLine());
            } while (!(niz == 2 || niz == 3 || niz == 4)); //Zanka se ponavlja dokler ni vnesena izbira 2 ali 3 ali 4

            //Preberemo niz oz. račun
            Console.WriteLine("Vnesite račun kot niz: ");
            string besede = Console.ReadLine();

            char[] besedilo = new char[besede.Length];
            
            //vsak znak iz niza prepišemo v polje znakov
            for (int i = 0; i < besede.Length; i++)
            {
                besedilo[i] = besede[i];
            }

            for (int j = 0; j < besedilo.Length; j++)
            {
                if (besedilo[j] != ' ' && besedilo[j] != '+' && besedilo[j] != '-' && besedilo[j] != '*' && besedilo[j] != '/' && besedilo[j] != '^' && besedilo[j] != '.' && besedilo[j] != '0' && besedilo[j] != '1' && besedilo[j] != '2' && besedilo[j] != '3' && besedilo[j] != '4' && besedilo[j] != '5' && besedilo[j] != '6' && besedilo[j] != '7' && besedilo[j] != '8' && besedilo[j] != '9')
                {
                    Console.WriteLine("Napaka! Vnesti morate števila in operatorje +, -, *, /, ^ (potenca)!");
                }
            }

            //inicializacija polja 
            int velikostPolja = SteviloStevil(besedilo);
            string[] locenaStevila = new string[velikostPolja];
            locenaStevila = LocevanjeStevil(besedilo, locenaStevila);

            if (niz == 2)
            {
                //preverimo ali je dovolj podatkov za izračun rezultata
                if (locenaStevila.Length < 3)
                {
                    Console.WriteLine("Napaka! Niste vnesli vseh podatkov!");
                }
                //Številom in operatorjem določimo oz. pretvorimo vrednost iz določenega mesta v polju nizov
                double stevilo1 = Convert.ToDouble(locenaStevila[0]);
                char operater1 = char.Parse(locenaStevila[1]);
                double stevilo2 = Convert.ToDouble(locenaStevila[2]);
                
                //izpišemo rezultat s klicem funkcije, kjer poiščemo operator ter izračunamo rezultat
                Console.WriteLine("Rezultat: {0} ", IzracunDvehStevil(stevilo1, stevilo2, operater1));
            }
            else if (niz == 3)
            {
                //preverimo ali je dovolj podatkov za izračun rezultata
                if (locenaStevila.Length < 5)
                {
                    Console.WriteLine("Napaka! Niste vnesli vseh podatkov!");
                }
                //Številom in operatorjem določimo oz. pretvorimo vrednost iz določenega mesta v polju nizov
                double stevilo1 = Convert.ToDouble(locenaStevila[0]);
                char operater1 = char.Parse(locenaStevila[1]);
                double stevilo2 = Convert.ToDouble(locenaStevila[2]);
                char operater2 = char.Parse(locenaStevila[3]);
                double stevilo3 = Convert.ToDouble(locenaStevila[4]);

                //iskanje ustreznega prvega operatorja, da nato kličemo funkcijo kjer poiščemo drugi operator, ki ustreza ter izračunamo rezultat
                if(operater1=='+')
                {
                    Console.WriteLine("Rezultat: {0} ", SestevanjeTri(stevilo1, stevilo2, stevilo3, operater2));
                }
                else if(operater1=='-')
                {
                    Console.WriteLine("Rezultat: {0} ", OdstevanjeTri(stevilo1, stevilo2, stevilo3, operater2));
                }
                else if(operater1=='*')
                {
                    Console.WriteLine("Rezultat: {0} ", MnozenjeTri(stevilo1, stevilo2, stevilo3, operater2));
                }
                else if(operater1=='/')
                {
                    Console.WriteLine("Rezultat: {0} ", DeljenjeTri(stevilo1, stevilo2, stevilo3, operater2));
                }
                else if(operater1=='^')
                {
                    Console.WriteLine("Rezultat: {0} ", PotencaTri(stevilo1, stevilo2, stevilo3, operater2));
                }
            }
            else if (niz == 4)
            {
                //preverimo ali je dovolj podatkov za izračun rezultata
                if (locenaStevila.Length < 7)
                {
                    Console.WriteLine("Napaka! Niste vnesli vseh podatkov!");
                }
                //Številom in operatorjem določimo oz. pretvorimo vrednost iz določenega mesta v polju nizov
                double stevilo1 = Convert.ToDouble(locenaStevila[0]);
                char operater1 = char.Parse(locenaStevila[1]);
                double stevilo2 = Convert.ToDouble(locenaStevila[2]);
                char operater2 = char.Parse(locenaStevila[3]);
                double stevilo3 = Convert.ToDouble(locenaStevila[4]);
                char operater3 = char.Parse(locenaStevila[5]);
                double stevilo4 = Convert.ToDouble(locenaStevila[6]);

                //iskanje kombinacije ustreznih dveh operatorjev, da nato kličemo funkcijo v kateri poiščemo še tretji operator ter izračunamo rezultat
                if(operater1 == '+' && operater2 == '+')
                {
                    Console.WriteLine("Rezultat: {0} ", SestevanjePlusPlus(stevilo1, stevilo2, stevilo3, stevilo4, operater3));
                }
                else if(operater1 == '+' && operater2 == '-')
                {
                    Console.WriteLine("Rezultat: {0} ", SestevanjePlusMinus(stevilo1, stevilo2, stevilo3, stevilo4, operater3));
                }
                else if(operater1 == '+' && operater2 == '*')
                {
                    Console.WriteLine("Rezultat: {0} ", SestevanjePlusMnozenje(stevilo1, stevilo2, stevilo3, stevilo4, operater3));
                }
                else if(operater1 == '+' && operater2 == '/')
                {
                    Console.WriteLine("Rezultat: {0} ", SestevanjePlusDeljenje(stevilo1, stevilo2, stevilo3, stevilo4, operater3));
                }
                else if(operater1 == '+' && operater2 == '^')
                {
                    Console.WriteLine("Rezultat: {0} ", SestevanjePlusPotenca(stevilo1, stevilo2, stevilo3, stevilo4, operater3));
                }
                else if(operater1 == '-' && operater2 == '+')
                {
                    Console.WriteLine("Rezultat: {0} ", OdstevanjeMinusPlus(stevilo1, stevilo2, stevilo3, stevilo4, operater3));
                }
                else if(operater1 == '-' && operater2 == '-')
                {
                    Console.WriteLine("Rezultat: {0} ", OdstevanjeMinusMinus(stevilo1, stevilo2, stevilo3, stevilo4, operater3));
                }
                else if(operater1 == '-' && operater2 == '*')
                {
                    Console.WriteLine("Rezultat: {0} ", OdstevanjeMinusMnozenje(stevilo1, stevilo2, stevilo3, stevilo4, operater3));
                }
                else if(operater1 == '-' && operater2 == '/')
                {
                    Console.WriteLine("Rezultat: {0} ", OdstevanjeMinusDeljenje(stevilo1, stevilo2, stevilo3, stevilo4, operater3));
                }
                else if(operater1 == '-' && operater2 == '^')
                {
                    Console.WriteLine("Rezultat: {0} ", OdstevanjeMinusPotenca(stevilo1, stevilo2, stevilo3, stevilo4, operater3));
                }
                else if(operater1 == '*' && operater2 == '+')
                {
                    Console.WriteLine("Rezultat: {0} ", MnozenjeMnozenjePlus(stevilo1, stevilo2, stevilo3, stevilo4, operater3));
                }
                else if(operater1 == '*' && operater2 == '-')
                {
                    Console.WriteLine("Rezultat: {0} ", MnozenjeMnozenjeMinus(stevilo1, stevilo2, stevilo3, stevilo4, operater3));
                }
                else if(operater1 == '*' && operater2 == '*')
                {
                    Console.WriteLine("Rezultat: {0} ", MnozenjeMnozenjeMnozenje(stevilo1, stevilo2, stevilo3, stevilo4, operater3));
                }
                else if(operater1 == '*' && operater2 == '/')
                {
                    Console.WriteLine("Rezultat: {0} ", MnozenjeMnozenjeDeljenje(stevilo1, stevilo2, stevilo3, stevilo4, operater3));
                }
                else if(operater1 == '*' && operater2 == '^')
                {
                    Console.WriteLine("Rezultat: {0} ", MnozenjeMnozenjePotenca(stevilo1, stevilo2, stevilo3, stevilo4, operater3));
                }
                else if(operater1 == '/' && operater2 == '+')
                {
                    Console.WriteLine("Rezultat: {0} ", DeljenjeDeljenjePlus(stevilo1, stevilo2, stevilo3, stevilo4, operater3));
                }
                else if(operater1 == '/' && operater2 == '-')
                {
                    Console.WriteLine("Rezultat: {0} ", DeljenjeDeljenjeMinus(stevilo1, stevilo2, stevilo3, stevilo4, operater3));
                }
                else if(operater1 == '/' && operater2 == '*')
                {
                    Console.WriteLine("Rezultat: {0} ", DeljenjeDeljenjeMnozenje(stevilo1, stevilo2, stevilo3, stevilo4, operater3));
                }
                else if(operater1 == '/' && operater2 == '/')
                {
                    Console.WriteLine("Rezultat: {0} ", DeljenjeDeljenjeDeljenje(stevilo1, stevilo2, stevilo3, stevilo4, operater3));
                }
                else if(operater1 == '/' && operater2 == '^')
                {
                    Console.WriteLine("Rezultat: {0} ", DeljenjeDeljenjePotenca(stevilo1, stevilo2, stevilo3, stevilo4, operater3));
                }
                else if(operater1 == '^' && operater2 == '+')
                {
                    Console.WriteLine("Rezultat: {0} ", PotencaPotencaPlus(stevilo1, stevilo2, stevilo3, stevilo4, operater3));
                }
                else if(operater1 == '^' && operater2 == '-')
                {
                    Console.WriteLine("Rezultat: {0} ", PotencaPotencaMinus(stevilo1, stevilo2, stevilo3, stevilo4, operater3));
                }
                else if(operater1 == '^' && operater2 == '*')
                {
                    Console.WriteLine("Rezultat: {0} ", PotencaPotencaMnozenje(stevilo1, stevilo2, stevilo3, stevilo4, operater3));
                }
                else if(operater1 == '^' && operater2 == '/')
                {
                    Console.WriteLine("Rezultat: {0} ", PotencaPotencaDeljenje(stevilo1, stevilo2, stevilo3, stevilo4, operater3));
                }
                else if(operater1 == '^' && operater2 == '^')
                {
                    Console.WriteLine("Rezultat: {0} ", PotencaPotencaPotenca(stevilo1, stevilo2, stevilo3, stevilo4, operater3));
                }
            }
            Console.ReadLine();
        }
    }
}
