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
        private FakeTempSensor _fakeTempSensor;
        private FakeHeater _fakeHeater;

        [SetUp]
        public void SetUp()
        {
            _fakeTempSensor = new FakeTempSensor();
            _fakeHeater = new FakeHeater();
            uut = new ECS(0, _fakeTempSensor, _fakeHeater);
           
        }

        [Test]

        public void Test1()
        {
            

            Assert.That(_fakeHeater.WasTurnOnCalled, Is.EqualTo(true));
        }

    }
}
