using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class LinkedList
    {
        public Node head { get; set; }

        public LinkedList(int value) 
        {
            this.head = new Node();
            this.head.value = value;
            this.head.nextNode = null;
        }

        public bool isEmpty() 
        {
            return head == null ? true : false;
        }

        public void insertAtBeginingOfList(int value) 
        {
            Node newNode = new Node();
            newNode.value = value;

            if (isEmpty())
            {
                head = newNode;
                head.nextNode = null;
            }
            else 
            {
                newNode.nextNode = head;
                head = newNode;
            }

            Console.WriteLine(head.value + " pushed to stack");
        }

        public void deleteFromFront() 
        {
            if (head == null)
            {
                Console.WriteLine("Can't pop already empty");
            }
            else 
            {
                Console.WriteLine(head.value+" poped from stack");
                head = head.nextNode;
            }
        }

        public void peek() 
        {
            Console.WriteLine(head.value + " peeked");
        }

        public void printAllNodes() 
        {
            Node headNode = new Node();
            headNode = head;
            while (headNode!=null) 
            {
                if (headNode.nextNode != null)
                {
                    Console.Write("[" + headNode.value + "]->");
                }
                else 
                {
                    Console.Write("[" + headNode.value + "]");
                }
             
                headNode = headNode.nextNode;
            }
        }

    }
}
