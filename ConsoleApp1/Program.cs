using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Testing stack with arrays
            Console.WriteLine("Stack Using Arrays");
            StackWithArrays swa = new StackWithArrays(50);
            swa.push(1);
            swa.push(2);
            swa.push(3);
            swa.push(4);
            swa.push(5);

            swa.peek();

            swa.printStack();

            swa.pop();
            swa.pop();
            swa.pop();

            swa.printStack();

            Console.WriteLine("Stack Using Linked List");

            StackWithLinkedList swl = new StackWithLinkedList(1);
            swl.push(2);
            swl.push(3);
            swl.push(4);
            swl.push(5);

            swl.print();

            swl.peek();

            swl.pop();
            swl.pop();
            swl.pop();

            swl.print();


            Console.ReadLine();

        }
    }
}
