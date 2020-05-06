using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepeatedString
{
    class Program
    {
        // Complete the repeatedString function below.
        static long repeatedString(string s, long n)
        {
            var strLength = s.Length;
            Math.DivRem(n , strLength, out long remainder);

            var countA = s.Count(c => c == 'a');
            var multiplier = n - remainder;
            var countARem = 1;
            
            if (remainder == 0)
                countARem = 0;
            else
                countARem = s.Substring(0, (int)remainder).Count(c => c == 'a');

            return (multiplier / strLength * countA) + countARem;
        }

        static void Main(string[] args)
        {
            string s = Console.ReadLine();

            var n = Convert.ToInt64(Console.ReadLine());

            long result = repeatedString(s, n);

            Console.WriteLine(result);

            Console.ReadLine();
        }
    }
}
