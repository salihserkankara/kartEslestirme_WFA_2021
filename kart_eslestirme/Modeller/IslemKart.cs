using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kart_eslestirme.Modeller
{
    public class IslemKart
    {
        public int Seviye { get; set; }
        public string ResimAdi { get; set; }
        public int KartKonum { get; set; }
        public bool Gosterim { get; set; }
        public bool Tamamlandi { get; set; }
    }
}
