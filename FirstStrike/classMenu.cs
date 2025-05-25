using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FirstStrike.Models;

namespace FirstStrike.Models
{
    public class CommanderConsole
    {
        public IDF myIdf;
        public Aman Mossad;
        public Hamas myHamas;
        public CommanderConsole(IDF idf, Hamas hamas, Aman mossad)
        {
            this.myIdf = idf;
            this.Mossad = mossad;
            this.myHamas = hamas;
        }

        public static Dictionary<string, int> weaponsAndPoints = new Dictionary<string, int> { { "Knife", 1 }, { "Gun", 2 }, { "M16", 3 }, { "AK47", 3 } };
        public void Menu()
        {
            bool sign = true;
            do
            {
                Console.WriteLine(
                  "1. Intel Analysis\n" +
                  "   Identify the terrorist with the most intelligence reports\n\n" +
                  "2. Strike Availability\n" +
                  "   Show all currently available strike units and their remaining capacity\n\n" +
                  "3. Target Prioritization\n" +
                  "   Determine the most dangerous terrorist based on a quality rank\n\n" +
                  "4. Strike Execution\n" +
                  "   Based on the terrorist's location and type, choose an appropriate strike unit \n\n" +
                  "5. Exit the Program\n" +
                  "   Finish program use and exit the panel");

                bool choiceSign = int.TryParse(Console.ReadLine(), out int choice);
                if (!choiceSign)
                {
                    Console.WriteLine("Enter choice again");
                    continue;
                }
                switch (choice)
                {
                    case 1:
                        IntelAnalysis(this.Mossad);
                        break;

                    case 2:
                        StrikeAvalabilty(this.myIdf);
                        break;

                    case 3:
                        MostDangerousTerrorist(this.myHamas);
                        break;

                    case 5:
                        sign = false;
                        break;

                    case 4:
                        Exectution(IntelAnalysis(this.Mossad));
                        break;
                    default:
                        break;
                }
            }
            while (sign);
        }


        List<Terrorist> HighestRisk = new List<Terrorist>();
        public List<Terrorist> IntelAnalysis(Aman intelligence)
        {
            int MaxCount = 0;
            Dictionary<Terrorist, int> IntelCount = intelligence.DisplayIntelCount();

            foreach (KeyValuePair<Terrorist, int> Terrorist in IntelCount)
            {
                if (Terrorist.Key.Alive && Terrorist.Value > MaxCount) MaxCount = Terrorist.Value;
            }

            Dictionary<Terrorist, List<string>> Intel = intelligence.IntelligenceDisplay();

            foreach (KeyValuePair<Terrorist, List<string>> terroristIntel in Intel)
            {
                if (IntelCount.ContainsKey(terroristIntel.Key) && IntelCount[terroristIntel.Key] == MaxCount)
                {
                    if (!HighestRisk.Contains(terroristIntel.Key) && terroristIntel.Key.Alive) HighestRisk.Add(terroristIntel.Key);
                }
            }

            foreach (var terrorist in HighestRisk)
            {
                terrorist.Info();
            }
            return HighestRisk;
        }
        public void MostDangerousTerrorist(Hamas Organization)
        {
            List<Terrorist> members = Organization.Members;
            int highestPoints = 0;
            Terrorist currentTrr = members[0];
            foreach (Terrorist trr in members)
            {
                int points = 0;
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
            Console.WriteLine($"Name: {currentTrr.Name}\n" +
                $"Rank: {currentTrr.Rank}\n" +
                $"Quality Score: {highestPoints}\n" +
                $"Location: {currentTrr.Place}\n" +
                $"Weapons: {currentTrr.GetWeapons()}");
        }

        public void StrikeAvalabilty(IDF Organization)
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
            Console.WriteLine(total);
        }
        public List<StrikeOption> findStrikes(IDF organization, string place)
        {
            List<StrikeOption> strikes = new List<StrikeOption>();
            foreach (StrikeOption strike in organization.StrikeOptions)
            {
                if (strike.EffectiveAgainst.Contains(place))
                {
                    strikes.Add(strike);
                }
            }
            return strikes;
        }

        public List<StrikeOption> StrikeType(string location)
        {
            List<StrikeOption> strikes = new List<StrikeOption>();
            switch (location)
            {
                case "Outside":
                    strikes.AddRange(findStrikes(this.myIdf, "Personnel"));
                    strikes.AddRange(findStrikes(this.myIdf, "Open-Space"));
                    break;

                case "In A Car":
                    strikes = findStrikes(this.myIdf, "Vehicles");
                    break;

                case "Home":
                    strikes = findStrikes(this.myIdf, "Building");
                    break;

                default:
                    Console.WriteLine("Unknown Place");
                    break;
            }
            return strikes;
        }
        public void Exectution(List<Terrorist> trrs)
        {
            Dictionary<string, int> Places = new Dictionary<string, int>();
            foreach (Terrorist trr in trrs)
            {
                if (Places.ContainsKey(trr.Place))
                {
                    Places[trr.Place]++;
                }
                else
                {
                    Places[trr.Place] = 1;
                }
            }
            if (Places.ContainsKey("Outside") && Places["Outside"] > 1)
            {
                foreach (Terrorist trr in trrs)
                {
                    if (trr.Place == "Outside")
                    {
                        myIdf.StrikeOptions[2].StrikeOperation(trr);
                        trrs.Remove(trr);
                    }
                }
                if (trrs.Count != 0)
                {
                    foreach (Terrorist trr in trrs)
                    {
                        switch (trr.Place)
                        {
                            case "Outside":
                                myIdf.StrikeOptions[1].StrikeOperation(trr);
                                break;
                            case "In A Car":
                                myIdf.StrikeOptions[1].StrikeOperation(trr);
                                break;
                            case "Home":
                                myIdf.StrikeOptions[0].StrikeOperation(trr);
                                break;
                            default:
                                break;
                        }
                    }
                }
            }
            else
            {
                if (trrs.Count == 0)
                {
                    Console.WriteLine("List is Empty");
                    return;
                }
                Terrorist trr = trrs[0];
                switch (trr.Place)
                {
                    case "Outside":
                        myIdf.StrikeOptions[1].StrikeOperation(trr);
                        break;
                    case "In A Car":
                        myIdf.StrikeOptions[1].StrikeOperation(trr);
                        break;
                    case "Home":
                        myIdf.StrikeOptions[0].StrikeOperation(trr);
                        break;
                    default:
                        break;
                }
            }
            Terrorist[] copytrrs = trrs.ToArray();
            foreach (Terrorist trr in copytrrs)
            {
                if (trr.Alive == false)
                {
                    trrs.Remove(trr);
                }
            }
        }
    }
}
