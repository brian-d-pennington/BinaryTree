using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresCode.BinaryTree
{
    public class BinarySearchTree
    {
        public Node root;



       

        public void Add(int numberAdded)
        {
            Node nodeToAdd = new Node(numberAdded);

            if (root == null)
            {
                root = nodeToAdd;
                return;
            }

            Node currentNode = root;

            bool isFinished = false;
            while(isFinished == false)
            {
                if (nodeToAdd.data < currentNode.data)
                {
                    if (currentNode.leftChild == null)
                    {
                        currentNode.leftChild = nodeToAdd;
                        isFinished = true;
                        return;
                    }
                    else
                    {
                        currentNode = currentNode.leftChild;
                    }
                    //  root.leftChild = currentNode;
                }
                else if (nodeToAdd.data > currentNode.data)
                {
                    if (currentNode.rightChild == null)
                    {
                        currentNode.rightChild = nodeToAdd;
                        isFinished = true;
                        return;
                    }
                    else
                    {
                        currentNode = currentNode.rightChild;
                    }
                }
                else
                {
                    // numbers are equal, cannot create duplicates
                    isFinished = true;
                    return;
                }
            }


            
        }
        public int numToSearch;
        public void Search(int numToSearch)
        {
            Node currentNode = root;

            if (numToSearch.Equals(currentNode))
            {
                Console.Write("The number " + numToSearch + " was found.");
                return;
            }
            else if (!numToSearch.Equals(currentNode))
            {
                bool leftChildren = false;
                while (leftChildren == false)
                {
                    currentNode = currentNode.leftChild;
                    if (numToSearch.Equals(currentNode))
                    {
                        Console.Write("The number " + numToSearch + " was found.");
                        leftChildren = true;
                        return;
                    }
                    else if (currentNode == null)
                    {
                        leftChildren = true;
                    }
                }
                currentNode = root;
                bool rightChildren = false;
                while (rightChildren == false)
                {
                    currentNode = currentNode.rightChild;
                    if (numToSearch.Equals(currentNode))
                    {
                        Console.Write("The number " + numToSearch + " was found.");
                        rightChildren = true;
                        return;
                    }
                    else if (currentNode == null)
                    {
                        rightChildren = true;
                        Console.Write("No matches found.");
                    }
                }

                
            }

        }

    }
}
