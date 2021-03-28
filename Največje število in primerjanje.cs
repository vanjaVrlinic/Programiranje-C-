// Vanja Vrlinič, ITK 2 - VS, Št.indexa: E1065215
/* Izdelajte postopek, ki bo določil največjo vrednost štirih vnesenih števil. Če je katero od števil večkratnik števila 6, se naj pri 
 * določanju največje vrednosti ne upošteva (v primeru, da so vsa štiri vnesena števila večkratniki števila 6, naj se izpiše opozorilo o 
 * napaki). Če je katero izmed vpisanih števil večje od 53, naj se izpiše opozorilo o prekoračitvi zgornje mejne vrednosti. V tem primeru 
 * se največjega števila ne izpiše. Postopek naj na začetku prečita štiri vrednosti in na koncu izpiše največje število ali pa opozorilo.*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vrlinic_vanja_e1065215_naloga6_sklop1
{
    class Program
    {
        static void Main(string[] args)
        {
            //deklaracija spremenljivk
            int a, b, c, d;

            //branje vrednosti iz konzole
            Console.WriteLine("Vnesite vrednosti štiri vrednosti do 53!");
            Console.Write("Vnesite a: ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Vnesite b: ");
            b = int.Parse(Console.ReadLine());
            Console.Write("Vnesite c: ");
            c = int.Parse(Console.ReadLine());
            Console.Write("Vnesite d: ");
            d = int.Parse(Console.ReadLine());

            //preverimo ali so vsa števila manjša ali enaka 53, sicer javimo napako
            if (a <= 53 && b <= 53 && c <= 53 && d <= 53)
            {
                //preverimo ali so vsa števila večkratniki števila 6, če so javimo napako
                if (a % 6 == 0 && b % 6 == 0 && c % 6 == 0 && d % 6 == 0)
                {
                    Console.WriteLine("Napaka! Vsa števila so deljiva z 6!");
                }
                else
                {
                    //ugotovimo katero število je največje
                    if (a % 6 != 0 && b % 6 != 0 && c % 6 != 0 && d % 6 != 0)
                    {
                        if (a < d && b < d && c < d)
                        {
                            Console.WriteLine("Največje število je {0}", d);
                        }
                        if (a < c && b < c && d < c)
                        {
                            Console.WriteLine("Največje število je {0}", c);
                        }
                        if (a < b && c < b && d < b)
                        {
                            Console.WriteLine("Največje število je {0}", b);
                        }
                        if (b < a && c < a && d < a)
                        {
                            Console.WriteLine("Največje število je {0}", a);
                        }
                    }
                    else
                    {
                        if (a % 6 == 0 && b % 6 != 0 && c % 6 != 0 && d % 6 != 0)
                        {
                            if (b < c && c < d)
                            {
                                Console.WriteLine("Največje število je {0}", d);
                            }
                            if (b > c && b > d)
                            {
                                Console.WriteLine("Največje število je {0}", b);
                            }
                            if (b < c && d < c)
                            {
                                Console.WriteLine("Največje število je {0}", c);
                            }
                        }
                        if (b % 6 == 0 && a % 6 != 0 && c % 6 != 0 && d % 6 != 0)
                        {
                            if (a < c && c < d)
                            {
                                Console.WriteLine("Največje število je {0}", d);
                            }
                            if (a > c && a > d)
                            {
                                Console.WriteLine("Največje število je {0}", a);
                            }
                            if (a < c && d < c)
                            {
                                Console.WriteLine("Največje število je {0}", c);
                            }
                        }
                        if (c % 6 == 0 && a % 6 != 0 && b % 6 != 0 && d % 6 != 0)
                        {
                            if (a < d && b < d)
                            {
                                Console.WriteLine("Največje število je {0}", d);
                            }
                            if (a > b && a > d)
                            {
                                Console.WriteLine("Največje število je {0}", a);
                            }
                            if (a < b && d < b)
                            {
                                Console.WriteLine("Največje število je {0}", b);
                            }
                        }
                        if (d % 6 == 0 && a % 6 != 0 && b % 6 != 0 && c % 6 != 0)
                        {
                            if (a < c && b < c)
                            {
                                Console.WriteLine("Največje število je {0}", c);
                            }
                            if (a > b && a > c)
                            {
                                Console.WriteLine("Največje število je {0}", a);
                            }
                            if (a < b && c < b)
                            {
                                Console.WriteLine("Največje število je {0}", b);
                            }
                        }
                        if (a % 6 == 0 && b % 6 == 0 && c % 6 != 0 && d % 6 != 0)
                        {
                            if (c < d)
                                Console.WriteLine("Največje število je {0}", d);
                            else
                                Console.WriteLine("Največje število je {0}", c);
                        }
                        if (a % 6 == 0 && b % 6 != 0 && c % 6 == 0 && d % 6 != 0)
                        {
                            if (b < d)
                                Console.WriteLine("Največje število je {0}", d);
                            else
                                Console.WriteLine("Največje število je {0}", b);
                        }
                        if (a % 6 == 0 && b % 6 != 0 && c % 6 != 0 && d % 6 == 0)
                        { 
                            if(b < c)
                                Console.WriteLine("Največje število je {0}", c);
                            else
                                Console.WriteLine("Največje število je {0}", b);
                        }
                        if (a % 6 != 0 && b % 6 == 0 && c % 6 == 0 && d % 6 != 0)
                        { 
                            if(a < d)
                                Console.WriteLine("Največje število je {0}", d);
                            else
                                Console.WriteLine("Največje število je {0}", a);
                        }
                        if (a % 6 != 0 && b % 6 != 0 && c % 6 == 0 && d % 6 == 0)
                        { 
                            if(a < b)
                                Console.WriteLine("Največje število je {0}", b);
                            else
                                Console.WriteLine("Največje število je {0}", a);
                        }
                        if (a % 6 != 0 && b % 6 == 0 && c % 6 == 0 && d % 6 == 0)
                        {
                            Console.WriteLine("Največje število je {0}", a);
                        }
                        if (a % 6 == 0 && b % 6 != 0 && c % 6 == 0 && d % 6 == 0)
                        {
                            Console.WriteLine("Največje število je {0}", b);
                        }
                        if (a % 6 == 0 && b % 6 == 0 && c % 6 != 0 && d % 6 == 0)
                        {
                            Console.WriteLine("Največje število je {0}", c);
                        }
                        if (a % 6 == 0 && b % 6 == 0 && c % 6 == 0 && d % 6 != 0)
                        {
                            Console.WriteLine("Največje število je {0}", d);
                        }
                    }
                }
            }
            else
            {
                Console.WriteLine("Napaka! Vnesti morate vrednosti manjše ali enake 53!");
            }

            Console.ReadLine();
        }
    }
}
