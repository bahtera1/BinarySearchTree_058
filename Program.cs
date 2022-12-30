using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree_058
{
    class Node
    {
        public string info;
        public Node leftchild;
        public Node rightchild;

        //konstruktor untuk class node

        public Node(string i, Node l, Node r)
        {
            info = i;
            leftchild = l;
            rightchild = r;
        }
    }

    // A node class consist on three things, the information, refrence of the right child and reference of the left child


    class BinaryTree
    {
        public Node ROOT;
        public BinaryTree()
        {
            ROOT = null; //initializing ROOT to null
        }

        public void insert(string element) //insert a node in the binary search tree
        {
            Node tmp, parent = null, currentNode = null;
            Search(element, ref parent, ref currentNode);
            if(currentNode != null) //check if the node to be inserted already inserted or not
            {
                Console.WriteLine("Duplicate words not allowed");
                return;

            }
            else //if the spesiefied is not present
            {
                tmp = new Node(element, null, null); //create a Node
                if(parent == null)  //if the tree is empty
                {
                    ROOT - tmp;
                }
                else if(string.Compare(element,parent.info)<0)
                {
                    parent.leftchild = tmp;
                }
                else
                {
                    parent.rightchild = tmp;
                }
            }
        }
    }
















    internal class Program
    {
     
        static void Main(string[] args)
        {
        }
    }
}
