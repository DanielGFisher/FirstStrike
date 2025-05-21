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
        public static void Intelligence(Terrorist terrorist)
        {
            Console.WriteLine($"Name: {terrorist.Name}\nRank: {terrorist.Rank}\nStatus: {terrorist.Alive}\nWeapons: {terrorist.GetWeapons()}Time: " + Convert.ToString(DateTime.Now));
        }
    }
}
