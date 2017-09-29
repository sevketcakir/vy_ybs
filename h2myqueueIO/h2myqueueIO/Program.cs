using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace h2myqueueIO
{
    class Program
    {
        static void Main(string[] args)
        {
            MyQueue kuyruk = new MyQueue();
            kuyruk.enqueue(5);
            kuyruk.enqueue(7);
            kuyruk.enqueue(4);
            kuyruk.print();
            kuyruk.dequeue();
            kuyruk.dequeue();
            kuyruk.dequeue();
            kuyruk.print();
            kuyruk.enqueue(6);
            kuyruk.print();
        }
    }
}
