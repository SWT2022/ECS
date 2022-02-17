using System;
using System.Collections.Generic;
using System.Text;

namespace ReDesignECS
{
    internal class FakeTempSensor : ITempSensor
    {
        public int GetTemp()
        {
            return 20;
        }

        public bool RunSelfTest()
        {
            return true;
        }

    }
}
