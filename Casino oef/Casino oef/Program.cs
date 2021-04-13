using System;

namespace Casino_oef
{
    class Program
    {
              static void Main(string[] args)
              {
            Console.WriteLine("Casino!");
            Console.WriteLine(" user guess which number computer will thrown between 0 and 6?");
            Console.WriteLine();
                 Console.WriteLine("Give 1st number between 0 and 6?");
            int x = int.Parse(Console.ReadLine());
            Random number = new Random();
            int casoninum1 = number.Next(6);
            if (x == casoninum1)
            {
                Console.WriteLine("Give 2nd number between 0 and 6?");
                int y = int.Parse(Console.ReadLine());
                int casoninum2 = number.Next(6);
                if (y == casoninum2)
                {
                    Console.WriteLine("Give 3rd number between 0 and 6?");
                    int z = int.Parse(Console.ReadLine());
                    int casoninum3 = number.Next(6);
                    if (z == casoninum3)
                    {
                        Console.WriteLine("Congrats, You won");
                    }
                    else
                    {
                        Console.WriteLine("you loose");
                    }
                }
                else
                {
                    Console.WriteLine("you loose");
                }
            }
            else
            {
                Console.WriteLine("you loose");
            }
            
        }


    }
}
