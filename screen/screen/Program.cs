using System;

namespace screen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string soz = ("programmist");
            int count = 0;
            foreach (char item in soz )
            {
                if (item == 'a')
                {
                    count++;

                }
            }


            {
                Console.WriteLine("a reqemlerinin sayi {0}", +count);
            }
        }
    }
}
