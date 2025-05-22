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
        private Dictionary<Terrorist, int> TerroristsIntelCount = new Dictionary<Terrorist, int>();
        private Dictionary<Terrorist, List<string>> Intel = new Dictionary<Terrorist, List<string>>();

        public void Intelligence(Terrorist terrorist)
        {
            string discoveredIntel = $"Name: {terrorist.Name}\nRank: {terrorist.Rank}\nStatus: {terrorist.Alive}\nWeapons: {terrorist.GetWeapons()}\nTime: {DateTime.Now}";

            if (TerroristsIntelCount.ContainsKey(terrorist)) TerroristsIntelCount[terrorist]++;
            else TerroristsIntelCount[terrorist] = 1;

            if (Intel.ContainsKey(terrorist))
            {
                if (!Intel[terrorist].Contains(discoveredIntel))
                {
                    Intel[terrorist].Add(discoveredIntel);
                }
                else
                {
                    Console.WriteLine("Intel already exists");
                }
            }
            else
            {
                Intel[terrorist] = new List<string> { discoveredIntel };
            }
        }

        public Dictionary<Terrorist, int> DisplayIntelCount()
        {
            return TerroristsIntelCount;
        }
        public Dictionary<Terrorist, List<string>> IntelligenceDisplay()
        {
            return Intel;
        }


    }
}
