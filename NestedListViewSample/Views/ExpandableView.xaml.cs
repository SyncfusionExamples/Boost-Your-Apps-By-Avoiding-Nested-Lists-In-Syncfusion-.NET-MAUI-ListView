namespace NestedListViewSample
{
    public partial class ExpandableView : ContentPage
    {
        /// <summary>
        /// Initializes the page and its XAML components.
        /// </summary>
        public ExpandableView()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Handles taps on a category header and toggles its IsExpanded state
        /// to show or hide the associated product list.
        /// </summary>
        /// <param name="sender">The header Grid that was tapped.</param>
        /// <param name="e">Tap event arguments.</param>
        private void OnHeaderTapped(object sender, TappedEventArgs e)
        {
            if (sender is View v && v.BindingContext is Category cat)
            {
                cat.IsExpanded = !cat.IsExpanded;
            }
        }
    }
}
