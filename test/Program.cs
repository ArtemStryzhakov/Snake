using System;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 3;
            solve s = new solve();
            int w=s.Solve(a, b);
            Console.WriteLine(w);
        }
    }
}
