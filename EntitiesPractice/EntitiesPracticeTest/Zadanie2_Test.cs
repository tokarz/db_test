using Microsoft.VisualStudio.TestTools.UnitTesting;
using NSubstitute;
using System;

namespace EntitiesPracticeTest.Zadanie
{

    // wykrywacz palindromow
    [TestClass]
    public class Zadanie2_Test
    {
        private Zadanie2 _Sut;
        private DbReader _ReaderMock;
        private DbWriter _WriterMock;
        private DbMapper _MapperMock;

        [TestInitialize]
        public void SetUp()
        {
            _ReaderMock = Substitute.For<DbReader>();
            _WriterMock = Substitute.For<DbWriter>();
            _MapperMock = Substitute.For<DbMapper>();

            _Sut = new Zadanie2(_ReaderMock, _WriterMock, _MapperMock);
        }

        [TestMethod]
        public void FetchById_Successfull()
        {
            //given 
            int testId = 7;
            _ReaderMock.ReadById(testId).Returns("SomeObject");
            _MapperMock.Map("SomeObject").Returns("SomeMappedObject");

            //when
            string result = _Sut.FetchFromDbById(testId);
            //then
            Assert.AreEqual("SomeMappedObject", result);
        }
    }
}
