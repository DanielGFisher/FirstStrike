using FirstStrike.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace FirstStrike.Models
{
    public class Hamas
    {
        public string DateOfFormation;

        public Terrorist CurrentCommander = null;

        public List<Terrorist> Members;
        public Hamas()
        {
            this.DateOfFormation = "19/08/1989";
            this.Members = new List<Terrorist>();
            this.CurrentCommander = null;
        }
        public void AddMember(Terrorist trr)
        {
            if (CurrentCommander == null || CurrentCommander.Rank < trr.Rank)
            {
                this.CurrentCommander = trr;
            }
                this.Members.Add(trr);
        }

        public void GetMembers()
        {
            foreach (Terrorist trr in Members)
            {
                trr.Info();
            }
        }
    }
}
