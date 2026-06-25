using System;
namespace MyAplication
{
    class Animal
    {
        public string animalSound()
        {
            Console.WriteLine("The animal makes a sound");
        }
    }
    class Pig : Animal
    {
        public void animalSound()
        {
            Console.WriteLine("The pig says: wee wee");
        }
    }
    class Dog : Animal
    {
        public void animalSound()
        {
            
        }
    }
}