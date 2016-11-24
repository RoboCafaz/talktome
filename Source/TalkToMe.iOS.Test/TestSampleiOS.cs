using Xunit;

namespace TalkToMe.iOS.Test
{
    public class TestsSampleiOS
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