using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KutuphaneIO
{
    class Odunc
    {
        Uye uye;
        Kitap kitap;
        DateTime zaman;
        public Odunc() { zaman = DateTime.Now; }
        public Odunc(Uye uye, Kitap kitap)
        {
            this.uye = uye;
            this.kitap = kitap;
            zaman = DateTime.Now;
        }
        public override string ToString()
        {
            return String.Format("Üye: {0}, Kitap: {1}, Zaman:{2}", uye.Ad, kitap.Ad, zaman);
        }
    }
}
