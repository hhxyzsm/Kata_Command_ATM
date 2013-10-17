using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Atm.Business
{
    public class AtmDepositCommand : AtmCommand
    {
        public AtmDepositCommand(BankBaseServer bankBaseServer) : 
            base(bankBaseServer) { }

        public override void Execute(Decimal money)
        {
            base.bankbaseServer.addAmount(-money);
        }
    }
}
