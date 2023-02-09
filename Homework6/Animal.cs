namespace Homework6
{
    internal class Animal
    {

        string name;
        int age;
        string gender;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int Age
        {
            get { return age; }
            set { age = value; }
        }
        public string Gender
        {
            get { return gender; }
            set { gender = value; }
        }

        public Animal()
        {
        }
        public Animal(string name, int age, string gender)
        {
            Name = name;
            Age = age;
            Gender = gender;
        }

        public virtual string ProduceSound() => "Animal sounds";

        public override string ToString() =>
        $"{GetType().Name}" +
        $"\n{Name} {Age} {Gender}" +
        $"\n{ProduceSound()}";
    }
}