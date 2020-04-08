using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the number of row: ");

            string m = Console.ReadLine();
            int n = int.Parse(m);
            DrawPyramid(n);
            Console.ReadLine();

        }

        static void DrawPyramid(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                for (int j = i; j <= n; j++)
                {
                    Console.Write("  ");
                }
                for (int k = 1; k <= 2 * i - 1; k++)
                {
                    Console.Write("*" + " ");
                }
                Console.WriteLine();
            }
            for (int i = 1; i <= n - 1; i++)
            {
                for (int j = i + 1; j > 0; j--)
                {
                    Console.Write("  ");
                }
                for (int k = 2 * (n - i) - 1; k > 0; k--)
                {
                    Console.Write("*" + " ");
                }
                Console.WriteLine();
            }

        }

    }
}