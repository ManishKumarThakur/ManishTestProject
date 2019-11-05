using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RNDVS2017_ConsoleApp
{
   public class Node1
    {
        internal int data;
        internal Node1 next;

        public Node1(int val)
        {
            this.data = val;
            this.next = null;
        }
    }
}
