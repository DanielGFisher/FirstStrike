using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FirstStrike.Models;

namespace FirstStrike.Models
{
    public class GeneratorTerrorists
    {
        static private List<string> Names = new List<string> { "Mohamad", "Ziad", "Omar", "Abed", "Muafak", "Halal", "Hasan", "Imad" };

        static private List<string> Weapons = new List<string> { "AK47", "M16", "Knife", "Gun"};
        public static Hamas GenerateTerrorists(int HowMany)
        {
            Hamas Organization = new Hamas();
            Random Rand = new Random();
            for (int i = 0; i < HowMany; i++)
            {
                string name = Names.ElementAt(Rand.Next(0, Names.Count));
                string place = Terrorist.Places.ElementAt(Rand.Next(0, Terrorist.Places.Count));
                int rank = Rand.Next(0, 6);
                bool alive = true;

                List<string> weapons = new List<string>();int j = 0;
                int howweapons = Rand.Next(1, Weapons.Count-1);
                while (j < howweapons)
                {
                    string weapon = Weapons.ElementAt(Rand.Next(0, Weapons.Count));
                    if (weapons.Contains(weapon))
                    {
                        j--;
                    }
                    else
                    {
                        weapons.Add(weapon);
                    }
                    j++;
                }

                Terrorist trr = new Terrorist(name, rank, alive, weapons, place);
                Organization.AddMember(trr);
            }
            return Organization;
        }
    }
}