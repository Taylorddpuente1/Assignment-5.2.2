// Print the first n natural number using recursion

using System.IO;

namespace MyRecursion
{
    internal class Program
    {
       static void Main(string[] args )
        {
            Print1toN(10);
            Console.ReadKey();
        }
        static int Add(int i, int j)
        {
            return i + j;
        }
        static void Print(int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(i);
            }
        }
        static void Print1toN(int n)
        {
           if (n>0)
            {
                Print1toN(n - 1);
                Console.WriteLine(n);
            }

            }
        }
    }

