using System.Collections.ObjectModel;

namespace NestedListViewSample;

/// <summary>
/// Provides catalog data for the UI, including category-wise products and a flattened, category-tagged product list for grouping scenarios.
/// </summary>
public class CatalogViewModel
{
    /// <summary>
    /// Gets the product categories, each containing its own product collection.
    /// </summary>
    public ObservableCollection<Category> Categories { get; }

    /// <summary>
    /// Gets a flattened list of products where each product carries its category name.
    /// </summary>
    public ObservableCollection<Product> GroupedProducts { get; }

    /// <summary>
    /// Initializes the catalog with sample data and derives the flattened grouped list.
    /// </summary>
    public CatalogViewModel()
    {
        Categories = new ObservableCollection<Category>
        {
            new Category
            {
                Name = "Featured",
                Products =
                {
                    new Product { Name = "Lamp", Price = 49.99m },
                    new Product { Name = "Chair", Price = 129.50m },
                    new Product { Name = "Table", Price = 299.00m },
                    new Product { Name = "Sofa",  Price = 799.00m },
                    new Product { Name = "Bookshelf", Price = 199.00m },
                    new Product { Name = "Rug", Price = 89.00m },
                    new Product { Name = "Floor Lamp", Price = 79.99m },
                    new Product { Name = "Armchair", Price = 229.00m },
                    new Product { Name = "Coffee Table", Price = 159.00m },
                    new Product { Name = "TV Stand", Price = 189.00m },
                    new Product { Name = "Wall Shelf", Price = 39.00m },
                    new Product { Name = "Side Table", Price = 89.00m },
                    new Product { Name = "Console Table", Price = 179.00m },
                    new Product { Name = "Ottoman", Price = 99.00m },
                    new Product { Name = "Bed Frame", Price = 499.00m },
                    new Product { Name = "Nightstand", Price = 79.00m },
                    new Product { Name = "Dresser", Price = 349.00m },
                    new Product { Name = "Mirror", Price = 69.00m },
                }
            },
            new Category
            {
                Name = "New Arrivals",
                Products =
                {
                    new Product { Name = "Sofa", Price = 799.00m },
                    new Product { Name = "Bookshelf", Price = 199.00m },
                    new Product { Name = "Rug", Price = 89.00m },
                    new Product { Name = "Vase", Price = 39.00m },
                    new Product { Name = "Accent Chair", Price = 219.00m },
                    new Product { Name = "Pendant Light", Price = 149.00m },
                    new Product { Name = "Bar Stool", Price = 99.00m },
                    new Product { Name = "Dining Table", Price = 599.00m },
                    new Product { Name = "Dining Chair", Price = 129.00m },
                    new Product { Name = "Bookcase", Price = 249.00m },
                    new Product { Name = "Throw Blanket", Price = 29.00m },
                    new Product { Name = "Cushion Set", Price = 39.00m },
                    new Product { Name = "Planter", Price = 24.00m },
                    new Product { Name = "Desk", Price = 279.00m },
                    new Product { Name = "Office Chair", Price = 189.00m },
                }
            },
            new Category
            {
                Name = "On Sale",
                Products =
                {
                    new Product { Name = "Desk", Price = 249.00m },
                    new Product { Name = "Stool", Price = 59.00m },
                    new Product { Name = "Bookshelf (Small)", Price = 149.00m },
                    new Product { Name = "End Table", Price = 69.00m },
                    new Product { Name = "Table Lamp", Price = 29.99m },
                    new Product { Name = "Recliner", Price = 399.00m },
                    new Product { Name = "Sectional Sofa", Price = 999.00m },
                    new Product { Name = "Hall Tree", Price = 179.00m },
                    new Product { Name = "Kitchen Cart", Price = 139.00m },
                    new Product { Name = "Shelf Brackets (Set)", Price = 19.00m },
                    new Product { Name = "Storage Bench", Price = 129.00m },
                    new Product { Name = "Lamp Shade", Price = 14.99m },
                    new Product { Name = "Throw Pillow", Price = 12.99m },
                    new Product { Name = "Wall Art", Price = 39.00m },
                    new Product { Name = "Desk Organizer", Price = 17.99m },
                    new Product { Name = "Coat Rack", Price = 49.00m },
                }
            }
        };

        // Build a flat list: a header product per category followed by its items
        var flat = new List<Product>();
        foreach (var cat in Categories)
        {
            flat.Add(new Product { CategoryName = cat.Name, IsHeader = true });
            foreach (var p in cat.Products)
            {
                flat.Add(new Product
                {
                    Name = p.Name,
                    Price = p.Price,
                    CategoryName = cat.Name
                });
            }
        }
        GroupedProducts = new ObservableCollection<Product>(flat);
    }
}
