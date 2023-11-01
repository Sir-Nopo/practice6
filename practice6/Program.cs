using System;

namespace practice6
{
    class Program
    {
        //MohammadRezaFatahi
        //tamrin6
        static void Main(string[] args)
        {
        first:
            Console.WriteLine("adad mored nazar ra baraye peyda kardan donbale vared konid :");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = 0;
            for (int i = 1; i <= a; i++)
                b += i;

            Console.WriteLine(b);

            Console.WriteLine(" ");
            Console.WriteLine("aya mikhay edame bedi?! (y/n)");
            string m = Console.ReadLine();
            if (m == "y")
            {
                goto first;
            }
            else
            {
                Console.WriteLine("khodafez");
            }
        }
    }
}
