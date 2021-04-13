using System;

namespace Enum_Season_oef
{
    class Program
    {
        enum Seasons { Winter, Lente, zommer, Herfst };

        static void Main(string[] args)
        {
            Console.WriteLine(" User Enter a Month Number?");
            int months;  //this variable use to ask from user month number
            months = int.Parse(Console.ReadLine());
            Seasons seasons; // this variable use for enum i.e(winter ,lente,zomer,herfst)
            switch (months)
            {
                case 1:
                case 2:
                case 3:
                    seasons = Seasons.Winter;
                    break;
                case 4:
                case 5:
                case 6:
                    seasons = Seasons.Lente;
                    break;
                case 7:
                case 8:
                case 9:
                    seasons = Seasons.zommer;
                    break;
                case 10:
                case 11:
                case 12:
                    seasons = Seasons.Herfst;
                    break;
                default:
                    seasons = Seasons.zommer;
                    break;
            }

            if (seasons == Seasons.Winter)

            {
                Console.WriteLine("accounding to number your season is winter");
            }
            else if (seasons == Seasons.Lente)
            {
                Console.WriteLine("accounding to number your season could be lente");

            }
            else if (seasons == Seasons.zommer)
            {
                Console.WriteLine("accounding to number your season is Zommer");
            }
            else
               
            {
                Console.WriteLine("accounding to number your season is Herfst");
            }

        }
    }
}
