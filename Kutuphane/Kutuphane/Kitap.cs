using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kutuphane
{
    class Kitap
    {
        string isbn;
        public string ISBN {
            get { return isbn; }
            set { isbn = value; }
        }

        string ad;
        public string Ad
        {
            get { return ad; }
            set { ad = value; }
        }

        string yazar;
        public string Yazar
        {
            get { return yazar; }
            set { yazar = value; }
        }

        string alan;
        public string Alan
        {
            get { return alan; }
            set { alan = value; }
        }
        public Kitap() { }
        public Kitap(string isbn, string ad, string yazar, string alan)
        {
            this.isbn = isbn;
            this.ad = ad;
            this.yazar = yazar;
            this.alan = alan;
        }
        public override string ToString()
        {
            return String.Format("ISBN:{0}, Ad: {1}, Yazar: {2}, Alan: {3}",isbn, ad, yazar, alan);
        }
    }
}
