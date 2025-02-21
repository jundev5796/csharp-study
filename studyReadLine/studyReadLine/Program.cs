using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studyReadLine
{
    class Program
    {
        static void Main(string[] args)
        {
            //// get user input w/ string
            //Console.Write("Write your name: ");
            //string userName = Console.ReadLine(); // get input from user

            //Console.WriteLine($"Hello, {userName}!");

            //// change string to int
            //Console.Write("Write your age: ");
            //string input = Console.ReadLine(); // get input from user
            //int age = int.Parse(input); // string to int

            //Console.WriteLine($"You will be {age + 1} next year!"); // output

            // readline practice
            Console.Write("루인 스킬 피해량 입력하새요: ");
            string skillDmg = Console.ReadLine();
            float skillDmgStat = float.Parse(skillDmg);
            Console.Clear();

            Console.Write("카드 게이지 획득량을 입력하새요: ");
            string cardGauge = Console.ReadLine();
            float cardGaugeStat = float.Parse(cardGauge);
            Console.Clear();

            Console.Write("각성기 피해량을 입력하새요: ");
            string ultSkill = Console.ReadLine();
            float ultSkillStat = float.Parse(ultSkill);
            Console.Clear();

            Console.Write("최대 마나를 입력하새요: ");
            string maxMana = Console.ReadLine();
            int maxManaStat = int.Parse(maxMana);
            Console.Clear();

            Console.Write("전투 중 마나 회복량을 입력하새요: ");
            string combatMana = Console.ReadLine();
            int combatManaStat = int.Parse(combatMana);
            Console.Clear();

            Console.Write("비전투 중 마나 회복량을 입력하새요: ");
            string nonCombatMana = Console.ReadLine();
            int nonCombatManaStat = int.Parse(nonCombatMana);
            Console.Clear();

            Console.Write("이동 속도를 입력하새요: ");
            string moveSpeed = Console.ReadLine();
            float moveSpeedStat = float.Parse(moveSpeed);
            Console.Clear();

            Console.Write("탈 것 속도를 입력하새요: ");
            string rideSpeed = Console.ReadLine();
            float rideSpeedStat = float.Parse(rideSpeed);
            Console.Clear();

            Console.Write("운반 속도를 입력하새요: ");
            string carrySpeed = Console.ReadLine();
            float carrySpeedStat = float.Parse(carrySpeed);
            Console.Clear();

            Console.Write("스킬 재사용 대기시간 감소를 입력하새요: ");
            string reuseSkill = Console.ReadLine();
            float reuseSkillStat = float.Parse(reuseSkill);
            Console.Clear();

            Console.WriteLine("활동 \n");
            Console.WriteLine($"루인 스킬 피해: {skillDmgStat}%");
            Console.WriteLine($"카드 게이지 획득량: {cardGaugeStat}%");
            Console.WriteLine($"각성기 피해: {ultSkillStat}%");
            Console.WriteLine($"최대 마나: {maxManaStat}");
            Console.WriteLine($"전투 중 마나 회복량: {combatManaStat}");
            Console.WriteLine($"비전투 중 마나 회복량: {nonCombatManaStat}");
            Console.WriteLine($"이동 속도: {moveSpeedStat}%");
            Console.WriteLine($"탈 것 속도: {rideSpeedStat}%");
            Console.WriteLine($"운반 속도: {carrySpeedStat}%");
            Console.WriteLine($"스킬 재사용 대기시간 감소: {reuseSkillStat}%");
        }
    }
}
