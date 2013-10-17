using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Atm.Business;

namespace Atm.Tests
{
    [TestClass]
    public class AtmTests
    {
        [TestMethod]
        public void TestAtm()
        {
            //问题1:接收者对象是一个还是多个好？
            BankBaseServer bankBaseServer = new BankBaseServer();//接收者（Receiver）角色

            AtmCommand depositCommand = new AtmDepositCommand(bankBaseServer);//实例化具体的命令角色
            AtmCommand withdrawCommand = new AtmWithdrawCommand(bankBaseServer);//实例化具体的命令角色
            AtmCommand powerPurchaseCommand = new AtmPowerPurchaseCommand(bankBaseServer);//实例化具体的命令角色
            AtmMachine atmMachine = new AtmMachine();//请求者（Invoker）角色
            //接收者接受存款命令并执行
            Assert.AreEqual(0m, bankBaseServer.GetBalance());
            Assert.AreEqual(0m, bankBaseServer.GetElectricityUnits());
            //接收者接受存款命令并执行存款1000
            atmMachine.SetCommand(depositCommand);
            atmMachine.Invoke(1000m);
            Assert.AreEqual(1000m, bankBaseServer.GetBalance());
            //接收者接受存款命令并执行取款300
            atmMachine.SetCommand(withdrawCommand);
            atmMachine.Invoke(300m);
            Assert.AreEqual(700m, bankBaseServer.GetBalance());
            //接收者接受存款命令并执行缴电费100度
            atmMachine.SetCommand(powerPurchaseCommand);
            atmMachine.Invoke(100m);
            Assert.AreEqual(500m, bankBaseServer.GetBalance());
            Assert.AreEqual(100m, bankBaseServer.GetElectricityUnits());
        }
    }
}
