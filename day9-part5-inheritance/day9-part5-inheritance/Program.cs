using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day9_part5_inheritance
{
    // method overriding
    // 부모 클래스의 메서드를 자식 클래스에서 재정의(override)하여 다른 동작을 수행할수있습니다.
    // if overriding, add 'virtual' keyword on parent class
    class Animal
    {
        public string Name { get; set; }

        public virtual void Speak()
        {
            Console.WriteLine($"{Name} makes animal sound.");
        }
    }

    class Dog : Animal
    {
        // overrides parent class methodds
        public override void Speak()
        {
            Console.WriteLine($"{Name} is barking.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Animal myAnimal = new Animal();
            myAnimal.Name = "Lion";
            myAnimal.Speak();

            Dog myDog = new Dog();
            myDog.Name = "Sparky";
            myDog.Speak();
        }
    }
}
