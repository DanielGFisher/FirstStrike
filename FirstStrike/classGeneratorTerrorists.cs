using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FirstStrike.Models;

namespace FirstStrike
{
    public class GeneratorTerrorists
    {
        static private List<string> _Names = new List<string> { "Mohamad", "Ziad", "Omar", "Abed", "Muafak", "Halal", "Hasan", "Imad" };
        static public List<string> Names
        {
            get { return _Names; }
            set { Names = value; }
        }

        static private List<string> _Weapons = new List<string> { "AK47", "M16", "Knife", "Rock", "Bomb", "Hands" };
        static public List<string> Weapons
        {
            get { return _Weapons; }
            set { Weapons = value; }
        }
        public static void GenerateTerrorists(Hamas Organization, int HowMany)
        {
            Random Rand = new Random();
            for (int i = 0; i < HowMany; i++)
            {
                string name = Names.ElementAt(Rand.Next(0, Names.Count));
                string place = Terrorist.Places.ElementAt(Rand.Next(0, Terrorist.Places.Count));
                int rank = Rand.Next(0, 6);
                bool alive = true;

                List<string> weapons = new List<string>();int j = 0;
                while (j > Weapons.Count)
                {
                    string weapon = Weapons.ElementAt(Rand.Next(0, Weapons.Count));
                    if (weapons.Contains(weapon))
                    {
                        i--; continue;
                    }
                    weapons.Add(weapon);
                }

                Terrorist trr = new Terrorist(name, rank, alive, weapons, place);
                Organization.AddMember(trr);
            }
        }
    }
}