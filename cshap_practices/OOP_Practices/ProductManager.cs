

public abstract class ProductManager
{
    public int Barcode { get; set; }
    public int Price { get; set; } 
    public string Name{ get; set; }
    public int ID { get; set; }


    public ProductManager(int bcode, int price, string name)
    {
        Barcode = bcode;
        Price = price;
    }

    public ProductManager(string name, int id)
    {
        Name = name;
        ID = id;
    }

    public ProductManager()
    {

    }


}