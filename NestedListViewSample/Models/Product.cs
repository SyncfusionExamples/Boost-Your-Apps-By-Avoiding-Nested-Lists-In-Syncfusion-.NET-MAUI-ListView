using System.Collections.ObjectModel;
namespace NestedListViewSample;

/// <summary>
/// Represents a product with display name, price, and its category label.
/// </summary>
public class Product
{
    /// <summary>
    /// Name of the Product.
    /// </summary>
    public string Name { get; set; } = string.Empty;

    /// <summary>
    /// Price of the product.
    /// </summary>
    public decimal Price { get; set; }

    /// <summary>
    /// Image of the product.
    /// </summary>
    public string Image { get; set; }

    /// <summary>
    /// Category label used for grouping in SfListView.
    /// </summary>
    public string CategoryName { get; set; } = string.Empty;

    /// <summary>
    /// Indicates whether this instance represents a header row or not
    /// </summary>
    public bool IsHeader { get; set; }
}

/// <summary>
/// Represents a category containing a list of products. Includes IsExpanded for expand/collapse in ExpandableView.
/// </summary>
public class Category : BindableObject
{
    /// <summary>
    /// Name of the Category.
    /// </summary>
    public string Name { get; set; } = string.Empty;

    private bool isExpanded;
    /// <summary>
    /// Whether the category's items are visible.
    /// </summary>
    public bool IsExpanded
    {
        get => isExpanded;
        set
        {
            if (isExpanded == value) return;
            isExpanded = value;
            OnPropertyChanged();
        }
    }

    /// <summary>
    /// Products under this category.
    /// </summary>
    public ObservableCollection<Product> Products { get; } = new();
}
