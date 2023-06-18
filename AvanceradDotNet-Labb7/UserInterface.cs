using AvanceradDotNet_Labb7.Log;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvanceradDotNet_Labb7
{
    public class UserInterface
    {
        public static void DisplayMainMenu()
        {
            bool end = false;
            while (!end)
            {
                Console.WriteLine("Miniräknaren\n" +
                "Välj ett av följande alternativ:\n" +
                "1. Addition\n" +
                "2. Subtraktion\n" +
                "3. Division\n" +
                "4. Multiplikation\n" +
                "5. Logg\n" +
                "6. Avsluta\n");

                end = MainMenuChoice(); 
            }
            DisplayExitMessage();
        }

        public static bool MainMenuChoice()
        {
            switch (UserStringInput())
            {
                case "1":
                    Calculate("Addition");
                    break;
                case "2":
                    Calculate("Subtraction");
                    break;
                case "3":
                    Calculate("Division");
                    break;
                case "4":
                    Calculate("Multiplication");
                    break;
                case "5":
                    LogStack.PrintLog();
                    break;
                case "6":
                    return true;
                    break;
                default:
                    DisplayMenuErrorMessage();
                    MainMenuChoice();
                    break;
            }
            PressKeyToContinue();
            return false;
        }

        private static void DisplayExitMessage()
        {
            Console.WriteLine("Tack för denna gång! Tryck på valfri tangent " +
                "för att avsluta.");
            Console.ReadKey();
        }

        // Returns user input for menu choice.
        public static string UserStringInput()
        {
            return Console.ReadLine();
        }
        // Returns user input for calculation.
        public static double UserDoubleInput()
        {
            double result = 0;
            try
            {
                result = double.Parse(Console.ReadLine());
            }
            catch
            {
                DisplayNumberErrorMessage();
                UserDoubleInput();
            }
            return result;
        }
        // Displays error message when menu choice is not correct.
        public static void DisplayMenuErrorMessage()
        {
            Console.WriteLine("Felaktigt val, försök igen.");
        }
        // Displays error message when input is not a number.
        public static void DisplayNumberErrorMessage()
        {
            Console.WriteLine("Ogiltig inmatning, använd endast siffror. Ange " +
                "kommatecken för decimaltal. Försök igen.");
        }
        // Tells user to input first number.
        public static void PrintFirstNumMessage()
        {
            Console.WriteLine("Skriv det första talet till uträkningen:");
        }
        // Tells user to input second number.
        public static void PrintSecondNumMessage()
        {
            Console.WriteLine("Skriv det andra talet till uträkningen:");
        }
        // Gets input from user, calculates and logs result and adds it to stack.
        public static void Calculate(string calcMethod)
        {
            PrintFirstNumMessage();
            double first = UserDoubleInput();
            PrintSecondNumMessage();
            double second = UserDoubleInput();
            double result = 0;
            switch (calcMethod)
            {
                case "Addition":
                    result = CalculationMethods.Add(first, second);
                    break;
                case "Subtraction":
                    result = CalculationMethods.Subtract(first, second);
                    break;
                case "Division":
                    result = CalculationMethods.Divide(first, second);
                    break;
                case "Multiplication":
                    result = CalculationMethods.Multiply(first, second);
                    break;
            }
            var log = CreateLog(first, second, result, calcMethod);
            log.Print();
            AddToLogStack(log);
        }
        // Creates a log entry.
        public static Log.CalcLog CreateLog(double first, 
            double second, double result, string calcMethod)
        {
            return new Log.CalcLog(first,second, result, calcMethod);
        }
        // Adds log to stack.
        public static void AddToLogStack(Log.CalcLog log)
        {
            Log.LogStack.AddToLog(log);
        }
        public static void PressKeyToContinue()
        {
            Console.WriteLine("\nTryck på valfri tangent för att gå tillbaka " +
                "till menyn.");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
