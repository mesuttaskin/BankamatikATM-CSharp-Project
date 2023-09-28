using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankamatikATM
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double bakiye = 2500;
            string sifre = "ab18";
            int hak = 3;
            Console.WriteLine("Kartlı İşlem: 1");
            Console.WriteLine("Kartsız İşlem: 2");
            string tus = Console.ReadLine();

            if (tus == "1")
            {
                while (hak > 0)
                {
                    Console.Write("Şifrenizi giriniz: ");
                    string pass = Console.ReadLine();

                    if (pass == sifre)
                    {

                        Console.WriteLine("Başarılı bir şekilde giriş yaptınız.");
                    DON:
                        Console.WriteLine("Para Çekmek için    1");
                        Console.WriteLine("Para yatırmak için  2");
                        Console.WriteLine("Para Transferleri   3");
                        Console.WriteLine("Eğitim Ödemeleri    4");
                        Console.WriteLine("Ödemeler            5");
                        Console.WriteLine("Ana menüye dönmek için   9");
                        Console.WriteLine("Çıkmak için              0");
                        string anaSecim = Console.ReadLine();

                        if (anaSecim == "1")
                        {
                            Console.WriteLine("Bakiyeniz:" + bakiye);
                            Console.Write("Çekilecek Tutar: ");
                            double cekTutar = Convert.ToDouble(Console.ReadLine());

                            if (cekTutar <= bakiye)
                            {

                                Console.WriteLine("Çekilen tutar: " + cekTutar + "\nGüncel Bakiyeniz: " + (bakiye - cekTutar) + "\n9 Ana Menüye Dön\n0 Hesaptan çık");
                                string secim = Console.ReadLine();
                                bakiye = bakiye - cekTutar;

                                if (secim == "9")
                                {
                                    goto DON;
                                }
                                else if (secim == "0")
                                {
                                    Console.WriteLine("Hesaptan çıkış yapıldı.");
                                }


                            }

                            else if (cekTutar > bakiye)
                            {
                                Console.WriteLine("Yeterli bakiye yoktur. \n9 Ana Menüye Dön\n0 Hesaptan çık");
                                string secim = Console.ReadLine();
                                if (secim == "9")
                                {
                                    goto DON;
                                }
                                else if (secim == "0")
                                {
                                    Console.WriteLine("Çıkış yapıldı.");
                                }
                            }
                        }

                        else if (anaSecim == "2")
                        {
                            Console.WriteLine("1 Kredi Kartına Para Yatır\n2 Kendi Hesabına Para Yatır");
                            string secim = Console.ReadLine();
                            if (secim == "1")
                            {
                                hak = 3;

                                while (hak > 0)
                                {
                                    Console.WriteLine("12 haneli kredi kartı numaranızı giriniz.");
                                    string kkartiNo = Console.ReadLine();

                                    if (kkartiNo.Length != 12)
                                    {
                                        hak--;
                                        Console.WriteLine("Kart numaranızı 12 haneli olacak şekilde tuşlayınız.");
                                    }
                                    if (hak == 0)
                                    {
                                        Console.WriteLine("9 Ana Menüye Dön\n0 Hesaptan çık");
                                        string secim1 = Console.ReadLine();
                                        if (secim1 == "9")
                                        {
                                            goto DON;
                                        }
                                        else if (secim1 == "0")
                                        {
                                            Console.WriteLine("Hesaptan çıkış yapıldı.");
                                        }
                                    }
                                    else if (kkartiNo.Length == 12)
                                    {
                                        Console.Write("Yatırılacak tutarı giriniz: ");
                                        double yatTutar = Convert.ToDouble(Console.ReadLine());
                                        if (bakiye >= yatTutar)
                                        {
                                            bakiye = bakiye - yatTutar;
                                            Console.WriteLine("Ödeme yapılmıştır. \nGüncel Bakiye: " + bakiye);
                                            Console.WriteLine("9 Ana Menüye Dön\n0 Hesaptan çık");
                                            string secim1 = Console.ReadLine();
                                            if (secim1 == "9")
                                            {
                                                goto DON;
                                            }
                                            else if (secim1 == "0")
                                            {
                                                Console.WriteLine("Hesaptan çıkış yapıldı.");
                                            }

                                        }
                                        else
                                        {
                                            Console.WriteLine("Yeterli bakiye bulunmamaktadır.");
                                            Console.WriteLine("9 Ana Menüye Dön\n0 Hesaptan çık");
                                            string secim1 = Console.ReadLine();
                                            if (secim1 == "9")
                                            {
                                                goto DON;
                                            }
                                            else if (secim1 == "0")
                                            {
                                                Console.WriteLine("Çıkış yapıldı.");
                                            }
                                        }
                                    }
                                }
                            }
                            else if (secim == "2")
                            {
                                Console.Write("Hesabınıza yatırmak istediğiniz tutarı giriniz: ");
                                double yatTutar = Convert.ToDouble(Console.ReadLine());
                                if (bakiye >= yatTutar)
                                {
                                    bakiye = bakiye - yatTutar;
                                    Console.WriteLine("Tutar hesabınıza aktarılmıştır. Güncel Bakiyeniz: " + bakiye);
                                    Console.WriteLine("9 Ana Menüye Dön\n0 Hesaptan çık");
                                    string secim1 = Console.ReadLine();
                                    if (secim1 == "9")
                                    {
                                        goto DON;
                                    }
                                    else if (secim1 == "0")
                                    {
                                        Console.WriteLine("Hesaptan çıkış yapıldı.");
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Yeterli bakiyeniz bulunmamaktadır.");
                                    Console.WriteLine("9 Ana Menüye Dön\n0 Hesaptan çık");
                                    string secim1 = Console.ReadLine();
                                    if (secim1 == "9")
                                    {
                                        goto DON;
                                    }
                                    else if (secim1 == "0")
                                    {
                                        Console.WriteLine("Hesaptan çıkış yapıldı.");
                                    }
                                }
                            }
                        }

                        else if (anaSecim == "3")
                        {
                            Console.WriteLine("1 Başka Hesaba EFT \n2 Başka Hesaba Havale");
                            string secim2 = Console.ReadLine();

                            if (secim2 == "1")
                            {
                            DON2:
                                Console.Write("Başına TR ekleyerek EFT yapılacak hesap numarasını giriniz: ");
                                string EFTno = Console.ReadLine();
                                if (EFTno.StartsWith("TR") && EFTno.Length == 14)
                                {
                                    Console.Write("Yatırmak istediğiniz tutarı giriniz: ");
                                    double gondTutar = Convert.ToDouble(Console.ReadLine());
                                    if (gondTutar > bakiye)
                                    {
                                        Console.WriteLine("Yeterli bakiyeniz bulunmamaktadır. \n9 Ana Menüye Dön\n0 Hesaptan çık");
                                        string secim = Console.ReadLine();
                                        if (secim == "9")
                                        {
                                            goto DON;
                                        }
                                        else if (secim == "0")
                                        {
                                            Console.WriteLine("Hesaptan çıkış yapıldı.");
                                        }
                                    }
                                    else if (gondTutar < bakiye)
                                    {
                                        bakiye = bakiye - gondTutar;
                                        Console.WriteLine("EFT yapıldı. Yeni Bakiyeniz: " + bakiye);
                                        Console.WriteLine("9 Ana Menüye Dön\n0 Hesaptan çık");
                                        string secim = Console.ReadLine();
                                        if (secim == "9")
                                        {
                                            goto DON;
                                        }
                                        else if (secim == "0")
                                        {
                                            Console.WriteLine("Çıkış yapıldı.");
                                        }

                                    }

                                }

                                else
                                {
                                    Console.WriteLine("Hatalı IBAN. Başına TR ekleyin ve 12 haneli olarak girin.");
                                    goto DON2;
                                }

                            }
                            else if (secim2 == "2")
                            {
                            DON2:
                                Console.Write("11 haneli hesap numarasını giriniz: ");
                                string hesapNo = Console.ReadLine();
                                if (hesapNo.Length == 11)
                                {
                                    Console.Write("Yatırmak istediğiniz tutarı giriniz: ");
                                    double gondTutar = Convert.ToDouble(Console.ReadLine());
                                    if (gondTutar > bakiye)
                                    {
                                        Console.WriteLine("Yeterli bakiyeniz bulunmamaktadır. \n9 Ana Menüye Dön\n0 Hesaptan çık");
                                        string secim = Console.ReadLine();
                                        if (secim == "9")
                                        {
                                            goto DON;
                                        }
                                        else if (secim == "0")
                                        {
                                            Console.WriteLine("Hesaptan çıkış yapıldı.");
                                        }
                                    }
                                    else if (gondTutar < bakiye)
                                    {
                                        bakiye = bakiye - gondTutar;
                                        Console.WriteLine("EFT yapılmıştır. Yeni Bakiyeniz: " + bakiye);
                                        Console.WriteLine("9 Ana Menüye Dön\n0 Hesaptan çık");
                                        string secim = Console.ReadLine();
                                        if (secim == "9")
                                        {
                                            goto DON;
                                        }
                                        else if (secim == "0")
                                        {
                                            Console.WriteLine("Hesaptan çıkış yapıldı.");
                                        }

                                    }

                                }

                                else
                                {
                                    Console.WriteLine("Hatalı Hesap Numarası. 11 haneli bir hesap numarası girin.");
                                    goto DON2;
                                }
                            }

                        }

                        else if (anaSecim == "4")
                        {
                            Console.WriteLine("Eğitim Ödemeleri bölümü arızalıdır.. \n9 Ana Menüye Dön\n0 Hesaptan Çık");
                            string secim = Console.ReadLine();

                            if (secim == "9")
                            {
                                goto DON;
                            }
                            else if (secim == "0")
                            {
                                Console.WriteLine("Hesaptan çıkış yapıldı.");
                            }
                        }

                        else if (anaSecim == "5")
                        {
                            Console.WriteLine("1 Elektrik Faturası\n2 Telefon Faturası\n3 İnternet Faturası\n4 Su Faturası\n5 HGS Ödemeleri");
                            string secim = Console.ReadLine();
                            if (secim == "1")
                            {
                                Console.Write("Fatura tutarını giriniz:");
                                double faturaTutari = Convert.ToDouble(Console.ReadLine());
                                if (bakiye >= faturaTutari)
                                {
                                    bakiye = bakiye - faturaTutari;
                                    Console.WriteLine("Fatura ödendi.\nKalan Bakiyeniz: " + bakiye + "\n9 Ana Menüye Dön\n0 Hesaptan Çık");
                                    string secim1 = Console.ReadLine();

                                    if (secim1 == "9")
                                    {
                                        goto DON;
                                    }
                                    else if (secim1 == "0")
                                    {
                                        Console.WriteLine("Hesaptan çıkış yapıldı.");
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Yeterli bakiye bulunmamaktadır.\n9 Ana Menüye Dön\n0 Hesaptan Çık");
                                    string secim1 = Console.ReadLine();

                                    if (secim1 == "9")
                                    {
                                        goto DON;
                                    }
                                    else if (secim1 == "0")
                                    {
                                        Console.WriteLine("Çıkış yapıldı.");
                                    }
                                }
                            }

                            else if (secim == "2")
                            {
                                Console.Write("Fatura tutarını giriniz:");
                                double faturaTutari = Convert.ToDouble(Console.ReadLine());
                                if (bakiye >= faturaTutari)
                                {
                                    bakiye = bakiye - faturaTutari;
                                    Console.WriteLine("Faturanız yatırılmıştır.\nKalan Bakiyeniz: " + bakiye + "\n9 Ana Menüye Dön\n0 Hesaptan Çık");
                                    string secim1 = Console.ReadLine();

                                    if (secim1 == "9")
                                    {
                                        goto DON;
                                    }
                                    else if (secim1 == "0")
                                    {
                                        Console.WriteLine("Hesaptan çıkış yapıldı.");
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Yeterli bakiyeniz bulunmamaktadır.\n9 Ana Menüye Dön\n0 Hesaptan Çık");
                                    string secim1 = Console.ReadLine();

                                    if (secim1 == "9")
                                    {
                                        goto DON;
                                    }
                                    else if (secim1 == "0")
                                    {
                                        Console.WriteLine("Hesaptan çıkış yapıldı.");
                                    }
                                }
                            }

                            else if (secim == "3")
                            {
                                Console.Write("Fatura tutarını giriniz:");
                                double faturaTutari = Convert.ToDouble(Console.ReadLine());
                                if (bakiye >= faturaTutari)
                                {
                                    bakiye = bakiye - faturaTutari;
                                    Console.WriteLine("Faturanız yatırılmıştır.\nKalan Bakiyeniz: " + bakiye + "\n9 Ana Menüye Dön\n0 Hesaptan Çık");
                                    string secim1 = Console.ReadLine();

                                    if (secim1 == "9")
                                    {
                                        goto DON;
                                    }
                                    else if (secim1 == "0")
                                    {
                                        Console.WriteLine("Hesaptan çıkış yapıldı.");
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Yeterli bakiyeniz bulunmamaktadır.\n9 Ana Menüye Dön\n0 Hesaptan Çık");
                                    string secim1 = Console.ReadLine();

                                    if (secim1 == "9")
                                    {
                                        goto DON;
                                    }
                                    else if (secim1 == "0")
                                    {
                                        Console.WriteLine("Hesaptan çıkış yapıldı.");
                                    }
                                }
                            }

                            else if (secim == "4")
                            {
                                Console.Write("Fatura tutarını giriniz:");
                                double faturaTutari = Convert.ToDouble(Console.ReadLine());
                                if (bakiye >= faturaTutari)
                                {
                                    bakiye = bakiye - faturaTutari;
                                    Console.WriteLine("Faturanız yatırılmıştır.\nKalan Bakiyeniz: " + bakiye + "\n9 Ana Menüye Dön\n0 Hesaptan Çık");
                                    string secim1 = Console.ReadLine();

                                    if (secim1 == "9")
                                    {
                                        goto DON;
                                    }
                                    else if (secim1 == "0")
                                    {
                                        Console.WriteLine("Hesaptan çıkış yapıldı.");
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Yeterli bakiyeniz bulunmamaktadır.\n9 Ana Menüye Dön\n0 Hesaptan Çık");
                                    string secim1 = Console.ReadLine();

                                    if (secim1 == "9")
                                    {
                                        goto DON;
                                    }
                                    else if (secim1 == "0")
                                    {
                                        Console.WriteLine("Hesaptan çıkış yapıldı.");
                                    }
                                }
                            }

                            else if (secim == "5")
                            {
                                Console.Write("Fatura tutarını giriniz:");
                                double faturaTutari = Convert.ToDouble(Console.ReadLine());
                                if (bakiye >= faturaTutari)
                                {
                                    bakiye = bakiye - faturaTutari;
                                    Console.WriteLine("Ödemeniz yapılmıştır.\nKalan Bakiyeniz: " + bakiye + "\n9 Ana Menüye Dön\n0 Hesaptan Çık");
                                    string secim1 = Console.ReadLine();

                                    if (secim1 == "9")
                                    {
                                        goto DON;
                                    }
                                    else if (secim1 == "0")
                                    {
                                        Console.WriteLine("Hesaptan çıkış yapıldı.");
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Yeterli bakiyeniz bulunmamaktadır.\n9 Ana Menüye Dön\n0 Hesaptan Çık");
                                    string secim1 = Console.ReadLine();

                                    if (secim1 == "9")
                                    {
                                        goto DON;
                                    }
                                    else if (secim1 == "0")
                                    {
                                        Console.WriteLine("Hesaptan çıkış yapıldı.");
                                    }
                                }

                            }

                        }

                        else if (anaSecim == "6")
                        {
                            Console.WriteLine("Yapmak istediğiniz işlemi tuşlayınız: \n1 Şifre değiştirme");
                            string sifreDegistir = Console.ReadLine();
                            Console.WriteLine("Yeni şifrenizi tuşlayınız: ");
                            string yeniSifre = Console.ReadLine();
                            sifre = yeniSifre;
                            Console.WriteLine("Şifreniz değiştirilmiştir.\n9 Ana Menüye Dön\n0 Hesaptan Çık");
                            string secim1 = Console.ReadLine();

                            if (secim1 == "9")
                            {
                                goto DON;
                            }
                            else if (secim1 == "0")
                            {
                                Console.WriteLine("Hesaptan çıkış yapıldı.");
                            }
                        }

                        break;
                    }
                    else
                    {
                        hak--;
                        Console.WriteLine("Hatalı şifre. Kalan giriş hakkı " + hak);
                    }

                    if (hak == 0)
                    {
                        Console.WriteLine("Kartınız bloke olmuştur. 0850 xxx numaralı telefonumuzla iletişiem geçiniz.");
                        break;
                    }
                }
            }

            else if (tus == "2")
            {


                Console.WriteLine("Kartsız işlem geçici olarak arızalıdır.");

            }
            Console.ReadLine();
        }
    }
}