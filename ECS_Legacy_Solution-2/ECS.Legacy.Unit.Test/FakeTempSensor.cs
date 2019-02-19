using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECS.Legacy.Unit.Test
{
    internal class FakeTempSensor : ITempSensor
    {
        public int Temp { get; set; }

        public FakeTempSensor()
        {
            Temp = 0;
        }

        public int GetTemp()
        {
            return Temp;
        }

        public bool RunSelfTest()
        {
            return true;
        }
    }
}
