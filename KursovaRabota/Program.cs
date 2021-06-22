using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KursovaRabota
{
    class Program
    {
        public static void Main(string[] args)
        {
            string imaGalaktika;
            string vidGalaktika;
            string godiniGalaktika;
            string imeZvezda;
            int temperatura;
            double osvetenost;
            double masa;
            double razmer;
            string klasZvezda = "O";
            string imePlaneta;
            string vidPlaneta;
            string obitaema;
            string imeLuna;
            List<Galaxy> ListGalaktiki = new List<Galaxy>();
            List<Star> ListZvezdi = new List<Star>();
            List<Planet> ListPlaneti = new List<Planet>();
            List<Moon> ListLuni = new List<Moon>();
            string cmd = Console.ReadLine();

            while (cmd != "exit")
            {
                switch (cmd)
                {
                    // dobavqne na glaktiki kum list
                    case "add galaxy":

                        Console.WriteLine("Enter galaxy name, type and age:");
                        imaGalaktika = Console.ReadLine();
                        vidGalaktika = Console.ReadLine();
                        godiniGalaktika = Console.ReadLine();

                        var Galaxy = new Galaxy(imaGalaktika, vidGalaktika, godiniGalaktika);

                        ListGalaktiki.Add(Galaxy);
                        cmd = Console.ReadLine();

                        break;

                    // pokazvane na galaktikite ot list
                    case "list galaxies":
                        Console.WriteLine($"\n--- List of all researched galaxies ---");
                        for (int i = 0; i < ListGalaktiki.Count; i++)
                        {
                            ListGalaktiki[i].ShowGalaxyInfo();
                        }
                        Console.WriteLine($"--- End of galaxies list ---\n");
                        cmd = Console.ReadLine();

                        break;

                    // dobavqne na zvezdi kum list
                    case "add star":

                        Console.WriteLine("Enter star name, temperature, luminosity, mass and size");
                        imaGalaktika = Console.ReadLine();
                        imeZvezda = Console.ReadLine();
                        masa = double.Parse(Console.ReadLine());
                        razmer = double.Parse(Console.ReadLine());
                        temperatura = int.Parse(Console.ReadLine());
                        osvetenost = double.Parse(Console.ReadLine());

                        // Integrirane na dadenite formuli za masa, temperatura, luminosity i razmer
                        if (temperatura >= 30000 && osvetenost >= 30000 && masa >= 16 && razmer >= 6.6)
                        {
                            klasZvezda = "0";
                        }

                        else if ((temperatura >= 10000 && temperatura < 30000) && (osvetenost >= 25 && osvetenost < 30000) && (masa >= 2.1 && masa < 16) && (razmer >= 1.8 && razmer < 6.6))
                        {
                            klasZvezda = "B";
                        }

                        else if ((temperatura >= 7500 && temperatura < 10000) && (osvetenost >= 5 && osvetenost < 25) && (masa >= 1.4 && masa < 2.1) && (razmer >= 1.4 && razmer < 1.8))
                        {
                            klasZvezda = "A";
                        }

                        else if ((temperatura >= 6000 && temperatura < 7500) && (osvetenost >= 1.5 && osvetenost < 5) && (masa >= 1.04 && masa < 1.4) && (razmer >= 1.15 && razmer < 1.4))
                        {
                            klasZvezda = "F";
                        }

                        else if ((temperatura >= 5200 && temperatura < 6000) && (osvetenost >= 0.6 && osvetenost < 1.5) && (masa >= 0.8 && masa < 1.04) && (razmer >= 0.96 && razmer < 1.15))
                        {
                            klasZvezda = "G";
                        }

                        else if ((temperatura >= 3700 && temperatura < 5200) && (osvetenost >= 0.08 && osvetenost < 0.6) && (masa >= 0.45 && masa < 0.8) && (razmer >= 0.7 && razmer < 0.96))
                        {
                            klasZvezda = "K";
                        }

                        else if ((temperatura >= 2400 && temperatura < 3700) && (osvetenost <= 0.08) && (masa >= 0.08 && masa < 0.45) && (razmer <= 0.7))
                        {
                            klasZvezda = "M";
                        }


                        var Star = new Star(imeZvezda, klasZvezda, temperatura, osvetenost, masa, razmer);

                        ListZvezdi.Add(Star);
                        cmd = Console.ReadLine();

                        break;

                    // pokazvane na zvezdite ot lista
                    case "list stars":
                        for (int i = 0; i < ListZvezdi.Count; i++)
                        {
                            Console.WriteLine($"\nStar info:\n");
                            ListZvezdi[i].ShowStarInfo();
                        }
                        cmd = Console.ReadLine();

                        break;


                    // dobavqne na planeti kum lista za planeti
                    case "add planet":

                        Console.WriteLine("Enter planet name, type and if habitable:");
                        imeZvezda = Console.ReadLine();
                        imePlaneta = Console.ReadLine();
                        vidPlaneta = Console.ReadLine();
                        obitaema = Console.ReadLine();

                        var Planet = new Planet(imePlaneta, vidPlaneta, obitaema);

                        ListPlaneti.Add(Planet);
                        cmd = Console.ReadLine();

                        break;
                    // pokazvane na planetite ot lista
                    case "list planets":
                        for (int i = 0; i < ListPlaneti.Count; i++)
                        {
                            Console.WriteLine($"\nPlanet info:\n");
                            ListPlaneti[i].ShowPlanetInfo();
                        }
                        cmd = Console.ReadLine();

                        break;


                    // dobavqne na luni kum lista
                    case "add moon":

                        Console.WriteLine("Enter moon name:");
                        imePlaneta = Console.ReadLine();
                        imeLuna = Console.ReadLine();

                        var Moon = new Moon(imeLuna);

                        ListLuni.Add(Moon);
                        cmd = Console.ReadLine();

                        break;
                    // pokazvane na lunite ot lista za luni
                    case "list moons":
                        for (int i = 0; i < ListLuni.Count; i++)
                        {
                            Console.WriteLine($"\nMoon info:\n");
                            ListLuni[i].ShowMoonInfo();
                        }
                        cmd = Console.ReadLine();

                        break;


                    case "stats":
                        int a = ListGalaktiki.Count;
                        int b = ListZvezdi.Count;
                        int c = ListPlaneti.Count;
                        int d = ListLuni.Count;
                        Console.WriteLine("--- Stats ---");
                        Console.WriteLine($"Galaxies: {a}");
                        Console.WriteLine($"Stars: {b}");
                        Console.WriteLine($"Planets: {c}");
                        Console.WriteLine($"Moons: {d}");
                        Console.WriteLine("--- End of stats ---");
                        cmd = Console.ReadLine();
                        break;
                }
            }
            while (cmd == "exit")
            {
                return;
            }

        }
    }
}
