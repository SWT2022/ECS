using System;

namespace ECS.Legacy
{
    interface ITempSensor
    {
        int GetTemp();
    }
    internal class TempSensor : ITempSensor
    {
        private Random gen = new Random();

        public int GetTemp()
        {

            return gen.Next(-5, 45);
        }

        public bool RunSelfTest()
        {
            return true;
        }
    }
}