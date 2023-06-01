

public abstract class Customers
{
    public int ShoppingBudget { get; set; }
    public int Cost { get; set; }
    public string Name { get; set; }



    public Customers(string name, int budget)
    {
        ShoppingBudget = budget;
        Name = name;    
    }
    public Customers(int cost)
    {
        Cost = cost;
    }

    public Customers() { }
}