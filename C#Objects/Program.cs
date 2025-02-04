namespace C_Objects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Cat firstCat = new Cat();
            firstCat.Name = "Maximus";
            firstCat.SayMeow();
            Console.WriteLine();

            Cat secondCat = new Cat("Zhelyazko", "red");
            secondCat.SayMeow();
            Console.WriteLine("Cat {0} is {1}!", secondCat.Name, secondCat.Color);
            Console.WriteLine();
   

            Cat someCat = new Cat();
            Cat newCat = new Cat("Jonny", "green");

            someCat = null; //garbage collector // cannot be used

            //Cat Manipulating

            Cat myCat = new Cat();
            myCat.Name = "Alfred";

            Console.WriteLine("The name of my cat is {0}.", myCat.Name);
            myCat.SayMeow();
            Console.WriteLine();
            

            Console.WriteLine("Sequence[1..4]: {0}, {1}, {2}, {3}", Sequence.NextValue(), Sequence.NextValue(), Sequence.NextValue(), Sequence.NextValue());
            Console.WriteLine();

            Dog dog = new Dog();
            dog.Bark();
            dog.Speak();
            Console.WriteLine();

            TestEnvironment.TestEnvironmentClass();
            Console.WriteLine();

            double a = 2;
            double b = 2;
            int angle = 60;

            TestEnvironment.MathTest(a, b, angle);
            Console.WriteLine();

            Console.WriteLine(Math.PI);
            Console.WriteLine(Math.E);
            Console.WriteLine();

            TestEnvironment.RandomTest();
            Console.WriteLine();

            RandomPasswordGenerator.RandomGenerator();
            Console.WriteLine();
        }
    }
}
