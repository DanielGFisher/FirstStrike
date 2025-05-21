using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstStrike
{
    public class Aman
    {
        public string AreaDate = Convert.ToString(DateTime.Now);
        public static void Aman(Terrorist terrorist)
        {
            Console.WriteLine($"Name: {Name}\nRank: {Rank}\nStatus: {Status}\nWeapons: {String.Join(",", Weapons);}Time: " + AreaDate); // Add weapons
        }
    }
}
