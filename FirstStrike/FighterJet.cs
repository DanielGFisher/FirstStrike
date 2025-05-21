using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstStrike.Models
{
    public class FighterJet : StrikeOption
    {
        public List<string> BombType;
        public string EffectiveAgainst;
        public string Operator;
        public int StrikeCapacity;
        public FighterJet(string pilot) : base("F16", 8, 100.00, new List<string>{"Buildings","Vehicles","Personnel","Open Area"})
        {
            Operator = pilot;
            BombType = new List<string> { "1 Tonne", "Half Tonne" };
            EffectiveAgainst = "Building";
        }

        public override void StrikeOperation()
        {
            Console.WriteLine($"Fighter -- {Name} -- Piloted by -- {Operator} --\nExecuting Operation:\nTarget struck successfully!");
            StrikeCapacity--;
        }
    }
}
