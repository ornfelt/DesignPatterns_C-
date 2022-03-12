using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.ChainOfResp
{
    /// <summary>
    /// The 'Handler' abstract class
    /// </summary>
    public abstract class Approver
    {
        protected Approver successor;
        public void SetSuccessor(Approver successor)
        {
            this.successor = successor;
        }
        public abstract void ProcessRequest(Purchase purchase);
    }
}
