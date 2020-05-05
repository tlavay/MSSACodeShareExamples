using CodeShare.Examples;
using CodeShare.Examples.Abstract;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace CodeShare.Tests.Examples
{
    public class InterfaceAbstractionExamples
    {
        [Fact]
        public void IWeapon_DoSomeDamge_WithA1To10Roll_ShouldReturnDamage()
        {
            //Arrange
            var sword = new Sword();
            var axe = new Axe();
            var random = new Random();

            //Act
            var damage = sword.DoSomeDamageBase(random.Next(1, 100));

            ArrayHelper.HitBoss(sword);
            ArrayHelper.HitBoss(axe);

            //Assert
        }
    }
}
