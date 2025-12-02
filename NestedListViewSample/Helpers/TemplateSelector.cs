namespace NestedListViewSample
{
    /// <summary>
    /// Selects a DataTemplate for heterogeneous rows at runtime.
    /// Returns <see cref="ParentTemplate"/> for parent rows and <see cref="ChildTemplate"/> for child rows.
    /// Falls back to <see cref="ChildTemplate"/> when the kind is unknown or item is null.
    /// </summary>
    public class RowTemplateSelector : DataTemplateSelector
    {
        /// <summary>
        /// Template used for parent rows.
        /// </summary>
        public DataTemplate ParentTemplate { get; set; }

        /// <summary>
        /// Template used for child rows.
        /// </summary>
        public DataTemplate ChildTemplate { get; set; }

        /// <summary>
        /// Chooses the template based on <see cref="Row.Kind"/>.
        /// </summary>
        /// <param name="item">The bound item (expected type: <see cref="Row"/>).</param>
        /// <param name="container">The bindable container.</param>
        /// <returns>The selected <see cref="DataTemplate"/>.</returns>
        protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
        {
            var card = (Row)item;
            return card.Kind switch
            {
                RowKind.Parent => ParentTemplate,
                RowKind.Child => ChildTemplate,
                _ => ChildTemplate
            };
        }
    }

}