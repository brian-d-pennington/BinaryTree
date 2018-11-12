using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresCode.LinkedList
{
    public class Node
    {
        public int info;
        public Node link;
        public Node(int info)
        {
            this.info = info;
            link = null;
        }
    }
}
