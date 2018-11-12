using DataStructuresCode.Dictionary;
using DataStructuresCode.HashSet;
using DataStructuresCode.LinkedList;
using DataStructuresCode.List;
using DataStructuresCode.ObservableCollection;
using DataStructuresCode.Queue;
using DataStructuresCode.SortedList;
using DataStructuresCode.Stack;
using DataStructuresCode.BinaryTree;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataStructuresCode.BinaryTree;

namespace DataStructuresCode
{
    class Program
    {
        static void Main(string[] args)
        {
            BinarySearchTree binaryTree = new BinarySearchTree();
            Random r = new Random();

            for(int i = 0; i < 10; i++)
            {
                binaryTree.Add(r.Next(1, 101));
            }
            binaryTree.Search(55);
        }
    }
}
