using System;
using System.Diagnostics;
using System.Threading;

namespace Kromer_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Kromer Calculator v.2.5.0";

            /*
            Random LoadingRand = new Random();

            int LoadingRandom = LoadingRand.Next(500, 2001);
            int LoadingRandom02 = LoadingRand.Next(500, 2001);
            int LoadingRandom03 = LoadingRand.Next(500, 2001);
            int LoadingRandom04 = LoadingRand.Next(500, 2001);
            int LoadingRandom05 = LoadingRand.Next(500, 2001);
            int LoadingRandom06 = LoadingRand.Next(500, 2001);
            */

            Console.ForegroundColor = ConsoleColor.Red;

            /*
            Console.WriteLine("Loading.");
            Thread.Sleep(LoadingRandom);
            Console.WriteLine("Loading..");
            Thread.Sleep(LoadingRandom02);
            Console.WriteLine("Loading...\n");
            Thread.Sleep(LoadingRandom03);
            */

            Console.WriteLine("Program Name: Kromer Calculator");
            Console.WriteLine("Program Version: v.2.5.0");
            Console.WriteLine("Developer: Livin' On The Streetz");
            Console.WriteLine("Website: https://streetz-programs-download.000webhostapp.com/ ");
            Console.WriteLine("Creation Date: Saturday 06.11.2021");
            Console.WriteLine("Latest Update: Sunday 14.11.2021 (Version 2.5.0)\n");

            /*
            Console.WriteLine("Loading.");
            Thread.Sleep(LoadingRandom04);
            Console.WriteLine("Loading..");
            Thread.Sleep(LoadingRandom05);
            Console.WriteLine("Loading...\n");
            Thread.Sleep(LoadingRandom06);
            */
            Console.WriteLine("Press 'H' to view The Change Log Menu\n");

            Console.ForegroundColor = ConsoleColor.White;

            Console.Write("Current [[ Kromer ]] value: ");

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("1 Euro = 0,5 [[ Kromer ]]");

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("--Press Q to Quit | Press C to Calculate Kromer | For a full list of commands type G--\n");

            while (true)
            {
                switch (Console.ReadKey().Key)
                {
                    case ConsoleKey.C:
                        calculator();
                        break;
                    case ConsoleKey.Q:
                        quit();
                        break;
                    case ConsoleKey.H:
                        changeLog();
                        break;
                    case ConsoleKey.R:
                        Console.Clear();
                        Console.Write("Current [[ Kromer ]] value: ");

                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("1 Euro = 0,5 [[ Kromer ]]");

                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("--Press Q to Quit | Press C to Calculate Kromer | For a full list of commands type G--");
                        break;
                    case ConsoleKey.G:
                        commandList();
                        break;
                    case ConsoleKey.L:
                        toDoList();
                        break;
                    case ConsoleKey.B:
                        becomeABigShot();
                        break;
                    case ConsoleKey.E:
                        barrage();
                        break;
                    case ConsoleKey.Y:
                        missYString();
                        break;
                    case ConsoleKey.T:
                        curencies();
                        break;
                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\nERROR: Unknown Keybind\n");
                        Console.ForegroundColor = ConsoleColor.White;
                        break;
                }
            }

        }
        static double euroCalculator(double number)
        {
            double ammount02 = Convert.ToDouble(number * Math.Sqrt(Math.PI) - 2 * 0.5 + 1.1);

            return (ammount02);
        }

        //----------------------------------------------------------------------------------------------

        static double kromerCalculator(double number)
        {
            double ammount02 = Convert.ToDouble(number / Math.Sqrt(Math.PI));

            return (ammount02);
        }

        //----------------------------------------------------------------------------------------------

        static double plnCalculator(double number)
        {
            double ammount02 = Convert.ToDouble(number / Math.Sqrt(Math.PI) / 2);

            return (ammount02);
        }

        //----------------------------------------------------------------------------------------------

        static double dlrCalculator(double number)
        {
            double ammount02 = Convert.ToDouble(number / Math.Sqrt(Math.PI) - 2);

            return (ammount02);
        }

        //----------------------------------------------------------------------------------------------

        static double lraCalculator(double number)
        {
            double ammount02 = Convert.ToDouble(number / Math.Sqrt(Math.PI) / 10);

            return (ammount02);
        }

        //----------------------------------------------------------------------------------------------

        static double pndCalculator(double number)
        {
            double ammount02 = Convert.ToDouble(number / Math.Sqrt(Math.PI) + 2);

            return (ammount02);
        }

        //----------------------------------------------------------------------------------------------

        static void quit()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(" - Are you sure you want to quit? (yes/no)\n");
            Console.ForegroundColor = ConsoleColor.White;
            Process MyProcess = Process.GetCurrentProcess();
            while (true)
            {
                string decision = Console.ReadLine();
                if (decision == "yes")
                {
                    MyProcess.Kill();
                }
                else if (decision == "no")
                {
                    Console.WriteLine(" ");
                    break;
                }
            }
            Console.WriteLine("--Press Q to Quit | Press C to Calculate Kromer | For a full list of commands type G--");
        }

        //----------------------------------------------------------------------------------------------

        static void calculator()
        {

            Console.WriteLine(" - Do you want to calculate Euro to Kromer or Kromer to Euro (type 1 or 2)");

            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Console.Write("\nEuro to Kromer - Write any number: ");
                    double kromer01 = Convert.ToDouble(Console.ReadLine());

                    Console.BackgroundColor = ConsoleColor.White;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine(kromerCalculator(kromer01));
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.ForegroundColor = ConsoleColor.White;

                    Console.WriteLine("Press Q to Quit and C to Calculate more [[ Kromer ]]\n");
                    break;
                case 2:
                    Console.Write("\nKromer to Euro - Write any number: ");
                    double kromer02 = Convert.ToDouble(Console.ReadLine());

                    Console.BackgroundColor = ConsoleColor.White;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine(euroCalculator(kromer02));
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.ForegroundColor = ConsoleColor.White;

                    Console.WriteLine("Press Q to Quit and C to Calculate more [[ Kromer ]]\n");
                    break;
            }
        }

        //----------------------------------------------------------------------------------------------

        static void changeLog()
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("\n--- Change Log Select Menu ---\n");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("- Press F1 to view version 2.0.0 changes\n");
            Console.WriteLine("- Press F2 to view version 2.5.0 changes\n");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n- Download previous versions from -- https://kromer-calculator-versions.000webhostapp.com/ \n");
            Console.ForegroundColor = ConsoleColor.White;

            switch (Console.ReadKey().Key)
            {
                case ConsoleKey.F1:
                    v2();
                    break;
                case ConsoleKey.F2:
                    v25();
                    break;
                default:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nERROR: Unknown Keybind\n");
                    Console.ForegroundColor = ConsoleColor.White;
                    break;

            }
        }

        //----------------------------------------------------------------------------------------------

        static void commandList()
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("\n--- Commands ---\n");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("- Press Q to Quit\n- Press C to Calculate Euro to Kromer\n- Press R to Clear Console\n- Press T to view avalible currencies\n- Press Y to calculate Miss Y's String\n- Press B to become a [[Big Shot]] !!\n- Press E to barrage\n");
        }

        //----------------------------------------------------------------------------------------------

        static void toDoList()
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("\n--- Secret Developer Only To Do List (if you're seeing this you are kromern't) ---\n");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("nie ma nic do zrobienia ;)");

        }

        //----------------------------------------------------------------------------------------------

        static void becomeABigShot()
        {
            Process MyProcess = Process.GetCurrentProcess();
            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.Black;

            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine(" - Becoming a [[ Big Shot ]] isn't avalible in your country");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;

            Thread.Sleep(5500);
            MyProcess.Kill();
        }

        //----------------------------------------------------------------------------------------------

        static void barrage()
        {
            while (true)
            {
                Process MyProcess = Process.GetCurrentProcess();

                for (var i = 0; i < 10000; i++)
                {
                    Console.WriteLine("CRINGE BARRAGES FIRST NOOB!");
                    Console.WriteLine("ORA!");
                    //MyProcess.StartInfo.FileName = "C:/Users/streetz/Desktop/ORA.exe";
                    //MyProcess.Start();
                }
                MyProcess.Kill();
            }
        }

        //----------------------------------------------------------------------------------------------

        static void missYString()
        {
            Console.WriteLine(" - Write a number you would want to be calculated with Miss Y's String\n");
            double choice = Convert.ToDouble(Console.ReadLine());

            double wynik = Convert.ToDouble(choice * choice - choice);

            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine(wynik);
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
        }

        //----------------------------------------------------------------------------------------------

        static void curencies()
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("\n--- Avaliable currencies ---");
            Console.WriteLine("(Currently only 4 avaliable) (more comming in future updates)");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("- Euro (EU €) --- Press F1 to calculate");
            Console.WriteLine("- Polish Złoty (PL zł) --- Press F2 to calculate");
            Console.WriteLine("- American Dollars (USA $) --- Press F3 to calculate");
            Console.WriteLine("- Turkish Lira (TR ₺) --- Press F4 to calculate");
            Console.WriteLine("- British Great Pounds (GB £) --- Press F5 to calculate");

            switch (Console.ReadKey().Key)
            {
                case ConsoleKey.F1:
                    return;
                case ConsoleKey.F2:
                    Console.Write("\nPLN to Kromer - Write any number: ");
                    double kromer01 = Convert.ToDouble(Console.ReadLine());

                    Console.BackgroundColor = ConsoleColor.White;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine(plnCalculator(kromer01));
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.ForegroundColor = ConsoleColor.White;

                    Console.WriteLine("Press Q to Quit and C to Calculate more [[ Kromer ]]\n");
                    break;
                case ConsoleKey.F3:
                    Console.Write("\nDLR to Kromer - Write any number: ");
                    double kromer02 = Convert.ToDouble(Console.ReadLine());

                    Console.BackgroundColor = ConsoleColor.White;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine(dlrCalculator(kromer02));
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.ForegroundColor = ConsoleColor.White;

                    Console.WriteLine("Press Q to Quit and C to Calculate more [[ Kromer ]]\n");
                    break;
                case ConsoleKey.F4:
                    Console.Write("\nLRA to Kromer - Write any number: ");
                    double kromer03 = Convert.ToDouble(Console.ReadLine());

                    Console.BackgroundColor = ConsoleColor.White;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine(lraCalculator(kromer03));
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.ForegroundColor = ConsoleColor.White;

                    Console.WriteLine("Press Q to Quit and C to Calculate more [[ Kromer ]]\n");
                    break;
                case ConsoleKey.F5:
                    Console.Write("\nPND to Kromer - Write any number: ");
                    double kromer04 = Convert.ToDouble(Console.ReadLine());

                    Console.BackgroundColor = ConsoleColor.White;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine(pndCalculator(kromer04));
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.ForegroundColor = ConsoleColor.White;

                    Console.WriteLine("Press Q to Quit and C to Calculate more [[ Kromer ]]\n");
                    break;
                default:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nERROR: Unknown Keybind\n");
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
            }
        }

        //----------------------------------------------------------------------------------------------

        static void v2()
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("\n--- Kromer Calculator Version 2.0.0 Change Log ---\n");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("- Fixed the 'ERROR: Unknown Keybind' popping up after each command\n- Reduced the load times to make them less annoying\n- Cleaned up some messy code and removed useless lines of code\n- Added YMMMMM\n- Added a 'Clear Console' feature\n- Added the ability to reverse the calculator to calculate Kromer to Euro instead of just Euro to Kromer\n- Added some other real world currencies\n- Added a couple of MEME Commands");
        }
        static void v25()
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("\n--- Kromer Calculator Version 2.5.0 Change Log ---\n");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("- Added an option to select previous update changes\n- You can now download earlier versions of the program using the site above\n- fixed some currency values (example: lira value going down the drain)\n- Multiple visual changes\n- Removed the unnecessary loading messages\n- Fixed a bug with the currency select command calculating kromer to x instead of x to kromer\n- Cleaned up messy lines of code");
        }

        //----------------------------------------------------------------------------------------------

        static void emptyFunction()
        {
            ;
        }
    }
}

