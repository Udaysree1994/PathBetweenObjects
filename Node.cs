using System;
namespace test
{
    /*
     * Using integer for id and parent for simplicity. if a node does not have parent, then parent will be 0;
     */
    public class Node
    {
        public int Id { get; set; }
        public int Parent { get; set; }
        public Node(int id, int parent)
        {
            Id = id;
            Parent = parent;
        }
    }
}
