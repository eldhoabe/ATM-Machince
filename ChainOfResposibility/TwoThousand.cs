using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResposibility
{
    public class TwoThousand : Node
    {

        public override string ToString()
        {
            return "2000";
        }

        public override bool ProcessNode(int amount)
        {
            int processableAmount = amount % 2000;

            if (processableAmount > 0)
                return NextNode.ProcessNode(processableAmount);

            return true;

        }

        protected override int Denomination
        {
            get
            {
                return 2000;
            }
        }
    }
}
