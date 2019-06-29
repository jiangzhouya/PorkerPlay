using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameModel;

namespace Model
{
    public class Player
    {
        string _name;
        int _stack;
        List<Card> _hands = new List<Card>();


        public string Name { get => _name; set => _name = value; }
        public int Stack { get => _stack; }
        public List<Card> Hands { get => _hands; }

        public Player(string name, int stack)
        {
            this.Name = name;
            _stack = stack;
        }


        public void GetHand(Card c)
        {
            Hands.Add(c);
        }

        public int GetHandsCount()
        {
            int i = 0;
            foreach(Card c in Hands)
            {
                i++;
            }
            return i;
        }

        public void StackIn(int stack)
        {
            _stack += stack;
        }
        public void StackOut(int stack)
        {
            _stack -= stack;
        }
    }
}
