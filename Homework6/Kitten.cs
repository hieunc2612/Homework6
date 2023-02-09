namespace Homework6
{
    internal class Kitten : Cat
    {

        public Kitten(string name, int age) : base(name, age, "Female")
        {
        }

        public override string ProduceSound()
        {
            return "Meow!";
        }
    }
}