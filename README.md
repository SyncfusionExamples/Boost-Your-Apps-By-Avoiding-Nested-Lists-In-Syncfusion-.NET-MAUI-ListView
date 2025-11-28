# alternatives-nested-listview-dotnet-maui
This demo shows Alternatives for Nested ListView in .NET MAUI

List View in .NET MAUI is ideal for virtualized, data-heavy UIs. Nesting one List View inside another, however, is a common anti-pattern that degrades performance. Nested List Views trigger extra measuring, compete for scroll gestures, and waste memory.
This article explains why those issues occur, how to redesign with grouping, DataTemplateSelector, and expand/collapse instead of nesting, and which Syncfusion® .NET MAUI List View tuning options deliver smooth, scalable scrolling.

## Why we need to Avoid Nested List View
1.	Nested List Views cause competing recyclers and extra measure/recycle work, which leads to stutter.
2.	Inner lists resizing during outer virtualization create re-entrant layouts that waste CPU and memory.
3.	Touch and scroll gestures compete between parent and child lists, causing unpredictable scrolling.
4.	Keyboard focus and accessibility navigation become confusing.
5.	Use one virtualized list per scroll direction and compose content within it. 

## Alternatives for Nested List View
A)	Grouping: Use a single List View and group items by a field such as category. Show a header for each group. You keep one scroll and smooth virtualization while users still see clear sections.

# XAML (List View with grouping and headers):

<!-- Grouped List View with sticky headers (details in GitHub demo) -->
<sfListView:SfListView ItemsSource="{Binding GroupedProducts}"
                       IsStickyGroupHeader="True"
                       SelectionMode="None">
  <!-- sfListView:SfListView.DataSource with sfData:GroupDescriptor -->
  <!-- GroupHeaderTemplate: shows {Binding Key} -->
  <!-- ItemTemplate: shows product fields -->
</sfListView:SfListView>

# Model:

public class Product
{
    public string Name { get; set; }
    public decimal Price { get; set; }
    public string CategoryName { get; set; }
} 

B)	Single List with Expand/Collapse: Use one list and let each parent row toggle its details in place. Tap to expand and tap again to collapse. Users stay in context without jumping into a nested list.

# XAML:

<!-- Expandable rows (details in GitHub demo) -->
<sfListView:SfListView ItemsSource="{Binding Categories}" SelectionMode="None">
  <!-- ItemTemplate:
       - Header row with tap gesture or command
       - Divider line
       - Child items in a BindableLayout shown when IsExpanded -->
</sfListView:SfListView>

# Code‑behind / View Model 

•	Toggle IsExpanded on tap or via a Command.
•	Bind child items to a simple template.
•	See the GitHub demo for the complete sample.


 
C)	Composite Item Template: For mixed row types Use a DataTemplateSelector to pick templates at runtime. Render posts, ads, dividers, or mini galleries in one List View. You retain one virtualization path and add new row types easily. 

# XAML:

<ContentPage.Resources>
  <!-- ParentTemplate and ChildTemplate -->
  <!-- RowTemplateSelector with ParentTemplate/ChildTemplate -->
</ContentPage.Resources>

<sfListView:SfListView ItemsSource="{Binding Rows}"
                       ItemTemplate="{StaticResource RowTemplateSelector}"
                       SelectionMode="None" />

# Model and Selector (Structure):

public enum RowKind { Parent, Child }
public class Row { public RowKind Kind { get; set; } public string Text { get; set; } }

public class RowTemplateSelector : DataTemplateSelector
{
  public DataTemplate ParentTemplate { get; set; }
  public DataTemplate ChildTemplate { get; set; }
  protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
    => ((Row)item).Kind == RowKind.Parent ? ParentTemplate : ChildTemplate;
}
                                                    
D) Orientation patterns
1. Horizontal List View inside a Vertical List View: Add a lightweight horizontal strip (fixed height, non-virtualized) within a vertical feed. The outer list remains the only scroll owner.

<!-- Vertical List View with a compact horizontal strip per section -->
<sfListView:SfListView ItemsSource="{Binding Categories}">
  <sfListView:SfListView.ItemTemplate>
    <DataTemplate>
      <VerticalStackLayout>
        <Label Text="{Binding Name}" FontAttributes="Bold" />
        <!-- Inner horizontal strip: fixed HeightRequest, simple item template -->
        <sfListView:SfListView ItemsSource="{Binding Products}" Orientation="Horizontal" HeightRequest="120">
          <!-- Simple item template -->
        </sfListView:SfListView>
      </VerticalStackLayout>
    </DataTemplate>
  </sfListView:SfListView.ItemTemplate>
</sfListView:SfListView>
 

2. Vertical List View inside another Vertical List View: If required, disable inner scrolling by giving the inner list an exact height. Only the outer list should scroll. Keep inner templates light and item counts bounded.

# XAML:
<!-- Vertical inside vertical: fix inner height; outer list owns scrolling -->
<sfListView:SfListView ItemsSource="{Binding Categories}">
  <sfListView:SfListView.ItemTemplate>
    <DataTemplate>
      <VerticalStackLayout>
        <Label Text="{Binding Name}" FontAttributes="Bold" />
        <sfListView:SfListView ItemsSource="{Binding Products}"
                                                         IsScrollingEnabled="False"
                                                        HeightRequest="{Binding Products.Count, Converter={StaticResource MultiplyConverter}, ConverterParameter=72}">
          <!-- Lightweight item template -->
        </sfListView:SfListView>
      </VerticalStackLayout>
    </DataTemplate>
  </sfListView:SfListView.ItemTemplate>
</sfListView:SfListView>
 

## Syncfusion .NET MAUI List View tuning tips

1.	ItemSize: Set a fixed size for uniform items to skip per-item measurement.
2.	QueryItemSize: Use when items vary in height to measure efficiently.
3.	Incremental loading: Load items on demand to keep memory and UI responsive.
4.	Template hygiene: Keep item templates lightweight. Size and cache images explicitly.

## Key Takeaways

1.	Do not stack a vertical list inside another vertical list that scrolls. Keep one scroller and flatten the data.
2.	Build with composition: use grouping, a DataTemplateSelector, expand/collapse, and lightweight horizontal scrollers.
3.	Tune Syncfusion® .NET MAUI List View for speed: set ItemSize (or use QueryItemSize), enable incremental loading, and keep images sized/cached.
4.	If you need a horizontal strip inside a vertical feed, fix its height and skip inner virtualization so only the outer list does the heavy lifting.