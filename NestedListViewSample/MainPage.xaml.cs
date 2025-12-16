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
        /// Navigates to the VerticalListView sample (vertical list inside a vertical list view).
        /// </summary>
        private void Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new VerticalListView());
        }

        /// <summary>
        /// Navigates to the HorizontalListView sample (horizontal list inside a vertical list view).
        /// </summary>
        private void Button_Clicked_1(object sender, EventArgs e)
        {
            Navigation.PushAsync(new HorizontalListView());
        }

        /// <summary>
        /// Navigates to the GroupHeaders sample (single list view with sticky group headers).
        /// </summary>
        private void Button_Clicked_2(object sender, EventArgs e)
        {
            Navigation.PushAsync(new GroupHeaders());
        }

        /// <summary>
        /// Navigates to the ExpandableView sample (category expand/collapse using a single view model).
        /// </summary>
        private void Button_Clicked_3(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ExpandableView());
        }

        /// <summary>
        /// Navigates to the TemplatePage sample (template selector with header and item templates).
        /// </summary>
        private void Button_Clicked_4(object sender, EventArgs e)
        {
            Navigation.PushAsync(new TemplatePage());
        }
    }
}
