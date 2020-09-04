namespace FizzBuzzGame
{
    public class Person
    {
        public Person(string name, string surname)
        {
            Name = name;
            Surname = surname;
        }

        public string Name { get; }
        public string Surname { get; }

        public override string ToString()
        {
            return $"{Name} {Surname}".Trim();
        }
    }
}