using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ControlStructures
{
   
    class Program
    {
        static void Main(string[] args)
        {
            bool isGold = true;
            float price;
            if (isGold)
            {
                price = 19.95f;
            }
            else {
                price = 21.24f;
            }
             price = (isGold)? 19.95f : 21.24f;



            var SAN = season.Autumn;

            switch (SAN)
            {
                case season.Autumn:
                    Console.WriteLine("very HOT");

                    break;

                case season.Spring:
                    Console.WriteLine("very chilly");
                    break;

                case season.Winter:
                    Console.WriteLine("very chilly");

                    break;

                case season.Fall:
                    Console.WriteLine("very chilly");

                    break;


            }
            Console.ReadKey();
        }
    }
}
