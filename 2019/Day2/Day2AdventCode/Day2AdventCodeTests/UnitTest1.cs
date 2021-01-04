using NUnit.Framework;
using System.Collections.Generic;
using Day2AdventCode;

namespace Day2AdventCodeTests
{
    public class Tests
    {
        List<int> test;
           
        [Category("PartOne")]
        [TestCase(0, 70)]
        public void GivenAList_StartingWith_1_Add_andOverrideTheCorrect_Index(int n, int expected)
        {
            test = new List<int> { 1, 9, 10, 6, 7, 3, 11, 0, 99, 30, 40, 50 };
            Program.InputIsOne(test, n);
            Assert.That(test, Does.Contain(expected));
        }

        [Category("PartOne")]
        [TestCase(0, 21)]
        public void GivenAn_AList_StartingWith_2_Multiply_andOverrideTheCorrect_Index(int n, int expected)
        {
            test = new List<int> { 2, 4, 5, 6, 7, 3, 11, 0, 99, 30, 40, 50 };
            Program.InputIsTwo(test, n);

            Assert.That(test, Does.Contain(expected));
        }

        [Category("PartOne")]
        [Test]
        public void WhenValueIs99_TerminateWithoutChangingAnything()
        {
            test = new List<int> { 99, 9, 10, 3, 2, 3, 11, 0, 99, 30, 40, 50 };
            Program.ChangeValues(test);
            List<int> test1 = new List<int> { 99, 9, 10, 3, 2, 3, 11, 0, 99, 30, 40, 50 };
            Assert.That(test, Is.EqualTo(test1));
        }

        [Category("PartOne")]
        [Test]
        public void GivenAList_ChangeTheList_Correctly()
        {
            test = new List<int> { 1, 9, 10, 3, 2, 3, 11, 0, 99, 30, 40, 50 };
            Program.ChangeValues(test);
            List<int> test1 = new List<int> { 3500, 9, 10, 70, 2, 3, 11, 0, 99, 30, 40, 50};
            Assert.That(test, Is.EqualTo(test1));
        }


        [Category("PartTwo")]
        [Ignore("Not implemented")]
        [Test]
        public void Test1()
        {

        }
    }
}