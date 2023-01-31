using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Bankamatik_bt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int bakiye = 250;
        DON:
            Console.WriteLine("Kartlı İşlemler İçin 1 \n Kartsız İşlemler için 2 Tuşlayınız");
            int islem = Convert.ToInt32(Console.ReadLine());
            string sifre = "ab18";
            int hak = 0;
            int hakk = 0;

            if (islem == 1)
            {
                Console.WriteLine("Kartlı İşlemler Bölümüne Hoşgeldiniz");

                while (hak < 3)
                {
                    Console.WriteLine("Lütfen Şifrenizi Giriniz");
                    string sifre1 = Console.ReadLine();

                    if (sifre == sifre1)
                    {
                    ANAMENU:
                        Console.WriteLine("ANA MENÜYE HOŞGELDİNİZ ");
                        Console.WriteLine("Para Çekmek İçin 1 \n Para Yatırmak İçin 2 \n Para Transferleri için 3 \n Eğitim Ödemeleri İçin 4 \n Ödemeler İçin 5 \n Bilgi Güncellemek için 6 tuşlayaınız");
                        int secim = Convert.ToInt32(Console.ReadLine());
                        if (secim == 1)
                        {
                            Console.WriteLine("Para Çekmek İstediğiniz Tutarı Giriniz");
                            int paracekme = Convert.ToInt32(Console.ReadLine());
                            if (paracekme <= bakiye)
                            {
                                bakiye = bakiye - paracekme;
                                Console.WriteLine("İşleminiz Başarıyla Gerçekleşti Kalan Bakiyeniz = " + (bakiye));

                            }
                            else
                            {
                                Console.WriteLine("Bakiyenizden Fazla Para Çekemezsiniz");
                            }
                            Console.WriteLine("Ana Menü 9 \n Çıkış Yapmak için 0 Tuşuna Basınız...");
                            int tercih = Convert.ToInt32(Console.ReadLine());
                            if (tercih == 9)
                            {
                                goto ANAMENU;
                            }
                            else if (tercih == 0)
                            {
                                Console.WriteLine("Çıkış Yapıldı.");
                                break;
                            }
                        }
                        if (secim == 2)
                        {
                        PARAYATIRMA:
                            Console.WriteLine(" 1- Kredi Kartına  \n 2- Kendi Hesabınıza yatırmak için \n 9- Ana Menü \n 0- Kart İade");
                            int tercih1 = Convert.ToInt32(Console.ReadLine());
                            if (tercih1 == 1)
                            {
                                Console.WriteLine("12 Haneli Kredi Kart Numaranızı Giriniz");
                                string kartNO = Console.ReadLine();
                                if (kartNO.Length == 12)
                                {
                                    Console.WriteLine("Karta Yatırmak İstediğiniz Tutarı Giriniz");
                                    int tutar = Convert.ToInt32(Console.ReadLine());
                                    if (tutar <= bakiye)
                                    {
                                        bakiye = bakiye - tutar;
                                        Console.WriteLine("İşleminiz Gerçekleşti Yatırdığınız toplam Tutar =" + tutar);
                                        Console.WriteLine("Kalan Bakiyeniz = " + bakiye);
                                        goto PARAYATIRMA;
                                    }

                                    else
                                    {
                                        Console.WriteLine("Bakiyenizden Fazla Tutar Girdiniz \n Lütfen Tekrar Deneyiniz.");
                                        goto PARAYATIRMA;
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Hatalı Kart Numarası Girdiniz");
                                    goto PARAYATIRMA;
                                }

                            }

                            else if (tercih1 == 2)
                            {
                                Console.WriteLine("Yatırmak İstediğiniz Tutarı Giriniz");
                                int tutar1 = Convert.ToInt32(Console.ReadLine());
                                bakiye = bakiye + tutar1;
                                Console.WriteLine("İşleminiz Gerçekleşti Yatırdığınız Toplam Tutar =" + (tutar1));
                                Console.WriteLine("Yeni Bakiyeniz = " + (bakiye));

                                goto PARAYATIRMA;
                            }

                            else if (tercih1 == 9)
                            {
                                goto ANAMENU;
                            }
                            else if (tercih1 == 0)
                            {
                                Console.WriteLine("Çıkış Yapıldı");
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Hatalı Tuşlama Yaptınız ");
                                goto PARAYATIRMA;
                            }



                        }
                        if (secim == 3)
                        {
                        PARATRANSFERLERI:
                            Console.WriteLine("Başka Hesaba EFT için 1 \n Başka Hesaba Havale için 2 Tuşuna Basınız.");
                            int tercih2 = Convert.ToInt32(Console.ReadLine());
                            if (tercih2 == 1)
                            {
                                Console.WriteLine("EFT yapılacak hesap numarasını giriniz");
                                string eftno = Console.ReadLine();
                                bool eftTR = eftno.StartsWith("TR");
                                int eftnoO = eftno.Length;
                                if (eftTR == true)
                                {
                                    if (eftnoO == 12)
                                    {
                                        Console.WriteLine("Yatırmak İstediğiniz Tutarı Giriniz");
                                        int tutar2 = Convert.ToInt32(Console.ReadLine());

                                        if (tutar2 <= bakiye)
                                        {
                                            bakiye = tutar2 - bakiye;
                                            Console.WriteLine("EFT işlemi başarıyla gerçekleşti kalan bakiyeniz =" + (bakiye));
                                            Console.WriteLine("Anamenü için 9 \n Çıkış Yapmak için 0 Tuşuna Basınız");
                                            int tercih3 = Convert.ToInt32(Console.ReadLine());
                                            if (tercih3 == 9)
                                            {
                                                goto ANAMENU;
                                            }
                                            else if (tercih3 == 0)
                                            {
                                                Console.WriteLine("Çıkış Yapıldı");
                                                break;
                                            }
                                            else
                                            {
                                                Console.WriteLine("Hatalı Tuşlama Yapıldı.");
                                                goto PARATRANSFERLERI;
                                            }

                                        }
                                        else
                                        {
                                            Console.WriteLine("Bakiyenizden Fazla Para Yatırma İşlemi Yapamazsınız!");
                                            goto PARATRANSFERLERI;
                                        }

                                    }
                                    else
                                    {
                                        Console.WriteLine("EFT NO 12 HANEDEN OLUŞMAKTADIR.");
                                        goto PARATRANSFERLERI;
                                    }


                                }
                            }
                            else if (tercih2 == 2)
                            {
                                Console.WriteLine("Hesap Numaranızı Giriniz");
                                string hesapNO = Console.ReadLine();
                                if (hesapNO.Length == 11)
                                {
                                    Console.WriteLine("Yatırmak İstediğiniz Tutarı Giriniz");
                                    int tutar3 = Convert.ToInt32(Console.ReadLine());
                                    if (tutar3 <= bakiye)
                                    {
                                        bakiye = tutar3 - bakiye;
                                        Console.WriteLine("Para Gönderme İşleminiz Başarıyla Gerçekleşti Kalan Bakiyeniz =" + (bakiye));
                                        Console.WriteLine("Anamenü için 9 \n Çıkış Yapmak için 0 Tuşuna Basınız");
                                        int tercih4 = Convert.ToInt32(Console.ReadLine());
                                        if (tercih4 == 9)
                                        {
                                            goto ANAMENU;
                                        }
                                        else if (tercih4 == 0)
                                        {
                                            Console.WriteLine("Çıkış yapıldı.");
                                            break;
                                        }
                                        else
                                        {
                                            Console.WriteLine("Hatalı Tuşlama Yaptınız");
                                            goto PARATRANSFERLERI;
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("Bakiyenizden Fazla Para Yatıramazsınız");
                                        goto PARATRANSFERLERI;
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Hesap NO 11 Haneden Oluşmaktadır");
                                    goto PARATRANSFERLERI;
                                }

                            }

                            else
                            {
                                Console.WriteLine("Hatalı Tuşlama Yaptınız Tekrar Deneyiniz");
                                goto PARATRANSFERLERI;
                            }
                        }
                        if (secim == 4)
                        {
                            Console.WriteLine("Eğitim Ödemeleri Sayfamız Malesef Arızalı");
                            Console.WriteLine("Anamenü için 9 \n Çıkış Yapmak için 0 Tuşuna Basınız");
                            int tercih5 = Convert.ToInt32(Console.ReadLine());
                            if (tercih5 == 9)
                            {
                                goto ANAMENU;
                            }
                            else if (tercih5 == 0)
                            {
                                Console.WriteLine("Çıkış Yapıldı.");
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Hatalı Tuşlama Yaptınız");
                                goto ANAMENU;
                            }
                        }
                        if (secim == 5)
                        {
                        FATURA:
                            Console.WriteLine("Fatura Yatırma Bölümüne Hoşgeldiniz");
                            Console.WriteLine("Elektrik Faturası için 1 \n Telefon Faturası için 2 \n İnternet faturası için 3 \n Su Faturası için 4 \n OGS Ödemeleri için 5 tuşuna basınız");
                            int tercih6 = Convert.ToInt32(Console.ReadLine());
                            if (tercih6 == 1)
                            {
                                Console.WriteLine("Fatura Tutarınızı Giriniz");
                                int tutar4 = Convert.ToInt32(Console.ReadLine());
                                if (tutar4 <= bakiye)
                                {
                                    bakiye = bakiye - tutar4;
                                    Console.WriteLine("Elektrik Faturanız Başarıyla Ödenmiştir Kalan Bakiyeniz =" + (bakiye));
                                    Console.WriteLine("Anamenü için 9 \n Çıkış Yapmak için 0 Tuşuna Basınız");
                                    int tercih7 = Convert.ToInt32(Console.ReadLine());
                                    if (tercih7 == 9)
                                    {
                                        goto ANAMENU;
                                    }
                                    else if (tercih7 == 0)
                                    {
                                        Console.WriteLine("Çıkış Yapıldı.");
                                        break;
                                    }
                                    else
                                    {
                                        Console.WriteLine("Hatalı Tuşlama Yaptınız.");
                                        goto FATURA;
                                    }

                                }
                                else
                                {
                                    Console.WriteLine("Bakiyenizden Fazla Ödeme Yapamazsınız.");
                                    goto FATURA;
                                }
                            }
                            if (tercih6 == 2)
                            {
                                Console.WriteLine("Fatura Tutarınızı Giriniz");
                                int tutar4 = Convert.ToInt32(Console.ReadLine());
                                if (tutar4 <= bakiye)
                                {
                                    bakiye = bakiye - tutar4;
                                    Console.WriteLine("Telefon Faturanız Başarıyla Ödenmiştir Kalan Bakiyeniz =" + (bakiye));
                                    Console.WriteLine("Anamenü için 9 \n Çıkış Yapmak için 0 Tuşuna Basınız");
                                    int tercih7 = Convert.ToInt32(Console.ReadLine());
                                    if (tercih7 == 9)
                                    {
                                        goto ANAMENU;
                                    }
                                    else if (tercih7 == 0)
                                    {
                                        Console.WriteLine("Çıkış Yapıldı.");
                                        break;
                                    }
                                    else
                                    {
                                        Console.WriteLine("Hatalı Tuşlama Yaptınız.");
                                        goto FATURA;
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Bakiyenizden Fazla Ödeme Yapamazsınız.");
                                    goto FATURA;
                                }
                            }
                            if (tercih6 == 3)
                            {
                                Console.WriteLine("Fatura Tutarınızı Giriniz");
                                int tutar4 = Convert.ToInt32(Console.ReadLine());
                                if (tutar4 <= bakiye)
                                {
                                    bakiye = bakiye - tutar4;
                                    Console.WriteLine("İnternet Faturanız Başarıyla Ödenmiştir Kalan Bakiyeniz =" + (bakiye));
                                    Console.WriteLine("Anamenü için 9 \n Çıkış Yapmak için 0 Tuşuna Basınız");
                                    int tercih7 = Convert.ToInt32(Console.ReadLine());
                                    if (tercih7 == 9)
                                    {
                                        goto ANAMENU;
                                    }
                                    else if (tercih7 == 0)
                                    {
                                        Console.WriteLine("Çıkış Yapıldı.");
                                        break;
                                    }
                                    else
                                    {
                                        Console.WriteLine("Hatalı Tuşlama Yaptınız.");
                                        goto FATURA;
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Bakiyenizden Fazla Ödeme Yapamazsınız.");
                                    goto FATURA;
                                }
                            }
                            if (tercih6 == 4)
                            {
                                Console.WriteLine("Fatura Tutarınızı Giriniz");
                                int tutar4 = Convert.ToInt32(Console.ReadLine());
                                if (tutar4 <= bakiye)
                                {
                                    bakiye = bakiye - tutar4;
                                    Console.WriteLine("Su Faturanız Başarıyla Ödenmiştir Kalan Bakiyeniz =" + (bakiye));
                                    Console.WriteLine("Anamenü için 9 \n Çıkış Yapmak için 0 Tuşuna Basınız");
                                    int tercih7 = Convert.ToInt32(Console.ReadLine());
                                    if (tercih7 == 9)
                                    {
                                        goto ANAMENU;
                                    }
                                    else if (tercih7 == 0)
                                    {
                                        Console.WriteLine("Çıkış Yapıldı.");
                                        break;
                                    }
                                    else
                                    {
                                        Console.WriteLine("Hatalı Tuşlama Yaptınız.");
                                        goto FATURA;
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Bakiyenizden Fazla Ödeme Yapamazsınız.");
                                    goto FATURA;
                                }
                            }
                            if (tercih6 == 5)
                            {
                                Console.WriteLine("Fatura Tutarınızı Giriniz");
                                int tutar4 = Convert.ToInt32(Console.ReadLine());
                                if (tutar4 <= bakiye)
                                {
                                    bakiye = bakiye - tutar4;
                                    Console.WriteLine("OGS Ödemeniz Başarıyla Ödenmiştir Kalan Bakiyeniz =" + (bakiye));
                                    Console.WriteLine("Anamenü için 9 \n Çıkış Yapmak için 0 Tuşuna Basınız");
                                    int tercih7 = Convert.ToInt32(Console.ReadLine());
                                    if (tercih7 == 9)
                                    {
                                        goto ANAMENU;
                                    }
                                    else if (tercih7 == 0)
                                    {
                                        Console.WriteLine("Çıkış Yapıldı.");
                                        break;
                                    }
                                    else
                                    {
                                        Console.WriteLine("Hatalı Tuşlama Yaptınız.");
                                        goto FATURA;
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Bakiyenizden Fazla Ödeme Yapamazsınız.");
                                    goto FATURA;
                                }
                            }

                        }
                        if (secim == 6)
                        {
                        SIFREDEGISIM:
                            Console.WriteLine("Şifrenizi Değiştirmek İçin 1 Tuşuna Basınız");
                            int tercih8 = Convert.ToInt32(Console.ReadLine());
                            if (tercih8 == 1)
                            {
                                Console.WriteLine("Yeni Şifrenizi Giriniz");
                                string yenısıfre = Console.ReadLine();
                                if (yenısıfre.Length == 4)
                                {
                                    string a = sifre;
                                    a = yenısıfre;
                                    yenısıfre = sifre;
                                    Console.WriteLine("İşlem Başarıyla Gerçekleşti");
                                }
                                else
                                {
                                    Console.WriteLine("Şifreniz 4 Haneden Oluşmaktadır");
                                    goto SIFREDEGISIM;
                                }

                            }
                            else
                            {
                                Console.WriteLine("Hatalı Tuşlama Yaptınız.");
                                goto SIFREDEGISIM;
                            }
                            Console.WriteLine("Anamenü için 9 \n Çıkış Yapmak için 0 Tuşuna Basınız");
                            int tercih9 = Convert.ToInt32(Console.ReadLine());
                            if (tercih9 == 9)
                            {
                                goto ANAMENU;
                            }
                            else if (tercih9 == 0)
                            {
                                Console.WriteLine("Çıkış Yapıldı");
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Hatalı Tuşlama Yaptınız");
                                goto SIFREDEGISIM;
                            }
                        }


                    }
                    else
                    {
                        Console.WriteLine("Şifre Hatalı Lütfen Tekrar Deneyiniz");
                    }
                    hak++;
                }
                if (hak == 3)
                {
                    Console.WriteLine("Sistemden Çıkış Yapılıyor...");
                }
                else if (islem == 2)
                {
                    Console.WriteLine("Kartsız İşlemler Bölümüne Hoşgeldiniz");
                AMENU:
                    Console.WriteLine("CepBank Para Çekmek için 1 \n Para Yatırmak İçin 2 \n Kredi Kartı Ödeme için 3 \n Eğitim Ödemeleri için 4 \n Ödemeler için 5 tuşlayınız");
                    int secim01 = Convert.ToInt32(Console.ReadLine());
                    if (secim01 == 1)
                    {
                        while (hakk < 3)
                        {
                            Console.WriteLine("Cep Telefon Numaranızıı Giriniz");
                            string ceptel = Console.ReadLine();
                            Console.WriteLine("TC kimlik no giriniz");
                            string tc = Console.ReadLine();
                            if (tc.Length == 11 && ceptel.Length == 11)
                            {
                                Console.WriteLine("Çekilecek Tutarı Giriniz");
                                int cekme = Convert.ToInt32(Console.ReadLine());

                                if (cekme <= bakiye)
                                {
                                    bakiye = bakiye - cekme;
                                    Console.WriteLine("İşleminiz Başarıyla Gerçekleşti Kalan Bakiyeniz = " + (bakiye));
                                }
                                else if (cekme > bakiye)
                                {
                                    Console.WriteLine("Bakiyenizden Fazla Para Çekemezsiniz");
                                    goto AMENU;
                                }
                                else
                                {
                                    Console.WriteLine("Hatalı Tuşlama Yaptınız ");
                                    goto AMENU;
                                }
                            }
                            else if (hakk < 2)
                            {
                                Console.WriteLine("Cep Telefonu Veya TC Kimlik Numaranızı Yanlış Girdiniz Lütfen Tekrar Deneyiniz");
                            }
                            hakk++;

                        }
                        if (hakk == 3)
                        {
                            Console.WriteLine("Sisteminiz Kilitlendi 1 Saat Sonra Tekrar Giriş Yapınız");
                            Thread.Sleep(1000000000);
                            goto AMENU;
                        }

                    }
                    if (secim01 == 2)
                    {
                    PARAYATTIRMA:
                        Console.WriteLine("Nakit Ödeme 1 \n Hesaptan Ödeme 2 \n Anamenü 9 \n Çıkış Yapmak İçin 0 Tuşuna basınız");
                        int tercihh = Convert.ToInt32((Console.ReadLine()));
                        if (tercihh == 1)
                        {
                            Console.WriteLine("12 Haneli Kredi Kart Numarasını Giriniz");
                            string kartnO1 = Console.ReadLine();
                            Console.WriteLine("11 Haneli TC Kimlik Numaranızı Giriniz");
                            string TCno01 = Console.ReadLine();
                            if (kartnO1.Length == 12 && TCno01.Length == 11)
                            {
                                Console.WriteLine("Yatırılıcak Para Tutarını Giriniz");
                                int paratutar = Convert.ToInt32((Console.ReadLine()));
                                if (paratutar <= bakiye)
                                {
                                    bakiye = paratutar - bakiye;
                                    Console.WriteLine("İşleminiz Gerçekleşti Kalan Bakiyeniz = " + (bakiye));
                                    goto PARAYATTIRMA;
                                }
                                else if (paratutar > bakiye)
                                {
                                    Console.WriteLine("Bakiyenizden Fazla Para Çekemzsiniz.");
                                    goto PARAYATTIRMA;
                                }
                                else
                                {
                                    Console.WriteLine("Hatalı Giriş Yaptınız.");
                                    goto PARAYATTIRMA;
                                }
                            }
                            else
                            {
                                Console.WriteLine("Kredi Kart Numarası veya TC Kimlik Numaranızı Yanlış Girdiniz \n Lütfen Tekrar Deneyiniz");
                                goto PARAYATTIRMA;
                            }
                        }
                        else if (tercihh == 2)
                        {
                            Console.WriteLine("Kredi Kart Numaranızı Giriniz");
                            string kartno2 = Console.ReadLine();
                            Console.WriteLine("Hesap Numaranızı Giriniz");
                            string hesapno = Console.ReadLine();
                            if (kartno2.Length == 12 && hesapno.Length == 11)
                            {
                                Console.WriteLine("Yatırılacak Tutarı Giriniz");
                                int tutarr = Convert.ToInt32((Console.ReadLine()));
                                if (tutarr <= bakiye)
                                {
                                    bakiye = tutarr - bakiye;
                                    Console.WriteLine("İşleminiz Gerçekleşti Kalan Bakiyeniz = " + (bakiye));
                                    goto PARAYATTIRMA;

                                }
                                else if (tutarr > bakiye)
                                {
                                    Console.WriteLine("Bakiyenizden Fazla Para Çekemezsiniz");
                                    goto PARAYATTIRMA;
                                }
                                else
                                {
                                    Console.WriteLine("Hatalı Tuşlama Yaptınız");
                                    goto PARAYATTIRMA;
                                }
                            }
                            else
                            {
                                Console.WriteLine("Kredi Kart veya Hesap Numaranızı Yanlış Girdiniz \n Lütfen Tekrar Deneyiniz");
                                goto PARAYATTIRMA;
                            }
                        }
                        else if (tercihh == 9)
                        {
                            goto AMENU;
                        }
                        else if (tercihh == 0)
                        {
                            Console.WriteLine("Çıkış Yapılıyor...");
                            Thread.Sleep(3000);
                            Console.WriteLine("Hesaptan çıkış yapıldı.");

                        }
                        else
                        {
                            Console.WriteLine("Hatalı Tuşlama Yaptınız.");
                            goto AMENU;
                        }

                    }
                    if (secim01 == 3)
                    {
                    EFTHAVALE:
                        Console.WriteLine("1-Başka Hesaba EFT\n2-Başka Hesaba Havale\n Anamenü 9\n Çıkış 0");
                        Console.WriteLine("İşleminiz:");
                        int scm = Convert.ToInt32(Console.ReadLine());
                        if (scm == 1)
                        {
                            Console.WriteLine("EFT Numarasını Giriniz");
                            string EFTno1 = Console.ReadLine();

                            if (EFTno1.StartsWith("TR") && EFTno1.Length == 14)

                            {
                                Console.WriteLine("Yatırılacak Tutarı Giriniz");
                                int yatutar = Convert.ToInt32(Console.ReadLine());
                                if (yatutar <= bakiye)
                                {
                                    bakiye = yatutar - bakiye;
                                    Console.WriteLine("İşleminiz Gerçekleşti Kalan Bakiyeniz =" + (bakiye));
                                    goto EFTHAVALE;
                                }
                                else if (yatutar > bakiye)
                                {
                                    Console.WriteLine("Bakiyenizden Fazla Tutar Giremezsiniz");
                                    goto EFTHAVALE;
                                }
                                else
                                {
                                    Console.WriteLine("Hatalı Tuşlama Yaptınız");
                                    goto EFTHAVALE;
                                }
                            }
                            else
                            {
                                Console.WriteLine(" EFT Numaranızı Yanlış Girdiniz Lütfen Tekrar Deneyiniz");
                                goto EFTHAVALE;
                            }

                        }
                        else if (scm == 2)
                        {
                            Console.WriteLine("Hesap Numarasını Giriniz");
                            string hspno = Console.ReadLine();
                            if (hspno.Length == 11)
                            {
                                Console.WriteLine("Yatıralacak Tutarı Giriniz");
                                int tutr = Convert.ToInt32(Console.ReadLine());
                                if (tutr <= bakiye)
                                {
                                    bakiye = tutr - bakiye;
                                    Console.WriteLine("İşleminiz Gerçekleşti Kalan Bakiyeniz =" + (bakiye));
                                    goto EFTHAVALE;
                                }
                                else if (tutr > bakiye)
                                {
                                    Console.WriteLine("Bakiyenizden Fazla Para Gönderemezsiniz");
                                    goto EFTHAVALE;
                                }
                                else
                                {
                                    Console.WriteLine("Yanlış Tuşlama Yaptınız ");
                                    goto EFTHAVALE;
                                }
                            }
                            else
                            {
                                Console.WriteLine("Hesap numarasını Yanlıs Girdiniz Lütfen Tekarar Deneyiniz");
                                goto EFTHAVALE;
                            }
                        }
                        else if (scm == 9)
                        {
                            goto AMENU;
                        }
                        else if (scm == 0)
                        {
                            Console.WriteLine("Çıkış Yapılıyor...");
                            Thread.Sleep(3000);
                            Console.WriteLine("Hesaptan çıkış yapıldı.");
                        }
                    }
                    if (secim01 == 4)
                    {
                        Console.WriteLine("Eğitim Ödemeleri Sayfamız Malesef Arızalı");
                        Console.WriteLine("Anamenü için 9 \n Çıkış Yapmak için 0 Tuşuna Basınız");
                        int tercih5 = Convert.ToInt32(Console.ReadLine());
                        if (tercih5 == 9)
                        {
                            goto AMENU;
                        }
                        else if (tercih5 == 0)
                        {
                            Console.WriteLine("Çıkış Yapıldı.");

                        }
                        else
                        {
                            Console.WriteLine("Hatalı Tuşlama Yaptınız");
                            goto AMENU;
                        }
                    }
                    if (secim01 == 5)
                    {
                    FATURA:
                        Console.WriteLine("Fatura Yatırma Bölümüne Hoşgeldiniz");
                        Console.WriteLine("Elektrik Faturası için 1 \n Telefon Faturası için 2 \n İnternet faturası için 3 \n Su Faturası için 4 \n OGS Ödemeleri için 5 tuşuna basınız");
                        int tercih6 = Convert.ToInt32(Console.ReadLine());
                        if (tercih6 == 1)
                        {
                            Console.WriteLine("Fatura Tutarınızı Giriniz");
                            int tutar4 = Convert.ToInt32(Console.ReadLine());
                            if (tutar4 <= bakiye)
                            {
                                bakiye = bakiye - tutar4;
                                Console.WriteLine("Elektrik Faturanız Başarıyla Ödenmiştir Kalan Bakiyeniz =" + (bakiye));
                                Console.WriteLine("Anamenü için 9 \n Çıkış Yapmak için 0 Tuşuna Basınız");
                                int tercih7 = Convert.ToInt32(Console.ReadLine());
                                if (tercih7 == 9)
                                {
                                    goto AMENU;
                                }
                                else if (tercih7 == 0)
                                {
                                    Console.WriteLine("Çıkış Yapıldı.");

                                }
                                else
                                {
                                    Console.WriteLine("Hatalı Tuşlama Yaptınız.");
                                    goto FATURA;
                                }

                            }
                            else
                            {
                                Console.WriteLine("Bakiyenizden Fazla Ödeme Yapamazsınız.");
                                goto FATURA;
                            }
                        }
                        if (tercih6 == 2)
                        {
                            Console.WriteLine("Fatura Tutarınızı Giriniz");
                            int tutar4 = Convert.ToInt32(Console.ReadLine());
                            if (tutar4 <= bakiye)
                            {
                                bakiye = bakiye - tutar4;
                                Console.WriteLine("Telefon Faturanız Başarıyla Ödenmiştir Kalan Bakiyeniz =" + (bakiye));
                                Console.WriteLine("Anamenü için 9 \n Çıkış Yapmak için 0 Tuşuna Basınız");
                                int tercih7 = Convert.ToInt32(Console.ReadLine());
                                if (tercih7 == 9)
                                {
                                    goto AMENU;
                                }
                                else if (tercih7 == 0)
                                {
                                    Console.WriteLine("Çıkış Yapıldı.");

                                }
                                else
                                {
                                    Console.WriteLine("Hatalı Tuşlama Yaptınız.");
                                    goto FATURA;
                                }
                            }
                            else
                            {
                                Console.WriteLine("Bakiyenizden Fazla Ödeme Yapamazsınız.");
                                goto FATURA;
                            }
                        }
                        if (tercih6 == 3)
                        {
                            Console.WriteLine("Fatura Tutarınızı Giriniz");
                            int tutar4 = Convert.ToInt32(Console.ReadLine());
                            if (tutar4 <= bakiye)
                            {
                                bakiye = bakiye - tutar4;
                                Console.WriteLine("İnternet Faturanız Başarıyla Ödenmiştir Kalan Bakiyeniz =" + (bakiye));
                                Console.WriteLine("Anamenü için 9 \n Çıkış Yapmak için 0 Tuşuna Basınız");
                                int tercih7 = Convert.ToInt32(Console.ReadLine());
                                if (tercih7 == 9)
                                {
                                    goto AMENU;
                                }
                                else if (tercih7 == 0)
                                {
                                    Console.WriteLine("Çıkış Yapıldı.");

                                }
                                else
                                {
                                    Console.WriteLine("Hatalı Tuşlama Yaptınız.");
                                    goto FATURA;
                                }
                            }
                            else
                            {
                                Console.WriteLine("Bakiyenizden Fazla Ödeme Yapamazsınız.");
                                goto FATURA;
                            }
                        }
                        if (tercih6 == 4)
                        {
                            Console.WriteLine("Fatura Tutarınızı Giriniz");
                            int tutar4 = Convert.ToInt32(Console.ReadLine());
                            if (tutar4 <= bakiye)
                            {
                                bakiye = bakiye - tutar4;
                                Console.WriteLine("Su Faturanız Başarıyla Ödenmiştir Kalan Bakiyeniz =" + (bakiye));
                                Console.WriteLine("Anamenü için 9 \n Çıkış Yapmak için 0 Tuşuna Basınız");
                                int tercih7 = Convert.ToInt32(Console.ReadLine());
                                if (tercih7 == 9)
                                {
                                    goto AMENU;
                                }
                                else if (tercih7 == 0)
                                {
                                    Console.WriteLine("Çıkış Yapıldı.");

                                }
                                else
                                {
                                    Console.WriteLine("Hatalı Tuşlama Yaptınız.");
                                    goto FATURA;
                                }
                            }
                            else
                            {
                                Console.WriteLine("Bakiyenizden Fazla Ödeme Yapamazsınız.");
                                goto FATURA;
                            }
                        }
                        if (tercih6 == 5)
                        {
                            Console.WriteLine("Fatura Tutarınızı Giriniz");
                            int tutar4 = Convert.ToInt32(Console.ReadLine());
                            if (tutar4 <= bakiye)
                            {
                                bakiye = bakiye - tutar4;
                                Console.WriteLine("OGS Ödemeniz Başarıyla Ödenmiştir Kalan Bakiyeniz =" + (bakiye));
                                Console.WriteLine("Anamenü için 9 \n Çıkış Yapmak için 0 Tuşuna Basınız");
                                int tercih7 = Convert.ToInt32(Console.ReadLine());
                                if (tercih7 == 9)
                                {
                                    goto AMENU;
                                }
                                else if (tercih7 == 0)
                                {
                                    Console.WriteLine("Çıkış Yapıldı.");

                                }
                                else
                                {
                                    Console.WriteLine("Hatalı Tuşlama Yaptınız.");
                                    goto FATURA;
                                }
                            }
                            else
                            {
                                Console.WriteLine("Bakiyenizden Fazla Ödeme Yapamazsınız.");
                                goto FATURA;
                            }
                        }

                    }
                }

            }
            else
            {
                Console.WriteLine("Hatalı Tuşlama Yaptınız \n Lütfen Tekrar Deneyiniz...");
                goto DON;
            }


            Console.ReadLine();
        }
    }
}


