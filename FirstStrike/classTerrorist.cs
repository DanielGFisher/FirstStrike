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
        private int _Rank;
        private bool _Alive;
        private List<string> _Weapons;

        public Terrorist(string name, int rank, bool alive, List<string> weapons)
        {
            _Name = name;
            _Rank = rank;
            _Alive  = alive;
            _Weapons = weapons;
        }

        public void Info()
        {
            Console.WriteLine($"Name: {_Name}\nRank: {_Rank}\nAlive: {_Alive}\nWeapons:");
            foreach (string weapon in _Weapons)
            {
                Console.WriteLine($"    {weapon}");
            }
        }
        public int GetRank()
        {
            return _Rank;
        }
    }
}
