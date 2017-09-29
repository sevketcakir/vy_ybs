using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myqueue
{
    class MyQueue
    {
        int [] dizi;
        int front=-1;//kuyruğun önü
        int rear=-1;//kuyruğun arkası
        public MyQueue()
        {
            dizi = new int[20];
        }
        public MyQueue(int boyut)
        {
            dizi = new int[boyut];
        }
        public bool isEmpty()
        {
            return front == -1 && rear == -1;
        }
        public bool isFull()
        {
            return rear == dizi.Length - 1;
        }
        public void enqueue(int eleman)
        {
            if (isEmpty())//Eğer kuyruk boşsa
            {
                front = 0;
                rear = 0;
                dizi[rear] = eleman;
            }
            else {
                if (isFull())//Kuyruk doluyas
                    throw new Exception("Kuyruk dolu!!!");
                dizi[++rear] = eleman;//rear değerini artır ve elemanı ilgili yere yaz
            }
        }
        public int dequeue()//Kuyruktan eleman siler
        {
            if (isEmpty())
                throw new Exception("Kuyruk boş!!!");
            int donen = dizi[front++];
            if (front > rear)
            {
                front = -1;
                rear = -1;
            }
            return donen;
        }

        public void print()
        {
            if (isEmpty())
                return;
            for (int i = front; i <= rear; i++)
            {
                Console.WriteLine(dizi[i]);
            }
        }

        public int Count
        {
            get {
                if (isEmpty())
                    return 0;
                return rear - front + 1;
            }
        }
    }
}
