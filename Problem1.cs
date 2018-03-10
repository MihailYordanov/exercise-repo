using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("{0}\\{1}/{0}", new string('*', i + 1), new string('-', (n - 1) * 2 + 1 - 2 * i), new string('*', i + 1));
            }

            for (int i = 0; i < n / 3; i++)
            {
                Console.WriteLine("|{0}\\{1}/{0}|", new string('*', n / 2 + i), new string('*', n - i * 2), new string('*', n / 2 + i));
            }

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("{0}\\{1}/{0}", new string('-', i + 1), new string('*', (n - 1) * 2 + 1 - 2 * i), new string('-', i + 1));
            }
        }
    }
}
