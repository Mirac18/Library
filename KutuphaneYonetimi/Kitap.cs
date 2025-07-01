using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace KutuphaneYonetimi
{
    public class Kitap
    {

        public Kitap() { }
        public Kitap(string name) { }

        public string KitapAdi1;
        public string KitapAdi2;
        public string KitapAdi3;
        public string KitapAdi4;
        public string KitapAdi5;
        public string KitapAdi6;
        public string KitapAdi7;
        public string KitapAdi8;
        public string KitapAdi9;

        public int KitapStok1 { get; set; }
        public int KitapStok2 { get; set; }
        public int KitapStok3 { get; set; }
        public int KitapStok4 { get; set; }
        public int KitapStok5 { get; set; }
        public int KitapStok6 { get; set; }
        public int KitapStok7 { get; set; }
        public int KitapStok8 { get; set; }
        public int KitapStok9 { get; set; }

        public void KitapStoklari()
        {
            KitapStok1 = 5;
            KitapStok2 = 3;
            KitapStok3 = 4;
            KitapStok4 = 2;
            KitapStok5 = 1;
            KitapStok6 = 4;
            KitapStok7 = 2;
            KitapStok8 = 3;
            KitapStok9 = 0;
        }
        public void KitapStoklariGoster()
        {
            Console.WriteLine("Kitap 1: " + KitapAdi1 + " - Stok: " + KitapStok1);
            Console.WriteLine("Kitap 2: " + KitapAdi2 + " - Stok: " + KitapStok2);
            Console.WriteLine("Kitap 3: " + KitapAdi3 + " - Stok: " + KitapStok3);
            Console.WriteLine("Kitap 4: " + KitapAdi4 + " - Stok: " + KitapStok4);
            Console.WriteLine("Kitap 5: " + KitapAdi5 + " - Stok: " + KitapStok5);
            Console.WriteLine("Kitap 6: " + KitapAdi6 + " - Stok: " + KitapStok6);
            Console.WriteLine("Kitap 7: " + KitapAdi7 + " - Stok: " + KitapStok7);
            Console.WriteLine("Kitap 8: " + KitapAdi8 + " - Stok: " + KitapStok8);
            Console.WriteLine("Kitap 9: " + KitapAdi9 + " - Stok: " + KitapStok9);
        }
        public void KitapStokEkle(string kitapAdi)
        {
            if (kitapAdi == KitapAdi1)
            {
                KitapStok1++;
                Console.WriteLine(KitapAdi1 + " stoğu eklendi. Yeni stok: " + KitapStok1);
            }
            else if (kitapAdi == KitapAdi2)
            {
                KitapStok2++;
                Console.WriteLine(KitapAdi2 + " stoğu eklendi. Yeni stok: " + KitapStok2);
            }
            else if (kitapAdi == KitapAdi3)
            {
                KitapStok3++;
                Console.WriteLine(KitapAdi3 + " stoğu eklendi. Yeni stok: " + KitapStok3);
            }
            else if (kitapAdi == KitapAdi4)
            {
                KitapStok4++;
                Console.WriteLine(KitapAdi4 + " stoğu eklendi. Yeni stok: " + KitapStok4);
            }
            else if (kitapAdi == KitapAdi5)
            {
                KitapStok5++;
                Console.WriteLine(KitapAdi5 + " stoğu eklendi. Yeni stok: " + KitapStok5);
            }
            else if (kitapAdi == KitapAdi6)
            {
                KitapStok6++;
                Console.WriteLine(KitapAdi6 + " stoğu eklendi. Yeni stok: " + KitapStok6);
            }
            else if (kitapAdi == KitapAdi7)
            {
                KitapStok7++;
                Console.WriteLine(KitapAdi7 + " stoğu eklend. Yeni stok: " + KitapStok7);
            }
            else if (kitapAdi == KitapAdi8)
            {
                KitapStok7++;
                Console.WriteLine(KitapAdi8 + " stoğu eklendi. Yeni stok: " + KitapStok8);
            }
            else if (kitapAdi == KitapAdi9)
            {
                KitapStok9++;
                Console.WriteLine(KitapAdi9 + " stoğu eklendi. Ynei stok: " + KitapStok9);
            }

        }

        public void KitapStokCikar(string kitapAdi)
        {
            if (kitapAdi == KitapAdi1 && KitapStok1 > 0)
            {
                KitapStok1--;
                Console.WriteLine(KitapAdi2 + "Stoğu azaldı. Kalan stok: " + KitapStok1);
            }
            else if (kitapAdi == KitapAdi1 && KitapStok2 > 0)
            {
                KitapStok1--;
                Console.WriteLine(KitapAdi2 + "Stoğu azaldı. Kalan stok: " + KitapStok1);
            }
            else if (kitapAdi == KitapAdi3 && KitapStok3 > 0)
            {
                KitapStok3--;
                Console.WriteLine(KitapAdi3 + "Stoğu azaldı. Kalan stok: " + KitapStok3);
            }
            else if (kitapAdi == KitapAdi4 && KitapStok4 > 0)
            {
                KitapStok4--;
                Console.WriteLine(KitapAdi4 + "Stoğu azaldı. Kalan stok: " + KitapStok4);
            }
            else if (kitapAdi == KitapAdi5 && KitapStok5 > 0)
            {
                KitapStok5--;
                Console.WriteLine(KitapAdi5 + "Stoğu azaldı. Kalan stok: " + KitapStok5);
            }
            else if (kitapAdi == KitapAdi6 && KitapStok6 > 0)
            {
                KitapStok6--;
                Console.WriteLine(KitapAdi6 + "Stoğu azaldı. Kalan stok: " + KitapStok6);
            }
            else if (kitapAdi == KitapAdi7 && KitapStok7 > 0)
            {
                KitapStok7--;
                Console.WriteLine(KitapAdi7 + "Stoğu azaldı. Kalan stok: " + KitapStok7);
            }
            else if (kitapAdi == KitapAdi8 && KitapStok8 > 0)
            {
                KitapStok8--;
                Console.WriteLine(KitapAdi8 + "Stoğu azaldı. Kalan stok: " + KitapStok8);
            }
            else if (kitapAdi == KitapAdi9 && KitapStok9 > 0)
            {
                KitapStok9--;
                Console.WriteLine(KitapAdi9 + "Stoğu azaldı. Kalan stok: " + KitapStok9);
            }
            else
            {
                Console.WriteLine("Bu kitap kütüphanemizde bulunmamaktadır veya stoğu kalmamıştır.");
            }

        }
    }
}

