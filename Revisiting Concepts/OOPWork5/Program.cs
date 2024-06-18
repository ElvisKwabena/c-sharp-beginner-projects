namespace Louisa
{
    public abstract class Animal
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Animal(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public abstract string MakeSound();

        public string GetName()
        {
            return Name;
        }

        public int GetAge()
        {
            return Age;
        }

        public void SetAge(int age)
        {
            Age = age;
        }
    }

    // Lion class
    public class Lion : Animal
    {
        public Lion(string name, int age) : base(name, age)
        {
        }

        public override string MakeSound()
        {
            return "Roar";
        }
    }

    // Tiger class
    public class Tiger : Animal
    {
        public Tiger(string name, int age) : base(name, age)
        {
        }

        public override string MakeSound()
        {
            return "Growl";
        }
    }

    // Elephant class
    public class Elephant : Animal
    {
        public Elephant(string name, int age) : base(name, age)
        {
        }

        public override string MakeSound()
        {
            return "Trumpet";
        }
    }

}