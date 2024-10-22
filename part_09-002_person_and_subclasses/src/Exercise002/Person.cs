namespace Exercise002
{
    public class Person
    {
        public string personName;
        public string personAddress;
        public Person(string name, string address)
        {
            this.personName = name;
            this.personAddress = address;
        }

        public override string ToString()
        {
            return this.personName + ", " + this.personAddress;
        }
    }
}