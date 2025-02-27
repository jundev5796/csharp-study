using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day6_practice2
{
    class Program
    {

        struct Student
        {
            public string Name;
            public int scoreLit;
            public int scoreEng;
            public int scoreMath;

            public void Print()
            {
                Console.WriteLine($"{Name, -3} {scoreLit, 5} {scoreEng, 7} {scoreMath, 8}");
            }
        }

        static void Main(string[] args)
        {
            Student[] students = new Student[3];

            for (int i = 0; i < students.Length; i++)
            {
                Console.WriteLine("Enter Score.");
                Console.Write("학생이름: ");
                students[i].Name = Console.ReadLine();
                Console.Write("국어: ");
                students[i].scoreLit = int.Parse(Console.ReadLine());
                Console.Write("영어: ");
                students[i].scoreEng = int.Parse(Console.ReadLine());
                Console.Write("수학: ");
                students[i].scoreMath = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("이름    국어    영어    수학");

            foreach (Student stud in students)
            {
                stud.Print();
            }

            //var student1 = new Student { Name = "홍길동", scoreLit = 100, scoreEng = 80, scoreMath = 70 };
            //var student2 = new Student { Name = "홍길란", scoreLit = 90, scoreEng = 10, scoreMath = 20 };
            //var student3 = new Student { Name = "홍길순", scoreLit = 22, scoreEng = 55, scoreMath = 70 };

            //Console.WriteLine($"-Name-  -Score-");
            //Console.WriteLine($"{student1.Name} {student1.scoreLit} {student1.scoreEng} {student1.scoreMath}");
            //Console.WriteLine($"{student2.Name} {student2.scoreLit}  {student2.scoreEng} {student2.scoreMath}");
            //Console.WriteLine($"{student3.Name} {student3.scoreLit}  {student3.scoreEng} {student3.scoreMath}");
        }
    }
}
