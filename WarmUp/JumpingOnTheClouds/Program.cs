using System;

namespace JumpingOnTheClouds
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            int[] c = Array.ConvertAll(Console.ReadLine().Split(' '), cTemp => Convert.ToInt32(cTemp));

            int result = jumpingOnClouds(c, n);

            Console.WriteLine(result);
            Console.ReadLine();
        }

        private static int jumpingOnClouds(int[] c, int n)
        {
            int cursor = 0;
            int jumps = -1;

            do
            {
                if (cursor + 2 < n && c[cursor + 2] == 0)
                    cursor += 2;
                else
                    cursor += 1;

                jumps++;
            }
            while (cursor < n);

            return jumps;
        }
    }
}
