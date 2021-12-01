using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class StackWithLinkedList
    {
        public LinkedList stack { get; set; }

        public StackWithLinkedList(int value) 
        {
            stack = new LinkedList(value);
        }

        public void push(int value) 
        {
            stack.insertAtBeginingOfList(value);
        }

        public void pop()
        {
            stack.deleteFromFront();
        }

        public void peek() 
        {
            stack.peek();
        }

        public void print() 
        {
            stack.printAllNodes();
        }
    }
}
