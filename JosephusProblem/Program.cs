using System;

namespace JosephusProblem
{
    class Program
    {
        static int josephus(int n, int k)
        {
            if (n == 1)
                return 1;
            else
                return (josephus(n - 1, k) + k - 1) % n + 1;
        }

        public static void Main()
        {
            Console.Write("Enter the number of people: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the killing interval: ");
            int k = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"The surviving person is {josephus(n, k)}.");
            Console.ReadKey();
        }
    }
}
