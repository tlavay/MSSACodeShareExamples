using System;
using System.Collections.Generic;
using System.Text;

namespace CodeShare.Examples.Abstract
{
    public sealed class Axe : WeaponBase
    {
        private readonly double dps = 2.67343432;
        public override double DoSomeDamageBase(int chanceRoll)
        {
            return dps * chanceRoll;
        }
    }
}
