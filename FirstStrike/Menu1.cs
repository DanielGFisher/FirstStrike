using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstStrike.Models
{
    public class Menu1
    {
        int MaxCount = 0;
        List<Terrorist> HighestRisk = new List<Terrorist>();
        public void IntelAnalysis(Aman intelligence)
        {
            Dictionary<Terrorist, int> IntelCount = intelligence.DisplayIntelCount();



            foreach (KeyValuePair<Terrorist, int> Terrorist in IntelCount)
            {
                if (Terrorist.Value > MaxCount) MaxCount = Terrorist.Value;
            }

            Dictionary<Terrorist, List<string>> Intel = intelligence.IntelligenceDisplay();
            
            foreach (KeyValuePair<Terrorist, List<string>> terroristIntel in Intel)
            {
                if (IntelCount.ContainsKey(terroristIntel.Key) && IntelCount[terroristIntel.Key] == MaxCount)
                {
                    HighestRisk.Add(terroristIntel.Key);
                }
            }

            foreach (var terrorist in HighestRisk)
            {
                terrorist.Info();
            }
        }
    }
}
