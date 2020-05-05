using System;
using System.Collections.Generic;
using System.Text;

namespace CodeShare.Examples.InterfaceExamples
{
    public sealed class Axe : IWeapon
    {
        private readonly double dps = 2.67343432;
        public double DoSomeDamage(int chanceRoll)
        {
            return dps * chanceRoll;
        }
    }
}
