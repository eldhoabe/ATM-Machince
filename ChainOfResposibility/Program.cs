using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResposibility
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                int amount = int.Parse(Console.ReadLine());
                
                TwoThousand twoThousand = new TwoThousand();
                twoThousand.Add(new FiveHunderd().Add(new Hundered()));
                
                Console.WriteLine(twoThousand.ProcessNode2(amount));

            }

        }
    }
}
