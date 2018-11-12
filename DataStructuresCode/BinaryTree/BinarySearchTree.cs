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
                    // found number (root)
                    isFinished = true;
                    return;
                }
                else if (!numToSearch.Equals(currentNode.leftChild))
                {
                    if (true)
                    {
                        currentNode = currentNode.leftChild;
                        numToSearch.Equals(currentNode.leftChild);
                        if (currentNode.leftChild == null)
                        {
                            // number doesn't exist in tree
                            isFinished = true;
                        }
                    }
                    else
                    {
                        // found number
                        isFinished = true;
                        return;
                    }
                }
                else if (!numToSearch.Equals(currentNode.rightChild))
                {
                    if (true)
                    {
                        currentNode = currentNode.rightChild;
                        numToSearch.Equals(currentNode.rightChild);
                        if (currentNode.rightChild == null)
                        {
                            // number doesn't exist in tree
                            isFinished = true;
                        }
                    }
                    else
                    {
                        // found number
                        isFinished = true;
                        return;
                    }
                }
            }
        }

    }
}
