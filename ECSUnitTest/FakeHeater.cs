using System;
using System.Collections.Generic;
using System.Text;

namespace ReDesignECS
{
    internal class FakeHeater : IHeater
    {
        public bool state;
        public void TurnOn()
        {
            state = true;
        }

        public void TurnOff()
        {
            state = false;
        }

        public bool RunSelfTest()
        {
            return true;
        }
    }
}
