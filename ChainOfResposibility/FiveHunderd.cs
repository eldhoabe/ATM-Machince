using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResposibility
{
    public class FiveHunderd : Node
    {
        public override bool ProcessNode(int amount)
        {
            int processableAmount = amount % 500;

            if (processableAmount > 0)
                return NextNode != null ? NextNode.ProcessNode(processableAmount) :  false;
            return true;

        }

        protected override int Denomination
        {
            get { return 500; }
        }
    }
}
