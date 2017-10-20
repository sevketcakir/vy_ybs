using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackKullanimi
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> s = new Stack<int>();//Stack oluştur
            s.Push(15);//Stack'e ekle
            s.Push(7);//Stack'e ekle
            int sonuc = s.Pop() / s.Pop();//Stack'ten 2 değer çek ve işlem yap
            Console.WriteLine(sonuc);//Sonucu yazdır
            "1 2 + 5 4 - /".Split(' ');//Metni boşluğa göre parçalar

        }
    }
}
