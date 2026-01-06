using Syncfusion.Maui.DataSource;
using Syncfusion.Maui.ListView;

namespace NestedListViewSample;

public partial class GroupHeaders : ContentPage
{
	public GroupHeaders()
	{
		InitializeComponent();

        // Resolve the list view by name and apply filter to remove header placeholders
        var list = this.FindByName<SfListView>("productsListView");
        if (list?.DataSource is DataSource ds)
        {
            ds.Filter = FilterProducts;
            ds.RefreshFilter();
        }
    }

    private bool FilterProducts(object obj)
    {
        return obj is Product product && !product.IsHeader;
    }
}
