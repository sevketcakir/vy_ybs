using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Siralama
{
    class Program
    {
        public static void print(int[] d)
        {
            for (int i = 0; i < d.Length; i++)
                Console.Write(d[i]+" ");
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            int[] dizi = new int[] { 3, 7, 1, 4, 2, 8, 10, 5 };
            secmeliSirala(dizi);
            print(dizi);
            dizi = new int[] { 3, 7, 1, 4, 2, 8, 10, 5 };
            kabarcikSiralama(dizi);
            print(dizi);
            dizi = new int[] { 3, 7, 1, 4, 2, 8, 10, 5 };
            arayaEklemeSiralama(dizi);
            print(dizi);
        }

        public static void arayaEklemeSiralama(int[] d)
        {
            for (int i = 1; i < d.Length; i++)
            {
                int deger = d[i];
                int j = i - 1;
                while (j >= 0 && d[j] > deger)
                {
                    d[j+1]=d[j];
                    j=j-1;
                }
                d[j+1] = deger;
            }
        }

        public static void kabarcikSiralama(int[] d)
        {
            for (int i = 0; i < d.Length-1; i++)
            {
                bool degisiklik = false;//İyileştirme için kullanılıyor. Yer değiştirme(swap) olmadıysa dizi zaten sıralıdır. Tekrar tekrar bakmaya gerek yok. İşlem sonlandırılabilir.
                for (int j = 0; j < d.Length-i-1; j++)
                {
                    if (d[j] > d[j + 1])//Komşusu ile karşılaştır
                    {
                        int gecici = d[j];
                        d[j] = d[j + 1];
                        d[j + 1] = gecici;
                        degisiklik = true;
                    }
                }
                if (!degisiklik)//Yer değiştirme yoksa dış döngüden çık
                    break;
            }
        }

        public static void secmeliSirala(int[] d)
        {
            for (int i = 0; i < d.Length-1; i++)
            {
                int min = i;//En küçük eleman olarak i indisindeki elemanı belirle
                for (int j = i+1; j < d.Length; j++)
                {
                    if (d[j] < d[min])//Seçilen min değerinden daha küçük bir değer varsa
                        min = j;//Yeni en küçük değeri belirle
                }
                //Yer değiştirme işlemi(swap)
                int gecici=d[min];
                d[min] = d[i];
                d[i] = gecici;
            }
        }
    }
}
