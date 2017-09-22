using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KutuphaneIO
{
    class Uye
    {
        int uyeNo;

        public int UyeNo
        {
            get { return uyeNo; }
            set { uyeNo = value; }
        }
        string ad;

        public string Ad
        {
            get { return ad; }
            set { ad = value; }
        }
        string adres;

        public string Adres
        {
            get { return adres; }
            set { adres = value; }
        }
        public Uye() { }
        public Uye(int uyeNo, string ad, string adres)
        {
            this.uyeNo = uyeNo;
            this.ad = ad;
            this.adres = adres;
        }
        public override string ToString()
        {
            return String.Format("Üye no:{0}, Ad: {1}, Adres: {2}", uyeNo, ad, adres);
        }
    }
}
