using System;
using System.Collections.Generic;

namespace sprint2whileloops
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
            int count = 1;
            while (count < 11)
            {
                Console.WriteLine("The count is {0}", count);
                count++;
            }

            string porridgeTemperature;
            do
            {
                Console.WriteLine("Please Specify porridge temperature.");
                Console.WriteLine("Type \"help\" to list options");
                porridgeTemperature = Console.ReadLine();

                if (porridgeTemperature.Equals("help"))
                {
                    Console.WriteLine("Options: too hot, too cold, just right ");
                }
            } while (porridgeTemperature.Equals("help"));


            string atmPin;
            int counter = 0;
            do
            {
                Console.WriteLine("Please enter your ATM pin");
                atmPin = Console.ReadLine();

                if (atmPin == "1234")
                {
                    Console.WriteLine("You entered the correct Pin!");
                }

                if (counter == 2)
                {
                    Console.WriteLine("You entered the incorrect Pin 3 times!!!");
                }
               
                counter++;

            } while (atmPin != "1234" && counter != 3);

            */


            int lowerNumber = 0;
            int higherNumber = 0;

            Console.WriteLine("Please enter a lower number");
            string inputOne = Console.ReadLine();
            lowerNumber = Convert.ToInt32(inputOne);

            Console.WriteLine("Please enter a higher number");
            string inputTwo = Console.ReadLine();
            higherNumber = Convert.ToInt32(inputTwo);

            Console.WriteLine(lowerNumber);
            Console.WriteLine(higherNumber);

            int temp = 0;

            for (int count = 1; count <= lowerNumber; count++)
            {
                temp += count;
                Console.WriteLine(temp);
            }




        }
    }
}
