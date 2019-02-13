using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECS.Legacy.Unit.Test
{
    public class FakeHeater : IHeater
    {
        public bool WasTurnOnCalled = false;
        public bool WasTurnOffCalled = false;

        public void TurnOn()
        {
           // System.Console.WriteLine("Heater is on");
            WasTurnOnCalled = true;
        }

        public void TurnOff()
        {
            //System.Console.WriteLine("Heater is off");
            WasTurnOffCalled = true;
        }

        public bool RunSelfTest()
        {
            return true;
        }
    }
}
