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
            List<Card> testCards = new List<Card>();
            Card card1 = new Card(Suit.diamond, Rank.king);
            Card card2 = new Card(Suit.diamond, Rank.jack);
            Card card3 = new Card(Suit.diamond, Rank.queen);
            Card card4 = new Card(Suit.diamond, Rank.ten);
            Card card5 = new Card(Suit.heart, Rank.ace);

            testCards.Add(card1);
            testCards.Add(card2);
            testCards.Add(card3);
            testCards.Add(card4);
            testCards.Add(card5);

            Boolean isStraight = CardsGroup.IsStraight(testCards);
            for (int i = 0; i < testCards.Count(); i++)
            {
                Console.WriteLine("第{0}张牌是:{1},{2},这几张牌{3}", i + 1, testCards[i].Suit, testCards[i].Rank, isStraight);
            }
            Console.ReadKey();
        }


    }
}
