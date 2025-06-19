using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorConsole
{
    public class CalculatorLog
    {
        private List<string> logEntries = [];

        // This class is a placeholder for a logger element that can be used in the Calculator application.
        public CalculatorLog() { }

        public void AddLogEntry(string entry)
        {
            logEntries.Add(entry);
        }

        public void ShowHistory()
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
