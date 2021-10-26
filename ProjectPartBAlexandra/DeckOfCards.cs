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
        public int Count => cards.Count; // Counting the cards

        #endregion

        #region ToString() related
        public override string ToString() 
        {

            string sRet = "";
            for (int i = 0; i < cards.Count; i++)
            {
                sRet += $"{cards[i]}";
                if ((i + 1) % 13 == 0) // print out 13 on every line
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
            Random rnd = new Random(); //Shuffels the card with random
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
            cards.Sort((x, y) => x.Value.CompareTo(y.Value)); //muffin recipe 
        }
        #endregion

        #region Creating a fresh Deck
        public virtual void Clear() //make an viritual so i can do a override
        {
            cards.Clear();
        }
        public void CreateFreshDeck()
        {

            for (PlayingCardColor color = PlayingCardColor.Clubs; color <= PlayingCardColor.Spades; color++) //creating a deck from clubs-spades
            {
                for (PlayingCardValue value = PlayingCardValue.Two; value <= PlayingCardValue.Ace; value++) //creating a deck from 2-ace
                {
                    cards.Add(new PlayingCard(color, value)); // adding both color and value to cards.
                }
            }
        }
        #endregion

        #region Dealing
        public PlayingCard RemoveTopCard()
        {
            PlayingCard temp1 = cards[^1]; // takes the last card
            cards = cards.Take(cards.Count() - 1).ToList(); // Take one card and take it of the list 
            return temp1; // reurn the temp with 1 card less
        }
        #endregion
    }
}
