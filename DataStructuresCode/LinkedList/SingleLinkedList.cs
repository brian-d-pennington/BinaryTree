using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresCode.LinkedList
{
    public class SingleLinkedList
    {
        //first node in list
        private Node start;
        public SingleLinkedList()
        {
            start = null;
        }
        public void CreateList()
        {
            Console.Write("Enter the number of nodes: ");
            int numberNodes = int.Parse(Console.ReadLine());
            if(numberNodes == 0)
            {
                return;
            }
            for(int i = 1; i <= numberNodes; i++)
            {
                Console.Write("Enter the element to be inserted: ");
                int data = int.Parse(Console.ReadLine());
                InsertAtEnd(data);

            }
        }
        public void InsertInBeginning(int data)
        {
            Node temp = new Node(data);
            temp.link = start;
            start = temp;
        }
        public void InsertAtEnd(int data)
        {
            Node node;
            Node temp = new Node(data);
            if(start == null)
            {
                start = temp;
                return;
            }
            node = start;
            while(node.link != null)
            {
                node = node.link;
            }
            node.link = temp;
        }
        
        public void DisplayList()
        {
            Node node;
            if(start == null)
            {
                Console.WriteLine("List is empty");
                return;
            }
            Console.Write("List is : ");
            node = start;
            while (node != null)
            {
                Console.Write(node.info + " ");
                node = node.link;
            }
            Console.WriteLine();
        }

        public void CountNodes()
        {
            int number = 0;
            Node node = start;
            while(node != null)
            {
                number++;
                node = node.link;
            }
            Console.WriteLine($"Number of nodes in the list = {number}");
        }
        public bool Search(int x)
        {
            int position = 1;
            Node node = start;
            while(node != null)
            {
                if(node.info == x)
                {
                    break;
                }
                position++;
                node = node.link;
            }
            if (node == null)
            {
                Console.WriteLine($"{x} not found in list");
                return false;
            }
            else
            {
                Console.WriteLine($"{x} is at position {position}");
                return true;
            }
        }
        public void Menu()
        {
            int choice;
            int data;
            while (true)
            {
                Console.WriteLine("1. Display List");
                Console.WriteLine("2. Count the number of nodes");
                Console.WriteLine("3. Search for an element");
                Console.WriteLine("4. Insert in empty list/Insert in beginning of the list");
                Console.WriteLine("5. Insert a node at the end of the list");

                Console.Write("Enter your choice: ");
                choice = int.Parse(Console.ReadLine());
                if (choice == 6)
                {
                    break;
                }
                switch (choice)
                {
                    case 1:
                        DisplayList();
                        break;
                    case 2:
                        CountNodes();
                        break;
                    case 3:
                        Console.Write("Enter the element to be searched: ");
                        data = int.Parse(Console.ReadLine());
                        Search(data);
                        break;
                    case 4:
                        Console.Write("Enter the element to be inserted: ");
                        data = int.Parse(Console.ReadLine());
                        InsertInBeginning(data);
                        break;
                    case 5:
                        Console.Write("Enter the element to be inserted: ");
                        data = int.Parse(Console.ReadLine());
                        InsertAtEnd(data);
                        break;
                }
            }
        }
    }
}
