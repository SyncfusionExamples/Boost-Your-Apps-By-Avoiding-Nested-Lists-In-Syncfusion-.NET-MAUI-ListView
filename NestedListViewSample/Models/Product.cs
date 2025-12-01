using System.Collections.ObjectModel;
namespace NestedListViewSample;

/// <summary>
/// Represents a product with display name, price, and its category label (for grouping).
/// </summary>
public sealed class Product
{
    /// <summary>
    /// Product name (non-null for stable bindings).
    /// </summary>
    public string Name { get; set; } = string.Empty;

    /// <summary>
    /// Product price.
    /// </summary>
    public decimal Price { get; set; }

    /// <summary>
    /// Category label used for grouping in SfListView.
    /// </summary>
    public string CategoryName { get; set; } = string.Empty;
}

/// <summary>
/// Represents a category containing a list of products.
/// </summary>
public sealed class Category
{
    /// <summary>
    /// Category name (non-null for stable bindings).
    /// </summary>
    public string Name { get; set; } = string.Empty;

    /// <summary>
    /// Products under this category.
    /// </summary>
    public ObservableCollection<Product> Products { get; } = new();
}