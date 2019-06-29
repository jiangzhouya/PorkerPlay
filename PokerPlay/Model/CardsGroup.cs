using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameModel
{
    /// <summary>
    /// 搞5张牌过来，根据牌型给一个数值，数值越大牌力越强
    /// </summary>
    public static class CardsGroup
    {
        public static Boolean IsStraight(List<Card> cards)
        {
            cards.Sort(CompareCard);
            ///存在Ace，要考虑 A,2,3,4,5...这样的顺子
            if ((cards[0].Rank - 2) == 0)
            {
                //只有2,3,4,5,6，这样子的顺子才需要考虑
                for (int i = 1; i < cards.Count() - 1; i++)
                {
                    if ((cards[i].Rank - i - 2) != 0)
                    {
                        return false;
                    }
                }
                if((cards.Last().Rank-14) ==0 |(cards.Last().Rank-6)==0)
                {
                    return true;
                }
                return false;
            }
            else
            {
                for (int i = 0; i < cards.Count() - 1; i++)
                {
                    if ((cards[i + 1].Rank - cards[i].Rank) != 1)
                    {
                        return false;
                    }
                }
                return true;
            }
        }

        private static int CompareCard(Card a, Card b)
        {
            if (a.Rank == b.Rank)
            {
                return 0;
            }
            else if (a.Rank > b.Rank)
            {
                return 1;
            }
            else
            {
                return -1;
            }
        }
    }


}

