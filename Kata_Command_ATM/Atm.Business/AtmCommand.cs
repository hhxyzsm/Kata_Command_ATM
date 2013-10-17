using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Atm.Business
{
    public abstract class AtmCommand
    {   
        protected BankBaseServer bankbaseServer = null;

        public AtmCommand(BankBaseServer bankBaseServer)
        {
            this.bankbaseServer = bankBaseServer;
        }
          
        abstract public void Execute(Decimal Value);

    }
}
