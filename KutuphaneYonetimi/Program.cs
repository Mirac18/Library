using System;
using System.Collections.Generic;

namespace KutuphaneYonetimi
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<string> kitaplar = new List<string>
            {
                "Küçük Prens",
                "Sefiller",
                "Suç ve Ceza",
                "Köroğlu",
                "Kafes",
                "İstanbul Hatırası",
                "Hayvan Çiftliği",
                "Yabancı",
                "Don Kişot"
            };


            List<int> KitapStok = new List<int>
            {
                5, // Küçük Prens
                3, // Sefiller
                4, // Suç ve Ceza
                2, // Köroğlu
                1, // Kafes
                4, // İstanbul Hatırası
                2, // Hayvan Çiftliği
                3, // Yabancı
                0  // Don Kişot
            };

            List<int> Bakiye = new List<int>
            {
                100,
                45,
                60,
                54,
                12
            };

            List<Admin> admins = new List<Admin>();
            Admin admin1 = new Admin();
            admin1.AdminAdi = "Admin1";
            admins.Add(admin1);

            Admin admin2 = new Admin();
            admin2.AdminAdi = "Admin2";
            admins.Add(admin2);



            List<Uye> uyeler = new List<Uye>();

            Uye uye1 = new Uye();
            uye1.Ad = "Miraç";
            uye1.Bakiye = 100;
            uye1.AldigiKitaplar.Add("Osmanlı Tarihi");

            Uye uye2 = new Uye();
            uye2.Ad = "Recep";
            uye2.Bakiye = 45;
            uye2.AldigiKitaplar.Add("Sherlock Holmes");
            uye2.AldigiKitaplar.Add("İçimizdeki Şeytan");

            Uye uye3 = new Uye();
            uye3.Ad = "Ayşe";
            uye3.Bakiye = 60;
            uye3.AldigiKitaplar.Add("C# Programlama");
            uye3.AldigiKitaplar.Add("Veri Yapıları");

            Uye uye4 = new Uye();
            uye4.Ad = "Fatma";
            uye4.Bakiye = 54;
            uye4.AldigiKitaplar.Add("Anna Karenina");

            Uye uye5 = new Uye();
            uye5.Ad = "Ali";
            uye5.Bakiye = 12;
            uye5.AldigiKitaplar.Add("Yüzüklerin Efendisi");
            uye5.AldigiKitaplar.Add("Harry Potter");

            Uye uye6 = new Uye();
            uye6.Ad = "Mehmet";
            uye6.Bakiye = 80;
            uye6.AldigiKitaplar.Add("Savaş ve Barış");

            uyeler.Add(uye1);
            uyeler.Add(uye2);
            uyeler.Add(uye3);
            uyeler.Add(uye4);
            uyeler.Add(uye5);
            uyeler.Add(uye6);

            Console.WriteLine("Lütfen giriş yapmak istediğiniz türü seçiniz:");
            Console.WriteLine("1. Admin");
            Console.WriteLine("2. Kullanıcı");
            string girisTuru = Console.ReadLine();

            if (girisTuru != "1" && girisTuru != "2")
            {
                Console.WriteLine("Geçersiz giriş türü. Program sonlandırılıyor.");
                return;
            }

            if (girisTuru == "1")
            {
                Console.Write("Lütfen admin adınızı giriniz: ");
                string adminAdi = Console.ReadLine();
                bool adminBulundu = false;
                foreach (Admin a in admins)
                {
                    if (a.AdminAdi.ToLower() == adminAdi.ToLower())
                    {
                        adminBulundu = true;
                        break;
                    }
                }
                if (!adminBulundu)
                {
                    Console.WriteLine("Admin bulunamadı. Program sonlandırılıyor.");
                    return;
                }
            }

            string girisYapanUyeAdi = "";
            int girisYapanUyeIndex = -1;

            Uye girisYapanUye = null;
            if (girisTuru == "2")
            {
                Console.Write("Lütfen adınızı giriniz: ");
                string uyeAdi = Console.ReadLine();
                foreach (Uye a in uyeler)
                {
                    if (a.Ad.ToLower() == uyeAdi.ToLower())
                    {
                        girisYapanUye = a;
                        break;
                    }
                }
                if (girisYapanUye == null)
                {
                    Console.WriteLine("Üye bulunamadı. Program sonlandırılıyor.");
                    return;
                }
            }
            while (true)
            {


                if (girisTuru == "1")
                {
                    Console.WriteLine("Kütüphane Yönetim Sistemine Hoş Geldiniz!");
                }
                else if (girisTuru == "2")
                {
                    Console.WriteLine("Kütüphane Kullanıcı Sistemine Hoş Geldiniz!");
                }
                Console.WriteLine("");
                Console.WriteLine("1. Kitapları Listele");
                Console.WriteLine("2. Kitap Ödünç Al");
                Console.WriteLine("3. Kullanıcı Kitapları");
                Console.WriteLine("4. Bakiye Sorgulama");
                Console.WriteLine("5. Bakiye Ekleme");
                Console.WriteLine("6. Kitap iade");
                if (girisTuru == "1")
                {
                    Console.WriteLine("7. Kitap Sil");
                }
                if (girisTuru == "1")
                {
                    Console.WriteLine("8. Kitap Ekle");
                }
                if (girisTuru == "1")
                {
                    Console.WriteLine("9. Kitap Stok Ekle");
                }
                if (girisTuru == "1")
                {
                    Console.WriteLine("10.Kitap Stok Sil");
                }
                if (girisTuru == "1")
                {
                    Console.WriteLine("11.Stok İhtiyaçları");
                }
                if (girisTuru == "1")
                {
                    Console.WriteLine("12. Kullanıcı gözünden gör");
                }

                Console.WriteLine("'X' Çıkış");
                
                if (girisTuru == "2")
                {
                    Console.WriteLine("Lütfen bir seçim yapınız (1-6 veya X)");
                }
                if (girisTuru == "1")
                {
                    Console.WriteLine("Lütfen bir seçim yapınız (1-12 veya X)");
                }


                string secim = Console.ReadLine();
                string kitapAdi = null;

                switch (secim)
                {
                    case "1":
                        Console.Clear();
                        Console.WriteLine("Kütüphanemizdeki kitaplar:");
                        for (int i = 0; i < kitaplar.Count; i++)
                        {
                            Console.WriteLine((i + 1) + ". Kitap: " + kitaplar[i] + "         Stok: " + KitapStok[i]);
                        }
                        Console.WriteLine("Q Geri Dön");
                        Console.ReadLine();
                        break;


                    case "2": 
                        Console.Clear();
                        Console.WriteLine("Ödünç almak istediğiniz kitabın ismini giriniz.(Günlük ücret 5TL'dir.1 gün direkt ödenir!)");
                        for (int i = 0; i < kitaplar.Count; i++)
                        {
                            Console.WriteLine((i + 1) + ". Kitap: " + kitaplar[i] + "         Stok: " + KitapStok[i]);
                        }
                        kitapAdi = Console.ReadLine();
                        int kitapIndex = kitaplar.IndexOf(kitapAdi);
                        Console.WriteLine("Seçilen kitap: " + kitapAdi);
                        if (kitapIndex != -1 && KitapStok[kitapIndex] > 0)
                        {
                            if (girisTuru == "2")
                            {
                                if (girisYapanUye.Bakiye >= 5)
                                {
                                    girisYapanUye.AldigiKitaplar.Add(kitapAdi);
                                    KitapStok[kitapIndex]--;
                                    girisYapanUye.Bakiye -= 5;
                                    Console.WriteLine($"{kitapAdi} kitabı ödünç alındı. Yeni bakiye: {girisYapanUye.Bakiye}");
                                }
                                else
                                {
                                    Console.WriteLine("Bakiyeniz yetersiz.");
                                }
                            }
                            else
                            {
                                Console.WriteLine("Adminler sadece kitapları listeleyebilir.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Kitap bulunamadı veya stokta yok.");
                        }



                        break;


                    case "3":
                        Console.Clear();
                        Console.WriteLine("Kullanıcılarda olan kitaplar:");
                        foreach (Uye a in uyeler)
                        {
                            if (a.AldigiKitaplar.Count > 0)
                            {
                                Console.WriteLine(a.Ad + " adlı üyenin aldığı kitaplar:");
                                foreach (string k in a.AldigiKitaplar)
                                {
                                    Console.WriteLine("- " + k);
                                }
                            }
                        }
                        Console.WriteLine("Devam etmek için Enter'a basın.");
                        Console.ReadLine();
                        break;


                    case "4":
                        Console.Clear();
                        if (girisTuru == "2")
                        {
                            Console.WriteLine("Güncel bakiyeniz: " + girisYapanUye.Bakiye);
                            Console.WriteLine("'X' ile çıkış yapabilirsiniz.");
                        }
                        else
                        {
                            foreach (Uye u in uyeler)
                            {
                                Console.WriteLine("Üye: " + u.Ad + " - Bakiye: " + u.Bakiye);
                            }
                        }
                        Console.ReadLine();
                        break;


                    case "5":
                        Console.Clear();

                        if (girisTuru == "1")
                        {
                            Console.WriteLine("Bakiye eklemek istediğiniz üyenin adını giriniz.");
                            foreach (Uye u in uyeler)
                            {
                                Console.WriteLine(u.Ad + " - Bakiye: " + u.Bakiye);
                            }
                            Console.WriteLine("'X' ile çıkış yapabilirsiniz");

                            string uyeAdi = Console.ReadLine();
                            Uye secilenUye = uyeler.Find(u => u.Ad.ToLower() == uyeAdi.ToLower());
                            if (secilenUye != null)
                            {
                                Console.Write("Eklemek istediğiniz bakiye miktarını giriniz: ");
                                if (int.TryParse(Console.ReadLine(), out int bakiyeMiktari) && bakiyeMiktari > 0)
                                {
                                    secilenUye.Bakiye += bakiyeMiktari;
                                    Console.WriteLine($"{secilenUye.Ad} adlı üyenin bakiyesi {bakiyeMiktari} TL arttırıldı. Yeni bakiye: {secilenUye.Bakiye}");
                                }
                                else
                                {
                                    Console.WriteLine("Geçersiz bakiye miktarı.");
                                }
                            }
                            else
                            {
                                Console.WriteLine("Üye bulunamadı.");
                            }
                        }
                        else if (girisTuru == "2")
                        {
                            Console.WriteLine("Güncel bakiyeniz: " + girisYapanUye.Bakiye);
                            Console.Write("Bakiyenizi arttırmak için bir miktar giriniz: ");
                            if (int.TryParse(Console.ReadLine(), out int bakiyeMiktari) && bakiyeMiktari > 0)
                            {
                                girisYapanUye.Bakiye += bakiyeMiktari;
                                Console.WriteLine($"Bakiyeniz {bakiyeMiktari} TL arttırıldı. Yeni bakiye: {girisYapanUye.Bakiye}");
                            }
                            else
                            {
                                Console.WriteLine("Geçersiz bakiye miktarı.");
                            }
                        }

                        break;
                    case "6":
                        Console.Clear();
                        Console.WriteLine("İade etmek istediğiniz kitabın ismini giriniz.");
                        for (int i = 0; i < girisYapanUye.AldigiKitaplar.Count; i++)
                        {
                            Console.WriteLine((i + 1) + ". Kitap: " + girisYapanUye.AldigiKitaplar[i]);
                        }
                        Console.WriteLine("'X' ile çıkış yapabilirsiniz.");
                        kitapAdi = Console.ReadLine();
                        if (girisYapanUye.AldigiKitaplar.Contains(kitapAdi))
                        {
                            Console.Write("Kaç gün süreyle aldınız? ");
                            if (int.TryParse(Console.ReadLine(), out int gunSayisi) && gunSayisi > 0)
                            {
                                int ucret = gunSayisi * 5;
                                if (girisYapanUye.Bakiye >= ucret)
                                {
                                    girisYapanUye.Bakiye -= ucret;
                                    kitaplar.Add(kitapAdi);
                                    girisYapanUye.AldigiKitaplar.Remove(kitapAdi);
                                    Console.WriteLine($"{kitapAdi} kitabı iade edildi. Ücret: {ucret} TL. Yeni bakiye: {girisYapanUye.Bakiye}");
                                }
                                else
                                {
                                    Console.WriteLine("Bakiyeniz yetersiz.");
                                }
                            }
                            else
                            {
                                Console.WriteLine("Geçersiz gün sayısı.");
                            }
                        }
                        else if (kitapAdi.ToUpper() == "X")
                        {
                            Console.WriteLine("İşlem iptal edildi.");
                        }
                        else
                        {
                            Console.WriteLine("Bu kitabı ödünç almadınız.");
                        }

                        break;


                    case "7":
                        Console.Clear();
                        Console.WriteLine("Silmek istediğiniz kitabın ismini giriniz. ");
                        for (int i = 0; i < kitaplar.Count; i++)
                        {
                            Console.WriteLine((i + 1) + ". Kitap: " + kitaplar[i]);
                        }
                        kitapAdi = Console.ReadLine();
                        if (kitaplar.Contains(kitapAdi))
                        {
                            kitaplar.Remove(kitapAdi);
                            Console.WriteLine("Kitap başarıyla silindi.");
                        }
                        else
                        {
                            Console.WriteLine("Kitap bulunamadı.");
                        }
                        Console.ReadLine();
                        break;


                    case "8":
                        Console.Clear();

                        for (int i = 0; i < kitaplar.Count; i++)
                        {
                            Console.WriteLine((i + 1) + ". Kitap: " + kitaplar[i]);
                        }
                        Console.WriteLine("Eklemek istediğiniz kitabın ismini giriniz.");
                        kitapAdi = Console.ReadLine();
                        if (!kitaplar.Contains(kitapAdi))
                        {
                            kitaplar.Add(kitapAdi);
                            KitapStok.Add(0);
                            Console.WriteLine($"{kitapAdi} kitabı başarıyla eklendi.");
                        }
                        else
                        {
                            Console.WriteLine("Bu kitap zaten mevcut.");
                        }

                        break;


                    case "9":
                        Console.Clear();
                        Console.WriteLine("Stok eklemek istediğiniz kitabın ismini giriniz.");
                        for (int i = 0; i < kitaplar.Count; i++)
                        {
                            Console.WriteLine((i + 1) + ". Kitap: " + kitaplar[i]);
                        }
                        kitapAdi = Console.ReadLine();

                        if (kitaplar.Contains(kitapAdi))
                        {
                            Console.Write("Eklemek istediğiniz stok miktarını giriniz: ");
                            if (int.TryParse(Console.ReadLine(), out int stokMiktari) && stokMiktari > 0)
                            {
                                int index = kitaplar.IndexOf(kitapAdi);
                                KitapStok[index] += stokMiktari;
                                Console.WriteLine($"{kitapAdi} için {stokMiktari} adet stok eklendi. Yeni stok: {KitapStok[index]}");
                            }
                            else
                            {
                                Console.WriteLine("Geçersiz stok miktarı.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Kitap bulunamadı.");
                        }
                        break;


                    case "10":
                        Console.Clear();
                        Console.WriteLine("Stok silmek istediğiniz kitabın ismini giriniz.");
                        for (int i = 0; i < kitaplar.Count; i++)
                        {
                            Console.WriteLine((i + 1) + ". Kitap: " + kitaplar[i] + " Stok: " + KitapStok[i]);
                        }
                        kitapAdi = Console.ReadLine();
                        if (kitaplar.Contains(kitapAdi))
                        {
                            Console.Write("Silmek istediğiniz stok miktarını giriniz: ");
                            if (int.TryParse(Console.ReadLine(), out int stokMiktari) && stokMiktari > 0)
                            {
                                int index = kitaplar.IndexOf(kitapAdi);
                                if (KitapStok[index] >= stokMiktari)
                                {
                                    KitapStok[index] -= stokMiktari;
                                    Console.WriteLine($"{kitapAdi} için {stokMiktari} adet stok silindi. Yeni stok: {KitapStok[index]}");
                                }
                                else
                                {
                                    Console.WriteLine("Yeterli stok yok.");
                                }
                            }
                            else
                            {
                                Console.WriteLine("Geçersiz stok miktarı.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Kitap bulunamadı.");
                        }


                        break;
                    case "11":
                        Console.Clear();
                        Console.WriteLine("Stok ihtiyaçları:");
                        for (int i = 0; i < kitaplar.Count; i++)
                        {
                            if (KitapStok[i] < 3)
                            {
                                Console.WriteLine($"{kitaplar[i]} - Stok: {KitapStok[i]}");
                            }
                        }
                        Console.WriteLine("Stok girmek için 1' basın");


                        Console.WriteLine("Devam etmek için Enter'a basın.");
                        string Secim = Console.ReadLine();
                        if (Secim == "1")

                        {
                            Console.WriteLine("Stok eklemek istediğiniz kitabın ismini giriniz.");
                            kitapAdi = Console.ReadLine();
                            Console.WriteLine("Eklemek istediğiniz stok miktarını giriniz: ");
                            if (kitaplar.Contains(kitapAdi))
                            {
                                if (int.TryParse(Console.ReadLine(), out int stokMiktari) && stokMiktari > 0)
                                {
                                    int index = kitaplar.IndexOf(kitapAdi);
                                    KitapStok[index] += stokMiktari;
                                    Console.WriteLine($"{kitapAdi} için {stokMiktari} adet stok eklendi. Yeni stok: {KitapStok[index]}");
                                }
                                else
                                {
                                    Console.WriteLine("Geçersiz stok miktarı.");
                                }
                            }
                            else
                            {
                                Console.WriteLine("Kitap bulunamadı.");
                            }
                        }


                        break;


                    case "12":
                        Console.Clear();
                        Console.WriteLine("Giriş türünü değiştirmek için '1' veya '2' tuşlayın:");
                        Console.WriteLine("1. Admin Girişi");
                        Console.WriteLine("2. Kullanıcı Girişi");
                        string yeniGirisTuru = Console.ReadLine();
                        if (yeniGirisTuru == "1" || yeniGirisTuru == "2")
                        {
                            girisTuru = yeniGirisTuru;
                            Console.WriteLine($"Yeni giriş türü: {(girisTuru == "1" ? "Admin" : "Kullanıcı")}");
                        }
                        else
                        {
                            Console.WriteLine("Geçersiz giriş türü.");
                        }
                        break;


                    case "X":
                        Console.WriteLine("Çıkış yapılıyor...");
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Geçersiz seçim.");
                        break;
                }
            }
        }
    }
}