﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECS.Legacy.Unit.Test
{
    public class FakeHeater : IHeater
    {
        public void TurnOn()
        {
            System.Console.WriteLine("Heater is on");
        }

        public void TurnOff()
        {
            System.Console.WriteLine("Heater is off");
        }

        public bool RunSelfTest()
        {
            return true;
        }
    }
}
