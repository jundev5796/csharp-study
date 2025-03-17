using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace review_session_2048Game
{
    // <summary>
    /// Program 클래스는 애플리케이션의 진입점입니다.
    /// GameManager를 생성하고 게임을 실행합니다.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            GameManager gameManager = new GameManager();
            gameManager.Run();
        }
    }
}
