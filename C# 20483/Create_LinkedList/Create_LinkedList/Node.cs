using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Create_LinkedList
{
    internal class Node
    {
        // where is the head?
        
        public int data; // data of current node
        public Node next; // points to the next node (once it's assigned value.)
        public Node prev;
        public Node(int val, Node Next=null, Node Prev=null) // constructor to create node & next containing null (until overwritten) 
        {
            this.data = val;
            this.next = Next;
            this.prev = Prev;
        }
    }
}
