using FluentAssertions;
using Ilya02Il.BaseTypes.Domain.AbstractClasses;
using Xunit;

namespace Ilya02Il.BaseTypes.Domain.Tests.AbstractClasses
{
    public class BaseEntityTests
    {
        private class TestEntity : BaseEntity<int>
        {
            public int TestProp1 { get; set; }
            public int TestProp2 { get; set; }

            public TestEntity() : base() { }
            public TestEntity(int id) : base(id) { } 
        }

        private class AnotherTestEntity : BaseEntity<int>
        {
            public AnotherTestEntity(int id) : base(id) { }
        }

        [Fact]
        public void The_Entities_Should_Be_Eqals()
        {
            var entity1 = new TestEntity(1)
            {
                TestProp1 = 1,
                TestProp2 = 1
            };
            var entity2 = new TestEntity(1)
            {
                TestProp1 = 2,
                TestProp2 = 2
            };
            var entity3 = entity1;

            TestEntity nullEntity1 = null;
            TestEntity nullEntity2 = null;

            entity1.Should().BeEquivalentTo(entity2);
            entity1.Should().BeEquivalentTo(entity3);

            (entity1 == entity2).Should().BeTrue();
            (entity1 == entity3).Should().BeTrue();

            (nullEntity1 == nullEntity2).Should().BeTrue();
        }

        [Fact]
        public void The_Entities_Should_Be_Not_Eqals()
        {
            var entity1 = new TestEntity(1)
            {
                TestProp1 = 1,
                TestProp2 = 2
            };
            var entity2 = new TestEntity(2)
            {
                TestProp1 = 1,
                TestProp2 = 2
            };
            var entity3 = new AnotherTestEntity(1);

            var entity4 = new TestEntity();

            entity1.Should().NotBeEquivalentTo(entity2);
            entity1.Should().NotBeEquivalentTo(entity3);
            entity1.Should().NotBeEquivalentTo(entity4);

            (entity1 != entity2).Should().BeTrue();
            (entity1 != entity3).Should().BeTrue();
            (entity1 != entity4).Should().BeTrue();

            (entity1 == null && null == entity1).Should().BeFalse();
        }

        [Fact]
        public void The_Entities_HashCodes_Should_Be_Eqals()
        {
            var entity1 = new TestEntity(1)
            {
                TestProp1 = 1,
                TestProp2 = 1
            };

            var entity2 = new TestEntity(1)
            {
                TestProp1 = 2,
                TestProp2 = 2
            };

            (entity1.GetHashCode() == entity2.GetHashCode()).Should().BeTrue();
        }

        [Fact]
        public void The_Entities_HashCodes_Should_Not_Be_Eqals()
        {
            var entity1 = new TestEntity(1);
            var entity2 = new TestEntity(2);
            var entity3 = new AnotherTestEntity(1);

            (entity1.GetHashCode() == entity2.GetHashCode()).Should().BeFalse();
            (entity1.GetHashCode() == entity3.GetHashCode()).Should().BeFalse();
        }
    }
}
