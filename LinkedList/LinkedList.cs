using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    internal class LinkedList
    {
        public Node head;

        public void Add(int data)
        {
            Node node = new Node(data);
            if (this.head == null)
            {
                this.head = node;
            }
            else
            {
                Node temp = this.head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;
            }
            Console.WriteLine($"{node.data} Add in to LinkedList");
        }
        public Node InserttoLnkLst(int position, int data)
        {
            if (position < 0)
            {
                Console.WriteLine("Invalid position : Write a valid position");
            }
            if (position == 1)
            {
                Node newNode = new Node(data);
                newNode.next = this.head;
                head = newNode;
                
            }
            else
            {
                Node temp = this.head;
                while (position-- != 0)
                {
                    if (position == 1)
                    {
                        Node node = new Node(data);
                        node.next = this.head.next;
                        head.next = node;
                        break;
                    }
                    temp = temp.next;
                }
                if (position != 1)
                {
                    Console.WriteLine("position Out Of Range");
                }
            }
            return head;
        }
        public void DiaplayLnkLst()
        {
            Node temp = this.head;
            if (temp == null)
            {
                Console.WriteLine("The LinkedList is Emptay");
                return;
            }
            else
            {
                
                while (temp != null)
                {
                    Console.Write(temp.data + "  ");
                    temp = temp.next;
                }
                
            }
        }

    }
}
