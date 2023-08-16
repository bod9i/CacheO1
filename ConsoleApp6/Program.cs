using ChacheProvider;
using System.Diagnostics;

namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var cacheProvider = new CacheProvider<int>();

            var sw1 = Stopwatch.StartNew();
            cacheProvider.Add("1", 1);
            sw1.Stop();
            var sw2 = Stopwatch.StartNew();
            cacheProvider.Add("2", 2);
            sw2.Stop();
            var sw3 = Stopwatch.StartNew();
            cacheProvider.Add("3", 3);
            sw3.Stop();
            var sw4 = Stopwatch.StartNew();
            cacheProvider.Add("4", 4);
            sw4.Stop();

            var sw5 = Stopwatch.StartNew();
            var a = cacheProvider["1"];
            sw5.Stop();
            var sw6 = Stopwatch.StartNew();
            var b = cacheProvider["2"];
            sw6.Stop();
            var sw7 = Stopwatch.StartNew();
            var c = cacheProvider["3"];
            sw7.Stop();

            var sw8 = Stopwatch.StartNew();
            cacheProvider.Add("5", 5);
            sw8.Stop();

            Console.WriteLine($"Execution time (ms) of adding element (key = \"1\"): {sw1.ElapsedTicks}");
            Console.WriteLine($"Execution time (ms) of adding element (key = \"2\"): {sw2.ElapsedTicks}");
            Console.WriteLine($"Execution time (ms) of adding element (key = \"3\"): {sw3.ElapsedTicks}");
            Console.WriteLine($"Execution time (ms) of adding element (key = \"4\"): {sw4.ElapsedTicks}");
            Console.WriteLine($"Execution time (ms) of selecting element (key = \"1\"): {sw5.ElapsedTicks}");
            Console.WriteLine($"Execution time (ms) of selecting element (key = \"2\"): {sw6.ElapsedTicks}");
            Console.WriteLine($"Execution time (ms) of selecting element (key = \"3\"): {sw7.ElapsedTicks}");
            Console.WriteLine($"Execution time (ms) of adding element (key = \"5\"): {sw8.ElapsedTicks}");
        }
    }
}