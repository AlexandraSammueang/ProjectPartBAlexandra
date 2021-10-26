using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectPartB_B1
{
    class DeckOfCards : IDeckOfCards
    {
        #region cards List related
        protected const int MaxNrOfCards = 52;
        public List<PlayingCard> cards = new List<PlayingCard>(MaxNrOfCards);

        public PlayingCard this[int idx] => cards[idx];
        public int Count => cards.Count;

        #endregion

        #region ToString() related
        public override string ToString()
        {

            string sRet = "";
            for (int i = 0; i < cards.Count; i++)
            {
                sRet += $"{cards[i]}";
                if ((i + 1) % 13 == 0)
                {
                    sRet = sRet + "\n";
                }
            }
            return sRet;
        }
        #endregion

        #region Shuffle and Sorting
        public void Shuffle()
        {
            Random rnd = new Random();
            for (int b = 0; b < cards.Count; b++)
            {
                int a = rnd.Next(0, b);
                PlayingCard value = cards[a];
                cards[a] = cards[b];
                cards[b] = value;
            }

        }
        public void Sort()
        {
            cards.Sort((x, y) => x.Value.CompareTo(y.Value)); //muffin recept 
        }
        #endregion

        #region Creating a fresh Deck
        public virtual void Clear()
        {
            cards.Clear();
        }
        public void CreateFreshDeck()
        {

            for (PlayingCardColor color = PlayingCardColor.Clubs; color <= PlayingCardColor.Spades; color++)
            {
                for (PlayingCardValue value = PlayingCardValue.Two; value <= PlayingCardValue.Ace; value++)
                {
                    cards.Add(new PlayingCard(color, value));
                }
            }
        }
        #endregion

        #region Dealing
        public PlayingCard RemoveTopCard()
        {
            PlayingCard temp1 = cards[^1]; // minska stacken med 1
            cards = cards.Take(cards.Count() - 1).ToList(); // Ta ett kort och ta bord -1 från kortet
            return temp1; // retunerar listan minus 1
        }
        #endregion
    }
}
