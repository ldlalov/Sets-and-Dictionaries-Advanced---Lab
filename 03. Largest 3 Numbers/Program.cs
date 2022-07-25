using System;
using System.Linq;

namespace _03._Largest_3_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).OrderByDescending(x => x).ToArray();
            int n = 0;
            if (numbers.Length > 3)
            {
                n = 3;
            }
            else
            {
                n = numbers.Length;
            }
            int[] sored = new int[n];
            for (int i = 0; i < sored.Length; i++)
            {
                sored[i] = numbers[i];
            }
            Console.WriteLine(string.Join(' ',sored));
        }
    }
}
