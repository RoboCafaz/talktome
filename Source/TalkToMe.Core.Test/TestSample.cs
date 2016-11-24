using Xunit;

namespace TalkToMe.Core.Test
{
    public class TestsSample
    {
        [Fact]
        public void Pass()
        {
            Assert.True(true);
        }

        [Fact]
        public void Fail()
        {
            Assert.False(true);
        }

        [Fact(Skip = "Example Skip")]
        public void Skip()
        {
            Assert.True(false);
        }
    }
}