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
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Choose target count 1-3:");
                    int choice = int.Parse(Console.ReadLine());

                    switch (choice)
                    {
                        case 1:
                        AmmoCapacity--;
                        Console.WriteLine($"Officer -- Or Zellinger --\nArtillery -- {Name} --\nExecuting Operation:\nUsing - {BombType}, Time: {DateTime.Now}");
                        terrorist.UpdateStatus();
                        flag = false;
                        break;

                    case 2:
                        AmmoCapacity -= 2;
                        flag = false;
                        terrorist.UpdateStatus();
                        break;

                    case 3:
                        AmmoCapacity -= 3;
                        flag = false;
                        terrorist.UpdateStatus();
                        break;
                        
                    default:
                        Console.WriteLine("Please Enter a Valid Choice");
                        break;
            }
            
            }
        }
    }
}