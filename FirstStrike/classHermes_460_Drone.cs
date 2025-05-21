using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FirstStrike.Models;

namespace FirstStrike.Models
{
    public class Hermes_460_Drone : StrikeOption
    {
        private List<string> EfectiveAgainst = new List<string>() { "People", "Vehicles" };
        private int StrikesCounter = 3;

        public Hermes_460_Drone(string name, int ammoCap, double fuel, string targetType) : base(name, ammoCap, fuel, targetType)
        {

        }
    }
}
