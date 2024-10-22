namespace Exercise002
{
    public class Teacher : Person
    {
        public int salary { get; set; }
        public Teacher(string personName, string PersonAddress, int salary) : base(personName, PersonAddress)
        {
            this.salary = salary;
        }
 
        public override string ToString()
        {
            return base.ToString() + " salary " + this.salary + " per month";
        }
    }
}