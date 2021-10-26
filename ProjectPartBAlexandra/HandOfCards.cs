using System.Collections.Generic;

namespace ProjectPartB_B1
{
    class HandOfCards : DeckOfCards, IHandOfCards
    {
        List<PlayingCard> Hand = new List<PlayingCard>();
        #region Pick and Add related
        public void Add(PlayingCard cards)
        {
            this.Hand.Add(cards); //This:hand add cards
            

        }

        #endregion

        #region Highest Card related
        public PlayingCard Highest
        {
            get
            {
                
                Hand.Sort(); //Sorted hand takes the last card(highest)
                PlayingCard _highest = Hand[^1];
                return _highest;
            }
        }
        public PlayingCard Lowest
        {
            get
            {
                Hand.Sort();//Sorted hand takes the lowest card
                PlayingCard _lowest = Hand[0];
                return _lowest;  
            }
        }
       
        public override string ToString()
        {
            string sRet = "";
            for (int i = 0; i < Hand.Count; i++) { sRet += $"{Hand[i]}"; }
            return sRet;
        }
        public override void Clear() // doing a a override on clear
        {
            Hand.Clear();
        }
    #endregion
    }

}

