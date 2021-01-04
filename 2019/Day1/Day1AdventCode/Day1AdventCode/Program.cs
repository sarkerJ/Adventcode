using System;
using System.Collections.Generic;
using System.IO;

namespace Day1AdventCode
{
   public class Program
    {
        static void Main(string[] args)
        {
            string[] listOfModules = File.ReadAllLines(@"C:\Users\saadi\OneDrive\Desktop\Sparta Global\Adventofcode.com_puzzles\2019\Day1\SpacecraftModules.txt");
            List<int> listOfIntegers = new List<int>();

            foreach (var item in listOfModules)
            {
                if(int.TryParse(item, out int result)) listOfIntegers.Add(result);
            }

            var totalFuel = CalculateAccumulativeListFuel(listOfIntegers);
            Console.WriteLine($"total fuel needed is: {totalFuel}");
        }

        //Calculating the Fuel for a module
        public static int Fuel(int module)
        {
            return (module / 3) - 2;
        }

        //Sum of fuel for all modules
        public static int CalculateListFuel(List<int> modules)
        {
            int totalFuel = 0;

            foreach (var item in modules) totalFuel += Fuel(item);
            return totalFuel;
        }

        //Calculating Accumulative fuel for a module
        public static int AccumulativeFuel(int module)
        {
            int overallFuel = Fuel(module); 
            int currentFuel = overallFuel;

            while ((currentFuel = Fuel(currentFuel))> 0) overallFuel += currentFuel;
            return overallFuel;
        }

        //Calculate Accumulative fuel for all modules
        public static int CalculateAccumulativeListFuel(List<int> modules)
        {
            int totalFuel = 0;

            foreach (var item in modules) totalFuel += AccumulativeFuel(item);
            return totalFuel;
        }


    }

}

