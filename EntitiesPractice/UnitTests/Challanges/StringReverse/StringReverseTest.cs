using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests.Challanges.StringReverse
{
    [TestClass]
    public class StringReverseTest
    {
        private StringReverse _Sut;

        public StringReverseTest()
        {
            _Sut = new StringReverse();
        }


        [TestMethod]
        public void TestInvertString()
        {
            Assert.AreEqual("cba", _Sut.InvertString("abc"));
            Assert.AreEqual("", _Sut.InvertString(""));
            Assert.AreEqual("cba", _Sut.InvertString("abc"));
            Assert.AreEqual("abba", _Sut.InvertString("abba"));
            Assert.AreEqual("123abc123", _Sut.InvertString("321cba321"));
        }
        [TestMethod]
        public void TestInvertTable()
        {
            char[] abc = new char[] { 'a', 'b', 'c' };

            char[] result = _Sut.InvertTable(abc);

            Assert.IsTrue(result[0] == abc[2]);
            Assert.IsTrue(result[1] == abc[1]);
            Assert.IsTrue(result[2] == abc[0]);

            char[] singleChar = new char[] { 'a' };

            result = _Sut.InvertTable(singleChar);

            Assert.IsTrue(result[0] == singleChar[0]);

           
        }

        [TestMethod]
        public void TestSwap()
        {
            char[] abc = new char[] { 'a', 'b', 'c' };

            _Sut.Swap(abc);

            Assert.IsTrue('c' == abc[0]);
            Assert.IsTrue('b' == abc[1]);
            Assert.IsTrue('a' == abc[2]);
        }
    }
}
