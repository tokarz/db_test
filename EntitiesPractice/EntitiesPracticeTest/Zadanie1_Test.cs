using Microsoft.VisualStudio.TestTools.UnitTesting;

using System;

namespace EntitiesPracticeTest.Zadanie
{

    // wykrywacz palindromow
    [TestClass]
    public class Zadanie1_Test
    {
        private Zadanie1 _Sut;

        [TestInitialize]
        public void SetUp()
        {
            _Sut = new Zadanie1();
        }

        [TestMethod]
        public void IsPalindrome_True()
        {
            Assert.IsTrue(_Sut.IsPalindrome("abba"));
            Assert.IsTrue(_Sut.IsPalindrome("aa"));
            Assert.IsTrue(_Sut.IsPalindrome("a"));
            Assert.IsTrue(_Sut.IsPalindrome("121"));
            Assert.IsTrue(_Sut.IsPalindrome("aabbaa"));
            Assert.IsTrue(_Sut.IsPalindrome("aaaaaaaaaaaaaaaaaaaaabaaaaaaaaaaaaaaaaaaaaa"));
        }

        [TestMethod]
        public void IsPalindrome_False()
        {
            Assert.IsFalse(_Sut.IsPalindrome("abb"));
            Assert.IsFalse(_Sut.IsPalindrome("aaaaaaaaaaaaaaaaaaaabaaaaaaaaaaaaaaaaaaaaa"));
            Assert.IsFalse(_Sut.IsPalindrome(""));
            Assert.IsFalse(_Sut.IsPalindrome(null));
        }

        [TestMethod]
        public void IsPalindromeAnagram_True()
        {
            Assert.IsTrue(_Sut.IsPalindromAnagram("aabb"));
            Assert.IsTrue(_Sut.IsPalindromAnagram("ala"));
            Assert.IsTrue(_Sut.IsPalindromAnagram("00x"));
        }

        [TestMethod]
        public void IsPalindromeAnagram_False()
        {
            Assert.IsFalse(_Sut.IsPalindromAnagram("abc"));
            Assert.IsFalse(_Sut.IsPalindromAnagram("123"));
            Assert.IsFalse(_Sut.IsPalindromAnagram(""));
            Assert.IsFalse(_Sut.IsPalindromAnagram(null));
        }

    }
}
