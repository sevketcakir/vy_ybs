using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace h2mystackIO
{
    class Program
    {
        static void Main(string[] args)
        {
            MyStack s1 = new MyStack();
            MyStack s2 = new MyStack(2);
            s2.push(6);
            s2.push(6);
            s1.push(5);
            s1.push(2);
            s1.push(7);
            s1.pop();
            s1.push(6); 
            s1.push(9);
            s1.push(4);
            s1.pop();
            s1.pop();
            s1.push(12);
            s1.print();

        }
    }
}
