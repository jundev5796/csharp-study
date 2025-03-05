using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day9_part6_inheritance
{
    // 1. upcasting
    // convert child -> parent
    // convert without data loss

    // 2. downcasting
    // 

    class Animal
    {
        public void Speak()
        {
            Console.WriteLine("Makes animal sound.");
        }
    }

    class Dog : Animal
    {
        public void Bark()
        {
            Console.WriteLine("Woof!");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // 1.
            //Dog myDog = new Dog(); // child
            //Animal myAnimal = myDog; // upscaling (child -> parent)

            //myAnimal.Speak(); // valid code

            // 2.
            Animal myAnimal = new Dog(); //업캐스팅
            //Dog myDog = (Dog)myAnimal; //다운캐스팅 (명시적 변환)

            Dog myDog = myAnimal as Dog;

            if (myDog != null)
            {
                myDog.Bark();
            }
            else
            {
                Console.WriteLine("변환 실패!");
            }

            //Animal myAnimal2 = new Animal();
            //Dog myDog = (Dog)myAnimal2;

            if (myAnimal is Dog myDog1)
            {
                myDog1.Bark(); //실행
            }
            else
            {
                Console.WriteLine("변환할수 없습니다.");
            }
        }
    }
};
