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
        private string _DateOfFormation;
        public string DateOfFormation
        {
            get { return _DateOfFormation; }
            set { DateOfFormation = value; }
        }

        private Terrorist _CurrentCommander = null;
        public Terrorist CurrentCommander
        {
            get { return _CurrentCommander; }
            set { CurrentCommander = value; }
        }

        private List<Terrorist> _Members;
        public List<Terrorist> Members
        {
            get { return _Members; }
            set { Members = value; }
        }
        public Hamas()
        {
            _DateOfFormation = "19/08/1989";
        }
        public void AddMember(Terrorist trr)
        {
            if (CurrentCommander == null || CurrentCommander.Rank < trr.Rank)
            {
                _CurrentCommander = trr;
            }
                _Members.Add(trr);

        }
    }
}
