using ce100_hw1_algo_lib_cs;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ce100_hw1_algo_test_cs
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]

        public void InsSort_TestEmpty()
        {
            int[] Arr1 = new int[0];
            Class1.InsSort(Arr1);
            int[] Exp = new int[0];
            CollectionAssert.AreEqual(Exp, Arr1);
        }
        [TestMethod]
        public void InsSort_TestSingle()
        {
            int[] Arr1 = new int[1] { 1 };
            Class1.InsSort(Arr1);
            int[] Exp = new int[1] { 1 };
            CollectionAssert.AreEqual(Exp, Arr1);
        }
        [TestMethod]
        public void InsSort_TestSimple()
        {
            int[] Arr1 = new int[7] { 69, 74, 70, 73, 75, 71, 72 };
            Class1.InsSort(Arr1);
            int[] Exp = new int[7] { 69, 70, 71, 72, 73, 74, 75, };
            CollectionAssert.AreEqual(Exp, Arr1);
        }
        [TestMethod]
        public void InsSort_TestMinus()
        {
            int[] Arr1 = new int[4] { -69, -35, 0, 78 };
            Class1.InsSort(Arr1);
            int[] Exp = new int[4] { -69, -35, 0, 78 };
            CollectionAssert.AreEqual(Exp, Arr1);
        }
        [TestMethod]
        public void InsSort_Test0()
        {
            int[] Arr1 = new int[3] { 0, 0, 0};
            Class1.InsSort(Arr1);
            int[] Exp = new int[3] { 0, 0, 0};
            CollectionAssert.AreEqual(Exp, Arr1);
        }


        [TestMethod]
        public void SelSort_TestEmpty()
        {
            int[] Arr1 = new int[0];
            Class1.SortArray(Arr1, 1);
            int[] Exp = new int[0];
            CollectionAssert.AreEqual(Exp, Arr1);
        }

        [TestMethod]
        public void SelSort_TestSimple()
        {

            int[] Arr1 = new int[4] { 1, 3, 2, 7 };
            Class1.SortArray(Arr1, 4);
            int[] Exp = new int[4] { 1, 2, 3, 7 };
            CollectionAssert.AreEqual(Arr1, Exp);
        }

        [TestMethod]
        public void SelSort_TestMinus()
        {
            int[] Arr1 = new int[5] { -69, -100, 0, 69, 100 };
            Class1.SortArray(Arr1, 5);
            int[] Exp = new int[5] { -100, -69, 0, 69, 100 };
            CollectionAssert.AreEqual(Exp, Arr1);
        }

        //RECURSİVE-POWER


        [TestMethod]
        public void RecPow_test()
        {

            double result = Class1.CalcuOfPower(4, 2);
            Assert.AreEqual(result, 16);

        }

        [TestMethod]

        public void RecPow_testMinus()
        {

            double result = Class1.CalcuOfPower(-2, 5);
            Assert.AreEqual(result, -32);

        }

        [TestMethod]

        public void RecPow_test0()
        {

            double result = Class1.CalcuOfPower(100, 0);
            Assert.AreEqual(result, 1);

        }

        [TestMethod]

        public void RecPow_test2()
        {

            double result = Class1.CalcuOfPower(-2, 4);
            Assert.AreEqual(result, 16);

        }


        //Naive Power


        [TestMethod]
        public void NaivePow_test()
        {

            double result = Class1.Naivepower(5, 2);
            Assert.AreEqual(result, 25);

        }

        [TestMethod]
        public void NaivePow_testMinus()
        {

            double result = Class1.Naivepower(-4, 3);
            Assert.AreEqual(result, -64);

        }

        [TestMethod]
        public void NaivePow_test0()
        {

            double result = Class1.Naivepower(5, 0);
            Assert.AreEqual(result, 1);

        }




        //Binary Search Iterative

        [TestMethod]

        public void BinarySearchIterative_test1()
        {
            int[] Arr1 = { 48, 49, 50, 51, 52, 53, 54};
            int key = 53;

            double bas = Class1.BinarySearchIterative(Arr1, key);
            Assert.AreEqual(bas, 5);
        }


        [TestMethod]

        public void BinarySearchIterative_test2()
        {
            int[] Arr1 = { 300, 400, 500, 600, 700, 800 };
            int key = 300;

            double bas = Class1.BinarySearchIterative(Arr1, key);
            Assert.AreEqual(bas, 0);
        }

        [TestMethod]

        public void BinarySearchIterative_test3()
        {
            int[] Arr1 = { -650, -480, -348, -200, -110, -54 };
            int key = -348;

            double bas = Class1.BinarySearchIterative(Arr1, key);
            Assert.AreEqual(bas, 2);
        }





        [TestMethod]

        public void MergeSort_TestSimple_1()
        {

            int[] Arr1 = new int[6] { 3, 1, 5, 2, 4, 6 };

            int[] Exp = new int[6] { 1, 2, 3, 4, 5, 6 };
            CollectionAssert.AreEqual(Class1.mergeSort(Arr1), Exp);
        }

        [TestMethod]
        public void MergeSort_TestSimple_2()
        {

            int[] Arr1 = new int[6] { 2, 4, 1, 3, 5, 6, };

            int[] Exp = new int[6] { 1, 2, 3, 4, 5, 6, };
            CollectionAssert.AreEqual(Class1.mergeSort(Arr1), Exp);
        }

        [TestMethod]
        public void MergeSort_TestSimple_3()
        {

            int[] Arr1 = new int[6] { 5, 3, 1, 6, 2, 4 };

            int[] Exp = new int[6] { 1, 2, 3, 4, 5, 6 };
            CollectionAssert.AreEqual(Class1.mergeSort(Arr1), Exp);
        }

        [TestMethod]

        public void BinarySearchRecursive_test()
        {
            int[] Arr1 = { 0, 1, 2, 3, 4, 5 };
            int key = 4;

            int bas = Class1.BinarySearchRecursive(Arr1, 0, 5, key);
            Assert.AreEqual(bas, 4);
        }


        [TestMethod]

        public void BinarySearchRecursive_test2()
        {
            int[] Arr1 = { 10, 42, 45, 78, 84, 99 };
            int key = 42;

            int bas = Class1.BinarySearchRecursive(Arr1, 0, 5, key);
            Assert.AreEqual(bas, 1);
        }

        [TestMethod]

        public void BinarySearchRecursive_test3()
        {
            int[] Arr1 = { -87, 74, -69, -45, -33, -25, -11 };
            int key = -11;

            int bas = Class1.BinarySearchRecursive(Arr1, 0, 6, key);
            Assert.AreEqual(bas, 6);
        }










    }
}
    

