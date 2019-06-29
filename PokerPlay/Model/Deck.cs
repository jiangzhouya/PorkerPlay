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


        public Deck()
        {
            int k = 0;
            for (int i = 0; i < 4; i++)
            {
                for (int j = 2; j < 15; j++)
                {
                    Card c = new Card((Suit)(i), (Rank)(j));
                    _cards[k] = c;
                    k++;
                }
            }
        }
        public void IniDeck()
        {
            int k = 0;
            for (int i = 0; i < 4; i++)
            {
                for (int j = 2; j < 15; j++)
                {
                    Card c = new Card((Suit)(i), (Rank)(j));
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

        public Card getCard(int num)
        {
            if (num < 1 || num > Cards.Length)
            {
                return Cards[Cards.Length - 1];
            }
            else
            {
                return Cards[num - 1];
            }

        }
        public int getCardCount()
        {
            return Cards.Length;
        }

        private int GUIDSeed()
        {
            byte[] buffer = Guid.NewGuid().ToByteArray();
            return BitConverter.ToInt32(buffer, 0);
        }
    }
}
