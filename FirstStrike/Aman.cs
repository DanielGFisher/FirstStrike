using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FirstStrike.Models;

namespace FirstStrike.Models
{
    public class Aman
    {
        private Dictionary<Terrorist, int> Terrorists = new Dictionary<Terrorist, int>();
        public static void Intelligence(Terrorist terrorist)
        {
            Console.WriteLine($"Name: {terrorist.Name}\nRank: {terrorist.Rank}\nStatus: {terrorist.Alive}\nWeapons: {terrorist.GetWeapons()}\nTime: " + Convert.ToString(DateTime.Now));
        }

        public void TerroristList(Terrorist terrorist)
        {
            if (Terrorists.ContainsKey(terrorist)) Terrorists[terrorist] += 1;
            else Terrorists.Add(terrorist, 1);
        }

    }
}
