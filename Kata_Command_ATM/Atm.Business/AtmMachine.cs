using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Atm.Business
{
    public class AtmMachine
    {
        private AtmCommand command = null;

        public void SetCommand(AtmCommand atmCommand)
        {
            this.command = atmCommand;
            
        }
        public void Invoke(decimal invokerValue)
        {
            this.command.Execute(invokerValue);
        }
    }
}
