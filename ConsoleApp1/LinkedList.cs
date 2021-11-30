using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class LinkedList
    {
        public int value { get; set; }
        public LinkedList nextNode { get; set; }

        public bool isEmpty()
        {
            return this == null ? true : false;
        }

        public LinkedList insertAtTheBeginningOfTheList(int value)
        {
            LinkedList newNode = new LinkedList();
            newNode.value = value;

            if (isEmpty())
            {
                newNode.nextNode = null;
                return newNode;
            }
            else 
            {
                return newNode;
            }
        }
    }
}
