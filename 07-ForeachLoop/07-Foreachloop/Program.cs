using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Foreachloop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region foreach döngüsü  

            //foreach(1;2;3;4)
            //1:değişken türü
            //2:değişken adı
            //3:ın
            //4:liste,koleksiyon,dizi

            //string[] cities = { "milano", "roma", "budapeşte", "ankara", "istanbul", "varşova" };
            //foreach (string x in cities)
            //{
            //    Console.WriteLine(x);
            //}

            //int[] numbers = { 45, 78, 985, 635, 74, 11, 22, 33, 41, 205, 6578, 10394 };
            //foreach (int i in numbers)
            //{
            //    Console.WriteLine(i);
            //}

            //int[] numbers = { 45, 78, 985, 635, 74, 11, 22, 33, 41, 205, 6578, 10394 };

            //    foreach (int j in numbers)
            //    {
            //        if (j % 2 == 0)
            //        {
            //            Console.WriteLine(j);
            //        }
            //    }

            //int[] numbers = { 45, 78, 985, 635, 74, 11, 22, 33, 41, 205, 6578, 10394 };
            //int total = 0;
            //foreach (int i in numbers)
            //{
            //    total += i;
            //}
            //Console.WriteLine(total);

            //List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 8 };
            //foreach (int i in numbers)
            //{
            //    Console.WriteLine(i);
            //}

            //string word = "merhaba";
            //foreach (char c in word)
            //{
            //    Console.WriteLine(c);
            //}
            #endregion

            #region Örnek Sınav Uygulaması  
            Console.WriteLine("***** C# Eğitim Kampı Sınav Uygulaması *****");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            //Sınıftaki öğrenci sayısını kullanıcıdan alma
            Console.WriteLine("------------------------------");
            Console.Write("Sınıfınızda Kaç Öğrenci Var: ");
            int studentCount=int.Parse(Console.ReadLine());
            Console.WriteLine("------------------------------");

            string[] studentName = new string[studentCount];
            double[] studentExamAvg =new double[studentCount];
            for (int i = 0; i < studentCount; i++)
            {
                Console.Write($"{i + 1}. öğrencinin ismini giriniz: ");
                studentName[i] = Console.ReadLine();
                double totalExamResult = 0;

                //Her öğrenci için 3 sıanv notu giriişi
                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"{studentName[i]} isimli öğrencinin {j + 1}. sınav notunu girin:");
                    double value = double.Parse(Console.ReadLine());
                    totalExamResult += value;//notları topluyoruz.
                }
                studentExamAvg[i] = totalExamResult / 3;
            }
            //sınav ortalamaları:
            Console.WriteLine();
            Console.WriteLine("------------------------------");
            Console.WriteLine();
            for (int i = 0; i < studentCount; i++)
            {
                Console.WriteLine($"{studentName[i]} adlı öğrencinin ortalaması: {studentExamAvg[i]}");

                //öğrencilerin ortalması ve geçip kalma durumları:
                if (studentExamAvg[i]>=50)
                {
                    Console.WriteLine();
                    Console.WriteLine($"{studentName[i]} adlı öğrenci dersi geçti");
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine($"{studentName[i]} adlı öğrenci dersten kaldı");
                }

            }

            #endregion
            Console.Read();
        }
    }
}
