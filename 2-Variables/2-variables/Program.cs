using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Double Değişkenler
            //double number;
            //number = 4.85;
            //Console.WriteLine(number);


            //Console.WriteLine("**** Fiyat Listesi *****");
            //Console.WriteLine();
            //double appleprice, orangeprice, strawberryprice, potatoprice, tomatoprice;
            //appleprice = 14.85;
            //orangeprice = 20.95;
            //strawberryprice = 45;
            //potatoprice = 9.74;
            //tomatoprice = 6.88;
            //Console.WriteLine("----- Elma Birim Fiyatı:" + appleprice);
            //Console.WriteLine("----- Elma Birim Fiyatı:" + orangeprice);
            //Console.WriteLine("----- Elma Birim Fiyatı:" + strawberryprice);
            //Console.WriteLine("----- Domates Birim Fiyatı:" + tomatoprice);
            //Console.WriteLine("----- Patates Birim Fiyatı:" + potatoprice);
            //Console.WriteLine();
            //Console.WriteLine();

            //double applegram, orangegram, strawberrygram, potatogram, tomatogram;
            //applegram = 1.245;
            //orangegram = 2.650;
            //strawberrygram = 0.750;
            //potatogram = 4.859;
            //tomatogram = 3.745;

            //double appletotalprice = applegram * appleprice;
            //double orangetotalprice = orangegram * orangeprice;
            //double strawberrytotalprice = strawberrygram * strawberryprice;
            //double potatototalprice = potatogram * potatoprice;
            //double tomatototalprice = tomatogram * tomatoprice;

            //Console.WriteLine("Alınan Ürün: Elma - " + "Birim Fiyat:" + appleprice + " - Gramaj:" + applegram + " - Toplam Tutar:" + appletotalprice + "TL");
            //Console.WriteLine("Alınan Ürün: Portakal - " + "Birim Fiyat:" + orangeprice + " - Gramaj:" + orangegram + " - Toplam Tutar:" + orangetotalprice + "TL");
            //Console.WriteLine("Alınan Ürün: Çilek - " + "Birim Fiyat:" + strawberryprice + " - Gramaj:" + strawberrygram + " - Toplam Tutar:" + strawberrytotalprice + "TL");
            //Console.WriteLine("Alınan Ürün: Patates - " + "Birim Fiyat:" + potatoprice + " - Gramaj:" + potatogram + " - Toplam Tutar:" + potatototalprice + "TL");
            //Console.WriteLine("Alınan Ürün: Domates - " + "Birim Fiyat:" + tomatoprice + " - Gramaj:" + tomatogram + " - Toplam Tutar:" + tomatototalprice + "TL");

            //Console.WriteLine();
            //Console.WriteLine("--------------------------------------------");
            //double totalprice = appletotalprice + orangetotalprice + strawberrytotalprice + potatototalprice + tomatototalprice;
            //Console.WriteLine("Toplam Tutar:" + totalprice + "TL");
            #endregion

            #region Char Değişkenler
            //ABCDEFGH
            //DEF..
            //TOPLANTI SAAT 20:00' DE
            //char symbol;
            //symbol = 'a';
            //Console.WriteLine(symbol);
            #endregion

            #region Klavyeden Veri Girişleri

            //Console.WriteLine("**** CSharp Hava Yolları Yolcu Bilgisi ****");
            //Console.WriteLine();
            //string passengername, passengersurname, passengerdistrict, passengercity, passengerage, passengeridentitynumber;

            //Console.Write("Yolcu Adı: ");
            //passengername = Console.ReadLine();
            //Console.Write("Yolcu Soyadı: ");
            //passengersurname = Console.ReadLine();
            //Console.Write("İlçe Bilgisi: ");
            //passengerdistrict = Console.ReadLine();
            //Console.Write("Şehir Bilgisi: ");
            //passengercity = Console.ReadLine();
            //Console.Write("Yolcu Yaş: ");
            //passengerage = Console.ReadLine();
            //Console.Write("Yolcu TC Kimlik No: ");
            //passengeridentitynumber = Console.ReadLine();
            //Console.WriteLine();
            //Console.WriteLine("****************************");
            //Console.WriteLine("Yolcu TC Kimlik No:" + passengeridentitynumber + "Yolcu Ad Soyad:" + passengername + " " + passengersurname + " " + 
            //    passengerdistrict + " / " + passengercity + " " + passengerage);
            #endregion

            #region Klavyeden Tam Sayı Girişleri ve Dönüşleri

            //int shoesprice, computerprice, chairprice, tvprice;
            //shoesprice = 1000;
            //computerprice = 20000;
            //chairprice = 5000;
            //tvprice = 12000;

            //int shoescount, computercount, chaircount, tvcount;
            //Console.Write("lütfen aldığın ayakkabı sayısını giriniz:");
            //shoescount=int.Parse(Console.ReadLine());
            //Console.Write("lütfen aldığın bilgisayar sayısını giriniz:");
            //computercount = int.Parse(Console.ReadLine());
            //Console.Write("lütfen aldığın sandalye sayısını giriniz:");
            //chaircount = int.Parse(Console.ReadLine());
            //Console.Write("lütfen aldığın televizyon sayısını giriniz:");
            //tvcount = int.Parse(Console.ReadLine());

            //int totalprice = shoescount * shoesprice + computerprice * computercount + chairprice * chaircount + tvprice * tvcount;
            //Console.WriteLine();
            //Console.WriteLine("Toplam Ödemeniz Gereken Tutar:" + totalprice);

            #endregion

            #region Klavyeden Ondalıklı Sayı İşlemleri
            //double exam1, exam2, exam3, result;
            //Console.Write("lütfen 1. Sınav Notunuzu Giriniz:");
            //exam1=double.Parse(Console.ReadLine());
            //Console.Write("lütfen 3. Sınav Notunuzu Giriniz:");
            //exam2 = double.Parse(Console.ReadLine());
            //Console.Write("lütfen 3. Sınav Notunuzu Giriniz:");
            //exam3 = double.Parse(Console.ReadLine());
            //result=(exam1 + exam2 + exam3)/3;
            //Console.WriteLine();
            //Console.WriteLine("Sınav Ortalamanız:" + result);
            #endregion

            #region Klavyeden Karakter Girişleri

            char gender;
            Console.Write("lütfen Karakter Giriniz:");
            gender=char.Parse(Console.ReadLine());
            Console.WriteLine("Seçtiğiniz Cinsiyet:" + gender);

            #endregion
            Console.Read();
        }
    }
}
