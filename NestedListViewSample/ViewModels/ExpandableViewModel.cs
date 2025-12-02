using System.Collections.ObjectModel;
namespace NestedListViewSample;

/// <summary>
/// View model that exposes expandable categories with their items for a single SfListView.
/// </summary>
/// <remarks>
/// Each <see cref="FoodCategory"/> can be expanded/collapsed in the UI to show its <see cref="FoodCategory.Items"/>.
/// Intended for an expandable-list pattern without nesting ListViews.
/// </remarks>
public class ExpandableViewModel
{
    /// <summary>
    /// Seed data of food categories and their items for display in a single SfListView.
    /// </summary>
    public ObservableCollection<FoodCategory> Categories { get; } = new()
    {
        new FoodCategory("Fruits", new() {  new FoodItem("Apple"), 
                                            new FoodItem("Banana"), 
                                            new FoodItem("Mango"), 
                                            new FoodItem("Pine Apple"), 
                                            new FoodItem("Jack fruit"), 
                                            new FoodItem("Strawberry ") }),

        new FoodCategory("Veggies", new() { new FoodItem("Carrot"), 
                                            new FoodItem("Broccoli"), 
                                            new FoodItem("Beetroot"), 
                                            new FoodItem("Spinach"), 
                                            new FoodItem("Tomato"), 
                                            new FoodItem("Cucumber") }),
    };
}