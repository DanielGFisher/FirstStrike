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

        private string _Place;
        public string Place
        {
            get { return _Place; }
            set { Place = value; }
        }

        private List<string> _Weapons;
        public List<string> Weapons
        {
            get { return _Weapons; }
            set { Weapons = value; }
        }

        static private List<string> _Places = new List<string> { "Outside", "In A Car", "Home" };
        static public List<string> Places
        {
            get { return _Places; }
            set { Places = value; }
        }



        public Terrorist(string name, int rank, bool alive, List<string> weapons, string place)
        {
            _Name = name;
            _Rank = rank;
            _Alive  = alive;
            _Weapons = weapons;
            _Place = place;
        }

        public void Info()
        {
            Console.WriteLine($"Name: {Name}\nRank: {Rank}\nPlace: {Place}\nAlive: {Alive}\nWeapons:");
            foreach (string weapon in Weapons)
            {
                Console.WriteLine($"{weapon}");
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
        public void Move()
        {
            Random Rand = new Random();
            _Place = Places.ElementAt(Rand.Next(0, Places.Count));
        }

        public void UpdateStatus()
        {
            _Alive = false;
        }
    }
}
