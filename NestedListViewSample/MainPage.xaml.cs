namespace NestedListViewSample
{
    /// <summary>
    /// The landing page that provides navigation to all sample views.
    /// </summary>
    public partial class MainPage : ContentPage
    {
        /// <summary>
        /// Initializes the main page and its XAML components.
        /// </summary>
        public MainPage()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Navigates to the <see cref="VerticalListView"/> page.
        /// </summary>
        private void VerticalNestedListView_Clicked(object sender, EventArgs e)

        {
            Navigation.PushAsync(new VerticalListView());
        }

        /// <summary>
        /// Navigates to the <see cref="HorizontalListView"/> page.
        /// </summary>
        private void HorizontalNestedListView_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new HorizontalListView());
        }

        /// <summary>
        /// Navigates to the <see cref="GroupHeaders"/> page.
        /// </summary>
        private void GroupHeaders_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new GroupHeaders());
        }

        /// <summary>
        /// Navigates to the <see cref="ExpandableView"/> page.
        /// </summary>
        private void ExpandableListView_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ExpandableView());
        }

        /// <summary>
        /// Navigates to the <see cref="TemplatePage"/> page.
        /// </summary>
        private void TemplatesPage_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new TemplatePage());
        }

    }
}
