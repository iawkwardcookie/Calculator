using System;
using System.ComponentModel;
using System.Reflection.Metadata.Ecma335;

namespace Menu
{
    class Program
    {

        static void Main(string[] args)
        {
            //This runs the CalcMenu program
            //Once the user chooses exit, the program will stop
            bool showCalc = true;
            while (showCalc)
            {
                showCalc = CalcMenu();
            }
        }
        private static bool CalcMenu()
        {
            //This displays the CalcMenu
            Console.Clear();
            Console.WriteLine("\tWelcome to the calculator\n\tPlease choose an option:");
            //Displays Addition and Subtraction choices
            Console.Write("\n\n\n1) Addition\t\t2) Subtraction");
            //Displays Power and Square Root choices
            Console.Write("\n\n\n3) Power\t\t4) Square Root");
            //Displays Multiplication and Exit choices
            Console.WriteLine("\n\n\n5) Multiplication\t6) Exit");
            //This waits for the user to input a number to go onto that specific screen
            Console.Write("\r\n\t\t");

            //This starts the programs for the specific screen the user chooses
            switch (Console.ReadLine())
            {
                //if user inputs "1", the Addition subprogram starts
                case "1":
                    Addition();
                    return true;
                //if user inputs "2", the Subtraction subprogram starts
                case "2":
                    Subtraction();
                    return true;
                //if user inputs "3", the Power subprogram starts
                case "3":
                    Power();
                    return true;
                //if user inputs "4", the Square Root subprogram starts
                case "4":
                    SqRoot();
                    return true;
                //if user inputs "5", the Multiplication subprogram starts
                case "5":
                    Multiplication();
                    return true;
                //if user inputs "6", the application would finish
                case "6":
                    return false;
                //if user inputs something else, menu would show again
                default:
                    return true;
            }
        }
        private static void Addition()
        {
            //This asks for Two values which the user inputs one after the other
            Console.Clear();
            Console.WriteLine("Please input first value, hit enter, then input next value");
            Console.Write("\n\n\t\t  ");

            //Reads line for first number then converts to integer
            string Num1 = Console.ReadLine();
            int N1 = Int32.Parse(Num1);

            Console.Write("\t\t+ ");

            //Reads line for second number then converts to integer
            string Num2 = Console.ReadLine();
            int N2 = Int32.Parse(Num2);

            //calculates result then displays and waits for input from the user to return to menu
            int Result = (N1 + N2);
            Console.WriteLine("\t\t= " + Result);
            Console.ReadLine();
        }
        private static void Subtraction()
        {
            //This asks for Two values which the user inputs one after the other
            Console.Clear();
            Console.WriteLine("Please input first value, hit enter, then input next value");
            Console.Write("\n\n\t\t  ");

            //Reads line for first number then converts to integer
            string Num1 = Console.ReadLine();
            int N1 = Int32.Parse(Num1);

            Console.Write("\t\t- ");

            //Reads line for second number then converts to integer
            string Num2 = Console.ReadLine();
            int N2 = Int32.Parse(Num2);

            //calculates result then displays and waits for input from the user to return to menu
            int Result = (N1 - N2);
            Console.WriteLine("\t\t= " + Result);
            Console.ReadLine();
        }
        private static void Power()
        {
            //This asks for Two values which the user inputs one after the other
            Console.Clear();
            Console.WriteLine("Please input first value, hit enter, then input next value as the power");
            Console.Write("\n\n\t\t  ");

            //Reads line for first number then converts to integer
            string Num1 = Console.ReadLine();
            int N1 = Int32.Parse(Num1);

            Console.Write("\t\t    ^ ");

            //Reads line for second number then converts to integer
            string Num2 = Console.ReadLine();
            int N2 = Int32.Parse(Num2);

            //calculates result then displays and waits for input from the user to return to menu
            double Result = Math.Pow(N1, N2);
            Console.WriteLine("\t\t= " + Result);
            Console.ReadLine();
        }
        private static void SqRoot()
        {
            //This asks for the values which the user wishes to be root squared
            Console.Clear();
            Console.WriteLine("Please input the value you wish to square root");
            Console.Write("\n\n\t\t  ");

            //Reads line for number then converts to integer
            string Num1 = Console.ReadLine();
            int N1 = Int32.Parse(Num1);

            //calculates result then displays and waits for input from the user to return to menu
            double Result = Math.Sqrt(N1);
            Console.WriteLine("\t\t= " + Result);
            Console.ReadLine();
        }

        private static void Multiplication()
        {
            //This asks for Two values which the user inputs one after the other
            Console.Clear();
            Console.WriteLine("Please input first value, hit enter, then input next value");
            Console.Write("\n\n\t\t  ");

            //Reads line for first number then converts to integer
            string Num1 = Console.ReadLine();
            int N1 = Int32.Parse(Num1);

            Console.Write("\t\tx ");

            //Reads line for second number then converts to integer
            string Num2 = Console.ReadLine();
            int N2 = Int32.Parse(Num2);

            //calculates result then displays and waits for input from the user to return to menu
            int Result = (N1 * N2);
            Console.WriteLine("\t\t= " + Result);
            Console.ReadLine();
        }
    }
}
