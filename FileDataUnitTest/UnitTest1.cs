using FileData;
using NUnit.Framework;
using System;

namespace Tests
{
    [TestFixture]
    public class Tests
    {
        private MethodWrapperClass _service;
        [SetUp]
        public void Setup()
        {
            _service = new MethodWrapperClass();
        }

        [Test]
        public void Version()
        {
            var result = _service.Version("s");
            Assert.Pass();
            Assert.IsNotNull(result);
        }
        [Test]
        public void Size()
        {
            var result = _service.Size("s");
            Assert.Pass();
            Assert.IsNotNull(result);
            Assert.Positive(result);
        }
    }
}