using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace ECS.Legacy.Unit.Test
{
    [TestFixture]
    public class ECSLegacy_unit_test
    {
        private ECS uut;
        private int _threshold;


        [SetUp]
        public void SetUp()
        {
            uut = new ECS(0, new FakeHeater(), new FakeTempSensor());
        }

        [Test]



    }
}
