using System;
using System.IO;

namespace DayOne
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] entiresArray = File.ReadAllLines("TextFile1.txt");

           // string[] entiresArray2 = { "1721", "979", "366", "299", "675", "1456" };


            Console.WriteLine(getTwoEntries(entiresArray, 2020));
        }

        public static string getTwoEntries(string[] array, int expected)
        {
            string result = "Nothing";

            foreach (var item1 in array)
            {
                foreach (var item2 in array)
                {
                    if (StringToInt(item1) + StringToInt(item2) == expected)
                    {
                        var mValue = StringToInt(item1) * StringToInt(item2);

                        return $"item 1: {item1}, item 2: {item2},  multiplied result: {mValue}";
                    }
                }
            }

            return result;
        }


        public static int StringToInt(string value) => int.Parse(value);
    }
}
