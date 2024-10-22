namespace Exercise004
{
    public class Item
    {

        public string name { get; set; }
        public int weight { get; set; }
        public Item(string name, int weight)
        {
            this.name = name;
            this.weight = weight;
        }

        public Item(string name) : this(name, 0)
        {
        }
        
        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            return name == ((Item)obj).name;
        }

        public override int GetHashCode()
        {
            return name.GetHashCode();
        }
    }
}