using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day11_part2_event
{
    // 게임 캐릭터 클래스
    class Character
    {
        // 속성
        public string Name { get; private set; } // Character Name
        public int Health { get; private set; } // Character HP


        // Event 정의 - 캐릭터가 데미지를 입었을때 발생
        // EventHandler는 C#에서 제공한는 기본 Delegate Type
        // Event는 외부에서 직접 호출할수 없고, += 와 -= 연산자로만 접근 가능
        public event EventHandler onDamaged;


        // constructor
        public Character(string name, int health)
        {
            Name = name;
            Health = health;
        }

        // 데미지를 입는 method
        public void TakeDamage(int amount)
        {
            // HP 감소
            Health -= amount;


            Console.WriteLine($"{Name}이 {amount}의 데미지를 입었습니다. 남은 체력: {Health}");

            // Event 발생 (구독자가 있는 경우에만)
            // ?. 연산자는 OnDamaged가 null이 아닐 때만 Invoke 메서드 호출
            // EventArgs.Empty는 추가 데이터가 없을때 사용하는 빈 이벤타 인자
            onDamaged?.Invoke(this, EventArgs.Empty);
        }
    }

    class Program
    {
        // Event Handler Method
        // EventHandler Delegate와 일치하는 시그니처를 가져야함
        // sender: 이벤트를 방생시킨 객체 (여기서는 Character객체)
        // e: 이벤트와 관련된 추가 데이터(여기서는 사용하지 않음)
        static void Hero_OnDamaged(object sender, EventArgs e)
        {
            // sender를 character타임으로 형변환
            Character character = (Character)sender;

            Console.WriteLine($"Event Alert: {character.Name}이 데미지를 입었습니다.!" + 
                $"Current HP: {character.Health}");
        }

        static void Main(string[] args)
        {
            // 캐릭터 생성
            Character hero = new Character("Hero", 100);

            // Event 구독 +=
            // Event가 발생했을때 실행될 메서드 등록
            hero.onDamaged += Hero_OnDamaged;

            // 데미지 입히기
            // TakeDamage 메서드 내에서 OnDamaged 이벤트가 발생함
            hero.TakeDamage(30);

            // 이벤트 구독 취소 -=
            // 더이상 이벤트 발생시 메서드가 호출되지 않음
            hero.onDamaged -= Hero_OnDamaged;
            Console.WriteLine("이벤트 구독 취소");
            hero.TakeDamage(20); // 이벤트 발생함수는 실행하지만 내용은 실행안함
        }
    }
}
