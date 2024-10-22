namespace Exercise003
{
    using System;
    public class Book : IComparable<Book>
    {

        public string name { get; set; }
        public int ageRecommendation { get; set; }

        public Book(string name, int ageRecommendation)
        {
            this.name = name;
            this.ageRecommendation = ageRecommendation;
        }


        public override string ToString()
        {
            return this.name + " (recommended for " + this.ageRecommendation + " year-olds or older)";
        }


        public int CompareTo(Book other)
        {
            int ageComparison = this.ageRecommendation.CompareTo(other.ageRecommendation);

            if (ageComparison == 0)
            {
                return string.Compare(this.name, other.name, StringComparison.Ordinal);
            }

            return ageComparison;
        }

    }
}