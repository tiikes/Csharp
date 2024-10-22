namespace Exercise002
{
    public class Student : Person
    {
        public int credits { get; set; }
        public Student(string personName, string personAddress) : base(personName, personAddress)
        {
            this.credits = 0;
        }
 
        public void Study()
        {
            this.credits++;
        }
 
        public override string ToString()
        {
            return base.ToString() + " credits: " + this.credits;
        }
    }
}