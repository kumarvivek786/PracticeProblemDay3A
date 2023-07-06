using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3
{
    internal class Interface
    {

        public interface IAnimal
        {
            void MakeSound();
        }

        // Implement the interface in a class
        public class Dog : IAnimal
        {
            public void MakeSound()
            {
                Console.WriteLine("Woof!");
            }
        }

        // Implement the interface in another class
        public class Cat : IAnimal
        {
            public void MakeSound()
            {
                Console.WriteLine("Meow!");
            }
        }

        // Use the implemented interface
        class Program
        {
            static void Main(string[] args)
            {
                IAnimal dog = new Dog();
                IAnimal cat = new Cat();

                dog.MakeSound(); // Output: Woof!
                cat.MakeSound(); // Output: Meow!
            }
        }

    }
}
