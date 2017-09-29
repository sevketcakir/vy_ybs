using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace h1mystack
{
    class MyStack
    {
        int[] dizi;//Elemanların saklanacağı dizi
        int top = -1;//Dizinin en üstünü gösteren değişken(indis)
        public MyStack()//Varsayılan kurucu metod
        {
            dizi = new int[20];
        }
        public MyStack(int boyut)//Parametre alan kurucu metod
        {
            dizi = new int[boyut];
        }
        public bool isEmpty()//Yığıtın boş olup olmadığını gösterir
        {
            return top == -1;
        }
        public bool isFull()//Yığıtın dolu olup olmadığını gösterir
        {
            return top == dizi.Length - 1;
        }
        public void push(int eleman)//Yığıta eleman eklemek için kullanılır
        {
            if (isFull())
                throw new Exception("Yığıt dolu!!!");
            dizi[++top] = eleman;
        }
        public int pop()
        {
            if (isEmpty())
                throw new Exception("Yığıt boş!!");
            return dizi[top--];
        }
        public void print()
        {
            Console.WriteLine("Eleman sayısı:{0}", Count);
            for (int i = top; i >= 0; i--)
            {
                Console.WriteLine(dizi[i]);
            }
        }
        public int Count {
            get { return top + 1; }
        }
        public int peek()
        {
            return dizi[top];
        }
    }
}
