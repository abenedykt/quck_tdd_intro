using Xunit;

namespace FizzBuzzGame
{
    public class FizzBuzzGameTestV2
    {
        [Theory,
         InlineData(1, "1"),
         InlineData(2, "2"),
         InlineData(3, "Fizz"),
         InlineData(4, "4"),
         InlineData(5, "Buzz"),
         InlineData(15, "Fizz Buzz")]

        public void FizzBuzzGameRulesAreMet(int input, string expected)
        {
            var systemUnderTest = new FizzBuzzGame();
            var result = systemUnderTest.Roll(input);
            Assert.Equal(expected,result);
        }

        [Fact]
        public void When_input_is_lower_than_1_should_throw_invalid_argument_exception()
        {
            var sut = new FizzBuzzGame();

            Assert.Throws<InvalidArgumentException>(()=>sut.Roll(0));
        }
    }
}