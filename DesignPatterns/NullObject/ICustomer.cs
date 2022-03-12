using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.NullObject
{
    interface ICustomer
    {
        public bool IsNull();
        public void GetPlan();
    }
}
