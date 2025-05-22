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

            IsraeliDefenceForce.AddStrikeOption(F16);
            IsraeliDefenceForce.AddStrikeOption(Hermes);
            IsraeliDefenceForce.AddStrikeOption(M1902);
        }

        public static void GenerateIntel(Hamas organisation)
        {
            for (int i = 0; i < 20; i++)
            {
                Random rand = new Random();
                int nextRand = rand.Next(0,organisation.Members.Count - 1);

                Aman Mossad = new Aman();
                Mossad.Intelligence(organisation.Members[nextRand]);
            }
        }

    }
}
