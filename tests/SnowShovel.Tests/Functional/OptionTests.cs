using Xunit;
using SnowShovel.Functional;
using static SnowShovel.Functional.Extensions;

namespace SnowShovel.Tests.Functional
{
    public class OptionTests
    {
        [Fact]
        public void MatchCallsSomeWhenValuePresent()
        {
            bool hasSome = false;

            var option = Some("FooBar");

            option.Match(
                () => { },
                x => hasSome = true
            );

            Assert.True(hasSome);
        }
    }
}
