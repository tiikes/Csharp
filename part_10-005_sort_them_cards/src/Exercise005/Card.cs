namespace Exercise005
{
    using System;
    public class Card : IComparable<Card>
    {
        public int value { get; }
        public Suit suit { get; }

        public Card(int value, Suit suit)
        {
            this.value = value;
            this.suit = suit;
        }

        public override string ToString()
        {
            string valueString;
            switch (value)
            {
                case 11:
                    valueString = "J";
                    break;
                case 12:
                    valueString = "Q";
                    break;
                case 13:
                    valueString = "K";
                    break;
                case 14:
                    valueString = "A";
                    break;
                default:
                    valueString = value.ToString();
                    break;
            }
            return suit + " " + valueString;
        }

        public int CompareTo(Card another)
        {
            int valueComparison = value.CompareTo(another.value);
            if (valueComparison == 0)
            {
                return suit.CompareTo(another.suit);
            }
            return valueComparison;
        }

        public override bool Equals(object compared)
        {
            if (this == compared)
            {
                return true;
            }
            if ((compared == null) || !this.GetType().Equals(compared.GetType()))
            {
                return false;
            }
            else
            {
                Card comparedCard = (Card)compared;
                return this.value == comparedCard.value && this.suit == comparedCard.suit;
            }
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(this.value, this.suit.GetHashCode());
        }

    }
}