using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FirstStrike.Models;

namespace FirstStrike.Models
{   
    public class Drone : StrikeOption
    {
        public List<string> BombType;
        public List<string> EffectiveAgainst;
        public int StrikeCapacity;
        public Drone(string pilot) : base("Hermes-460", 3, 100.00, new List<string> { "Buildings", "Vehicles", "Personnel", "Open Area" })
        {
            BombType = new List<string> { "Targeted-Strike", "Armor-Piercing" };
            EffectiveAgainst = new List<string> { "Personnel", "Vehicles" };
            StrikeCapacity = AmmoCapacity;
        }

        public override void StrikeOperation()
        {
            Console.WriteLine($"Drone -- {Name} --\nExecuting Operation:\nTarget struck successfully!");
            StrikeCapacity--;
        }
    }
}
