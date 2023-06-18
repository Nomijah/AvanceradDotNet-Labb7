using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvanceradDotNet_Labb7.Log
{
    public class CalcLog
    {
        public double First { get; set; }
        public double Second { get; set; }
        public double Result { get; set; }
        public string CalculationMethod { get; set; }
        public string TimeCreated { get; set; }
        
        // Constructor for use in app.
        public CalcLog(double a, double b, double c, string calc)
        {
            First = a;
            Second = b;
            Result = c;
            CalculationMethod = calc;
            TimeCreated = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
        }
        // Constructor for reading from file.
        public CalcLog(double a, double b, double c, string calc, string time)
        {
            First = a;
            Second = b;
            Result = c;
            CalculationMethod = calc;
            TimeCreated = time;
        }

        public void PrintWithDate()
        {
            Console.Write(TimeCreated + " " + First);
            switch (CalculationMethod)
            {
                case "Addition":
                    Console.Write(" + ");
                    break;
                case "Subtraction":
                    Console.Write(" - ");
                    break;
                case "Multiplication":
                    Console.Write(" * ");
                    break;
                case "Division":
                    Console.Write(" / ");
                    break;
            }
            Console.Write(Second + " = " + Result + "\n");
        }
        public void Print()
        {
            Console.Write(First);
            switch (CalculationMethod)
            {
                case "Addition":
                    Console.Write(" + ");
                    break;
                case "Subtraction":
                    Console.Write(" - ");
                    break;
                case "Multiplication":
                    Console.Write(" * ");
                    break;
                case "Division":
                    Console.Write(" / ");
                    break;
            }
            Console.Write(Second + " = " + Result + "\n");
        }
    }
}
