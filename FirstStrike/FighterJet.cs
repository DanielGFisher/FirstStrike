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
        public FighterJet(string pilot) : base("F16", 8, 100.00, new List<string> { "Buildings", "Vehicles", "Personnel", "Open Area" })
        {
            Operator = pilot;
            BombType = new List<string> { "1 Tonne", "Half Tonne" };
            EffectiveAgainst = "Building";
            StrikeCapacity = 1;
        }

        public override void StrikeOperation(Terrorist terrorist)
        {
            Console.WriteLine("Please choose bomb type: (1 - Tonne, 2 - Half-Tonne)");
            int choice = int.Parse(Console.ReadLine());


            if (choice == 1)
            {
                FuelSupply -= 50;
                AmmoCapacity--;
                Console.WriteLine($"Officer -- Or Zellinger --\nFighter -- {Name} --\nExecuting Operation:\nUsing - {BombType[0]}, Time: {DateTime.Now}");
                Console.WriteLine($"Target {terrorist.Name} -- Eliminated");
                terrorist.UpdateStatus();
                terrorist.Info();
            }

            else if (choice == 2)
            {
                FuelSupply -= 50;
                AmmoCapacity--;
                Console.WriteLine($"Officer -- Or Zellinger --\nFighter -- {Name} --\nExecuting Operation:\nUsing - {BombType[1]}, Time: {DateTime.Now}");
                Console.WriteLine($"Target {terrorist.Name} -- Eliminated");
                terrorist.UpdateStatus();
                terrorist.Info();
            }

            else Console.WriteLine("Invalid Input");
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
            if ((ammo + original) <= 8 && ammo > 0) AmmoCapacity += ammo;
            else if ((ammo + original) > 8)
            {
                StrikeCapacity += (8 - original);
                ammo -= (8 - original);
                remainder = ammo;
                Console.WriteLine($"You've refueled to max capacity,  your remaining fuel is {remainder}");
            }
        }
    }
}
