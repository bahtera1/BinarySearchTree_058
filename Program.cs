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
    }
















    internal class Program
    {
     
        static void Main(string[] args)
        {
        }
    }
}
