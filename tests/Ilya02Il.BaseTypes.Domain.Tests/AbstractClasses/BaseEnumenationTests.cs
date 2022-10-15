using FluentAssertions;
using Ilya02Il.BaseTypes.Domain.AbstractClasses;
using Xunit;

namespace Ilya02Il.BaseTypes.Domain.Tests.AbstractClasses
{
    public class BaseEnumenationTests
    {
        private class Color : BaseEnumenation<string>
        {
            private Color(int id, string value) : base(id, value) { }

            public static Color Red      => new Color(0, "#ff0000");
            public static Color Green    => new Color(1, "#00ff00");
        }

        private class TestEnumenation : BaseEnumenation<string>
        {
            private TestEnumenation(int id, string value) : base(id, value) { }

            public static TestEnumenation Red => new TestEnumenation(0, "#ff0000");
        }

        [Fact]
        public void Enumenations_Should_Be_Equals()
        {
            var color1 = Color.Red;
            var color2 = Color.Red;
            Color nullColor1 = null;
            Color nullColor2 = null;

            color1.Should().BeEquivalentTo(color2);

            (color1 == color2).Should().BeTrue();
            (nullColor1 == nullColor2).Should().BeTrue();
        }

        [Fact]
        public void Enumenations_Should_Not_Be_Equals()
        {
            var color1 = Color.Red;
            var color2 = Color.Green;
            Color nullColor = null;
            int notAColor = 0;
            
            color1.Should().NotBeEquivalentTo(color2);
            color1.Should().NotBeEquivalentTo(notAColor);

            (color1 != color2).Should().BeTrue();
            (color1 != nullColor).Should().BeTrue();
        }

        [Fact]
        public void Enumenation_Should_Implicitly_Cast_To_Int32()
        {
            var color = Color.Red;
            int colorId = color;

            (color.Id == colorId).Should().BeTrue();
        }

        [Fact]
        public void Enumenations_Comparison_Should_Be_Correct()
        {
            var color1 = Color.Red;
            var color2 = Color.Green;
            var color3 = Color.Green;

            color1.CompareTo(color2).Should().BeLessThan(0);
            color2.CompareTo(color1).Should().BeGreaterThan(0);
            color2.CompareTo(color3).Should().Be(0);
        }

        [Fact]
        public void Enumenations_Hash_Codes_Should_Be_Eqals()
        {
            var color1 = Color.Red;
            var color2 = Color.Red;

            (color1.GetHashCode() == color2.GetHashCode()).Should().BeTrue();
        }

        [Fact]
        public void Enumenations_Hash_Codes_Should_Not_Be_Equals()
        {
            var color1 = Color.Red;
            var color2 = Color.Green;
            var testEnum = TestEnumenation.Red;

            (color1.GetHashCode() != color2.GetHashCode()).Should().BeTrue();
            (color1.GetHashCode() != testEnum.GetHashCode()).Should().BeTrue();
        }
    }
}
