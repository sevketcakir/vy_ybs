using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KutuphaneIO
{
    class Kutuphane
    {
        ArrayList uyeler;
        ArrayList kitaplar;
        ArrayList oduncler;
        public Kutuphane()
        {
            uyeler = new ArrayList();
            kitaplar = new ArrayList();
            oduncler = new ArrayList();
        }
        public void uyeEkle(Uye u)
        {
            uyeler.Add(u);
        }
        public void uyeleriGoster()
        {
            for (int i = 0; i < uyeler.Count; i++)
            {
                Console.WriteLine(uyeler[i]);
            }
        }
        public Uye uyeBul(string uyeAdi)
        {
            foreach (Uye u in uyeler)
            {
                if (u.Ad.Equals(uyeAdi))
                    return u;
            }
            return null;
        }
        public void kitapEkle(Kitap k)
        {
            kitaplar.Add(k);
        }
        public Kitap kitapBul(string kitapAdi)
        {
            foreach (Kitap k in kitaplar)
            {
                if (k.Ad.Equals(kitapAdi))
                    return k;
            }
            return null;
        }
        public void oduncListele()
        {
            foreach (Odunc o in oduncler)
            {
                Console.WriteLine(o);
            }
        }
        public void oduncAl(Uye uye, Kitap kitap)
        {
            oduncler.Add(new Odunc(uye, kitap));
        }
        public void oduncAl(string uyeAdi, string kitapAdi)
        {
            Uye u = uyeBul(uyeAdi);
            Kitap k = kitapBul(kitapAdi);
            if (u == null || k == null)
                throw new Exception("Üye veya kitap bulunamadı!!!");
            oduncAl(u, k);
        }
    }
}
