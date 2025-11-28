namespace NestedListViewSample
{
    public partial class ExpandableView : ContentPage
    {
        public ExpandableView()
        {
            InitializeComponent();
        }

        void OnHeaderTapped(object sender, TappedEventArgs e)
        {
            if (sender is View v && v.BindingContext is FoodCategory cat)
                cat.IsExpanded = !cat.IsExpanded;
        }
    }
}