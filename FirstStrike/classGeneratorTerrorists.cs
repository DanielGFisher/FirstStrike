using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FirstStrike.Models;

namespace FirstStrike
{
    public class GeneratorTerrorists
    {
        private List<string> _Names = new List<string> { "Mohamad", "Ziad", "Omar", "Abed", "Muafak", "Halal", "Hasan", "Imad" };
        private List<string> _Weapons = new List<string> { "MK-47", "M4A1", "Knife", "Rock", "Bomb", "Hands" };
        private List<string> _Places = new List<string> { "Outside", "In A Car", "Home" };

        public static GenerateTerrorists(Hamas Organization, int HowMany)
        {
            for (int i = 0; i < HowMany; i++)
            {

            }
        }
    }
}