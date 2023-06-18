using AvanceradDotNet_Labb7.Log;

namespace AvanceradDotNet_Labb7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LogStack.GetLogsFromFile("C:\\Users\\pette\\source" +
                "\\repos\\AvanceradDotNetLabb7\\" +
                "AvanceradDotNet-Labb7\\Log\\LogFile.txt");
            UserInterface.DisplayMainMenu();
            LogStack.WriteLogsToFile("C:\\Users\\pette\\source" +
                "\\repos\\AvanceradDotNetLabb7\\" +
                "AvanceradDotNet-Labb7\\Log\\LogFile.txt");
        }
    }
}