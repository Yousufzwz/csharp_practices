

public abstract class AllCollection
{
    protected abstract int Amount { get; set; }
    public abstract void SelectedItems(string catagory1, string category2);

    public AllCollection(int amount)
    {
      Amount = amount;
    }

    
}