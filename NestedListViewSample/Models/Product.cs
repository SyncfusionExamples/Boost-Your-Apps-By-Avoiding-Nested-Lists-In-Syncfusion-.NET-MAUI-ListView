using System.Collections.ObjectModel;

namespace NestedListViewSample;

public class Product
{
    public string Name { get; set; }
    public decimal Price { get; set; }

    public string CategoryName { get; set; }
}

public class Category
{
    public string Name { get; set; }
    public ObservableCollection<Product> Products { get; set; } = new();
}