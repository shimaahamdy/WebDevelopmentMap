using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    public class Mediator
    {
        Attackers attackers;
        Defenders defenders;
        Guards guards;
        Soliders soliders;

        public void  setComponents(Attackers _attackers, Defenders _defenders, Guards guards, Soliders _soliders)
        {
            this.attackers = _attackers;
            this.defenders = _defenders;
            this.guards = guards;
            this.soliders = _soliders;
        }


        public bool GuardPosition(string position)
        {
            if(guards.position(position))return true;
            else return false;
        }

        public string SolidersWeapons()
        {
            return soliders.provide();
        }

        public bool DefendersINCastle()
        {
            return defenders.castle();
        }
    }
}
