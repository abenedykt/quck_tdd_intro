using FluentAssertions;
using Xunit;

namespace FizzBuzzGame
{

    public class PersonTest
    {
        [Theory,
         InlineData("Arek", "Benedykt", "Arek Benedykt"),
         InlineData("", "Benedykt", "Benedykt"),
         InlineData("Arek", "", "Arek")]
        public void ToString_override_example(string name, string surname, string expected)
        {
            new Person(name, surname)
                .ToString()
                .Should()
                .Be(expected);
        }
    }
}