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

                // Øvelse 5.1
                static void ExersizeOne()
                {
                    Console.WriteLine("Øvelse 1\n");
                    
                }

                // Øvelse 5.1
                static void ExersizeTwo()
                {
                    Console.WriteLine("Øvelse 2");
                }

                // Øvelse 5.1
                static void ExersizeTree() { }

                // Øvelse 5.1
                static void ExersizeFour() { }

                // Øvelse 5.1
                static void ExersizeFive() { }

                // Øvelse 5.1
                static void ExersizeSix() { }

                // Øvelse 5.1
                static void ExersizeSeven() { }

                // Øvelse 5.1
                static void ExersizeEight() { }

                // Øvelse 5.1
                static void ExersizeNine() { }

                // Øvelse 5.1
                static void ExersizeTen() { }

            
        }
    }
}