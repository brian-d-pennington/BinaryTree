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

namespace DataStructuresCode
{
    class Program
    {
        static void Main(string[] args)
        {
            //List Example
            //List<Customer> customers = new List<Customer>();
            //Customer mike = new Customer() { Name = "Mike", Age = 29 };
            //customers.Add(mike);

            //Linked List Example
            //Console.WriteLine("Linked List");
            //SingleLinkedList singleLinkedList = new SingleLinkedList();
            //singleLinkedList.CreateList();
            //singleLinkedList.Menu();


            //Sorted List Example
            //Console.WriteLine("Sorted List");
            //EmployeeTracker employeeTracker = new EmployeeTracker();
            //employeeTracker.DisplayEmployeesNameAge();

            //Observable Collection Example
            //Console.WriteLine("Observable Collection");
            //MovieTracker movieTracker = new MovieTracker();
            //movieTracker.GetFastFuriousFilmCollection();

            //Dictionary
            //Console.WriteLine("Dictionary");
            //DictionaryExamples dictionaryExamples = new DictionaryExamples();
            //dictionaryExamples.DisplayAnimalCategorization();
            //dictionaryExamples.DisplayMonthSeason();
            //dictionaryExamples.DisplayEmployeeIdName();

            //HashSet
            //Console.WriteLine("Hash Set");
            //CountriesTracker countriesTracker = new CountriesTracker();
            //countriesTracker.CheckHasCountries();

            //Stack
            //Console.WriteLine("Stack");
            //StackExample stack = new StackExample();
            //stack.PushOnToStack();

            //Queue
            Console.WriteLine("Queue");
            QueueExample queue = new QueueExample();
            queue.EnqueueOnQueue();

            ////Binary Tree
            ////ASCII characters table: https://www.dotnetperls.com/ascii-table
            Console.WriteLine("Binary Tree");
            DataStructuresCode.BinaryTree.BinaryTree binaryTree = new DataStructuresCode.BinaryTree.BinaryTree();
            binaryTree.CreateTree();
            binaryTree.Display();
            Console.WriteLine();

            //Pre-order starts at root and works its way down left side of tree
            Console.WriteLine("Pre-order: ");
            binaryTree.PreOrder();
            Console.WriteLine("");

            //In-order starts at the farthest-left node and works its way to the farthest-right
            Console.WriteLine("In-order: ");
            binaryTree.InOrder();
            Console.WriteLine();

            //Post-order starts with the farthest-left tree and works its way to the root tree-by-tree
            Console.WriteLine("Post-order: ");
            binaryTree.PostOrder();
            Console.WriteLine();

            //Level-order works its way node-to-node by level
            Console.WriteLine("Level order: ");
            binaryTree.LevelOrder();
            Console.WriteLine();

            Console.WriteLine($"Height of tree is {binaryTree.Height()}");

        }
    }
}
