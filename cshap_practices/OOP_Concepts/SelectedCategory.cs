



class SelectedCategory : AllCategory
{
    public string category;
    public override void Name(string barcode, string productionId)
    {
     category = $"Barcode: {barcode}, Production ID: {productionId}";
    }
    /*
    public override string ToString()
    {
        return $"SelectedCategory: {category}";
    }
    */
    public string GetCategory()
    { return category ; }
}