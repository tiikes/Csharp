namespace Exercise002
{
    using System;
    using System.Collections.Generic;

    public class LotteryRow
    {
        public List<int> numbers { get; set; }

        public LotteryRow()
        {
            this.RandomizeNumbers();
        }
        public bool ContainsNumber(int number)
        {
            return this.numbers.Contains(number);
        }
        public void RandomizeNumbers()
        {
            this.numbers = new List<int>();
            Random random = new Random();
            while (this.numbers.Count < 7)
            {
                int randomNumber = random.Next(1, 41);
                if (!this.ContainsNumber(randomNumber))
                {
                    this.numbers.Add(randomNumber);
                }
            }
            this.numbers.Sort();
        }

    }
}