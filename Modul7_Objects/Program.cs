using Modul8;
using System;
using System.Runtime.ConstrainedExecution;

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

                    if (i == 0 || indtastedeTekster[i].Length < kortesteTekst.Length)
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

                for (int i = 0; i < mineTal.Length; i++)
                {
                    mineTal[i] = i;

                }

                mineTal = mineTal.OrderBy(x => myRandom.Next()).ToArray();

                foreach (int i in mineTal) { Console.WriteLine(i + 1); }


            }

            // Øvelse 7
            static void ExersizeSeven()
            {
                Console.Clear();
                Console.WriteLine("Øvelse 7.");

                // Lav et program, hvor brugeren kan indtaste 5 tekster.
                // Programmet skal derefter udskrive teksterne i tilfældig orden.

                string[] tekster = new string[5];
                Random myRandom = new Random();

                for(int i = 0; i < tekster.Length; i++)
                {
                    Console.WriteLine("Indtast tekst nr {0}", tekster[i]);
                    tekster[i] = Console.ReadLine();
                }

                tekster = tekster.OrderBy(x => myRandom.Next()).ToArray();

                foreach(string tekst in tekster) { Console.WriteLine(tekst); }               
            }

            // Øvelse 8
            static void ExersizeEight()
            {
                Console.Clear();
                Console.WriteLine("Øvelse 8.");

                // Lav et program, som kan opfinde beskrivelser af ting.
                // En beskrivelse består af en størrelse -
                // (kæmpestor, stor, lille, lillebitte) en farve (rød, gul, grøn) -
                // og en type (kasse, bold, rygsæk, bil, legeplads).
                // Lav programmet så det udskriver 10 tilfældige beskrivelser.

                Ting[] listeMedTing = new Ting[10];
                string[] størrelse = {"Stor", "Lille", "Lillebitte"};
                string[] farve = {"Rød", "Gul", "Grøn"};
                string[] tingType = {"Kasse", "Bold", "Rygsæk", "Bil", "Legeplads"};
                Random myRandomizer = new Random();              
                                             

                for(int i = 0;i < 10;i++) {

                    størrelse = størrelse.OrderBy(x => myRandomizer.Next(0, størrelse.Length - 1)).ToArray();
                    farve = farve.OrderBy(x => myRandomizer.Next()).ToArray();
                    tingType = tingType.OrderBy(x => myRandomizer.Next()).ToArray();

                    listeMedTing[i] = new Ting(størrelse[0], farve[0], tingType[0] );
                    Console.WriteLine(listeMedTing[i]);

                    //if (Array.IndexOf  listeMedTing[i]  ){
                    //    Console.WriteLine("eksisterer allerede");
                        
                    //}
                }
                

                //Kan du udvide programmet, så det sikrer, at der kommer 10 forskellige, tilfældige beskrivelser?
            }

            // Øvelse 9
            static void ExersizeNine()
            {
                Console.Clear();
                Console.WriteLine("Øvelse 9.");

                int[] indtastedeTal = new int[10];


                for (int tal = 0; tal < 10; tal++)
                {

                    Console.WriteLine("\nIndtast tal:");
                    indtastedeTal[tal] = Convert.ToInt32(Console.ReadLine());

                    for (int j = 0; j <= tal; j++)
                    {
                        Console.Write("Dine tal indtal videre: {0}, ", indtastedeTal[j]);
                    }

                }
            }

            // Øvelse 10
            static void ExersizeTen()
            {
                Console.Clear();
                Console.WriteLine("Øvelse 10.");

                int[] mineFireTal = new int[4];


                for (int i = 0; i < mineFireTal.Length; i++)
                {
                    Console.WriteLine("indtast tal {0}", i);
                    mineFireTal[i] = Convert.ToInt32(Console.ReadLine());
                }

                int midlertidigObevaring1 = mineFireTal[0];
                int midlertidigObevaring2 = mineFireTal[2];

                mineFireTal[0] = mineFireTal[1];
                mineFireTal[1] = midlertidigObevaring1;
                mineFireTal[2] = mineFireTal[3];
                mineFireTal[3] = midlertidigObevaring2;

                Console.WriteLine();

                // Udskriv
                for (int tal = 0; tal < mineFireTal.Length; tal++)
                {
                    Console.WriteLine(mineFireTal[tal]);
                }

            }
        }
    }
}