namespace Exercise002
{
    public class Student : IComparable<Student>
    {
        public string Name { get; }

        public Student(string name)
        {
            this.Name = name;
        }

        public override string ToString()
        {
            return this.Name;
        }

        public int CompareTo(Student other)
        {
            if (other == null)
            {
                return 1;
            }

            return this.Name.CompareTo(other.Name);
        }
    }
}