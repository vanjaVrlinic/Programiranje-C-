// Vanja Vrlinič, ITK VS - 2, Št.indexa: E1065215
/* Izdelajte program, ki bo prebral vrstico besedila, v katerem so besede ločene s presledki. V besedilu pa se lahko nahajajo tudi številke.
Program naj prebrano besedilo razbije na posamezne besede ter jih po velikosti izpiše od najmanjše do največje v obliki seznama. Pri izpisu naj se morebitna 
ločila "držijo" svojih besed. Zraven besede izpišite še njeno velikost (ločila, ki se držijo besed, naj se ne štejejo k velikosti besede). Upoštevajte, da je lahko 
med besedami več kakor eno ločilo. Če se neka beseda ponovi dvakrat ali več, jo izpišite samo enkrat, in to brez ločil.
V primeru, da se zraven besede "drži" število, takšno besedo skupaj z njenimi ločili izpustite.
Opomba: kot ločilo štejte vsak znak, ki ni slovenska črka, število ali presledek. */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vrlinic_vanja_e1065215_naloga6_sklop3
{
    class Program
    {
        //podprogram, ki prešteje koliko je besed v nizu
        static int SteviloBesed(char[] besedilo)
        {
            int stevec = 1;
            //sprehodimo se skozi celoten niz znak po znak
            for (int i = 0; i < besedilo.Length; i++)
            {
                //preverimo ali je znak enak presledku, če je povečamo števec
                if (besedilo[i] == ' ')
                {
                    stevec++;
                }
            }
            return stevec;
        }

        //podprogram, ki loči niz znakov na besede
        static string[] LocevanjeBesed(char[] besedilo, string[] locenoBesedilo)
        {
            string beseda = "";
            int index = 0;
            //sprehodimo se čez celoten niz znak po znak
            for (int i = 0; i < besedilo.Length; i++)
            {
                //preverimo, če je znak različen presledku, če je lepimo znake v besedo, če ne pa imamo besedo, ki jo shranimo v polje
                if (besedilo[i] != ' ')
                {
                    beseda += besedilo[i];
                }
                else
                {
                    locenoBesedilo[index] = beseda;
                    index++;
                    //besedo na novo inicializiramo na prazen string
                    beseda = "";
                }
            }
            //zadnjo besedo, ki je za zadnjim presledkom zapise v polje
            locenoBesedilo[index] = beseda;
            return locenoBesedilo;
        }

        //podprogram, ki šteje števila v besedah
        static int StetjeStevil(string[] locenoBesedilo, int[] stevila)
        {
            int stevec = 0;
            //sprehodimo se skozi polje besed
            foreach (string beseda in locenoBesedilo)
            {
                //postavimo obstajaStevilo na false
                bool obstajaStevilo = false;
                //sprehodimo se čez vse znake besede
                for (int i = 0; i < beseda.Length; i++)
                {
                    //polje velikosti 10
                    for (int j = 0; j < stevila.Length; j++)
                    {
                        //za vsak znak v besedi preverjamo ali ustreza indexu polja števila, kjer so indexi 0-9, če ustreza nastavimo vrednost na true
                        if (beseda[i].ToString() == j.ToString())
                        {
                            obstajaStevilo = true;
                        }
                    }
                }
                //če je obstajaStevilo ostal enak, potem beseda ne vsebuje števila in povečamo števec
                if (obstajaStevilo == false)
                {
                    stevec++;
                }
            }
            return stevec;
        }

        //podprogram, ki uredi besede in izloči besede, ki vsebujejo števila
        static string[] OdstraniStevila(string[] locenoBesedilo, string[] odstranjeneStevilke, int[] stevila)
        {
            int index = 0;

            foreach (string beseda in locenoBesedilo)
            {
                bool obstajaStevilo = false;
                for (int i = 0; i < beseda.Length; i++)
                {
                    //za vsak znak v besedi preverimo ali je stevilo
                    for (int j = 0; j < stevila.Length; j++)
                    {
                        //če beseda vsebuje število nastavimo vrednost na true
                        if (beseda[i].ToString() == j.ToString())
                        {
                            obstajaStevilo = true;
                        }
                    }
                }
                //če beseda ni vsebovala števila jo zapišemo v polje
                if (obstajaStevilo == false)
                {
                    odstranjeneStevilke[index] = beseda;
                    index++;
                }
            }
            return odstranjeneStevilke;
        }
        //podprogram, ki šteje koliko besed imamo po ostranitvi besed s števili
        static int StetjeBesedBrezLocil(string[] odstranjeneStevilke)
        {
            int stevec = 0;
            //sprehodimo se skozi polje in za vsako besedo povečujemo števec za 1
            foreach (string beseda in odstranjeneStevilke)
            {
                stevec++;
            }
            return stevec;
        }
        //podprogram, ki besedam odstrani ločila 
        static string[] OdstranjevanjeLocil(string[] odstranjeneStevilke, string[] odstranjenaLocila)
        {
            string dolzina = "";
            int stevec = 0;
            //sprehodimo se skozi polje besed
            foreach (string beseda in odstranjeneStevilke)
            {
                //preverjamo znak po znak in izločimo ločila iz besede
                for (int i = 0; i < beseda.Length; i++)
                {
                    if (beseda[i] != '_' && beseda[i] != 'q' && beseda[i] != 'y' && beseda[i] != 'x' && beseda[i] != '.' && beseda[i] != ',' && beseda[i] != '!' && beseda[i] != '?' && beseda[i] != '"' && beseda[i] != '[' && beseda[i] != ']' && beseda[i] != '(' && beseda[i] != ')' && beseda[i] != '-' && beseda[i] != '{' && beseda[i] != '}' && beseda[i] != ';' && beseda[i] != ':')
                    {
                        dolzina += beseda[i];
                    }
                }
                //besede brez ločil shranimo v novo polje
                odstranjenaLocila[stevec] = dolzina;
                stevec++;
                //besedo inicializiramo na prazen string
                dolzina = "";
            }
            return odstranjenaLocila;
        }
        //podprogram, ki loči besede na ponavljajoče in neponavljajoče
        static string[] BesedeBrezPonavljanja(string[] odstranjenaLocila, string[] nePonavljajoceBesede, string[] ponavljajoceBesede)
        {
            int stevec = 0;
            int index = 0;
            //sprehodimo se skozi polje besed
            foreach (string beseda in odstranjenaLocila)
            {
                bool sePonavlja = false;
                //sprehodimo se skozi polje neponavljajocih besed
                for (int i = 0; i < nePonavljajoceBesede.Length; i++)
                {
                    //preverjamo ali se beseda med neponavljajočimi besedami ponavlja in če se jo shranimo v polje ponavljajočih besed
                    if (beseda == nePonavljajoceBesede[i])
                    {
                        sePonavlja = true;
                        ponavljajoceBesede[index] = beseda;
                        index++;
                    }
                }
                //če se beseda ne ponavljaja jo shranimo v polje neponavljajočih besed
                if (sePonavlja == false)
                {
                    nePonavljajoceBesede[stevec] = beseda;
                    stevec++;
                }
            }
            return nePonavljajoceBesede;
        }

        //podprogram, ki odstrani ponavljajoče besede iz ponavljajočih se besed
        static string[] PonavljanjePonavljajocihBesed(string[] ponavljajoceBesede, string[] ponPonovljenih)
        {
            int stevec = 0;
            //sprehodimo se skozi polje besed
            foreach (string beseda in ponavljajoceBesede)
            {
                bool sePonavlja = false;
                //sprehodimo se skozi polje ponovljenih besed
                for (int i = 0; i < ponPonovljenih.Length; i++)
                {
                    //preverimo ali beseda že obstaja v polju, če ja nastavimo vrednost na true
                    if (beseda == ponPonovljenih[i])
                    {
                        sePonavlja = true;
                    }
                }
                //če beseda v polju ponovljenih besed ne obstaja jo shranimo vanj
                if (sePonavlja == false)
                {
                    ponPonovljenih[stevec] = beseda;
                    stevec++;
                }
            }
            return ponPonovljenih;
        }
        //podprogram, ki prešteje število neponavljajočih besed v polju
        static int StetjeNePon(string[] nePonavljajoceBesede)
        {
            int stevec = 0;
            foreach (string beseda in nePonavljajoceBesede)
            {
                //preverjamo ali je vrednost besede različna null 
                if (beseda != null)
                {
                    stevec++;
                }
            }
            return stevec;
        }

        //podprogram, ki prešteje število ponavljajočih besed v polju
        static int StetjePon(string[] ponPonovljenih)
        {
            int stevec = 0;
            foreach (string beseda in ponPonovljenih)
            {
                //preverjamo ali je vrednost besede različna null 
                if (beseda != null)
                {
                    stevec++;
                }
            }
            return stevec;
        }

        //podprogram, ki prepiše neponavljajoče besede v manjše polje
        static string[] PrepisNeponovljenih(string[] nePonavljajoceBesede, string[] stNePonov)
        {
            int stevec = 0;
            //sprehodimo se skozi polje
            for (int i = 0; i < nePonavljajoceBesede.Length; i++)
            {
                //preverjamo ali je vrednost različna null, če je besedo prepišemo v novo polje
                if (nePonavljajoceBesede[i] != null)
                {
                    stNePonov[stevec] = nePonavljajoceBesede[i];
                    stevec++;
                }
            }
            return stNePonov;
        }

        //podprogram, ki prepiše ponavljajoče besede v manjše polje
        static string[] PrepisPonovljenih(string[] ponPonovljenih, string[] stPonov)
        {
            int stevec = 0;
            //sprehodimo se skozi polje
            for (int i = 0; i < ponPonovljenih.Length; i++)
            {
                //preverjamo ali je vrednost različna null, če je besedo prepišemo v novo polje
                if (ponPonovljenih[i] != null)
                {
                    stPonov[stevec] = ponPonovljenih[i];
                    stevec++;
                }
            }
            return stPonov;
        }

        //podprogram, ki besedam povrne ločila
        static string[] PovraciloLocil(string[] odstranjeneStevilke, string[] stNePonov, string[] povrnitevLocil)
        {
            string dolzina = "";
            int stevec = 0;
            //sprehodimo se skozi polje
            foreach (string beseda in odstranjeneStevilke)
            {
                //preverjamo znak po znak in izločimo ločila iz besede
                for (int i = 0; i < beseda.Length; i++)
                {
                    if (beseda[i] != '_' && beseda[i] != 'q' && beseda[i] != 'y' && beseda[i] != 'x' && beseda[i] != '.' && beseda[i] != ',' && beseda[i] != '!' && beseda[i] != '?' && beseda[i] != '"' && beseda[i] != '[' && beseda[i] != ']' && beseda[i] != '(' && beseda[i] != ')' && beseda[i] != '-' && beseda[i] != '{' && beseda[i] != '}' && beseda[i] != ';' && beseda[i] != ':')
                    {
                        dolzina += beseda[i];
                    }
                }
                //sprehodimo se skozi polje neponovljenih besed
                for (int j = 0; j < stNePonov.Length; j++)
                {
                    //primerjamo ali se beseda ujema z besedo iz polja, če se v novo polje na isto mesto(index) shranimo besedo z ločili
                    if (dolzina == stNePonov[j])
                    {
                        povrnitevLocil[j] = beseda;
                        stevec++;
                        //besedo inicializiramo na prazen string
                        dolzina = "";
                    }
                }
                dolzina = "";
            }
            return povrnitevLocil;
        }

        //podprogram prešteje koliko besed ima polje
        static int StetjeVrnjenihLocil(string[] povrnitevLocil)
        {
            int stevec = 0;
            //sprehodimo se shozi polje besed
            foreach (string beseda in povrnitevLocil)
            {
                //preverjamo ali je vrednost v polju različna null, če je povečamo števec za 1
                if (beseda != null)
                {
                    stevec++;
                }
            }
            return stevec;
        }
        //podprogram prepiše besede iz enega polja v manjše novo polje
        static string[] PrepisNeponavljajocih(string[] povrnitevLocil, string[] neponavljajoce)
        {
            int stevec = 0;
            //sprehodimo se skozi polje 
            for (int i = 0; i < povrnitevLocil.Length; i++)
            {
                //preverjamo ali je vrednost v polju različna null, če je besedo iz polja prepišemo v novo polje
                if (povrnitevLocil[i] != null)
                {
                    neponavljajoce[stevec] = povrnitevLocil[i];
                    stevec++;
                }
            }
            return neponavljajoce;
        }

        //podprogram zamenja ponavljajoče besede z ločili z ponavljajočimi besedami brez ločil
        static string[] ZdruzevanjePolj(string[] neponavljajoce, string[] stPonov, string[] zdruzenoPolje)
        {
            string dolzina = "";
            int stevec = 0;
            //sprehodimo se skozi polje besed
            foreach (string beseda in neponavljajoce)
            {
                //preverjamo besedo znak po znak in izločimo ločila iz besede
                for (int i = 0; i < beseda.Length; i++)
                {
                    if (beseda[i] != '_' && beseda[i] != 'q' && beseda[i] != 'y' && beseda[i] != 'x' && beseda[i] != '.' && beseda[i] != ',' && beseda[i] != '!' && beseda[i] != '?' && beseda[i] != '"' && beseda[i] != '[' && beseda[i] != ']' && beseda[i] != '(' && beseda[i] != ')' && beseda[i] != '-' && beseda[i] != '{' && beseda[i] != '}' && beseda[i] != ';' && beseda[i] != ':')
                    {
                        dolzina += beseda[i];
                    }
                }
                bool obstaja = false;
                //sprehodimo se skozi polje ponovljenih besed
                for (int i = 0; i < stPonov.Length; i++)
                {
                    //preverjamo ali se beseda pojavi v polju ponavljajočih besed, če se shranimo besedo brez ločil
                    if (dolzina == stPonov[i])
                    {
                        obstaja = true;
                        zdruzenoPolje[stevec] = dolzina;
                        stevec++;
                        dolzina = "";
                    }
                }
                //če je ni shranimo besedo z ločili
                if (obstaja == false)
                {
                    zdruzenoPolje[stevec] = beseda;
                    stevec++;
                    dolzina = "";
                }
            }
            return zdruzenoPolje;
        }

        //podprogram uredi besede od najmanjše do največje
        static string[] Uredi(string[] zdruzenoPolje, string[] novoBrezLocil)
        {
            string dolzina = "";
            int stevec = 0;
            //sprehodimo se skozi polje besed
            foreach (string beseda in zdruzenoPolje)
            {
                //sprehodimo se skozi besedo znak po znak in izločimo ločila
                for (int i = 0; i < beseda.Length; i++)
                {
                    if (beseda[i] != '_' && beseda[i] != 'q' && beseda[i] != 'y' && beseda[i] != 'x' && beseda[i] != '.' && beseda[i] != ',' && beseda[i] != '!' && beseda[i] != '?' && beseda[i] != '"' && beseda[i] != '[' && beseda[i] != ']' && beseda[i] != '(' && beseda[i] != ')' && beseda[i] != '-' && beseda[i] != '{' && beseda[i] != '}' && beseda[i] != ';' && beseda[i] != ':')
                    {
                        dolzina += beseda[i];
                    }
                }
                //besede brez ločil shranimo v novo polje
                novoBrezLocil[stevec] = dolzina;
                stevec++;
                dolzina = "";
            }

            //urejanje polja besed brez ločil od najmanjše do največje
            for (int j = 0; j < novoBrezLocil.Length; j++)
            {
                int najmanjsa = novoBrezLocil[j].Length;
                for (int k = 0; k < novoBrezLocil.Length - 1; k++)
                {
                    if (najmanjsa < novoBrezLocil[k].Length)
                    {
                        najmanjsa = novoBrezLocil[k].Length;

                        string zacasna = novoBrezLocil[j];
                        novoBrezLocil[j] = novoBrezLocil[k];
                        novoBrezLocil[k] = zacasna;
                    }
                }              
            }
            return novoBrezLocil;
        }

        //podprogram besedam v urejenem polju vrne ločila
        static string[] UrediVrniLocila(string[] zdruzenoPolje, string[] novoBrezLocil, string[] novoZLocili)
        {
            string dolzina = "";
            //sprehodimo se skozi polje besed
            foreach (string beseda in zdruzenoPolje)
            {
                //sprehodimo se skozi besedo znak po znak in izločimo ločila
                for (int i = 0; i < beseda.Length; i++)
                {
                    if (beseda[i] != '_' && beseda[i] != 'q' && beseda[i] != 'y' && beseda[i] != 'x' && beseda[i] != '.' && beseda[i] != ',' && beseda[i] != '!' && beseda[i] != '?' && beseda[i] != '"' && beseda[i] != '[' && beseda[i] != ']' && beseda[i] != '(' && beseda[i] != ')' && beseda[i] != '-' && beseda[i] != '{' && beseda[i] != '}' && beseda[i] != ';' && beseda[i] != ':')
                    {
                        dolzina += beseda[i];
                    }
                }
                //sprehodimo se skozi polje besed brez ločil
                for (int j = 0; j < novoBrezLocil.Length; j++)
                {
                    //primerjamo na katerem mestu mestu v polju se pojavi beseda ter na isto mesto (index) v novem polju shranimo besedo z ločili
                    if (dolzina == novoBrezLocil[j])
                    {
                        novoZLocili[j] = beseda;
                    }
                }
                dolzina = "";
            }

            //uredimo seznam gledena dolžino besede brez ločil in z ločili
            for (int z = 0; z < novoBrezLocil.Length; z++)
            {
                for (int k = 0; k < novoZLocili.Length; k++)
                {
                    if (novoBrezLocil[z].Length == novoBrezLocil[k].Length)
                    {
                        if (novoBrezLocil[z].Length < novoZLocili[k].Length)
                        {
                            if (novoZLocili[z].Length < novoZLocili[k].Length)
                            {
                                string zacasna = novoZLocili[z];
                                novoZLocili[z] = novoZLocili[k];
                                novoZLocili[k] = zacasna;
                            }
                        }
                    }
                }
            }
            return novoZLocili;
        }
        //glavni podprogram
        static void Main(string[] args)
        {
            //preberemo besedilo
            Console.Write("Vnesite niz: "); 
            string besede = Console.ReadLine();

            //inicializacija polja znakov
            char[] besedilo = new char[besede.Length];

            //besedilo shranimo v polje znakov
            for (int i = 0; i < besede.Length; i++)
            {
                besedilo[i] = besede[i];
            }

            //pridobimo velikost polja za besede
            int velikostPolja = SteviloBesed(besedilo);
            //inicializiramo polje z pridobljeno velikostjo
            string[] locenoBesedilo = new string[velikostPolja];
            //pridobimo polje besed
            locenoBesedilo = LocevanjeBesed(besedilo, locenoBesedilo);

            //inicializacija polja za primerjavo s števili
            int[] stevila = new int[10];

            //velikost polja z besedami brez števil
            int velikostLocenegaPolja = StetjeStevil(locenoBesedilo, stevila);
            string[] odstranjeneStevilke = new string[velikostLocenegaPolja];
            odstranjeneStevilke = OdstraniStevila(locenoBesedilo, odstranjeneStevilke, stevila);

            //velikost polja z besedami brez ločil
            int velBrezLocil = StetjeBesedBrezLocil(odstranjeneStevilke);
            string[] odstranjenaLocila = new string[velBrezLocil];
            odstranjenaLocila = OdstranjevanjeLocil(odstranjeneStevilke, odstranjenaLocila);

            //inicializacija neponavljajočih se besed in ponavljajočih se besed
            string[] nePonavljajoceBesede = new string[odstranjenaLocila.Length];
            string[] ponavljajoceBesede = new string[odstranjenaLocila.Length];

            nePonavljajoceBesede = BesedeBrezPonavljanja(odstranjenaLocila, nePonavljajoceBesede, ponavljajoceBesede);

            //inicializacija polja z odstranjenimi ponavljanji ponovljenih besed
            string[] ponPonovljenih = new string[odstranjenaLocila.Length];
            ponPonovljenih = PonavljanjePonavljajocihBesed(ponavljajoceBesede, ponPonovljenih);

            //velikost polj in inicializacija za ponavljajoče in neponavljajoče besede brez vrednosti null
            int velStNePon = StetjeNePon(nePonavljajoceBesede);
            string[] stNePonov = new string[velStNePon];
            stNePonov = PrepisNeponovljenih(nePonavljajoceBesede, stNePonov);

            int velStPonov = StetjePon(ponPonovljenih);
            string[] stPonov = new string[velStPonov];
            stPonov = PrepisPonovljenih(ponPonovljenih, stPonov);

            //inicializacija polja z vrnjenimi ločili neponovljenim besedam
            string[] povrnitevLocil = new string[velStNePon];
            povrnitevLocil = PovraciloLocil(odstranjeneStevilke, stNePonov, povrnitevLocil);

            int velLocil = StetjeVrnjenihLocil(povrnitevLocil);
            string[] neponavljajoce = new string[velLocil];
            neponavljajoce = PrepisNeponavljajocih(povrnitevLocil, neponavljajoce);

            //inicializacija združenega polja
            string[] zdruzenoPolje = new string[neponavljajoce.Length];
            zdruzenoPolje = ZdruzevanjePolj(neponavljajoce, stPonov, zdruzenoPolje);

            //inicializacija polja združenih besed brez ločil
            string[] novoBrezLocil = new string[zdruzenoPolje.Length];
            novoBrezLocil = Uredi(zdruzenoPolje, novoBrezLocil);

            //inicializacija polja združenih besed z ločili
            string[] novoZLocili = new string[zdruzenoPolje.Length];
            novoZLocili = UrediVrniLocila(zdruzenoPolje, novoBrezLocil, novoZLocili);

            //izpis besed z dolžino
            for (int j = 0; j < novoZLocili.Length; j++)
            {
                Console.WriteLine(novoZLocili[j] + " " + novoBrezLocil[j].Length);
            }

            Console.ReadLine();
        }
    }
}
