namespace NestedListViewSample
{
    /// <summary>
    /// Selects between header and item templates for Product rows using Product.IsHeader flag.
    /// </summary>
    public sealed class ProductTemplateSelector : DataTemplateSelector
    {
        /// <summary>
        /// Template used for header rows (IsHeader = true).
        /// </summary>
        public DataTemplate? HeaderTemplate { get; set; }

        /// <summary>
        /// Template used for normal item rows.
        /// </summary>
        public DataTemplate? ItemTemplate { get; set; }

        /// <inheritdoc />
        protected override DataTemplate OnSelectTemplate(object? item, BindableObject container)
        {
            if (item is Product p && p.IsHeader)
            {
                return HeaderTemplate ?? ItemTemplate ?? new DataTemplate(() => new ContentView());
            }
            else
            {
                return ItemTemplate ?? HeaderTemplate ?? new DataTemplate(() => new ContentView());
            }
        }
    }
}