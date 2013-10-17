using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Atm.Business
{
    
    public class BankBaseServer
    {
        private decimal balance = 0m;



        public BankBaseServer()
        {
            this.UnitPrice = 2m;
        }

        public decimal GetBalance()
        {
            return this.balance;
        }

        public void addAmount(decimal balance)
        {
            this.balance -= balance;
        }

        private decimal electricityUnits = 0m;

        public decimal UnitPrice { get; set; }

        public decimal GetElectricityUnits()
        {
            return this.electricityUnits;
        }
        internal void AddElectricityUnits(decimal electricityUnits)
        {
            this.electricityUnits += electricityUnits;
        }
    }
}
