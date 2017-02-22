using System;
using NUnit.Framework;

namespace Test
{
    public class UnitTest1
    {
        private Random _rand;
        
        [SetUp]
        public void Setup()
        {
            _rand = new Random();    
        }

        [Test]
        public void TestMethod1()
        {
            if (_rand.NextDouble() > .5)
            {
                Assert.Fail();
            }
        }

        [Test]
        public void TestMethod2()
        {
            if (_rand.NextDouble() > .5)
            {
                Assert.Fail();
            }
        }

        [Test]
        public void TestMethod3()
        {
            if (_rand.NextDouble() > .5)
            {
                Assert.Fail();
            }
        }

        [Test]
        public void TestMethod4()
        {
            if (_rand.NextDouble() > .5)
            {
                Assert.Fail();
            }
        }
    }
}
