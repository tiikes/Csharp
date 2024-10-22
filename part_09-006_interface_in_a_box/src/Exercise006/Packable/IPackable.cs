namespace Exercise006
{
  public interface IPackable
  {
    int Weight();
  }
  public class Book : IPackable
{
    private string author;
    private string name;
    private int publicationYear;

    public Book(string author, string name, int publicationYear)
    {
        this.author = author;
        this.name = name;
        this.publicationYear = publicationYear;
    }

    public int Weight()
    {
        return 1;
    }

    public override string ToString()
    {
        return $"{author}: {name} ({publicationYear})";
    }
}

public class Furniture : IPackable
{
    private string type;
    private string color;
    private int weight;

    public Furniture(string type, string color, int weight)
    {
        this.type = type;
        this.color = color;
        this.weight = weight;
    }

    public int Weight()
    {
        return weight;
    }

    public override string ToString()
    {
        return $"{color} {type} - weight {weight} kg";
    }
}

public class Box : IPackable
{
    private int maxCapacity;
    private List<IPackable> items;

    public Box(int maxCapacity)
    {
        this.maxCapacity = maxCapacity;
        this.items = new List<IPackable>();
    }

    public void Add(IPackable item)
    {
        if (TotalWeight() + item.Weight() <= maxCapacity)
        {
            items.Add(item);
        }
    }

    public int Weight()
    {
        return TotalWeight();
    }

    private int TotalWeight()
    {
        int totalWeight = 0;
        foreach (var item in items)
        {
            totalWeight += item.Weight();
        }
        return totalWeight;
    }

    public override string ToString()
    {
        return $"{items.Count} items, total weight {TotalWeight()} kg";
    }
}
}