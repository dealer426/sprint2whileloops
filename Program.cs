using System;

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

            int numOne = 0;

            Console.WriteLine("Please enter a number to add all numbers");
            string input = Console.ReadLine();
            numOne = Convert.ToInt32(input);

            for (int i = numOne; i < numOne; i--)
            {
                Console.WriteLine(i);
            }

            for (int count = 1; count <= numOne; count++)
            {
                Console.WriteLine("Count is " + count);
            }




        }
    }
}
