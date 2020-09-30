using NUnit.Framework;

namespace NUnitTestProject1
{
    [Category("NUnitTests")]
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [TestCase(1)]
        [TestCase(2)]
        [TestCase(3)]
        [TestCase(4)]
        public void Test1Argument(int i)
        {
            Assert.True(true, $"{i}");
        }

        [TestCase(1, "1")]
        [TestCase(2, "2")]
        [TestCase(3, "3")]
        [TestCase(4, "4")]
        public void Test2Arguments(int i, string s)
        {
            Assert.True($"{i}" == s);
        }

        [TestCase(1, "1", "test1")]
        [TestCase(2, "2", "test2")]
        [TestCase(3, "3", "test3")]
        [TestCase(4, "4", "test4")]
        public void Test3Arguments(int i, string s1, string s2)
        {
            Assert.True($"{i}" == s1);
            Assert.True($"test{s1}" == s2);
        }

        [TestCase(1)]
        [TestCase(2)]
        [TestCase(3)]
        [TestCase(4)]
        public void FailedTest1Argument(int i)
        {
            Assert.False(true, $"{i}");
        }

        [TestCase(1, "1")]
        [TestCase(2, "2")]
        [TestCase(3, "3")]
        [TestCase(4, "4")]
        public void FailedTest2Arguments(int i, string s)
        {
            Assert.False($"{i}" == s);
        }

        [TestCase(1, "1", "test1")]
        [TestCase(2, "2", "test2")]
        [TestCase(3, "3", "test3")]
        [TestCase(4, "4", "test4")]
        public void FailedTest3Arguments(int i, string s1, string s2)
        {
            Assert.False($"{i}" == s1);
            Assert.False($"test{s1}" == s2);
        }

        [Test]
        public void Test()
        {
            Assert.True(true);
        }

        [Test]
        public void FaliedTest()
        {
            Assert.True(false);
        }
    }
}