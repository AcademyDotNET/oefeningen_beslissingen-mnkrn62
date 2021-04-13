using System;

namespace Calculate_BMI_Oef
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" User BMI!");

            Console.WriteLine("Weight in Kg");

            double weight = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Height in m");
            double height = Convert.ToDouble(Console.ReadLine());


            double BMI;
            BMI = (weight / Math.Sqrt (height) );


            Console.WriteLine($"BMI¨: {Math.Round(BMI)}");

           if (BMI < 18.5)

            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"you are underweight");
            }
           else if ((18.5 > BMI) || (BMI < 24.9))
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"your weight is normal");
            }
           else if ((25 > BMI) || (BMI < 29.9))
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine($"overweight. You are not really at risk, but you should not put on weight");
            }
           else if ((30 > BMI) || (BMI < 39.9))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Obesity.Increased risk of all kinds of conditions such as diabetes, heart disease and back problems. You should lose 5 to 10 kg.");
            }
            else if (BMI > 40)
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine($"severe obesity.You need to lose weight urgently because your health is in danger or you entered your height or weight in the wrong unit.");
            }
        }
    }
}
