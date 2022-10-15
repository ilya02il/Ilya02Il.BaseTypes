using FluentAssertions;
using Ilya02Il.BaseTypes.Domain.ValueTypes;
using System;
using Xunit;

namespace Ilya02Il.BaseTypes.Domain.Tests.ValueTypes
{
    public class ResultTests
    {
        private class TestType
        {
            public string Message { get; }

            public TestType(string message) => Message = message;
        }

        [Fact]
        public void Result_Should_Be_Success()
        {
            var result = new Result<int>(10);

            result.IsSuccess.Should().BeTrue();
        }

        [Fact]
        public void Result_Should_Be_Faulted()
        {
            var result = new Result<int>(new Exception());

            result.IsFaulted.Should().BeTrue();
        }

        [Fact]
        public void Value_Getter_Should_Throw_An_Exception_Then_Result_Is_Faulted()
        {
            var result = new Result<int>(new Exception());

            Action action = () =>
            {
                var value = result.Value; 
            };

            action.Should()
                .Throw<Exception>()
                .WithMessage("The result faulted and does not have the value.");
        }

        [Fact]
        public void Exception_Getter_Should_Throw_An_Exception_Then_Result_Is_Success()
        {
            var result = new Result<int>(10);

            Action action = () =>
            {
                var exception = result.Exception;
            };

            action.Should()
                .Throw<Exception>()
                .WithMessage("The result is success and does not have an exception.");
        }

        [Fact]
        public void Type_Of_Value_Should_Casts_To_Result()
        {
            int resultVal = 10;
            Result<int> result = resultVal;

            result.Value.Should().Be(10);
        }

        [Fact]
        public void Exception_Should_Casts_To_Result()
        {
            var exception = new Exception();
            Result<int> result = exception;

            result.Exception.Should().Be(exception);
        }

        [Fact]
        public void Results_Should_Be_Equals()
        {
            var result1 = new Result<int>(10);
            var result2 = new Result<int>(10);

            result1.Should().BeEquivalentTo(result2);

            (result1 == result2).Should().BeTrue();
        }

        [Fact]
        public void Results_Should_Not_Be_Equals()
        {
            var result1 = new Result<int>(10);
            var result2 = new Result<int>(11);
            var result3 = new Result<int>(new Exception());
            int notAResult = 10;

            result1.Should().NotBeEquivalentTo(result2);
            result1.Should().NotBeEquivalentTo(result3);
            result1.Should().NotBeEquivalentTo(notAResult);

            (result1 != result2).Should().BeTrue();
            (result1 != result3).Should().BeTrue();
        }

        [Fact]
        public void Results_HashCodes_Should_Be_Equals()
        {
            var exception = new Exception();

            var hashCode1 = new Result<int>(10).GetHashCode();
            var hashCode2 = new Result<int>(10).GetHashCode();
            var hashCode3 = new Result<int>(exception).GetHashCode();
            var hashCode4 = new Result<int>(exception).GetHashCode();

            (hashCode1 == hashCode2).Should().BeTrue();
            (hashCode3 == hashCode4).Should().BeTrue();
        }

        [Fact]
        public void Results_HashCodes_Should_Not_Be_Equals()
        {
            var hashCode1 = new Result<int>(10).GetHashCode();
            var hashCode2 = new Result<int>(11).GetHashCode();
            var hashCode3 = new Result<int>(new Exception()).GetHashCode();
            var hashCode4 = new Result<int>(new Exception()).GetHashCode();

            (hashCode1 != hashCode2).Should().BeTrue();
            (hashCode1 != hashCode3).Should().BeTrue();
            (hashCode3 != hashCode4).Should().BeTrue();
        }

        [Fact]
        public void Result_Should_Correct_Match_To_Test_Type()
        {
            var testType1 = Divide(10, 2.5D).Match(value => new TestType(value.ToString()),
                exception => new TestType(exception.Message));

            var testType2 = Divide(11, 0).Match(value => new TestType(value.ToString()),
                exception => new TestType(exception.Message));

            testType1.Message.Should().BeEquivalentTo(4D.ToString());
            testType2.Message.Should().BeEquivalentTo("You can't divide by zero");
        }

        [Fact]
        public void Result_Should_Correct_Map_To_Test_Type()
        {
            var result = new Result<int>(10);
            var testTypeResult = result.Map(value => new TestType(value.ToString()));

            testTypeResult.Value.Message.Should().BeEquivalentTo(10.ToString());
        }

        private Result<double> Divide(double numerator, double denominator)
        {
            if (denominator == 0D)
                return new Result<double>(new Exception("You can't divide by zero"));

            return numerator / denominator;
        }
    }
}
