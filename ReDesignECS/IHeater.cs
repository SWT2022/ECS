using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReDesignECS
{
    public interface IHeater
    {
        void TurnOn();
        void TurnOff();
        bool RunSelfTest();

    }
}
