using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using МодТестЧасть2;

namespace TestProject2
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()//testFront
        {
            DEQueue<string> qwsda = new DEQueue<string>();
            qwsda.pushBack("KAte");
            qwsda.pushBack("LOLQOP");
            Assert.AreEqual(qwsda.front(), "KAte");
        }

        [TestMethod]
        public void TestMethod2()//test_popfront
        {
            DEQueue<string> qwsda = new DEQueue<string>();
            qwsda.pushBack("a");
            qwsda.pushBack("b");
            qwsda.pushBack("c");
            qwsda.pushBack("d");
            string a = qwsda.popFront() + qwsda.popFront() + qwsda.popFront() + qwsda.popFront();
            Assert.AreEqual(a, "abcd");
        }
        [TestMethod]
        public void TestMethod3()//test_popback
        {
            DEQueue<string> qwsda = new DEQueue<string>();
            qwsda.pushBack("a");
            qwsda.pushBack("b");
            qwsda.pushBack("c");
            qwsda.pushBack("d");
            string a = qwsda.popBack() + qwsda.popBack() + qwsda.popBack() + qwsda.popBack();
            Assert.AreEqual(a, "dcba");
        }

        [TestMethod]
        public void TestMethod4()//test_popfront_popback
        {
            DEQueue<string> qwsda = new DEQueue<string>();
            qwsda.pushBack("a");
            qwsda.pushBack("b");
            qwsda.pushBack("c");
            qwsda.pushBack("d");
            string a = qwsda.popFront() + qwsda.popBack() + qwsda.popFront() + qwsda.popBack();
            Assert.AreEqual(a, "adbc");
        }

        [TestMethod]
        public void TestMethod5()//test_toArray
        {
            DEQueue<int> qwsda = new DEQueue<int>();
            qwsda.pushBack(1);
            qwsda.pushBack(2);
            qwsda.pushBack(3);
            qwsda.pushBack(4);
            int[] a = new int[4];
            a[0] = 1; a[1] = 2; a[2] = 3; a[3] = 4;
            int[] b = qwsda.toArray();
            CollectionAssert.AreEqual(a, b);
        }

    }
}
