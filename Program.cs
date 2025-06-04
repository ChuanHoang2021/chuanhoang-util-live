using System;
using System.Threading.Tasks;

namespace ChuanHoangUtilLive
{
    class Program
    {
        static async Task Main()
        {
            byte i = 0;
            do
            {
                Console.Write($"\rLoading something...{i}%...in other thread!");
                await Task.Delay(100);
                i++;
            }
            while (i < 100);
            Console.WriteLine();
            Console.WriteLine("End of main thread.");
        }
    }
}