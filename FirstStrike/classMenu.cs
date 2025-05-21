using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstStrike.Models
{
    public class CommanderConsole
    {
        public static void Menu()
        {
            Console.WriteLine(
                "1. Intel Analysis\n" +
                "   Identify the terrorist with the most intelligence reports\n\n" +
                "2. Strike Availability\n" +
                "   Show all currently available strike units and their remaining capacity\n\n" +
                "3. Target Prioritization\n" +
                "   Determine the most dangerous terrorist based on a quality rank\n\n" +
                "4. Strike Execution\n" +
                "   Based on the terrorist's location and type, choose an appropriate strike unit");
        }
    }
}
