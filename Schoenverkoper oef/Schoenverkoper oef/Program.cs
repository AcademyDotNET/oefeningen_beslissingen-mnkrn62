using System;

namespace Schoenverkoper_oef
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("shoe salesMan");
            int x; // cost of one shoe pair is 20 euros.
            int y; // cost of above 9 shoes pair is 10 euros.
            int z; // numbers of shoes pairs user wants to buy.
            int d; // numbers of shoes above 9 pairs.
            Console.WriteLine("How many pairs of shoes you want to buy?");
            z = int.Parse(Console.ReadLine());

            x = 20 * z;
            y = 10 * z;
            d = z - 9;

            if (z <= 9)
            {
                Console.WriteLine(z + " shoes cost " + z + " * 20 = " + x + " euros");
            }
            else
            {
                Console.WriteLine(z + " shoes cost " + " 9 * 20  + " + d + " * 10 = " + ((9 * 20) + (d * 10)) + " euros");
            }
            Console.WriteLine("********************************************************************************************************");
            int a; //number of pairs cahier tell on discount does not apply
            int b; //numbers of pairs on which discount apply
            Console.WriteLine("Cashier please tell how many shoes the discount does not apply to?");
            a = int.Parse(Console.ReadLine());
            b = z - a;
            Console.WriteLine(z + " shoes cost " + a + " * 20  + " + b + " * 10 = " + ((a * 20) + (b * 10)) + " euros");

        }
    }
}









