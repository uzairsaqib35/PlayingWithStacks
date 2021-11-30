using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class StackWithArrays
    {
        int top = -1;
        int[] stk;
        int MAX = 0;

        public StackWithArrays(int max) 
        {
            this.MAX = max;
            stk = new int[MAX];
        }

        public bool isEmpty() 
        {
            return this.top == -1 ? true : false;
        }

        public bool isFull() 
        {
            return this.top == MAX - 1 ? true:false;
        }

        public void printStack() 
        {
            if (!isEmpty())
            {
                for (int i = top; i >= 0; i--)
                {
                    Console.WriteLine("|"+stk[i]+ "|");
                }

            }
            else 
            {
                Console.WriteLine("Can't print stack is empty");
            }
            
        }

        public void peek() 
        {
            if (!isEmpty())
            {
                Console.WriteLine("PEEK CALLED : =>" + stk[top]);
            }
            else 
            {
                Console.WriteLine("CAN'T PEEK STACK IS EMPTY");
            }
          
        }

        public void push(int value) 
        {
            if (!isFull())
            {
                top++;
                stk[top]=value;

                Console.WriteLine("("+value+")PUSHED TO STACK");

            }
            else 
            {
                Console.WriteLine("CAN'T PUSH STACK IS FULL");
            }
        }

        public void pop()
        {
            if (!isEmpty())
            {
                int temp = stk[top];
                top--;

                Console.WriteLine("(" + temp + ")POPED FROM STACK");
            }
            else
            {
                Console.WriteLine("CAN'T POP STACK IS EMPTY");
            }
        }

    }
}
