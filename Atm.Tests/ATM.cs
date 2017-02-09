using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ChainOfResposibility;

namespace Atm.Tests
{
    [TestClass]
    public class ATM
    {
        [TestMethod]
        public void ValidAmount_ShouldAbleToProcess()
        {

            var twothousand = new TwoThousand();
            twothousand.Add(new Hundered());
            Assert.IsTrue(twothousand.ProcessNode2(2400));
        }

        [TestMethod]
        public void InvalidAmount_ShouldNotAbleToProcess()
        {

            var twothousand = new TwoThousand();
            twothousand.Add(new Hundered());
            Assert.IsFalse(twothousand.ProcessNode2(2412));
        }


        [TestMethod]
        public void FiveHunderedAndTwoThousandOnlyInMachine_ValidAmount()
        {

            var twothousand = new TwoThousand();
            twothousand.Add(new FiveHunderd());
            Assert.IsTrue(twothousand.ProcessNode2(2500));
        }

        [TestMethod]
        public void FiveHunderedAndTwoThousandOnlyInMachine_InvalidAmount()
        {

            var twothousand = new TwoThousand();
            twothousand.Add(new FiveHunderd());
            Assert.IsFalse(twothousand.ProcessNode2(2400));
        }
    }
}
