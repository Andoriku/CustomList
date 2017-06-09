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

            actualResult.AddToList(1);
            int expectedResult = 1;

            Assert.AreEqual(expectedResult, actualResult[0]);

        }
        [TestMethod]
        public void TestBoolAddCompletion()
        {

            CustomList<bool> actualResult = new CustomList<bool>();

            actualResult.AddToList(true);
            bool expectedResult = true;

            Assert.AreEqual(expectedResult, actualResult[0]);

        }
        [TestMethod]
        public void TestdoubleAddCompletion()
        {

            CustomList<double> actualResult = new CustomList<double>();

            actualResult.AddToList(1.323);
            double expectedResult = 1.323;

            Assert.AreEqual(expectedResult, actualResult[0]);

        }
        [TestMethod]
        public void TestStringAddCompletion()
        {

            CustomList<string> actualResult = new CustomList<string>();

            actualResult.AddToList("yo");
            string expectedResult = "yo";

            Assert.AreEqual(expectedResult, actualResult[0]);

        }
        public void TestCustomAddCompletion()
        {

            CustomList<object> actualResult = new CustomList<object>();

            actualResult.AddToList("265");
            object expectedResult = "265";

            Assert.AreEqual(expectedResult, actualResult[0]);

        }
        [TestMethod]
        public void TestAddListCount()
        {
            CustomList<int> actualResult = new CustomList<int>();

            actualResult.AddToList(3);
            actualResult.AddToList(6);
            actualResult.AddToList(1);

            int expectedResult = 3;

            Assert.AreEqual(expectedResult, actualResult.CountList());
        }
        [TestMethod]
        public void TestIntsubtractCount()
        {
            CustomList<int> actualResult = new CustomList<int>();

            actualResult.AddToList(3);
            actualResult.AddToList(6);
            actualResult.AddToList(1);
            actualResult.AddToList(2);
            actualResult.AddToList(3);
            actualResult.AddToList(4);
            actualResult[0].SubtractFromList();
            actualResult[1].SubtractFromList();
            actualResult[2].SubtractFromList();

            int expectedResult = 3;

            Assert.AreEqual(expectedResult, actualResult.CountList());
        }
        [TestMethod]
        public void TestDoublesubtractCompletion()
        {
            CustomList<double> actualResult = new CustomList<double>();

            actualResult.AddToList(3.33);
            actualResult.AddToList(6.666);
            actualResult.AddToList(1.1111);
            actualResult.AddToList(2.22);
            actualResult.AddToList(3.3);
            actualResult.AddToList(4.4444);
            actualResult[0].SubtractFromList();
            actualResult[1].SubtractFromList();
            actualResult[2].SubtractFromList();

            double expectedResult = 2.22;

            Assert.AreEqual(expectedResult, actualResult[0]);
        }
        [TestMethod]
        public void TestStringsubtractCompletion()
        {
            CustomList<string> actualResult = new CustomList<string>();

            actualResult.AddToList("yo");
            actualResult.AddToList("whats");
            actualResult.AddToList("up");
            actualResult.AddToList("my");
            actualResult.AddToList("main");
            actualResult.AddToList("man");
            actualResult[0].SubtractFromList();
            actualResult[1].SubtractFromList();
            actualResult[2].SubtractFromList();

            string expectedResult = "my";

            Assert.AreEqual(expectedResult, actualResult[0]);
        }
        [TestMethod]
        public void TestIntsubtractCompletion()
        {
            CustomList<int> actualResult = new CustomList<int>();

            actualResult.AddToList(3);
            actualResult.AddToList(6);
            actualResult.AddToList(1);
            actualResult.AddToList(2);
            actualResult.AddToList(3);
            actualResult.AddToList(4);
            actualResult[0].SubtractFromList();
            actualResult[1].SubtractFromList();
            actualResult[2].SubtractFromList();

            int expectedResult = 2;

            Assert.AreEqual(expectedResult, actualResult[0]);
        }
        [TestMethod]
        public void TestObjectsubtractCompletion()
        {
            CustomList<object> actualResult = new CustomList<object>();

            actualResult.AddToList(3);
            actualResult.AddToList("eyrui");
            actualResult.AddToList(1.44);
            actualResult.AddToList("eyri");
            actualResult.AddToList(true);
            actualResult.AddToList("sup yall");
            actualResult[0].SubtractFromList();
            actualResult[1].SubtractFromList();
            actualResult[2].SubtractFromList();

            object expectedResult = "eyri";

            Assert.AreEqual(expectedResult, actualResult[0]);
        }
        [TestMethod]
        public void TestIntAt0ZipItUp()
        {
            CustomList<int> list1 = new CustomList<int>();
            CustomList<int> list2 = new CustomList<int>();
            CustomList<int> expectedResult = new CustomList<int>();

            list1.AddToList(1);
            list1.AddToList(3);
            list1.AddToList(5);

            list2.AddToList(2);
            list2.AddToList(4);
            list2.AddToList(6);

            expectedResult.AddToList(1);
            expectedResult.AddToList(2);
            expectedResult.AddToList(3);
            expectedResult.AddToList(4);
            expectedResult.AddToList(5);
            expectedResult.AddToList(6);

            CustomList<int> actualResult = new CustomList<int>();
            actualResult = customListClass.ZipItUp(list1, list2);

            Assert.AreEqual(expectedResult[0], actualResult[0]);
        }
        [TestMethod]
        public void TestIntAt1ZipItUp()
        {
            CustomList<int> list1 = new CustomList<int>();
            CustomList<int> list2 = new CustomList<int>();
            CustomList<int> expectedResult = new CustomList<int>();

            list1.AddToList(1);
            list1.AddToList(3);
            list1.AddToList(5);

            list2.AddToList(2);
            list2.AddToList(4);
            list2.AddToList(6);

            expectedResult.AddToList(1);
            expectedResult.AddToList(2);
            expectedResult.AddToList(3);
            expectedResult.AddToList(4);
            expectedResult.AddToList(5);
            expectedResult.AddToList(6);

            CustomList<int> actualResult = new CustomList<int>();
            actualResult.ZipItUp(list1, list2);

            Assert.AreEqual(expectedResult[1], actualResult[1]);
        }
        [TestMethod]
        public void TestDoubleAt0ZipItUp()
        {
            CustomList<double> list1 = new CustomList<double>();
            CustomList<double> list2 = new CustomList<double>();
            CustomList<double> expectedResult = new CustomList<double>();

            list1.AddToList(1.1);
            list1.AddToList(3.3);
            list1.AddToList(5.5);

            list2.AddToList(2.2);
            list2.AddToList(4.4);
            list2.AddToList(6.6);

            expectedResult.AddToList(1.1);
            expectedResult.AddToList(2.2);
            expectedResult.AddToList(3.3);
            expectedResult.AddToList(4.4);
            expectedResult.AddToList(5.5);
            expectedResult.AddToList(6.6);

            CustomList<double> actualResult = new CustomList<double>();
            actualResult.ZipItUp(list1, list2);

            Assert.AreEqual(expectedResult[0], actualResult[0]);
        }
        [TestMethod]
        public void TestDoubleAt1ZipItUp()
        {
            CustomList<double> list1 = new CustomList<double>();
            CustomList<double> list2 = new CustomList<double>();
            CustomList<double> expectedResult = new CustomList<double>();

            list1.AddToList(1.1);
            list1.AddToList(3.3);
            list1.AddToList(5.5);

            list2.AddToList(2.2);
            list2.AddToList(4.4);
            list2.AddToList(6.6);

            expectedResult.AddToList(1.1);
            expectedResult.AddToList(2.2);
            expectedResult.AddToList(3.3);
            expectedResult.AddToList(4.4);
            expectedResult.AddToList(5.5);
            expectedResult.AddToList(6.6);

            CustomList<double> actualResult =  new CustomList<double>();
            actualResult.ZipItUp(list1, list2);

            Assert.AreEqual(expectedResult[1], actualResult[1]);
        }
        [TestMethod]
        public void TestStringAt0ZipItUp()
        {
            CustomList<string> list1 = new CustomList<string>();
            CustomList<string> list2 = new CustomList<string>();
            CustomList<string> expectedResult = new CustomList<string>();

            list1.AddToList("1");
            list1.AddToList("3");
            list1.AddToList("5");

            list2.AddToList("2");
            list2.AddToList("4");
            list2.AddToList("6");

            expectedResult.AddToList("1");
            expectedResult.AddToList("2");
            expectedResult.AddToList("3");
            expectedResult.AddToList("4");
            expectedResult.AddToList("5");
            expectedResult.AddToList("6");

            CustomList<string> actualResult = new CustomList<string>();
            actualResult.ZipItUp(list1, list2);

            Assert.AreEqual(expectedResult[0], actualResult[0]);
        }
        [TestMethod]
        public void TestStringAt1ZipItUp()
        {
            CustomList<string> list1 = new CustomList<string>();
            CustomList<string> list2 = new CustomList<string>();
            CustomList<string> expectedResult = new CustomList<string>();

            list1.AddToList("1");
            list1.AddToList("3");
            list1.AddToList("5");

            list2.AddToList("2");
            list2.AddToList("4");
            list2.AddToList("6");

            expectedResult.AddToList("1");
            expectedResult.AddToList("2");
            expectedResult.AddToList("3");
            expectedResult.AddToList("4");
            expectedResult.AddToList("5");
            expectedResult.AddToList("6");

            CustomList<string> actualResult = new CustomList<string>();
            actualResult.ZipItUp(list1, list2);

            Assert.AreEqual(expectedResult[1], actualResult[1]);
        }
        [TestMethod]
        public void TestBoolAt0ZipItUp()
        {
            CustomList<bool> list1 = new CustomList<bool>();
            CustomList<bool> list2 = new CustomList<bool>();
            CustomList<bool> expectedResult = new CustomList<bool>();

            list1.AddToList(true);
            list1.AddToList(true);
            list1.AddToList(true);

            list2.AddToList(false);
            list2.AddToList(false);
            list2.AddToList(false);

            expectedResult.AddToList(true);
            expectedResult.AddToList(false);
            expectedResult.AddToList(true);
            expectedResult.AddToList(false);
            expectedResult.AddToList(true);
            expectedResult.AddToList(false);

            CustomList<bool> actualResult = new CustomList<bool>();
            actualResult.ZipItUp(list1, list2);

            Assert.AreEqual(expectedResult[0], actualResult[0]);
        }
        [TestMethod]
        public void TestBoolAt1ZipItUp()
        {
            CustomList<bool> list1 = new CustomList<bool>();
            CustomList<bool> list2 = new CustomList<bool>();
            CustomList<bool> expectedResult = new CustomList<bool>();

            list1.AddToList(true);
            list1.AddToList(true);
            list1.AddToList(true);

            list2.AddToList(false);
            list2.AddToList(false);
            list2.AddToList(false);

            expectedResult.AddToList(true);
            expectedResult.AddToList(false);
            expectedResult.AddToList(true);
            expectedResult.AddToList(false);
            expectedResult.AddToList(true);
            expectedResult.AddToList(false);

            CustomList<bool> actualResult = new CustomList<bool>();
            actualResult.ZipItUp(list1, list2);

            Assert.AreEqual(expectedResult[1], actualResult[1]);
        }
        [TestMethod]
        public void TestintToString()
        {
            CustomList<int> actualList = new CustomList<int>();

            actualList.AddToList(1);
            actualList.AddToList(2);
            actualList.AddToList(3);
            actualList.AddToList(4);
            actualList.AddToList(5);
            actualList.AddToList(6);

            string expectedResult = "123456";
            string actualResult = actualList.ToString();

            Assert.AreEqual(expectedResult, actualResult);
        }
        [TestMethod]
        public void TestDoubleToString()
        {
            CustomList<double> actualList = new CustomList<double>();

            actualList.AddToList(1.1);
            actualList.AddToList(2.2);
            actualList.AddToList(3.3);
            actualList.AddToList(4.4);
            actualList.AddToList(5.5);
            actualList.AddToList(6.6);

            string expectedResult = "1.12.23.34.45.56.6";
            string actualResult = actualList.ToString();

            Assert.AreEqual(expectedResult, actualResult);
        }
        [TestMethod]
        public void TestStringToString()
        {
            CustomList<string> actualList = new CustomList<string>();

            actualList.AddToList("1");
            actualList.AddToList("3");
            actualList.AddToList("5");
            actualList.AddToList("2");
            actualList.AddToList("4");
            actualList.AddToList("6");

            string expectedResult = "123456";
            string actualResult = actualList.ToString();

            Assert.AreEqual(expectedResult, actualResult);
        }
        [TestMethod]
        public void TestBoolToString()
        {
            CustomList<bool> actualList = new CustomList<bool>();

            actualList.AddToList(true);
            actualList.AddToList(false);
            actualList.AddToList(true);
            actualList.AddToList(false);
            actualList.AddToList(true);
            actualList.AddToList(false);

            string expectedResult = "truefalsetruefalsetruefalse";
            string actualResult = actualList.ToString();

            Assert.AreEqual(expectedResult, actualResult);
        }
        [TestMethod]
        public void TestIntOverloadAdditonOperator()
        {
            CustomList<int> list1 = new CustomList<int>();
            CustomList<int> list2 = new CustomList<int>();
            CustomList<int> expectedResult = new CustomList<int>();

            list1.AddToList(1);
            list1.AddToList(2);
            list1.AddToList(3);

            list2.AddToList(4);
            list2.AddToList(5);
            list2.AddToList(6);

            expectedResult.AddToList(1);
            expectedResult.AddToList(2);
            expectedResult.AddToList(3);
            expectedResult.AddToList(4);
            expectedResult.AddToList(5);
            expectedResult.AddToList(6);

            CustomList<int> actualResult = list1.OverloadAdditionOperator(list2);

            Assert.AreEqual(expectedResult.CountList(), actualResult.CountList());
        }
        [TestMethod]
        public void TestDoubleOverloadAdditonOperator()
        {
            CustomList<double> list1 = new CustomList<double>();
            CustomList<double> list2 = new CustomList<double>();
            CustomList<double> expectedResult = new CustomList<double>();

            list1.AddToList(1.1);
            list1.AddToList(2.2);
            list1.AddToList(3.3);

            list2.AddToList(4.4);
            list2.AddToList(5.5);
            list2.AddToList(6.6);

            expectedResult.AddToList(1.1);
            expectedResult.AddToList(2.2);
            expectedResult.AddToList(3.3);
            expectedResult.AddToList(4.4);
            expectedResult.AddToList(5.5);
            expectedResult.AddToList(6.6);

            CustomList<double> actualResult = list1.OverloadAdditionOperator(list2);

            Assert.AreEqual(expectedResult.CountList(), actualResult.CountList());
        }
        [TestMethod]
        public void TestStringOverloadAdditonOperator()
        {
            CustomList<string> list1 = new CustomList<string>();
            CustomList<string> list2 = new CustomList<string>();
            CustomList<string> expectedResult = new CustomList<string>();

            list1.AddToList("1");
            list1.AddToList("2");
            list1.AddToList("3");

            list2.AddToList("4");
            list2.AddToList("5");
            list2.AddToList("6");

            expectedResult.AddToList("1");
            expectedResult.AddToList("2");
            expectedResult.AddToList("3");
            expectedResult.AddToList("4");
            expectedResult.AddToList("5");
            expectedResult.AddToList("6");

            CustomList<string> actualResult = list1.OverloadAdditionOperator(list2);


            Assert.AreEqual(expectedResult.CountList(), actualResult.CountList());
        }
        [TestMethod]
        public void TestSBoolgOverloadAdditonOperator()
        {
            CustomList<bool> list1 = new CustomList<bool>();
            CustomList<bool> list2 = new CustomList<bool>();
            CustomList<bool> expectedResult = new CustomList<bool>();

            list1.AddToList(true);
            list1.AddToList(true);
            list1.AddToList(true);

            list2.AddToList(false);
            list2.AddToList(false);
            list2.AddToList(false);

            expectedResult.AddToList(true);
            expectedResult.AddToList(true);
            expectedResult.AddToList(true);
            expectedResult.AddToList(false);
            expectedResult.AddToList(false);
            expectedResult.AddToList(false);

            CustomList<bool> actualResult = list1.OverloadAdditionOperator(list2);

            Assert.AreEqual(expectedResult.CountList(), actualResult.CountList());
        }
        [TestMethod]
        public void TestIntOverloadSubtractionOperator()
        {
            CustomList<int> list1 = new CustomList<int>();
            CustomList<int> list2 = new CustomList<int>();
            CustomList<int> expectedResult = new CustomList<int>();

            list1.AddToList(2);
            list1.AddToList(1);
            list1.AddToList(2);
            list1.AddToList(3);
            list1.AddToList(4);
            list1.AddToList(2);

            list2.AddToList(2);
            list2.AddToList(3);
            

            expectedResult.AddToList(1);
            expectedResult.AddToList(4);

            CustomList<int> actualResult = list1.OverloadSubtractionOperator(list2);

            Assert.AreEqual(expectedResult[0], actualResult[0]);
        }
        [TestMethod]
        public void TestDoubleOverloadSubtractionOperator()
        {
            CustomList<double> list1 = new CustomList<double>();
            CustomList<double> list2 = new CustomList<double>();
            CustomList<double> expectedResult = new CustomList<double>();

            list1.AddToList(2.2);
            list1.AddToList(1.1);
            list1.AddToList(2.2);
            list1.AddToList(3.3);
            list1.AddToList(4.4);
            list1.AddToList(2.2);

            list2.AddToList(2.2);
            list2.AddToList(3.3);


            expectedResult.AddToList(1.1);
            expectedResult.AddToList(4.4);

            CustomList<double> actualResult = list1.OverloadSubtractionOperator(list2);

            Assert.AreEqual(expectedResult[0], actualResult[0]);
        }
        [TestMethod]
        public void TestStringOverloadSubtractionOperator()
        {
            CustomList<string> list1 = new CustomList<string>();
            CustomList<string> list2 = new CustomList<string>();
            CustomList<string> expectedResult = new CustomList<string>();

            list1.AddToList("2.2");
            list1.AddToList("1.1");
            list1.AddToList("2.2");
            list1.AddToList("3.3");
            list1.AddToList("4.4");
            list1.AddToList("2.2");

            list2.AddToList("2.2");
            list2.AddToList("3.3");


            expectedResult.AddToList("1.1");
            expectedResult.AddToList("4.4");

            CustomList<string> actualResult = list1.OverloadSubtractionOperator(list2);

            Assert.AreEqual(expectedResult[0], actualResult[0]);
        }
        [TestMethod]
        public void TestBoolOverloadSubtractionOperator()
        {
            CustomList<bool> list1 = new CustomList<bool>();
            CustomList<bool> list2 = new CustomList<bool>();
            CustomList<bool> expectedResult = new CustomList<bool>();

            list1.AddToList(true);
            list1.AddToList(true);
            list1.AddToList(false);
            list1.AddToList(true);
            list1.AddToList(false);
            list1.AddToList(false);

            list2.AddToList(false);


            expectedResult.AddToList(true);
            expectedResult.AddToList(true);
            expectedResult.AddToList(true);

            CustomList<string> actualResult = list1.OverloadSubtractionOperator(list2);

            Assert.AreEqual(expectedResult[0], actualResult[0]);
        }
    }
}
