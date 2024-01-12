using System;

namespace ortalama_hesaplama
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Fibonacci serisindeki rakamların ortalamasının alınacağı derinliği giriniz :  ");
            int derinlik = int.Parse(Console.ReadLine());
            FibonacciSerisiOrtalama(derinlik);


        }
        private static void FibonacciSerisiOrtalama(int derinlik)
        {
            int toplam = 0;
            double ortalama = 0; 

            for (int i = 0; i < derinlik; i++)
            {
                Console.WriteLine($"Fibonacci {i} : " + Fib(i));
                toplam += Fib(i);
            }

            ortalama = Convert.ToDouble(toplam) / Convert.ToDouble(derinlik);
            Console.WriteLine("Fİbonacci seri sayılarının ortalaması : " + ortalama);

        }
        private static int Fib(int sayi)
        {
            if(sayi == 0)
                return 0;
            if(sayi == 1)
                return 1;
            return Fib(sayi - 1) + Fib(sayi - 2);
        }
    }
}
