using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SockMerchant
{
    class Program
    {
        // Complete the sockMerchant function below.
        static int sockMerchant(int n, int[] ar)
        {
            var pairs = 0;
            var colors = ar.Distinct();

            foreach (var color in colors)
            {
                var colorCount = ar.Count(c => c == color);
                if (colorCount > 0)
                    if (colorCount % 2 == 0)
                        pairs += colorCount / 2;
                    else
                        pairs += (colorCount - 1) / 2;
            }

            return pairs;
        }

        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            int[] ar = Array.ConvertAll(Console.ReadLine().Split(' '), arTemp => Convert.ToInt32(arTemp));
            int result = sockMerchant(n, ar);

            Console.WriteLine(result.ToString());

            Console.ReadKey();
        }
    }
}
