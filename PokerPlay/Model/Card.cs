using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameModel
{
    public enum Suit
    { spade = 3, heart = 2, club = 1, diamond = 0 }
    public enum Rank
    {
        two = 2,
        three = 3,
        four = 4,
        five = 5,
        six = 6,
        seven = 7,
        eight = 8,
        night = 9,
        ten = 10,
        jack = 11,
        queen = 12,
        king = 13,
        ace = 14
    }

    public class Card
    {
        Suit _suit;
        Rank _rank;
        Boolean _isInDeck;
        public Suit Suit { get => _suit; }
        public Rank Rank { get => _rank; }
        public bool IsInDeck { get => _isInDeck; }

        public Card(Suit suit, Rank rank)
        {
            _suit = suit;
            _rank = rank;
        }

        public void SetAvailable()
        {
            _isInDeck = true;
        }
        public void SetUnavailable()
        {
            _isInDeck = false;
        }


    }
}
