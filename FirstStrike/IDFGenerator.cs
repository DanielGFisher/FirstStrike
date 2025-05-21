using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstStrike.Models
{
    public class IDFGenerator
    {
        public static void GenerateIDF()
        {
            IDF IsraeliDefenceForce = new IDF("May 26th, 1948","Eyal Zamir");
            string pilot = "Or Zelinger";

            FighterJet F16 = new FighterJet(pilot);
            Drone Hermes = new Drone();
            Artillery M1902 = new Artillery();
            IsraeliDefenceForce.AddStrikeOption(IsraeliDefenceForce, Hermes);

        } 


    }
}
