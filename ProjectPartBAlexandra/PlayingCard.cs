using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectPartB_B1
{
	public class PlayingCard : IComparable<PlayingCard>, IPlayingCard
	{
		public PlayingCardColor Color { get; init; }
		public PlayingCardValue Value { get; init; }
		public PlayingCard() : this(PlayingCardColor.Clubs, PlayingCardValue.Two) { } //vad gör dessa??
		public PlayingCard(PlayingCardColor color, PlayingCardValue value)
		{
			Color = color;
			Value = value;
		}

		#region IComparable Implementation
		//Need only to compare value in the project
		public int CompareTo(PlayingCard card1) //Comparing method
		{
			if (this.Value < card1.Value) return 1;
			else if (this.Value > card1.Value) return -1;
			else return 0;
		}
		#endregion

		#region ToString() related
		string ShortDescription
		{
			//Use switch statment or switch expression
			//https://en.wikipedia.org/wiki/Playing_cards_in_Unicode
			get
			{
				char c = Color switch
				{
					PlayingCardColor.Clubs => '\u2663',
					PlayingCardColor.Spades => '\u2660',
					PlayingCardColor.Hearts => '\u2665',
					_ => '\u2666'
				};
				return $"{c} {Value,-7}";
			}
		}

		public override string ToString() => ShortDescription;
		#endregion
	}
}
