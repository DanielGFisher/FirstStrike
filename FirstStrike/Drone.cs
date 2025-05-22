using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
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
        public Drone() : base("Hermes-460", 3, 100.00, new List<string> { "Buildings", "Vehicles", "Personnel", "Open Area" })
        {
            BombType = new List<string> { "Targeted-Strike", "Armor-Piercing" };
            EffectiveAgainst = new List<string> { "Personnel", "Vehicles" };
            StrikeCapacity = AmmoCapacity;
        }

        public override void StrikeOperation(Terrorist terrorist)
        {
            
            if (terrorist.Place == "Outside")
            {
                AmmoCapacity--;
                Console.WriteLine($"Officer -- Or Zellinger --\nDrone -- {Name} --\nExecuting Operation:\nUsing - {BombType[1]}, Place: {EffectiveAgainst[1]} Time: {DateTime.Now}");
                Console.WriteLine($"Target {terrorist.Name} -- Eliminated");
                terrorist.UpdateStatus();
            }

            else if (terrorist.Place == "In A Car")
            {
                AmmoCapacity--;
                Console.WriteLine($"Officer -- Or Zellinger --\nDrone -- {Name} --\nExecuting Operation:\nUsing - {BombType[2]}, Place: {EffectiveAgainst[2]} Time: {DateTime.Now}");
                Console.WriteLine($"Target {terrorist.Name} -- Eliminated");
                terrorist.UpdateStatus();
            }

            else Console.WriteLine("Unsuitable type for strike");
        }

        public void Refuel(double fuel)
        {
            double remainder = 0;
            double original = FuelSupply;
            if ((fuel + original) <= 100 && fuel > 0) original += fuel;
            else if ((fuel + original) > 100)
            {
                FuelSupply += (100 - original);
                fuel -= (100 - original);
                remainder = fuel;
                Console.WriteLine($"You've refueled to max capacity,  your remaining fuel is {remainder}");
            }
        }

        public void Reload(int ammo)
        {
            int remainder = 0;
            int original = StrikeCapacity;
            if ((ammo + original) <= 3 && ammo > 0) AmmoCapacity += ammo;
            else if ((ammo + original) > 3)
            {
                StrikeCapacity += (3 - original);
                ammo -= (3 - original);
                remainder = ammo;
                Console.WriteLine($"You've refueled to max capacity,  your remaining fuel is {remainder}");
            }
        }
    }
}
