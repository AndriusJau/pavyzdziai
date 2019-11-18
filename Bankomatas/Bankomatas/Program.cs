using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankomatas
{
    class Program
    {
        public static int PIN = 1234;
        public static Saskaita saskaita = new Saskaita() { Likutis = 1000 };

        static void Main(string[] args)
        {
            PasirinktiKalba();
            IvestiPIN();

            Console.ReadLine();
        }

        static void PasirinktiKalba()
        {
            Console.WriteLine($"Pasirinkite kalba:\n1-LT\n2-EN\n3-RU");
            int kalbosPasirinkimas = Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            switch (kalbosPasirinkimas)
            {
                case 1:
                    Console.WriteLine("Sveiki atvyke!");
                    break;
                case 2:
                    Console.WriteLine("Hello!");
                    break;
                case 3:
                    Console.WriteLine("Zravstvuyte!");
                    break;
                default:
                    Console.WriteLine("Nera tokio pasirinkimo");
                    PasirinktiKalba();
                    break;
            }
        }

        static void IvestiPIN()
        {
            for (int i = 0; i < 3; i++)
            {
                Console.Write("Iveskite PIN koda: ");
                int ivestasPIN = Convert.ToInt32(Console.ReadLine());

                if (ivestasPIN == PIN)
                {
                    Console.Clear();
                    Console.WriteLine("PIN kodas ivestas teisingai");
                    Meniu();
                    break;
                }
                else if (ivestasPIN != PIN && i == 2)
                {
                    Console.Clear();
                    Console.WriteLine("Jus suklydote 3 kartus ir jusu kortele uzblokuota");
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine($"Neteisingas PIN kodas, bandykite dar karta. Liko bandymu: {3 - (i + 1)}");
                }
            }
        }

        static void Meniu()
        {
            Console.WriteLine("1 - Keisti kalba \n2 - Keisti PIN koda \n3 - Saskaitos likutis");
            Console.WriteLine("4 - Saskaitos israsas \n5 - Inesti pinigus \n6 - Pasiimti pinigus \n7 - Baigti darba");

            int pasirinkimas = Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            switch (pasirinkimas)
            {
                case 1:
                    PasirinktiKalba();
                    GrizimasIMeniu();
                    break;
                case 2:
                    KeistiPINKoda();
                    GrizimasIMeniu();
                    break;
                case 3:
                    SaskaitosLikutis();
                    GrizimasIMeniu();
                    break;
                case 4:
                    SaskaitosIsrasas();
                    GrizimasIMeniu();
                    break;
                case 5:
                    InestiPinigus();
                    GrizimasIMeniu();
                    break;
                case 6:
                    IsimtiPinigus();
                    GrizimasIMeniu();
                    break;
                case 7:
                    Console.WriteLine("Aciu uz apsilankyma. Geros dienos!");
                    break;
                default:
                    Console.WriteLine("Nera tokio pasirinkimo");
                    GrizimasIMeniu();
                    break;
            }
        }

        static void KeistiPINKoda()
        {
            Console.WriteLine("Iveskite dabartini PIN koda: ");
            int ivestasPIN = Convert.ToInt32(Console.ReadLine());

            if (ivestasPIN == PIN)
            {
                Console.WriteLine("Iveskite nauja PIN koda: ");
                int naujasPIN = Convert.ToInt32(Console.ReadLine());
                PIN = naujasPIN;
                Console.WriteLine("PIN kodas sekmingai pakeistas");
            }
            else
            {
                Console.WriteLine("Neteisingai ivestas PIN, bandykite dar karta");
                KeistiPINKoda();
            }
        }

        static void SaskaitosLikutis()
        {
            Console.WriteLine($"Jusu saskaitos likutis: {saskaita.Likutis}");
        }

        static void InestiPinigus()
        {
            Console.WriteLine("Priimamos kupiuros: 5, 10, 20, 50, 100");
            Console.Write("Iveskita suma kuria norite inesti i saskaita: ");

            int inesamaSuma = Convert.ToInt32(Console.ReadLine());

            if (inesamaSuma % 5 == 0)
            {
                Tranzakcija tranzakcija = new Tranzakcija()
                {
                    Suma = inesamaSuma,
                    Data = DateTime.Now,
                    Paskirtis = "Inesimas i bankomata",
                    Valiuta = Valiuta.EUR
                };

                saskaita.OperSarasas.Add(tranzakcija);
                saskaita.Likutis = saskaita.Likutis + inesamaSuma;
                Console.WriteLine($"Jus inesete {inesamaSuma} EUR i savo saskaita");
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Netinkamos kupiuros, bankykite dar karta");
                InestiPinigus();
            }
        }

        static void IsimtiPinigus()
        {
            Console.WriteLine($"Saskaitos likutis: {saskaita.Likutis}");
            Console.WriteLine("Galimi nominalai: 5, 10, 20, 50, 100");
            Console.Write("Iveskita suma kuria norite isimti is saskaitos: ");
            int isimamaSuma = Convert.ToInt32(Console.ReadLine());

            if (isimamaSuma % 5 == 0)
            {
                if (isimamaSuma <= saskaita.Likutis)
                {
                    Tranzakcija tranzakcija = new Tranzakcija()
                    {
                        Suma = isimamaSuma,
                        Data = DateTime.Now,
                        Paskirtis = "Nuemimas is bankomato",
                        Valiuta = Valiuta.EUR
                    };

                    saskaita.OperSarasas.Add(tranzakcija);
                    saskaita.Likutis = saskaita.Likutis - isimamaSuma;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Jusu saskaitoje nepakankamas likutis, bandykite dar karta");
                    IsimtiPinigus();
                }
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Ivesta suma negalima, netinkamas nominalas. Bandykite dar karta.");
                IsimtiPinigus();
            }
        }

        static void GrizimasIMeniu()
        {
            Console.WriteLine("\nNoredami grizti i Meniu spauskite 1");
            Console.WriteLine("Noredami baigti darba spauskite 2");

            int pasirinkimas = Convert.ToInt32(Console.ReadLine());

            switch (pasirinkimas)
            {
                case 1:
                    Console.Clear();
                    Meniu();
                    break;
                case 2:
                    Console.Clear();
                    Console.WriteLine("Aciu uz apsilankyma. Geros dienos!");
                    break;
                default:
                    break;
            }
        }

        static void SaskaitosIsrasas()
        {
            foreach (var tranzakcija in saskaita.OperSarasas)
            {
                Console.WriteLine($"{tranzakcija.Suma}; {tranzakcija.Paskirtis}; {tranzakcija.Data}");
            }
        }
    }
}

