using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class StackWithLinkedList
    {
        private int value { get; set; }
        private StackWithLinkedList nextNode { get; set; }


        public bool isEmpty(StackWithLinkedList firstNode) 
        {
            return firstNode == null ? true:false;
        }

        public void push(int value) 
        {
            //Here push means inserting a node at the beginning of the linked list
            StackWithLinkedList newNode = new StackWithLinkedList();
            newNode.value = value;

            if (isEmpty(this)) 
            {
            
            }

        }



    }
}
