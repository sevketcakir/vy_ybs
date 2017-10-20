using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackKullanimiIO
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> s = new Stack<int>();//Stack oluştur
            s.Push(17);//Stack'e değer it
            s.Push(6);//Stack'e değer it
            int sonuc = s.Pop() / s.Pop();//2 değer çek ve işlem yap
            Console.WriteLine(sonuc);//sonucu ekrana yazdır
            var a = "3 2 + 5 16 - /".Split(' ');//Boşluk karakterine göre metni parçala
        }
    }
}
