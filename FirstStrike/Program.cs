using FirstStrike.Models;
using System.Collections.Generic;

namespace FirstStrike
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Terrorist trr = new Terrorist("Ahmed", 5, true, new List<string> { "MK-47", "Knife" });
            trr.Info();
        }
    }
}