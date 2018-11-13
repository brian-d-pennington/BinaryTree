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

            bool isFinished = false;
            while (isFinished == false)
            {
                if (numToSearch.Equals(currentNode))
                {
                    Console.Write("The number " + numToSearch + " was found.");
                    isFinished = true;
                    return;
                }
                else if (!numToSearch.Equals(currentNode))
                {
                    currentNode = currentNode.leftChild;
                    if (numToSearch.Equals(currentNode))
                    {
                        Console.Write("The number " + numToSearch + " was found.");
                        isFinished = true;
                        return;
                    }
                    else if (currentNode.leftChild == null)
                    {
                        Console.Write("The number " + numToSearch + " doesn't exist in Binary Tree.");
                        isFinished = true;
                        return;
                    }
                    // recycle while loop until match or null
                }
                else
                {
                    currentNode = currentNode.rightChild;
                    if (numToSearch.Equals(currentNode))
                    {
                        Console.Write("The number " + numToSearch + " was found.");
                        isFinished = true;
                        return;
                    }
                    else if (currentNode.rightChild == null)
                    {
                        Console.Write("The number " + numToSearch + " doesn't exist in Binary Tree.");
                        isFinished = true;
                        return;
                    }

                }
            }
        }

    }
}
