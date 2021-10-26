using System.Collections.Generic;

namespace ProjectPartB_B1
{
    class HandOfCards : DeckOfCards, IHandOfCards
    {
        List<PlayingCard> Hand = new List<PlayingCard>();
        #region Pick and Add related
        public void Add(PlayingCard cards)
        {
            this.Hand.Add(cards);
            //Sort();

        }

        #endregion

        #region Highest Card related
        public PlayingCard Highest
        {
            get
            {
                //Sort(); annars denna
                Hand.Sort();
                PlayingCard _highest = Hand[^1];
                return _highest;
            }
        }
        public PlayingCard Lowest
        {
            get
            {
                Hand.Sort();
                PlayingCard _lowest = Hand[0];
                return _lowest;  
            }
        }
        /*public void HandSort() //LA TILL NU
        {
            cards.Sort((x, y) => x.Value.CompareTo(y.Value)); //muffin recept 
        }*/
        public override string ToString()
        {
            string sRet = "";
            for (int i = 0; i < Hand.Count; i++) { sRet += $"{Hand[i]}"; }
            return sRet;
        }
        public override void Clear() 
        {
            Hand.Clear();
        }
    #endregion
    }

}

