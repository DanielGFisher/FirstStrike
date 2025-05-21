using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FirstStrike.Models;

namespace FirstStrike.Models
{
    public class Terrorist
    {
        private string _Name;
        public string Name
        {
            get { return _Name; }
            set { Name = value; }
        }

        private int _Rank;
        public int Rank
        {
            get { return _Rank; }
            set { Rank = value; }
        }

        private bool _Alive;
        public bool Alive
        {
            get { return _Alive; }
            set { Alive = value; }
        }

        private string _Location;
        public string Location
        {
            get { return _Location; }
            set { Location = value; }
        }

        private List<string> _Weapons;
        public List<string> Weapons
        {
            get { return _Weapons; }
            set { Weapons = value; }
        }


        public Terrorist(string name, int rank, bool alive, List<string> weapons, string location)
        {
            _Name = name;
            _Rank = rank;
            _Alive  = alive;
            _Weapons = weapons;
            _Location = location;
        }

        public void Info()
        {
            Console.WriteLine($"Name: {Name}\nRank: {Rank}\nAlive: {Alive}\nWeapons:");
            foreach (string weapon in Weapons)
            {
                Console.WriteLine($"    {weapon}");
            }
        }
        public string GetWeapons()
        {
            string weapons = "";
            for (int i = 0; i < Weapons.Count; i++)
            {
                weapons += "    ";
                weapons += Weapons.ElementAt(i);
                if (i < Weapons.Count -1)
                {
                    weapons += "\n";
                }
            }
            return weapons;
        }
    }
}
