using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace GameModel
{
    public class Deck
    {
        Card[] _cards = new Card[52];
        internal Card[] Cards { get => _cards; }

        /// <summary>
        /// 创造一副牌出来，每张牌都在牌堆里面
        /// </summary>
        public Deck()
        {
            int k = 0;
            for (int i = 0; i < 4; i++)
            {
                for (int j = 2; j < 15; j++)
                {
                    Card c = new Card((Suit)(i), (Rank)(j));
                    c.SetAvailable();
                    _cards[k] = c;
                    k++;
                }
            }

        }
        public void Shuffle()
        {
            for (int i = Cards.Length - 1; i > 0; i--)
            {
                Random r = new Random(GUIDSeed());
                int rand = r.Next(i + 1);
                Card temp = Cards[i];
                Cards[i] = Cards[rand];
                Cards[rand] = temp;
            }

        }

        /// <summary>
        /// 把还在Deck里面的第一张牌发出去
        /// </summary>
        /// <returns></returns>
        public Card GetCard()
        {
            foreach (Card c in Cards)
            {
                if (c.IsInDeck)
                {
                    c.SetUnavailable();
                    return c;
                }
            }
            throw (new System.ArgumentException("没有牌可以获得"));
        }
        public int GetDeckCount()
        {
            int i = 0;
            foreach (Card c in Cards)
            {
                if (c.IsInDeck == true)
                {
                    i++;
                }

            }
            return i;
        }

        private int GUIDSeed()
        {
            byte[] buffer = Guid.NewGuid().ToByteArray();
            return BitConverter.ToInt32(buffer, 0);
        }
    }
}
