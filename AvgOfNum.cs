using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    class AvgOfNum
    {
        static void Main(string[] args)
        {
            int num = 12389;
            int sum = 0;
            int avg = 0;
            int count = 0;
            while (num > 0)
            {
                int digit = num % 10;
                count++;
                sum = sum + digit;
                num /= 10;

            }
            avg = sum / count;

            Console.WriteLine(avg);
        }
    }
}
