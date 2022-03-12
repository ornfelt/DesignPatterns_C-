using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.NullObject
{
    class NullCustomer : ICustomer
    {
        public bool IsNull()
        {
            return true;
        }

        public void GetPlan()
        {
            // Do nothing
        }

    }
}
