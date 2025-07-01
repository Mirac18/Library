using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KutuphaneYonetimi
{
    public class Bakiye
    {
        public Bakiye()  { }
        
        public int Bakiye1 { get; set; }
        public int Bakiye2 { get; set; }
        public int Bakiye3 { get; set; }
        public int Bakiye4 { get; set; }
        public int Bakiye5 { get; set; }
        public int Bakiye6 { get; set; }

        public void Bakiyeler()
        {
            Bakiye1 = 100;
            Bakiye2 = 45;
            Bakiye3 = 80;
            Bakiye4 = 60;
            Bakiye5 = 54;
            Bakiye6 = 12;
        }

        public int BakiyeSorgula(int uyeId)
        {
            switch (uyeId)
            {
                case 1:
                    return Bakiye1;
                case 2:
                    return Bakiye2;
                case 3:
                    return Bakiye3;
                case 4:
                    return Bakiye4;
                case 5:
                    return Bakiye5;
                case 6:
                    return Bakiye6;
                default:
                    throw new ArgumentException("Geçersiz üye ID");
            }
        }

    }
}
