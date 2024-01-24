using System;
using System.Threading;

namespace Stopwatch
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {

            Console.Clear();
            Console.WriteLine(" (S) = Segundos -> 10s -> 10 segundos \n (M) = Minutos -> 1m - 1 minuto \n (0) = Sair");
            Console.WriteLine(" ");
            Console.WriteLine("Quanto tempo deseja contar? ");

            string data = Console.ReadLine().ToLower();
            Console.WriteLine(data);


        }

        static void Start(int time)
        {
            int currentTime = 0;

            while (currentTime != time)
            {
                Console.Clear();
                currentTime++;
                Console.WriteLine(currentTime);
                Thread.Sleep(1000);
            }

            Console.Clear();
            Console.WriteLine("Stopwatch finalizado... Retornando para o menu");
            Thread.Sleep(2000);
        }
    }
}
