
internal class Product1:ProductManager

{
    public string Name { get; set; }
    public int  Barcode { get; set; }
    public Product1(string  name, int quality) 
    {
        Name = name;
        Barcode= quality;
    }
    public Product1()
    {

    }

}