using System;
using System.Collections.Generic;
using System.Text;

namespace CodeShare.Examples.InterfaceExamples
{
    public sealed class Sword : IWeapon
    {
        private readonly double dps = 1.67343432;
        public double DoSomeDamage(int chanceRoll)
        {
            return dps * chanceRoll;
        }
    }
}
