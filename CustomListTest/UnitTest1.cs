using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace CustomListTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestIntAddCompletion()
        {

            customList<int> actualResult = new customList<int>();

            actualResult.AddToList(1);
            int expectedResult = 1;

            Assert.AreEqual(expectedResult, actualResult[0]);

        }
        [TestMethod]
        public void TestBoolAddCompletion()
        {

            customList<bool> actualResult = new customList<bool>();

            actualResult.AddToList(true);
            bool expectedResult = true;

            Assert.AreEqual(expectedResult, actualResult[0]);

        }
        [TestMethod]
        public void TestdoubleAddCompletion()
        {

            customList<double> actualResult = new customList<double>();

            actualResult.AddToList(1.323);
            double expectedResult = 1.323;

            Assert.AreEqual(expectedResult, actualResult[0]);

        }
        [TestMethod]
        public void TestStringAddCompletion()
        {

            customList<string> actualResult = new customList<string>();

            actualResult.AddToList("yo");
            string expectedResult = "yo";

            Assert.AreEqual(expectedResult, actualResult[0]);

        }
        public void TestCustomAddCompletion()
        {

            customList<object> actualResult = new customList<object>();

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

            Assert.AreEqual(expectedResult, actualResult.CountList);
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

            Assert.AreEqual(expectedResult, actualResult.Count);
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
        public void TestIntZipItUp()
        {
            
            CustomeList<int> list1 = new CustomeList<int>();
            CustomeList<int> list2 = new CustomeList<int>();
            List<int> expectedResult = new List<int>();

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

            CustomList<int> actualResult = CustomListTest<int>();
            actualResult = ZipItUp(list1, list2);

            Assert.AreEqual(expectedResult, actualResult);
        }
        [TestMethod]
        public void TestDoubleZipItUp()
        {
            CustomeList<double> list1 = new CustomeList<double>();
            CustomeList<double> list2 = new CustomeList<double>();
            List<double> expectedResult = new List<double>();

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

            CustomList<double> actualResult = CustomListTest<double>();
            actualResult = ZipItUp(list1, list2);

            Assert.AreEqual(expectedResult, actualResult);
        }
        [TestMethod]
        public void TestStringZipItUp()
        {
            CustomeList<string> list1 = new CustomeList<string>();
            CustomeList<string> list2 = new CustomeList<string>();
            List<string> expectedResult = new List<string>();

            list1.AddToList("1");
            list1.AddToList("3");
            list1.AddToList("5");

            list2.AddToList("2");
            list2.AddToList("4");
            list2.AddToList("4");

            expectedResult.AddToList("1");
            expectedResult.AddToList("2");
            expectedResult.AddToList("3");
            expectedResult.AddToList("4");
            expectedResult.AddToList("5");
            expectedResult.AddToList("6");

            CustomList<string> actualResult = CustomListTest<string>();
            actualResult = ZipItUp(list1, list2);

            Assert.AreEqual(expectedResult, actualResult);
        }
        [TestMethod]
        public void TestBoolZipItUp()
        {
            CustomeList<bool> list1 = new CustomeList<bool>();
            CustomeList<bool> list2 = new CustomeList<bool>();
            List<bool> expectedResult = new List<bool>();

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

            CustomList<bool> actualResult = CustomListTest<bool>();
            actualResult = ZipItUp(list1, list2);

            Assert.AreEqual(expectedResult, actualResult);
        }
        [TestMethod]
        public void TestintToString()
        {
            CustomeList<int> actualList = new CustomeList<int>();

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
            CustomeList<double> actualList = new CustomeList<double>();

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
            CustomeList<string> actualList = new CustomeList<string>();

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
            CustomeList<bool> actualList = new CustomeList<bool>();

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

    }

}
