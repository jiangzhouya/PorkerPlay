using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameModel;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Deck curDeck = new Deck();
            curDeck.Shuffle();
            for (int i = 0; i < curDeck.getCardCount(); i++)
            {
                Console.WriteLine("第{0}张牌是:{1},{2}", i + 1, curDeck.getCard(i + 1).Suit, curDeck.getCard(i + 1).Rank);

            }
            Console.ReadKey();
        }
    }
}
