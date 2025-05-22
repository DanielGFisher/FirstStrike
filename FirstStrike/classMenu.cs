using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FirstStrike.Models;

namespace FirstStrike.Models
{
    public class CommanderConsole
    {
        private static Dictionary<string, int> weaponsAndPoints = new Dictionary<string, int> { { "Knife", 1 }, { "Gun", 2 }, { "M16", 3 }, { "MK47", 3 } };
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
        public string MostDangerousTerrorist(Hamas Organization)
        {
            List<Terrorist> members = Organization.Members;
            int points = 0, highestPoints = 0;
            Terrorist currentTrr = members[0];
            foreach (Terrorist trr in members)
            {
                foreach (string weapon in trr.Weapons)
                {
                    points += weaponsAndPoints[weapon];
                }
                points = points * trr.Rank;
                if (points > highestPoints)
                {
                    highestPoints = points;
                    currentTrr = trr;
                }
            }
            return $"Name: {currentTrr.Name}\n" +
                $"Rank: {currentTrr.Rank}\n" +
                $"Quality Score: {highestPoints}\n" +
                $"Location: {currentTrr.Place}\n" +
                $"Weapons: {currentTrr.GetWeapons()}";
        }

        public string StrikeAvalabilty(IDF Organization)
        {
            string total = "";
            List<StrikeOption> strikes = Organization.StrikeOptions;
            foreach (StrikeOption strike in strikes)
            {
                total += $"Strike: {strike.Name}\n" +
                    $"  Fuel: {strike.FuelSupply}\n" +
                    $"  Capacity: {strike.AmmoCapacity}" +
                    $"\n";
            }
            return total;
        }
        private List<StrikeOption> findStrikes(IDF organization, string place)
        {
            List<StrikeOption> strikes = new List<StrikeOption>();
            foreach (StrikeOption strike in organization.StrikeOptions)
            {
                if (strike.)
                {

                }
            }
        }

        private List<StrikeOption> StrikeType(string location)
        {
            List<StrikeOption> strikes = new List<StrikeOption>();
            switch (location)
            {
                case "Outside":
                    strikes.Add();
                    return 

                default:
                    break;
            }
        }
        public string Exectution(Terrorist trr)
        {

        }
    }
}
