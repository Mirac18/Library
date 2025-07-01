using System.Collections.Generic;

namespace KutuphaneYonetimi
{
    public class Uye
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public List<string> AldigiKitaplar { get; set; }
        public int Bakiye { get; set; } 

        public Uye()
        {
            AldigiKitaplar = new List<string>();
        }
    }
}