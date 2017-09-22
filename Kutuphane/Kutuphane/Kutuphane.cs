using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kutuphane
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
        public void uyeEkle(Uye uye)
        {
            uyeler.Add(uye);
        }
        public void uyeleriListele()
        {
            for (int i = 0; i < uyeler.Count; i++)
            {
                Console.WriteLine(uyeler[i]);
            }
        }
        public Uye uyeBul(string uyeAdi)
        {
            foreach (Uye uye in uyeler)
            {
                if (uye.Ad.Equals(uyeAdi))
                    return uye;
            }
            return null;
        }

        public void kitapEkle(Kitap kitap)
        {
            kitaplar.Add(kitap);
        }
        public Kitap kitapBul(string kitapAdi)
        {
            foreach (Kitap kitap in kitaplar)
            {
                if(kitap.Ad.Equals(kitapAdi))
                    return kitap;
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
                throw new Exception("Kitap veya üye bulunamadı!!!");
            oduncAl(u, k);
        }
    }
}
