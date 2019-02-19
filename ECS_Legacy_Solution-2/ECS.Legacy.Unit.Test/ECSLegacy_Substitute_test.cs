using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NSubstitute;
using NUnit.Framework;

namespace ECS.Legacy.Unit.Test
{
    [TestFixture]
    public class ECSLegacy_Substitute_test
    {
        private ECS _uut;
        private ITempSensor _tempSensor;
        private IHeater _heater;

        [SetUp]
        public void Setup()
        {
            _tempSensor = Substitute.For<ITempSensor>();
            _heater = Substitute.For<IHeater>();
            _uut = new ECS(25, _tempSensor, _heater);
        }

        [Test]
        public void TempChanged()
        {
            _tempSensor.GetTemp().Returns(10);
            _uut.Regulate();
            _heater.Received(1).TurnOn();



        }

        [Test]
        public void TempChangedRunSelfTest()
        {
            _tempSensor.RunSelfTest().Returns(false);
            _heater.RunSelfTest().Returns(true);
            Assert.IsFalse(_uut.RunSelfTest());

        }

    }
}
