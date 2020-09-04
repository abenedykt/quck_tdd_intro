using FluentAssertions;
using Xunit;

namespace FizzBuzzGame
{
    public class FizzBuzzGameTest
    {
        // TDD !!!
        // first test
        // then code

        // Uncle Bobs 3 laws of TDD
        // 1. You are not allowed to write any production code unless
        //    it is to make a failing unit test pass
        //
        // 2. You are not allowed to write any more of a unit test
        //    that is sufficient to fail, and compilation failures are failures
        //
        // 3. You are not allowed to write any more production code
        //    that is sufficient to pass the one failing the unit test


        // xunit

        // fizz buzz
        // 1 - n
        // divisible by 3 = Fizz
        // divisible by 5 = Buzz

        [Fact]
        public void When_play_1_should_return_1()
        {
            // arrange
            var systemUnderTest = new FizzBuzzGame();

            // act
            var result = systemUnderTest.Roll(1);

            // assert
            Assert.Equal("1",result);
        }

        [Fact]
        public void When_play_2_should_return_2()
        {
            // arrange
            var systemUnderTest = new FizzBuzzGame();

            // act
            var result = systemUnderTest.Roll(2);

            // assert
            Assert.Equal("2", result);
        }

        // 1. name of the test function -> describes expected result (proper result is a bad pattern - code smell)
        // 2. Single Responsibility Principle


        [Fact]
        public void When_argument_is_divisible_by_3_should_returns_fizz()
        {
            var sut = new FizzBuzzGame();
            var result = sut.Roll(3);
            result.Should().Be("Fizz");
        }
        
        [Fact]
        public void When_argument_is_divisible_by_5_should_returns_buzz()
        {
            var sut = new FizzBuzzGame();
            var result = sut.Roll(5);
            result.Should().Be("Buzz");
        }

        [Fact]
        public void When_argument_is_divisible_by_3_and_5_should_returns_fizz_buzz()
        {
            var sut = new FizzBuzzGame();
            var result = sut.Roll(15);
            result.Should().Be("Fizz Buzz");
        }

        [Fact]
        public void When_input_is_lower_than_1_should_throw_invalid_argument_exception()
        {
            var sut = new FizzBuzzGame();

            Assert.Throws<InvalidArgumentException>(()=>sut.Roll(0));
        }
        
        // Test F.I.R.S.T.
        // 
        // Test should be:
        // - Fast
        // - Independent
        // - Repeatable
        // - Self Validating
        // - Timely 
    }
}