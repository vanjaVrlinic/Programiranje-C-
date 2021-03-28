// Vanja Vrlinič, ITK 2 - VS, Št.indexa: E1065215
/* Izdelajte postopek, ki bo izračunal končno oceno pri predmetu. Vhodni podatki so: število točk pridobljenih pri vajah (ločeno po 
 * posameznih sklopih), število točk pridobljenih na testih (delni izpiti/kolokviji) in število točk pri pisnem izpitu. Izračun naj 
 * upošteva, kdaj se testi upoštevajo in kdaj ne, omejitve točk po posameznih sklopih, ipd. Postopek naj izpiše končno število točk in 
 * končno oceno. */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vrlinic_vanja_e1065215_naloga13_sklop1
{
    class Program
    {
        static void Main(string[] args)
        {
            // deklaracija spremenljivk
            int vaje1, vaje2, vaje3, vaje;
            int kolokvij1, kolokvij2, kolokvij3;
            int kolokvij = 0;
            int izpit;
            double tocke = 0;
            int tockeVaj = 0;
            double kolokvijNeg = 0;
           
            // branje podatkov
            Console.WriteLine("Vnesite točke pridobljene pri predmetu OPDP!");
            Console.Write("Vnesite točke vaj 1.sklopa: ");
            vaje1 = int.Parse(Console.ReadLine());
            Console.Write("Vnesite točke vaj 2.sklopa: ");
            vaje2 = int.Parse(Console.ReadLine());
            Console.Write("Vnesite točke vaj 3.sklopa: ");
            vaje3 = int.Parse(Console.ReadLine());
            Console.Write("Vnesite točke 1.kolokvija: ");
            kolokvij1 = int.Parse(Console.ReadLine());
            Console.Write("Vnesite točke 2.kolokvija: ");
            kolokvij2 = int.Parse(Console.ReadLine());
            Console.Write("Vnesite točke 3.kolokvija: ");
            kolokvij3 = int.Parse(Console.ReadLine());
            Console.Write("Vnesite točke pisnega izpita: ");
            izpit = int.Parse(Console.ReadLine());

            // preveranje ali so vneseni podatki med 0 in 100 oz. odvisno od omejitev pri sklopih
            if (vaje1 < 0 | vaje1 > 30 | vaje2 < 0 | vaje2 > 30 | vaje3 < 0 | vaje3 > 40 | kolokvij1 < 0 | kolokvij1 > 30 | kolokvij2 < 0 | kolokvij2 > 30 | kolokvij3 < 0 | kolokvij3 > 40 | izpit < 0 | izpit > 100)
            {
                Console.WriteLine("Vnesti morate število točk med 0 in 100, vendar po omejitvah pri posameznem sklopu tudi manj!");
            }
            else
            { 
                // izračun končne ocene vaj
                if (vaje1 <= 30 && vaje2 <= 30)
                {
                    vaje = vaje1 + vaje2;

                    if (vaje < 10)
                    {
                        Console.WriteLine("Ne morete opravljati 3.sklopa! Vaje lahko ponovno opravljate naslednje leto!");
                    }
                    else
                    {
                        if (vaje3 >= 15 && vaje3 <= 40)
                        {
                            tockeVaj = vaje1 + vaje2 + vaje3;
                            Console.WriteLine("Pridobljene točke pri vajah: " + tockeVaj);

                            if (tockeVaj < 50)
                            {
                                Console.WriteLine("Vaj niste uspešno opravili!");
                            }
                            else 
                            {
                                Console.WriteLine("Vaje ste uspešno opravili!");
                            }
                        }
                    }
                }

                // izpis končne ocene kolokvijev
                if (kolokvij1 < 15)
                {
                    Console.WriteLine("Kolokvijev niste opravili!");
                }
                else
                {
                    if (kolokvij2 < 15)
                    {
                        Console.WriteLine("Kolokvijev niste opravili!");
                    }
                    else
                    {
                        if (kolokvij3 < 20)
                        {
                            Console.WriteLine("Kolokvijev niste opravili!");
                        }
                        else
                        {
                            kolokvij = kolokvij1 + kolokvij2 + kolokvij3;
                            Console.WriteLine("Iz kolokvijev ste zbrali {0} točk! Teorijo imate opravljeno!", kolokvij);
                        }
                    }
                }

                // izračun in izpis točk predmeta z kolokviji ali izpitom
                if (kolokvij >= 50 && tockeVaj >= 50)
                {
                    tocke = kolokvij * 0.4 + tockeVaj * 0.6;
                    Console.WriteLine("Pri predmetu OPDP ste zbrali skupno {0} točk!", tocke);
                }
                else
                {
                    if (izpit >= 50 && tockeVaj >= 50)
                    {
                        tocke = izpit * 0.4 + tockeVaj * 0.6;
                        Console.WriteLine("Pri predmetu OPDP ste zbrali skupno {0} točk!", tocke);
                    }
                    else
                    {
                        vaje = vaje1 + vaje2 + vaje3;
                        kolokvijNeg = kolokvij1 + kolokvij2 + kolokvij3;
                        tocke = kolokvijNeg * 0.4 + vaje * 0.6;
                        Console.WriteLine("Pri predmetu OPDP ste zbrali skupno {0} točk! Iz vaj: {1} in iz kolokvijev: {2}", tocke, vaje, kolokvijNeg);
                        Console.WriteLine("Predmeta niste opravili!");
                    }
                }
                
                // izpis ocene predmeta
                if (tocke < 50)
                {
                    Console.WriteLine("Ocena je 5!");
                }
                else
                {
                    if (tocke < 60)
                    {
                        Console.WriteLine("Ocena je 6!");
                    }
                    else
                    {
                        if (tocke < 70)
                        {
                            Console.WriteLine("Ocena je 7!");
                        }
                        else
                        {
                            if (tocke < 80)
                            {
                                Console.WriteLine("Ocena je 8!");
                            }
                            else
                            {
                                if (tocke < 90)
                                {
                                    Console.WriteLine("Ocena je 9!");
                                }
                                else
                                {
                                    Console.WriteLine("Ocena je 10!");
                                }
                            }
                        }
                    }
                }
            }
            Console.ReadLine();
        }
    }
}
