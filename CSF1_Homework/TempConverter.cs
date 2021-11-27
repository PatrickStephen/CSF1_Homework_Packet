using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSF1_Homework
{
    class TempConverter
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Temp Converter...");
            Console.WriteLine();

            bool repeat = true;
            do
            {

                Console.WriteLine("-= Celcius and Fahrenheit Conversions =-");
                Console.WriteLine(@"
F) Fahrenheit to Celcius
C) Celcius to Fahrenheit
");
                string userChoice = Console.ReadLine().ToLower();
                
                Console.Clear();

                //Variables
                //int celToFah = Convert.ToDecimal(fah = cel * (9.0 / 5.0) + 32);
                switch (userChoice)
                {
                    case "f":
                    case "fahrenheit":

                        Console.Write("Write a number to convert from Celcius to Fahrenheit...");
                        double cel = Convert.ToDouble(Console.ReadLine());
                        double fah = cel * (9.0 / 5.0) + 32;
                        Console.WriteLine("That would be " + fah + " in Fahrenheit.");
                        Console.WriteLine("Would you like to make another conversion? Y/N ");
                        ConsoleKey userChoice2 = Console.ReadKey().Key;
                        switch (userChoice2)
                        {
                            case ConsoleKey.Y:
                                repeat = true;
                                Console.Clear();
                                break;

                            default:
                                repeat = false;
                                break;
                        }
                        break;


                    case "c":
                    case "celcius":

                        Console.Write("Write a number to convert from Fahrenheit to Celcius...");
                        double fah2 = Convert.ToDouble(Console.ReadLine());
                        double cel2 = (fah2 - 32) / (9.0 / 5.0);
                        Console.WriteLine("That would be " + cel2 + " in Celcius.");
                        Console.WriteLine("Would you like to make another conversion? Y/N ");
                        ConsoleKey userChoice3 = Console.ReadKey().Key;
                        switch (userChoice3)
                        {
                            case ConsoleKey.Y:
                                repeat = true;
                                Console.Clear();
                                break;

                            default:
                                repeat = false;
                                break;
                        }
                        break;

                    default:
                        Console.WriteLine("That was an invalid selection, please choose again..or else...");
                        break;
                }
            } while (repeat);
            



            //Calculation


            Console.WriteLine();
        }
    }
}
