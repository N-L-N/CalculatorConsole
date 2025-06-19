using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorConsole
{
    public static class CalculatorLog
    {
        private static List<string> logEntries = [];

        public static void AddLogEntry(string entry)
        {
            logEntries.Add(entry);
        }

        public static void ShowHistory()
        {
            if (logEntries.Count == 0)
            {
                Console.WriteLine("Нет истории на данный момент.");
                return;
            }
            Console.WriteLine("История калькулятора:");
            foreach (var entry in logEntries)
            {
                Console.WriteLine(entry);
            }
        }

    }
}
