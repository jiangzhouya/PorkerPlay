using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameModel
{
    public class Round
    {
        int _id;
        int _pot;
        int _smallBlind;
        int _buttonPos;
        List<Card> _boradCards = new List<Card>();

        public int Pot { get => _pot; set => _pot = value; }
        public int SmallBlind { get => _smallBlind; set => _smallBlind = value; }
        public int ButtonPos { get => _buttonPos; set => _buttonPos = value; }
        public List<Card> BoradCards { get => _boradCards; set => _boradCards = value; }
        public int Id { get => _id; set => _id = value; }

        public Round(int smallBlind, int buttonPos, int id)
        {
            Id = id;
            SmallBlind = smallBlind;
            ButtonPos = buttonPos;
            Pot = 0;
        }

        public void GetFlop(Card a, Card b, Card c)
        {
            BoradCards.Add(a);
            BoradCards.Add(b);
            BoradCards.Add(c);
        }

        public void GetTurn(Card a)
        {
            if (BoradCards.Count != 3)
            {
                throw (new System.ArgumentException("转牌前必须有3张底牌"));
            }
            else
            {
                BoradCards.Add(a);
            }
        }

        public void GetRiver(Card a)
        {
            if (BoradCards.Count != 4)
            {
                throw (new System.ArgumentException("河牌前必须要4张底牌"));
            }
            else
            {
                BoradCards.Add(a);
            }
        }

    }
}
