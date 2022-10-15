using FluentAssertions;
using Ilya02Il.BaseTypes.Domain.AbstractClasses;
using System.Collections.Generic;
using Xunit;

namespace Ilya02Il.BaseTypes.Domain.Tests.AbstractClasses
{
    public class BaseValueObjectTests
    {
        private class TestValueObject : BaseValueObject
        {
            public int SomeProp1 { get; private set; }
            public int SomeProp2 { get; private set; }

            public TestValueObject(int someProp1, int someProp2)
            {
                SomeProp1 = someProp1;
                SomeProp2 = someProp2;
            }

            protected override IEnumerable<object> GetEqualityComponents()
            {
                yield return SomeProp1;
                yield return SomeProp2;
            }
        }

        private class AnotherTestValueObject : BaseValueObject
        {
            public int SomeProp1 { get; private set; }
            public int SomeProp2 { get; private set; }

            public AnotherTestValueObject(int someProp1, int someProp2)
            {
                SomeProp1 = someProp1;
                SomeProp2 = someProp2;
            }

            protected override IEnumerable<object> GetEqualityComponents()
            {
                yield return SomeProp1;
                yield return SomeProp2;
            }
        }

        [Fact]
        public void ValueObjects_Should_Be_Equals()
        {
            var valObj1 = new TestValueObject(1, 2);
            var valObj2 = new TestValueObject(1, 2);

            valObj1.Should().BeEquivalentTo(valObj2);

            (valObj1 == valObj2).Should().BeTrue();
        }

        [Fact]
        public void ValueObjects_Should_Not_Be_Equals()
        {
            var valObj1 = new TestValueObject(1, 1);
            var valObj2 = new TestValueObject(1, 2);
            var valObj3 = new AnotherTestValueObject(1, 1);

            valObj1.Should().NotBeEquivalentTo(valObj2);
            valObj1.Should().NotBeEquivalentTo(valObj3);

            (valObj1 != valObj2).Should().BeTrue();
            (valObj1 != valObj3).Should().BeTrue();
        }

        [Fact]
        public void ValueObjects_HashCodes_Should_Be_Equals()
        {
            var valObj1 = new TestValueObject(1, 2);
            var valObj2 = new TestValueObject(1, 2);

            (valObj1.GetHashCode() == valObj2.GetHashCode()).Should().BeTrue();
        }
        [Fact]
        public void ValueObjects_HashCodes_Should_Not_Be_Equals()
        {
            var valObj1 = new TestValueObject(1, 1);
            var valObj2 = new TestValueObject(1, 2);
            var valObj3 = new AnotherTestValueObject(1, 1);

            (valObj1.GetHashCode() != valObj2.GetHashCode()).Should().BeTrue();
            (valObj1.GetHashCode() != valObj3.GetHashCode()).Should().BeTrue();
        }
    }
}
