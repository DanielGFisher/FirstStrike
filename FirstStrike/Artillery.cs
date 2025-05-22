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
        public Artillery() : base("M109", 40, 100.00, new List<string> { "Buildings", "Vehicles", "Personnel", "Open Area" })
        {
            BombType = "Explosive-Shells";
            EffectiveAgainst = "Open-Space";
            StrikeCapacity = new List<int> {1, 2, 3};
        }

        public override void StrikeOperation(Terrorist terrorist)
        { 
            AmmoCapacity--;
            Console.WriteLine($"Officer -- Or Zellinger --\nArtillery -- {Name} --\nExecuting Operation:\nUsing - {BombType}, Time: {DateTime.Now}");
            terrorist.UpdateStatus();
            terrorist.Info();
        }
    }
}