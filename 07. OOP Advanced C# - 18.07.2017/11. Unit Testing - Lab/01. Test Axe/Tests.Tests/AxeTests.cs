using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests.Tests
{
    [TestFixture]
    public class AxeTests
    {
        [Test]
        public void AxeAttackLosesDurability()
        {
            Axe axe = new Axe(10,10);
            Dummy dummy = new Dummy(10,10);

            axe.Attack(dummy);

            Assert.AreEqual(9,axe.DurabilityPoints);
        }

        [Test]
        public void AxeAttackWithoutDurability()
        {
            Axe axe = new Axe(10, 1);
            Dummy dummy = new Dummy(10, 10);

            axe.Attack(dummy);

            Assert.AreEqual(0, axe.DurabilityPoints);
        }
    }
}
