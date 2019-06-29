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
        public int Stack { get => _stack; set => _stack = value; }
        public List<Card> Hands { get => _hands; set => _hands = value; }

        public Player(string name, int stack)
        {
            this.Name = name;
            this.Stack = stack;
        }

        public void GetHands()
        {
            //从Deck拿2张牌
            //Hands数组里面里加上这2张牌

        }

        public void StackIn(int stack)
        {
            this.Stack += stack;
        }
        public void StackOut(int stack)
        {
            this.Stack -= stack;
        }
    }
}
