using System;
using System.Collections.Generic;

namespace test
{
    class Program
    {
        //creating a list to store nodes
        static List<Node> nodeList = new List<Node>();


        static void Main(string[] args)
        {
            //add new node objects to nodeList with Id and Parent
            nodeList.Add(new Node(1, 2));
            nodeList.Add(new Node(2, 3));
            nodeList.Add(new Node(3, 4));
            nodeList.Add(new Node(4, 5));
            nodeList.Add(new Node(5, 7));
            nodeList.Add(new Node(7, 5));

            //creating 2 temporary nodes a and b to search path between a and b
            Node a = nodeList.Find(x => x.Id == 1);
            Node b = nodeList.Find(x => x.Id == 7);

            //if(id of a is same as parent of b, it means they are linked to one another
            if(a.Id == b.Parent)
            {
                Console.WriteLine(a.Id + " " + a.Parent + "---->" + b.Id+ " "+b.Parent);
            }

            //loop until you find a link between a and b
            while (a.Id != b.Parent)
            {
                //print the path
                Console.WriteLine(a.Id + " " + a.Parent + "---->");
                //a will be the new neighbour
                a = FindNeighbour(a);

            }

        }

        //method to find the neighbour of a node
        public static Node FindNeighbour(Node a)
        {
            //traverse through the list
            foreach(Node n in nodeList)
            {
                //if a link is found
                if(n.Id == a.Parent)
                {
                    //if parent is not zero (there is no parent)
                    if(n.Parent != 0)
                    {
                        //return node
                        return n;
                    }
                }
            }
            //if node is not found return null
            return null;      
        }
    }
}
