using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstStrike.Models
{
    public class StrikeOption
    {
        public string Name;
        public int AmmoCap;
        public double FuelSupply;
        public string TargetType;

        public StrikeOption(string name, int ammo, double fuel, string targetType)
        {
            Name = name;
            AmmoCap = ammo;
            FuelSupply = fuel;
            TargetType = targetType;
        }

        public void Description()
        {
            Console.WriteLine($"Type: {Name}\nMunition Capacity: {AmmoCap}\nFuel Gauge: {FuelSupply}\nSpecialty Target: {TargetType}");
        }
    }
}
