using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Atm.Business
{
    public class AtmPowerPurchaseCommand : AtmCommand
    {
        public AtmPowerPurchaseCommand(BankBaseServer bankBaseServer)
            : base(bankBaseServer) { }

        public override void Execute(decimal electricUnits)
        {
            base.bankbaseServer.addAmount(electricUnits * this.bankbaseServer.UnitPrice);

            base.bankbaseServer.AddElectricityUnits(electricUnits);
        }
    }
}
