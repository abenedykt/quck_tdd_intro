namespace FizzBuzzGame
{
    public class FizzBuzzGame
    {
        public string Roll(int i)
        {
            if( i < 1 ) throw  new InvalidArgumentException();
            if (i % 15 == 0) return "Fizz Buzz";
            if (i % 3 == 0) return "Fizz";
            if (i % 5 == 0) return "Buzz";

            return i.ToString();
        }
    }
}
