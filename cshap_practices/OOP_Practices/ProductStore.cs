
public class ProductStore
{
    private Product product;

    

    public ProductStore(Product product)
    {
        this.product = product;
    }

   
    public int Count { get;  set; }
    internal void AddProduct(Product added)
    {
        Count++;
    }

    
}