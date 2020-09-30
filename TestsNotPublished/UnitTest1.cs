using System;

using Xunit;

namespace TestsNotPublished
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(1)]
        [InlineData(2)]
        [InlineData(3)]
        [InlineData(4)]
        public void Theory1Argument(int i)
        {
            Assert.True(true, $"{i}");
        }

        [Theory]
        [InlineData(1, "1")]
        [InlineData(2, "2")]
        [InlineData(3, "3")]
        [InlineData(4, "4")]
        public void Theory2Arguments(int i, string s)
        {
            Assert.True($"{i}" == s);
        }

        [Theory]
        [InlineData(1, "1", "test1")]
        [InlineData(2, "2", "test2")]
        [InlineData(3, "3", "test3")]
        [InlineData(4, "4", "test4")]
        public void Theory3Arguments(int i, string s1, string s2)
        {
            Assert.True($"{i}" == s1);
            Assert.True($"test{s1}" == s2);
        }

        [Theory]
        [InlineData(1)]
        [InlineData(2)]
        [InlineData(3)]
        [InlineData(4)]
        public void FailedTheory1Argument(int i)
        {
            Assert.False(true, $"{i}");
        }

        [Theory]
        [InlineData(1, "1")]
        [InlineData(2, "2")]
        [InlineData(3, "3")]
        [InlineData(4, "4")]
        public void FailedTheory2Arguments(int i, string s)
        {
            Assert.False($"{i}" == s);
        }

        [Theory]
        [InlineData(1, "1", "test1")]
        [InlineData(2, "2", "test2")]
        [InlineData(3, "3", "test3")]
        [InlineData(4, "4", "test4")]
        public void FailedTheory3Arguments(int i, string s1, string s2)
        {
            Assert.False($"{i}" == s1);
            Assert.False($"test{s1}" == s2);
        }

        [Fact]
        public void Fact()
        {
            Assert.True(true);
        }

        [Fact]
        public void FailedFact()
        {
            Assert.True(false);
        }
    }
}
