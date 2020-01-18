using System;

namespace sprint2whileloops
{
    class Program
    {
        static void Main(string[] args)
        {
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
        }
    }
}
