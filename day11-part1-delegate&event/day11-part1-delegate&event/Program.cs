using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day11_part1_delegate_event
{
    class Program
    {
        // Delegate 정의 - 메시지 출력을 위한 메서드 참조
        // string 매개변수를 받고 변환값이 없는 (void)메서드를 참조할 수 있는 타입
        delegate void MessageHandler(string message);

        // 델리게이트에 연결할 메서드
        // 메서드 형과 타입 이런게 일치해야 받아줌
        static void DisplayMessage(string message)
        {
            Console.WriteLine($"Message: {message}");
        }

        static void DisplayUpperMessage(string message)
        {
            Console.WriteLine($"Uppercase Message: {message.ToUpper()}");
        }

        static void Main(string[] args)
        {
            Console.WriteLine("=== 간단한 Delegate와 Event 예제 ===");

            // 1. delegate 사용해보기
            Console.WriteLine("Delegate 1");

            // Delegate 변수 선언 및 메서드 연결
            // DisplayMessage 메서드를 messageHandler 변수에 할당
            MessageHandler messageHandler = DisplayMessage;

            // Delegate 호출 - 연결된 메서드를 실행됨
            messageHandler("Hi!");

            // Delegate에 다른 메서드 추가 (멀티캐스트 Delegate)
            // += 연산자로 메서드추가
            messageHandler += DisplayUpperMessage;

            // 여러 메서드가 연결된 Delegate 호출
            // 등록된 모든 메서드가 순서대로 호출됨
            Console.WriteLine("여러 메서드 호출: ");
            messageHandler("Hello ");
        }
    }
}
