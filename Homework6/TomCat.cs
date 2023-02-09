namespace Homework6
{

    internal class TomCat : Cat
    {

        public TomCat(string name, int age) : base(name, age, "Male")
        {
        }

        public override string ProduceSound()
        {
            return "MEOW!";
        }
    }
}