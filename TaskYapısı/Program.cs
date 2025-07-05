using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TaskYapısı
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Topla();
            // Carp();

            // Thread toplamaIslemi = new Thread(new ThreadStart(Topla));
            // Thread carpmaIslemi = new Thread(new ThreadStart(Carp));
            //toplamaIslemi.Start();
            // carpmaIslemi.Start();
            // new Thread(new ThreadStart(Topla)).Start();



            //Task.Run(() =>
            //{
            //    Topla(); Console.WriteLine("İşlem Bitti");
            //});

            //Task.Run(() => Carp()).Wait();

            //Console.WriteLine("Toplama Başlatılıyor....");
            //Task.Run(() => Topla()).Wait();

            //Console.WriteLine("Çarpma Başlatılıyor.... ");

            //Task.Run(() =>
            //{
            //    Carp(); Console.WriteLine("İşlem Bitti");
            //});

            //Console.WriteLine("Görevler Başlatıldı");

            // thread leri büyü k işlerde kullanıyoruz(uzun işlerde tek seferlikse task kulanırız



            Console.WriteLine("Toplama Başlatılıyor....");
            Task.Run(() => Topla()).ContinueWith(x => Carp());
            Task.Run(() => Carp()).ContinueWith(x => Topla()).ContinueWith(x => Carp());
            Console.WriteLine("Görevler Başlatıldı");


            Console.ReadKey();
        }

        public static void Topla()
        {
            int sonuc = 0;  
            for(int i =0; i < 10; i++)
            {
                Thread.Sleep(500);
                sonuc += i;
            }
            Console.WriteLine("Sonuc: {0}", sonuc);
        }

        public  static void Carp()
        {
            int sonuc = 1;
            for (int i = 1; i < 10; i++)
            {
                Thread.Sleep(500);
                sonuc *= i;
            }
            Console.WriteLine("Sonuc: {0}", sonuc);
        }

    }



}
