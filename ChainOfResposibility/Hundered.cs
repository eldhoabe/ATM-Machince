using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChainOfResposibility
{
   public class Hundered : Node
    {
        public override bool ProcessNode(int amount)
        {
            int processableAmount = amount % 100;

            if (processableAmount > 0)
                return NextNode != null;
            return true;
        }

        protected override int Denomination
        {
            get { return 100; }
        }
    }
}
