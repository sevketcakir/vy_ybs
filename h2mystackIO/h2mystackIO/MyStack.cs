using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace h2mystackIO
{
    class MyStack
    {
        int[] dizi;//Elemanları saklayacak dizi
        int top = -1;//en üst elemanın konumu
        public MyStack()//Varsayılan kurucu metod
        {
            dizi = new int[20];
        }
        public MyStack(int boyut)//Parametre alan kurucu metod
        {
            dizi = new int[boyut];
        }
        public bool isEmpty()//Yığıtın boş olup olmadığını döndürür
        {
            return top == -1;
        }
        public bool isFull()//Yığıtın dolu olup olmadığını döndürür
        {
            return top == dizi.Length - 1;
        }
        public void push(int eleman)
        {
            if (isFull())
                throw new Exception("Yığıt dolu / Stack overflow!!!");
            dizi[++top] = eleman;
        }
        public int pop()
        {
            if (isEmpty())
                throw new Exception("Yığıt boş / Stack underflow !!!");
            return dizi[top--];
        }
        public void print()
        {
            for (int i = top; i >= 0 ; i--)
            {
                Console.WriteLine(dizi[i]);
            }
        }
        public int peek()
        {
            if (isEmpty())
                throw new Exception("Yığıt boş / Stack underflow !!!");
            return dizi[top];
        }
        public int Count
        {
            get {
                return top + 1;//top değeri en üstteki elemanın konumunu tutar. 3 eleman varsa top=2 olacaktır. top değerinin 1 fazlası eleman sayısını verir.
            }
        }
    }
}
