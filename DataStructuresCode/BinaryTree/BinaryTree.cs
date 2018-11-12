using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresCode.BinaryTree
{
    public class BinaryTree
    {
        public int root;



        public void Root(Node root, int data)
        {
            if (root == null)
            {
                root = new Node(data);
            }
        }

        public void Add(Node root, int data)
        {
            if (data <= root.data)
            {
                root.leftChild = new Node(data);
            }
            else
            {
                root.rightChild = new Node(data);
            }
        }
    }
}
