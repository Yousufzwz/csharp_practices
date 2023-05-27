

internal class Product2 :ProductManager
{
    public string Name { get; set; }
    public int Barcode { get; set; }
    public Product2(string name, int quality)
    {
        Name = name;
        Barcode = quality;
    }



}