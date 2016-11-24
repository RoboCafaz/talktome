using Xunit;

namespace TalkToMe.Droid.Test
{
    public class TestsSampleDroid
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