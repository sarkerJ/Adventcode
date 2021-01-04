using NUnit.Framework;
using Day1AdventCode;
using System.IO;
using System.Collections.Generic;


namespace Day1AdventCodeTests
{
    public class Tests
    {
        string[] listOfModules = File.ReadAllLines(@"C:\Users\saadi\OneDrive\Desktop\Sparta Global\Adventofcode.com_puzzles\2019\Day1\SpacecraftModules.txt");

     
        [Category("PartOne")]
        [TestCase(12,2)]
        [TestCase(14, 2)]
        [TestCase(1969, 654)]
        [TestCase(100756, 33583)]
        public void GivenAModule_ReturnTheCorrectFuelValue(int num, int expected)
        {
            Assert.That(Program.Fuel(num), Is.EqualTo(expected));
        }

        [Category("PartOne")]
        [Test]
        public void GivenAListOfIntegers_ReturnTotalFuelValue()
        {
            List<int> modules = new List<int> {21,3,3};

            Assert.That(Program.CalculateListFuel(modules), Is.EqualTo(3));
        }

        [Category("PartTwo")]
        [TestCase(1969, 966)]
        [TestCase(100756, 50346)]
        public void AccumulativeFuel_GivenAModule_ReturnTheCorrectFuelValue(int num, int expected)
        {
            Assert.That(Program.AccumulativeFuel(num), Is.EqualTo(expected));
        }

        [Test]
        [Category("PartTwo")]
        public void AccumulativeFuel_GivenAListOfIntegers_ReturnTotalFuelValue()
        {
            List<int> modules = new List<int> { 1969, 100756 };

            Assert.That(Program.CalculateAccumulativeListFuel(modules), Is.EqualTo(51312));
        }
    }
}