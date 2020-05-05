using System;
using System.Collections.Generic;
using System.Text;

namespace CodeShare.Examples.Abstract
{
    public abstract class WeaponBase
    {
        public abstract double DoSomeDamageBase(int chanceRoll);

        public double DoSomeDamage(int chanceRoll)
        {
            var times2 = chanceRoll * 2;
            return this.DoSomeDamageBase(times2);
        }
    }
}
