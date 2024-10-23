using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_MakingDecision
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region if else 
            //Console.Write("Lütfen şifreyi giriniz:");
            //string password;
            //password = Console.ReadLine();
            //if (password == "abcd")
            //{
            //    Console.WriteLine("Şifre Doğru");
            //}
            //else
            //{
            //    Console.WriteLine("Şifre Yanlış");
            //}

            //string capital, country;
            //Console.Write("Başkenti Giriniz:");
            //capital = Console.ReadLine();
            //Console.Write("Ülkeyi Giriniz:");
            //country = Console.ReadLine();
            //if(capital=="ankara"&country=="türkiye")
            //{
            //    Console.Write("Veriler Doğrulandı");
            //}
            //else
            //{
            //    Console.Write("Hatalı Bilgi");
            //}

            //int number;
            //Console.Write("Sayıyı Giriniz:");
            //number=int.Parse(Console.ReadLine());
            //if (number == 5) 
            //{
            //    Console.WriteLine("Sayı Doğru");
            //}
            //else
            //{
            //    Console.WriteLine("Sayı Hatalı");
            //}
            //int exam1, exam2, exam3, average;
            //string result = "Hata!";

            //Console.Write("Sınav1:");
            //exam1=int.Parse(Console.ReadLine());
            //Console.Write("Sınav2:");
            //exam2 = int.Parse(Console.ReadLine());
            //Console.Write("Sınav3:");
            //exam3 = int.Parse(Console.ReadLine());
            //average=(exam1 + exam2 + exam3) / 3;
            //Console.WriteLine("sınavların ortlaması:" + average);
            //if (average >0 & average<=50)
            //{
            //    result = "sonuç vasat";
            //}
            //if (average > 50 & average <= 70)
            //{
            //    result = "sonuç orta";
            //}

            //if (average > 70 & average <= 84)
            //{
            //    result = "sonuç iyi";
            //}
            //if (average >84)
            //{
            //    result = "sonuç çok iyi";
            //}
            //Console.WriteLine(result);


            //string city;
            //Console.Write("Lütfen Şehir Giriniz:  ");
            //city = Console.ReadLine();
            //if (city == "adana" | city == "ankara" | city == "bursa" | city == "trabzon")
            //{
            //    Console.WriteLine("Şehir Mevcut");
            //}
            //else
            //{
            //    Console.WriteLine("Şehir Mevcut Değil");
            //}

            //Console.Write("lütfen Kullanıcı Adını Giriniz:  ");
            //string username = Console.ReadLine();
            //if (username != "admin")
            //{
            //    Console.Write("Bu Kullanıcı Adı Kabul Edilemez");
            //}
            //else
            //{
            //    Console.Write("Hoş Geldiniz");
            //}

            #endregion
            #region Mod İşlemleri
            //int number;
            //number = 26;
            //int result = number % 5;
            //Console.WriteLine(result);

            //Console.WriteLine("Lütfen 1.sayıyı giriniz");
            //int number1=int.Parse(Console.ReadLine());
            //Console.WriteLine("Lütfen 2.sayıyı giriniz");
            //int number2 = int.Parse(Console.ReadLine());
            //int result=number1%number2;
            //Console.Write("1.Sayının 2.sayıya bölümünden kalan:  " + result);

            //Console.WriteLine("lütfen sayı giriniz");
            //int number=int.Parse(Console.ReadLine());
            //if(number %2==0)
            //{
            //    Console.Write("Sayı Çifttir");
            //}
            //else
            //{
            //    Console.Write("Sayı Tekttir");
            //}
            #endregion
            #region Char Değikenler ile Karar Yapıları    
            //char team;
            //Console.Write("lütfen takım sembolünü giriniz:  ");
            //team=char.Parse(Console.ReadLine());
            //if(team =='g'|team=='G')
            //{
            //    Console.Write("Galatasaray");
            //}
            //if (team == 'f' | team == 'F')
            //{
            //    Console.Write("Fenerbahçe");
            //}
            //if (team == 'b' | team == 'B')
            //{
            //    Console.Write("Beşiktaş");
            //}
            #endregion
            #region Örnek Proje Uygulaması  
            //Console.WriteLine("***** C# Eğitim Kampı Restoranı *****");
            //Console.WriteLine();
            //Console.WriteLine("----------------------------");
            //Console.WriteLine("1- Ana Yemekler");
            //Console.WriteLine("2- Çorbalar");
            //Console.WriteLine("3- Pizzalar");
            //Console.WriteLine("4- İçecekler");
            //Console.WriteLine("5- Tatlılar");
            //Console.WriteLine("----------------------------");
            //Console.WriteLine();

            //string menuıtems;
            //Console.Write("Detayını görmek istediğiniz menü seçimi:  ");
            //menuıtems=Console.ReadLine();
            //if(menuıtems=="1")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("----------Ana Yemekler----------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Köri Soslu Tavuk");
            //    Console.WriteLine("2-Kızartma Tabağı");
            //    Console.WriteLine("3-Fasulye Pilav");
            //    Console.WriteLine("4-Fırında Somon");
            //    Console.WriteLine("5-Ptlıcan Musakka");
            //    Console.WriteLine("----------Ana Yemekler----------");
            //    Console.WriteLine();

            //}

            //if (menuıtems == "2")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("----------Çorbalar----------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Mercimek Çorbası");
            //    Console.WriteLine("2-Ezogeli Çorbası");
            //    Console.WriteLine("----------Çorbalar----------");
            //    Console.WriteLine();

            //}

            //if (menuıtems == "3")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("----------Pizzalar----------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Akdeniz Pizza");
            //    Console.WriteLine("2-Margeritha");
            //    Console.WriteLine("3-Tavuklu Pizza");
            //    Console.WriteLine("----------Pizzalar----------");
            //    Console.WriteLine();

            //}

            //if (menuıtems == "4")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("----------içecekler----------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Kola");
            //    Console.WriteLine("2-Ayran");
            //    Console.WriteLine("3-Su");
            //    Console.WriteLine("----------içecekler----------");
            //    Console.WriteLine();

            //}


            //if (menuıtems == "5")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("----------Tatlılar----------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Trileçe");
            //    Console.WriteLine("2-Kazandibi");
            //    Console.WriteLine("3-Sütlaç");
            //    Console.WriteLine("----------Tatlılar----------");
            //    Console.WriteLine();

            //}

            #endregion
            #region switch case 

            //Console.Write("lütfen ay girişi yapınız:  ");
            //int montnumber=int.Parse(Console.ReadLine());

            //switch(montnumber)
            //{
            //    case 1:Console.Write("ocak");break;
            //    case 2: Console.Write("şubat"); break;
            //    case 3: Console.Write("mart"); break;
            //    case 4: Console.Write("nisan"); break;
            //    case 5: Console.Write("mayıs"); break;
            //    case 6: Console.Write("haziran"); break;
            //    case 7: Console.Write("temmuz"); break;
            //    case 8: Console.Write("ağustos"); break;
            //    case 9: Console.Write("eylül"); break;
            //    case 10: Console.Write("ekim"); break;
            //    case 11: Console.Write("kasım"); break;
            //    case 12: Console.Write("aralık"); break;
            //    default:Console.Write("hatalı değer girişi");break;
            //}
            #endregion
            #region switc case hesap makinesi  

            int s1, s2, result;
            char symbol;
            Console.Write("1. Sayıyı Giriniz:  ");
            s1=int.Parse(Console.ReadLine());
            Console.Write("12. Sayıyı Giriniz:  ");
            s2 = int.Parse(Console.ReadLine());
            Console.Write("Lütfen yapamk istedğiniz işlemi giriniz:   ");
            symbol = char.Parse(Console.ReadLine());
            switch(symbol)
            {
                case '+':result=s1 + s2; Console.WriteLine("Toplam:" + result); break;
                    case'-':result = s1 - s2;Console.WriteLine("Fark:" + result); break;
                    case '*':result=s1 * s2; Console.WriteLine("Çarpma:" + result); break;
                    case '/':result=s1 / s2; Console.WriteLine("Bölme:" + result); break;
                default:Console.Write("Yapmak istediğiniz işlem hatalı!!");break;
            }
            #endregion
            Console.Read();
        }
    }
}
