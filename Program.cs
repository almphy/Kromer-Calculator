using System;
using System.Diagnostics;
using System.Threading;
using System.Text;

namespace Kromer_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Kromer Calculator v.3.0.0 -- Merry Christmas!";

            Console.OutputEncoding = Encoding.Unicode;

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

            write("Program Name: Kromer Calculator\n");
            write("Program Version: v.3.0.0\n");
            write("Developer: Livin' On The Streetz\n");
            write("Website: https://streetz-programs-download.000webhostapp.com/ \n");
            write("Creation Date: Saturday 06.11.2021\n");
            write("Latest Update: Saturday 11.12.2021 (Version 3.0.0)\n\n");

            /*
            Console.WriteLine("Loading.");
            Thread.Sleep(LoadingRandom04);
            Console.WriteLine("Loading..");
            Thread.Sleep(LoadingRandom05);
            Console.WriteLine("Loading...\n");
            Thread.Sleep(LoadingRandom06);
            */
            write("Press 'H' to view The Change Log Menu\n");
            Thread.Sleep(1000);

            Console.ForegroundColor = ConsoleColor.White;

            Console.Write("Current [[ Kromer ]] value: ");

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("1 Euro = 0,5 [[ Kromer ]]");

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("--Press Q to Quit | Press C to Calculate Kromer | For a full list of commands type G--\n");

            while (true)
            {
                switch (Console.ReadKey(true).Key)
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
                        write("Current [[ Kromer ]] value: \n");

                        Console.ForegroundColor = ConsoleColor.Green;
                        write("1 Euro = 0,5 [[ Kromer ]]\n");

                        Console.ForegroundColor = ConsoleColor.White;
                        write("--Press Q to Quit | Press C to Calculate Kromer | For a full list of commands type G--\n");
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
                    case ConsoleKey.I:
                        IGSstring();
                        break;
                    case ConsoleKey.S:
                        streetzTheorem();
                        break;
                    case ConsoleKey.A:
                        arrayTheorem();
                        break;
                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        write("\nERROR: Unknown Keybind\n");
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

        static double usdCalculator(double number)
        {
            double ammount02 = Convert.ToDouble(number / Math.Sqrt(Math.PI) - 2);

            return (ammount02);
        }

        //----------------------------------------------------------------------------------------------

        static double tryCalculator(double number)
        {
            double ammount02 = Convert.ToDouble(number / Math.Sqrt(Math.PI) - 30);

            return (ammount02);
        }

        //----------------------------------------------------------------------------------------------

        static double gbpCalculator(double number)
        {
            double ammount02 = Convert.ToDouble(number / Math.Sqrt(Math.PI) + 2);

            return (ammount02);
        }

        //----------------------------------------------------------------------------------------------
        static double hufCalculator(double number)
        {
            double ammount02 = Convert.ToDouble(number / Math.Sqrt(Math.PI) - 200);

            return (ammount02);
        }

        //---------------------------------------------------------------------------------------------
        static double rubCalculator(double number)
        {
            double ammount02 = Convert.ToDouble(number / Math.Sqrt(Math.PI) - 170);

            return (ammount02);
        }

        //---------------------------------------------------------------------------------------------
        static void quit()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            write("\nAre you sure you want to quit? \n(yes/no)\n");
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
            write("--Press Q to Quit | Press C to Calculate Kromer | For a full list of commands type G--\n");
        }

        //----------------------------------------------------------------------------------------------

        static void calculator()
        {

            write("\nDo you want to calculate Euro to Kromer or Kromer to Euro\n(press F1 or F2)\n");

            switch (Console.ReadKey(true).Key)
            {
                case ConsoleKey.F1:
                    write("\nEuro to Kromer - Write any number: ");
                    double kromer01 = Convert.ToDouble(Console.ReadLine());

                    Console.BackgroundColor = ConsoleColor.White;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine(kromerCalculator(kromer01));
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.ForegroundColor = ConsoleColor.White;

                    write("\nPress Q to Quit and C to Calculate more [[ Kromer ]]\n");
                    break;
                case ConsoleKey.F2:
                    write("\nKromer to Euro - Write any number: \n");
                    double kromer02 = Convert.ToDouble(Console.ReadLine());

                    Console.BackgroundColor = ConsoleColor.White;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine(euroCalculator(kromer02));
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.ForegroundColor = ConsoleColor.White;

                    write("\nPress Q to Quit and C to Calculate more [[ Kromer ]]\n");
                    break;
                default:
                    Console.ForegroundColor = ConsoleColor.Red;
                    write("\nERROR: Unknown Keybind\n");
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
            }
        }

        //----------------------------------------------------------------------------------------------

        static void changeLog()
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            write("\n--- Change Log Select Menu ---\n");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            write("- Press F1 to view version 2.0.0 changes\n");
            write("- Press F2 to view version 2.5.0 changes\n");
            write("- Press F2 to view version 3.0.0 changes\n");
            Console.ForegroundColor = ConsoleColor.Yellow;
            write("\n- Download previous versions from -- https://kromer-calculator-versions.000webhostapp.com/ \n");
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
                    write("\nERROR: Unknown Keybind\n");
                    Console.ForegroundColor = ConsoleColor.White;
                    break;

            }
        }

        //----------------------------------------------------------------------------------------------

        static void commandList()
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            write("\n--- Commands ---\n");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            write("- Press Q to Quit\n- Press C to Calculate Euro to Kromer\n- Press R to Clear Console\n- Press T to view avalible currencies\n- Press Y to calculate Miss Y's Number\n- Press I to calculate IGS's Number\n- Press S for streetz's Theorem\n- Press A for The Array Theorem\n- Press B to become a [[Big Shot]] !!\n- Press E to barrage\n");
        }

        //----------------------------------------------------------------------------------------------
        static void streetzTheorem()
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            write("\n--- streetz's Theorem ---\n");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            write("\n'Every program written by people from class P has to have a function called 'emptyFunction''\n(Fø € Px)");
        }

        //----------------------------------------------------------------------------------------------
        static void arrayTheorem()
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            write("\n--- The Array Theorem ---\n");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            write("\n'If you want you can use arrays, but you don't need to.'\n(t[] = m)");
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
            Console.WriteLine("\nBecoming a [[ Big Shot ]] isn't avalible in your country");
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
            write("\n\nWrite a number you would want to be calculated with");
            Console.ForegroundColor = ConsoleColor.Red;
            write(" Mrs Y ");
            Console.ForegroundColor = ConsoleColor.White;
            write("Number\n");
            double choice = Convert.ToDouble(Console.ReadLine());

            double wynik = Convert.ToDouble(choice * choice - choice);

            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("Y(" + choice + ") = " + wynik);
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
        }

        //----------------------------------------------------------------------------------------------
        static void IGSstring()
        {
            write("\n\nWrite a number you would want to be calculated with");
            Console.ForegroundColor = ConsoleColor.Cyan;
            write(" IGS ");
            Console.ForegroundColor = ConsoleColor.White;
            write("Number\n");
            double choice = Convert.ToDouble(Console.ReadLine());

            double wynik = Convert.ToDouble(Math.Pow(choice, 2) + choice);

            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("I(" + choice + ") = " + wynik);
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
        }

        //----------------------------------------------------------------------------------------------

        static void curencies()
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            write("\n--- Avaliable currencies ---\n");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            write("(Currently only 7 avaliable) (more comming in future updates)\n\n");
            Thread.Sleep(500);
            write("- Euro (EU €) --- Press F1 to calculate\n");
            write("- Polish Złoty (PLN zł) --- Press F2 to calculate\n");
            write("- American Dollars (USD $) --- Press F3 to calculate\n");
            write("- Turkish Lira (TRY ₺) --- Press F4 to calculate\n");
            write("- British Great Pounds (GBP £) --- Press F5 to calculate\n");
            write("- Hungarian Froint (HUF Ft) --- Press F6 to calculate\n");
            write("- Rusian Rouble (RUB ₽) --- Press F7 to calculate\n");

            switch (Console.ReadKey().Key)
            {
                case ConsoleKey.F1:
                    return;
                case ConsoleKey.F2:
                    write("\nPLN to Kromer - Write any number: ");
                    double kromer01 = Convert.ToDouble(Console.ReadLine());

                    Console.BackgroundColor = ConsoleColor.White;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine(plnCalculator(kromer01));
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.ForegroundColor = ConsoleColor.White;

                    write("Press Q to Quit and C to Calculate more [[ Kromer ]]\n");
                    break;
                case ConsoleKey.F3:
                    write("\nUSD to Kromer - Write any number: ");
                    double kromer02 = Convert.ToDouble(Console.ReadLine());

                    Console.BackgroundColor = ConsoleColor.White;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine(usdCalculator(kromer02));
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.ForegroundColor = ConsoleColor.White;

                    write("Press Q to Quit and C to Calculate more [[ Kromer ]]\n");
                    break;
                case ConsoleKey.F4:
                    write("\nTRY to Kromer - Write any number: ");
                    double kromer03 = Convert.ToDouble(Console.ReadLine());

                    Console.BackgroundColor = ConsoleColor.White;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine(tryCalculator(kromer03));
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.ForegroundColor = ConsoleColor.White;

                    write("Press Q to Quit and C to Calculate more [[ Kromer ]]\n");
                    break;
                case ConsoleKey.F5:
                    write("\nGBP to Kromer - Write any number: ");
                    double kromer04 = Convert.ToDouble(Console.ReadLine());

                    Console.BackgroundColor = ConsoleColor.White;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine(gbpCalculator(kromer04));
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.ForegroundColor = ConsoleColor.White;

                    write("Press Q to Quit and C to Calculate more [[ Kromer ]]\n");
                    break;
                case ConsoleKey.F6:
                    write("\nHUF to Kromer - Write any number: ");
                    double kromer05 = Convert.ToDouble(Console.ReadLine());

                    Console.BackgroundColor = ConsoleColor.White;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine(hufCalculator(kromer05));
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.ForegroundColor = ConsoleColor.White;

                    write("Press Q to Quit and C to Calculate more [[ Kromer ]]\n");
                    break;
                case ConsoleKey.F7:
                    write("\nRUB to Kromer - Write any number: ");
                    double kromer06 = Convert.ToDouble(Console.ReadLine());

                    Console.BackgroundColor = ConsoleColor.White;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine(rubCalculator(kromer06));
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.ForegroundColor = ConsoleColor.White;

                    write("Press Q to Quit and C to Calculate more [[ Kromer ]]\n");
                    break;
                default:
                    Console.ForegroundColor = ConsoleColor.Red;
                    write("\nERROR: Unknown Keybind\n");
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
            }
        }

        //----------------------------------------------------------------------------------------------

        static void v2()
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            write("\n--- Kromer Calculator Version 2.0.0 Change Log ---\n");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            write("- Fixed the 'ERROR: Unknown Keybind' popping up after each command\n- Reduced the load times to make them less annoying\n- Cleaned up some messy code and removed useless lines of code\n- Added YMMMMM\n- Added a 'Clear Console' feature\n- Added the ability to reverse the calculator to calculate Kromer to Euro instead of just Euro to Kromer\n- Added some other real world currencies\n- Added a couple of MEME Commands");
        }
        static void v25()
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            write("\n--- Kromer Calculator Version 2.5.0 Change Log ---\n");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            write("- Added an option to select previous update changes\n- You can now download earlier versions of the program using the site above\n- fixed some currency values (example: lira value going down the drain)\n- Multiple visual changes\n- Removed the unnecessary loading messages\n- Fixed a bug with the currency select command calculating kromer to x instead of x to kromer\n- Cleaned up messy lines of code");
        }
        static void v3()
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            write("\n--- Kromer Calculator Version 3.0.0 Change Log ---\n");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            write("- Added an option to select previous update changes\n- You can now download earlier versions of the program using the site above\n- fixed some currency values (example: lira value going down the drain)\n- Multiple visual changes\n- Removed the unnecessary loading messages\n- Fixed a bug with the currency select command calculating kromer to x instead of x to kromer\n- Cleaned up messy lines of code");
        }

        //----------------------------------------------------------------------------------------------
        static void write(string message)
        {
            for (int i = 0; i < message.Length; i++)
            {
                Console.Write(message[i]);
                Thread.Sleep(5);
            }

        }

        static void emptyFunction()
        {
            ;
        }
    }
}

