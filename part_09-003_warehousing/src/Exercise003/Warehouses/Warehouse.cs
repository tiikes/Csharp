using System.Security.Cryptography.X509Certificates;

namespace Exercise003
{

    public class Warehouse
    {
        public int balance { get; set; }
        public int capacity { get; set; }

        public Warehouse(int capacity)
        {
            if (capacity > 0)
            {
                this.capacity = capacity;
            }
            else
            {
                this.capacity = 0;
            }

            this.balance = 0;
            
        }

        public int HowMuchSpaceLeft()
        {
            return this.capacity - this.balance;
        }

        public void AddToWarehouse(int amount)
        {
            if (amount < 0)
            {
                return;
            }
            if (amount <= HowMuchSpaceLeft())
            {
                this.balance += amount;
            }
            else
            {
                this.balance = this.capacity;
            }
        }

        public int TakeFromWarehouse(int amount)
        {
            if (amount < 0)
            {
                return 0;
            }
            if (amount > this.balance)
            {
                int allThatWeCan = this.balance;
                this.balance = 0;
                return allThatWeCan;
            }
            this.balance -= amount;
            return amount;
        }

        public override string ToString()
        {
            return "balance: " + this.balance + ", space left " + HowMuchSpaceLeft();
        }
    }
    public class ProductWarehouse : Warehouse
{
    public string productName;

    public ProductWarehouse(string productName, int capacity) : base(capacity)
    {
        this.productName = productName;
    }

    public override string ToString()
    {
        return $"{productName}: {base.ToString()}";
    }
}
public class ChangeHistory
{
    private List<int> history;

    public ChangeHistory()
    {
        this.history = new List<int>();
    }

    public void Add(int status)
    {
        this.history.Add(status);
    }

    public void Clear()
    {
        this.history.Clear();
    }

    public int MaxValue()
    {
        return this.history.Count > 0 ? this.history.Max() : 0;
    }

    public int MinValue()
    {
        return this.history.Count > 0 ? this.history.Min() : 0;
    }

    public override string ToString()
    {
        return $"Current: {this.history.LastOrDefault()} Min: {MinValue()} Max: {MaxValue()}";
    }
}
public class ProductWarehouseWithHistory : ProductWarehouse
{
    private ChangeHistory history;

    public ProductWarehouseWithHistory(string productName, int capacity, int initialBalance)
        : base(productName, capacity)
    {
        this.balance = initialBalance;
        this.history = new ChangeHistory();
        this.history.Add(initialBalance);
    }

    public string History()
    {
        return this.history.ToString();
    }

    new public void AddToWarehouse(int amount)
    {
        base.AddToWarehouse(amount);
        this.history.Add(this.balance);
    }

    new public int TakeFromWarehouse(int amount)
    {
        int takenAmount = base.TakeFromWarehouse(amount);
        this.history.Add(this.balance);
        return takenAmount;
    }
}
}
