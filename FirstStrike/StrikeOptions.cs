using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstStrike.Models
{
    public abstract class StrikeOption
    {
        public string Name { get; set; }
        public int AmmoCapacity { get; set; }
        public double FuelSupply { get; set; }
        public List<string> TargetType { get; set; }

        public StrikeOption(string name, int ammo, double fuelsupply, List<string> targets)
        {
            Name = name;
            AmmoCapacity = ammo;
            FuelSupply = fuelsupply;
            TargetType = targets;
        }
        public abstract void StrikeOperation(Terrorist terrorist);
        public void Description()
        {
            Console.WriteLine($"Type: {Name}\nMunition Capacity: {AmmoCapacity}\nFuel Gauge: {FuelSupply}\nSpecialty Target: {TargetType}");
        }
    }
}
