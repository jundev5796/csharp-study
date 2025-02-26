using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace day5_part2
{
    class Program
    {
        // #2 Function

        // memory
        // - stack (provides data) (ex. int, string)
        // - heap (manual input of data) (ex. new)
        // - static memory

        // Phase 1
        static void Loading()
        {
            Console.WriteLine("로딩중.");
            Thread.Sleep(1000);
            Console.WriteLine("로딩중..");
            Thread.Sleep(1000);
            Console.WriteLine("로딩중...");
            Thread.Sleep(1000);
        }

        // Phase 2 (input)
        static void AttackFunction(int _Attack)
        {
            Console.WriteLine("ATK: " + _Attack);
        }

        // Phase 3 (output)
        static int BaseAttack()
        {
            // atk: 10
            int atk = 10;
            return atk;
        }

        static void Main(string[] args)
        {
            int atk = 0;
            int baseAttack = 0;
            Console.WriteLine("Enter Character ATK: ");
            atk = int.Parse(Console.ReadLine());

            // atk
            baseAttack = BaseAttack();

            AttackFunction(baseAttack + atk);
        }
    }
}
