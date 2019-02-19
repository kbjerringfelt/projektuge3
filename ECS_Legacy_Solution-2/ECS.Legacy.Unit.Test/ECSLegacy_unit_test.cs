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
            uut = new ECS(25, _fakeTempSensor, _fakeHeater);
           
        }

        [Test]

        public void RegulateLowTemp_HeaterOn()
        {
            _fakeTempSensor.Temp = 20;
            uut.Regulate();

            Assert.That(_fakeHeater.TurnOnCalledTimes,Is.EqualTo(1));
        }

        [Test]

        public void RegulateHighTemp_HeaterOff()
        {
            _fakeTempSensor.Temp = 30;
            uut.Regulate();

            Assert.That(_fakeHeater.TurnOffCalledTimes, Is.EqualTo(1));
        }

        [Test]

        public void RegulateNormalTemp_HeaterOn()
        {
            _fakeTempSensor.Temp = 25;
            uut.Regulate();

            Assert.That(_fakeHeater.TurnOnCalledTimes, Is.EqualTo(0));
        }

    }


    }

