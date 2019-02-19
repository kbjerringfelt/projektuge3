using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECS.Legacy.Unit.Test
{
    internal class FakeHeater : IHeater
    {
        public int TurnOffCalledTimes { get; set; }
        public int TurnOnCalledTimes { get; set; }

        public FakeHeater()
        {
            TurnOffCalledTimes = 0;
            TurnOnCalledTimes = 0;
        }
        public void TurnOn()
        {
            ++TurnOnCalledTimes;
        }

        public void TurnOff()
        {
            ++TurnOffCalledTimes;
        }

        public bool RunSelfTest()
        {
            return true;
        }
    }
}
