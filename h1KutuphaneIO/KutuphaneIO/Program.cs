using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KutuphaneIO
{
    class Program
    {
        static void Main(string[] args)
        {
            Kitap k1 = new Kitap("987654321", "Data Structures and Algorithm Analysis in Java", "Mark Allen Weiss", "Bilgisayar");
            Kitap k2 = new Kitap("987654312", "C && Java ile Veri Yapılarına Giriş", "Olcay Taner Yıldız", "Bilgisayar");
            k2.ISBN = "987456258";
            //Console.WriteLine(k1+"\n"+k2);
            Uye u1 = new Uye(123, "Şevket Çakır", "Denizli");
            Uye u2 = new Uye(124, "Abdülkadir Yaldır", "Denizli");
            //Console.WriteLine(u1);
            //Console.WriteLine(u2);
            Odunc o1 = new Odunc(u1, k2);
            Odunc o2 = new Odunc(u2, k1);
            //Console.WriteLine(o1);
            //Console.WriteLine(o2);
            Kutuphane kutuphane = new Kutuphane();
            kutuphane.uyeEkle(u1);
            kutuphane.uyeEkle(u2);
            kutuphane.uyeleriGoster();
            //Console.WriteLine(kutuphane.uyeBul("Şevket Çakır"));
            kutuphane.kitapEkle(k1);
            kutuphane.kitapEkle(k2);
            kutuphane.oduncAl(u1, k2);
            kutuphane.oduncAl("Şevket Çakır", "Data Structures and Algorithm Analysis in Java");
            kutuphane.oduncListele();
        }
    }
}
