using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kutuphane
{
    class Program
    {
        static void Main(string[] args)
        {
            Kitap k1 = new Kitap("987654321", "Data Structures and Algorithm Analysis in Java", "Mark Allen Weiss", "Bilgisayar");
            Kitap k2 = new Kitap("987654312", "Veri Yapıları ve Algoritmalar", "Rıfat Çölkesen", "Bilgisayar");
            //Console.WriteLine(k1.ToString());
            k2.ISBN = "123456";
            //Console.WriteLine(k2);
            Uye u1 = new Uye(123, "Şevket Çakır", "Denizli");
            Uye u2 = new Uye(124, "Mehtap Sanver", "Adana");
            //Console.WriteLine(u1);
            //Console.WriteLine(u2);
            Odunc o1 = new Odunc(u1, k2);
            Odunc o2 = new Odunc(u2, k1);
            //Console.WriteLine(o1);
            //Console.WriteLine(o2);
            Kutuphane kutuphane = new Kutuphane();
            kutuphane.uyeEkle(u1);
            kutuphane.uyeEkle(u2);
            kutuphane.uyeleriListele();
            Console.WriteLine(kutuphane.uyeBul("Şevket Çakır"));
            kutuphane.kitapEkle(k1);
            kutuphane.kitapEkle(k2);
            kutuphane.oduncAl(u2, k1);
            kutuphane.oduncAl("Şevket Çakır", "Veri Yapıları ve Algoritmalar");
            kutuphane.oduncListele();

        }
    }
}
