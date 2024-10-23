using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace _08_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region  Void Metotlar

            //geriye değer döndürmeyen metotlar
            //customer--> listele,ekle,sil,güncelle
            //void

            //void customerslist()
            //{
            //    Console.WriteLine("Ali Yıdlız");
            //    Console.WriteLine("Ayşe Yıldız");
            //    Console.WriteLine("Hakan Öztürk");
            //    Console.WriteLine("Merve Çınar");
            //}
            //customerslist();
            //customerslist();
            //customerslist();
            //customerslist();


            //void sum ()
            //{
            //    int x = 1;
            //    int y = 2;
            //    int z = x + y;
            //    Console.WriteLine(z);
            //}
            //sum();


            #endregion
            #region Geriye Değer Dödürmeyen String  Parametreli Metotlar  

            //void WriteMethod(string customerName)
            //{
            //    Console.WriteLine(customerName);
            //}
            //WriteMethod("Mehmet Yıldırım");


            //void custmoercard(string name,string surname)
            //{
            //    Console.WriteLine("Müşteri: " + name + " " + surname);
            //}
            //custmoercard("Ömer Faruk", "Adan");
            #endregion
            #region Geriye Değer Döndürmeyen İnt Parametreli Metotlar
            //void sum(int s1,int s2,int s3)
            //{

            //    int result=s1+s2+s3; 
            //    Console.WriteLine(result);
            //}
            //sum(4,5,6);
            #endregion
            #region Geriye Değer Döndüren Metotlar
            //string customername()
            //{
            //    return "Buse Yıldız";
            //}
            //customername();
            //string studentcard()
            //{
            //    string name = "ali";
            //    string surname = "kaya";
            //    return name + " " + surname;
            //}
            //Console.WriteLine(studentcard());
            #endregion
            #region Geriye Değer Döndüren String Parametreli Metotlar
            // string countrycard(string countryname,string capital,string flagcolor)
            // {
            //     string cardinfo = "Ülke: " + countryname + " \n"+"Başkent: " + capital +"\n"+"Bayrak Rengi: " + flagcolor;
            //     return cardinfo;
            // }
            // Console.Write("Ülke Adını Giriniz:");
            //string x=Console.ReadLine();
            // Console.Write("Ülkenin Başkentini Giriniz:");
            // string y=Console.ReadLine();
            // Console.Write("Ülkenin Bayrak Renklerini Giriniz:");
            // string z=Console.ReadLine();
            // Console.WriteLine();
            // Console.WriteLine("---------------------");
            // Console.WriteLine();
            // Console.WriteLine(countrycard(x,y,z));
            #endregion
            #region Geriye Değer Döndüren İnt Parametreli Metotlar;
            //int sum(int number1,int number2)
            //{
            //    int result=number1 + number2;
            //    return result;
            //}
            //Console.WriteLine(sum(12, 15));
            #endregion
            #region Örnek Uygulama
            string examresult(string student, int exam1, int exam2, int exam3)
            {
                int result = (exam1 + exam2 + exam3) / 3;
                if (result >= 50)
                {
                    return student + " İsimli Öğrenci Sınavı Geçti " + " Ortalama: " + result;
                }
                else
                {
                    return student + " İsimli Öğrenci Başarısız Oldu " + " Ortalama: " + result;
                }
            }
            Console.WriteLine(examresult("Ali", 25, 41, 81));
            Console.WriteLine(examresult("Ayşe", 36, 88, 33));
            #endregion
            Console.Read();
        }
    }
}
