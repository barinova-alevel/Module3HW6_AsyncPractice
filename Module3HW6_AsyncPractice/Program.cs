using System;
using System.Threading.Tasks;

namespace Module3HW6_AsyncPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Task t = Task.Factory.StartNew(() =>
            {
                FibonacciSeries(135);
            });
            t.Wait(10000);
        }

        public static int FibonacciSeries(int n)
        {
            if (n == 0) return 0;
            if (n == 1) return 1;
            return FibonacciSeries(n - 1) + FibonacciSeries(n - 2);
        }
    }
}
