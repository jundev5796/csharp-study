using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace review_session6
{
    class SnackUnit
    {
        string Name = "새우깡한조각";
        string Flavor = "새우맛";
        string Texture = "바삭함";
        public int Weight = 1;
        public void Eat()
        {
            Console.WriteLine($"{Name}을 먹었습니다. {Flavor},{Texture}이 느껴집니다");
        }

        public override string ToString()
        {


            return $"과자이름 : {Name}, 맛 : {Flavor}, 식감 : {Texture}, 무게 : {Weight}";
        }

    }
}
