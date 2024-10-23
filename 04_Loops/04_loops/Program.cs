using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region for döngüsü  

            // döngüler 1+2+3+4+5+6
            // 3+3=6+4=10+5=15+6=21

            //for(x;y;z)
            //x:başlangıç
            //y:bitiş
            //z:artış-azalış

            //int i;
            //for(i=1;i<=10;i++)
            //{
            //    Console.WriteLine(i+ ".C# Eğitim Kampı");
            //}

            //for(int i=1;i<=20;i++)
            //{
            //    Console.WriteLine(i);
            //}

            //for(int i=3; i<=50;i+=3)
            //{
            //    Console.WriteLine(i);
            //}

            //Console.Write("lütfen ekrana yazılmasını istediğiniz adedi giriniz:");
            //int finisvalue=int.Parse(Console.ReadLine());
            //for(int i=1; i<=finisvalue; i++)
            //{
            //    Console.WriteLine("Yaşasın Cumhuriyet");
            //}

            #endregion
            #region for döngüsü ile karar yapıları   

            //for(int i = 0;i<=100;i++)
            //{
            //    if(i%5==0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}
            //int totalvalue = 0;
            //for (int i = 0; i<=10;i++)
            //{
            //    totalvalue += i;
            //}
            //Console.WriteLine(totalvalue);

            //int totalvalue = 0;
            //for(int i = 1;i<20;i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        totalvalue += i;
            //        Console.WriteLine(i);
            //    }
            //}
            //Console.WriteLine("------");
            //Console.WriteLine(totalvalue);

            //int count = 0;
            //for (int i = 1; i <= 50; i++)
            //{
            //    if (i % 7 == 0)
            //    {
            //        count++;
            //    }
            //}
            //Console.WriteLine(count);


            //1-2-4-6-8-16-...

            //int bacterium = 1;
            //for(int i=1; i<=24; i++)
            //{
            //    bacterium *= 2;
            //    Console.WriteLine(i + ".Saat Sonunda: " + bacterium);
            //}
            #endregion
            #region while döngüsü

            //while(şart)
            //{
            //işlemler
            //}


            //int i = 1;
            //while(i<=10)
            //{
            //    Console.WriteLine("Merhaba Döngüler");
            //    i++;
            //}

            //int i = 1;
            //while(i<=10)
            //{
            //    if(i%3==0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //    i++;
            //}

            //int i = 1;
            //int sum = 0;
            //while (i <= 10)
            //{
            //    sum += i;
            //    i++;
            //}
            //Console.WriteLine(sum);


            #endregion
            #region örnek sınav sorusu
            ////klavyeden girilen 3 basamaklı sayının basamakları toplamını hesaplayan kodu yazınız:

            //Console.Write("Sayıyı giriniz:");
            //int number=int.Parse(Console.ReadLine());
            //int ones, tens, hunders;
            //int sum;
            //ones = number % 10;
            //hunders = number / 100;
            //tens = (number % 100 )/ 10;
            //sum=ones+tens+hunders;
            //Console.WriteLine(sum);
            #endregion
            Console.Read();
        }

    }
}