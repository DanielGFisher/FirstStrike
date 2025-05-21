using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FirstStrike.Models;

namespace FirstStrike.Models
{
    public class IDF
    {
        private string DOE;
        private string CurrentCommander;
        private List<StrikeOption> StrikeOptions = new List<StrikeOption>();

        public IDF(string doe, string currentCommander)
        {
            DOE = doe;
            CurrentCommander = currentCommander;
        }

        public static void AddStrikeOption(IDF iDF, StrikeOption strikeOption)
        {
            iDF.StrikeOptions.Add(strikeOption);
        }
    }
}
