using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstStrike.Models
{
    public class Artillery : StrikeOption
    {
        public string BombType;
        public string EffectiveAgainst;
        public List<int> StrikeCapacity;
        public Artillery(string pilot) : base("M109", 40, 100.00, new List<string> { "Buildings", "Vehicles", "Personnel", "Open Area" })
        {
            BombType = "Explosive-Shells";
            EffectiveAgainst = "Open-Space";
            StrikeCapacity = new List<int> {2, 3};
        }

        public override void StrikeOperation()
        {
            Console.WriteLine($"Drone -- {Name} --\nExecuting Operation:\nTarget struck successfully!");
            AmmoCapacity--;
        }
    }
}