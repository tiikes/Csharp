namespace Exercise007
{
    public interface IMovable
    {
        void Move(int dx, int dy);
    }
    public class Organism : IMovable
{
    private int x;
    private int y;

    public Organism(int x, int y)
    {
        this.x = x;
        this.y = y;
    }

    public override string ToString()
    {
        return $"x: {x}; y: {y}";
    }

    public void Move(int dx, int dy)
    {
        x += dx;
        y += dy;
    }
}

public class Herd : IMovable
{
    private List<IMovable> members;

    public Herd()
    {
        members = new List<IMovable>();
    }

    public override string ToString()
    {
        string result = "";
        foreach (var member in members)
        {
            result += member.ToString() + Environment.NewLine;
        }
        return result;
    }

    public void AddToHerd(IMovable movable)
    {
        members.Add(movable);
    }

    public void Move(int dx, int dy)
    {
        foreach (var member in members)
        {
            member.Move(dx, dy);
        }
    }
}

}