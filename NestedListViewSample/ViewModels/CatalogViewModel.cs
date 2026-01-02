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
                    new Product { Name = "Lamp", Price = 49.99m, Image = "lamp.png" },
                    new Product { Name = "Chair", Price = 129.50m, Image = "chair.png" },
                    new Product { Name = "Table", Price = 299.00m, Image = "table.png" },
                    new Product { Name = "Sofa",  Price = 799.00m, Image = "sofa.png" },
                    new Product { Name = "Bookshelf", Price = 199.00m , Image = "bookshelf.png"},
                    new Product { Name = "Rug", Price = 89.00m , Image = "rug.png"},
                    new Product { Name = "Floor Lamp", Price = 79.99m , Image = "floorlamp.png"},
                    new Product { Name = "Armchair", Price = 229.00m , Image = "armchair.png"},
                    new Product { Name = "Coffee Table", Price = 159.00m , Image = "coffeetable.png"},
                    new Product { Name = "TV Stand", Price = 189.00m , Image = "tvstand.png"},
                    new Product { Name = "Wall Shelf", Price = 39.00m , Image = "wallshelf.png"},
                    new Product { Name = "Side Table", Price = 89.00m , Image = "sidetable.png"},
                    new Product { Name = "Console Table", Price = 179.00m , Image = "consoletable.png"},
                    new Product { Name = "Ottoman", Price = 99.00m , Image = "ottoman.png"},
                    new Product { Name = "Bed Frame", Price = 499.00m , Image = "bedframe.png"},
                    new Product { Name = "Nightstand", Price = 79.00m , Image = "nightstand.png"},
                    new Product { Name = "Dresser", Price = 349.00m , Image = "dresser.png"},
                    new Product { Name = "Mirror", Price = 69.00m , Image = "mirror.png"},
                }
            },
            new Category
            {
                Name = "New Arrivals",
                Products =
                {
                    new Product { Name = "Sofa", Price = 799.00m , Image = "sofa.png"},
                    new Product { Name = "Bookshelf", Price = 199.00m , Image = "bookshelf.png"},
                    new Product { Name = "Rug", Price = 89.00m , Image = "rug.png"},
                    new Product { Name = "Vase", Price = 39.00m , Image = "vase.png"},
                    new Product { Name = "Accent Chair", Price = 219.00m , Image = "accentchair.png"},
                    new Product { Name = "Pendant Light", Price = 149.00m , Image = "pendantlight.png"},
                    new Product { Name = "Bar Stool", Price = 99.00m , Image = "barstool.png"},
                    new Product { Name = "Dining Table", Price = 599.00m , Image = "diningchair.png"},
                    new Product { Name = "Dining Chair", Price = 129.00m , Image = "diningchair.png"},
                    new Product { Name = "Bookcase", Price = 249.00m , Image = "bookcase.png"},
                    new Product { Name = "Throw Blanket", Price = 29.00m , Image = "throwblanket.png"},
                    new Product { Name = "Cushion Set", Price = 39.00m , Image = "cushion.png"},
                    new Product { Name = "Planter", Price = 24.00m , Image = "planter.png"},
                    new Product { Name = "Desk", Price = 279.00m , Image = "desk.png"},
                    new Product { Name = "Office Chair", Price = 189.00m , Image = "officechair.png"},
                }
            },
            new Category
            {
                Name = "On Sale",
                Products =
                {
                    new Product { Name = "Desk", Price = 249.00m , Image = "desk.png"},
                    new Product { Name = "Stool", Price = 59.00m , Image = "stool.png"},
                    new Product { Name = "Bookshelf (Small)", Price = 149.00m , Image = "bookshelf.png"},
                    new Product { Name = "End Table", Price = 69.00m , Image = "endtable.png"},
                    new Product { Name = "Table Lamp", Price = 29.99m , Image = "tablelamp.png"},
                    new Product { Name = "Recliner", Price = 399.00m , Image = "recliner.png"},
                    new Product { Name = "Sectional Sofa", Price = 999.00m , Image = "sectionalsofa.png"},
                    new Product { Name = "Hall Tree", Price = 179.00m , Image = "halltree.png"},
                    new Product { Name = "Kitchen Cart", Price = 139.00m , Image = "kitchencart.png"},
                    new Product { Name = "Shelf Brackets (Set)", Price = 19.00m , Image = "shelfbrackets.png"},
                    new Product { Name = "Storage Bench", Price = 129.00m , Image = "storagebench.png"},
                    new Product { Name = "Lamp Shade", Price = 14.99m , Image = "lampshade.png"},
                    new Product { Name = "Throw Pillow", Price = 12.99m , Image = "throwpillow.png"},
                    new Product { Name = "Wall Art", Price = 39.00m , Image = "wallart.png"},
                    new Product { Name = "Desk Organizer", Price = 17.99m , Image = "deskorganizer.png"},
                    new Product { Name = "Coat Rack", Price = 49.00m , Image = "coatrack.png"},
                }
            }
        };

        // Build a flat list: a header product per category followed by its items
        var flat = new List<Product>();
        foreach (var category in Categories)
        {
            flat.Add(new Product { CategoryName = category.Name, IsHeader = true });
            foreach (var product in category.Products)
            {
                flat.Add(new Product
                {
                    Name = product.Name,
                    Price = product.Price,
                    Image = product.Image,
                    CategoryName = category.Name
                });
            }
        }
        GroupedProducts = new ObservableCollection<Product>(flat);
    }
}
