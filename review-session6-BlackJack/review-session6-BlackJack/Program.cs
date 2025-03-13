using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace review_session6_BlackJack
{
    class Program
    {
        static void Main(string[] args)
        {
            GameManager gameManager = new GameManager();
            bool exit = false;

            while (!exit)
            {
                gameManager.Play();

                Console.WriteLine("게임을 반복하려면 아무키나 누르세요, 종료하려면'q'를 입력 해주세요");

                if (Console.ReadLine() == "q")
                {
                    exit = true;
                }
            }
        }
    }
}
