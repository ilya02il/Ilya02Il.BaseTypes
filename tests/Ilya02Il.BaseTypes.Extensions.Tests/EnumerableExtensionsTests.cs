using FluentAssertions;
using Xunit;

namespace Ilya02Il.BaseTypes.Extensions.Tests
{
    public class EnumerableExtensionsTests
    {
        [Fact]
        public void ForEach_Should_Modify_Enumerable_As_Expected()
        {
            var enumerable = new[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            int result = 0;

            enumerable.ForEach(x => result = x);

            result.Should().Be(9);
        }

        [Fact]
        public void Join_Should_Return_Right_String()
        {
            var stringArr = new[] { "Hello", " ", "world", "!!!" };

            var resultString = stringArr.Join();

            resultString.Should().Be("Hello world!!!");
        }
    }
}
