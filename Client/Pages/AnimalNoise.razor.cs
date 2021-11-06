using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AnimalNoises
{
    public class AnimalNoise
    {
        public virtual void animalSound()
        {
            Console.WriteLine("The animal makes a sound.");
        }
    }

    class Dog : AnimalNoise
    {
        public override void animalSound()
        {
            Console.WriteLine("The dog goes woof!");
        }
    }

    public class Cat : AnimalNoise
    {
        public override void animalSound()
        {
            Console.WriteLine("The cat goes meow!");
        }
    }

    public class Cow : AnimalNoise
    {
        public override void animalSound()
        {
            Console.WriteLine("The cow goes moo!");
        }
    }

    public class Sheep : AnimalNoise
    {
        public override void animalSound()
        {
            Console.WriteLine("The sheep goes baa!");
        }
    }

    public class Pig : AnimalNoise
    {
        public override void animalSound()
        {
            Console.WriteLine("The pig goes oink!");
        }
    }

    public class Lion : AnimalNoise
    {
        public override void animalSound()
        {
            Console.WriteLine("The lion goes roar!");
        }
    }

    public class Product
    {
        static void Main(string[] args)
        {
            AnimalNoise myAnimal = new AnimalNoise();
            AnimalNoise myDog = new Dog();
            AnimalNoise myCat = new Cat();
            AnimalNoise myCow = new Cow();
            AnimalNoise mySheep = new Sheep();
            AnimalNoise myPig = new Pig();
            AnimalNoise myLion = new Lion();

            myAnimal.animalSound();
            myDog.animalSound();
            myCat.animalSound();
            myCow.animalSound();
            mySheep.animalSound();
            myPig.animalSound();
            myLion.animalSound();
        }
    }
}
