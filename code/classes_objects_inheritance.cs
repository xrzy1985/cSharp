using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharp_tutorial
{
    class Animal
    {

        // public means access is unlimited
        // protected means access is limited to specific class methods
        //      the methods inside of the class and subclass methods
        // private means access is limited to only the specific classes methods

        // This is how C# would handle creating getters and setters for you
        public double Height { get; set; }
        public double Weight { get; set; }
        public string Sound { get; set; }

        // You can create you own getters and setters alternatively
        // you must use a predefine variable that is not the same name as the method being used
        public string nameOfAnimal;

        // use uppercase
        public string Name
        {
            get { return nameOfAnimal; }
            // You MUST USE value
            // value is used by a lot of background C# code
            set { nameOfAnimal = value; }
        }

        // Constructors : a way to initialize the attributes of the Animal class
        // A default constructor will be provided unless you create one

        public Animal()
        {
            // this is a way of saying the current object being created
            // will have this Height, Weight, Name, and Sound
            this.Height = 0;
            this.Weight = 0;
            this.nameOfAnimal = "No name";
            this.Sound = "No Sound";
            numberOfAnimals++;
        }

        //
        public Animal(double h, double w, string n, string s)
        {
            this.Height = h;
            this.Weight = w;
            this.nameOfAnimal = n;
            this.Sound = s;
            numberOfAnimals++;
        }

        // A static field is an attribute of a class that
        // the class might not normally have. For instance,
        // the number of objects in Animal created. It doesn't
        // make sense to have that as an Attribute inside of the Animal class definition
        // a static field will be shared by every object in the Animal class, but it can only access
        // static fields itself. Meaning getNumberOfAnimals can only access the numberOfAnimals, but
        // any public method has access to the static methods
        static int numberOfAnimals = 0;

        public static int getNumberOfAnimals()
        {
            return numberOfAnimals;
        }

        // Let's create a method to print the attributes of our objects
        public string toString()
        {
            return String.Format("{0} is {1} inches tall, weighs {2} lbs, and likes to {3} a lot.\n", nameOfAnimal, Height, Weight, Sound);
        }

        // Overloading
        // Here we will create some worthless method to show OVERLOADING
        // here we will define a public method that will return an int named getSum
        public int getSum(int n1, int n2)
        {
            return n1 + n2;
        }

        // The purpose of overloading is to have multiple methods with the same name
        // handle different data types or parameters
        public double getSum(double n1, double n2)
        {
            return n1 + n2;
        }

        // Here we will handle different parameters
        public double getSum(int n1, double n2, int n3)
        {
            return n1 + n2 + n3;
        }

        static void Main(string[] args)
        {
            // Classes and Objects

            // Create a new Animal object
            // Object objectName = new Object(height, weight, name, sound);
            Animal marlow = new Animal(15, 10, "Marlow", "Woof");

            // Here we will utilize that toString() method we wrote to display the information
            Console.WriteLine(marlow.toString());

            // To write out only a few attributes of marlow
            Console.WriteLine("{0} likes to {1} a lot more now.\n", marlow.nameOfAnimal, marlow.Sound);

            // Create another Animal
            Animal buster = new Animal(36, 80, "Buster", "Ruff Ruff");

            Console.WriteLine(buster.toString());

            // To retrieve the Number of Animals currently created
            Console.WriteLine("Number of animals created: " + Animal.getNumberOfAnimals() + "\n");

            // Lets take a look at those phone methods we made for the overloading purposes

            // int
            Console.WriteLine(buster.getSum(1, 1) + "\n");

            // double
            Console.WriteLine(buster.getSum(1.1, 1.4) + "\n");

            // different dataTypes and parameters
            Console.WriteLine(buster.getSum(1, 3.14, 2) + "\n");

            // You can also jumble the parameters around, but you have to set them up like this
            // n2: entry, n3: entry, n1: entry...
            Console.WriteLine(buster.getSum(n2: 3.145, n1: 0.001) + "\n");

            // This is another way to create
            Animal purrpurr = new Animal
            {
                nameOfAnimal = "PurrPurr",
                Height = 14,
                Weight = 10,
                Sound = "Meow Meow"
            };

            Console.WriteLine(purrpurr.toString());

            // Lets try using the Dog class
            // create a dog object
            Dog rusty = new Dog();

            // Lets see what prints out if we don't pass any parameters
            Console.WriteLine(rusty.toString());

            // Now lets pass parameters that make sense
            rusty = new Dog(36, 70, "Rusty", "Bark Bark", "Pedegree");

            // Now lets see what prints out
            Console.WriteLine(rusty.toString());

            // To retrieve the Number of Animals currently created
            Console.WriteLine("Number of animals created: " + Animal.getNumberOfAnimals() + "\n");

            Console.WriteLine("\nPress any key to close...");
            Console.ReadKey();
        }
    }

    class Dog : Animal
    {
        public string favFood { get; set; }

        // base() allows the initializations from the SuperClass (Animal)
        public Dog() : base()
        {
            // base() allows the programmer to only have to code what he wishes to add
            this.favFood = "No Favorite Food";
        }

        // base(height, weight, name, sound) are being initialized through the superclass Animal
        public Dog(double h, double w, string n, string s, string f): base(h, w, n, s)
        {
            // here, the superclass will handle initializing h, w, n, and s
            // all i need to do is set this objects favFood to f
            this.favFood = f;
        }

        // We can override the toString() method from within the subClass because it is set to public
        // MUST USE new in front of the override
        new public string toString()
        {
            return String.Format("{0} is {1} inches tall, weighs {2} lbs, eats {4}, and likes to {3} a lot.\n", nameOfAnimal, Height, Weight, Sound, favFood);
        }

    }
}
