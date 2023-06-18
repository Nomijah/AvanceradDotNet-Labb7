using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace AvanceradDotNet_Labb7.Log
{
    public static class LogStack
    {
        public static Stack<CalcLog> logs = new Stack<CalcLog>();

        public static void AddToLog(CalcLog log)
        {
            logs.Push(log);
        }

        public static void PrintLog()
        {
            foreach (var log in logs)
            {
                log.PrintWithDate();
            }
        }

        public static void WriteLogsToFile(string path)
        {
            using (StreamWriter sw = new StreamWriter(path))
            {
                foreach (var log in logs)
                {
                    sw.WriteLine($"{log.First};{log.Second};" +
                        $"{log.Result};{log.CalculationMethod};" +
                        $"{log.TimeCreated}");
                }
            }
        }
        public static void GetLogsFromFile(string path)
        {
            using (StreamReader sr = new StreamReader(path))
            {
                string[] logs = sr.ReadToEnd().Split('\n');
                foreach (string log in logs)
                {
                    // Check that string is not empty.
                    if (log != "")
                    {
                        string[] logProps = log.Split(";");
                        CalcLog temp = new CalcLog(Convert.ToDouble(logProps[0]),
                            Convert.ToDouble(logProps[1]),
                            Convert.ToDouble(logProps[2]),
                            logProps[3], logProps[4].Trim('\r'));
                        LogStack.AddToLog(temp);
                    }
                }
            }
        }
    }
}
