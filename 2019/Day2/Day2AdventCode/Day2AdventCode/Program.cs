using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

namespace Day2AdventCode
{
    public class Program
    {
        public static string [] listOfNumbers = File.ReadAllText(@"C:\Users\saadi\OneDrive\Desktop\Sparta Global\Adventofcode.com_puzzles\2019\Day2\inputValues.txt").Split(",");
        public static List<int> listOfInt = new List<int>();

        static void Main(string[] args)
        {
            foreach (var item in listOfNumbers)
            {
                listOfInt.Add(int.Parse(item));
            }

            //listOfInt[1] = 12;
            //listOfInt[2] = 2;
            //Console.WriteLine(ChangeValues(listOfInt));
            //Console.WriteLine(listOfInt[0]);

            var values = SwapValues(listOfInt);
            var result = (100 * values.Item1) + values.Item2;
            Console.WriteLine(result);
        }

        public static (int,int) SwapValues(List<int> nums)
        {
            var currentList = nums.ToList();
            int noun, verb = 0;

            for(noun=0; noun<=99; noun++)
            {
                for (verb=0; verb<= 99; verb++)
                {
                    currentList[1] = noun;
                    currentList[2] = verb;
                    ChangeValues(currentList);
                    if (currentList[0] == 19690720) return (noun, verb);
                    else  currentList = nums.ToList();
                }
            }
            
            return (noun,verb);
        }

        public static bool ChangeValues(List<int> nums)
        {
            for(int i=0; i< nums.Count; i+=4)
            {
                var item = nums[i];
                switch (item)
                {
                    case 1:
                        InputIsOne(nums, i);
                        break;

                    case 2:
                        InputIsTwo(nums, i);
                        break;

                    case 99:
                        return true;
                }
            }
            return false;
        }

        public static void InputIsOne(List<int> nums, int index)
        {
            int valueOne = nums[index + 1];
            int valueTwo = nums[index + 2];
            int position3 = nums[index + 3];
            nums[position3] = nums[valueOne] + nums[valueTwo];
        }

        public static void InputIsTwo(List<int> nums, int index)
        {
            int valueOne = nums[index + 1];
            int valueTwo = nums[index + 2];
            int position3 = nums[index + 3];
            nums[position3] = nums[valueOne] * nums[valueTwo];

        }

        
    }
}
