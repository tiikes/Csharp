namespace Exercise006
{
    using System;
    public class SimpleDate
    {
        private int day;
        private int month;
        private int year;
 
        public SimpleDate(int day, int month, int year)
        {
            this.day = day;
            this.month = month;
            this.year = year;
        }
 
        public override string ToString()
        {
            return this.day + "." + this.month + "." + this.year;
        }
 
        public bool Earlier(SimpleDate compared)
        {
            if (this.year < compared.year)
            {
                return true;
            }
            if (this.year == compared.year && this.month < compared.month)
            {
                return true;
            }
            if (this.year == compared.year && this.month == compared.month &&
                this.day < compared.day)
            {
                return true;
            }
            return false;
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
 
 
            SimpleDate comparedDate = (SimpleDate)compared;
 
 
            return this.day == comparedDate.day &&
                this.month == comparedDate.month &&
                this.year == comparedDate.year;
        }
 
        public override int GetHashCode()
        {
            return HashCode.Combine(this.day, this.month, this.year);
        }
    }
}
 
