using Exercise005;
        public class Hand : IComparable<Hand>
        {
            private List<Card> cards = new List<Card>();

            public void Add(Card card)
            {
                if (!cards.Contains(card))
                {
                    cards.Add(card);
                }
            }

            public void Print()
            {
                foreach (var card in cards)
                {
                    Console.WriteLine(card);
                }
            }

            public void Sort()
            {
                cards.Sort();
            }

            public int CompareTo(Hand other)
            {
                int sumThis = cards.Sum(card => card.value);
                int sumOther = other.cards.Sum(card => card.value);

                return sumThis.CompareTo(sumOther);
            }
        }