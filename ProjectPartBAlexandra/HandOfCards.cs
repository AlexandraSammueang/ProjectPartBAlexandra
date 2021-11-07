using System.Collections.Generic;

namespace ProjectPartB_B1
{
    class HandOfCards : DeckOfCards, IHandOfCards
    {
        #region Pick and Add related
        public void Add(PlayingCard cards)
        {
            this.cards.Add(cards); //This:hand add cards //Have chaningg to the List in decofcards      
        }

        #endregion

        #region Highest Card related
        public PlayingCard Highest
        {
            get
            {
                
                cards.Sort(); //Sorted hand takes the last card(highest)
                PlayingCard _highest = cards[^1];
                return _highest;
            }
        }
        public PlayingCard Lowest
        {
            get
            {
                cards.Sort();//Sorted hand takes the lowest card
                PlayingCard _lowest = cards[0];
                return _lowest;  
            }
        }
       
        public override string ToString()
        {
            string sRet = "";
            for (int i = 0; i < cards.Count; i++) { sRet += $"{cards[i]}"; }
            return sRet;
        }
        public override void Clear() // doing a a override on clear
        {
            cards.Clear();
        }
    #endregion
    }

}

