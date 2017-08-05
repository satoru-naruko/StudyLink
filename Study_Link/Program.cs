using System;
using System.Linq;

namespace Study_Link
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

            int[] list = new int[] { 1, 23, 4, 56, 78, 9, 999 };

            var tmp = list.Where(x => x >= 10).Select(x => x.ToString()+"naruko");

            {
                Console.WriteLine(test);
            }
        }
    }
}
