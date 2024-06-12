using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Create_LinkedList
{
    internal class LinkedHouses
    {

        private Node head; // starting point
        private Node tail; // last known node
        
        private string address;
        private int size; // counter to keep track of total nodes
        public int Length { get { return size; } }
        public string Address { get { return address; } }



        public LinkedHouses()
        {
            head = null; tail = null; size = 0;
        }
        public bool IsEmpty() // check to see if its null first? 
        {
            return size == 0;
        }

        public void AddHouse(int val, string address)
        {
            Node newest = new Node(val, null);
            this.address = address;
            
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
            int i = 1;
            if (IsEmpty()) { Console.WriteLine("List is empty"); }
            else
            {
                while (p != null)
                {
                    Console.Write($"[{i}] House #{p.data}, Address: {Address}\n");
                    
                    p = p.next;
                }
            }
            Console.WriteLine();
        }

        public void UpdateFirst(int val, string address)
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
            this.address = address;
            size++;
        }

        public void RemoveFirstHouse()
        {
            if (IsEmpty())
            {
                Console.WriteLine("There are no houses...");
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
                Console.WriteLine($"House #{data} has been removed");
            }

        }

        public void Cut_the_Tail()
        {
            if (IsEmpty()) { Console.WriteLine("There are no houses..."); }

            Node h = head;
            int i = 1;
            while (i < size - 1) // second to last node (new tail)
            {
                h = h.next; // moves through nodes
                i++;
            }

            tail = h;   // assigns current node to tail

            h = h.next; // goes to final node to get data
            int data = h.data; // assigns data

            tail.next = null;  // removes final node
            size--; // updates size
            Console.WriteLine($"House #{data} was removed...");
        }

        public void Search(int val) // update?
        {
            Node h = head;
            int i = 1;
            while (h != null)
            {
                if (h.data == val)
                {
                    Console.WriteLine($"House #{val} is located at index: [{i}] with the address of: {Address}");
                    i = 0; break;
                }
                h = h.next;
                i++;
            }
            if(i!=0)
                Console.WriteLine("The house you were looking for was not found...");
        }

        public void AddAnywhere(int data, string address, int position)
        {
            if (position <= 0 || position > size)
            {
                Console.WriteLine("Invalid position");
            }
            else if (position == 1)
            {
                UpdateFirst(data, address);
            }

            Node h = head;
            int i = 1;
            while (i < position - 1)
            {
                h = h.next;
                i++;
            }
            Node addNode = new Node(data, h.next); // creates node using user data and takes position node as tail.
            h.next = addNode;
            h = h.next;
            this.address = address;
            size++; // updates size

        }
        public void RemoveAnywhere(int position)
        {
            if (position <= 0 || position > size)
            {
                Console.WriteLine("Invalid position");
            }
            else if (position == 1)
            {
                RemoveFirstHouse();
            }
            else if (position == size)
            {
                Cut_the_Tail();
            }
            else
            {
                Node h = head;
                int i = 2;
                while (i < position - 1)
                {
                    h = h.next;
                    i++;
                }
                int data = h.next.data; // assigns data
                h.next = h.next.next;   // assigns current node to tail
                size--; // updates size
                Console.WriteLine($"House #{data} was removed...");
            }
        }


        // adding a mid section?
    }
}

