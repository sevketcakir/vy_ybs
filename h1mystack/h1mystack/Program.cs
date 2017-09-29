using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace h1mystack
{
    class Program
    {
        static void Main(string[] args)
        {
            MyStack stack = new MyStack(5);
            stack.push(5);
            stack.push(6);
            stack.push(2);
            stack.push(5);
            stack.push(7);
            //stack.print();
            while (!stack.isEmpty())
                stack.pop();
            stack.print();
            stack.push(5);
            stack.push(2);
            stack.push(7);
            stack.pop();
            stack.push(6);
            stack.push(9);
            stack.push(4);
            stack.pop();
            stack.pop();
            stack.push(12);
            stack.print();

        }
    }
}
