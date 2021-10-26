using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectPartB_B1
{
    class HandOfCards : DeckOfCards, IHandOfCards
    {
        protected List<PlayingCard> Hand = new List<PlayingCard>();
        #region Pick and Add related
        public void Add(PlayingCard cards)
        {

            this.Hand.Add(cards);
            this.Hand.Sort();

        }
        #endregion

        #region Highest Card related
        public PlayingCard Highest
        {
            get
            {
                Hand.Sort();
                PlayingCard _highest = Hand[^1];
                return _highest;
                //return cards.Max();

            }
        }
        public PlayingCard Lowest
        {
            get
            {
                Hand.Sort();
                PlayingCard _lowest = Hand[0];
                return _lowest;
                //return cards.Min();
            }
        }
        #endregion
    }
}
