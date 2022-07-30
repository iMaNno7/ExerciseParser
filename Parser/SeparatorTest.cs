using Domain;
using FluentAssertions;
using System.ComponentModel.DataAnnotations;

namespace Parser
{
    public class SeparatorTest
    {
        [Theory]
        [InlineData("Cat,Dog", ',')]
        public void Should_Return_Array_String(string text, char separator)
        {
            string[] res = Domain.String.Separator(text, separator);
            res.Count().Should().BeGreaterThan(1);
        }

        [Theory]
        [InlineData("Cat,Dog", char.MinValue)]
        public void Should_throw_EmptySeparatorException(string text, char separator)
        {
            FluentActions.Invoking(() =>
                 Domain.String.Separator(text, separator))
                    .Should().Throw<EmptySeparatorException>();
        }

        [Theory]
        [InlineData("", ',')]
        public void Should_Return_Empty_Array(string text, char separator)
        {
            string[] res = Domain.String.Separator(text, separator);
            res.Count().Should().Be(0);
        }
    }
}