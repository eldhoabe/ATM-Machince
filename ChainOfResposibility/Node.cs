using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResposibility
{
    public abstract class Node
    {
        protected Node NextNode { get; set; }

        protected abstract int Denomination { get; }

        public Node Add(Node node)
        {
            this.NextNode = (node);
            return this;
        }

        public abstract bool ProcessNode(int amount);


        public bool ProcessNode2(int amount)
        {
            int processableAmount = amount % Denomination;

            if (processableAmount > 0)
                return NextNode.ProcessNode(processableAmount);
            return true;
        }
    }



}
