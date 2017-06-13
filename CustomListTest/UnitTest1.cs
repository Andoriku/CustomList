using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomList;

namespace CustomListTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestIntAddCompletion()
        {

            CustomList<int> actualResult = new CustomList<int>();

            actualResult.Add(1);
            int expectedResult = 1;

            Assert.AreEqual(expectedResult, actualResult[0]);

        }
        [TestMethod]
        public void TestBoolAddCompletion()
        {

            CustomList<bool> actualResult = new CustomList<bool>();

            actualResult.Add(true);
            bool expectedResult = true;

            Assert.AreEqual(expectedResult, actualResult[0]);

        }
        [TestMethod]
        public void TestdoubleAddCompletion()
        {

            CustomList<double> actualResult = new CustomList<double>();

            actualResult.Add(1.323);
            double expectedResult = 1.323;

            Assert.AreEqual(expectedResult, actualResult[0]);

        }
        [TestMethod]
        public void TestStringAddCompletion()
        {

            CustomList<string> actualResult = new CustomList<string>();

            actualResult.Add("yo");
            string expectedResult = "yo";

            Assert.AreEqual(expectedResult, actualResult[0]);

        }
        public void TestCustomAddCompletion()
        {

            CustomList<object> actualResult = new CustomList<object>();

            actualResult.Add("265");
            object expectedResult = "265";

            Assert.AreEqual(expectedResult, actualResult[0]);

        }
        [TestMethod]
        public void TestAddListCount()
        {
            CustomList<int> actualResult = new CustomList<int>();

            actualResult.Add(3);
            actualResult.Add(6);
            actualResult.Add(1);

            int expectedResult = 3;

            Assert.AreEqual(expectedResult, actualResult.Count);
        }
        [TestMethod]
        public void TestIntsubtractCount()
        {
            CustomList<int> actualResult = new CustomList<int>();

            actualResult.Add(3);
            actualResult.Add(6);
            actualResult.Add(1);
            actualResult.Add(2);
            actualResult.Add(3);
            actualResult.Add(4);
            actualResult.Remove(1);
            actualResult.Remove(3);
            actualResult.Remove(6);

            int expectedResult = 3;

            Assert.AreEqual(expectedResult, actualResult.Count);
        }
        [TestMethod]
        public void TestDoublesubtractCompletion()
        {
            CustomList<double> actualResult = new CustomList<double>();

            actualResult.Add(3.33);
            actualResult.Add(6.666);
            actualResult.Add(1.1111);
            actualResult.Add(2.22);
            actualResult.Add(3.3);
            actualResult.Add(4.4444);
            actualResult.Remove(3.33);
            actualResult.Remove(6.666);
            actualResult.Remove(1.1111);

            double expectedResult = 2.22;

            Assert.AreEqual(expectedResult, actualResult[0]);
        }
        [TestMethod]
        public void TestStringsubtractCompletion()
        {
            CustomList<string> actualResult = new CustomList<string>();

            actualResult.Add("yo");
            actualResult.Add("whats");
            actualResult.Add("up");
            actualResult.Add("my");
            actualResult.Add("main");
            actualResult.Add("man");
            actualResult.Remove("yo");
            actualResult.Remove("whats");
            actualResult.Remove("up");

            string expectedResult = "my";

            Assert.AreEqual(expectedResult, actualResult[0]);
        }
        [TestMethod]
        public void TestIntsubtractCompletion()
        {
            CustomList<int> actualResult = new CustomList<int>();

            actualResult.Add(3);
            actualResult.Add(6);
            actualResult.Add(1);
            actualResult.Add(2);
            actualResult.Add(3);
            actualResult.Add(4);
            actualResult.Remove(3);
            actualResult.Remove(6);
            actualResult.Remove(1);

            int expectedResult = 2;

            Assert.AreEqual(expectedResult, actualResult[0]);
        }
        [TestMethod]
        public void TestObjectsubtractCompletion()
        {
            CustomList<object> actualResult = new CustomList<object>();

            actualResult.Add(3);
            actualResult.Add("eyrui");
            actualResult.Add(1.44);
            actualResult.Add("eyri");
            actualResult.Add(true);
            actualResult.Add("sup yall");
            actualResult.Remove(3);
            actualResult.Remove("eyrui");
            actualResult.Remove(1.44);

            object expectedResult = "eyri";

            Assert.AreEqual(expectedResult, actualResult[0]);
        }
        //[TestMethod]
        //public void TestIntAt0ZipItUp()
        //{
        //    CustomList<int> list1 = new CustomList<int>();
        //    CustomList<int> list2 = new CustomList<int>();
        //    CustomList<int> expectedResult = new CustomList<int>();

        //    list1.Add(1);
        //    list1.Add(3);
        //    list1.Add(5);

        //    list2.Add(2);
        //    list2.Add(4);
        //    list2.Add(6);

        //    expectedResult.Add(1);
        //    expectedResult.Add(2);
        //    expectedResult.Add(3);
        //    expectedResult.Add(4);
        //    expectedResult.Add(5);
        //    expectedResult.Add(6);

        //    CustomList<int> actualResult = new CustomList<int>();
        //    actualResult.ZipItUp(list2);

        //    Assert.AreEqual(expectedResult[0], actualResult[0]);
        //}
        //[TestMethod]
        //public void TestIntAt1ZipItUp()
        //{
        //    CustomList<int> list1 = new CustomList<int>();
        //    CustomList<int> list2 = new CustomList<int>();
        //    CustomList<int> expectedResult = new CustomList<int>();

        //    list1.Add(1);
        //    list1.Add(3);
        //    list1.Add(5);

        //    list2.Add(2);
        //    list2.Add(4);
        //    list2.Add(6);

        //    expectedResult.Add(1);
        //    expectedResult.Add(2);
        //    expectedResult.Add(3);
        //    expectedResult.Add(4);
        //    expectedResult.Add(5);
        //    expectedResult.Add(6);

        //    CustomList<int> actualResult = new CustomList<int>();
        //    actualResult.ZipItUp(list2);

        //    Assert.AreEqual(expectedResult[1], actualResult[1]);
        //}
        //[TestMethod]
        //public void TestDoubleAt0ZipItUp()
        //{
        //    CustomList<double> list1 = new CustomList<double>();
        //    CustomList<double> list2 = new CustomList<double>();
        //    CustomList<double> expectedResult = new CustomList<double>();

        //    list1.Add(1.1);
        //    list1.Add(3.3);
        //    list1.Add(5.5);

        //    list2.Add(2.2);
        //    list2.Add(4.4);
        //    list2.Add(6.6);

        //    expectedResult.Add(1.1);
        //    expectedResult.Add(2.2);
        //    expectedResult.Add(3.3);
        //    expectedResult.Add(4.4);
        //    expectedResult.Add(5.5);
        //    expectedResult.Add(6.6);

        //    CustomList<double> actualResult = new CustomList<double>();
        //    actualResult.ZipItUp(list2);

        //    Assert.AreEqual(expectedResult[0], actualResult[0]);
        //}
        //[TestMethod]
        //public void TestDoubleAt1ZipItUp()
        //{
        //    CustomList<double> list1 = new CustomList<double>();
        //    CustomList<double> list2 = new CustomList<double>();
        //    CustomList<double> expectedResult = new CustomList<double>();

        //    list1.Add(1.1);
        //    list1.Add(3.3);
        //    list1.Add(5.5);

        //    list2.Add(2.2);
        //    list2.Add(4.4);
        //    list2.Add(6.6);

        //    expectedResult.Add(1.1);
        //    expectedResult.Add(2.2);
        //    expectedResult.Add(3.3);
        //    expectedResult.Add(4.4);
        //    expectedResult.Add(5.5);
        //    expectedResult.Add(6.6);

        //    CustomList<double> actualResult =  new CustomList<double>();
        //    actualResult.ZipItUp(list2);

        //    Assert.AreEqual(expectedResult[1], actualResult[1]);
        //}
        //[TestMethod]
        //public void TestStringAt0ZipItUp()
        //{
        //    CustomList<string> list1 = new CustomList<string>();
        //    CustomList<string> list2 = new CustomList<string>();
        //    CustomList<string> expectedResult = new CustomList<string>();

        //    list1.Add("1");
        //    list1.Add("3");
        //    list1.Add("5");

        //    list2.Add("2");
        //    list2.Add("4");
        //    list2.Add("6");

        //    expectedResult.Add("1");
        //    expectedResult.Add("2");
        //    expectedResult.Add("3");
        //    expectedResult.Add("4");
        //    expectedResult.Add("5");
        //    expectedResult.Add("6");

        //    CustomList<string> actualResult = new CustomList<string>();
        //    actualResult.ZipItUp(list2);

        //    Assert.AreEqual(expectedResult[0], actualResult[0]);
        //}
        //[TestMethod]
        //public void TestStringAt1ZipItUp()
        //{
        //    CustomList<string> actualResult = new CustomList<string>();
        //    CustomList<string> list2 = new CustomList<string>();
        //    CustomList<string> expectedResult = new CustomList<string>();

        //    actualResult.Add("1");
        //    actualResult.Add("3");
        //    actualResult.Add("5");

        //    list2.Add("2");
        //    list2.Add("4");
        //    list2.Add("6");

        //    expectedResult.Add("1");
        //    expectedResult.Add("2");
        //    expectedResult.Add("3");
        //    expectedResult.Add("4");
        //    expectedResult.Add("5");
        //    expectedResult.Add("6");

        //    actualResult.ZipItUp(list2);

        //    Assert.AreEqual(expectedResult[1], actualResult[1]);
        //}
        //[TestMethod]
        //public void TestBoolAt0ZipItUp()
        //{
        //    CustomList<bool> actualResult = new CustomList<bool>();
        //    CustomList<bool> list2 = new CustomList<bool>();
        //    CustomList<bool> expectedResult = new CustomList<bool>();

        //    actualResult.Add(true);
        //    actualResult.Add(true);
        //    actualResult.Add(true);

        //    list2.Add(false);
        //    list2.Add(false);
        //    list2.Add(false);

        //    expectedResult.Add(true);
        //    expectedResult.Add(false);
        //    expectedResult.Add(true);
        //    expectedResult.Add(false);
        //    expectedResult.Add(true);
        //    expectedResult.Add(false);

        //    actualResult.ZipItUp(list2);

        //    Assert.AreEqual(expectedResult[0], actualResult[0]);
        //}
        //[TestMethod]
        //public void TestBoolAt1ZipItUp()
        //{
        //    CustomList<bool> actualResult = new CustomList<bool>();
        //    CustomList<bool> list2 = new CustomList<bool>();
        //    CustomList<bool> expectedResult = new CustomList<bool>();

        //    actualResult.Add(true);
        //    actualResult.Add(true);
        //    actualResult.Add(true);

        //    list2.Add(false);
        //    list2.Add(false);
        //    list2.Add(false);

        //    expectedResult.Add(true);
        //    expectedResult.Add(false);
        //    expectedResult.Add(true);
        //    expectedResult.Add(false);
        //    expectedResult.Add(true);
        //    expectedResult.Add(false);

        //    actualResult.ZipItUp(list2);

        //    Assert.AreEqual(expectedResult[1], actualResult[1]);
        //}
        //[TestMethod]
        //public void TestintToString()
        //{
        //    CustomList<int> actualList = new CustomList<int>();

        //    actualList.Add(1);
        //    actualList.Add(2);
        //    actualList.Add(3);
        //    actualList.Add(4);
        //    actualList.Add(5);
        //    actualList.Add(6);

        //    string expectedResult = "123456";
        //    string actualResult = actualList.ToString();

        //    Assert.AreEqual(expectedResult, actualResult);
        //}
        [TestMethod]
        public void TestDoubleToString()
        {
            CustomList<double> actualList = new CustomList<double>();

            actualList.Add(1.1);
            actualList.Add(2.2);
            actualList.Add(3.3);
            actualList.Add(4.4);
            actualList.Add(5.5);
            actualList.Add(6.6);

            string expectedResult = "1.12.23.34.45.56.6";
            string actualResult = actualList.ToString();

            Assert.AreEqual(expectedResult, actualResult);
        }
        [TestMethod]
        public void TestStringToString()
        {
            CustomList<string> actualList = new CustomList<string>();

            actualList.Add("1");
            actualList.Add("3");
            actualList.Add("5");
            actualList.Add("2");
            actualList.Add("4");
            actualList.Add("6");

            string expectedResult = "135246";
            string actualResult = actualList.ToString();

            Assert.AreEqual(expectedResult, actualResult);
        }
        [TestMethod]
        public void TestBoolToString()
        {
            CustomList<bool> actualList = new CustomList<bool>();

            actualList.Add(true);
            actualList.Add(false);
            actualList.Add(true);
            actualList.Add(false);
            actualList.Add(true);
            actualList.Add(false);

            string expectedResult = "TrueFalseTrueFalseTrueFalse";
            string actualResult = actualList.ToString();

            Assert.AreEqual(expectedResult, actualResult);
        }
        [TestMethod]
        public void TestIntOperator()
        {
            CustomList<int> list1 = new CustomList<int>();
            CustomList<int> list2 = new CustomList<int>();
            CustomList<int> expectedResult = new CustomList<int>();

            list1.Add(1);
            list1.Add(2);
            list1.Add(3);

            list2.Add(4);
            list2.Add(5);
            list2.Add(6);

            expectedResult.Add(1);
            expectedResult.Add(2);
            expectedResult.Add(3);
            expectedResult.Add(4);
            expectedResult.Add(5);
            expectedResult.Add(6);

            CustomList<int> actualResult = list1 + list2;

            Assert.AreEqual(expectedResult.Count, actualResult.Count);
        }
        [TestMethod]
        public void TestDoubleOperatorr()
        {
            CustomList<double> list1 = new CustomList<double>();
            CustomList<double> list2 = new CustomList<double>();
            CustomList<double> expectedResult = new CustomList<double>();

            list1.Add(1.1);
            list1.Add(2.2);
            list1.Add(3.3);

            list2.Add(4.4);
            list2.Add(5.5);
            list2.Add(6.6);

            expectedResult.Add(1.1);
            expectedResult.Add(2.2);
            expectedResult.Add(3.3);
            expectedResult.Add(4.4);
            expectedResult.Add(5.5);
            expectedResult.Add(6.6);

            CustomList<double> actualResult = list1 + list2;

            Assert.AreEqual(expectedResult.Count, actualResult.Count);
        }
        [TestMethod]
        public void teststringPlusOperator()
        {
            CustomList<string> list1 = new CustomList<string>();
            CustomList<string> list2 = new CustomList<string>();
            CustomList<string> expectedResult = new CustomList<string>();

            list1.Add("1");
            list1.Add("2");
            list1.Add("3");

            list2.Add("4");
            list2.Add("5");
            list2.Add("6");

            expectedResult.Add("1");
            expectedResult.Add("2");
            expectedResult.Add("3");
            expectedResult.Add("4");
            expectedResult.Add("5");
            expectedResult.Add("6");

            CustomList<string> actualResult = list1 + list2;


            Assert.AreEqual(expectedResult.Count, actualResult.Count);
        }
        [TestMethod]
        public void TestBoolenPlusOperator()
        {
            CustomList<bool> list1 = new CustomList<bool>();
            CustomList<bool> list2 = new CustomList<bool>();
            CustomList<bool> expectedResult = new CustomList<bool>();

            list1.Add(true);
            list1.Add(true);
            list1.Add(true);

            list2.Add(false);
            list2.Add(false);
            list2.Add(false);

            expectedResult.Add(true);
            expectedResult.Add(true);
            expectedResult.Add(true);
            expectedResult.Add(false);
            expectedResult.Add(false);
            expectedResult.Add(false);

            CustomList<bool> actualResult = list1 + list2;

            Assert.AreEqual(expectedResult.Count, actualResult.Count);
        }
        [TestMethod]
        public void TestIntOverloadSubtractionOperator()
        {
            CustomList<int> list1 = new CustomList<int>();
            CustomList<int> list2 = new CustomList<int>();
            CustomList<int> expectedResult = new CustomList<int>();

            list1.Add(2);
            list1.Add(1);
            list1.Add(2);
            list1.Add(3);
            list1.Add(4);
            list1.Add(2);

            list2.Add(2);
            list2.Add(3);
            

            expectedResult.Add(1);
            expectedResult.Add(4);

            CustomList<int> actualResult = list1-list2;

            Assert.AreEqual(expectedResult[0], actualResult[0]);
        }
        [TestMethod]
        public void TestObjOverloadSubtractionOperator()
        {
            CustomList<object> list1 = new CustomList<object>();
            CustomList<object> list2 = new CustomList<object>();
            CustomList<object> expectedResult = new CustomList<object>();

            list1.Add(2);
            list1.Add(111);
            list1.Add(21);
            list1.Add(3111);
            list1.Add(411);
            list1.Add(2111);

            list2.Add(21);
            list2.Add(3111);


            expectedResult.Add(2);
            expectedResult.Add(111);
            expectedResult.Add(411);
            expectedResult.Add(2111);

            CustomList<object> actualResult = list1 - list2;

            Assert.AreEqual(expectedResult[0], actualResult[0]);
        }
        [TestMethod]
        public void TestDoubleOverloadSubtractionOperator()
        {
            CustomList<double> list1 = new CustomList<double>();
            CustomList<double> list2 = new CustomList<double>();
            CustomList<double> expectedResult = new CustomList<double>();

            list1.Add(2.2);
            list1.Add(1.1);
            list1.Add(2.2);
            list1.Add(3.3);
            list1.Add(4.4);
            list1.Add(2.2);

            list2.Add(2.2);
            list2.Add(3.3);


            expectedResult.Add(1.1);
            expectedResult.Add(4.4);

            CustomList<double> actualResult = list1 - list2;

            Assert.AreEqual(expectedResult[0], actualResult[0]);
        }
        [TestMethod]
        public void TestStringOverloadSubtractionOperator()
        {
            CustomList<string> list1 = new CustomList<string>();
            CustomList<string> list2 = new CustomList<string>();
            CustomList<string> expectedResult = new CustomList<string>();

            list1.Add("2.2");
            list1.Add("1.1");
            list1.Add("2.2");
            list1.Add("3.3");
            list1.Add("4.4");
            list1.Add("2.2");

            list2.Add("2.2");
            list2.Add("3.3");


            expectedResult.Add("1.1");
            expectedResult.Add("4.4");

            CustomList<string> actualResult = list1 - list2;

            Assert.AreEqual(expectedResult[0], actualResult[0]);
        }
        [TestMethod]
        public void TestBoolOverloadSubtractionOperator()
        {
            CustomList<bool> list1 = new CustomList<bool>();
            CustomList<bool> list2 = new CustomList<bool>();
            CustomList<bool> expectedResult = new CustomList<bool>();

            list1.Add(true);
            list1.Add(true);
            list1.Add(false);
            list1.Add(true);
            list1.Add(false);
            list1.Add(false);

            list2.Add(false);


            expectedResult.Add(true);
            expectedResult.Add(true);
            expectedResult.Add(true);

            CustomList<bool> actualResult = list1 - list2;

            Assert.AreEqual(expectedResult[0], actualResult[0]);
        }
    }
}
