using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myqueue
{
    class Program
    {
        static void Main(string[] args)
        {
            MyQueue q1 = new MyQueue();
            MyQueue q2 = new MyQueue(66);
            q1.enqueue(5);
            q1.enqueue(7);
            q1.enqueue(4);
            q1.print();
            Console.WriteLine();
            q1.dequeue();
            q1.dequeue();
            q1.dequeue();
            q1.print();
            Console.WriteLine();
            q1.enqueue(6);
            q1.print();
            Console.WriteLine();

        }
    }
}
