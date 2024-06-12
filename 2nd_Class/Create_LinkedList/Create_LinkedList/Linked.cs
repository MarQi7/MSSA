using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Create_LinkedList
{
    internal class Linked
    {
        enum Build
        {

        }
        
        private Node head; // starting point
        private Node tail; // last known node
        private int size; // counter to keep track of total nodes
        public int Length { get { return size; } }
        public string Address { get; set; }
        public int HouseNum { get; set; }
        


        public Linked()
        {
            head = null; tail = null; size = 0;
        }
        public bool IsEmpty() // check to see if its null first? 
        {
            return size == 0;
        }

        public void AddNode(int val)
        {
            Node newest = new Node(val, null);
            if (IsEmpty())
            {
                head = newest; // assigns first node as head.
            }
            else 
            { 
                tail.next = newest; // tells previous tail that next is now the newest node >>
            }
            tail = newest; // the new node becomes the tail parameter.
            size++;
        }

        public void Display()
        {
            Node p = head;
            if (IsEmpty()) { Console.WriteLine("List is empty"); }
            else
            {
                while (p != null)
                {
                    if (p.next != null)
                        Console.Write (p.data + " ---> ");
                    else Console.WriteLine(p.data);
                    p = p.next;
                }
            }
            Console.WriteLine();
        }

        public void UpdateHead(int val)
        {
            Node newHead = new Node(val, null);
            
            if (IsEmpty()) 
            { 
                head = newHead; // assign as only node, no follower.
                tail = newHead; // needs a tail
            }
            else
            {
                newHead.next = head; // assigns old head to current nodes tail.
                head = newHead; // assigns to head.
            }   
            size++;
        }

        public int RemoveHead()
        {
            if (IsEmpty())
            {
                Console.WriteLine("There are no nodes..."); return -1;
            }
            else
            {
                int data = head.data; // return this data
                head = head.next;
                size--;
                if (IsEmpty()) // there was only 1 node, which is now gone. the tail would keep that value otherwise.
                {
                    tail = null;
                }
                return data;
            }

        }

        public int Cut_the_Tail()
        {
            if (IsEmpty()) { Console.WriteLine("The list is empty"); return -1; }

            Node h = head;
            int i = 1;
            while(i<size-1) // second to last node (new tail)
            {
                h = h.next; // moves through nodes
                i++;
            }
            tail = h;   // assigns current node to tail

            h = h.next; // goes to final node to get data
            int data = h.data; // assigns data

            tail.next = null;  // removes final node
            size--; // updates size
            return data;
        }

        public bool Search(int val, out int index)
        {
            Node h = head;
            int i = 1;
            while (h != null)
            {
                if (h.data == val)
                {
                    index = i;
                    return true;
                }
                h = h.next;
                i++;
            }
            index = 0; // value 0 is not index[0] 
            return false;            
        }

        public void AddAnywhere(int data, int position)
        {
            if (position <= 0 || position > size)
            {
                Console.WriteLine("Invalid position");
            }
            else if (position == 1)
            {
                UpdateHead(data);
            }

            Node h = head;
            int i = 1;
            while (i < position-1)
            {
                h = h.next;
                i++;
            }
            Node addNode = new Node(data, h.next); // creates node using user data and takes position node as tail.
            h.next = addNode;
            
            size++; // updates size
       
        }
        public int RemoveAnywhere(int position)
        {
            if(position<=0 || position>size) 
            {
                Console.WriteLine("Invalid position");
                return -1;
            }
            else if(position==1)
            {
                return RemoveHead();
            }
            else if (position==size)
            {
                return Cut_the_Tail();   
            }
            Node h = head;
            int i = 1;
            while (i < position - 1)
            {
                h = h.next;
                i++;
            }
            int data = h.next.data; // assigns data
            h.next = h.next.next;   // assigns current node to tail
            size--; // updates size
            return data;
        }

        public void Return_Head_to_Tail()
        {

        }

        public void Return_Tail_to_Head()
        {

        }
        // adding a mid section?
    }
}
