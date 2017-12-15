using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SiralamaIO
{
    class Program
    {
        public static void print(int[] d)
        {
            for (int i = 0; i < d.Length; i++)
            {
                Console.Write(d[i]+" ");
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            int[] dizi = new int[] { 1, 9, 11, 5, 4, 2, 6, 3 };
            secmeliSiralama(dizi);
            print(dizi);
            dizi = new int[] { 1, 9, 11, 5, 4, 2, 6, 3 };
            kabarcikSiralama(dizi);
            kabarcikSiralama(dizi);
            print(dizi);
            dizi = new int[] { 21, 9, 11, 5, 4, 2, 6, 3 };
            arayaEklemeSiralama(dizi);
            print(dizi);
        }

        public static void arayaEklemeSiralama(int[] d)
        {
            for (int i = 1; i < d.Length; i++)
            {
                int deger=d[i];
                int j=i-1;
                while (j >= 0 && d[j] > deger)
                {
                    d[j + 1] = d[j];
                    j = j - 1;
                }
                d[j + 1] = deger;
            }
        }

        public static void kabarcikSiralama(int[] d)
        {
            for (int i = 0; i < d.Length-1; i++)
            {
                bool degisiklik = false;
                for (int j = 0; j < d.Length-i-1; j++)
                {
                    if (d[j] > d[j + 1])
                    {
                        int gecici = d[j];
                        d[j] = d[j + 1];
                        d[j + 1] = gecici;
                        degisiklik = true;
                    }
                }
                if (degisiklik==false)
                {
                    Console.WriteLine("i={0}", i);
                    break;
                }
            }
        }
        
        public static void secmeliSiralama(int[] d)
        {
            for (int i = 0; i < d.Length-1; i++)
            {
                int min = i;
                for (int j = i+1; j < d.Length; j++)
                {
                    if (d[j] < d[min])
                        min = j;
                }
                int gecici = d[min];
                d[min] = d[i];
                d[i] = gecici;
            }
        }



    }
}
