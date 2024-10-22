namespace Exercise004
{
  public abstract class Box
  {

    public abstract void Add(Item item);
    public abstract bool IsInBox(Item item);
  }
public class BoxWithMaxWeight : Box
    {
        private int capacity;
        private List<Item> items;

        public BoxWithMaxWeight(int capacity)
        {
            this.capacity = capacity;
            this.items = new List<Item>();
        }

        public override void Add(Item item)
        {
            if (items.Sum(i => i.weight) + item.weight <= capacity)
            {
                items.Add(item);
            }
        }

        public override bool IsInBox(Item item)
        {
            return items.Contains(item);
        }
    }

    public class OneItemBox : Box
    {
        private Item item;

        public override void Add(Item item)
        {
            if (this.item == null)
            {
                this.item = item;
            }
        }

        public override bool IsInBox(Item item)
        {
            return this.item != null && this.item.Equals(item);
        }
    }

    public class MisplacingBox : Box
    {
        public override void Add(Item item)
        {
            // Adding to the box always succeeds
        }

        public override bool IsInBox(Item item)
        {
            return false;
        }
    }

}
