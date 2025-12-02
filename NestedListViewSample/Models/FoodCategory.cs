using System.Collections.ObjectModel;
namespace NestedListViewSample;

/// <summary>
/// Represents a food category that can be expanded/collapsed in the UI.
/// </summary>
public sealed class FoodCategory : BindableObject
{
    /// <summary>
    /// Category title shown in the UI.
    /// </summary>
    public string Title { get; }

    /// <summary>
    /// Items that belong to this category.
    /// </summary>
    public ObservableCollection<FoodItem> Items { get; }

    private bool isExpanded;

    /// <summary>
    /// Indicates whether the category is expanded in the UI.
    /// </summary>
    public bool IsExpanded
    {
        get => isExpanded;
        set
        {
            if (isExpanded == value)
                return;
            isExpanded = value;
            OnPropertyChanged();
        }
    }

    /// <summary>
    /// Create a category with a title and its items.
    /// </summary>
    public FoodCategory(string title, ObservableCollection<FoodItem> items)
    {
        Title = title ?? throw new ArgumentNullException(nameof(title));
        Items = items ?? new ObservableCollection<FoodItem>();
    }
}

/// <summary>
/// Represents a single food item.
/// </summary>
public sealed class FoodItem
{
    /// <summary>
    /// Display name of the food item.
    /// </summary>
    public string Name { get; }

    /// <summary>
    /// Creates a food item with a display name.
    /// </summary>
    /// <param name="name">Display name of the item.</param>
    /// <exception cref="ArgumentException">Thrown when <paramref name="name"/> is null or whitespace.</exception>
    public FoodItem(string name)
    {
        if (string.IsNullOrWhiteSpace(name))
            throw new ArgumentException("Name cannot be null or whitespace.", nameof(name));
        Name = name;
    }
}