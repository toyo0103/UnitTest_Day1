using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitTestDay1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestDay1.Tests
{
    [TestClass()]
    public class EasyMethodTests
    {
        [TestMethod()]
        public void Method1Test_呼叫時應回傳結果為7()
        {
            //assert
            var Sut = new EasyMethod();
            var expected = 7;

            //arrange
            var actual = Sut.Method1();

            //act
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void Method2Test_呼叫時應回傳結果為10()
        {
            //assert
            var Sut = new EasyMethod();
            var expected = 10;

            //arrange
            var actual = Sut.Method2();

            //act
            Assert.AreEqual(expected, actual);
        }
    }
}