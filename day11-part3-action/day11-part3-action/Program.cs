using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day11_part3_action
{
    class Program
    {
        // Delegate와 Event를 더 쉽게 만든 Action
        static void SayHello()
        {
            Console.WriteLine("Hello!");
        }

        static void ShowNotification()
        {
            Console.WriteLine("Important Alert");
        }

        static void HelloWorld(string message)
        {
            Console.WriteLine("New Message: " + message);
        }

        static void Main(string[] args)
        {
            // Action은 매개변수가 없고 반환값이 없는 메서드를 참조
            // 메서드 이름을 변수에 저장한다고 생각하면 쉬움
            Action sayHello = SayHello;

            sayHello += ShowNotification;

            sayHello?.Invoke();

            Action<string> h = null;

            h += HelloWorld;

            h?.Invoke("This is Action.");

            Action noti = null;

            noti += () => Console.WriteLine("Action without Parameters");

            noti?.Invoke();

            Action<int> Square = number => Console.WriteLine(number * number);

            Square(5);
        }
    }
}
