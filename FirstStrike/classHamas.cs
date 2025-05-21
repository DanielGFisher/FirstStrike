using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FirstStrike.Models;

namespace FirstStrike.Models
{
    public class Hamas
    {
        private string _DateOfFormation;
        private Terrorist _CurrentCommander = null;
        private List<Terrorist> _Members;

        public Hamas()
        {
            _DateOfFormation = "19/08/1989";
        }

        private Terrorist CurrentCommander()
        {
            return _CurrentCommander;
        }
        public void AddMember(Terrorist trr)
        {
            if (CurrentCommander() == null || )
            {
                _CurrentCommander = trr;
            }
                _Members.Add(trr);

        }
    }
}
