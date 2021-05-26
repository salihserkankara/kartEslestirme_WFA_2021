using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kart_eslestirme.Modeller
{
    public class Surec
    {
        List<Kartlar> kartlar;
        List<IslemKart> IslemKartlar;
        public Surec()
        {

            kartlar = new List<Kartlar>()
            {
                new Kartlar{ ResimAdi="s1\\1.png",Tema="Hayvanlar"},
                new Kartlar{ ResimAdi="s1\\2.png",Tema="Hayvanlar"},
                new Kartlar{ ResimAdi="s1\\3.png",Tema="Hayvanlar"},
                new Kartlar{ ResimAdi="s1\\4.png",Tema="Hayvanlar"},
                new Kartlar{ ResimAdi="s2\\11.png",Tema="Cadılar Bayramı"},
                new Kartlar{ ResimAdi="s2\\22.png",Tema="Cadılar Bayramı"},
                new Kartlar{ ResimAdi="s2\\33.png",Tema="Cadılar Bayramı"},
                new Kartlar{ ResimAdi="s2\\44.png",Tema="Cadılar Bayramı"},
                new Kartlar{ ResimAdi="s2\\55.png",Tema="Cadılar Bayramı"},
                new Kartlar{ ResimAdi="s2\\66.png",Tema="Cadılar Bayramı"},
                new Kartlar{ ResimAdi="s3\\111.png",Tema="Logolar"},
                new Kartlar{ ResimAdi="s3\\222.png",Tema="Logolar"},
                new Kartlar{ ResimAdi="s3\\333.png",Tema="Logolar"},
                new Kartlar{ ResimAdi="s3\\444.png",Tema="Logolar"},
                new Kartlar{ ResimAdi="s3\\555.png",Tema="Logolar"},
                new Kartlar{ ResimAdi="s3\\666.png",Tema="Logolar"},
                new Kartlar{ ResimAdi="s3\\777.png",Tema="Logolar"},
                new Kartlar{ ResimAdi="s3\\888.png",Tema="Logolar"},
            };

            IslemKartlar = KartIslemleri();

        }

        public List<Kartlar> Kartlar()
        {
            return kartlar;
        } 

        public List<IslemKart> IslemKart2()
        {
            return IslemKartlar;
        }

        public void Tamamlandi(int index1, int index2)
        {
            IslemKartlar[index1].Tamamlandi = true;
            IslemKartlar[index2].Tamamlandi = true;
            IslemKartlar[index1].Gosterim = false;
            IslemKartlar[index2].Gosterim = false;
        }

        public void Tamamlanamadi(int index1,int index2)
        {
            IslemKartlar[index1].Gosterim = false;
            IslemKartlar[index2].Gosterim = false;
        }

        public void HepsiniFalseYap()
        {
            for (int i = 0; i < IslemKartlar.Count; i++)
            {
                IslemKartlar[i].Gosterim = false;
            }
        }

        public List<IslemKart> KartIslemleri()
        {
            List<Kartlar> Seviye1Kartlar = kartlar.Where(x => x.Tema.Equals("Hayvanlar")).ToList();
            List<Kartlar> Seviye2Kartlar = kartlar.Where(x => x.Tema.Equals("Cadılar Bayramı")).ToList();
            List<Kartlar> Seviye3Kartlar = kartlar.Where(x => x.Tema.Equals("Logolar")).ToList();
            Seviye1Kartlar.AddRange(Seviye1Kartlar);
            Seviye2Kartlar.AddRange(Seviye2Kartlar);
            Seviye3Kartlar.AddRange(Seviye3Kartlar);
            Seviye1Kartlar = Seviye1Kartlar.OrderBy(x => Guid.NewGuid()).ToList();
            Seviye2Kartlar = Seviye2Kartlar.OrderBy(x => Guid.NewGuid()).ToList();
            Seviye3Kartlar = Seviye3Kartlar.OrderBy(x => Guid.NewGuid()).ToList();

            List<IslemKart> IslemKartlar = new List<IslemKart>();
            for (int i = 0; i < Seviye1Kartlar.Count; i++)
            {
                IslemKartlar.Add(new IslemKart { Gosterim = false, KartKonum = i, ResimAdi = Seviye1Kartlar[i].ResimAdi, Seviye = 1, Tamamlandi = false });
            }
            for (int i = 0; i < Seviye2Kartlar.Count; i++)
            {
                IslemKartlar.Add(new IslemKart { Gosterim = false, KartKonum = i, ResimAdi = Seviye2Kartlar[i].ResimAdi, Seviye = 2, Tamamlandi = false });
            }
            for (int i = 0; i < Seviye3Kartlar.Count; i++)
            {
                IslemKartlar.Add(new IslemKart { Gosterim = false, KartKonum = i, ResimAdi = Seviye3Kartlar[i].ResimAdi, Seviye = 3, Tamamlandi = false });
            }
            return IslemKartlar;
        }
        public List<IslemKart> Seviye1Kartlar() => IslemKartlar.Where(x => x.Seviye == 1).ToList();
        public List<IslemKart> Seviye2Kartlar() => IslemKartlar.Where(x => x.Seviye == 2).ToList();
        public List<IslemKart> Seviye3Kartlar() => IslemKartlar.Where(x => x.Seviye == 3).ToList();

        public void GosterimGuncelle(int index)
        {
            IslemKartlar[index].Gosterim=true;
        }
    }
}
