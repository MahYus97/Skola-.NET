using System;

namespace Rock_Paper_Scissors
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Random random = new Random();
            bool spelaigen = true;

            string spelare;
            string computer;
            string svar;

            while (spelaigen)
            {
                spelare = "";
                computer = "";
                svar = "";

                while (spelare != "STEN" && spelare != "SAXS" && spelare != "PÅSE")
                {
                    Console.Write("VÄLJ STEN, SAXS eller PÅSE: ");
                    spelare = Console.ReadLine();
                    spelare = spelare.ToUpper();

                    switch (random.Next(1, 4))
                    {
                        case 1:
                            computer = "STEN";
                            break;

                        case 2:
                            computer = "SAXS";
                            break;

                        case 3:
                            computer = "PÅSE";
                            break;

                        default:
                            Console.WriteLine("\nOgiltigt svar");
                            break;
                    }

                    Console.WriteLine("\nSpelare: " + spelare);
                    Console.WriteLine("\nComputer: " + computer);

                    switch (spelare)
                    {
                        case "STEN":
                            if (computer == "STEN")
                            {
                                Console.WriteLine("\nDet är oavgjort!\n");
                            }
                            else if (computer == "PÅSE")
                            {
                                Console.WriteLine("\nDu förlorar!\n");
                            }
                            else if (computer == "SAXS")
                            {
                                Console.WriteLine("\nDu vinner!\n");
                            }
                            else
                            {
                                Console.WriteLine("\nOgiltigt svar");
                                continue;
                            }
                            break;

                        case "SAXS":
                            if (computer == "PÅSE")
                            {
                                Console.WriteLine("\nDU VINNER!");
                            }
                            else if (computer == "SAXS")
                            {
                                Console.WriteLine("\nDet är oavgjort!\n");
                            }
                            else if (computer == "STEN")
                            {
                                Console.WriteLine("\nDu förlorar!\n");
                            }
                            else
                            {
                                Console.WriteLine("\nOgiltigt svar");
                                continue;
                            }
                            break;

                        case "PÅSE":
                            if (computer == "SAXS")
                            {
                                Console.WriteLine("\nDu förlorar!\n");
                            }
                            else if (computer == "STEN")
                            {
                                Console.WriteLine("\nDU VINNER!\n");
                            }
                            else if (computer == "PÅSE")
                            {
                                Console.WriteLine("\nDet är aovgjort!\n");
                            }
                            else
                            {
                                Console.WriteLine("\nOgiltigt svar");
                                continue;
                            }
                            break;
                    }
                }

                Console.Write("Vill du spela igen (J/N):");
                svar = Console.ReadLine();
                svar = svar.ToUpper();

                if (svar == "J")
                {
                    spelaigen = true;
                    Console.Clear();
                }
                else
                {
                    spelaigen = false;
                }
            }

            Console.WriteLine("Välkomen åter");

            Console.ReadKey();
        }
    }
}