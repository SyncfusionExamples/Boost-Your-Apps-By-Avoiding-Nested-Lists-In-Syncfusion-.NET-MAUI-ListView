using System.Collections.ObjectModel;

namespace NestedListViewSample;

public class FoodCategory : BindableObject
{
    public string Title { get; }
    public ObservableCollection<FoodItem> Items { get; }

    bool isExpanded;
    public bool IsExpanded
    {
        get => isExpanded;
        set { isExpanded = value; OnPropertyChanged(); }
    }

    public FoodCategory(string title, ObservableCollection<FoodItem> items)
    {
        Title = title;
        Items = items;
    }
}

public class FoodItem
{
    public string Name { get; }
    public FoodItem(string name) => Name = name;
}