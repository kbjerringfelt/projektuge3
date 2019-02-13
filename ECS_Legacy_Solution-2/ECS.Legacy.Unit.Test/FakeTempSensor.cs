using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECS.Legacy.Unit.Test
{
    public class FakeTempSensor : ITempSensor
    {

        public int GetTemp()
        {
            return 0;
        }

        public bool RunSelfTest()
        {
            return true;
        }
    }
}
