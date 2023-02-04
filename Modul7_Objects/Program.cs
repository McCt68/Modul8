using System;

namespace Modul7_Objects
{

    internal class Program
    {
        static void Main(string[] args)
        {
            // User menu
            // Console.WriteLine("\nVælg den øvelse du vil se. 1 - 10");

            bool stayInLoop = true;


            while (stayInLoop)
            {
                Console.WriteLine("\nVælg den øvelse du vil se. 1 - 10, eller Nul hvis du vil afslutte programmet");


                string exersizeNumber = Console.ReadLine();

                switch (exersizeNumber)
                {
                    case "1":
                        ExersizeOne();
                        break;

                    case "2":
                        ExersizeTwo();
                        break;

                    case "3":
                        ExersizeTree();
                        break;

                    case "4":
                        ExersizeFour();
                        break;

                    case "5":
                        ExersizeFive();
                        break;

                    case "6":
                        ExersizeSix();
                        break;

                    case "7":
                        ExersizeSeven();
                        break;

                    case "8":
                        ExersizeEight();
                        break;

                    case "9":
                        ExersizeNine();
                        break;

                    case "10":
                        ExersizeTen();
                        break;

                    case "0":
                        Console.WriteLine("Programmet afsluttes. Tak for denne gang");
                        stayInLoop = false;
                        break;

                    default:
                        Console.WriteLine("Ugyldigt valg. Prøv venligst igen.");
                        break;


                }

            }

            // Øvelse 1
            static void ExersizeOne()
            {
                Console.Clear();
                Console.WriteLine("Øvelse 1\n");

            }

            // Øvelse 2
            static void ExersizeTwo()
            {
                Console.Clear();
                Console.WriteLine("Øvelse 2");
            }

            // Øvelse 3
            static void ExersizeTree()
            {
                Console.Clear();
                Console.WriteLine("Øvelse 3");

                int[] indtastedeTal = new int[5];

                for (int i = 0; i < indtastedeTal.Length; i++)
                {
                    Console.WriteLine("Indtast tal nr {0}: ", i + 1);
                    indtastedeTal[i] = Convert.ToInt32(Console.ReadLine());
                }
                Console.WriteLine("\nDine indtaste tal i sorteret i række følge er: ");
                Array.Sort(indtastedeTal);

                foreach (int i in indtastedeTal)
                {
                    Console.WriteLine("{0}", i);
                }


            }

            // Øvelse 4
            static void ExersizeFour()
            {
                Console.Clear();
                Console.WriteLine("Øvelse 4");

                int[] indtastedeTal = new int[5];

                for (int i = 0; i < indtastedeTal.Length; i++)
                {
                    Console.WriteLine("Indtast tal nr {0}: ", i + 1);
                    indtastedeTal[i] = Convert.ToInt32(Console.ReadLine());
                }
                Console.WriteLine("\nDine indtaste tal i med det højestetal først er: ");
                Array.Sort(indtastedeTal);
                Array.Reverse(indtastedeTal);
                foreach (int i in indtastedeTal)
                {
                    Console.WriteLine("{0}", i);
                }
            }

            // Øvelse 5
            static void ExersizeFive()
            {
                Console.Clear();
                Console.WriteLine("Øvelse 5.");

                string[] indtastedeTekster = new string[3];
                string kortesteTekst = indtastedeTekster[0];

                for (int i = 0; i < indtastedeTekster.Length; i++)
                {
                    Console.WriteLine(i);

                    Console.WriteLine($"Indtast tekst Nr. {i + 1}");
                    indtastedeTekster[i] = Console.ReadLine();

                    // Få længden på teksten i array index i
                    Console.WriteLine("Længden på den indtaste text er: {0} tegn", indtastedeTekster[i].Length);

                    if ( i == 0 || indtastedeTekster[i].Length < kortesteTekst.Length)
                    {
                        // korteste = indtastedeTekster[i].Length;
                        kortesteTekst = indtastedeTekster[i];
                    }

                }
                Console.WriteLine("Den korteste text var: {0} tegn. Den var: {1} chars lang"
                    , kortesteTekst, kortesteTekst.Length); 


            }

            // Øvelse 6 
            static void ExersizeSix()
            {
                Console.Clear();
                Console.WriteLine("Øvelse 6.");

                int[] mineTal = new int[13];
                Random myRandom = new Random();

                for(int i = 0; i < mineTal.Length; i++)
                {
                    mineTal[i] = i;
                        
                }

                mineTal = mineTal.OrderBy( x => myRandom.Next()).ToArray();
                
                foreach(int i in mineTal) { Console.WriteLine(i + 1); }
                
            
            }

            // Øvelse 7
            static void ExersizeSeven() { }

            // Øvelse 8
            static void ExersizeEight() { }

            // Øvelse 9
            static void ExersizeNine() { }

            // Øvelse 10
            static void ExersizeTen() { }


        }
    }
}