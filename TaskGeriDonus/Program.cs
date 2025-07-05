using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TaskGeriDonus
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int sonuc = Task.Run(Topla).Result;
            Console.WriteLine("Sonuc {0}", sonuc);
            Console.ReadKey();

        }
        public static Task<int> Topla() //BURAYA VOİD YAZIP YA DA  TASK VE ALTA RETURN YAZMAKLA Bİ FARKI YOK
        {
            int sonuc = 0;
            for (int i = 0; i < 10; i++)
            {
                Thread.Sleep(500);
                sonuc += i;
            }
            // Console.WriteLine("Sonuc: {0}", sonuc);

            return Task.FromResult(sonuc);
        }

        public static void Carp()
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
