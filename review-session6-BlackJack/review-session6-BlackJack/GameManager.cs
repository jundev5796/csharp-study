using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace review_session6_BlackJack
{
    class GameManager
    {
        private Deck deck;

        public GameManager()
        {
            deck = new Deck();
        }

        public void Play()
        {
            //플레이어 손패 생성
            Hand playerHand = new Hand();

            //딜러의 손패 생성
            Hand dealerHand = new Hand();

            //초기 카드 배분 
            //플레이어와 딜러에게 각각 2장씩 배분
            playerHand.AddCard(deck.DrawCard());
            dealerHand.AddCard(deck.DrawCard());
            playerHand.AddCard(deck.DrawCard());
            dealerHand.AddCard(deck.DrawCard());

            //플레이어와 딜러의 버스트(21초과) 여부를 확인하기위한 변수
            bool playerBust = false;
            bool dealerBust = false;

            //플레이어 턴 시작 플레이어가 추가로 카드를 받거나 버스트될때까지 반복
            while (true)
            {
                Console.Clear();
                Console.WriteLine("플레이어 카드 :" + playerHand);
                Console.WriteLine("플레이어 점수 : " + playerHand.CalculateValue());
                Console.WriteLine("딜러의 첫번째 카드 " + dealerHand.Cards[0]);
                //플레이어의 총합이 21을 넘으면 버스트 상태로 변경
                if (playerHand.CalculateValue() > 21)
                {
                    Console.WriteLine("플레이어 버스트(21초과)");
                    playerBust = true;
                    Console.ReadKey();
                    break;
                }

                Console.WriteLine("카드를 더 받으시겠습니까? (y/n)");
                string input = Console.ReadLine();
                if (input == "y")
                {
                    playerHand.AddCard(deck.DrawCard());
                }
                else
                {
                    break;
                }
            }

            if (!playerBust)
            {
                Console.WriteLine("딜러 턴 시작.");
                Console.WriteLine("딜러 카드 : " + dealerHand);
                Console.WriteLine($"딜러 점수 : {dealerHand.CalculateValue()}");
                while (dealerHand.CalculateValue() < 17)
                {
                    Console.WriteLine("딜러가 카드를 더 받습니다.");
                    dealerHand.AddCard(deck.DrawCard());
                    Console.WriteLine("딜러 카드 : " + dealerHand);//갱신된 손패 출력
                    Console.WriteLine($"딜러 점수 : {dealerHand.CalculateValue()}");

                    //딜러의 총합이 21을 넘으면 버스트
                    if (dealerHand.CalculateValue() > 21)
                    {
                        Console.WriteLine("딜러 버스트(21 초과)");
                        dealerBust = true;
                        break;
                    }
                }
            }
            Console.WriteLine("게임결과=====");
            if (playerBust)
            {
                Console.WriteLine("플레이어 패배!");
            }
            else
            {

                //최종 점수계산
                int playerTotal = playerHand.CalculateValue();
                int dealerTotal = dealerHand.CalculateValue();

                Console.WriteLine("플레이어 점수 : " + playerTotal);
                Console.WriteLine("딜러 점수 : " + dealerTotal);

                if (dealerBust)
                {
                    Console.WriteLine("딜러 버스트, 플레이어 승리"); ;
                }
                else if (playerTotal > dealerTotal)
                {
                    Console.WriteLine("플레이어 승리"); ;
                }
                else if (playerTotal < dealerTotal)
                {
                    Console.WriteLine("딜러 승리"); ;
                }
                else
                {
                    Console.WriteLine("무승부");
                }

                Console.ReadKey();

            }
        }
    }
}
